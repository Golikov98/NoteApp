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
        Project project = new Project();

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
            Note note = new Note();
            //Передаем данные в класс Note для проверки
            note.SetName(AddNameTextBox.Text);
            note.SetCreationTime(AddCreateDateTimePicker.Value);
            note.SetNoteText(AddTextNoteTextBox.Text);
            note.SetNoteCategory(AddCategoryComboBox.ToString());
            //Записываем объект note в список Notes
            project.Notes.Add(note);

            this.DialogResult = DialogResult.OK;
        }

        //TextBox названия создаваемой заметки
        private void AddNameTextBox_TextChanged(object sender, EventArgs e)
        {

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
    }
}
