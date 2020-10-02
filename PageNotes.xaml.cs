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

namespace Qontrol
{
    /// <summary>
    /// Interaction logic for PageNotes.xaml
    /// </summary>
    public partial class PageNotes : Page
    {

        DataTable tableNotes;
        public PageNotes()
        {
            InitializeComponent();
            Note note = new Note();
            note.noteTitle = "Test Title";
            note.noteMessage = "Test Message";


            dataGridView.Items.Add(note);

        }

        public class Note
        {
            public string noteTitle { get; set; }
            public string noteMessage { get; set; }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Type code here to happen//
        }


        private void BtnClickNewNote(object sender, RoutedEventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void btnClickSaveNote(object sender, RoutedEventArgs e)
        {
            Note newNote = new Note();
            newNote.noteTitle = txtTitle.Text;
            newNote.noteMessage = txtMessage.Text;

            dataGridView.Items.Add(newNote);

            //tableNotes.Rows.Add(txtTitle.Text, txtMessage.Text);
            //txtTitle.Clear();
            //txtMessage.Clear();
        }

        private void btnClickReadNote(object sender, RoutedEventArgs e)
        {
        }


    }
}
