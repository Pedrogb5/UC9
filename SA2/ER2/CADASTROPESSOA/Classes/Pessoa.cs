using CADASTROPESSOA.Interfaces;

namespace CADASTROPESSOA.Classes
{
    public abstract class Pessoa : IPessoa //abstrato = classe nao deve ser instanciada, usada; apenas para ser herdada
    {

        public string? nome { get; set; } // atributo...prop = properties

        public float rendimento { get; set; }

        public string? endereco { get; set; }

        public abstract float  CalcularImposto(float rendimento); //logica de imposto se difere entre as pessoas = nao deve ser implementado em Pessoa
        
    }
}