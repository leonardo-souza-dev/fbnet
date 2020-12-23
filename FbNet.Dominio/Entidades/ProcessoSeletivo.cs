using System;
using System.Collections.Generic;

namespace FbNet.Dominio.Entidades
{
    public class ProcessoSeletivo
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public string Empresa { get; set; }
        public bool PassouFeedback { get; set; }
    }
}
