using System;

namespace Models
{
    public class User
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public char Sexo { get; set; }

        public int EnderecoId { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime? DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public bool? Deletado { get; set; }
    }
}