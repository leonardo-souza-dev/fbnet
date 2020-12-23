using System;
using System.Collections.Generic;

namespace FbNet.Dominio.Entidades
{
    public class Candidato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }

        private ICollection<ProcessoSeletivo> _processosSeletivos;
        public virtual ICollection<ProcessoSeletivo> ProcessosSeletivos
        {
            get { return _processosSeletivos ?? (_processosSeletivos = new HashSet<ProcessoSeletivo>()); }
            protected set { _processosSeletivos = value; }
        }
    }
}
