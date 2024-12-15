using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clinic.Data.Migrations
{
    /// <inheritdoc />
    public partial class manytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientcsClassDoctorClass",
                columns: table => new
                {
                    ClientcsId = table.Column<int>(type: "int", nullable: false),
                    DoctorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientcsClassDoctorClass", x => new { x.ClientcsId, x.DoctorsId });
                    table.ForeignKey(
                        name: "FK_ClientcsClassDoctorClass_List_doctor_DoctorsId",
                        column: x => x.DoctorsId,
                        principalTable: "List_doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientcsClassDoctorClass_List_patient_ClientcsId",
                        column: x => x.ClientcsId,
                        principalTable: "List_patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientcsClassDoctorClass_DoctorsId",
                table: "ClientcsClassDoctorClass",
                column: "DoctorsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientcsClassDoctorClass");
        }
    }
}
