namespace CadastroClientes.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string SenhaHash { get; set; } = string.Empty;
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        public Usuario()
        {
            Ativo = true;
            DataCadastro = DateTime.Now;
        }

        public List<string> Validar()
        {
            var erros = new List<string>();

            //REGRA: O nome do cliente é obrigatório
            //e deve conter pelo menos 3 caracteres.
            if (string.IsNullOrEmpty(Nome))
            {
                erros.Add("O nome do usuario é obrigatório.");
            }
            else if (Nome.Length < 3)
            {
                erros.Add("O nome deve conter pelo menos 3 caracteres.");
            }

            //REGRA: O email do cliente é obrigatório
            //e deve ser um formato válido.
            if (string.IsNullOrEmpty(Login))
            {
                erros.Add("O login do usuario é obrigatório.");
            }

            if (string.IsNullOrEmpty(SenhaHash))
            {
                erros.Add("A senha do usuario é obrigatória.");

            }

            //REGRA: a data de cadastro do cliente não pode ser futura.
            if (DataCadastro > DateTime.Now)
            {
                erros.Add("a data de cadastro não pode ser futura.");
            }
            return erros;
        }




    }
}

