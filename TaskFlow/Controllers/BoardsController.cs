using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskFlow.Services.DTOs;
using TaskFlow.Services.Interfaces;

namespace TaskFlow.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardsController : ControllerBase
    {
        private readonly IBoardService _boardService;

        public BoardsController(IBoardService boardService)
        {
            _boardService = boardService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBoards()
        {
            var boards = await _boardService.GetAllBoardsAsync();
            return Ok(boards);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBoardById(int id)
        {
            var board = await _boardService.GetBoardByIdAsync(id);

            if (board == null)
                return NotFound();

            return Ok(board);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBoard(int id, BoardDTO dto)
        {
            var updated = await _boardService.UpdateBoardAsync(id, dto);

            if (!updated)
                return NotFound();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBoard(int id)
        {
            var deleted = await _boardService.DeleteBoardAsync(id);

            if (!deleted)
                return NotFound();

            return NoContent();
        }

    }
}
