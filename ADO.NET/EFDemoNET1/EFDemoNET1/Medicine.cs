using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoNET1
{
    [Table("Tbl_Medicine")]
    public class Medicine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //-> otherwise instead of None we can identity also
        public int MID { get; set; }
        public string MName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public float? Price { get; set; } //-> float can hold a null value now
        public int? Quantity { get; set; }








    }
}
