using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Models.Dtos;
using PlatformService.Models.Interfaces.Repositories;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        private readonly IPlatformRepository _platformRepository;
        private readonly IMapper _mapper;

        public PlatformsController(
            IPlatformRepository platformRepository,
            IMapper mapper)
        {
            _platformRepository = platformRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlatformDetails>>> GetPlatforms()
        {
            Console.WriteLine("Get Platforms ...");

            var platforms = await _platformRepository.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<PlatformDetails>>(platforms));
        }
    }
}
