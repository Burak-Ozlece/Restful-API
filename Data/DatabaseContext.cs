using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YoutubeWebApi.Models;

namespace YoutubeWebApi.Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> opt):base(opt)
        {
            
        }
        public DbSet<Posts> Posts{get; set;}
    }
}