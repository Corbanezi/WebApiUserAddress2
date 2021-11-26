using Models;
using System.Collections.Generic;


namespace Repository.Interfaces
{
    public interface IUsuarioRepository
    {
        public IEnumerable<User> List(IDictionary<string, object> Params);
        public void Put(User user);
        public User Get(IDictionary<string, object> Params);
        public void Delete(int id);
        public void Post(User user);

    }
}
