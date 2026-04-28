using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFlow.Services.DTOs;

namespace TaskFlow.Services.Interfaces
{
    public interface IBoardService
    {

        Task<IEnumerable<BoardDTO>> GetAllBoardsAsync();
        Task<BoardDTO?> GetBoardByIdAsync(int id);
        Task<BoardDTO> CreateBoardAsync(BoardDTO dto);
        Task<bool> UpdateBoardAsync(int id, BoardDTO dto);
        Task<bool> DeleteBoardAsync(int id);

        

    }
}
