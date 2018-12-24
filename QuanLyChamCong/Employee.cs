using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChamCong
{
    class Employee
    {
        private string Id { get; set; }
        private string Name { get; set; }
        private string Code { get; set; }
        private string Birth { get; set; }
        private string Gender { get; set; }
        private string Phone { get; set; }
        private string Address { get; set; }
        private string Mail { get; set; }
        private string County { get; set; }
        private string Positon { get; set; }
        private string JoinDate { get; set; }
        public string getCode()
        {
            return this.Code;
        }
        public string getMail()
        {
            return this.Mail;
        }
        public string getName()
        {
            return this.Name;
        }
        public string getPosition()
        {
            return this.Positon;
        }
        public string getPhone()
        {
            return this.Phone;
        }
        public string getId()
        {
            return this.Id;
        }
        public string getGender()
        {
            return this.Gender;
        }
        public string getAddress()
        {
            return this.Address;
        }
        public string getJoinDate()
        {
            return this.JoinDate;
        }
        public string getBirth()
        {
            return this.Birth;
        }
        public string getCountry()
        {
            return this.County;
        }
        public Employee() { }
        public Employee(string code, string mail)
        {
            this.Name = this.Id = this.Gender = this.Phone = this.Address = this.County = this.Positon = "";
            this.JoinDate = this.Birth = DateTime.Now.ToString();
            this.Code = code;
            this.Mail = mail;

        }
        public Employee(string code, string name, string id, string phone, string birth, string gender, string address, string country, string join, string position, string mail) {
            this.Address = address;
            
            this.Birth = birth;
            this.Code = code;
            this.County = country;
            this.Gender = gender;
            this.Phone = phone;
            this.Id = id;
            this.Mail = mail;
            this.JoinDate = join;
            this.Positon = position;
            this.Name = name;
        }
    }
}
