namespace pr2_up
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private PhoneBook phoneBook = new PhoneBook();
      

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim();
            if (Proverka(phone))
            {
                Contact newContact = new Contact(name, phone);
                phoneBook.AddContact(name, phone);
            }
            else MessageBox.Show("Введите корректный номер телефона");

        }

        private void сохранитьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PhoneBookLoader.Save(phoneBook, @"C:\Users\karin\Documents\котик c#\pr2_up\pr2_up\bin\Debug\1.txt");
        }

        private void показатьВсеКонтактыToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string cont = File.ReadAllText(@"C:\Users\karin\Documents\котик c#\pr2_up\pr2_up\bin\Debug\1.txt");
            listBox1.Items.Clear();//очитска листа перед повторным использованием
            PhoneBookLoader.Load(phoneBook, @"C:\Users\karin\Documents\котик c#\pr2_up\pr2_up\bin\Debug\1.txt");//показ весх контактов из файла

            var contacts = phoneBook.GetInfo();//получение списка

            // Добавляем контакты в ListBox

            foreach (var contact in contacts)
            {
                // Проверяем, содержится ли имя контакта в строке cont
                if (cont.Contains(contact.Name))
                {
                    listBox1.Items.Add($"{contact.Name} : {contact.Phone}");

                }

            }

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim();
            Contact newContact = new Contact(name, phone);//создаем нужный контакт для удаления

            string delete = $"{newContact.Name} : {newContact.Phone}";//переменная для удаления
            phoneBook.RemoveContact(newContact);
            var lines = File.ReadAllLines(@"C:\Users\karin\Documents\котик c#\pr2_up\pr2_up\bin\Debug\1.txt").ToList();


            // Удаляем строку, если она существует
            if (lines.Contains(delete))
            {
                lines.Remove(delete);
            }

            // Записываем оставшиеся строки обратно в файл
            File.WriteAllLines(@"C:\Users\karin\Documents\котик c#\pr2_up\pr2_up\bin\Debug\1.txt", lines);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//присваивание значений по индексу

            string selectedContact = listBox1.SelectedItem.ToString();

            // Разделяем строку на имя и телефон
            string[] contactDetails = selectedContact.Split(new[] { " : " }, StringSplitOptions.None);

            // Заполняем текстовые поля
            textBox1.Text = contactDetails[0]; 
            textBox2.Text = contactDetails[1];
        }

        private void поискПоИмениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

         
            string name = textBox1.Text.Trim();

           
            var results = phoneBook.Search(name); // выполняем поиск по имени

            //показываем нужный контакт
            foreach (var contact in results)
            {
                listBox1.Items.Add($"{contact.Name} : {contact.Phone}");
            }

        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int selectedIndex = listBox1.SelectedIndex;//нужный индекс
            Contact selectedContact = phoneBook.GetInfo()[selectedIndex];//узнаем информацию по индексу

            // присваеваем значения
            string newName = textBox1.Text.Trim();
            string newPhone = textBox2.Text.Trim();
            Contact newContact = new Contact(newName, newPhone);
            if (Proverka(newPhone))
            // редактируем контакт
            {
                phoneBook.EditContact(selectedContact, newContact);
                //перезаписываем в файл с изменением
                PhoneBookLoader.Save(phoneBook, @"C:\Users\karin\Documents\котик c#\pr2_up\pr2_up\bin\Debug\1.txt");
            }
            else MessageBox.Show("Введите корректный номер телефона");

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//выходим из программы
        }
        private bool Proverka(string number)
        {//(901)210-38-80
            char[] chars = number.ToCharArray();
            int count = 0; ;
            if (chars.Length != 14)
            
                return false;
                if (chars[0] == '(')
                {
                    if (chars[4] == ')')
                    {
                        if (chars[8] == '-' && chars[11] == '-')
                        {
                            foreach (char c in chars)
                            {
                                if (char.IsDigit(c))
                                    count++;
                            }
                          
                        }
                    }
                }
                if(count==10)
              
                    return true;
                else
                    return false;



        }
    }
}
