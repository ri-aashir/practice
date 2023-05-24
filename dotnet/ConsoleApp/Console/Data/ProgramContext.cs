using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Console.Models;

namespace Console.Data
{
    internal class ProgramContext : DbContext
    {
        public ProgramContext(DbContextOptions<ProgramContext> options)
            : base(options)
        {
        }

        public DbSet<_Program> Programs { get; set; }
        public DbSet<Interviewer> interviewers { get; set; }
    }
}
