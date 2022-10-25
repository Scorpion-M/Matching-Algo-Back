using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace MatchingAlgo.Migrations
{
    public partial class nullableDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AvailableDate",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "DriverId",
                table: "AvailableDate",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "AvailableDate",
                columns: new[] { "Id", "AvaialbeDate", "DriverId", "HelperId" },
                values: new object[,]
                {
                    { new Guid("4204a444-635f-4845-8926-881ab81092e5"), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("acf7017f-9ac7-45a3-9063-30940be3ae37"), null },
                    { new Guid("423371d9-d9dd-491f-b0bd-a6c0728f9797"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6ecea8de-25a1-4305-9105-2a3b466ca61e"), new Guid("c1b66404-66c6-46b4-ad02-1d5a4c16f001") },
                    { new Guid("5d236980-387a-4e79-a55e-29fe9984a5fa"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0471b3b1-8e8e-4a5a-bfc6-21f7edb42a40"), new Guid("170b7a8f-f843-4482-a79a-b77c4c574630") },
                    { new Guid("a582ee86-edd5-43e4-a078-83120fa5000e"), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3567850-6fb1-4a5a-b681-0334c075e689"), null },
                    { new Guid("b4d8083c-44af-4bc1-a8d6-e904d4b3cabd"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ec29ad8-a93e-4d96-94e5-8f5a27b6a019"), new Guid("c34d743d-f787-4b7d-8ebc-76c0760ff938") }
                });

            migrationBuilder.InsertData(
                table: "Shift",
                columns: new[] { "Id", "DriverId", "EndAvailableTime", "HelperId", "StartAvailableTime" },
                values: new object[,]
                {
                    { new Guid("42f11c2e-3809-48a4-8fcd-cfaa20841abb"), new Guid("d3567850-6fb1-4a5a-b681-0334c075e689"), new TimeSpan(0, 11, 30, 0, 0), null, new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("5fcf259a-9feb-48e5-a62b-2db50bb40163"), new Guid("4ec29ad8-a93e-4d96-94e5-8f5a27b6a019"), new TimeSpan(0, 11, 30, 0, 0), null, new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("7296b0fd-9f02-4a29-b86a-a627234f6b4c"), new Guid("acf7017f-9ac7-45a3-9063-30940be3ae37"), new TimeSpan(0, 11, 30, 0, 0), new Guid("c1b66404-66c6-46b4-ad02-1d5a4c16f001"), new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("942daf1b-2f3b-4234-8054-b3aadb17a622"), new Guid("0471b3b1-8e8e-4a5a-bfc6-21f7edb42a40"), new TimeSpan(0, 11, 30, 0, 0), new Guid("170b7a8f-f843-4482-a79a-b77c4c574630"), new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("bba22ede-6646-4e93-bf97-cd992e93b78a"), new Guid("6ecea8de-25a1-4305-9105-2a3b466ca61e"), new TimeSpan(0, 11, 30, 0, 0), null, new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("fe792abb-723d-4b12-b9c3-ebf5b3e96f1f"), null, new TimeSpan(0, 10, 30, 0, 0), new Guid("c34d743d-f787-4b7d-8ebc-76c0760ff938"), new TimeSpan(0, 8, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "AvaliableDateId", "DistanceToPickUp", "DriverLocation", "ShiftId", "VehicleSize" },
                values: new object[,]
                {
                    { new Guid("0471b3b1-8e8e-4a5a-bfc6-21f7edb42a40"), new Guid("5d236980-387a-4e79-a55e-29fe9984a5fa"), 5.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.518 7.45425)"), new Guid("942daf1b-2f3b-4234-8054-b3aadb17a622"), 0 },
                    { new Guid("4ec29ad8-a93e-4d96-94e5-8f5a27b6a019"), new Guid("b4d8083c-44af-4bc1-a8d6-e904d4b3cabd"), 4.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.503333 -0.119722)"), new Guid("5fcf259a-9feb-48e5-a62b-2db50bb40163"), 2 },
                    { new Guid("6ecea8de-25a1-4305-9105-2a3b466ca61e"), new Guid("423371d9-d9dd-491f-b0bd-a6c0728f9797"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (52.506272 10.377722)"), new Guid("bba22ede-6646-4e93-bf97-cd992e93b78a"), 0 },
                    { new Guid("acf7017f-9ac7-45a3-9063-30940be3ae37"), new Guid("4204a444-635f-4845-8926-881ab81092e5"), 2.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (52.516272 13.377722)"), new Guid("7296b0fd-9f02-4a29-b86a-a627234f6b4c"), 1 },
                    { new Guid("d3567850-6fb1-4a5a-b681-0334c075e689"), new Guid("a582ee86-edd5-43e4-a078-83120fa5000e"), 1.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (59.3275 18.0675)"), new Guid("42f11c2e-3809-48a4-8fcd-cfaa20841abb"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Helpers",
                columns: new[] { "Id", "AvaliableDateId", "DistanceToPickUp", "HelperLocation", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("170b7a8f-f843-4482-a79a-b77c4c574630"), new Guid("5d236980-387a-4e79-a55e-29fe9984a5fa"), 5.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.518 7.45425)"), new Guid("942daf1b-2f3b-4234-8054-b3aadb17a622") },
                    { new Guid("c1b66404-66c6-46b4-ad02-1d5a4c16f001"), new Guid("423371d9-d9dd-491f-b0bd-a6c0728f9797"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (59.3275 18.0675)"), new Guid("7296b0fd-9f02-4a29-b86a-a627234f6b4c") },
                    { new Guid("c34d743d-f787-4b7d-8ebc-76c0760ff938"), new Guid("b4d8083c-44af-4bc1-a8d6-e904d4b3cabd"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.503333 -0.119722)"), new Guid("fe792abb-723d-4b12-b9c3-ebf5b3e96f1f") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("4204a444-635f-4845-8926-881ab81092e5"));

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("423371d9-d9dd-491f-b0bd-a6c0728f9797"));

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("5d236980-387a-4e79-a55e-29fe9984a5fa"));

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("a582ee86-edd5-43e4-a078-83120fa5000e"));

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("b4d8083c-44af-4bc1-a8d6-e904d4b3cabd"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("0471b3b1-8e8e-4a5a-bfc6-21f7edb42a40"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("4ec29ad8-a93e-4d96-94e5-8f5a27b6a019"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("6ecea8de-25a1-4305-9105-2a3b466ca61e"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("acf7017f-9ac7-45a3-9063-30940be3ae37"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("d3567850-6fb1-4a5a-b681-0334c075e689"));

            migrationBuilder.DeleteData(
                table: "Helpers",
                keyColumn: "Id",
                keyValue: new Guid("170b7a8f-f843-4482-a79a-b77c4c574630"));

            migrationBuilder.DeleteData(
                table: "Helpers",
                keyColumn: "Id",
                keyValue: new Guid("c1b66404-66c6-46b4-ad02-1d5a4c16f001"));

            migrationBuilder.DeleteData(
                table: "Helpers",
                keyColumn: "Id",
                keyValue: new Guid("c34d743d-f787-4b7d-8ebc-76c0760ff938"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("42f11c2e-3809-48a4-8fcd-cfaa20841abb"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("5fcf259a-9feb-48e5-a62b-2db50bb40163"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("7296b0fd-9f02-4a29-b86a-a627234f6b4c"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("942daf1b-2f3b-4234-8054-b3aadb17a622"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("bba22ede-6646-4e93-bf97-cd992e93b78a"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("fe792abb-723d-4b12-b9c3-ebf5b3e96f1f"));

            migrationBuilder.AlterColumn<Guid>(
                name: "HelperId",
                table: "AvailableDate",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DriverId",
                table: "AvailableDate",
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
    }
}
