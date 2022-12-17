using System.Text.RegularExpressions;
using CADASTROPESSOA.Interfaces;

namespace CADASTROPESSOA.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public override float CalcularImposto(float rendimento)
        {

            if (rendimento <= 3000) 
            {
                return rendimento * .03f; // .03 = 0.03

            }
            else if ( rendimento <= 6000) 
            {
                return rendimento * .05f;

            }
            else if (rendimento <= 10000) 
            {
                return rendimento * .07f;

            }
            else
            {
                return rendimento * .09f;

            }
        }

        // XX.XXX.XXX/0001-XX = 18 digitos
        // XXXXXXXX0001XX == 14 digitos
        public bool ValidarCnpj(string cnpj)
        {
           bool retornoCnpjValido = Regex.IsMatch(cnpj, @"(^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$)" ); // IsMatch(oque quero comparar, padrao de comparacao)... Regex = Regular Expression

           if (retornoCnpjValido) 
           {

                if (cnpj.Length == 14) {

                    string subStringCnpj14 = cnpj.Substring(8, 4); // "a partir do oitavo digito pegue 4 digitos"
 
                    if (subStringCnpj14 == "0001")  {

                        return true;

                     }

                }

                else {

                    string subStringCnpj18 = cnpj.Substring(11, 4);
 
                    if (subStringCnpj18 == "0001")  {

                        return true;

                     }

                }
               

           }

           return false;
        }
    }
}