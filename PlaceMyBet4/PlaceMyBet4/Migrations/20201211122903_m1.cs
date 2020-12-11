using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaceMyBet4.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    EventoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EquipoLocal = table.Column<string>(nullable: true),
                    EquipoVisitante = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.EventoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    edad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Mercado",
                columns: table => new
                {
                    MercadoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OverUnder = table.Column<double>(nullable: false),
                    CuotaOver = table.Column<double>(nullable: false),
                    CuotaUnder = table.Column<double>(nullable: false),
                    DineroOver = table.Column<double>(nullable: false),
                    DineroUnder = table.Column<double>(nullable: false),
                    EventoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercado", x => x.MercadoId);
                    table.ForeignKey(
                        name: "FK_Mercado_Evento_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Evento",
                        principalColumn: "EventoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    CuentaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Saldo = table.Column<double>(nullable: false),
                    UsuarioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => x.CuentaId);
                    table.ForeignKey(
                        name: "FK_Cuenta_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apuesta",
                columns: table => new
                {
                    ApuestaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OverUnder = table.Column<double>(nullable: false),
                    Cuota = table.Column<double>(nullable: false),
                    tipoApuesta = table.Column<string>(nullable: true),
                    DineroApuesta = table.Column<double>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    EventoId = table.Column<int>(nullable: false),
                    MercadoId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apuesta", x => x.ApuestaId);
                    table.ForeignKey(
                        name: "FK_Apuesta_Mercado_MercadoId",
                        column: x => x.MercadoId,
                        principalTable: "Mercado",
                        principalColumn: "MercadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Apuesta_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Evento",
                columns: new[] { "EventoId", "EquipoLocal", "EquipoVisitante", "Fecha" },
                values: new object[] { 1, "Valencia", "Madrid", new DateTime(2020, 12, 11, 13, 29, 3, 25, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "apellido", "edad", "nombre" },
                values: new object[] { 1, "Monterde", 20, "Pau" });

            migrationBuilder.InsertData(
                table: "Cuenta",
                columns: new[] { "CuentaId", "Nombre", "Saldo", "UsuarioID" },
                values: new object[] { 100, "Santander", 123456789.0, 1 });

            migrationBuilder.InsertData(
                table: "Mercado",
                columns: new[] { "MercadoId", "CuotaOver", "CuotaUnder", "DineroOver", "DineroUnder", "EventoId", "OverUnder" },
                values: new object[] { 1000, 1.8999999999999999, 1.8999999999999999, 50.0, 50.0, 1, 1.5 });

            migrationBuilder.InsertData(
                table: "Apuesta",
                columns: new[] { "ApuestaId", "Cuota", "DineroApuesta", "EventoId", "Fecha", "MercadoId", "OverUnder", "UsuarioId", "tipoApuesta" },
                values: new object[] { 12, 1.8999999999999999, 20.0, 1, new DateTime(2020, 12, 11, 13, 29, 3, 32, DateTimeKind.Local).AddTicks(9514), 1000, 1.5, 1, "over" });

            migrationBuilder.CreateIndex(
                name: "IX_Apuesta_MercadoId",
                table: "Apuesta",
                column: "MercadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Apuesta_UsuarioId",
                table: "Apuesta",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuenta_UsuarioID",
                table: "Cuenta",
                column: "UsuarioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mercado_EventoId",
                table: "Mercado",
                column: "EventoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apuesta");

            migrationBuilder.DropTable(
                name: "Cuenta");

            migrationBuilder.DropTable(
                name: "Mercado");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Evento");
        }
    }
}
