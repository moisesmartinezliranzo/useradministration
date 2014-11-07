using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAdministration
{
    public  class UserClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Addr { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }

        public UserClass(string name, string lastName,string addr,string email,string phone,string gender,int id)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Addr = addr;
            this.Email = email;
            this.Phone = phone;
            this.Gender = gender;
            this.Id = id;
        }
    }
}
