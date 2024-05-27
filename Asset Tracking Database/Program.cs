

using Asset_Tracking_Database;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Asset Tracking Database !");

MyDbContext Context = new MyDbContext();

// Get data-Read,select

Computer Mycomputer = Context.Computers.Include(x => x.MobileList).SingleOrDefault(x => x.Id == 1);

foreach(Mobile A in Mycomputer.MobileList)
{
    Console.WriteLine(A.Brand);

}
