using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Singleton
        Singleton singleton = Singleton.GetInstance();
        singleton.FazerAlgo();

        // Builder
        ICarroBuilder carroBuilder = new CarroBuilder();
        carroBuilder.DefinirModelo("Gol");
        carroBuilder.DefinirMarca("Volkswagen");
        carroBuilder.DefinirAno(2023);
        carroBuilder.DefinirCor("Vermelho");
        Carro carro = carroBuilder.ObterCarro();
        Console.WriteLine($"Carro: {carro.Modelo} {carro.Marca} {carro.Ano} {carro.Cor}");

        // Abstract Factory
        IFactory fabrica1 = new Fabrica1();
        IProduto produtoA1 = fabrica1.CriarProdutoA();
        IProduto produtoB1 = fabrica1.CriarProdutoB();

        // Factory Method
        FabricaDeCarros fabricaDeCarrosPopulares = new FabricaDeCarrosPopulares();
        ICarro carroPopular = fabricaDeCarrosPopulares.CriarCarro();

        // Strategy
        Pedido pedido = new Pedido(10, new CalculoFreteNormal());
        double frete = pedido.CalcularFrete();
        Console.WriteLine($"Frete normal: {frete}");

        pedido.CalculoFrete = new CalculoFreteExpresso();
        frete = pedido.CalcularFrete();
        Console.WriteLine($"Frete expresso: {frete}");

        // Template Method
        ProcessoDePagamento pagamentoComCartao = new PagamentoComCartao();
        pagamentoComCartao.EfetuarPagamento(100);

        // Decorator
        IComponente componente = new Componente();
        IComponente componenteDecorado = new Decorador(componente);
        componenteDecorado.Operacao();

        // State
        Lampada lampada = new Lampada();
        lampada.Ligar();
        lampada.Desligar();
    }
}