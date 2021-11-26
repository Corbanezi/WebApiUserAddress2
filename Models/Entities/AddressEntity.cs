using System;

namespace Models.Entities
{
    public class AddressEntity
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Numero { get; set; }

        public string Cep { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public bool? Deletado { get; set; }

    }
}
