using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPIServiceExample.Model;
using Microsoft.EntityFrameworkCore;

namespace WebAPIServiceExample.Controllers
{
    //[ApiController]
    //[Route("api/[controller]")]
    public class TodoController123 : Controller
    {
        // POST: api/TodoItems
        //[HttpPost]
        //public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        //{
        //    _context.TodoItems.Add(todoItem);
        //    await _context.SaveChangesAsync();

        //    //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        //    return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
        //}
        //    public TodoController(ITodoRepository todoItems)
        //    {
        //        TodoItems = todoItems;
        //    }

        //    public ITodoRepository TodoItems { get; set; }

        //    public IEnumerable<TodoItem> GetAll()
        //    {
        //        return TodoItems.GetAll();
        //    }


        //    [HttpGet("{id}", Name = "GetTodo")]
        //    public IActionResult GetById(string id)
        //    {
        //        var item = TodoItems.Find(id);
        //        if (item == null)
        //        {
        //            return NotFound();
        //        }
        //        return new ObjectResult(item);
        //    }

        //    [HttpPost]
        //    public IActionResult Create([FromBody] TodoItem item)
        //    {
        //        if (item == null)
        //        {
        //            return BadRequest();
        //        }
        //        TodoItems.Add(item);
        //        return CreatedAtRoute("GetTodo", new { id = item.Key }, item);
        //    }

        }
    }
