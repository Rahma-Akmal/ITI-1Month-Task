using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITIProject.Migrations
{
    /// <inheritdoc />
    public partial class kk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Departments",
                newName: "DeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeptId",
                table: "Departments",
                newName: "Id");
        }
    }
}
