using System.ComponentModel.DataAnnotations;

namespace ShelterApi.Models;

public class Animal
{
	public int AnimalId { get; set; }
	[Required]
	[StringLength(30)]
	public string Name { get; set; }
	[Required]
	[Range(0, 40)]
	public int Age { get; set; }
	[Required]
	[StringLength(30)]
	public string Species { get; set; }
	[Required]
	[StringLength(30)]
	public string Attitude { get; set; }
	[Required]
	public bool Adoptable { get; set; }
}
