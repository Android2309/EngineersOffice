using EngineersOffice_Library.Models;
using EngineersOffice_Library.Models.MetalAssortment;
using Microsoft.EntityFrameworkCore;


namespace EngineersOffice_WebApi.ContextFolder
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {

        }
        public DbSet<SteelGrade> SteelGrade_Guide { get; set; }
        public DbSet<BendingCoefficient> BendingCoefficient_Guide { get; set; }
        public DbSet<Beam> Beam_Guide { get; set; }
    }
}
