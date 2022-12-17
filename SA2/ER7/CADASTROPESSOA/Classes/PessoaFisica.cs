using CADASTROPESSOA.Interfaces;

namespace CADASTROPESSOA.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {

        public string? cpf { set ; get ;}

        public DateTime dataNasc { set; get; }

        public override float CalcularImposto(float rendimento) // sobrescrevendo a implementacao feita em Pessoa (la o metodo e abstrato)
        {
            float resultado = 0;
            if (rendimento <= 1500) 
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                resultado = (rendimento * 2/100);
                return resultado;
            }
            else if (rendimento > 1500 && rendimento <= 6000)
            {
                resultado = (rendimento * 3.5f/100); // 3.5/100 = numero double, converte colocando f (float)
                return resultado;
            }
            else 
            {
                resultado = (rendimento * 5/100);
                return resultado;
            }
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365; //atributo TotalDays ja converte tipo datetime para valor numerico (numero de dias)
            
            if (anos >= 18) { 
                return true;
            }
            
                return false;
        }

        public bool ValidarDataNasc(string dataNasc)
        {
           if (DateTime.TryParse(dataNasc, out DateTime dataConvertida)) // por padrao if ja faz comparacao com true 
           {
             DateTime dataAtual = DateTime.Today;

             double anos = (dataAtual - dataConvertida).TotalDays / 365;

             if (anos >= 18) {
                return true;
             }    

           }

           return false;
             
        }
    }

 }