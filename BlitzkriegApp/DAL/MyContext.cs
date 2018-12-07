using System.Data.Entity;
using BlitzkriegApp.Models;

namespace BlitzkriegApp.DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base("DefaultConnection")
        {

        }
        public DbSet<WorkModels> Work { get; set; }

        //public System.Data.Entity.DbSet<WorkModel> Work { get; set; }
    }
}