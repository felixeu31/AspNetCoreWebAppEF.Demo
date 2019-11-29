using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Adjunto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? PajeraId { get; set; }
        public virtual Pajera Pajera { get; set; }

        public int? SubPajeraId { get; set; }
        public virtual SubPajera SubPajera { get; set; }

        public int? InspeccionId { get; set; }
        public virtual Inspeccion Inspeccion { get; set; }

    }
}
