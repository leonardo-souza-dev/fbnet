using FbNet.Dominio.Entidades;
using System.Collections.Generic;

namespace FbNet.Interfaces.Services
{
    public interface ITudoService
    {
        List<ProcessoSeletivo> ObterProcessosHome(int qtd);
    }
}
