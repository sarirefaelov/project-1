using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class onetomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "List_turn",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "List_turn",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_List_turn_ClientId",
                table: "List_turn",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_List_turn_DoctorId",
                table: "List_turn",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_List_turn_List_doctor_DoctorId",
                table: "List_turn",
                column: "DoctorId",
                principalTable: "List_doctor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_List_turn_List_patient_ClientId",
                table: "List_turn",
                column: "ClientId",
                principalTable: "List_patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_List_turn_List_doctor_DoctorId",
                table: "List_turn");

            migrationBuilder.DropForeignKey(
                name: "FK_List_turn_List_patient_ClientId",
                table: "List_turn");

            migrationBuilder.DropIndex(
                name: "IX_List_turn_ClientId",
                table: "List_turn");

            migrationBuilder.DropIndex(
                name: "IX_List_turn_DoctorId",
                table: "List_turn");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "List_turn");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "List_turn");
        }
    }
}
