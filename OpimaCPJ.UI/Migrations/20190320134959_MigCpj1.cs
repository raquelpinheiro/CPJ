using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OpimaCPJ.Web.Migrations
{
    public partial class MigCpj1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rua",
                table: "Endereco");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "Endereco",
                newName: "CEP");

            migrationBuilder.RenameColumn(
                name: "TelefoneResidencial",
                table: "Endereco",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "TelefoneCelular",
                table: "Endereco",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "CodigoBairro",
                table: "Endereco",
                newName: "PessoaCodigo");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Endereco",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Endereco",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Endereco",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Endereco",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "Endereco",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PessoaFisica",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TelefoneResidencial = table.Column<string>(nullable: true),
                    TelefoneCelular = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    Profissao = table.Column<string>(nullable: true),
                    Nacionalidade = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NomePai = table.Column<string>(nullable: true),
                    NomeMae = table.Column<string>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    NumeroOAB = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaFisica", x => x.Codigo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_PessoaCodigo",
                table: "Endereco",
                column: "PessoaCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_PessoaFisica_PessoaCodigo",
                table: "Endereco",
                column: "PessoaCodigo",
                principalTable: "PessoaFisica",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_PessoaFisica_PessoaCodigo",
                table: "Endereco");

            migrationBuilder.DropTable(
                name: "PessoaFisica");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_PessoaCodigo",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "Endereco");

            migrationBuilder.RenameColumn(
                name: "CEP",
                table: "Endereco",
                newName: "Cep");

            migrationBuilder.RenameColumn(
                name: "PessoaCodigo",
                table: "Endereco",
                newName: "CodigoBairro");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Endereco",
                newName: "TelefoneResidencial");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "Endereco",
                newName: "TelefoneCelular");

            migrationBuilder.AlterColumn<string>(
                name: "Numero",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Complemento",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cep",
                table: "Endereco",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 8);

            migrationBuilder.AddColumn<string>(
                name: "Rua",
                table: "Endereco",
                nullable: true);
        }
    }
}
