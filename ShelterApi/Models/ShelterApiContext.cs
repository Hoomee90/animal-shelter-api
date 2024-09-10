using Microsoft.EntityFrameworkCore;

namespace ShelterApi.Models;
public class ShelterApiContext : DbContext
{
	public DbSet<Animal> Animals { get; set; }

	public ShelterApiContext(DbContextOptions<ShelterApiContext> options) : base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.Entity<Animal>()
			.HasData(
				new Animal { AnimalId = 1, Name = "Bella", Age = 3, Species = "Dog", Attitude = "Friendly", Adoptable = true },
				new Animal { AnimalId = 2, Name = "Max", Age = 5, Species = "Cat", Attitude = "Curious", Adoptable = true },
				new Animal { AnimalId = 3, Name = "Milo", Age = 2, Species = "Rabbit", Attitude = "Calm", Adoptable = false },
				new Animal { AnimalId = 4, Name = "Luna", Age = 7, Species = "Dog", Attitude = "Playful", Adoptable = true },
				new Animal { AnimalId = 5, Name = "Oscar", Age = 4, Species = "Cat", Attitude = "Independent", Adoptable = false },
				new Animal { AnimalId = 6, Name = "Daisy", Age = 1, Species = "Guinea Pig", Attitude = "Timid", Adoptable = true },
				new Animal { AnimalId = 7, Name = "Charlie", Age = 6, Species = "Dog", Attitude = "Protective", Adoptable = true },
				new Animal { AnimalId = 8, Name = "Whiskers", Age = 9, Species = "Cat", Attitude = "Affectionate", Adoptable = false },
				new Animal { AnimalId = 9, Name = "Buddy", Age = 8, Species = "Dog", Attitude = "Loyal", Adoptable = true },
				new Animal { AnimalId = 10, Name = "Nibbles", Age = 1, Species = "Hamster", Attitude = "Energetic", Adoptable = true },
				new Animal { AnimalId = 11, Name = "Rocky", Age = 2, Species = "Dog", Attitude = "Excitable", Adoptable = true },
				new Animal { AnimalId = 12, Name = "Lily", Age = 3, Species = "Cat", Attitude = "Shy", Adoptable = true },
				new Animal { AnimalId = 13, Name = "Buster", Age = 4, Species = "Dog", Attitude = "Stubborn", Adoptable = true },
				new Animal { AnimalId = 14, Name = "Mittens", Age = 6, Species = "Cat", Attitude = "Playful", Adoptable = true },
				new Animal { AnimalId = 15, Name = "Fuzzy", Age = 2, Species = "Rabbit", Attitude = "Gentle", Adoptable = true },
				new Animal { AnimalId = 16, Name = "Smokey", Age = 10, Species = "Cat", Attitude = "Calm", Adoptable = false },
				new Animal { AnimalId = 17, Name = "Shadow", Age = 7, Species = "Dog", Attitude = "Reserved", Adoptable = true },
				new Animal { AnimalId = 18, Name = "Ziggy", Age = 1, Species = "Parrot", Attitude = "Talkative", Adoptable = true },
				new Animal { AnimalId = 19, Name = "Patches", Age = 5, Species = "Cat", Attitude = "Lazy", Adoptable = false },
				new Animal { AnimalId = 20, Name = "Pepper", Age = 6, Species = "Dog", Attitude = "Protective", Adoptable = true },
				new Animal { AnimalId = 21, Name = "Coco", Age = 3, Species = "Hamster", Attitude = "Curious", Adoptable = true },
				new Animal { AnimalId = 22, Name = "Tiger", Age = 9, Species = "Cat", Attitude = "Independent", Adoptable = false },
				new Animal { AnimalId = 23, Name = "Rex", Age = 4, Species = "Dog", Attitude = "Energetic", Adoptable = true },
				new Animal { AnimalId = 24, Name = "Chloe", Age = 2, Species = "Guinea Pig", Attitude = "Nervous", Adoptable = true },
				new Animal { AnimalId = 25, Name = "Ginger", Age = 5, Species = "Cat", Attitude = "Friendly", Adoptable = true }
		);
	}
}