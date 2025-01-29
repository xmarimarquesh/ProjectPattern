public interface IFactory
{
    IProduto CriarProdutoA();
    IProduto CriarProdutoB();
}

public interface IProduto { }

public class ProdutoA1 : IProduto { }
public class ProdutoB1 : IProduto { }

public class Fabrica1 : IFactory
{
    public IProduto CriarProdutoA() => new ProdutoA1();
    public IProduto CriarProdutoB() => new ProdutoB1();
}

//! O que faz: 
// Permite criar famílias de objetos relacionados (ProdutoA1 e ProdutoB1) 
// sem especificar suas classes concretas.
//! Para que serve:
// Útil quando você precisa trabalhar com diferentes famílias de produtos, como
// diferentes interfaces de usuário ou diferentes tipos de bancos de dados.
//! Por que usar:
// Promove a flexibilidade e a manutenibilidade do código, facilitando a troca 
// de famílias de produtos sem afetar o restante do sistema.