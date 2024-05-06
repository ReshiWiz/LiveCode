using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LiveCode.Migrations
{
    /// <inheritdoc />
    public partial class fromlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_formLists_City_CityId",
                table: "formLists");

            migrationBuilder.DropForeignKey(
                name: "FK_formLists_Country_CountryId",
                table: "formLists");

            migrationBuilder.DropForeignKey(
                name: "FK_formLists_State_StateId",
                table: "formLists");

            migrationBuilder.DropIndex(
                name: "IX_formLists_CityId",
                table: "formLists");

            migrationBuilder.DropIndex(
                name: "IX_formLists_CountryId",
                table: "formLists");

            migrationBuilder.DropIndex(
                name: "IX_formLists_StateId",
                table: "formLists");

            migrationBuilder.DropColumn(
                name: "CitiesId",
                table: "formLists");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "formLists");

            migrationBuilder.DropColumn(
                name: "Countries",
                table: "formLists");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "formLists");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "formLists");

            migrationBuilder.DropColumn(
                name: "states",
                table: "formLists");

            migrationBuilder.AddColumn<int>(
                name: "FormListId",
                table: "State",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormListId",
                table: "Country",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FormListId",
                table: "City",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_State_FormListId",
                table: "State",
                column: "FormListId");

            migrationBuilder.CreateIndex(
                name: "IX_Country_FormListId",
                table: "Country",
                column: "FormListId");

            migrationBuilder.CreateIndex(
                name: "IX_City_FormListId",
                table: "City",
                column: "FormListId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_formLists_FormListId",
                table: "City",
                column: "FormListId",
                principalTable: "formLists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_formLists_FormListId",
                table: "Country",
                column: "FormListId",
                principalTable: "formLists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_State_formLists_FormListId",
                table: "State",
                column: "FormListId",
                principalTable: "formLists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_formLists_FormListId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_formLists_FormListId",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_State_formLists_FormListId",
                table: "State");

            migrationBuilder.DropIndex(
                name: "IX_State_FormListId",
                table: "State");

            migrationBuilder.DropIndex(
                name: "IX_Country_FormListId",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_City_FormListId",
                table: "City");

            migrationBuilder.DropColumn(
                name: "FormListId",
                table: "State");

            migrationBuilder.DropColumn(
                name: "FormListId",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "FormListId",
                table: "City");

            migrationBuilder.AddColumn<int>(
                name: "CitiesId",
                table: "formLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "formLists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Countries",
                table: "formLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "formLists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "formLists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "states",
                table: "formLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_formLists_CityId",
                table: "formLists",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_formLists_CountryId",
                table: "formLists",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_formLists_StateId",
                table: "formLists",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_formLists_City_CityId",
                table: "formLists",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_formLists_Country_CountryId",
                table: "formLists",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_formLists_State_StateId",
                table: "formLists",
                column: "StateId",
                principalTable: "State",
                principalColumn: "Id");
        }
    }
}
