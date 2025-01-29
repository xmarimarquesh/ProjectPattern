public class Singleton
{
    private static Singleton _instance;

    private Singleton() { }

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }
}

//! O que faz: 
// Garante que a classe Singleton tenha apenas uma instância e 
// fornece um ponto de acesso global a ela.   
//! Para que serve:
// Útil quando você precisa de um único objeto para coordenar 
// ações em todo o sistema, como um gerenciador de configurações 
// ou um pool de conexões com o banco de dados.
//! Por que usar:
// Evita a criação de várias instâncias, economizando recursos e 
// garantindo a consistência do estado do objeto.

