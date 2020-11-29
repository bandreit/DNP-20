using Microsoft.EntityFrameworkCore.Migrations;

namespace DNP_A4_Server.Migrations
{
    public partial class CascadeOnDeleteForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adult_Families_FamilyId",
                table: "Adult");

            migrationBuilder.DropForeignKey(
                name: "FK_Child_Families_FamilyId",
                table: "Child");

            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Child_ChildId",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Families_FamilyId",
                table: "Pet");

            migrationBuilder.AddForeignKey(
                name: "FK_Adult_Families_FamilyId",
                table: "Adult",
                column: "FamilyId",
                principalTable: "Families",
                principalColumn: "Id",
                onUpdate: ReferentialAction.Cascade,
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Families_FamilyId",
                table: "Child",
                column: "FamilyId",
                principalTable: "Families",
                principalColumn: "Id",
                onUpdate: ReferentialAction.Cascade,
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Child_ChildId",
                table: "Pet",
                column: "ChildId",
                principalTable: "Child",
                principalColumn: "Id",
                onUpdate: ReferentialAction.Cascade,
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Families_FamilyId",
                table: "Pet",
                column: "FamilyId",
                principalTable: "Families",
                principalColumn: "Id",
                onUpdate: ReferentialAction.Cascade,
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adult_Families_FamilyId",
                table: "Adult");

            migrationBuilder.DropForeignKey(
                name: "FK_Child_Families_FamilyId",
                table: "Child");

            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Child_ChildId",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Families_FamilyId",
                table: "Pet");

            migrationBuilder.AddForeignKey(
                name: "FK_Adult_Families_FamilyId",
                table: "Adult",
                column: "FamilyId",
                principalTable: "Families",
                principalColumn: "Id",
                onUpdate: ReferentialAction.Restrict,
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Families_FamilyId",
                table: "Child",
                column: "FamilyId",
                principalTable: "Families",
                principalColumn: "Id",
                onUpdate: ReferentialAction.Restrict,
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Child_ChildId",
                table: "Pet",
                column: "ChildId",
                principalTable: "Child",
                principalColumn: "Id",
                onUpdate: ReferentialAction.Restrict,
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Families_FamilyId",
                table: "Pet",
                column: "FamilyId",
                principalTable: "Families",
                principalColumn: "Id",
                onUpdate: ReferentialAction.Restrict,
                onDelete: ReferentialAction.Restrict);
        }
    }
}
