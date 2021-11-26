using Dapper;
using Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Repository
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private IDbConnection _connection;

        public EnderecoRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public void Delete(int id)
        {
            _connection.Execute($"Update Endereco SET Deletado = 1 WHERE Id = @id");
        }

        public Address Get(IDictionary<string, object> Params)
        {
            return _connection.Query<Address>($"Select * FROM Endereco WHERE Deletado = 0 AND Id = @id", param: new DynamicParameters(Params)).FirstOrDefault();
        }

        public IEnumerable<Address> List(IDictionary<string, object> Params)
        {
            return _connection.Query<Address>($"SELECT * FROM Endereco WHERE Deletado = 0 AND Descricao = @Descricao AND Numero = @Numero AND Cep = @Cep", param: new DynamicParameters(Params));
        }

        public void Post(Address address)
        {
            _connection.Execute($"INSERT INTO Endereco(Descricao,Numero,Cep,Deletado,DataCriacao) " +
                $"VALUES('{address.Descricao}','{address.Numero}','{address.Cep}',{0},'{DateTime.Now}'");
        }

        public void Put(Address address)
        {
            _connection.Execute($"Update Endereco SET Descricao = '{address.Descricao}',Numero = '{address.Numero}',Cep = {address.Cep}" +
                $",DataAtualizacao = '{DateTime.Now}' WHERE Id = {address.Id}");
        }
    }
}
