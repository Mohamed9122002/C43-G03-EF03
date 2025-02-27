using Assignment02EFCore.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Assignment02EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext dbContext = new ITIDbContext();
            dbContext.Database.Migrate();
        }
    }
}
