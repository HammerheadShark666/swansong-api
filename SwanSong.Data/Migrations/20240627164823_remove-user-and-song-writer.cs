using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwanSong.Data.Migrations
{
    /// <inheritdoc />
    public partial class removeuserandsongwriter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SWSG_SongWriter");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: null);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SWSG_SongWriter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    SongId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SWSG_SongWriter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SWSG_SongWriter_SWSG_Song_SongId",
                        column: x => x.SongId,
                        principalTable: "SWSG_Song",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "b38c4c03-5476-471f-bbed-4800b69a8bb5");

            migrationBuilder.UpdateData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7211",
                column: "ConcurrencyStamp",
                value: "42fdc14d-43b7-4995-93b0-6951e2487635");

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8645), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8659), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8666), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8671), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8677), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8679) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8684), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8690), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8696), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8701), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8717), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8732), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8738), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8747), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8752), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8758), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8763), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8770), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8774), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8779), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8783), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8789), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "SWSG_Album",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8793), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8796) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(978), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1048), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1055), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1060), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1065), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1072), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1075) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1077), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1082), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1088), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1094), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1105), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1110), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1116), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1121), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1126), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1132), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1134) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1140), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1142) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1145), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1150), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1155), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1157) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1163) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1165), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1171), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1176), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1181), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1187), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1193), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1198), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1204), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1210), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1215), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1217) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1220), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1228), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1233), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1238), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1244), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1250), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1255), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1260), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1266), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1271), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1273) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1277), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1282), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1285) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1288), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1294), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1299), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1304), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1310), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1314), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1320), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1325), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1331), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1336), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1342), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1345) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1348), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1354), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1360), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1365), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1371), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1377), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1382), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1388), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1393), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1399), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1406), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1411), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1416), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1421), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1427), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1429) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1487), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1495), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1500), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1507), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1512), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1518), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1523), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1528), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1534), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1539), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1544), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1550), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1555), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1561), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1566), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1572), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1578), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1583), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1589), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1594), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1599), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1605), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1612), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1617), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1622), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1628), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1634), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1640), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1645), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1650), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1656), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1661), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1666), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1672), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1678), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1684), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1690), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1695), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1701), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1706), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1711), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1717), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1723), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1729), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1735), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1741), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1747), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1749) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1752), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1758), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1763), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1769), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1775), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1780), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1786), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1791), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1796), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1807), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1812), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1814) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1821), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1826), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1832), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1837), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1843), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1849), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1854), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1859), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1864), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1870), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1927), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1934), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1939), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1946), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1952), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1957), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1963), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1969), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1975), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 159L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1981), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 160L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1986), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 161L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1992), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1997), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2003), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2009), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2014), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2019), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2025), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2030), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2036), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2041), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2047), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2053), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2058), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2064), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2069), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2075), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2080), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2087), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2092), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2097), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2103), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2108), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2113), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2118), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2123), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2129), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2134), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2140), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2145), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2151), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2156), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2162), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2167), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2172), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2177), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2183), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2189), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2194), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2200), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2205), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2210), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2215), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2221), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2226), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2232), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2237), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2242), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2250), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2256), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2262), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2268), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2273), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2279), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2284), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2291), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2296), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2301), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2307), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2313), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2318), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2324), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2329), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2331) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2334), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2340), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2345), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2351), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2357), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2362), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2368), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2373), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2379), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2385), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2391), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2396), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2402), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2407), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2413), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2418), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2424), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2429), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2435), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2441), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2502), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2509), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2514), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2520), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2526), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2531), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2537), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 256L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2542), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "SWSG_AlbumSong",
                keyColumn: "Id",
                keyValue: 257L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2548), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7882), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7907), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7925), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7943), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7959), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7977), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7991), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7997), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8001), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8009), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8014), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8024), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8039), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8053), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8058), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8063), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8068), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8075), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8080), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "SWSG_Artist",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8086), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7469), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7487), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7491), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7501), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7505), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7509), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7514), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7521), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7526), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7531), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7535), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7540), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7544), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7549), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7553), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7559), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7563), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7568), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7573), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7577), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7583), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7587), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7592), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7597), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7602), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7607), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7611), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7616), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7620), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7622) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7624), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7629), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7707), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7714), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7719), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7723), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7727), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7731), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7736), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7741), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7745), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7750), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7754), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7759), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "SWSG_BirthPlace",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7764), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6846), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6903), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6908), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6913), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6925), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "SWSG_Country",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6930), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8142), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8249), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8255), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8261), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8269), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8275), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8283), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8288), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8295), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8300), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8305), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8311), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8316), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8322), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8328), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8334), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8341), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8346), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8351), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8357), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8362), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8367), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8373), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8376) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8379), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8385), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8391), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8399) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8402), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8404) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8408), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8413), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8420), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8425), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8432), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8437), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8443), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8448), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8453), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8459), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8464), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8470), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8475), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8479), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8542), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8551), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8557), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "SWSG_Member",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8562), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7369), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7385), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7389), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7394), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7399), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7406), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7410), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7414), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "SWSG_RecordLabel",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7418), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8927), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8941), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8946), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8952), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8965), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8971), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8976), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8981), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8986), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9689), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9695), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9701), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9707), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9721), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9729), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9740), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9746), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9758), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9766), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9779), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9817), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9823) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9833), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9838), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9851), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9859), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9868), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9873), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9879), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9884), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9890), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9894), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9899), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8992), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8996), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9003), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9014), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9026), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9032), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9042), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9218), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9230), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9236), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9246), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9255), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9262), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9273), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9281), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9052), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9062), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9072), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9084), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9088), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9100), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9108), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9116), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9128), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9134), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9144), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9154), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9161), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9173), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9182), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9189), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9201), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9210), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9289), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9301), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9306), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9317), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9326), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9334), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9345), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9351), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9362), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9372), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9378), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9391), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9404), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9436), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9442), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9449), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9454), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9460), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9465), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9472), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9477), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9483), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9489), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9565), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9573), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9577), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9582), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9595), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9609), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9615), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9624), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9637), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9645), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9650), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9654), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9660), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9682), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9904), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9909), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9914), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9916) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9919), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9925), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9932) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9935), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9940), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9945), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9950), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9954), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9959), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9964), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9971), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9977), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9983), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9989), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9993), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9995) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(9998), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(4), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(10), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(12) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(15), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(21), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 135L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(27), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 136L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(32), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(34) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 137L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(114), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 138L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(121), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 139L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(125), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 140L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(130), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 141L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(136), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 142L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(147), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 143L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(152), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 144L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(156), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 145L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(161), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 146L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(165), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 147L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(170), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 148L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(174), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 149L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(186), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(188) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 150L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(193), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 151L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(203), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 152L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 153L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(219), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 154L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(224), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(226) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 155L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(229), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 156L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(234), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 157L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(239), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 158L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(245), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 166L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(250), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 167L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(254), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(256) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 168L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 169L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(263), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 170L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(268), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 171L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(274), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 172L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(278), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 173L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(283), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 174L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(289), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 175L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(293), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 176L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(298), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 177L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(302), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 178L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(307), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 179L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(312), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 180L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(318), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 181L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(323), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 182L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(328), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 183L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(334), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 184L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(339), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 185L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(346), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 186L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(350), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(352) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 187L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(355), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(357) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 188L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(360), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(362) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 189L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(365), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 190L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(369), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(371) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 191L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(374), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(376) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 192L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(378), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 193L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(383), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 194L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(389), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 195L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(395), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(396) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 196L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(399), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 197L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(404), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 198L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(410), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 199L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(415), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 200L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(420), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 201L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(425), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 202L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(430), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 203L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(434), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 204L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(439), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 205L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(444), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(446) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 206L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(448), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 207L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(453), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 208L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(457), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(459) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 209L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(462), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 210L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(466), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 211L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(471), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 212L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 213L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(482), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 214L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(486), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 215L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(491), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 216L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(497), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 217L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(502), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 218L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(508), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 219L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(629), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 220L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(638), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 221L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(644), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 222L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(649), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 223L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(654), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 224L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(659), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 225L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(665), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 226L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(670), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 227L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(676), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 228L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(681), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 229L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(686), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 230L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(691), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 231L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(697), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 232L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(703), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 233L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(708), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 234L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(713), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 235L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(719), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 236L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(724), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 237L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(729), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 238L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(735), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 239L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(740), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 240L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(745), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 241L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(751), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 242L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(757), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 243L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(762), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 244L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(767), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 245L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(773), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 246L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(778), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 247L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(783), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 248L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(788), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 249L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(794), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 250L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(799), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 251L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(805), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 252L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(810), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 253L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(815), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 254L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(821), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "SWSG_Song",
                keyColumn: "Id",
                keyValue: 255L,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(826), new DateTime(2024, 3, 18, 16, 45, 44, 529, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "SWSG_Studio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7830), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "SWSG_Studio",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7839), new DateTime(2024, 3, 18, 16, 45, 44, 528, DateTimeKind.Local).AddTicks(7841) });

            migrationBuilder.CreateIndex(
                name: "IX_SWSG_SongWriter_SongId",
                table: "SWSG_SongWriter",
                column: "SongId");
        }
    }
}
