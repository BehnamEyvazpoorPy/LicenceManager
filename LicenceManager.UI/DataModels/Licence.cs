namespace LicenceManager.UI.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Licence
    {
        public Guid Id { get; set; }

        [Required]
        public string Serial { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerCode { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public bool IsTrial { get; set; }

        public int TrialDaysCount { get; set; }

        public int LicenceType { get; set; }

        public DateTime CreationDate { get; set; }

        [Required]
        public string LicencePack { get; set; }
    }
}
