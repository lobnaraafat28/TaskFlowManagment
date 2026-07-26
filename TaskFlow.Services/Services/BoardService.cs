using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFlow.Application.DTOs;
using TaskFlow.Core.Entities;
using TaskFlow.Core.Enums;
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
        public async Task<int> CreateBoardAsync(BoardDTO dto, string userId)
        {
            
                var board = new Board()
                {
                    Name = dto.Name,
                    Description = dto.Description,
                    CreatorId = userId
                
                };
            board.BoardUsers.Add(new BoardUser
            {
                UserId = userId,
                Role = BoardRole.Creator
            });
            await _unitOfWork.Repository<Board>().AddAsync(board);

                await _unitOfWork.CompleteAsync();
            return board.Id;
            
        }


        public async Task<bool> DeleteBoardAsync(int id)
        {
            var board = await _unitOfWork.Repository<Board>().GetByIdAsync(id);
            if (board != null)
            {
                _unitOfWork.Repository<Board>().Delete(board);
                await _unitOfWork.CompleteAsync();    
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<GetBoardDTO>> GetAllBoardsAsync()
        {
           var boards = await _unitOfWork.Repository<Board>().GetAllAsync();
            var boardsDto = boards.Select(b => new GetBoardDTO
            {
                Id = b.Id,
                Name = b.Name,
                Description = b.Description
            }).ToList();
            return boardsDto;


        }

        public async Task<GetBoardDTO?> GetBoardByIdAsync(int id)
        {
            var board = await _unitOfWork.Repository<Board>().GetByIdAsync(id);
            if (board == null) return null;
            return new GetBoardDTO() { Id = board.Id,Description = board.Description, Name = board.Name };
        }

        public async Task<bool> UpdateBoardAsync(int id, BoardDTO dto)
        {
            var board = await _unitOfWork.Repository<Board>().GetByIdAsync(id);
            if (board == null) return false;
            board.Name = dto.Name;
            board.Description = dto.Description;
            _unitOfWork.Repository<Board>().Update(board);
            await _unitOfWork.CompleteAsync();
            return true;


        }
    }
}
