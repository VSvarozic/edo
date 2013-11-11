using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDO.Model.Common.Entities
{
    [Table("Office")]
    public class Office : Entity
    {
        public string Title { get; set; }
    }
}
