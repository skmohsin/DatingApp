
//commands that use in vscode of migration and db update related packages are installed,, can check in
//DatingApp.API.csproj file
//dotnet ef migrations add InitialCreate
//dotnet ef database update

using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) { }
        public DbSet<Value> Values { get; set; }
    }
}