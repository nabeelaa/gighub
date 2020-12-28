using Microsoft.EntityFrameworkCore.Migrations;

namespace Gighub.Data.Migrations
{
    public partial class PopulateGenresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
            table: "Genres",
            columns: new[] { "Id", "Name" },
            values: new object[] { "1", "Jazz" });

            migrationBuilder.InsertData(
            table: "Genres",
            columns: new[] { "Id", "Name" },
            values: new object[] { "2", "Rock" });

            migrationBuilder.InsertData(
            table: "Genres",
            columns: new[] { "Id", "Name" },
            values: new object[] { "3", "Pop" });

            migrationBuilder.InsertData(
            table: "Genres",
            columns: new[] { "Id", "Name" },
            values: new object[] { "4", "Country" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Genres", true);
        }
    }
}
