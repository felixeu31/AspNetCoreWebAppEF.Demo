using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Dtos
{
    public class PajeraDto
    {
        public PajeraDto()
        {
            SubPajeras = new List<SubPajeraDto>();
            Inspecciones = new List<InspeccionDto>();
            Adjuntos = new List<AdjuntoDto>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<SubPajeraDto> SubPajeras { get; set; }
        public virtual List<InspeccionDto> Inspecciones { get; set; }
        public virtual List<AdjuntoDto> Adjuntos { get; set; }
    }

    public class SubPajeraDto
    {
        public SubPajeraDto()
        {
            Adjuntos = new List<AdjuntoDto>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<AdjuntoDto> Adjuntos { get; set; }
    }

    public class InspeccionDto
    {
        public InspeccionDto()
        {
            Adjuntos = new List<AdjuntoDto>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<AdjuntoDto> Adjuntos { get; set; }
    }

    public class AdjuntoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
