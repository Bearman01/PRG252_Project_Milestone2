using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG252_Project
{
    class Student
    {
        private int number;
        private string name;
        private string surname;
        private byte[] image;
        private string dob;
        private string gender;
        private int phone;
        private string address;

        int moduleCode;
        string moduleName;
        string moduleDescription;
        string link;

        public Student(int moduleCode, string moduleName, string moduleDescription, string link)
        {
            this.ModuleCode = moduleCode;
            this.ModuleName = moduleName;
            this.ModuleDescription = moduleDescription;
            this.Link = link;
        }

        public Student(int number, string name, string surname, byte[] image, string dob, string gender, int phone, string address)
        {
            this.Number = number;
            this.Name = name;
            this.Surname = surname;
            this.Image = image;
            this.Dob = dob;
            this.Gender = gender;
            this.Phone = phone;
            this.Address = address;
        }

        public int Number { get => number; set => number = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public byte[] Image { get => image; set => image = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public int ModuleCode { get => moduleCode; set => moduleCode = value; }
        public string ModuleName { get => moduleName; set => moduleName = value; }
        public string ModuleDescription { get => moduleDescription; set => moduleDescription = value; }
        public string Link { get => link; set => link = value; }
    }
}
