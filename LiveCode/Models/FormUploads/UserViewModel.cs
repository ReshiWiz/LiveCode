using System.ComponentModel.DataAnnotations;

namespace LiveCode.Models.FormUploads
{
	public class UserViewModel
	{
		[Display(Name = "Name")]
		public string? UserName { get; set; }
		public string? LastName { get; set; }

		public string? Qualification { get; set; }
		public int Phone { get; set; }
		public string? Email { get; set; }
		public int Experience { get; set; }

		[DataType(DataType.Date)]
		[Display(Name = "Date")]
		public DateTime SpeakingDate { get; set; }

		[DataType(DataType.Time)]
		[Display(Name = "Time")]
		public DateTime SpeakingTime { get; set; }
		public int ZipCode { get; set; }
		public string? Address { get; set; }
		public string? Venue { get; set; }
		public Country? Country { get; set; }
		public State? State { get; set; }
		public City? City { get; set; }
		public int CountryId { get; set; }
		public int StateId { get; set; }
		public int CityId { get; set; }
	}
}
