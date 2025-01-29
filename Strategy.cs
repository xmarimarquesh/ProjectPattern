public interface ICalculoFrete
{
    double Calcular(double peso);
}

public class CalculoFreteNormal : ICalculoFrete
{
    public double Calcular(double peso) => peso * 10;
}

public class CalculoFreteExpresso : ICalculoFrete
{
    public double Calcular(double peso) => peso * 20;
}

public class Pedido
{
    public double Peso { get; set; }
    public ICalculoFrete CalculoFrete { get; set; }

    public Pedido(double peso, ICalculoFrete calculoFrete)
    {
        Peso = peso;
        CalculoFrete = calculoFrete;
    }

    public double CalcularFrete() => CalculoFrete.Calcular(Peso);
}

//! O que faz:
// Define uma família de algoritmos (ICalculoFrete), encapsula cada um deles 
// em uma classe separada (CalculoFreteNormal e CalculoFreteExpresso) e 
// permite que seus objetos sejam intercambiáveis.
//! Para que serve:
// Permite escolher o algoritmo de cálculo de frete em tempo de execução, 
// sem precisar modificar o código do pedido.
//! Por que usar:
// Promove a flexibilidade e a manutenibilidade do código, facilitando a
// adição de novos algoritmos no futuro.