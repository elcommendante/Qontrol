using System;
using System.Collections.Generic;
using System.Data;
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
using System.Data.SqlClient; // Sql Server load
using System.Windows.Forms;

namespace Qontrol
{
    /// <summary>
    /// Interaction logic for PageNotes.xaml
    /// </summary>
    public partial class PageNotes : Page
    {

        //DataTable tableNotes;
        private BindingSource bindingSource1 = new BindingSource();
        public PageNotes()
        {
            InitializeComponent();
            //Note note = new Note();
            //note.noteTitle = "Test Title";
            //note.noteMessage = "Test Message";


            //dataGridView.Items.Add(note);

        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Type code here to happen//
        }

        private void dataGridView_Loaded(object sender, RoutedEventArgs e)
        {
            Load_List();
        }


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
            bindingSource1.DataSource = tbl;
            dataGridView.DataContext = bindingSource1;

        }

        #endregion
    }
}
