﻿using System;
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
    public partial class MainForm : Form
    {
        public Note _note;
        private Project project = new Project();
        private List<Note> _notes = new List<Note>();
        private static string DocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/NoteApp.txt";

        public MainForm()
        {  
            InitializeComponent();
            HeadNoteCategoryComboBox.Items.Add("New");
            HeadNoteCategoryComboBox.Items.Add("Old");
            HeadNoteCategoryComboBox.Items.Add(NoteCategoryEnum.Documents);
            HeadNoteCategoryComboBox.Items.Add(NoteCategoryEnum.Finance);
            HeadNoteCategoryComboBox.Items.Add(NoteCategoryEnum.Work);
            HeadNoteCategoryComboBox.Items.Add(NoteCategoryEnum.People);
            HeadNoteCategoryComboBox.Items.Add(NoteCategoryEnum.HealthAndSports);
            HeadNoteCategoryComboBox.Items.Add(NoteCategoryEnum.Home);
            HeadNoteCategoryComboBox.Items.Add(NoteCategoryEnum.Other);
            HeadNoteCategoryComboBox.Items.Add("All");
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

            //Проверка подтверждения с формы
            if (form.DialogResult == DialogResult.OK)
            { 
                //Записываем данные в локальные переменные
                var MainName = form._currentNote.Name;
                var MainCategory = form._currentNote.NoteCategory;
                var MainText = form._currentNote.NoteText;
                var MainCreationDate = form._currentNote.CreationTime;
                var MainModifiedDate = DateTime.Now;

                //Записываем в TitleListBox данные из MainName по индексу
                TitleListBox.Items.Add(MainName);

                //Записываем текущую заметку _currentNote в список _notes
                _notes.Add(form._currentNote);

                //Записываем текущую заметку _currentNote в список Notes
                project.Notes.Add(form._currentNote);

                ProjectManager.SaveToFIle();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void HeadNoteCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void TitleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var form = new AddNote();
                if (TitleListBox.SelectedIndex >= 0)
                {
                    //Создаем локальную переменную типа Note
                    Note _clicklist;

                    //Присваиваем переменной данные из списка по индексу
                    _clicklist = _notes[TitleListBox.SelectedIndex];

                    //Присваиваем полям значения из переменной списка
                    NameTextBox.Text = _clicklist.Name;
                    NoteTextTextBox.Text = _clicklist.NoteText;
                    HeadNoteCategoryComboBox.Text = _clicklist.NoteCategory;
                    CreateDateTimePicker.Value = _clicklist.CreationTime;

                }
            }
            catch
            {
                this.Show();
            }
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

        //Кнопка для удаления заметки
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Вызываем форму для удаления заметки
                DialogResult result = MessageBox.Show("Действительно хотите удалить заметку?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    //Получаем индекс текущей выбранной заметки
                    var selectedIndex = TitleListBox.SelectedIndex;
                    var selectedNote = project.Notes[selectedIndex];

                    //Удаляем данные по выбранному индексу
                    TitleListBox.Items.RemoveAt(selectedIndex);
                    project.Notes.RemoveAt(selectedIndex);

                    //Очищаем поля от записанных в них значений
                    NameTextBox.Clear();
                    NoteTextTextBox.Clear();
                    HeadNoteCategoryComboBox.Text = string.Empty;
                }
            }
            catch
            {
                DialogResult result = MessageBox.Show("Вы не выбрали заметку!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Show();
            }
        }

        //Кнопка для редактирования заметки
        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Получаем текущую выбранную заметку
                var selectedIndex = TitleListBox.SelectedIndex;
                var selectedNotes = project.Notes[selectedIndex];

                //Создаем форму
                var edit = new EditForm();

                //Передаем форме данные
                edit.EditNote = selectedNotes;

                //Отображаем форму для редактирования
                edit.ShowDialog();

                //Забираем измененные данные
                var updatedNote = edit.EditNote;

                //Удаляем старые данные по выбранному индексу и заменяем их на обновленные
                TitleListBox.Items.RemoveAt(selectedIndex);
                project.Notes.RemoveAt(selectedIndex);

                project.Notes.Insert(selectedIndex, updatedNote);

                //Присваиваем значения локальным переменным
                var MainName = edit.EditNote.Name;
                var MainCategory = edit.EditNote.NoteCategory;
                var MainText = edit.EditNote.NoteText;
                var MainModifiedDate = edit.EditNote.ModifiedTime;
                TitleListBox.Items.Insert(selectedIndex, MainName);

                //Передаем обновленные данные на элементы формы
                NameTextBox.Text = MainName;
                NoteTextTextBox.Text = MainText;
                HeadNoteCategoryComboBox.Text = MainCategory;
                ModifiedDateTimePicker.Value = MainModifiedDate;
            }
            catch
            {
                DialogResult result = MessageBox.Show("Вы не выбрали заметку!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Show();
            }

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void создатьНовуюЗаметкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Переход на форму для создания заметки
            var form = new AddNote();
            form.ShowDialog();

            //Проверка подтверждения с формы
            if (form.DialogResult == DialogResult.OK)
            {
                //Записываем данные в локальные переменные
                var MainName = form._currentNote.Name;
                var MainCategory = form._currentNote.NoteCategory;
                var MainText = form._currentNote.NoteText;
                var MainCreationDate = form._currentNote.CreationTime;
                var MainModifiedDate = DateTime.Now;

                //Записываем в TitleListBox данные из MainName по индексу
                TitleListBox.Items.Add(MainName);

                //Записываем текущую заметку _currentNote в список _notes
                _notes.Add(form._currentNote);

                //Записываем текущую заметку _currentNote в список Notes
                project.Notes.Add(form._currentNote);
            }
        }

        private void редактироватьТекущуюЗаметкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Получаем текущую выбранную заметку
                var selectedIndex = TitleListBox.SelectedIndex;
                var selectedNotes = project.Notes[selectedIndex];

                //Создаем форму
                var edit = new EditForm();

                //Передаем форме данные
                edit.EditNote = selectedNotes;

                //Отображаем форму для редактирования
                edit.ShowDialog();

                //Забираем измененные данные
                var updatedNote = edit.EditNote;

                //Удаляем старые данные по выбранному индексу и заменяем их на обновленные
                TitleListBox.Items.RemoveAt(selectedIndex);
                project.Notes.RemoveAt(selectedIndex);

                project.Notes.Insert(selectedIndex, updatedNote);

                //Присваиваем значения локальным переменным
                var MainName = edit.EditNote.Name;
                var MainCategory = edit.EditNote.NoteCategory;
                var MainText = edit.EditNote.NoteText;
                var MainModifiedDate = edit.EditNote.ModifiedTime;
                TitleListBox.Items.Insert(selectedIndex, MainName);

                //Передаем обновленные данные на элементы формы
                NameTextBox.Text = MainName;
                NoteTextTextBox.Text = MainText;
                HeadNoteCategoryComboBox.Text = MainCategory;
                ModifiedDateTimePicker.Value = MainModifiedDate;
            }
            catch
            {
                DialogResult result = MessageBox.Show("Вы не выбрали заметку!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Show();
            }
        }

        private void удалитьТекущуюЗаметкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Вызываем форму для удаления заметки
                DialogResult result = MessageBox.Show("Действительно хотите удалить заметку?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    //Получаем индекс текущей выбранной заметки
                    var selectedIndex = TitleListBox.SelectedIndex;
                    var selectedNote = project.Notes[selectedIndex];

                    //Удаляем данные по выбранному индексу
                    TitleListBox.Items.RemoveAt(selectedIndex);
                    project.Notes.RemoveAt(selectedIndex);

                    //Очищаем поля от записанных в них значений
                    NameTextBox.Clear();
                    NoteTextTextBox.Clear();
                    HeadNoteCategoryComboBox.Text = string.Empty;
                }
            }
            catch
            {
                DialogResult result = MessageBox.Show("Вы не выбрали заметку!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Show();
            }
        }

        private void оПрограммеF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about=new AboutForm();
            about.Show();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        //Обработчик на нажатие клавиши F1
        private void HeadForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.F1)
            {
                var about = new AboutForm();
                about.Show();
            }
        }
    }
}
