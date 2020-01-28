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
        List<Note> list = new List<Note>();

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
            _project = ProjectManager.LoadFromFile(@"C:..\\NoteApp.txt");

            //Проверяем значение переменной "_project"
            if (_project == null)
            {
                _project = new Project();
                _project.Notes = new List<Note>();
                _project.CurrentNote = new Note();
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

                //Записываем данные из свойства CurrentNote в переменную "CurrentLoadNote"
                var CurrentLoadNote = _project.CurrentNote;

                NameTextBox.Text = CurrentLoadNote.Name;
                CategoryTextBox.Text = CurrentLoadNote.NoteCategory;
                NoteTextTextBox.Text = CurrentLoadNote.NoteText;
                CreateDateTimePicker.Value = CurrentLoadNote.CreationTime;
                ModifiedDateTimePicker.Value = CurrentLoadNote.ModifiedTime;

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
            if (HeadNoteCategoryComboBox.Text == "New")
            {
                TitleListBox.Items.Clear();
                _project.SortedModifiedTimeNew();
                for(var ForTimeNew = 0; ForTimeNew < _project.Notes.Count; ForTimeNew++)
                {
                    var Data = _project.Notes[ForTimeNew];
                    TitleListBox.Items.Add(Data.Name);
                }
            }
            else if (HeadNoteCategoryComboBox.Text == "Old")
            {
                TitleListBox.Items.Clear();
                _project.SortedModifiedTimeOld();
                for (var ForTimeOld = 0; ForTimeOld < _project.Notes.Count; ForTimeOld++)
                {
                    var Data = _project.Notes[ForTimeOld];
                    TitleListBox.Items.Add(Data.Name);
                }
            }
            else if (HeadNoteCategoryComboBox.Text == "Documents")
            {
                SortedCategory();
            }
            else if (HeadNoteCategoryComboBox.Text == "Finance")
            {
                SortedCategory();
            }
            else if (HeadNoteCategoryComboBox.Text == "Work")
            {
                SortedCategory();
            }
            else if (HeadNoteCategoryComboBox.Text == "People")
            {
                SortedCategory();
            }
            else if (HeadNoteCategoryComboBox.Text == "HealthAndSports")
            {
                SortedCategory();
            }
            else if (HeadNoteCategoryComboBox.Text == "Home")
            {
                SortedCategory();
            }
            else if (HeadNoteCategoryComboBox.Text == "Other")
            {
                SortedCategory();
            }
            else if(HeadNoteCategoryComboBox.Text == "All")
            {
                TitleListBox.Items.Clear();
                for (var i = 0; i < _project.Notes.Count; i++)
                {
                    var Data = _project.Notes[i];
                    TitleListBox.Items.Add(Data.Name);
                }
            }
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

                    if (HeadNoteCategoryComboBox.Text == "All")
                    {
                        //Присваиваем переменной данные из списка по индексу
                        _clicklist = _project.Notes[TitleListBox.SelectedIndex];


                        //Присваиваем полям значения из переменной списка
                        NameTextBox.Text = _clicklist.Name;
                        NoteTextTextBox.Text = _clicklist.NoteText;
                        CategoryTextBox.Text = _clicklist.NoteCategory;
                        CreateDateTimePicker.Value = _clicklist.CreationTime;
                        ModifiedDateTimePicker.Value = _clicklist.ModifiedTime;

                        _project.CurrentNote = _clicklist;
                    }
                    else if(HeadNoteCategoryComboBox.Text == "New")
                    {
                        //Присваиваем переменной данные из списка по индексу
                        _clicklist = _project.Notes[TitleListBox.SelectedIndex];


                        //Присваиваем полям значения из переменной списка
                        NameTextBox.Text = _clicklist.Name;
                        NoteTextTextBox.Text = _clicklist.NoteText;
                        CategoryTextBox.Text = _clicklist.NoteCategory;
                        CreateDateTimePicker.Value = _clicklist.CreationTime;
                        ModifiedDateTimePicker.Value = _clicklist.ModifiedTime;

                        _project.CurrentNote = _clicklist;
                    }
                    else if (HeadNoteCategoryComboBox.Text == "Old")
                    {
                        //Присваиваем переменной данные из списка по индексу
                        _clicklist = _project.Notes[TitleListBox.SelectedIndex];


                        //Присваиваем полям значения из переменной списка
                        NameTextBox.Text = _clicklist.Name;
                        NoteTextTextBox.Text = _clicklist.NoteText;
                        CategoryTextBox.Text = _clicklist.NoteCategory;
                        CreateDateTimePicker.Value = _clicklist.CreationTime;
                        ModifiedDateTimePicker.Value = _clicklist.ModifiedTime;

                        _project.CurrentNote = _clicklist;
                    }
                    else
                    {
                        //Присваиваем переменной данные из списка по индексу
                        _clicklist = _project.SortedResult[TitleListBox.SelectedIndex];


                        //Присваиваем полям значения из переменной списка
                        NameTextBox.Text = _clicklist.Name;
                        NoteTextTextBox.Text = _clicklist.NoteText;
                        CategoryTextBox.Text = _clicklist.NoteCategory;
                        CreateDateTimePicker.Value = _clicklist.CreationTime;
                        ModifiedDateTimePicker.Value = _clicklist.ModifiedTime;

                        _project.CurrentNote = _clicklist;
                    }


                    //Вызываем SaveToFile из класса ProjectManager
                    ProjectManager.SaveToFIle(_project, @"C:..\\NoteApp.txt");
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
            if (HeadNoteCategoryComboBox.Text == "All")
            {
                DeleteFunction();
            }
            else if (HeadNoteCategoryComboBox.Text == "New")
            {
                DeleteFunction();
            }
            else if (HeadNoteCategoryComboBox.Text == "Old")
            {
                DeleteFunction();
            }
            else
            {
                DialogResult result = MessageBox.Show("Выберите, пожалуйста, категорию All", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    HeadNoteCategoryComboBox.Text = "All";
                }
            }
        }

        //Кнопка для редактирования заметки
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (HeadNoteCategoryComboBox.Text == "All")
            {
                EditFunction();
            }
            else if (HeadNoteCategoryComboBox.Text == "New")
            {
                EditFunction();
            }
            else if (HeadNoteCategoryComboBox.Text == "Old")
            {
                EditFunction();
            }
            else
            {
                DialogResult result = MessageBox.Show("Выберите, пожалуйста, категорию All", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    HeadNoteCategoryComboBox.Text = "All";
                }
            }
        }

        //Поле "Редактировать" ToolStripMenu
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Значение "СоздатьНовуюЗаметку" в поле "Редактировать" ToolStripMenu
        private void createNewNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HeadNoteCategoryComboBox.Text = "All";
            AddFunction();
        }

        //Значение "РедактироватьТекущуюЗаметку" в поле "Редактировать" ToolStripMenu
        private void editCurrentNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HeadNoteCategoryComboBox.Text == "All")
            {
                EditFunction();
            }
            else if (HeadNoteCategoryComboBox.Text == "New")
            {
                EditFunction();
            }
            else if (HeadNoteCategoryComboBox.Text == "Old")
            {
                EditFunction();
            }
            else
            {
                DialogResult result = MessageBox.Show("Выберите, пожалуйста, категорию All", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    HeadNoteCategoryComboBox.Text = "All";
                }
            }
        }

        //Значение "УдалитьТекущуюЗаметку" в поле "Редактировать" ToolStripMenu
        private void deleteCurrentNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HeadNoteCategoryComboBox.Text == "All")
            {
                DeleteFunction();
            }
            else if (HeadNoteCategoryComboBox.Text == "New")
            {
                DeleteFunction();
            }
            else if (HeadNoteCategoryComboBox.Text == "Old")
            {
                DeleteFunction();
            }
            else
            {
                DialogResult result = MessageBox.Show("Выберите, пожалуйста, категорию All", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    HeadNoteCategoryComboBox.Text = "All";
                }
            }
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
            DialogResult result = MessageBox.Show("Действительно хотите выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        //Обработчик на нажатие клавиши "F1", "Delete", "Add","Substract","Escape".
        private void HeadForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.F1)
            {
                var about = new AboutForm();
                about.Show();
            }
            else if (e.KeyData == Keys.Delete)
            {
                DeleteFunction();
            }
            else if (e.KeyData == Keys.Subtract)
            {
                DeleteFunction();
            }
            else if(e.KeyData == Keys.Add)
            {
                AddFunction();
            }
            else if (e.KeyData == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Действительно хотите выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    //Вызываем SaveToFile из класса ProjectManager
                    ProjectManager.SaveToFIle(_project, @"C:\Users\Голиков Юрий\NoteApp.txt");

                    this.Close();
                }
            }
        }

        //Метод создающий заметку
        private void AddFunction()
        {
            HeadNoteCategoryComboBox.Text = "All";

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
                    ProjectManager.SaveToFIle(_project, @"C:..\\NoteApp.txt");
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
                ProjectManager.SaveToFIle(_project, @"C:..\\NoteApp.txt");

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
                HeadNoteCategoryComboBox.Text = "All";

                //Вызываем метод для удаления заметки
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
                    ProjectManager.SaveToFIle(_project, @"C:..\\NoteApp.txt");

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

        public void SortedCategory()
        {
            //Вызываем метод для фильрации списка Notes по HeadNodeCategoryComboBox.Text
            _project.SortedNoteForNoteCtaegory(HeadNoteCategoryComboBox.Text);

            TitleListBox.Items.Clear();

            for (var i = 0; i < _project.SortedResult.Count; i++)
            {
                //Записываем данные из списка SortedResult
                var DataSortedResult = _project.SortedResult[i];

                TitleListBox.Items.Add(DataSortedResult.Name);
            }
        }
    }
}
