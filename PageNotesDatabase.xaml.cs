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
            //Note newNote = new Note();
            //newNote.noteTitle = txtTitle.Text;
            //newNote.noteMessage = txtMessage.Text;

            //tableNotes.Rows.Add(txtTitle.Text, txtMessage.Text);
            //txtTitle.Clear();
            //txtMessage.Clear();
        }
        #endregion

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
    }
}
