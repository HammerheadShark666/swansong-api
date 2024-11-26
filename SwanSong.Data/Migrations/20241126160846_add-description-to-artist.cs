using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwanSong.Data.Migrations
{
    /// <inheritdoc />
    public partial class adddescriptiontoartist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SWSG_Artist",
                type: "varchar(MAX)",
                nullable: true);

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
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5910), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5922), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5926), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5931), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5935), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5939), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5941) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5944), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5948), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5952), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5957), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5961), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5966), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5970), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5974), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5979), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5983), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5987), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5992), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5997), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6001), null, new DateTime(2024, 11, 26, 16, 8, 44, 150, DateTimeKind.Local).AddTicks(6002) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "SWSG_Artist");

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8575), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8589), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8596), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8601), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8605), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8610), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8614), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8618), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8623), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8628), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8633), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8637), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8645), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8649), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8652), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8656), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8661), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8665), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8668), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8672), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8675), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8679), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9907), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9916), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9921), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9924), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9928), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9929) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9933), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9937), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9940), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9944), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9948), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9953), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9955) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9957), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9960), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9964), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9967), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9971), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9975), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9980), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9983), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9987), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9988) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9991), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9994), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9998), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(65), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(67) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(70), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(73), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(77), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(82), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(83) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(86), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(94), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(95) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(98), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(103), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(107), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(111), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(114), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(118), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(121), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(125), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(128), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(132), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(136), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(139), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(143), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(147), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(151), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(155), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(159), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(162), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(166), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(169), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(173), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(176), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(183), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(187), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(191), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(194), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(198), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(201), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(205), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(209), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(217), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(221), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(225), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(229), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(236), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(239), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(243), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(246), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(250), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(254), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(257), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(259) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(261), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(264), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(268), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(271), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(275), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(279), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(289), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(292), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(296), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(303), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(307), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(310), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(315), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(318), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(322), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(325), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(329), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(332), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(336), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(339), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(343), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(347), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(431), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(436), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(439), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(443), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(450), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(454), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(457), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(461), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(465), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(468), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(472), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(473) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(475), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(476) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(479), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(482), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(486), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(489), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(493), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(501), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(505), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(508), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(512), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(516), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(517) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(519), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(523), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(526), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(530), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(533), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(537), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(540), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(546), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(550), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(553), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(560), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(564), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(567), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(572), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(575), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(579), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(582), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(583) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(586), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(589), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(593), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(597), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(600), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(604), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(607), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(611), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(615), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(618), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(622), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(625), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(629), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(632), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(637), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(644), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(648), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(651), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(655), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(658), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(662), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(666), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(669), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(673), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(676), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(680), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(683), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(687), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(767), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(772), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(775), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(780), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(784), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(787), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(791), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(794), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(798), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(801), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(805), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(808), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(812), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(815), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(819), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(826), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(829), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(833), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(837), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(841), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(844), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(848), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(851), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(855), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(858), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(862), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(865), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(869), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(872), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(876), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(880), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(883), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(887), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(890), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(895), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(896) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(898), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(902), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(905), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(906) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(909), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(912), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(916), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(920), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(923), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(927), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(931), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(934), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(938), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(939) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(941), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(945), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(948), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(952), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(955), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(956) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(959), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(962), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(966), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(969), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(973), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(974) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(976), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(980), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(983), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(985) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(987), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(988) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(990), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(994), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(997), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1001), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1002) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1004), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1008), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1011), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1015), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1019), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1022), new DateTime(2024, 11, 26, 15, 14, 1, 793, DateTimeKind.Local).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8018), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8028), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8033), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8037), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8041), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8047), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8051), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8055), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8059), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8065), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8069), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8073), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8077), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8081), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8085), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8090), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8094), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8099), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8103), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8107), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7693), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7703), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7707), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7710), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7714), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7718), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7722), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7725), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7728), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7732), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7736), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7739), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7742), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7746), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7749), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7752), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7756), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7761), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7764), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7767), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7771), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7774), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7777), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7781), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7784), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7787), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7790), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7794), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7797), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7800), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7804), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7807), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7810), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7814), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7818), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7821), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7824), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7828), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7831), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7834), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7838), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7841), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7844), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7847), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7851), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7854), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7464), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7520), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7524), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7527), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7530), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7535), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7539), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8152), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8168), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8173), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8179), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8184), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8189), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8194), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8198), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8203), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8273), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8278), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8284), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8288), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8293), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8294) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8297), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8302), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8306), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8312), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8317), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8322), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8326), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8330), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8335), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8339), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8344), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8348), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8353), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8359), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8363), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8368), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8372), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8377), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8381), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8386), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8391), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8405), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8410), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8414), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8419), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8423), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8427), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8432), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8436), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8440), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8445), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7625), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7632), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7636), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7640), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7643), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7647), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7651), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7654), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7657), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8723), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8730), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8734), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8737), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8740), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8744), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8748), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8778), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9017), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9020), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9024), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9027), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9030), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9033), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9036), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9040), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9043), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9046), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9049), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9053), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9056), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9059), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9063), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9066), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9070), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9073), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9076), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9079), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9082), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9085), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9089), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9092), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8783), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8787), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8791), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8794), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8797), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8801), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8804), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8867), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8870), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8874), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8877), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8880), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8883), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8886), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8890), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8807), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8811), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8814), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8818), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8821), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8824), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8828), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8831), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8834), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8837), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8841), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8844), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8847), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8850), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8853), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8856), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8858) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8860), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8861) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8864), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8894), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8897), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8900), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8903), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8906), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8910), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8913), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8916), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8919), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8922), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8925), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8929), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8932), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8935), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8938), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8941), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8944), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8947), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8951), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8954), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8957), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8960), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8963), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8968), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8969) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8971), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8975), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8978), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8981), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8984), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8985) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8987), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8990), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8994), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8997), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9001), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9004), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9007), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9011), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9014), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9095), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9099), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9102), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9106), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9109), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9112), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9115), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9118), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9122), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9125), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9213), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9217), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9221), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9224), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9230), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9234), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9237), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9240), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9243), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9246), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9250), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9253), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9256), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9259), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9264), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9267), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9270), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9274), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9277), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9280), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9283), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9288), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9291), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9294), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9297), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9301), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9304), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9307), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9310), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9313), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9317), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9320), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9323), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9326), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9329), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9333), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9336), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9339), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9342), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9345), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9349), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9352), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9355), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9358), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9361), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9364), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9367), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9371), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9374), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9377), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9380), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9384), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9388), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9391), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9394), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9397), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9401), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9404), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9407), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9410), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9413), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9417), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9420), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9423), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9426), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9429), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9433), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9436), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9439), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9442), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9446), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9449), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9452), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9455), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9459), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9462), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9463) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9465), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9468), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9471), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9474), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9477), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9481), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9488), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9491), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9494), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9497), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9500), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9504), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9505) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9507), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9510), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9513), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9516), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9520), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9523), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9526), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9529), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9532), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9536), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9539), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9542), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9545), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9546) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9548), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9551), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9555), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9556) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9558), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9561), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9564), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9665), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9669), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9672), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9676), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9679), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9682), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9685), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9688), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9692), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9693) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9695), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9696) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9698), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9701), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9704), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9708), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9711), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9714), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9717), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9719) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9721), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "SWSG_Studio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7985), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "SWSG_Studio",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7992), new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(7993) });
        }
    }
}
