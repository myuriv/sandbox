using System.ComponentModel.DataAnnotations;

namespace WebAPIServiceExample.Model
{
    public class TodoItem
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
