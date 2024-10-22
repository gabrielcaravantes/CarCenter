public class Nota
{
    public int Id { get; set; }
    public string Numero { get; set; }
    public DateTime DataEmissao { get; set; }
    public int Garantia { get; set; }
    public decimal ValorVenda { get; set; }

    public Cliente Comprador { get; set; }
    public Vendedor Vendedor { get; set; }
    public Carro Carro { get; set; }
}

