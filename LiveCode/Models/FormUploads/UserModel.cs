using System.ComponentModel.DataAnnotations;

namespace LiveCode.Models.FormUploads
{
	public class UserModel
	{
		[Key]
		public int Id { get; set; }

		[StringLength(100)]
		[Display(Name = "Name")]
		public string? UserName { get; set; }

		[StringLength(100)]
		public string? Qualification { get; set; }

		[StringLength(100)]
		public int Experience { get; set; }

		[DataType(DataType.Date)]
		[Display(Name = "Date")]
		public DateTime DateOfBirth { get; set; }

		[DataType(DataType.Time)]
		[Display(Name = "Time")]
		public DateTime Time { get; set; }

		[StringLength(255)]
		public string? Venue { get; set; }

		[Display(Name = "Image")]
		public string? ProfilePicture { get; set; }
		public int kjjjjjjjjjj { get; }	
	}
}
