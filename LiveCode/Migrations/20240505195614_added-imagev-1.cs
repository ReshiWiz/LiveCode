using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiveCode.Migrations
{
	/// <inheritdoc />
	public partial class addedimagev1 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.RenameColumn(
				name: "SpeakerName",
				table: "UserModels",
				newName: "UserName");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.RenameColumn(
				name: "UserName",
				table: "UserModels",
				newName: "SpeakerName");
		}
	}
}
