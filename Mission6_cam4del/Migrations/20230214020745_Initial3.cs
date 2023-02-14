using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_cam4del.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lent_to = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "category", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Action", "John Singleton", false, "Cameron Delgrosso", "Very fast, not very furious", "PG-13", "2 Fast 2 Furious", 2003 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "category", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Comedy", "Phil Lord", true, "Cameron Delgrosso", "Jonah Hill is funny", "R", "21 Jump Street", 2012 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "category", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Action", "Joseph Kosinski", false, "Cameron Delgrosso", "Gave me chills", "PG-13", "Top Gun Maverick", 2022 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
