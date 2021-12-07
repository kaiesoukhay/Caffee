using DataAcess.Models;
using DataAcess.Interface;
using System.Linq;
using System.Threading.Tasks;

namespace DataAcess.Repositories
{
    public class ClientRepository : IClientRepository

    {
        private readonly MachineAppContext _dbContext;

        public ClientRepository(MachineAppContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task CreateClient(Clients entity)
        {
            await _dbContext.Set<Clients>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }


        public Clients GetClietById(int id)
        {
            return _dbContext.Clients.FirstOrDefault(p => p.Id == id);
        }



    }
}
