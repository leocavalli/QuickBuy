namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (Preco < 0)
                AdicionarMensagem("Preço deve ter um valor positivo");
            if (string.IsNullOrEmpty(Nome))
                AdicionarMensagem("Você precisa dar um nome ao produto");
        }
    }
}
