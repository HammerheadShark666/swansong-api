using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwanSong.Data.Migrations
{
    /// <inheritdoc />
    public partial class adddescriptiontomember : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SWSG_Member",
                type: "varchar(MAX)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5421), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5424) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5436), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5443), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5447), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5451), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5457), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5458) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5461), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5466), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5471), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5476), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5481), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5485), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5489), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5493), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5497), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5501), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5505), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5510), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5514), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5518), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5521), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5525), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5529), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6753), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6762), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6766), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6769), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6773), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6778), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6783), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6786), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6790), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6795), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6798), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6802), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6806), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6810), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6813), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6817), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6821), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6825), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6829), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6833), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6837), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6841), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6842) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6844), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6848), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6853), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6856), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6858) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6898), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6903), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6906), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6910), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6914), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6922), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6927), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6930), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6934), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6938), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6942), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6945), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6949), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6953), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6956), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6961), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6965), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6968), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6972), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6976), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6979), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6983), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6987), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6991), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6994), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6998), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7002), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7005), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7009), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7013), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7016), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7020), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7024), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7028), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7032), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7036), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7039), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7043), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7048), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7052), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7055), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7059), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7063), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7066), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7071), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7079), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7082), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7089), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7093), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7097), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7104), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7108), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7112), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7116), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7120), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7127), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7131), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7138), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7143), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7147), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7151), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7154), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7158), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7162), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7165), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7173), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7181), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7188), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7257), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7261), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7265), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7269), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7272), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7276), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7280), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7283), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7287), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7291), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7294), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7298), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7307), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7314), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7318), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7321), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7325), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7329), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7333), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7337), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7340), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7344), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7347), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7351), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7355), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7360), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7364), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7367), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7372), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7376), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7379), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7381) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7383), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7387), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7391), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7394), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7398), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7402), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7406), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7409), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7417), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7420), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7424), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7428), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7431), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7435), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7440), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7443), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7447), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7451), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7454), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7458), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7462), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7465), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7469), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7473), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7476), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7481) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7484), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7487), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7491), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7495), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7499), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7507), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7511), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7515), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7555), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7559), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7563), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7566), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7570), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7574), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7578), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7581), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7585), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7589), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7592), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7596), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7600), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7603), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7607), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7612), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7616), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7620), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7623), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7627), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7631), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7634), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7636) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7638), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7642), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7646), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7649), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7653), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7657), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7660), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7664), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7668), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7671), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7675), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7683), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7687), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7691), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7694), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7698), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7702), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7705), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7709), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7713), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7717), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7724), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7728), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7731), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7735), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7739), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7742), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7747), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7754), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7758), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7761), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7765), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7769), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7773), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7776), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7780), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7784), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7787), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7791), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7795), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7799), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7802), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7806), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7810), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7813), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4902), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4913), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4918), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4922), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4931), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4935), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4940), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4944), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4949), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4953), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4958), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4962), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4966), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4971), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4975), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4980), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4985), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4990), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4994), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4593), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4600), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4607), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4611), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4615), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4619), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4623), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4626), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4631), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4637), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4640), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4643), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4647), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4654), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4657), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4662), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4665), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4669), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4672), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4676), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4679), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4683), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4686), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4687) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4690), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4693), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4697), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4700), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4704), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4707), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4710), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4714), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4715) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4719), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4722), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4725), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4729), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4732), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4736), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4739), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4743), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4746), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4750), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4757), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4760), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4342), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4394) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4403), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4407), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4411), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4414), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4420), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4421) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4423), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5044), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5062), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5067), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5072), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5077), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5083), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5088), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5093), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5097), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5107), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5112), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5156), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5161), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5166), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5171), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5172) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5175), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5180), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5187), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5192), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5197), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5201), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5206), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5210), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5214), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5219), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5224), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5229), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5234), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5239), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5244), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5248), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5253), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5257), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5264), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5269), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5274), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5278), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5283), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5288), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5292), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5297), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5301), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5305), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5310), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5314), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5316) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5319), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5324), null, new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4522), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4528), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4532), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4535), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4539), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4543), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4546), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4549), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4553), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5582), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5589), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5591) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5594), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5597), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5601), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5605), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5609), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5675), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5680), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5682) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5929), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5932), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5935), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5939), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5942), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5945), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5949), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5952), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5955), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5959), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5962), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5965), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5969), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5972), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5975), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5979), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5982), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5986), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5987) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5990), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5993), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5996), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5999), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6003), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6006), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5685), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5688), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5689) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5691), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5695), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5698), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5701), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5705), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5771), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5775), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5779), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5782), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5785), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5789), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5792), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5793) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5795), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5708), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5709) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5712), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5715), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5719), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5722), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5725), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5729), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5732), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5736), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5739), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5742), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5746), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5749), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5753), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5756), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5760), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5763), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5767), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5799), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5802), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5806), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5809), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5812), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5816), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5819), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5822), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5824) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5826), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5829), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5832), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5836), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5839), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5842), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5846), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5849), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5852), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5856), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5859), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5863), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5866), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5868) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5870), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5873), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5878), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5882), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5885), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5889), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5892), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5896), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5899), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5902), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5906), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5909), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5912), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5916), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5919), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5922), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5926), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6009), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6012), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6016), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6019), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6022), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6023) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6025), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6029), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6032), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6033) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6035), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6039), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6042), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6045), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6049), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6104), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6108), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6111), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6115), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6118), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6119) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6121), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6125), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6128), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6131), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6135), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6138), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6141), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6147), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6150), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6154), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6157), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6160), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6162) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6164), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6167), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6170), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6173), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6177), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6178) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6180), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6183), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6187), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6190), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6193), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6196), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6200), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6203), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6206), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6209), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6213), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6216), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6219), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6223), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6226), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6229), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6232), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6236), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6239), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6242), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6245), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6253), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6256), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6259), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6263), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6266), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6269), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6273), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6276), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6279), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6282), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6286), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6289), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6292), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6294) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6296), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6299), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6302), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6305), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6309), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6312), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6315), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6319), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6322), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6325), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6329), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6332), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6335), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6337) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6339), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6342), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6345), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6349), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6356), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6359), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6362), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6366), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6369), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6372), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6375), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6379), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6382), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6383) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6385), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6387) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6389), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6392), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6396), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6399), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6402), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6406), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6409), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6412), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6415), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6419), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6422), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6425), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6429), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6432), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6436), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6437) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6439), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6442), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6446), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6449), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6452), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6455), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6459), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6462), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6465), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6469), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6472), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6512), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6516), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6519), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6521) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6523), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6526), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6527) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6529), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6533), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6536), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6539), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6542), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6546), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6549), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6552), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6556), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "SWSG_Studio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4867), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "SWSG_Studio",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4874), new DateTime(2024, 11, 26, 16, 41, 50, 387, DateTimeKind.Local).AddTicks(4876) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "SWSG_Member");

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6528), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6542), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6548), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6553), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6557), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6562), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6566), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6570), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6575), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6576) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6580), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6584), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6589), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6593), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6597), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6601), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6604), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6608), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6613), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6617), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6620), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6624), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6628), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6632), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7787), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7795), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7799), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7803), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7804) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7807), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7811), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7816), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7819), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7823), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7825) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7828), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7832), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7835), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7839), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7842), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7846), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7850), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7853), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7858), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7862), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7865), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7869), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7873), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7877), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7880), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7884), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7887), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7891), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7895), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7938), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7942), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7946), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7950), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7953), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7958), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7962), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7966), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7969), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7973), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7977), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7980), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7984), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7989), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7992), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7996), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8000), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8003), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8007), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8010), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8014), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8018), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8021), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8025), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8029), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8032), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8036), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8039), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8043), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8047), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8050), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8058), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8061), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8065), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8069), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8072), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8076), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8080), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8084), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8088), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8092), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8095), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8099), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8103), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8106), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8110), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8114), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8117), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8121), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8125), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8129), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8133), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8136), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8140), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8144), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8147), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8151), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8155), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8159), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8162), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8166), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8170), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8173), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8177), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8181), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8184), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8188), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8192), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8193) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8196), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8203), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8205) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8207), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8211), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8214), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8218), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8261), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8265), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8269), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8272), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8276), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8280), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8283), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8287), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8291), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8294), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8298), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8303), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8306), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8308) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8310), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8318), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8319) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8321), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8325), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8329), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8332), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8336), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8339), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8343), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8347), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8351), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8354), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8359), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8363), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8366), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8368) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8371), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8379), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8382), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8386), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8390), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8393), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8395) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8404), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8408), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8412), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8415), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8419), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8423), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8426), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8430), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8434), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8442), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8446), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8449), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8453), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8457), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8460), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8462) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8464), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8468), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8471), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8475), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8478), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8482), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8486), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8489), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8493), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8497), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8500), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8505), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8508), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8512), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8516), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8519), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8546), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8551), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8554), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8558), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8562), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8566), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8569), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8573), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8576), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8580), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8584), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8587), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8592), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8595), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8599), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8603), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8606), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8610), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8614), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8618), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8621), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8625), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8628), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8632), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8636), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8640), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8643), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8645) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8647), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8651), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8654), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8659), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8663), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8666), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8670), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8673), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8675) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8677), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8681), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8682) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8684), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8688), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8692), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8695), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8699), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8702), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8706), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8707) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8710), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8713), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8717), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8721), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8725), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8729), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8733), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8736), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8740), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8754), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8758), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8762), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8766), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8769), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8773), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8776), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8780), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8784), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8787), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8791), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8795), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5910), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5922), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5926), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5931), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5935), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5939), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5944), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5948), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5952), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5957), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5961), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5966), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5970), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5974), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5979), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5983), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5987), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5992), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5997), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6001), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5618), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5624), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5628), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5631), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5635), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5639), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5642), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5646), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5649), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5653), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5658), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5661), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5662) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5664), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5668), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5669) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5671), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5675), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5678), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5682), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5686), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5689), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5693), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5694) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5696), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5699), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5703), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5706), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5710), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5713), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5716), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5720), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5723), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5727), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5728) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5730), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5734), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5738), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5741), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5744), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5748), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5751), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5755), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5758), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5761), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5765), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5766) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5768), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5772), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5775), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5779), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5382), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5433), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5437), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5440), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5444), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5448), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5451), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6050), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6066), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6071), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6076), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6081), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6086), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6091), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6096), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6100), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6174), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6175) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6180), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6185), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6190), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6194), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6199), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6204), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6208), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6216), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6220), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6225), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6229), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6233), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6238), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6242), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6247), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6253), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6258), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6262), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6267), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6272), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6276), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6280), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6285), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6291), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6296), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6300), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6305), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6310), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6311) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6314), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6319), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6323), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6327), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6332), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6337), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6341), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6345), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6350), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5547), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5554), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5555) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5557), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5561), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5564), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5568), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5571), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5575), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5578), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6680), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6688), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6692), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6695), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6698), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6702), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6705), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6709), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6712), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6998), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7001), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7005), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7008), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7011), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7014), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7018), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7021), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7024), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7027), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7031), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7034), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7037), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7040), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7044), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7047), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7050), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7055), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7058), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7061), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7064), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7068), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7071), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7074), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6758), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6762), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6765), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6768), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6772), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6775), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6778), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6844), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6848), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6851), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6854), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6858), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6861), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6864), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6868), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6782), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6786), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6789), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6792), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6796), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6799), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6803), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6806), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6809), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6812), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6816), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6819), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6822), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6826), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6829), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6833), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6836), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6840), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6871), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6874), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6878), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6881), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6884), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6888), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6891), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6894), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6898), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6901), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6908), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6911), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6914), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6917), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6921), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6924), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6927), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6934), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6937), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6941), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6944), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6949), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6952), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6955), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6959), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6962), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6965), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6968), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6972), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6975), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6978), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6981), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6985), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6988), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6991), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6995), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7077), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7087), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7090), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7094), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7097), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7103), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7107), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7113), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7117), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7120), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7128), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7174), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7183), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7185) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7187), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7190), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7191) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7199), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7203), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7206), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7213), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7216), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7219), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7223), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7226), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7229), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7233), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7236), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7239), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7242), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7245), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7249), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7252), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7255), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7259), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7262), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7265), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7268), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7271), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7275), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7278), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7281), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7285), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7288), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7291), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7294), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7298), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7301), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7305), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7308), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7311), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7315), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7318), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7321), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7325), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7328), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7331), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7334), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7337), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7341), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7344), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7347), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7350), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7353), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7357), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7360), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7363), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7366), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7370), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7373), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7376), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7379), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7382), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7384) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7386), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7389), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7392), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7394) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7396), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7399), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7403), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7406), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7410), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7416), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7420), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7423), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7426), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7429), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7433), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7436), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7439), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7442), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7446), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7449), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7452), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7456), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7459), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7462), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7465), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7469), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7472), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7475), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7479), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7482), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7485), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7488), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7491), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7495), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7498), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7501), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7505), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7508), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7511), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7515), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7518), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7521), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7524), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7528), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7568), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7572), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7575), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7579), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7582), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7585), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7589), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7592), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7595), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7598), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7602), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7605), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "SWSG_Studio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5874), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "SWSG_Studio",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5881), new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5882) });
        }
    }
}
