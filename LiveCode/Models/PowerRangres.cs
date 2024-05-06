using System.ComponentModel.DataAnnotations;

namespace LiveCode.Models
{
	public class PowerRangres
	{
		[Key]
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? color { get; set; }
	}
}
