using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCCoreUsersWebAPIDemo.Migrations
{
    public partial class Initialization1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    website = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "email", "name", "phone", "username", "website" },
                values: new object[,]
                {
                    { 1, "Sincere@april.biz", "Leanne Graham", "1-770-736-8031", "Bret", "hildegard.org" },
                    { 2, "Shanna@melissa.tv", "Ervin Howell", "010-692-6593", "Antonette", "anastasia.net" },
                    { 3, "Nathan@yesenia.net", "Clementine Bauch", "1-463-123-4447", "Samantha", "ramiro.info" },
                    { 4, "Julianne.OConner@kory.org", "Patricia Lebsack", "493-170-9623", "Karianne", "kale.biz" },
                    { 5, "Lucio_Hettinger@annie.ca", "Chelsey Dietrich", "(254)954-1289", "Kamren", "demarco.info" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
