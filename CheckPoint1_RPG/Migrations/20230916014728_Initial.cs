using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CheckPoint1_RPG.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Idade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Classe = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Vida = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Dano_fisico = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Dano_magico = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Res_magica = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Res_fisica = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagens", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personagens");
        }
    }
}
