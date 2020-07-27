//commands that use in vscode of migration and db update related packages are installed,, can check in
//DatingApp.API.csproj file
//dotnet ef migrations add InitialCreate
//dotnet ef database update
//dotnet ef database drop
//https://github.com/OmniSharp/omnisharp-vscode/issues/3034

using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data {
    public class DataContext : DbContext {
        public DataContext (DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}