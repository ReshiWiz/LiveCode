using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiveCode.Models
{
	public class FormList
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		//	public IFormFile File { get; set; }
		public int CountryId { get; set; }
		public int StateId { get; set; }
		public int CityId { get; set; }

		public Country? Country { get; set; }
		public State? State { get; set; }
		public City? City { get; set; }
	}

	public class Country
	{
		[Key]
		public int Id { get; set; }
		public string? Name { get; set; }
		public ICollection<State>? States { get; set; }
	}

	public class State
	{
		[Key]
		public int Id { get; set; }
		public string? state { get; set; }
		[ForeignKey(nameof(countryId))]
		public Country? Country { get; set; }
		public int countryId { get; set; }
		public ICollection<City>? Cities { get; set; }
	}
	public class City
	{
		[Key]
		public int Id { get; set; }
		public string? name { get; set; }
		[ForeignKey("stateId")]
		public State? State { get; set; }
		public int stateId { get; set; }
	}
}
