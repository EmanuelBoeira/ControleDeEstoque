namespace Mercearia.Model
{
    internal class Fornecedor
    {
        private int id;
        private string nome;
        private string cnpj;
        private string email;

        public Fornecedor(string nome, string cnpj, string email)
        {
            this.nome = nome;   
            this.cnpj = cnpj;   
            this.email = email;
        }
    }
}
