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
    public partial class MainForm : Form
    {
        private Project _project = new Project();

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

            HeadNoteCategoryComboBox.SelectedIndex = 9;
        }

        private void NoteApp_Load(object sender, EventArgs e)
        {
            //Записываем данные из файла в переменную "_project" при помощи метода LoadFromFile
            _project = ProjectManager.LoadFromFile(@"C:\Users\Голиков Юрий\NoteApp.txt");

            //Проверяем значение переменной "_project"
            if (_project == null)
            {
                _project = new Project();
                _project.Notes = new List<Note>();
            }

            //Очищаем TitleListBox
            TitleListBox.Items.Clear();

            try
            {
                for (var NoteNumber = 0; NoteNumber < _project.Notes.Count; NoteNumber++)
                {
                    //Записываем данные из списка Notes в переменную "item"
                    var item = _project.Notes[NoteNumber];

                    //Записываем имя заметки из переменной "item" в TitleListBox
                    TitleListBox.Items.Add(item.Name);
                }
            }
            catch
            {

            }
        }

        //Кнопка для создания заметки
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddFunction();
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
                    _clicklist = _project.Notes[TitleListBox.SelectedIndex];

                    //Присваиваем полям значения из переменной списка
                    NameTextBox.Text = _clicklist.Name;
                    NoteTextTextBox.Text = _clicklist.NoteText;
                    CategoryTextBox.Text = _clicklist.NoteCategory;
                    CreateDateTimePicker.Value = _clicklist.CreationTime;
                    ModifiedDateTimePicker.Value = _clicklist.ModifiedTime;
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
            DeleteFunction();
        }

        //Кнопка для редактирования заметки
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditFunction();
        }

        //Поле "Редактировать" ToolStripMenu
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Значение "СоздатьНовуюЗаметку" в поле "Редактировать" ToolStripMenu
        private void createNewNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFunction();
        }

        //Значение "РедактироватьТекущуюЗаметку" в поле "Редактировать" ToolStripMenu
        private void editCurrentNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditFunction();
        }

        //Значение "УдалитьТекущуюЗаметку" в поле "Редактировать" ToolStripMenu
        private void deleteCurrentNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteFunction();
        }

        //Значение "О программе-F1" в поле "Справка" ToolStripMenu
        private void aboutF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about=new AboutForm();
            about.Show();
        }

        //Значение "Выйти" в поле "Файл" ToolStripMenu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        //Метод создающий заметку
        private void AddFunction()
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
                    var MainModifiedDate = form._currentNote.ModifiedTime;

                    //Записываем в TitleListBox данные из MainName по индексу
                    TitleListBox.Items.Add(MainName);

                    //Записываем текущую заметку _currentNote в список Notes
                    _project.Notes.Add(form._currentNote);

                    //Вызываем SaveToFile из класса ProjectManager
                    ProjectManager.SaveToFIle(_project, @"C:\Users\Голиков Юрий\NoteApp.txt");
                }      
        }

        //Метод, редактирующий заметку
        private void EditFunction()
        {
            try
            {
                //Получаем текущую выбранную заметку
                var selectedIndex = TitleListBox.SelectedIndex;
                var selectedNotes = _project.Notes[selectedIndex];

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
                _project.Notes.RemoveAt(selectedIndex);

                _project.Notes.Insert(selectedIndex, updatedNote);

                //Вызываем SaveToFile из класса ProjectManager
                ProjectManager.SaveToFIle(_project, @"C:\Users\Голиков Юрий\NoteApp.txt");

                //Присваиваем значения локальным переменным
                var MainName = edit.EditNote.Name;
                var MainCategory = edit.EditNote.NoteCategory;
                var MainText = edit.EditNote.NoteText;
                var MainModifiedDate = edit.EditNote.ModifiedTime;
                TitleListBox.Items.Insert(selectedIndex, MainName);

                if (edit.DialogResult == DialogResult.OK)
                {
                    //Передаем обновленные данные на элементы формы
                    NameTextBox.Text = MainName;
                    NoteTextTextBox.Text = MainText;
                    CategoryTextBox.Text = MainCategory;
                    ModifiedDateTimePicker.Value = MainModifiedDate;
                }
            }
            catch
           {
                DialogResult result = MessageBox.Show("Вы не выбрали заметку!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Show();
            }
        }

        //Метод, удаляющий заметку
        private void DeleteFunction()
        {
            try
            {
                //Вызываем форму для удаления заметки
                DialogResult result = MessageBox.Show("Действительно хотите удалить заметку?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    //Получаем индекс текущей выбранной заметки
                    var selectedIndex = TitleListBox.SelectedIndex;
                    var selectedNote = _project.Notes[selectedIndex];

                    //Удаляем данные по выбранному индексу
                    TitleListBox.Items.RemoveAt(selectedIndex);
                    _project.Notes.RemoveAt(selectedIndex);

                    //Вызываем SaveToFile из класса ProjectManager
                    ProjectManager.SaveToFIle(_project, @"C:\Users\Голиков Юрий\NoteApp.txt");

                    //Очищаем поля от записанных в них значений
                    NameTextBox.Clear();
                    NoteTextTextBox.Clear();
                    CategoryTextBox.Text = string.Empty;
                }
            }
            catch
            {
                DialogResult result = MessageBox.Show("Вы не выбрали заметку!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Show();
            }
        }
    }
}
