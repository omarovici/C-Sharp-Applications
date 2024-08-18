using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_01_EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_Dep_IdId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "Dep_IdId",
                table: "Student",
                newName: "DepartmentIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_Dep_IdId",
                table: "Student",
                newName: "IX_Student_DepartmentIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_DepartmentIdId",
                table: "Student",
                column: "DepartmentIdId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_DepartmentIdId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "DepartmentIdId",
                table: "Student",
                newName: "Dep_IdId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_DepartmentIdId",
                table: "Student",
                newName: "IX_Student_Dep_IdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_Dep_IdId",
                table: "Student",
                column: "Dep_IdId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
