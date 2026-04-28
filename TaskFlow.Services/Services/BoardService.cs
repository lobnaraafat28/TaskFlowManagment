using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFlow.Core.Interfaces;
using TaskFlow.Services.DTOs;
using TaskFlow.Services.Interfaces;

namespace TaskFlow.Services.Services
{
    public class BoardService : IBoardService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BoardService(IUnitOfWork unitOfWork)
        {
           _unitOfWork = unitOfWork;
        }
        public Task<BoardDTO> CreateBoardAsync(BoardDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBoardAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BoardDTO>> GetAllBoardsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BoardDTO?> GetBoardByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateBoardAsync(int id, BoardDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
