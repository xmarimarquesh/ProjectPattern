public abstract class FabricaDeCarros
{
    public abstract ICarro CriarCarro();
}

public interface ICarro { }

public class CarroPopular : ICarro { }
public class CarroLuxo : ICarro { }

public class FabricaDeCarrosPopulares : FabricaDeCarros
{
    public override ICarro CriarCarro() => new CarroPopular();
}

public class FabricaDeCarrosDeLuxo : FabricaDeCarros
{
    public override ICarro CriarCarro() => new CarroLuxo();
}


//! O que faz:
// Define uma interface para criação de objetos (ICarro) em uma superclasse (FabricaDeCarros), 
// mas permite que as subclasses (FabricaDeCarrosPopulares e FabricaDeCarrosDeLuxo) decidam 
// qual tipo de objeto será criado.
//! Para que serve:
// Permite criar diferentes tipos de objetos sem precisar modificar o código da fábrica.
//! Por que usar:
// Promove o baixo acoplamento e a flexibilidade do código, facilitando a adição de novos 
// tipos de objetos no futuro.