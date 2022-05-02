using TodoApi.Models;

namespace TodoApi.Utils
{
    public class ModelConversion
    {
        public TodoItemDTO ToDto(TodoItem todoItem)
        {
            return new TodoItemDTO { Id = todoItem.Id, Name = todoItem.Name, IsComplete = todoItem.IsComplete};
        }
    }
}