using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FribergHomez.Migrations
{
    /// <inheritdoc />
    public partial class madeREAidentityuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleObjects_RealEstateAgents_RealEstateAgentId",
                table: "SaleObjects");

            migrationBuilder.DropTable(
                name: "RealEstateAgents");

            migrationBuilder.DropIndex(
                name: "IX_SaleObjects_RealEstateAgentId",
                table: "SaleObjects");

            migrationBuilder.AddColumn<string>(
                name: "RealEstateAgentId1",
                table: "SaleObjects",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FirmId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SaleObjects_RealEstateAgentId1",
                table: "SaleObjects",
                column: "RealEstateAgentId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FirmId",
                table: "AspNetUsers",
                column: "FirmId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Firms_FirmId",
                table: "AspNetUsers",
                column: "FirmId",
                principalTable: "Firms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleObjects_AspNetUsers_RealEstateAgentId1",
                table: "SaleObjects",
                column: "RealEstateAgentId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Firms_FirmId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleObjects_AspNetUsers_RealEstateAgentId1",
                table: "SaleObjects");

            migrationBuilder.DropIndex(
                name: "IX_SaleObjects_RealEstateAgentId1",
                table: "SaleObjects");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FirmId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RealEstateAgentId1",
                table: "SaleObjects");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirmId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "RealEstateAgents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmId = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_SaleObjects_RealEstateAgentId",
                table: "SaleObjects",
                column: "RealEstateAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstateAgents_FirmId",
                table: "RealEstateAgents",
                column: "FirmId");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleObjects_RealEstateAgents_RealEstateAgentId",
                table: "SaleObjects",
                column: "RealEstateAgentId",
                principalTable: "RealEstateAgents",
                principalColumn: "Id");
        }
    }
}
