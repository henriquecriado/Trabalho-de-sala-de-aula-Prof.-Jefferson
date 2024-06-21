using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrabalhoJeff.Data;
using TrabalhoJeff.Model.Enum;
using TrabalhoJeff.Model;

namespace TrabalhoJeff.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly StateDBContext _context;
        public TaskController(StateDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<TaskModel>> PostTask(TaskModel tasksmodel)
        {
            tasksmodel.State = StateTask.Criado;
            _context.TasksModel.Add(tasksmodel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTask", new { id = tasksmodel.Id }, tasksmodel);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskModel>> GetTask(int id)
        {
            var tasks = await _context.TasksModel.FindAsync(id);

            if (tasks == null)
            {
                return NotFound();
            }

            return tasks;
        }

        [HttpPut("{id}/Começar")]
        public async Task<IActionResult> StartTask(int id)
        {
            var tasks = await _context.TasksModel.FindAsync(id);

            if (tasks == null)
            {
                return NotFound();
            }

            // altera apenas se a tarefa estiver criada
            if (tasks.State == StateTask.Criado)
            {
                tasks.State = StateTask.EmProgresso;
                _context.Entry(tasks).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                return BadRequest("A tarefa não pode ser iniciada!");
            }

            return NoContent();
        }

        [HttpPut("{id}/Completo")]
        public async Task<IActionResult> CompleteTask(int id)
        {
            var tasks = await _context.TasksModel.FindAsync(id);

            if (tasks == null)
            {
                return NotFound();
            }

            // altera apenas se a tarefa estiver em progresso
            if (tasks.State == StateTask.EmProgresso)
            {
                tasks.State = StateTask.Completo;
                _context.Entry(tasks).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                return BadRequest("A tarefa não pode ser completada!");
            }

            return NoContent();
        }

        [HttpPut("{id}/Cancelado")]
        public async Task<IActionResult> CancelTask(int id)
        {
            var tasks = await _context.TasksModel.FindAsync(id);
            if (tasks == null)
            {
                return NotFound();
            }
            // Cancela se a tarefa estiver: criada ou em progresso
            if (tasks.State == StateTask.Criado || tasks.State == StateTask.EmProgresso)
            {
                tasks.State = StateTask.Cancelado;
                _context.Entry(tasks).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                return BadRequest("A tarefa não pode ser cancelada!");
            }

            return NoContent();
        }
    }
}
