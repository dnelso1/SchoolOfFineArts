using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolOfFineArtsDB.Migrations
{
    public partial class CreateCoursesInfoView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR ALTER VIEW vwCoursesInfo

                                    AS

                                    SELECT ce.CourseId, CONCAT(c.Abbreviation, ' - ', c.Name) as Course, c.Department, c.TeacherId, CONCAT(t.LastName, ', ', t.FirstName) as TeacherName, ce.StudentId, CONCAT(s.LastName, ', ', s.FirstName) as StudentName
                                    FROM CourseEnrollment ce
                                    JOIN Courses c ON c.Id = ce.CourseId
                                    JOIN Students s ON s.Id = ce.StudentId
                                    JOIN Teachers t ON c.TeacherId = t.Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF EXISTS (SELECT 1 FROM sys.views WHERE OBJECT_ID=OBJECT_ID('dbo.vwCoursesInfo'))
                                    BEGIN
                                        DROP VIEW dbo.vwCoursesInfo
                                    END");
        }
    }
}
