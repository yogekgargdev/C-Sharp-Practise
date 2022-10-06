// See https://aka.ms/new-console-template for more information
using EFDemo;
using Microsoft.EntityFrameworkCore;



DbContextOptionsBuilder<ClinicDbContext> dbo = new DbContextOptionsBuilder<ClinicDbContext>();
DbContextOptionsBuilder< ClinicDbContext> dbo1 =dbo.UseSqlServer("server=.;database=EFDBDemo;user id=sa;pwd=sa");

ClinicDbContext cdbc = new ClinicDbContext(dbo1.Options);
cdbc.Database.EnsureCreated(); //in case database does not exist it will create

Console.WriteLine("Database Created Succesfully");

//Medicine m1 = new Medicine
//{
//    MID = 1,
//    MName = "Paracetamol",
//    ExpiryDate = DateTime.Now.AddYears(2),
//    Price = 100.0f,
//    Quantity = 20
//};

//cdbc.Medicines.Add(m1);
//cdbc.Medicines.Add(new Medicine { MID = 2, MName = "Crocin", ExpiryDate = DateTime.Now.AddYears(2), Price = 20.0f, Quantity = 30 });
//cdbc.Medicines.Add(new Medicine { MID = 3, MName = "Disperin", ExpiryDate = DateTime.Now.AddYears(2), Price = 50.0f, Quantity = 10 });
//cdbc.Medicines.Add(new Medicine { MID = 4, MName = "Vicks", ExpiryDate = DateTime.Now.AddYears(2), Price = 5.0f, Quantity = 50 });
//cdbc.SaveChanges();
//Console.WriteLine("Medicine Record Inserted");
//List<Medicine> listofmd = cdbc.Medicines.Where(m=>m.Price>20).ToList(); //-> linq operator
//List<Medicine> listofmd = cdbc.Medicines.Where(m => m.Price < 20).OrderBy(m=>m.MName).ToList();
//List<Medicine> listofmd = cdbc.Medicines.Where(m => m.Price < 20).OrderBy(m => m.MName).ThenByDescending(m=>m.Quantity).ToList();

//Updating the values
//Medicine fm=cdbc.Medicines.Find(4);
//fm.Quantity = 80;
//cdbc.SaveChanges();

//Removing the valeus
//Medicine fm = cdbc.Medicines.Find(4);
//cdbc.Medicines.Remove(fm);
//cdbc.SaveChanges();

List<Medicine> listofmd= cdbc.Medicines.Where(x => x.MName== "Crocin").Select(x=>x).ToList(); ;
// regex can aslo be used in linq
//var query = from md in cdbc.Medicines where md.Price <= 20 select md;
var query = from md in cdbc.Medicines select md;
Console.WriteLine("MID\tMedicine Name\tExpiry Date\tPrice\tQuantity");
Console.WriteLine("------------------------------------------------------------------");
foreach (Medicine md in listofmd)
{
    Console.WriteLine($"{md.MID}\t{md.MName}\t\t{md.ExpiryDate.ToString("dd-MM-yyyy")}\t{md.Price}\t{md.Quantity}");
}
//foreach(Medicine md in listofmd)
//{
//    Console.WriteLine($"{md.MID}\t{md.MName}\t{md.ExpiryDate.ToString("dd-MM-yyyy")}\t{md.Price}\t{md.Quantity}");
//}
Console.WriteLine("------------------------------------------------------------------");

Console.Read();
