using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Inspeccion
    {
        public Inspeccion(){
            Adjuntos = new HashSet<Adjunto>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int PajeraId { get; set; }
        public virtual Pajera Pajera { get; set; }
        public virtual ICollection<Adjunto> Adjuntos { get; set; }
    }
}
