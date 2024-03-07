using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkoutApplication.Model;

namespace WorkoutApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExerciseController : ControllerBase
    {
        private readonly DataContext _context;

        public ExerciseController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetExercises()
        {
            return Ok(_context.ExerciseList);
            
        }

        [HttpGet("{id}")]
        public IActionResult GetDetails(int? id)
        {
            var Exercise = _context.ExerciseList?.FirstOrDefault(e => e.Id == id);
            if (Exercise == null)
            {
                return NotFound();
            }

            return Ok(Exercise);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Exercise exercise)
        {
            var dbExercise = _context.ExerciseList?.Find(exercise.Id);
            if (dbExercise == null)
            {
                _context.Add(exercise);
                _context.SaveChanges();

                return CreatedAtAction(nameof(GetDetails), new { Id = exercise.Id}, exercise);
            }
            else
            {
                return Conflict();
            }
        }
    }
}