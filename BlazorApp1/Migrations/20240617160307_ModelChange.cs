using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class ModelChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userSettings");

            migrationBuilder.CreateTable(
                name: "userProfiles",
                columns: table => new
                {
                    UserProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Theme = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Notificationpreferences = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Userid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userProfiles", x => x.UserProfileId);
                    table.ForeignKey(
                        name: "FK_userProfiles_users_Userid",
                        column: x => x.Userid,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_userProfiles_Userid",
                table: "userProfiles",
                column: "Userid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userProfiles");

            migrationBuilder.CreateTable(
                name: "userSettings",
                columns: table => new
                {
                    UserSettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Userid = table.Column<int>(type: "int", nullable: false),
                    Notificationpreferences = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Theme = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userSettings", x => x.UserSettingId);
                    table.ForeignKey(
                        name: "FK_userSettings_users_Userid",
                        column: x => x.Userid,
                        principalTable: "users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_userSettings_Userid",
                table: "userSettings",
                column: "Userid",
                unique: true);
        }
    }
}
