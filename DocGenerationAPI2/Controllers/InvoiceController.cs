using AutoMapper;
using DocGenerationAPI2.Models;
using DocGenerationAPI2.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;
using DocGenerationAPI2.Entites;
using DocGenerationAPI2.Invoice_Generation;
using Microsoft.AspNetCore.Authorization;

namespace DocGenerationAPI2.Controllers
{
    [ApiController]
    
    [Route("api/invoices")]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IMapper _mapper;

        public InvoiceController(IInvoiceRepository invoiceRepository, IMapper mapper)
        {
            _invoiceRepository = invoiceRepository ?? throw new ArgumentNullException(nameof(invoiceRepository)); 
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoiceDto>>> GetInvoices() 
        {
            var InvoicesEntities = await _invoiceRepository.GetInvoicesAsync();
            return Ok(_mapper.Map <IEnumerable<InvoiceDto>>(InvoicesEntities));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InvoiceDto>> GetInvoiceById(int id)
        {
           
            
            var invoiceEntity = await _invoiceRepository.GetInvoiceByIdAsync(id);
            
            return Ok(_mapper.Map<InvoiceDto>(invoiceEntity));

          
        }

        [HttpGet("generate/{id}")]

        public async Task<ActionResult> GeneratePdfForInvoice (int id) 
        {
            GenerateDoc  generateDoc = new GenerateDoc();
            //var doc = await GetInvoiceById(id);
            var invoiceEntity = await _invoiceRepository.GetInvoiceByIdAsync(id);
            var doc = _mapper.Map<InvoiceDto>(invoiceEntity);
            byte[] abytes =  generateDoc.PrepareInvoice(doc);

           return File(abytes, "application/pdf");
        }



    }
}
