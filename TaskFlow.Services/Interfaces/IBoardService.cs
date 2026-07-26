using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFlow.Application.DTOs;
using TaskFlow.Services.DTOs;

namespace TaskFlow.Services.Interfaces
{
    public interface IBoardService
    {

        Task<IEnumerable<GetBoardDTO>> GetAllBoardsAsync();
        Task<GetBoardDTO?> GetBoardByIdAsync(int id);
        Task<int> CreateBoardAsync(BoardDTO dto, string userId);
        Task<bool> UpdateBoardAsync(int id, BoardDTO dto);
        Task<bool> DeleteBoardAsync(int id);

        

    }
}
