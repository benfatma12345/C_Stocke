using C_Stocke.Entities;
using C_Stocke.Repositories;
using System.Collections.Generic;

namespace C_Stocke.Services
{
    public class ClientService
    {
        private readonly ClientRepository _clientRepository;

        // Injection du repository via le constructeur
        public ClientService(ClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _clientRepository.GetAll();
        }

    }
}
