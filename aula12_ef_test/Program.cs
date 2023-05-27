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
var Person3 = new Person{ Id = 3, Name = "Shakespeare", phoneNumber = "23123123" };
db.Add<Person>(Person3);
db.SaveChanges();
var person2 = new Person() { Id = 2, Name = "João Cabron", phoneNumber ="493993" };
db.Add(person2);
db.SaveChanges();

var product = new Product() { Id = 12,  Description ="4454545454545" };
db.Add(product);
db.SaveChanges();