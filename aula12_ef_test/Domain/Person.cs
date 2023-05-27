using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula12_ef_test.Domain
{
    public class Person
    {
        public Person(){}
        public Person (int Id, string Name, string phoneNumber){
            this.Id = Id;
            this.Name = Name;
            this.phoneNumber = phoneNumber;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string phoneNumber { get; set; }
    }
}