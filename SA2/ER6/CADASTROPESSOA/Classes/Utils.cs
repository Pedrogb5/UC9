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
    }
}