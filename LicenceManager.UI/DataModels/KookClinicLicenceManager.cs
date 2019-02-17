namespace LicenceManager.UI.DataModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KookClinicLicenceManager : DbContext
    {
        public KookClinicLicenceManager()
            : base("name=KookClinicLicenceManager")
        {
        }

        public virtual DbSet<Licence> Licences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
