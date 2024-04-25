using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FribergHomez.Migrations
{
    /// <inheritdoc />
    public partial class triedtofixseed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleObjects_RealEstateAgents_RealEstateAgentId",
                table: "SaleObjects");

            migrationBuilder.AlterColumn<int>(
                name: "RealEstateAgentId",
                table: "SaleObjects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleObjects_RealEstateAgents_RealEstateAgentId",
                table: "SaleObjects",
                column: "RealEstateAgentId",
                principalTable: "RealEstateAgents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleObjects_RealEstateAgents_RealEstateAgentId",
                table: "SaleObjects");

            migrationBuilder.AlterColumn<int>(
                name: "RealEstateAgentId",
                table: "SaleObjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleObjects_RealEstateAgents_RealEstateAgentId",
                table: "SaleObjects",
                column: "RealEstateAgentId",
                principalTable: "RealEstateAgents",
                principalColumn: "Id");
        }
    }
}
