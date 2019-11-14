using Microsoft.EntityFrameworkCore.Migrations;

namespace UserMentor.Migrations
{
    public partial class UserMig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mentor",
                columns: table => new
                {
                    Mentor_Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mentor_Name = table.Column<string>(nullable: false),
                    Mentor_Mobile = table.Column<long>(nullable: false),
                    Mentor_Email = table.Column<string>(nullable: false),
                    Mentor_Exp = table.Column<string>(nullable: false),
                    Mentor_PrimarySkill = table.Column<string>(nullable: true),
                    Mentor_From_TimeSlot = table.Column<string>(nullable: true),
                    Mentor_To_TimeSlot = table.Column<string>(nullable: true),
                    Mentor_Availability = table.Column<bool>(nullable: true),
                    Mentor_active = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentor", x => x.Mentor_Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    User_Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_Name = table.Column<string>(nullable: false),
                    User_Email = table.Column<string>(nullable: false),
                    User_Mobile = table.Column<long>(nullable: false),
                    User_active = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.User_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mentor");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
