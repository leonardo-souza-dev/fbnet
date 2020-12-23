using FbNet.Repositorio;
using FbNet.Interfaces.Dao;
using FbNet.Interfaces.Services;
using System.Collections.Generic;
using FbNet.Dominio.Entidades;

namespace FbNet.Services
{
    public class TudoService : ITudoService
    {
        private ITudoDao _candidatoDao;

        public TudoService(ITudoDao candidatoDao)
        {
            _candidatoDao = candidatoDao;
        }

        public List<ProcessoSeletivo> ObterProcessosHome(int qtd)
        {
            return _candidatoDao.ObterProcessosHome(qtd);
        }
    }
}
