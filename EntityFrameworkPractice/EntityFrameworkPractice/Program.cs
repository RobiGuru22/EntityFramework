// See https://aka.ms/new-console-template for more information
using EntityFrameworkPractice.Models;
using EntityFrameworkPractice;
using EntityFrameworkPractice.Data;

/*Supplier supplier = new Supplier
{
    Name = "Teszt Szup 1",
    GLN = "1111111111222",
    TaxID = "1111-22-33",
    AccountNumber = "11111111-22222222-33333333",
    CodeByBuyer = "11112222",
    PublicAreaName = "Teszt utca 1.",
    CityName = "Teszt város",
    PostalCode = "1234",
    Country = "HU"
};*/

using TrackerContext context = new TrackerContext();

var deletable = context.Suppliers.Where(x => x.Name == "Teszt Szup 1").FirstOrDefault();

if(deletable is Supplier)
{
    Querys.RemoveSupplier(deletable);
}


Console.WriteLine("Removal done!");

