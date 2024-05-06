namespace LiveCode.Models.FormUploads
{
	public class UploadImageView
	{
		public IFormFile? formFile { get; set; }
	}
	public class EditImageView : UploadImageView
	{
		public int Id { get; set; }
		public string? ExistingImage { get; set; }
	}
}
