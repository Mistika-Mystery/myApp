using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace myApp.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IDRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IDRole);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IDUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdRole = table.Column<int>(type: "int", nullable: false),
                    RoleIDRole = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IDUser);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleIDRole",
                        column: x => x.RoleIDRole,
                        principalTable: "Roles",
                        principalColumn: "IDRole");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleIDRole",
                table: "Users",
                column: "RoleIDRole");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
