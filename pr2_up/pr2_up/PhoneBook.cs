using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pr2_up
{
    class PhoneBook
    {
        private List<Contact> contacts;
        public PhoneBook()
        {
            contacts = new List<Contact>();
        }
        //список всех контактов
        public List<Contact> GetInfo()
        {
            return contacts;
        }
        //добавление контакта
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }
        public void AddContact(string name, string phone)
        {
            Contact contact=new Contact(name, phone);
            contacts.Add(contact);
        }
        //удаление контакта
        public void RemoveContact(Contact contact)
        {
            contacts.Remove(contact);
        }
        //поиск по имени
        public List<Contact> Search(string name)
        {
            return contacts.Where(c => c.Name.ToLower().Contains(name.ToLower())).ToList();
        }
        //редактирование
        public void EditContact(Contact contact, Contact newContact)
        {
            contact.Name = newContact.Name;
            contact.Phone = newContact.Phone;
        }

    }
}
