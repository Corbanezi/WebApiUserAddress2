using Models.Entities;

namespace Models.Mappings
{
    public class UserMapping
    {
        public UserEntity ToEntity(User user)
        {
            UserEntity userEntity = new UserEntity();
            userEntity.Id = user.Id;
            userEntity.Nome = user.Nome;
            userEntity.Sexo = user.Sexo;
            userEntity.EnderecoId = user.EnderecoId;
            userEntity.DataNascimento = user.DataNascimento;

            return userEntity;
        }
        public User ToModel(UserEntity userEntity)
        {
            User user = new User();

            user.Id = userEntity.Id;
            user.Nome = userEntity.Nome;
            user.Sexo = userEntity.Sexo;
            user.EnderecoId = userEntity.EnderecoId;
            user.DataNascimento = userEntity.DataNascimento;
            user.DataCriacao = userEntity.DataCriacao;
            user.DataAtualizacao = userEntity.DataAtualizacao;
            user.Deletado = userEntity.Deletado;
            return user;
        }
    }
}
