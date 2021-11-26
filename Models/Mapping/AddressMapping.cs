using Models.Entities;

namespace Models.Mappings
{
    public class AddressMapping
    {
        public AddressEntity ToEntity(Address address)
        {
            AddressEntity AddressEntity = new AddressEntity();

            AddressEntity.Id = address.Id;
            AddressEntity.Descricao = address.Descricao;
            AddressEntity.Numero = address.Numero;
            AddressEntity.Cep = address.Cep;
            return AddressEntity;
        }
        public Address ToModel(AddressEntity AddressEntity)
        {
            Address address = new Address();

            address.Id = AddressEntity.Id;
            address.Descricao = AddressEntity.Descricao;
            address.Numero = AddressEntity.Numero;
            address.Cep = AddressEntity.Cep;
            address.DataCriacao = AddressEntity.DataCriacao;
            address.DataAtualizacao = AddressEntity.DataAtualizacao;
            address.Deletado = AddressEntity.Deletado;
            return address;
        }

    }
}
