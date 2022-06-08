namespace Mercearia.Model
{
    internal class Produto
    {
        private int id;
        private string nome;
        private float quantidade;
        private string unidadeMedida;
        private float valor;

        public string Nome { get { return nome; } set { nome = value; } }
        public float Quantidade { get { return quantidade; } set { quantidade = value; } }
        public string UnidadeMedida { get { return unidadeMedida; } set { unidadeMedida = value; } }
        public float Valor { get { return valor; } set { valor = value; } }

        public Produto(string nome, float quantidade, string unidade, float valor)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.unidadeMedida = unidade;
            this.valor = valor;
        }
    }
}
