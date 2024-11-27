using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace pr2_up
{
   static class PhoneBookLoader
    {
        //показ всех контактов
       public static void Load(PhoneBook phoneBook, string fileName) {
           var lines = File.ReadAllLines(fileName);
            phoneBook.GetInfo().Clear();
            foreach (var line in lines)//проходим по всему файлу
            {
                var parts = line.Split(':');//разделяем
                if (parts.Length == 2)
                {
                    var contact = new Contact(parts[0], parts[1]);
                    phoneBook.AddContact(contact);//добавляем контакт в лист

                }
             
            }
        }
        //сохранение контактов в файл
       public static void Save(PhoneBook phoneBook, string fileName) {
    
            StreamWriter sw=new StreamWriter(fileName);
            
            foreach (var contact in phoneBook.GetInfo())
            {
              
                sw.WriteLine($"{contact.Name} : {contact.Phone}");
            }
           sw.Close();
        }
    }
}
