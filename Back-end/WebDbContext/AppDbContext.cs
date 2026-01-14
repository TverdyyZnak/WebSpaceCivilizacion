using Microsoft.EntityFrameworkCore;
using WebDbContext.DbEntity;
using WebDbContext.DbEntity.Modules;

namespace WebDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<UserEntity> userDbSet { get; set; }
        public DbSet<PlayerEntity> playerDbSet { get; set; }
        public DbSet<WeaponEntity> weaponDbSet { get; set; }
        public DbSet<ArmorEntity> armorDbSet { get; set; }
        public DbSet<MaterialEntity> materialDbSet { get; set; }
        public DbSet<InventoryEntity> inventoryDbSet { get; set; }
        public DbSet<HeroEntity> heroDbSet { get; set; }
        public DbSet<ModuleEntity> moduleDbSet { get; set; }
        public DbSet<BedroomModuleEntity> bedroomModuleDbSet { get;set; }
        public DbSet<BusterModuleEntity> busterModuleDbSet { get; set; }
        public DbSet<EnergyModuleEntity> energyModuleDbSet { get; set; }
        public DbSet<MedicalModuleEntity> mediicalModuleDbSet { get; set; }        
    }
}
