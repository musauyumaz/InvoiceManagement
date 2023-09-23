using InvoiceManagement.Application.Abstractions.Repositories.Blocks;
using InvoiceManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace InvoiceManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private IBlockCommandRepository _blockCommandRepository;
        private IBlockQueryRepository _blockQueryRepository;
        public TestsController(IBlockCommandRepository blockCommandRepository, IBlockQueryRepository blockQueryRepository)
        {
            _blockCommandRepository = blockCommandRepository;
            _blockQueryRepository = blockQueryRepository;
        }
        [HttpPost]
        public async Task<IActionResult> Add(BlockDTO blockDto)
        {
            Block addedBlock = await _blockCommandRepository.AddAsync(new()
            {
                FloorCount = blockDto.FloorCount,
                Name = blockDto.Name,
            });
            await _blockCommandRepository.SaveAsync();
            return Ok(addedBlock);
        }
        [HttpPost("add2")]
        public async Task<IActionResult> Add2(Block block)
        {
            Block addedBlock = await _blockCommandRepository.AddAsync(block);
            await _blockCommandRepository.SaveAsync();
            return Ok(addedBlock);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _blockQueryRepository.GetAll().ToListAsync());
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Block block = await _blockQueryRepository.GetByIdAsync(id);
            _blockCommandRepository.Table.Entry(block).State = EntityState.Deleted;
            await _blockCommandRepository.SaveAsync();
            return Ok(block);
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get2(int id)
        //{
        //    return Ok();
        //}
    }
    public class BlockDTO
    {
        public string Name { get; set; }
        public string FloorCount { get; set; }
    }
}
//localhost:5001/api/test