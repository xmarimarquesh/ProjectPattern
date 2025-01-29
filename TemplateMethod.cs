public abstract class ProcessoDePagamento
{
    public void EfetuarPagamento(double valor)
    {
        ValidarPagamento(valor);
        CalcularTaxas(valor);
        ProcessarPagamento(valor);
        EnviarConfirmacao();
    }

    protected abstract void ValidarPagamento(double valor);
    protected abstract void CalcularTaxas(double valor);
    protected abstract void ProcessarPagamento(double valor);
    protected abstract void EnviarConfirmacao();
}

public class PagamentoComCartao : ProcessoDePagamento
{
    protected override void ValidarPagamento(double valor) { /* Lógica de validação do cartão */ }
    protected override void CalcularTaxas(double valor) { /* Lógica de cálculo de taxas do cartão */ }
    protected override void ProcessarPagamento(double valor) { /* Lógica de processamento do pagamento com cartão */ }
    protected override void EnviarConfirmacao() { /* Lógica de envio de confirmação do pagamento com cartão */ }
}

//! O que faz:
// Define o esqueleto de um algoritmo (EfetuarPagamento) em uma superclasse (ProcessoDePagamento), 
// mas permite que as subclasses (PagamentoComCartao) substituam etapas específicas do algoritmo 
// sem alterar sua estrutura geral.
//! Para que serve:
// Útil quando você tem um processo com etapas comuns a várias subclasses, mas que precisam ser 
// implementadas de forma diferente.
//! Por que usar:
// Evita a duplicação de código e promove a consistência do processo em todas as subclasses.