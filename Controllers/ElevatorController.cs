#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketElevatorREST.Models;

namespace RocketElevatorREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevatorController : ControllerBase
    {
        private readonly feliciaHartonoContext _context;

        public ElevatorController(feliciaHartonoContext context)
        {
            _context = context;
        }

        // GET: api/Elevator
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ElevatorDto>>> GetElevators()
        {
            // var elevators = await _context.Elevators.ToListAsync();
            var elevators = await _context.Elevators
                            .Select(elevator => ElevatorToDTO(elevator))
                            .ToListAsync();
            return elevators;

        }

        // GET: api/elevator/invalid
        [HttpGet("invalid")]
        public async Task<ActionResult<IEnumerable<InvalidElevatorDto>>> GetInvalid(){
            var elevators = await _context.Elevators
                            .Where(elevator => elevator.Status != "valid")
                            .Select(elevator => InvalidElevatorDto(elevator))
                            .ToListAsync();
            return elevators;
        }

        // GET: api/Elevator/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Elevator>> GetElevator(long id)
        {
            var elevator = await _context.Elevators.FindAsync(id);

            if (elevator == null)
            {
                return NotFound();
            }

            return elevator;
        }

        // PUT: api/Elevator/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutElevator(long id, Elevator elevator)
        {
            if (id != elevator.Id)
            {
                return BadRequest();
            }

            _context.Entry(elevator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ElevatorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Elevator>> PostElevator(Elevator elevator)
        {
            _context.Elevators.Add(elevator);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetElevator", new { id = elevator.Id }, elevator);
        }

        // DELETE: api/Elevator/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteElevator(long id)
        {
            var elevator = await _context.Elevators.FindAsync(id);
            if (elevator == null)
            {
                return NotFound();
            }

            _context.Elevators.Remove(elevator);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ElevatorExists(long id)
        {
            return _context.Elevators.Any(e => e.Id == id);
        }
    
        private static ElevatorDto ElevatorToDTO(Elevator elevator) => new ElevatorDto{
            Id = elevator.Id,
            SerialNumber = elevator.SerialNumber,
            Status = elevator.Status
        };
        
        private static InvalidElevatorDto InvalidElevatorDto(Elevator elevator) => new InvalidElevatorDto{
            Id = elevator.Id,
            ColumnId = elevator.ColumnId,
            SerialNumber = elevator.SerialNumber,
            Model = elevator.Model,
            Status = elevator.Status  
        };

    }
}
