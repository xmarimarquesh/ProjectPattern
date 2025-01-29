public interface IComponente
{
    void Operacao();
}

public class Componente : IComponente
{
    public void Operacao() { /* Lógica da operação básica */ }
}

public class Decorador : IComponente
{
    private IComponente _componente;

    public Decorador(IComponente componente)
    {
        _componente = componente;
    }

    public void Operacao()
    {
        _componente.Operacao();
        /* Lógica adicional do decorador */
    }
}

//! O que faz:
// Permite adicionar novos comportamentos a objetos (Componente) dinamicamente, envolvendo-os em objetos wrapper (Decorador).
//! Para que serve:
// Útil quando você precisa adicionar funcionalidades extras a objetos sem alterar suas classes originais.
//! Por que usar:
// Promove a flexibilidade e a extensibilidade do código, permitindo adicionar novos comportamentos sem herança.