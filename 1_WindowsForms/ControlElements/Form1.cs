using System.Collections.Generic;
using System.Windows.Forms;

namespace ControlElements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Кнопка по умолчанию
            this.AcceptButton = button1;
            this.CancelButton = button1;
            // Горячие клавиши - ALT + &буква
            button1.Text = "&Аватар";


            //***************************************************************************************************//


            // Ссылки

            // linkLabel1.ActiveLinkColor
            // linkLabel1.VisitedLinkColor
            // linkLabel1.LinkColor
            linkLabel1.LinkClicked += LinkLable_Click;


            //***************************************************************************************************//


            // Текстовое поле

            textBox1.Multiline = false;
            //textBox1.Text = "zsxdfghjkl;kjhgfdxghasbcnkasckasncjasbchjsabcjkasjcajsbcsjancjsancascnajcsca";
            //textBox1.ScrollBars = ScrollBars.Both;

            // Автозаполнение
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection()
            {
                "ass", "heeeeelllo", "man", "kolko"
            };
            textBox1.AutoCompleteCustomSource = auto;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Режим пароля
            textBox1.PasswordChar = '*';
            textBox1.UseSystemPasswordChar = false;


            //***************************************************************************************************//


            // 0: Позволяет вводить только цифры
            // 9: Позволяет вводить цифры и пробелы
            //#: Позволяет вводить цифры, пробелы и знаки '+' и '-'
            // L: Позволяет вводить только буквенные символы
            // ?: Позволяет вводить дополнительные необязательные буквенные символы
            // A: Позволяет вводить буквенные и цифровые символы
            // .: Задает позицию разделителя целой и дробной части
            // ,: Используется для разделения разрядов в целой части числа
            // ::Используется в временных промежутках - разделяет часы, минуты и секунды
            // /: Используется для разделения дат
            // $: Используется в качестве символа валюты

            maskedTextBox1.Mask = "+0 (000) 000-00-00";
            maskedTextBox1.BeepOnError = true;
            maskedTextBox1.PromptChar = ' ';


            //***************************************************************************************************//


            // ListBox

            string[] str = new string[] { "rveveveve", "erveevevev", "Eververvev", "reveverver" };
            listBox1.Items.AddRange(str);
            //listBox1.SetSelected(1, true);
            listBox1.SelectedIndex = 1;
            listBox1.SelectionMode = SelectionMode.MultiSimple;

            Person person1 = new Person(1, "Tom");
            Person person2 = new Person(2, "Tom");
            Person person3 = new Person(3, "Tom");
            Person person4 = new Person(4, "Tom");
            Person person5 = new Person(5, "Tom");

            var list = new List<Person>()
            {
                person1, person2, person3, person4, person5
            };

            listBox1.DataSource = list;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";

            
            //***************************************************************************************************//


            // ComboBox

            comboBox1.Items.AddRange(str);
            comboBox2.Items.AddRange(str);
            comboBox3.Items.AddRange(str);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox3.DropDownStyle = ComboBoxStyle.Simple;


            //***************************************************************************************************//


            // CheckListBox

            checkedListBox1.Items.AddRange(str);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.SetItemChecked(0, true);
            checkedListBox1.SetItemCheckState(2, CheckState.Indeterminate);
            checkedListBox1.CheckOnClick = true;


            //***************************************************************************************************//


        }

        private void LinkLable_Click(object sender, LinkLabelLinkClickedEventArgs args)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }
    }

    public class Person
    {
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
    }
}
