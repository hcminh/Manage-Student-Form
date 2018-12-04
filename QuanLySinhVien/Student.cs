using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    [Serializable]
    class Student
    {
        public Student()
        {
        }

        public Student(string Name, string Id, string Class, string Birth, string Gender, string Code, string Phone, string Mail)
        {
            this.Id = Id;
            this.Name = Name;
            this.Class = Class;
            this.Birth = Birth;
            this.Gender = Gender;
            this.Phone = Phone;
            this.Code = Code;
            this.Mail = Mail;
        }

        public Student(string studentInfos)
        {
            string[] infos = studentInfos.Split('~');
            this.Name = infos[0];
            this.Id = infos[1];
            this.Class = infos[2];
            this.Birth = infos[3];
            this.Gender = infos[4];
            this.Code = infos[5];
            this.Phone = infos[6];
            this.Mail = infos[7];
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Birth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }
        public string Mail { get; set; }
    }
}
