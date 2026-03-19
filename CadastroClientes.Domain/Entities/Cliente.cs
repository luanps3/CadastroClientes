namespace CadastroClientes.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public Cliente()
        {
            DataCadastro = DateTime.Now;
            Ativo = true;
        }

        public List<string> Validar()
        {
            var erros = new List<string>();

            //REGRA: O nome do cliente é obrigatório
            //e deve conter pelo menos 3 caracteres.
            if (string.IsNullOrEmpty(Nome))
            {
                erros.Add("O nome do cliente é obrigatório.");
            }
            else if (Nome.Length < 3)
            {
                erros.Add("O nome deve conter pelo menos 3 caracteres.");
            }

            //REGRA: O email do cliente é obrigatório
            //e deve ser um formato válido.
            if (string.IsNullOrEmpty(Email))
            {
                erros.Add("O email do cliente é obrigatório.");
            }
            else if (!Email.Contains("@"))
            {
                erros.Add("O email deve ser válido.");
            }

            //REGRA: a data de cadastro do cliente não pode ser futura.
            if (DataCadastro > DateTime.Now)
            {
                erros.Add("a data de cadastro não pode ser futura.");
            }

            return erros;
        }

        public bool EhValido()
        {
            return Validar().Count == 0;
        }



    }
}
