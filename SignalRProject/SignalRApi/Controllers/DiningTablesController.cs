using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.DiningTableDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiningTablesController : ControllerBase
    {
        private readonly IDiningTableService _diningTableService;
        private readonly IMapper _mapper;
        public DiningTablesController(IDiningTableService diningTableService, IMapper mapper)
        {
            _diningTableService = diningTableService;
            _mapper = mapper;
        }
        [HttpGet("DiningTableCount")]
        public IActionResult DiningTableCount()
        {
            return Ok(_diningTableService.TDiningTableCount());
        }
        [HttpGet]
        public IActionResult DiningTableList()
        {
            var values = _diningTableService.TGetListAll();
            return Ok(_mapper.Map<List<ResultDiningTableDto>>(values));
        }
        [HttpPost]
        public IActionResult CreateDiningTable(CreateDiningTableDto createDiningTableDto)
        {
            createDiningTableDto.Status = false;
            var value = _mapper.Map<DiningTable>(createDiningTableDto);
            _diningTableService.TAdd(value);
            return Ok("Masa Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDiningTable(int id)
        {
            var value = _diningTableService.TGetByID(id);
            _diningTableService.TDelete(value);
            return Ok("Masa Silindi");
        }
        [HttpPut]
        public IActionResult UpdateDiningTable(UpdateDiningTableDto updateDiningTableDto)
        {
            var value = _mapper.Map<DiningTable>(updateDiningTableDto);
            _diningTableService.TUpdate(value);
            return Ok("Masa Bilgisi Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetDiningTable(int id)
        {
            var value = _diningTableService.TGetByID(id);
            return Ok(value);
        }
        [HttpGet("ChangeDiningTableStatusToTrue")]
        public IActionResult ChangeDiningTableStatusToTrue(int id)
        {
            _diningTableService.TChangeDiningTableStatusToTrue(id);
            return Ok("İşlem başarılı");
        }

        [HttpGet("ChangeDiningTableStatusToFalse")]
        public IActionResult ChangeDiningTableStatusToFalse(int id)
        {
            _diningTableService.TChangeDiningTableStatusToFalse(id);
            return Ok("İşlem başarılı");
        }
    }
}
