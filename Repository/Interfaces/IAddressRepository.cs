using Models;
using System.Collections.Generic;


namespace Repository.Interfaces
{
    public interface IEnderecoRepository
    {
        public IEnumerable<Address> List(IDictionary<string, object> Params);
        public void Put(Address address);
        public Address Get(IDictionary<string, object> Params);
        public void Delete(int id);
        public void Post(Address address);

    }
}
