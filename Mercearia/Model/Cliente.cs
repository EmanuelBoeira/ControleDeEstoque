namespace Mercearia.Model
{
    internal class Cliente
    {
        private int id;
        private string nome;
        private string cpf;
        private string email;

        public Cliente(string nome, string cpf, string email)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
        }
    }
}
