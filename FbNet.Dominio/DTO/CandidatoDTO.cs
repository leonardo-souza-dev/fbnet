namespace FbNet.Dominio.Entidades
{
    public class CategoriaDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public CategoriaDTO(int id, string descricao)
        {
            this.Id = id;
            this.Descricao = descricao;
        }
    }
}
