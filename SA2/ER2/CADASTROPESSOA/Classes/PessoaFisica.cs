using CADASTROPESSOA.Interfaces;

namespace CADASTROPESSOA.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {

        public string? cpf { set ; get ;}

        public DateTime dataNasc { set; get; }

        public override float CalcularImposto(float rendimento) // sobrescrevendo a implementacao feita em Pessoa (la o metodo e abstrato)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}