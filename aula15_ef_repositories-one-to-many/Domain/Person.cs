using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula15_ef_repositories.Domain;

namespace aula15_ef_repositories.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string phoneNumber { get; set; }
        public City City { get; set; }
    }
}