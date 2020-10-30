using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helper
{
    public class TestniContext
    {

        public mojDbContext InMemoryContext()
        {
            var option = new DbContextOptionsBuilder<mojDbContext>().UseInMemoryDatabase(databaseName: "Test_Database").Options;

            var db = new mojDbContext(option);
            if (db != null)
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }

            return db;

        }
       





    }
}
