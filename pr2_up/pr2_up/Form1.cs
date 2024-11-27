namespace pr2_up
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private PhoneBook phoneBook = new PhoneBook();
      

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim();
            if (Proverka(phone))
            {
                Contact newContact = new Contact(name, phone);
                phoneBook.AddContact(name, phone);
            }
            else MessageBox.Show("������� ���������� ����� ��������");

        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PhoneBookLoader.Save(phoneBook, @"C:\Users\karin\Documents\����� c#\pr2_up\pr2_up\bin\Debug\1.txt");
        }

        private void �������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string cont = File.ReadAllText(@"C:\Users\karin\Documents\����� c#\pr2_up\pr2_up\bin\Debug\1.txt");
            listBox1.Items.Clear();//������� ����� ����� ��������� ��������������
            PhoneBookLoader.Load(phoneBook, @"C:\Users\karin\Documents\����� c#\pr2_up\pr2_up\bin\Debug\1.txt");//����� ���� ��������� �� �����

            var contacts = phoneBook.GetInfo();//��������� ������

            // ��������� �������� � ListBox

            foreach (var contact in contacts)
            {
                // ���������, ���������� �� ��� �������� � ������ cont
                if (cont.Contains(contact.Name))
                {
                    listBox1.Items.Add($"{contact.Name} : {contact.Phone}");

                }

            }

        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim();
            Contact newContact = new Contact(name, phone);//������� ������ ������� ��� ��������

            string delete = $"{newContact.Name} : {newContact.Phone}";//���������� ��� ��������
            phoneBook.RemoveContact(newContact);
            var lines = File.ReadAllLines(@"C:\Users\karin\Documents\����� c#\pr2_up\pr2_up\bin\Debug\1.txt").ToList();


            // ������� ������, ���� ��� ����������
            if (lines.Contains(delete))
            {
                lines.Remove(delete);
            }

            // ���������� ���������� ������ ������� � ����
            File.WriteAllLines(@"C:\Users\karin\Documents\����� c#\pr2_up\pr2_up\bin\Debug\1.txt", lines);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//������������ �������� �� �������

            string selectedContact = listBox1.SelectedItem.ToString();

            // ��������� ������ �� ��� � �������
            string[] contactDetails = selectedContact.Split(new[] { " : " }, StringSplitOptions.None);

            // ��������� ��������� ����
            textBox1.Text = contactDetails[0]; 
            textBox2.Text = contactDetails[1];
        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

         
            string name = textBox1.Text.Trim();

           
            var results = phoneBook.Search(name); // ��������� ����� �� �����

            //���������� ������ �������
            foreach (var contact in results)
            {
                listBox1.Items.Add($"{contact.Name} : {contact.Phone}");
            }

        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int selectedIndex = listBox1.SelectedIndex;//������ ������
            Contact selectedContact = phoneBook.GetInfo()[selectedIndex];//������ ���������� �� �������

            // ����������� ��������
            string newName = textBox1.Text.Trim();
            string newPhone = textBox2.Text.Trim();
            Contact newContact = new Contact(newName, newPhone);
            if (Proverka(newPhone))
            // ����������� �������
            {
                phoneBook.EditContact(selectedContact, newContact);
                //�������������� � ���� � ����������
                PhoneBookLoader.Save(phoneBook, @"C:\Users\karin\Documents\����� c#\pr2_up\pr2_up\bin\Debug\1.txt");
            }
            else MessageBox.Show("������� ���������� ����� ��������");

        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//������� �� ���������
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
