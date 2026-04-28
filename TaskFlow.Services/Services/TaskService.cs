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
    public class TaskService : ITaskService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TaskService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<TaskDTO> CreateTaskAsync(TaskDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TaskDTO>> GetAllTasksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TaskDTO?> GetTaskByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTaskAsync(int id, TaskDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
