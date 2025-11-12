using MySqlX.XDevAPI;

namespace CadastroDeProdutos.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
            public decimal Quantidade { get; set; }

        public List<Produto>? ListaProduto { get; set; }
    }
}
