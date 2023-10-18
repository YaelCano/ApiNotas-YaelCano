using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Auditorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreUsuario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DesAccion = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditorias", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EstadoNotificacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreEstado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoNotificacions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Formatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombtreFormatos = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formatos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HiloRespuetasNot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombretipo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HiloRespuetasNot", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModulosMaestros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreModulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulosMaestros", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PermisosGenericos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombrePermiso = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisosGenericos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Radicados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radicados", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SubModulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreSubmodulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubModulos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoNotificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreTipo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoNotificaciones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TipoRequerimientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoRequerimientos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RolvsMaestros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rolesId = table.Column<int>(type: "int", nullable: true),
                    IdRolFk = table.Column<int>(type: "int", nullable: false),
                    MaestrosId = table.Column<int>(type: "int", nullable: true),
                    IdMaestroFk = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolvsMaestros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolvsMaestros_ModulosMaestros_MaestrosId",
                        column: x => x.MaestrosId,
                        principalTable: "ModulosMaestros",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RolvsMaestros_Rol_rolesId",
                        column: x => x.rolesId,
                        principalTable: "Rol",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MaestrosvsSubmodulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MaestrosId = table.Column<int>(type: "int", nullable: true),
                    IdMaestro = table.Column<int>(type: "int", nullable: false),
                    subModulosId = table.Column<int>(type: "int", nullable: true),
                    IsSubModulo = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaestrosvsSubmodulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MaestrosvsSubmodulos_ModulosMaestros_MaestrosId",
                        column: x => x.MaestrosId,
                        principalTable: "ModulosMaestros",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MaestrosvsSubmodulos_SubModulos_subModulosId",
                        column: x => x.subModulosId,
                        principalTable: "SubModulos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BlockChains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HashGenerado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AuditoriasId = table.Column<int>(type: "int", nullable: true),
                    IdAuditoriaFk = table.Column<int>(type: "int", nullable: false),
                    HiloRespuestaNotId = table.Column<int>(type: "int", nullable: true),
                    IdHiloRespuestaFk = table.Column<int>(type: "int", nullable: false),
                    TipoNotsId = table.Column<int>(type: "int", nullable: true),
                    IdNotificacionFk = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockChains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlockChains_Auditorias_AuditoriasId",
                        column: x => x.AuditoriasId,
                        principalTable: "Auditorias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlockChains_HiloRespuetasNot_HiloRespuestaNotId",
                        column: x => x.HiloRespuestaNotId,
                        principalTable: "HiloRespuetasNot",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlockChains_TipoNotificaciones_TipoNotsId",
                        column: x => x.TipoNotsId,
                        principalTable: "TipoNotificaciones",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModuloNotificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    asuntoNotificacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TextoNotificacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoNotificacioneId = table.Column<int>(type: "int", nullable: true),
                    IdNotificacionFk = table.Column<int>(type: "int", nullable: false),
                    RadicadosId = table.Column<int>(type: "int", nullable: true),
                    IdRadicado = table.Column<int>(type: "int", nullable: false),
                    EstadoNotId = table.Column<int>(type: "int", nullable: true),
                    IdEstadoNotificacionFk = table.Column<int>(type: "int", nullable: false),
                    HiloRespuestaNotId = table.Column<int>(type: "int", nullable: true),
                    IdHiloRespuestaFk = table.Column<int>(type: "int", nullable: false),
                    FormatosId = table.Column<int>(type: "int", nullable: true),
                    IdFormatoFk = table.Column<int>(type: "int", nullable: false),
                    TpRequerimientoId = table.Column<int>(type: "int", nullable: true),
                    IdRequerimiento = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModuloNotificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModuloNotificaciones_EstadoNotificacions_EstadoNotId",
                        column: x => x.EstadoNotId,
                        principalTable: "EstadoNotificacions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ModuloNotificaciones_Formatos_FormatosId",
                        column: x => x.FormatosId,
                        principalTable: "Formatos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ModuloNotificaciones_HiloRespuetasNot_HiloRespuestaNotId",
                        column: x => x.HiloRespuestaNotId,
                        principalTable: "HiloRespuetasNot",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ModuloNotificaciones_Radicados_RadicadosId",
                        column: x => x.RadicadosId,
                        principalTable: "Radicados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ModuloNotificaciones_TipoNotificaciones_TipoNotificacioneId",
                        column: x => x.TipoNotificacioneId,
                        principalTable: "TipoNotificaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ModuloNotificaciones_TipoRequerimientos_TpRequerimientoId",
                        column: x => x.TpRequerimientoId,
                        principalTable: "TipoRequerimientos",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "genericosvsSubmodulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PermisosGenerId = table.Column<int>(type: "int", nullable: true),
                    IdPermisosFk = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<int>(type: "int", nullable: true),
                    IdRolFk = table.Column<int>(type: "int", nullable: false),
                    MaestrosvsSubmodulosId = table.Column<int>(type: "int", nullable: true),
                    IdSubModulos = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genericosvsSubmodulos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_genericosvsSubmodulos_MaestrosvsSubmodulos_MaestrosvsSubmodu~",
                        column: x => x.MaestrosvsSubmodulosId,
                        principalTable: "MaestrosvsSubmodulos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_genericosvsSubmodulos_PermisosGenericos_PermisosGenerId",
                        column: x => x.PermisosGenerId,
                        principalTable: "PermisosGenericos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_genericosvsSubmodulos_Rol_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Rol",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BlockChains_AuditoriasId",
                table: "BlockChains",
                column: "AuditoriasId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockChains_HiloRespuestaNotId",
                table: "BlockChains",
                column: "HiloRespuestaNotId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockChains_TipoNotsId",
                table: "BlockChains",
                column: "TipoNotsId");

            migrationBuilder.CreateIndex(
                name: "IX_genericosvsSubmodulos_MaestrosvsSubmodulosId",
                table: "genericosvsSubmodulos",
                column: "MaestrosvsSubmodulosId");

            migrationBuilder.CreateIndex(
                name: "IX_genericosvsSubmodulos_PermisosGenerId",
                table: "genericosvsSubmodulos",
                column: "PermisosGenerId");

            migrationBuilder.CreateIndex(
                name: "IX_genericosvsSubmodulos_RolesId",
                table: "genericosvsSubmodulos",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_MaestrosvsSubmodulos_MaestrosId",
                table: "MaestrosvsSubmodulos",
                column: "MaestrosId");

            migrationBuilder.CreateIndex(
                name: "IX_MaestrosvsSubmodulos_subModulosId",
                table: "MaestrosvsSubmodulos",
                column: "subModulosId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificaciones_EstadoNotId",
                table: "ModuloNotificaciones",
                column: "EstadoNotId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificaciones_FormatosId",
                table: "ModuloNotificaciones",
                column: "FormatosId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificaciones_HiloRespuestaNotId",
                table: "ModuloNotificaciones",
                column: "HiloRespuestaNotId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificaciones_RadicadosId",
                table: "ModuloNotificaciones",
                column: "RadicadosId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificaciones_TipoNotificacioneId",
                table: "ModuloNotificaciones",
                column: "TipoNotificacioneId");

            migrationBuilder.CreateIndex(
                name: "IX_ModuloNotificaciones_TpRequerimientoId",
                table: "ModuloNotificaciones",
                column: "TpRequerimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_RolvsMaestros_MaestrosId",
                table: "RolvsMaestros",
                column: "MaestrosId");

            migrationBuilder.CreateIndex(
                name: "IX_RolvsMaestros_rolesId",
                table: "RolvsMaestros",
                column: "rolesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlockChains");

            migrationBuilder.DropTable(
                name: "genericosvsSubmodulos");

            migrationBuilder.DropTable(
                name: "ModuloNotificaciones");

            migrationBuilder.DropTable(
                name: "RolvsMaestros");

            migrationBuilder.DropTable(
                name: "Auditorias");

            migrationBuilder.DropTable(
                name: "MaestrosvsSubmodulos");

            migrationBuilder.DropTable(
                name: "PermisosGenericos");

            migrationBuilder.DropTable(
                name: "EstadoNotificacions");

            migrationBuilder.DropTable(
                name: "Formatos");

            migrationBuilder.DropTable(
                name: "HiloRespuetasNot");

            migrationBuilder.DropTable(
                name: "Radicados");

            migrationBuilder.DropTable(
                name: "TipoNotificaciones");

            migrationBuilder.DropTable(
                name: "TipoRequerimientos");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "ModulosMaestros");

            migrationBuilder.DropTable(
                name: "SubModulos");
        }
    }
}
