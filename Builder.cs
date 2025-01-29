public class Carro
{
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }
}

public interface ICarroBuilder
{
    void DefinirModelo(string modelo);
    void DefinirMarca(string marca);
    void DefinirAno(int ano);
    void DefinirCor(string cor);
    Carro ObterCarro();
}

public class CarroBuilder : ICarroBuilder
{
    private Carro _carro = new Carro();

    public void DefinirModelo(string modelo) => _carro.Modelo = modelo;
    public void DefinirMarca(string marca) => _carro.Marca = marca;
    public void DefinirAno(int ano) => _carro.Ano = ano;
    public void DefinirCor(string cor) => _carro.Cor = cor;
    public Carro ObterCarro() => _carro;
}

//! O que faz:
// Permite construir objetos complexos (Carro) passo a passo, definindo cada atributo individualmente. 
//! Para que serve:
// Facilita a criação de objetos com muitos parâmetros opcionais ou dependências complexas.
//! Por que usar:
// Melhora a legibilidade do código, separando a lógica de construção do objeto da sua representação final.