using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Pajera
    {
        public Pajera()
        {
            SubPajeras = new HashSet<SubPajera>();
            Inspecciones = new HashSet<Inspeccion>();
            Adjuntos = new HashSet<Adjunto>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<SubPajera> SubPajeras { get; set; }
        public virtual ICollection<Inspeccion> Inspecciones { get; set; }
        public virtual ICollection<Adjunto> Adjuntos { get; set; }
    }
}
