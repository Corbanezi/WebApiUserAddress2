using Dapper;
using Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        private IDbConnection _connection;
        public UserRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void Delete(int id)
        {
            _connection.Execute($"Update Usuario SET Deletado = 1 WHERE Id = {id}");
        }

        public User Get(IDictionary<string, object> Params)
        {
            return _connection.Query<User>($"Select * FROM Usuario WHERE Deletado = 0 AND Id = @id", param: new DynamicParameters(Params)).FirstOrDefault();
        }

        public IEnumerable<User> List(IDictionary<string, object> Params)
        {
            return _connection.Query<User>($"SELECT * FROM Usuario WHERE Deletado = 0 AND Nome = @Nome AND Sexo = @Sexo", param: new DynamicParameters(Params));
        }

        public void Post(User user)
        {
            _connection.Execute($"INSERT INTO Usuario(Nome,Sexo,DataNascimento,Deletado,DataCriacao,EnderecoId) " +
                $"VALUES('{user.Nome}','{user.Sexo}','{user.DataNascimento}',{0},'{DateTime.Now}',{user.EnderecoId})");
        }

        public void Put(User user)
        {
            _connection.Execute($"Update Usuario SET Nome = '{user.Nome}',Sexo = '{user.Sexo}',EnderecoId = {user.EnderecoId}" +
                $",DataNascimento = '{user.DataNascimento}',DataAtualizacao = '{DateTime.Now}' WHERE Id = {user.Id}");
        }
    }
}
