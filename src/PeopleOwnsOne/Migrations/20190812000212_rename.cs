using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleOwnsOne.Migrations
{
    public partial class rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAddress_Address",
                table: "People",
                newName: "EmailAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "People",
                newName: "EmailAddress_Address");
        }
    }
}
