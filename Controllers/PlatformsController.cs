using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Models.Common;
using PlatformService.Models.Dtos;
using PlatformService.Models.Entities;
using PlatformService.Models.Interfaces.Repositories;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PlatformsController(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlatformDetails>>> GetPlatforms()
        {
            Console.WriteLine("Get Platforms ...");

            var platforms = await _unitOfWork.PlatformRepository.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<PlatformDetails>>(platforms));
        }

        [HttpGet("id:int")]
        public async Task<ActionResult<PlatformDetails>> GetPlatform(int platformId)
        {
            Console.WriteLine("Get Platform By Id ...");

            var platforms = await _unitOfWork.PlatformRepository.GetAsync(platformId);

            if (platforms is null)
                return NotFound();

            return Ok(_mapper.Map<PlatformDetails>(platforms));
        }

        [HttpPost]
        public async Task<ActionResult<PlatformDetails>> CreatePlatForm(PlatformCreate platform)
        {
            Console.WriteLine("Create Platform ...");

            var platformEntity = _mapper.Map<Platform>(platform);

            await _unitOfWork.PlatformRepository.CreateAsync(platformEntity);

            return Ok(platformEntity.Id);
        }
    }
}
