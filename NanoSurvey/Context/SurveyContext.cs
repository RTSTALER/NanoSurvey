using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NanoSurvey.Models;
using Microsoft.Extensions.Configuration;

namespace NanoSurvey.Context
{
    public class SurveyContext : DbContext
    {
        public SurveyContext(DbContextOptions<SurveyContext> options, IConfiguration configuration)
    : base(options)
        { this.configuration = configuration;}
        IConfiguration configuration;
        public DbSet<Survey> Survey { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Result> Result { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value);
        }
    }
}
