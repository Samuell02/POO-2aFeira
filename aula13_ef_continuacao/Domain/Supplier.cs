using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace aula12_ef_test.Domain

{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
       public string Address { get; set; }

        public string phoneNumber { get; set; }
    }
}