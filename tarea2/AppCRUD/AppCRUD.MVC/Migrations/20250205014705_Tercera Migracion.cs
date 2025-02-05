using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppCRUD.MVC.Migrations
{
    /// <inheritdoc />
    public partial class TerceraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Departamentos_IdDepartamentoID",
                table: "Empleado");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropIndex(
                name: "IX_Empleado_IdDepartamentoID",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "IdDepartamentoID",
                table: "Empleado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdDepartamentoID",
                table: "Empleado",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroEmpleados = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_IdDepartamentoID",
                table: "Empleado",
                column: "IdDepartamentoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Departamentos_IdDepartamentoID",
                table: "Empleado",
                column: "IdDepartamentoID",
                principalTable: "Departamentos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
