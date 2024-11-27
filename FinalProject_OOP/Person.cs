using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject_OOP
{
    public class Person
    {   
        public Person(string name, string contactInfo)
        {
            this.Name = name;
            this.ContactInfo = contactInfo;
        }
        private string name;
        private string contactInfo;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        public virtual string PrintDetails()
        {
            return ($"Name: {Name}, Contact: {ContactInfo}");
        }
        public interface IPrintDetails
        {
            string PrintDetails();
        }
    }
}