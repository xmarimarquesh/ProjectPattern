public interface IEstado
{
    void Ligar();
    void Desligar();
}

public class EstadoLigado : IEstado
{
    private Lampada _lampada;

    public EstadoLigado(Lampada lampada)
    {
        _lampada = lampada;
    }

    public void Ligar()
    {
        Console.WriteLine("A lâmpada já está ligada.");
    }

    public void Desligar()
    {
        _lampada.Estado = new EstadoDesligado(_lampada);
        Console.WriteLine("A lâmpada foi desligada.");
    }
}

public class EstadoDesligado : IEstado
{
    private Lampada _lampada;

    public EstadoDesligado(Lampada lampada)
    {
        _lampada = lampada;
    }

    public void Ligar()
    {
        _lampada.Estado = new EstadoLigado(_lampada);
        Console.WriteLine("A lâmpada foi ligada.");
    }

    public void Desligar()
    {
        Console.WriteLine("A lâmpada já está desligada.");
    }
}

public class Lampada
{
    public IEstado Estado { get; set; }

    public Lampada()
    {
        Estado = new EstadoDesligado(this);
    }

    public void Ligar()
    {
        Estado.Ligar();
    }

    public void Desligar()
    {
        Estado.Desligar();
    }
}

//! O que faz:
// Permite que um objeto (Lampada) altere seu comportamento (ligar/desligar) 
// quando seu estado interno muda (EstadoLigado / EstadoDesligado).
//! Para que serve:
// Modela objetos que possuem diferentes comportamentos dependendo de seu 
// estado, como máquinas de estado ou objetos com modos de operação distintos.
//! Por que usar:
// Organiza o código, separando a lógica de cada estado em classes separadas, 
// facilitando a manutenção e a adição de novos estados no futuro.
