using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "varchar(55)", maxLength: 55, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanıcılar",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    KullaniciAdi = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Sifre = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    KullaniciTipi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcılar", x => x.KullaniciID);
                });

            migrationBuilder.CreateTable(
                name: "YayınEvleri",
                columns: table => new
                {
                    YayinEviID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YayinEviAdi = table.Column<string>(type: "varchar(55)", maxLength: 55, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YayınEvleri", x => x.YayinEviID);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlar",
                columns: table => new
                {
                    YazarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdi = table.Column<string>(type: "varchar(55)", maxLength: 55, nullable: false),
                    YazarSoyadi = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    KitapID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlar", x => x.YazarID);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    KitapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAdi = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Fiyat = table.Column<decimal>(type: "money", nullable: false),
                    BasimYili = table.Column<int>(type: "int", nullable: false),
                    BaskiSayisi = table.Column<int>(type: "int", nullable: false),
                    ISBN = table.Column<int>(type: "int", nullable: false),
                    KitapOzeti = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    AlmaTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    IadeTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    YayinEviID = table.Column<int>(type: "int", nullable: false),
                    YazarID = table.Column<int>(type: "int", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.KitapID);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Kullanıcılar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanıcılar",
                        principalColumn: "KullaniciID");
                    table.ForeignKey(
                        name: "FK_Kitaplar_YayınEvleri_YayinEviID",
                        column: x => x.YayinEviID,
                        principalTable: "YayınEvleri",
                        principalColumn: "YayinEviID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitapYazar",
                columns: table => new
                {
                    KitaplarKitapID = table.Column<int>(type: "int", nullable: false),
                    YazarlarYazarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapYazar", x => new { x.KitaplarKitapID, x.YazarlarYazarID });
                    table.ForeignKey(
                        name: "FK_KitapYazar_Kitaplar_KitaplarKitapID",
                        column: x => x.KitaplarKitapID,
                        principalTable: "Kitaplar",
                        principalColumn: "KitapID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KitapYazar_Yazarlar_YazarlarYazarID",
                        column: x => x.YazarlarYazarID,
                        principalTable: "Yazarlar",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KategoriID",
                table: "Kitaplar",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KullaniciID",
                table: "Kitaplar",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_YayinEviID",
                table: "Kitaplar",
                column: "YayinEviID");

            migrationBuilder.CreateIndex(
                name: "IX_KitapYazar_YazarlarYazarID",
                table: "KitapYazar",
                column: "YazarlarYazarID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KitapYazar");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Yazarlar");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Kullanıcılar");

            migrationBuilder.DropTable(
                name: "YayınEvleri");
        }
    }
}
