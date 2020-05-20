using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Task Required")]
        public string Task { get; set; }
        /*[Required]
        public string Task2 { get; set; }*/
        public bool Completed { get; set; }
    }
}
