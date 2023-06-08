// See https://aka.ms/new-console-template for more information
using aula12_ef_test.Data;
using aula12_ef_test.Domain;

var db = new DataContext();
Console.WriteLine($"Database path: {db.DbPath}.");




// Create
Console.WriteLine("Inserting a new person");
var perso2 = new Person() { Id = 1, Name = "João da siis", phoneNumber ="4454545454545" };
db.Add(perso2);
var perso3 = new Person() { Id = 1, Name = "João da sii333s", phoneNumber ="4454545454545" };
db.Add(perso3);
db.SaveChanges();