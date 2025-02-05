using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppCRUD.MVC.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nombreCompleto",
                table: "Empleado",
                newName: "NombreCompleto");

            migrationBuilder.RenameColumn(
                name: "fechaContrato",
                table: "Empleado",
                newName: "FechaContrato");

            migrationBuilder.RenameColumn(
                name: "correo",
                table: "Empleado",
                newName: "Correo");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "Empleado",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "idEmpleado",
                table: "Empleado",
                newName: "IdEmpleado");

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
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "NombreCompleto",
                table: "Empleado",
                newName: "nombreCompleto");

            migrationBuilder.RenameColumn(
                name: "FechaContrato",
                table: "Empleado",
                newName: "fechaContrato");

            migrationBuilder.RenameColumn(
                name: "Correo",
                table: "Empleado",
                newName: "correo");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "Empleado",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "IdEmpleado",
                table: "Empleado",
                newName: "idEmpleado");
        }
    }
}
