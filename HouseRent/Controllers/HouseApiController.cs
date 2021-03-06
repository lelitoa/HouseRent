using System;
using HouseRent.Data;
using HouseRent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseRent.Controllers
{
    [Route("api/context")]
    [ApiController]
    public class HouseApiController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HouseApiController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<House>>> GetHouse()
        {
            return await _context.House.ToListAsync();
        }


        [HttpGet("{id}")]   
       
        public async Task<ActionResult<House>> GetHouse(int id)
        {
            var house = await _context.House.FindAsync(id);

            if (house == null)
            {
                return NotFound();
            }

            return house;
        }


        [HttpPut("{id}")]
      
        public async Task<IActionResult> PutHouse(int id, House house)
        {
            if (id != house.Id)
            {
                return BadRequest();
            }

            _context.Entry(house).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HouseExists(id))
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
        public async Task<ActionResult<House>> PostHouse(House house)
        {
            
            _context.House.Add(house);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHouse", new { id = house.Id }, house);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHouse(int id)
        {
            var house = await _context.House.FindAsync(id);
            if (house == null)
            {
                return NotFound();
            }

            _context.House.Remove(house);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HouseExists(int id)
        {
            return _context.House.Any(e => e.Id == id);
        }
    }
}

