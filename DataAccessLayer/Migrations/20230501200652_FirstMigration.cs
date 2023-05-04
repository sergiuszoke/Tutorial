using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    latitude = table.Column<int>(type: "int", nullable: false),
                    longitude = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeatherStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeatherDays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    WeatherStatusId = table.Column<int>(type: "int", nullable: false),
                    MaxTemperature = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinTemperature = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverageHumidity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SunRise = table.Column<TimeSpan>(type: "time", nullable: false),
                    SunSet = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeatherDays_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeatherDays_WeatherStatus_WeatherStatusId",
                        column: x => x.WeatherStatusId,
                        principalTable: "WeatherStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeatherHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<TimeSpan>(type: "time", nullable: false),
                    End = table.Column<TimeSpan>(type: "time", nullable: false),
                    WeatherStatusId = table.Column<int>(type: "int", nullable: false),
                    Temperature = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RealisticTemperature = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Humidity = table.Column<int>(type: "int", nullable: false),
                    WindSpeed = table.Column<int>(type: "int", nullable: false),
                    Visibility = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeatherHours_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeatherHours_WeatherStatus_WeatherStatusId",
                        column: x => x.WeatherStatusId,
                        principalTable: "WeatherStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherDays_CityId",
                table: "WeatherDays",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherDays_WeatherStatusId",
                table: "WeatherDays",
                column: "WeatherStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherHours_CityId",
                table: "WeatherHours",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherHours_WeatherStatusId",
                table: "WeatherHours",
                column: "WeatherStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherDays");

            migrationBuilder.DropTable(
                name: "WeatherHours");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "WeatherStatus");
        }
    }
}
