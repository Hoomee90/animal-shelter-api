using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShelterApi.Models;

namespace ShelterApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnimalsController : ControllerBase
{
	private readonly ShelterApiContext _db;

	public AnimalsController(ShelterApiContext db)
	{
		_db = db;
	}

	// GET api/animals
	[HttpGet]
	public async Task<ActionResult<IEnumerable<Animal>>> Get(int reference, int pageSize)
	{
		IQueryable<Animal> query = _db.Animals.AsQueryable()
			.OrderBy(animal => animal.AnimalId)
			.Where(p => p.AnimalId > reference);
		if (pageSize != 0)
		{
			query = query
			.Take(pageSize);
		}
		return await query.ToListAsync();
	}

	// GET: api/Animals/5
	[HttpGet("{id}")]
	public async Task<ActionResult<Animal>> GetAnimal(int id)
	{
		Animal animal = await _db.Animals.FindAsync(id);

		if (animal == null)
		{
			return NotFound();
		}

		return animal;
	}

	// POST api/animals
	[HttpPost]
	public async Task<ActionResult<Animal>> Post(Animal animal)
	{
		_db.Animals.Add(animal);
		await _db.SaveChangesAsync();
		return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
	}

	private bool AnimalExists(int id)
	{
		return _db.Animals.Any(e => e.AnimalId == id);
	}

	// PUT: api/Animals/5
	[HttpPut("{id}")]
	public async Task<IActionResult> Put(int id, Animal animal)
	{
		if (id != animal.AnimalId)
		{
			return BadRequest();
		}

		_db.Animals.Update(animal);

		try
		{
			await _db.SaveChangesAsync();
		}
		catch (DbUpdateConcurrencyException)
		{
			if (!AnimalExists(id))
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

	// DELETE: api/Animals/5
	[HttpDelete("{id}")]
	public async Task<IActionResult> DeleteAnimal(int id)
	{
		Animal animal = await _db.Animals.FindAsync(id);
		if (animal == null)
		{
			return NotFound();
		}

		_db.Animals.Remove(animal);
		await _db.SaveChangesAsync();

		return NoContent();
	}
}
