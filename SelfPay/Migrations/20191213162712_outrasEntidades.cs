using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SelfPay.Migrations
{
    public partial class outrasEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "produto_precoPromo",
                table: "Produto",
                newName: "Produto_precoPromo");

            migrationBuilder.RenameColumn(
                name: "produto_preco",
                table: "Produto",
                newName: "Produto_preco");

            migrationBuilder.RenameColumn(
                name: "produto_nome",
                table: "Produto",
                newName: "Produto_nome");

            migrationBuilder.RenameColumn(
                name: "produto_desc",
                table: "Produto",
                newName: "Produto_desc");

            migrationBuilder.RenameColumn(
                name: "produto_ativo",
                table: "Produto",
                newName: "Produto_ativo");

            migrationBuilder.RenameColumn(
                name: "produto_id",
                table: "Produto",
                newName: "Produto_id");

            migrationBuilder.AddColumn<int>(
                name: "PedidoItens_id",
                table: "Produto",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Categoria_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Categoria_nome = table.Column<string>(nullable: true),
                    Categoria_ativo = table.Column<string>(nullable: true),
                    Categoria_dataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Categoria_id);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoCategoria",
                columns: table => new
                {
                    Categoria_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Produto_id = table.Column<int>(nullable: false),
                    ProdutoCategoria_dataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoCategoria", x => x.Categoria_id);
                });

            migrationBuilder.CreateTable(
                name: "Carrinhoitens",
                columns: table => new
                {
                    CarrinhoItens_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CarrinhoItens_carrinho_id = table.Column<int>(nullable: false),
                    Carrinhoitens_produto_id = table.Column<int>(nullable: false),
                    CarrinhoItens_valorUnitario = table.Column<decimal>(nullable: false),
                    CarrinhoItens_valorTotalItem = table.Column<decimal>(nullable: false),
                    CarrinhoItens_quantidade = table.Column<int>(nullable: false),
                    CarrinhoItens_dataCadatro = table.Column<DateTime>(nullable: false),
                    Carrinho_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinhoitens", x => x.CarrinhoItens_id);
                });

            migrationBuilder.CreateTable(
                name: "PedidoItens",
                columns: table => new
                {
                    PedidoItens_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Pedidoitens_pedido_id = table.Column<int>(nullable: false),
                    PedidoItens_valorTotal = table.Column<decimal>(nullable: false),
                    PedidoItens_valorUnidade = table.Column<decimal>(nullable: false),
                    PedidoItens_quantidade = table.Column<int>(nullable: false),
                    PedidoItens_produto_id = table.Column<int>(nullable: false),
                    PedidoItens_dataCadastro = table.Column<DateTime>(nullable: false),
                    CarrinhoItens_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoItens", x => x.PedidoItens_id);
                    table.ForeignKey(
                        name: "FK_PedidoItens_Carrinhoitens_CarrinhoItens_id",
                        column: x => x.CarrinhoItens_id,
                        principalTable: "Carrinhoitens",
                        principalColumn: "CarrinhoItens_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Pedido_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Pedido_valor = table.Column<decimal>(nullable: false),
                    CarrinhoItens_id = table.Column<int>(nullable: false),
                    Pedido_dataCadastro = table.Column<DateTime>(nullable: false),
                    PedidoItens_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Pedido_id);
                    table.ForeignKey(
                        name: "FK_Pedido_PedidoItens_PedidoItens_id",
                        column: x => x.PedidoItens_id,
                        principalTable: "PedidoItens",
                        principalColumn: "PedidoItens_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carrinho",
                columns: table => new
                {
                    Carrinho_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Carrinho_dataCadastro = table.Column<DateTime>(nullable: false),
                    Cliente_id = table.Column<int>(nullable: false),
                    Carrinho_total = table.Column<decimal>(nullable: false),
                    Pedido_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinho", x => x.Carrinho_id);
                    table.ForeignKey(
                        name: "FK_Carrinho_Pedido_Pedido_id",
                        column: x => x.Pedido_id,
                        principalTable: "Pedido",
                        principalColumn: "Pedido_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Cliente_id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Carrinho_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Cliente_id);
                    table.ForeignKey(
                        name: "FK_Cliente_Carrinho_Carrinho_id",
                        column: x => x.Carrinho_id,
                        principalTable: "Carrinho",
                        principalColumn: "Carrinho_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_PedidoItens_id",
                table: "Produto",
                column: "PedidoItens_id");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_Pedido_id",
                table: "Carrinho",
                column: "Pedido_id");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinhoitens_Carrinho_id",
                table: "Carrinhoitens",
                column: "Carrinho_id");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Carrinho_id",
                table: "Cliente",
                column: "Carrinho_id");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_PedidoItens_id",
                table: "Pedido",
                column: "PedidoItens_id");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoItens_CarrinhoItens_id",
                table: "PedidoItens",
                column: "CarrinhoItens_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_PedidoItens_PedidoItens_id",
                table: "Produto",
                column: "PedidoItens_id",
                principalTable: "PedidoItens",
                principalColumn: "PedidoItens_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carrinhoitens_Carrinho_Carrinho_id",
                table: "Carrinhoitens",
                column: "Carrinho_id",
                principalTable: "Carrinho",
                principalColumn: "Carrinho_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_PedidoItens_PedidoItens_id",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Carrinho_Pedido_Pedido_id",
                table: "Carrinho");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "ProdutoCategoria");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "PedidoItens");

            migrationBuilder.DropTable(
                name: "Carrinhoitens");

            migrationBuilder.DropTable(
                name: "Carrinho");

            migrationBuilder.DropIndex(
                name: "IX_Produto_PedidoItens_id",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "PedidoItens_id",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "Produto_precoPromo",
                table: "Produto",
                newName: "produto_precoPromo");

            migrationBuilder.RenameColumn(
                name: "Produto_preco",
                table: "Produto",
                newName: "produto_preco");

            migrationBuilder.RenameColumn(
                name: "Produto_nome",
                table: "Produto",
                newName: "produto_nome");

            migrationBuilder.RenameColumn(
                name: "Produto_desc",
                table: "Produto",
                newName: "produto_desc");

            migrationBuilder.RenameColumn(
                name: "Produto_ativo",
                table: "Produto",
                newName: "produto_ativo");

            migrationBuilder.RenameColumn(
                name: "Produto_id",
                table: "Produto",
                newName: "produto_id");
        }
    }
}
