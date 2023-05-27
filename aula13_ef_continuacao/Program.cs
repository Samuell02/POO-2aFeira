// See https://aka.ms/new-console-template for more information
using aula12_ef_test.Data;
using aula12_ef_test.Domain;

var db = new DataContext();
Console.WriteLine($"Database path: {db.DbPath}.");




// Create
Console.WriteLine("Inserting a new person");
var person = new Person() { Id = 1, Name = "João da Silva", phoneNumber ="4454545454545" };
db.Add(person);
db.SaveChanges();
var supplier = new Supplier() 
     {   Name = "Coca-cola", 
         Address ="Rua Jorge Menedez",
        phoneNumber = "2312312321",
     };
db.Add(supplier);
db.SaveChanges();