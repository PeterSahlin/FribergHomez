using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FribergHomez.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Firms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Presentation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageLocation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RealEstateAgents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealEstateAgents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RealEstateAgents_Firms_FirmId",
                        column: x => x.FirmId,
                        principalTable: "Firms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SaleObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartingPrice = table.Column<int>(type: "int", nullable: false),
                    LivingArea = table.Column<int>(type: "int", nullable: false),
                    AncillaryArea = table.Column<int>(type: "int", nullable: false),
                    PlotArea = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfRooms = table.Column<int>(type: "int", nullable: false),
                    MonthlyFee = table.Column<int>(type: "int", nullable: false),
                    OperatingCostPerYear = table.Column<int>(type: "int", nullable: false),
                    YearOfConstruction = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RealEstateAgentId = table.Column<int>(type: "int", nullable: true),
                    MunicipalityId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleObjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaleObjects_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleObjects_Municipalities_MunicipalityId",
                        column: x => x.MunicipalityId,
                        principalTable: "Municipalities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleObjects_RealEstateAgents_RealEstateAgentId",
                        column: x => x.RealEstateAgentId,
                        principalTable: "RealEstateAgents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RealEstateAgents_FirmId",
                table: "RealEstateAgents",
                column: "FirmId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleObjects_CategoryId",
                table: "SaleObjects",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleObjects_MunicipalityId",
                table: "SaleObjects",
                column: "MunicipalityId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleObjects_RealEstateAgentId",
                table: "SaleObjects",
                column: "RealEstateAgentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleObjects");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropTable(
                name: "RealEstateAgents");

            migrationBuilder.DropTable(
                name: "Firms");
        }
    }
}
