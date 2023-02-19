using AutoMapper;
using DocGenerationAPI2.Models;
using DocGenerationAPI2.Services;
using Microsoft.AspNetCore.Mvc;

namespace DocGenerationAPI2.Controllers
{
    [ApiController]
    [Route("api/clients")]

    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientController(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(_mapper));

        }
        
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientDto>>> GetClients() 
        {
            var ClientsEntities = await _clientRepository.GetClientsAsync();
            return Ok(_mapper.Map<IEnumerable<ClientDto>>(ClientsEntities));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientDto>> GetClientById(int id)
        {
            var clientEntity = await _clientRepository.GetClientByIdAsync(id);
            return Ok(_mapper.Map<ClientDto>(clientEntity));
        }
    }

   

}
