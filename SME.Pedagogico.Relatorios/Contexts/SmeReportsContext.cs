using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SME.Pedagogico.Relatorios.Contexts
{
    public class SmeReportsContext : DbContext
    {
        #region ==================== ATTRIBUTES ====================
        private string connectionString = "Server=localhost;Port=5432;Database=smeReportsDB;Username=postgres;Password=39162604;";

        public DbSet<Models.Application> Applications { get; set; }
        public DbSet<Models.LogControl> LogControls { get; set; }
        public DbSet<Models.Report> Reports { get; set; }
        public DbSet<Models.ReportTag> ReportTags { get; set; }
        public DbSet<Models.Tag> Tags { get; set; }
        public DbSet<Models.ReportType> ReportTypes { get; set; }
        #endregion ==================== ATTRIBUTES ====================



        #region ==================== CONSTRUCTORS ====================
        public SmeReportsContext()
            : base()
        { }

        public SmeReportsContext(string connectionString)
            : base()
        {
            this.connectionString = connectionString;
        }
        #endregion ==================== CONSTRUCTORS ====================



        #region ==================== METHODS ====================
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }
        #endregion ==================== METHODS ====================
    }
}
