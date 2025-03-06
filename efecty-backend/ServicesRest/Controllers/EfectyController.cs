using Microsoft.AspNetCore.Mvc;
using ServicesRest.Application.Abstract;
using ServicesRest.Application.Dto;

namespace ServicesRest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EfectyController(IRecruitmentService recruitmentService) : Controller
    {
        private readonly IRecruitmentService _recruitmentService = recruitmentService;

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            try
            {
                return Ok(await _recruitmentService.GetPrueba());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(PruebaDto pruebaDto)
        {
            try
            {
                await _recruitmentService.AddPrueba(pruebaDto);

                return Ok("Registro creado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
