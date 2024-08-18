using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_01_EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class StudentCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Student",
                newName: "Dep_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course",
                columns: new[] { "StudentId", "CourseId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst",
                columns: new[] { "CourseId", "InstructorId" });

            migrationBuilder.CreateIndex(
                name: "IX_Student_Dep_IdId",
                table: "Student",
                column: "Dep_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Course_CourseId",
                table: "Stud_Course",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Course_CourseId",
                table: "Stud_Course",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Course_Student_StudentId",
                table: "Stud_Course",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_Dep_IdId",
                table: "Student",
                column: "Dep_Id",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Course_CourseId",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Course_Student_StudentId",
                table: "Stud_Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_Dep_IdId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_Dep_IdId",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Course");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Course_CourseId",
                table: "Stud_Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst");

            migrationBuilder.RenameColumn(
                name: "Dep_IdId",
                table: "Student",
                newName: "DepartmentId");
        }
    }
}
