using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFlow.Services.DTOs;

namespace TaskFlow.Services.Interfaces
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskDTO>> GetAllTasksAsync();
        Task<TaskDTO?> GetTaskByIdAsync(int id);
        Task<TaskDTO> CreateTaskAsync(TaskDTO dto);
        Task<bool> UpdateTaskAsync(int id, TaskDTO dto);
        Task<bool> DeleteTaskAsync(int id);

      
    }
}
