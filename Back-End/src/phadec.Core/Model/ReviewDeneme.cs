using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phadec.Model
{

    [Table("ReviewDeneme")]
    public class ReviewDeneme : FullAuditedEntity<int>
    {

        public ReviewDeneme()
        {
        }

        [Column("Puan")]
        public long Barcode { get; set; }

        [Column("EvaluationNotes")]
        public string Name { get; set; }



    }
}
