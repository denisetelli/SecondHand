using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    IdadeMinima = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Respostas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPergunta = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    DataInclusao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Respostas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Nota = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nota = table.Column<int>(nullable: false),
                    Comentario = table.Column<string>(nullable: true),
                    AvaliadorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Usuarios_AvaliadorId",
                        column: x => x.AvaliadorId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Anuncios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnuncianteId = table.Column<int>(nullable: true),
                    Titulo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    Localidade = table.Column<string>(nullable: true),
                    CategoriaId = table.Column<int>(nullable: true),
                    AvaliaçãoId = table.Column<int>(nullable: true),
                    Situacao = table.Column<int>(nullable: false),
                    IdComprador = table.Column<int>(nullable: false),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    DataVenda = table.Column<DateTime>(nullable: false),
                    DataCancelamento = table.Column<DateTime>(nullable: false),
                    DataBloqueio = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anuncios_Usuarios_AnuncianteId",
                        column: x => x.AnuncianteId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anuncios_Avaliacoes_AvaliaçãoId",
                        column: x => x.AvaliaçãoId,
                        principalTable: "Avaliacoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Anuncios_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Imagens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<byte[]>(nullable: true),
                    AnuncioId = table.Column<int>(nullable: true),
                    RespostaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Imagens_Anuncios_AnuncioId",
                        column: x => x.AnuncioId,
                        principalTable: "Anuncios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Imagens_Respostas_RespostaId",
                        column: x => x.RespostaId,
                        principalTable: "Respostas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Perguntas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdInteressado = table.Column<int>(nullable: false),
                    IdAnuncio = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: true),
                    RespostaId = table.Column<int>(nullable: true),
                    DataInclusao = table.Column<DateTime>(nullable: false),
                    AnuncioId = table.Column<int>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perguntas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Perguntas_Anuncios_AnuncioId",
                        column: x => x.AnuncioId,
                        principalTable: "Anuncios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Perguntas_Respostas_RespostaId",
                        column: x => x.RespostaId,
                        principalTable: "Respostas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Perguntas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Anuncios_AnuncianteId",
                table: "Anuncios",
                column: "AnuncianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Anuncios_AvaliaçãoId",
                table: "Anuncios",
                column: "AvaliaçãoId");

            migrationBuilder.CreateIndex(
                name: "IX_Anuncios_CategoriaId",
                table: "Anuncios",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_AvaliadorId",
                table: "Avaliacoes",
                column: "AvaliadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_AnuncioId",
                table: "Imagens",
                column: "AnuncioId");

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_RespostaId",
                table: "Imagens",
                column: "RespostaId");

            migrationBuilder.CreateIndex(
                name: "IX_Perguntas_AnuncioId",
                table: "Perguntas",
                column: "AnuncioId");

            migrationBuilder.CreateIndex(
                name: "IX_Perguntas_RespostaId",
                table: "Perguntas",
                column: "RespostaId");

            migrationBuilder.CreateIndex(
                name: "IX_Perguntas_UsuarioId",
                table: "Perguntas",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imagens");

            migrationBuilder.DropTable(
                name: "Perguntas");

            migrationBuilder.DropTable(
                name: "Anuncios");

            migrationBuilder.DropTable(
                name: "Respostas");

            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
