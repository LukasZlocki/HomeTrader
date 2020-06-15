using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeTrader.Data.Migrations
{
    public partial class UpdateCompanymodelwithdescritpionfirld : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Balance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(nullable: false),
                    ComapanyName = table.Column<string>(nullable: true),
                    RaportYear = table.Column<int>(nullable: false),
                    AktywaTrwale = table.Column<int>(nullable: false),
                    AktywaObrotowe = table.Column<int>(nullable: false),
                    AktywaRazem = table.Column<int>(nullable: false),
                    KapitalWlasnyAkcjonariuszyJednostkiDominujacej = table.Column<int>(nullable: false),
                    UdzialyNiekontrolujace = table.Column<int>(nullable: false),
                    ZobowiazaniaDlugoterminowe = table.Column<int>(nullable: false),
                    ZobowiazaniaKrotkoterminowe = table.Column<int>(nullable: false),
                    PasywaRazem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CashFlow",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(nullable: false),
                    ComapanyName = table.Column<string>(nullable: true),
                    RaportYear = table.Column<int>(nullable: false),
                    PrzeplywyZDzialalnosciOperacyjnej = table.Column<int>(nullable: false),
                    PrzeplywyZDzialalnosciInvestycyjnej = table.Column<int>(nullable: false),
                    PrzeplywyZDzialalnosciFinansowej = table.Column<int>(nullable: false),
                    PrzeplywyRazem = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CashFlow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Ticker = table.Column<string>(nullable: true),
                    Index = table.Column<string>(nullable: true),
                    ISIN = table.Column<string>(nullable: true),
                    CompanyDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfitAndLose",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(nullable: false),
                    ComapanyName = table.Column<string>(nullable: true),
                    RaportYear = table.Column<int>(nullable: false),
                    PrzychodyZeSprzedazy = table.Column<int>(nullable: false),
                    ZyskZeSprzedazy = table.Column<int>(nullable: false),
                    ZyskOperacyjny = table.Column<int>(nullable: false),
                    ZyskZDzialalnosciGospodarczej = table.Column<int>(nullable: false),
                    ZyskPrzedOpodatkowaniem = table.Column<int>(nullable: false),
                    ZyskNetto = table.Column<int>(nullable: false),
                    ZyskNettoAkcjonariuszyJednostkiDominujacej = table.Column<int>(nullable: false),
                    EBITDA = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfitAndLose", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Balance");

            migrationBuilder.DropTable(
                name: "CashFlow");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "ProfitAndLose");
        }
    }
}
