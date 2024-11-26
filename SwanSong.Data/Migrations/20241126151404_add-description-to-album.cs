using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwanSong.Data.Migrations
{
    /// <inheritdoc />
    public partial class adddescriptiontoalbum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SWSG_Album",
                type: "varchar(MAX)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8575), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8589), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8596), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8601), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8605), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8610), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8611) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8614), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8618), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8623), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8628), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8633), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8637), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8641), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8645), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8649), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8652), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8656), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8661), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8665), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8668), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8672), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8675), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "Description", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8679), null, new DateTime(2024, 11, 26, 15, 14, 1, 792, DateTimeKind.Local).AddTicks(8680) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "SWSG_Album");

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3299), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3315), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3324), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3328), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3333), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3338), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3343), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3348), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3353), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3359), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3364), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3368), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3373), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3377), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3381), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3385), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3388), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3394), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3398), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3402), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3406), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3410), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3469), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4625), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4633), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4638), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4642), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4646), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4651), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4659), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4663), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4668), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4671), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4675), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4716), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4717) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4720), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4724), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4728), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4732), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4737), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4749), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4754), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4758), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4762), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4765), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4769), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4773), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4777), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4781), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4785), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4789), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4793), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4797), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4801), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4805), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4809), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4813), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4817), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4821), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4826), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4829), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4833), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4837), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4841), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4845), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4849), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4853), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4857), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4860), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4864), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4868), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4872), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4876), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4880), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4884), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4888), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4892), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4897), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4900), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4904), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4908), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4912), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4916), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4920), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4929), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4933), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4937), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4941), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4944), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4948), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4952), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4956), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4960), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4964), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4969), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4973), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4977), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4981), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4985), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4989), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4993), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4996), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5000), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5042), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5047), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5051), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5055), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5059), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5062), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5066), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5070), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5074), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5079), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5083), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5087), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5091), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5094), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5098), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5102), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5106), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5110), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5114), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5118), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5125), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5129), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5133), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5137), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5141), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5145), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5149), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5153), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5157), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5161), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5165), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5169), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5173), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5176), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5180), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5184), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5188), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5192), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5196), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5200), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5203), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5207), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5211), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5215), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5221), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5225), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5229), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5233), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5237), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5241), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5245), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5249), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5253), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5256), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5260), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5264), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5268), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5272), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5276), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5279), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5283), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5287), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5292), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5296), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5300), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5304), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5308), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5312), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5316), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5410), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5416), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5420), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5421) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5424), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5428), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5432), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5435), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5439), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5443), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5447), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5451), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5456), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5460), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5464), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5467), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5471), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5475), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5479), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5483), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5487), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5490), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5492) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5494), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5498), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5502), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5506), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5510), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5513), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5517), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5521), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5526), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5530), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5531) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5533), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5537), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5541), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5545), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5549), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5553), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5556), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5558) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5560), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5564), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5568), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5572), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5575), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5579), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5583), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5587), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5588) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5591), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5596), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5599), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5603), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5607), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5611), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5615), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5619), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5622), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5626), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5630), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5634), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5638), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5642), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5643) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5646), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5650), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5653), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5655) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5657), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5661), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5666), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5667) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5670), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5674), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5678), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5682), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5683) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5685), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5689), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5693), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5697), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5701), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5705), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5709), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5713), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5716), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5720), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5721) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5724), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5728), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5732), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5735), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5739), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5743), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5747), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2719), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2732), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2736), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2741), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2745), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2750), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2755), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2759), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2764), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2769), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2774), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2778), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2783), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2787), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2791), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2797), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2801), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2807), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2811), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2816), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2409), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2417), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2421), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2425), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2428), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2434), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2438), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2441), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2445), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2449), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2453), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2457), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2461), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2465), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2468), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2472), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2475), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2480), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2483), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2487), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2490), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2494), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2497), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2501), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2504), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2508), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2511), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2514), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2518), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2521), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2525), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2528), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2532), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2583), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2587), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2590), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2594), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2597), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2601), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2604), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2608), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2611), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2615), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2616) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2618), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2622), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2625), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2162), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2221), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2225), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2229), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2233), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2238), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2241), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2866), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2908), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2915), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2922), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2929), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2937), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2943), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2948), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2955), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2956) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2961), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2965), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2970), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2975), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2981), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2986), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2993), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2994) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3002), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3009), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3015), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3022), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3028), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3032), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3037), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3041), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3047), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3052), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3053) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3057), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3061), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3066), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3071), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3075), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3080), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3086), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3092), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3097), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3101), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3106), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3110), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3115), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3120), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3124), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3206), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3212), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3217), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3222), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3226), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3231), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2346), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2350), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2354), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2357), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2361), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2365), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2368), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2372), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3516), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3525), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3529), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3532), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3536), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3540), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3544), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3547), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3551), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3811), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3814), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3818), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3821), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3825), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3828), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3832), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3835), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3839), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3842), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3885), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3889), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3894), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3898), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3901), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3905), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3908), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3912), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3913) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3915), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3919), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3923), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3926), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3929), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3933), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3555), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3558), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3562), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3565), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3569), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3572), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3576), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3646), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3649), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3653), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3657), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3660), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3664), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3667), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3671), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3579), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3584), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3587), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3591), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3594), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3598), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3601), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3605), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3612), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3615), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3619), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3623), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3627), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3630), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3634), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3638), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3642), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3674), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3678), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3681), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3685), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3688), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3692), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3695), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3699), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3702), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3704) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3706), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3710), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3713), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3717), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3720), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3723), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3727), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3730), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3734), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3738), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3742), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3746), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3749), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3753), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3757), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3759) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3761), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3765), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3766) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3768), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3772), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3776), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3779), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3783), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3784) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3786), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3790), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3793), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3797), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3800), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3804), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3807), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3936), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3940), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3943), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3947), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3951), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3954), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3958), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3961), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3965), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3968), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3972), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3976), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3979), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3983), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3986), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3990), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3993), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3995) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3997), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4000), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4005), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4006) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4008), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4012), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4015), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4019), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4023), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4027), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4031), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4032) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4034), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4038), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4041), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4043) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4045), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4048), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4052), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4055), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4059), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4062), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4066), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4070), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4073), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4076), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4080), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4084), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4088), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4091), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4095), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4098), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4102), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4105), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4109), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4112), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4117), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4120), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4124), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4125) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4127), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4130), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4134), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4138), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4141), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4145), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4148), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4149) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4152), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4155), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4159), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4162), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4166), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4167) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4169), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4173), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4176), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4180), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4183), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4187), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4190), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4194), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4197), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4200), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4204), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4207), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4211), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4214), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4218), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4221), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4226), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4229), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4233), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4236), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4240), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4244), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4247), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4251), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4254), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4258), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4261), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4265), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4268), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4272), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4275), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4316), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4320), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4324), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4327), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4331), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4334), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4338), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4341), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4345), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4349), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4352), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4356), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4359), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4363), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4366), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4370), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4374), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4377), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4381), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4384), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4388), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4391), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4395), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4398), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4401), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4405), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4408), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4412), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4415), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4419), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4422), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4426), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4429), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4433), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4436), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4440), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4443), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4447), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4450), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4454), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4457), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "SWSG_Studio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2687), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "SWSG_Studio",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2694), new DateTime(2024, 6, 27, 17, 48, 21, 430, DateTimeKind.Local).AddTicks(2696) });
        }
    }
}
