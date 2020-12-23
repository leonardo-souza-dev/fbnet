using FbNet.Dominio.Entidades;
using System.Collections.Generic;

namespace FbNet.Interfaces.Dao
{
    public interface ITudoDao
    {
        List<ProcessoSeletivo> ObterProcessosHome(int qtd);
    }
}
