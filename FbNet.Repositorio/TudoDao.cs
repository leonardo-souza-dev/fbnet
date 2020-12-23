using FbNet.Dominio.Entidades;
using FbNet.Interfaces.Dao;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FbNet.Repositorio
{
    public class TudoDao : ITudoDao
    {
        private List<Candidato> Candidatos { get; set; } = new List<Candidato>();
        private List<ProcessoSeletivo> ProcessosSeletivos { get; set; } = new List<ProcessoSeletivo>();

        public TudoDao()
        {
            Candidato c1 = new Candidato();
            c1.Id = 1;
            c1.Cargo = "Desenvolvedor";
            c1.Nome = "John";

            ProcessoSeletivo p1 = new ProcessoSeletivo();
            p1.Id = 1;
            p1.DataInicio = DateTime.Now.AddDays(-1);
            p1.Empresa = "Xpto";
            p1.PassouFeedback = false;

            ProcessoSeletivo p2 = new ProcessoSeletivo();
            p2.Id = 2;
            p2.DataInicio = DateTime.Now.AddDays(-80);
            p2.Empresa = "Abc";
            p2.PassouFeedback = true;

            c1.ProcessosSeletivos.Add(p1);

            Candidatos.Add(c1);

            ProcessosSeletivos.Add(p1);
            ProcessosSeletivos.Add(p2);
        }

        public List<ProcessoSeletivo> ObterProcessosHome(int qtd)
        {
            using (var context = new Contexto())
            {
                try
                {
                    //var candidato = context.Candidatos.Where(c => c.Id == id).FirstOrDefault();
                    var processos = ProcessosSeletivos.Take(6).ToList();

                    return processos;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
