using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission06_Martin.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    movieID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    movieCategory = table.Column<string>(type: "TEXT", nullable: false),
                    movieTitle = table.Column<string>(type: "TEXT", nullable: false),
                    movieYear = table.Column<int>(type: "INTEGER", nullable: false),
                    movieDirector = table.Column<string>(type: "TEXT", nullable: false),
                    movieRating = table.Column<string>(type: "TEXT", nullable: false),
                    movieLentTo = table.Column<string>(type: "TEXT", nullable: true),
                    movieEdited = table.Column<bool>(type: "INTEGER", nullable: true),
                    movieNotes = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.movieID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
