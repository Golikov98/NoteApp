using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class HeadForm : Form
    {
        Note _note = new Note();
        Project project = new Project();
        private List<Note> _notes = new List<Note>();

        public HeadForm()
        {  
            InitializeComponent();
            Note note = new Note();

        }

        private void NoteApp_Load(object sender, EventArgs e)
        {
            
        }

        //Кнопка для создания заметки
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Переход на форму для создания заметки
            var form = new AddNote ();
            form.ShowDialog();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void HeadNoteCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void TitleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ModifiedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NoteTextTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
