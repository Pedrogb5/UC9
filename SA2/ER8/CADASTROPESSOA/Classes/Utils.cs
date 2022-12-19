namespace CADASTROPESSOA.Classes
{
    public static class Utils //classe estatica (ex: Console) = usada para alocar somente metodos / nao precisa instanciar a classe para usar seus metodos
    {
        public static void BarraCarregamento(string texto) {

            Console.Write($"{texto}");

            for (int contador = 0; contador < 5; contador++)
            {
                Thread.Sleep(600);
                Console.Write(".");
            }

        }


        // Database/PessoaJuridica.csv = pasta/arquivo
        public static void VerificarLocalArquivo(string caminhoDoArquivo) {

                string pasta = caminhoDoArquivo.Split("/")[0]; //Split = separar .... [0] = comeca da posicao 0 da string ... pasta aloca "Database"

                if (!Directory.Exists(pasta)) //verificando se a pasta existe e senao cria-la
                {
                    Directory.CreateDirectory(pasta);
                }

                if (!File.Exists(caminhoDoArquivo)) //verificando (pelo caminho) se o arquivo existe e senao cria-lo
                {
                    using (File.Create(caminhoDoArquivo))
                    {
                        
                    }
                }
        }
    }
}