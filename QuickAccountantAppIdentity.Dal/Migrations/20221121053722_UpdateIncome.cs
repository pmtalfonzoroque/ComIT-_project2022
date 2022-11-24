using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuickAccountantAppIdentity.Dal.Migrations
{
    public partial class UpdateIncome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "IncomeType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IncomeTypeID",
                table: "IncomeRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IncomeRecord_IncomeTypeID",
                table: "IncomeRecord",
                column: "IncomeTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeRecord_IncomeType_IncomeTypeID",
                table: "IncomeRecord",
                column: "IncomeTypeID",
                principalTable: "IncomeType",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeRecord_IncomeType_IncomeTypeID",
                table: "IncomeRecord");

            migrationBuilder.DropIndex(
                name: "IX_IncomeRecord_IncomeTypeID",
                table: "IncomeRecord");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "IncomeType");

            migrationBuilder.DropColumn(
                name: "IncomeTypeID",
                table: "IncomeRecord");
        }
    }
}
