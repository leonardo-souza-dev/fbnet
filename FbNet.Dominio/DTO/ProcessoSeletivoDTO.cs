using System;
namespace FbNet.Dominio.Entidades
{
    public class ProdutorDTO
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Empresa { get; set; }
        public bool PassouFeedback { get; set; }

        public ProdutorDTO(int id, DateTime data, string empresa, bool passouFeedback)
        {
            this.Id = id;
            this.Data = data;
            this.Empresa = empresa;
            this.PassouFeedback = passouFeedback;
        }
    }
}
