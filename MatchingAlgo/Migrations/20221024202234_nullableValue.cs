using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace MatchingAlgo.Migrations
{
    public partial class nullableValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("b0b2e5ca-1cb7-4c76-a363-93f06dea76b9"));

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("be87197e-22c7-49ad-9c13-89aa039466fa"));

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("f806f3f3-8fc3-41cb-a0d5-aff5f0997ef4"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("05ed0d77-abcc-480f-8d8c-4520dd5a1a43"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("2a152f6c-dbf5-42b7-b3d1-56efebca428e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("7bc431ae-3f80-46e9-887d-6cd354598d87"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("aa0dcc1d-da5f-482e-a3e5-5554b5cf507c"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d42ae769-b316-43c8-8554-412141af8fb8"));

            migrationBuilder.DeleteData(
                table: "Helpers",
                keyColumn: "Id",
                keyValue: new Guid("1bf35939-759f-4874-b958-4507c6afee09"));

            migrationBuilder.DeleteData(
                table: "Helpers",
                keyColumn: "Id",
                keyValue: new Guid("b3d821f8-4661-40e5-9633-9755c0e8b13e"));

            migrationBuilder.DeleteData(
                table: "Helpers",
                keyColumn: "Id",
                keyValue: new Guid("e9abb058-4a5b-4814-923d-c6925690fedf"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("27c1c667-1e3a-4988-a550-8e4573493465"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("87418dcb-59e1-480c-92c9-de7730780233"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("89ca1462-7d61-4549-a5d8-888032da9b70"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("c36ef7ea-b585-497c-8d58-3e123684eaf6"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("d64823be-617c-4ca2-b730-07ad945bb17b"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("f6ea1dd0-f26f-4e14-8afd-5a574892d0d2"));

            migrationBuilder.AlterColumn<Guid>(
                name: "HelperId",
                table: "Shift",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "DriverId",
                table: "Shift",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "AvailableDate",
                columns: new[] { "Id", "AvaialbeDate", "DriverId", "HelperId" },
                values: new object[,]
                {
                    { new Guid("2a8e6da9-8998-480a-a5cc-68fbe7a023ac"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0e4e67d9-8000-45b6-a47e-faa4768c3b71"), new Guid("99e35547-3186-42cc-a1e7-540308d5e9c5") },
                    { new Guid("2d61d972-775d-4c14-9c37-13fe08492d67"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d6cc015d-d291-4c75-8e1d-eb3253ad254f"), new Guid("9c013935-d2bc-4ca6-845a-d33f82cf04a0") },
                    { new Guid("4411db20-c110-4306-b984-507626129b98"), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5eb4d747-f70d-47ca-87e0-4090525dbda2"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8db46ff0-a8a2-4387-b882-db6a8369189a"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1b0754ba-0d9d-402f-928d-ed72d3d95750"), new Guid("aed0ceb1-9af4-444b-97e1-aaf6e2e56ef5") },
                    { new Guid("aebf3869-bb69-4a06-8028-8e217a0c7f57"), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44f9d7cc-8376-43b7-a3e7-1eb4b695707a"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Shift",
                columns: new[] { "Id", "DriverId", "EndAvailableTime", "HelperId", "StartAvailableTime" },
                values: new object[,]
                {
                    { new Guid("2ee189eb-60a5-4bfd-9507-adac90efd207"), new Guid("5eb4d747-f70d-47ca-87e0-4090525dbda2"), new TimeSpan(0, 11, 30, 0, 0), new Guid("99e35547-3186-42cc-a1e7-540308d5e9c5"), new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("61db7a72-9db6-44c7-b918-4efad85558ce"), new Guid("0e4e67d9-8000-45b6-a47e-faa4768c3b71"), new TimeSpan(0, 11, 30, 0, 0), null, new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("784bcab2-f331-4bb2-b442-4bdbf241dcd9"), new Guid("d6cc015d-d291-4c75-8e1d-eb3253ad254f"), new TimeSpan(0, 11, 30, 0, 0), null, new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("8a135904-60c3-4493-9c51-11e67d865b95"), null, new TimeSpan(0, 10, 30, 0, 0), new Guid("9c013935-d2bc-4ca6-845a-d33f82cf04a0"), new TimeSpan(0, 8, 30, 0, 0) },
                    { new Guid("da6847ce-6a31-4953-9f19-2b342d4e9e9b"), new Guid("44f9d7cc-8376-43b7-a3e7-1eb4b695707a"), new TimeSpan(0, 11, 30, 0, 0), null, new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("ee113259-66f7-4efe-a5c4-24ab27ed2fe7"), new Guid("1b0754ba-0d9d-402f-928d-ed72d3d95750"), new TimeSpan(0, 11, 30, 0, 0), new Guid("aed0ceb1-9af4-444b-97e1-aaf6e2e56ef5"), new TimeSpan(0, 9, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "AvaliableDateId", "DistanceToPickUp", "DriverLocation", "ShiftId", "VehicleSize" },
                values: new object[,]
                {
                    { new Guid("0e4e67d9-8000-45b6-a47e-faa4768c3b71"), new Guid("2a8e6da9-8998-480a-a5cc-68fbe7a023ac"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (52.506272 10.377722)"), new Guid("61db7a72-9db6-44c7-b918-4efad85558ce"), 0 },
                    { new Guid("1b0754ba-0d9d-402f-928d-ed72d3d95750"), new Guid("8db46ff0-a8a2-4387-b882-db6a8369189a"), 5.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.518 7.45425)"), new Guid("ee113259-66f7-4efe-a5c4-24ab27ed2fe7"), 0 },
                    { new Guid("44f9d7cc-8376-43b7-a3e7-1eb4b695707a"), new Guid("aebf3869-bb69-4a06-8028-8e217a0c7f57"), 1.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (59.3275 18.0675)"), new Guid("da6847ce-6a31-4953-9f19-2b342d4e9e9b"), 0 },
                    { new Guid("5eb4d747-f70d-47ca-87e0-4090525dbda2"), new Guid("4411db20-c110-4306-b984-507626129b98"), 2.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (52.516272 13.377722)"), new Guid("2ee189eb-60a5-4bfd-9507-adac90efd207"), 1 },
                    { new Guid("d6cc015d-d291-4c75-8e1d-eb3253ad254f"), new Guid("2d61d972-775d-4c14-9c37-13fe08492d67"), 4.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.503333 -0.119722)"), new Guid("784bcab2-f331-4bb2-b442-4bdbf241dcd9"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Helpers",
                columns: new[] { "Id", "AvaliableDateId", "DistanceToPickUp", "HelperLocation", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("99e35547-3186-42cc-a1e7-540308d5e9c5"), new Guid("2a8e6da9-8998-480a-a5cc-68fbe7a023ac"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (59.3275 18.0675)"), new Guid("2ee189eb-60a5-4bfd-9507-adac90efd207") },
                    { new Guid("9c013935-d2bc-4ca6-845a-d33f82cf04a0"), new Guid("2d61d972-775d-4c14-9c37-13fe08492d67"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.503333 -0.119722)"), new Guid("8a135904-60c3-4493-9c51-11e67d865b95") },
                    { new Guid("aed0ceb1-9af4-444b-97e1-aaf6e2e56ef5"), new Guid("8db46ff0-a8a2-4387-b882-db6a8369189a"), 5.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.518 7.45425)"), new Guid("ee113259-66f7-4efe-a5c4-24ab27ed2fe7") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("2a8e6da9-8998-480a-a5cc-68fbe7a023ac"));

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("2d61d972-775d-4c14-9c37-13fe08492d67"));

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("4411db20-c110-4306-b984-507626129b98"));

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("8db46ff0-a8a2-4387-b882-db6a8369189a"));

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("aebf3869-bb69-4a06-8028-8e217a0c7f57"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("0e4e67d9-8000-45b6-a47e-faa4768c3b71"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("1b0754ba-0d9d-402f-928d-ed72d3d95750"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("44f9d7cc-8376-43b7-a3e7-1eb4b695707a"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("5eb4d747-f70d-47ca-87e0-4090525dbda2"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d6cc015d-d291-4c75-8e1d-eb3253ad254f"));

            migrationBuilder.DeleteData(
                table: "Helpers",
                keyColumn: "Id",
                keyValue: new Guid("99e35547-3186-42cc-a1e7-540308d5e9c5"));

            migrationBuilder.DeleteData(
                table: "Helpers",
                keyColumn: "Id",
                keyValue: new Guid("9c013935-d2bc-4ca6-845a-d33f82cf04a0"));

            migrationBuilder.DeleteData(
                table: "Helpers",
                keyColumn: "Id",
                keyValue: new Guid("aed0ceb1-9af4-444b-97e1-aaf6e2e56ef5"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("2ee189eb-60a5-4bfd-9507-adac90efd207"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("61db7a72-9db6-44c7-b918-4efad85558ce"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("784bcab2-f331-4bb2-b442-4bdbf241dcd9"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("8a135904-60c3-4493-9c51-11e67d865b95"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("da6847ce-6a31-4953-9f19-2b342d4e9e9b"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("ee113259-66f7-4efe-a5c4-24ab27ed2fe7"));

            migrationBuilder.AlterColumn<Guid>(
                name: "HelperId",
                table: "Shift",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DriverId",
                table: "Shift",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AvailableDate",
                columns: new[] { "Id", "AvaialbeDate", "DriverId", "HelperId" },
                values: new object[,]
                {
                    { new Guid("b0b2e5ca-1cb7-4c76-a363-93f06dea76b9"), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("be87197e-22c7-49ad-9c13-89aa039466fa"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f806f3f3-8fc3-41cb-a0d5-aff5f0997ef4"), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "AvaliableDateId", "DistanceToPickUp", "DriverLocation", "ShiftId", "VehicleSize" },
                values: new object[,]
                {
                    { new Guid("05ed0d77-abcc-480f-8d8c-4520dd5a1a43"), new Guid("00000000-0000-0000-0000-000000000000"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (52.506272 10.377722)"), null, 0 },
                    { new Guid("2a152f6c-dbf5-42b7-b3d1-56efebca428e"), new Guid("00000000-0000-0000-0000-000000000000"), 1.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (59.3275 18.0675)"), null, 0 },
                    { new Guid("7bc431ae-3f80-46e9-887d-6cd354598d87"), new Guid("00000000-0000-0000-0000-000000000000"), 5.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.518 7.45425)"), null, 0 },
                    { new Guid("aa0dcc1d-da5f-482e-a3e5-5554b5cf507c"), new Guid("00000000-0000-0000-0000-000000000000"), 4.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.503333 -0.119722)"), null, 2 },
                    { new Guid("d42ae769-b316-43c8-8554-412141af8fb8"), new Guid("00000000-0000-0000-0000-000000000000"), 2.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (52.516272 13.377722)"), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Helpers",
                columns: new[] { "Id", "AvaliableDateId", "DistanceToPickUp", "HelperLocation", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("1bf35939-759f-4874-b958-4507c6afee09"), new Guid("00000000-0000-0000-0000-000000000000"), 5.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.518 7.45425)"), null },
                    { new Guid("b3d821f8-4661-40e5-9633-9755c0e8b13e"), new Guid("00000000-0000-0000-0000-000000000000"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.503333 -0.119722)"), null },
                    { new Guid("e9abb058-4a5b-4814-923d-c6925690fedf"), new Guid("00000000-0000-0000-0000-000000000000"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (59.3275 18.0675)"), null }
                });

            migrationBuilder.InsertData(
                table: "Shift",
                columns: new[] { "Id", "DriverId", "EndAvailableTime", "HelperId", "StartAvailableTime" },
                values: new object[,]
                {
                    { new Guid("27c1c667-1e3a-4988-a550-8e4573493465"), new Guid("05ed0d77-abcc-480f-8d8c-4520dd5a1a43"), new TimeSpan(0, 11, 30, 0, 0), new Guid("00000000-0000-0000-0000-000000000000"), new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("87418dcb-59e1-480c-92c9-de7730780233"), new Guid("7bc431ae-3f80-46e9-887d-6cd354598d87"), new TimeSpan(0, 11, 30, 0, 0), new Guid("1bf35939-759f-4874-b958-4507c6afee09"), new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("89ca1462-7d61-4549-a5d8-888032da9b70"), new Guid("aa0dcc1d-da5f-482e-a3e5-5554b5cf507c"), new TimeSpan(0, 11, 30, 0, 0), new Guid("00000000-0000-0000-0000-000000000000"), new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("c36ef7ea-b585-497c-8d58-3e123684eaf6"), new Guid("d42ae769-b316-43c8-8554-412141af8fb8"), new TimeSpan(0, 11, 30, 0, 0), new Guid("e9abb058-4a5b-4814-923d-c6925690fedf"), new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("d64823be-617c-4ca2-b730-07ad945bb17b"), new Guid("00000000-0000-0000-0000-000000000000"), new TimeSpan(0, 10, 30, 0, 0), new Guid("b3d821f8-4661-40e5-9633-9755c0e8b13e"), new TimeSpan(0, 8, 30, 0, 0) },
                    { new Guid("f6ea1dd0-f26f-4e14-8afd-5a574892d0d2"), new Guid("2a152f6c-dbf5-42b7-b3d1-56efebca428e"), new TimeSpan(0, 11, 30, 0, 0), new Guid("00000000-0000-0000-0000-000000000000"), new TimeSpan(0, 9, 30, 0, 0) }
                });
        }
    }
}
