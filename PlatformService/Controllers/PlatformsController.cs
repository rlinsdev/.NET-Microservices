using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        private readonly IPlataformRepo _repository;
        private readonly IMapper _mapper;

        public PlatformsController(IPlataformRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
        {
            Console.WriteLine("--> Getting Platforms...");
            var platfomItems = _repository.GetAllPlatforms();
            return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(platfomItems));
        }

        [HttpGet("{id}", Name="GetPlatformById")]
        public ActionResult<PlatformReadDto> GetPlatformById(int id)
        {
            Console.WriteLine("--> Getting single item");
            var platformItem = _repository.GetPlatformById(id);
            if (platformItem != null)
                return Ok(_mapper.Map<PlatformReadDto>(platformItem));
            else
                return NotFound();
        }

        [HttpPost]
        public ActionResult<PlatformReadDto> CreatePlatform(PlatformCreateDto platformCreate)
        {
            var platformModel = _mapper.Map<Platform>(platformCreate);
            _repository.CreatePlatform(platformModel);
            _repository.SaveChanges();

            var platformReadDto = _mapper.Map<PlatformReadDto>(platformModel);
            /* Will return a route to get the specific register that I insert right now.
             * Sample: http://localhost:5092/api/Platforms/4 */
            return CreatedAtRoute(nameof(GetPlatformById), new {Id = platformReadDto.Id}, platformReadDto);
        }
    }
}