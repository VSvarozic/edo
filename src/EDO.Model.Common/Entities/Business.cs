using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDO.Model.Common.Entities
{
    [Table("Business")]
    public class Business : Entity
    {
        public string Title { get; set; }

        public virtual List<Office> Offices { get; set; }
    }
}
