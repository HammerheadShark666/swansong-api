using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwanSong.Data.Migrations;

/// <inheritdoc />
public partial class removeartistidfrommember : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        //migrationBuilder.DropForeignKey(
        //    name: "FK_SWSG_Member_SWSG_Artist_ArtistId",
        //    table: "SWSG_Member");

        migrationBuilder.DropIndex(
            name: "IX_SWSG_Member_ArtistId",
            table: "SWSG_Member");

        migrationBuilder.DropColumn(
            name: "ArtistId",
            table: "SWSG_Member");
    }
}