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
    /// <summary>
    /// Форма создания заметки
    /// </summary>
    public partial class AddNote : Form
    {
        public Note _currentNote = new Note();

        public AddNote()
        {
            InitializeComponent();

            //Передаем значения в ComboBox
            AddCategoryComboBox.Items.Add(NoteCategoryEnum.Documents);
            AddCategoryComboBox.Items.Add(NoteCategoryEnum.Finance);
            AddCategoryComboBox.Items.Add(NoteCategoryEnum.Work);
            AddCategoryComboBox.Items.Add(NoteCategoryEnum.People);
            AddCategoryComboBox.Items.Add(NoteCategoryEnum.HealthAndSports);
            AddCategoryComboBox.Items.Add(NoteCategoryEnum.Home);
            AddCategoryComboBox.Items.Add(NoteCategoryEnum.Other);
           
            //Устанавливаем индекс значения по умолчанию в ComboBox
            AddCategoryComboBox.SelectedIndex = 6;
        }

        //Кнопка закрытия формы создания заметки
        private void AddCANCELButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопка, подтверждающая создание заметки 
        private void AddOKButton_Click(object sender, EventArgs e)
        {
            if (AddNameTextBox.TextLength <= 50)
            {
                this.DialogResult = DialogResult.OK;

                Note note = new Note();
                Project project = new Project();
                //Передаем данные в класс Note для проверки
                note.Name = AddNameTextBox.Text;
                note.CreationTime = DateTime.Now;
                note.NoteText = AddTextNoteTextBox.Text;
                note.NoteCategory = AddCategoryComboBox.Text;
                note.ModifiedTime = DateTime.MaxValue;

                //Передаем данные в абстрактный класс _currentNote
                _currentNote.Name = AddNameTextBox.Text;
                _currentNote.NoteText = AddTextNoteTextBox.Text;
                _currentNote.CreationTime = DateTime.Now;
                _currentNote.NoteCategory = AddCategoryComboBox.Text;
                _currentNote.ModifiedTime = DateTime.MaxValue;
            }
            else
            {
                DialogResult result = MessageBox.Show("Длина имени заметки должна быть больше либо равна 50 символам!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
            }
        }

        //TextBox названия создаваемой заметки
        private void AddNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string AddName = AddNameTextBox.Text;

            //Выполняем проверку на количество введенных символов
            if (AddName.Length >= 50)
            {
                AddNameTextBox.BackColor = Color.LightSalmon;
            }
            else
            {
                AddNameTextBox.BackColor = Color.White;
            }
        }

        //DateTimePicker времени создания заметки
        private void AddCreateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
          
        }

        //ComboBox категории создаваемой заметки
        private void AddCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //TextBox текста создаваемой заметки
        private void AddTextNoteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNote_Load(object sender, EventArgs e)
        {

        }
    }
}
