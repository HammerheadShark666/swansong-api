using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace SwanSong.Data.Migrations;

/// <inheritdoc />
public partial class addartistmembertable : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_SWSG_Member_SWSG_Artist_ArtistId",
            table: "SWSG_Member");

        migrationBuilder.CreateTable(
            name: "SWSG_ArtistMember",
            columns: table => new
            {
                Id = table.Column<long>(type: "bigint", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                ArtistId = table.Column<long>(type: "bigint", nullable: false),
                MemberId = table.Column<long>(type: "bigint", nullable: false),
                AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_SWSG_ArtistMember", x => x.Id);
                table.ForeignKey(
                    name: "FK_SWSG_ArtistMember_SWSG_Artist_ArtistId",
                    column: x => x.ArtistId,
                    principalTable: "SWSG_Artist",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_SWSG_ArtistMember_SWSG_Member_MemberId",
                    column: x => x.MemberId,
                    principalTable: "SWSG_Member",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });
    }
}