using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace Qontrol
{
    /// <summary>
    /// Interaction logic for PageNotesDatabase.xaml
    /// </summary>
    public partial class PageNotesDatabase : Page
    {
        public PageNotesDatabase()
        {
            InitializeComponent();
            Load_List();

        }
        public class Note
        {
            public string noteTitle { get; set; }
            public string noteMessage { get; set; }

        }
        #region Buttons
        private void BtnClickNewNote(object sender, RoutedEventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void btnClickReadNote(object sender, RoutedEventArgs e)
        {
        }
        private void btnClickSaveNote(object sender, RoutedEventArgs e)
        {
            addDBEntry();
        }
        private void btnClickDeleteNote(object sender, RoutedEventArgs e)
        {
            deleteDBEntry();
        }
        #endregion

        #region Methods

        private void Load_List()
        {
            // Load List
            string cn_string = Properties.Settings.Default.dbUserConnectionString;
            SqlConnection cn_connection = new SqlConnection(cn_string);


            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "SELECT * FROM tbl_Notes";

            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_Text, cn_connection);
            adapter.Fill(tbl);
            dataGrid.ItemsSource = tbl.DefaultView;
        }
        private void addDBEntry()
        {
            //creates connection
            string cn_string = Properties.Settings.Default.dbUserConnectionString;
            SqlConnection cn_connection = new SqlConnection(cn_string);
            //opens connection
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            // inserts new information to database from 
            string newNote = txtTitle.Text;
            string newMessage = txtMessage.Text;
            string sql_Text = "INSERT INTO tbl_Notes (NoteTitle,NoteMessage) Values('" + newNote + "','" + newMessage +"')";

            SqlCommand cmd = new SqlCommand(sql_Text, cn_connection);
            cmd.ExecuteNonQuery();

            Load_List();
            cn_connection.Close();
        }

        private void deleteDBEntry()
        {
            //creates connection
            string cn_string = Properties.Settings.Default.dbUserConnectionString;
            SqlConnection cn_connection = new SqlConnection(cn_string);
            //opens connection
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            DataRowView row = dataGrid.SelectedItem as DataRowView;
            if(row == null)
            {

                System.Windows.Forms.MessageBox.Show("Error, cannot delete null row!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string id = row["IDNotes"].ToString();
                string sql_Text = "DELETE FROM tbl_Notes WHERE (IDNotes = " + id + ")";
                SqlCommand cmd = new SqlCommand(sql_Text, cn_connection);
                cmd.ExecuteNonQuery();
                Load_List();
                cn_connection.Close();
            }
        }



        #endregion


    }

}
