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
    public partial class EditForm : Form
    {
        private Note _editNote;

        public Note EditNote
        {
            get
            {
                return _editNote;
            }
            set
            {
                _editNote = value;
                if (_editNote != null)
                {
                        EditNameTextBox.Text = _editNote.Name;
                        EditCategoryComboBox.Text = _editNote.NoteCategory;
                        EditNoteTextTextBox.Text = _editNote.NoteText;
                        EditFormEditDateDateTimePicker.Value = _editNote.ModifiedTime;                    
                }
            }
        }
        public EditForm()
        {
            InitializeComponent();

            //Передаем значения в ComboBox
            EditCategoryComboBox.Items.Add(NoteCategoryEnum.Documents);
            EditCategoryComboBox.Items.Add(NoteCategoryEnum.Finance);
            EditCategoryComboBox.Items.Add(NoteCategoryEnum.Work);
            EditCategoryComboBox.Items.Add(NoteCategoryEnum.People);
            EditCategoryComboBox.Items.Add(NoteCategoryEnum.HealthAndSports);
            EditCategoryComboBox.Items.Add(NoteCategoryEnum.Home);
            EditCategoryComboBox.Items.Add(NoteCategoryEnum.Other);           
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }

        private void EditNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string EditName = EditNameTextBox.Text;

                //Выполняем проверку на введенное количество символов
                if (EditName.Length >= 50)
                {
                    EditNameTextBox.BackColor = Color.LightSalmon;
                }
                else
                {
                    EditNameTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                this.Show();
            }
        }

        private void EditFormEditDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void EditCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void EditNoteTextTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditFormOkButton_Click(object sender, EventArgs e)
        {
            if (EditNameTextBox.TextLength <= 50)
            {
                DialogResult = DialogResult.OK;
                _editNote.Name = EditNameTextBox.Text;
                _editNote.ModifiedTime = DateTime.Now;
                _editNote.NoteCategory = EditCategoryComboBox.Text;
                _editNote.NoteText = EditNoteTextTextBox.Text;
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Длина имени заметки должна быть больше либо равна 50 символам!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();
            }
        }

        private void EditFormCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Действительно хотите отменить редактирование?", "Отмена", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK) { this.Close(); }
        }
    }
}
