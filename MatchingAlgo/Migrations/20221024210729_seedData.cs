using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace MatchingAlgo.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AvailableDate",
                columns: new[] { "Id", "AvaialbeDate", "DriverId", "HelperId" },
                values: new object[,]
                {
                    { new Guid("3f97053e-3e6d-4dbc-a8fd-30656901fc70"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1b1ae87e-4e2c-47a3-9994-78ec0887e241"), new Guid("9c3f02b0-bb38-4578-9bd3-1dd19b3ed08c") },
                    { new Guid("8848e8d0-725c-4b22-b726-185ae1a09cd3"), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cc8366c1-08a7-421a-b996-17d301d18e46"), null },
                    { new Guid("aadfe685-6183-4edd-aa37-dfeb37876bdc"), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8da8ba30-cc43-4abc-958f-ba8534e0c851"), null },
                    { new Guid("ce8d1020-58f7-49cf-8829-12d9980a5ff9"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8d0cf5f-0a15-4553-9ab3-796efda31222"), new Guid("70cc46b5-d095-41a1-81fd-5c3990230b17") },
                    { new Guid("ed21818a-6923-4273-bfe9-49d42e39f2a3"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("efff30c0-87a4-4ace-9a63-41a0196fd5cf"), new Guid("cfaf13c9-f75d-400b-8148-bba542ae579a") }
                });

            migrationBuilder.InsertData(
                table: "Shift",
                columns: new[] { "Id", "DriverId", "EndAvailableTime", "HelperId", "StartAvailableTime" },
                values: new object[,]
                {
                    { new Guid("32f5b362-ca05-4757-9b22-ebea8cd67027"), new Guid("cc8366c1-08a7-421a-b996-17d301d18e46"), new TimeSpan(0, 11, 30, 0, 0), null, new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("5db02059-1ae2-478d-834d-23296316007e"), new Guid("efff30c0-87a4-4ace-9a63-41a0196fd5cf"), new TimeSpan(0, 11, 30, 0, 0), new Guid("cfaf13c9-f75d-400b-8148-bba542ae579a"), new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("b104ed68-3919-4e89-a9d2-49adcacca423"), new Guid("1b1ae87e-4e2c-47a3-9994-78ec0887e241"), new TimeSpan(0, 11, 30, 0, 0), null, new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("b70c4e67-87f8-4e8b-9d14-0216988f9c3b"), new Guid("8da8ba30-cc43-4abc-958f-ba8534e0c851"), new TimeSpan(0, 11, 30, 0, 0), new Guid("9c3f02b0-bb38-4578-9bd3-1dd19b3ed08c"), new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("da854648-ae35-436c-8499-145b798e05fe"), new Guid("b8d0cf5f-0a15-4553-9ab3-796efda31222"), new TimeSpan(0, 11, 30, 0, 0), null, new TimeSpan(0, 9, 30, 0, 0) },
                    { new Guid("ee136e11-1d82-49fe-9260-9b51a41c999d"), null, new TimeSpan(0, 10, 30, 0, 0), new Guid("70cc46b5-d095-41a1-81fd-5c3990230b17"), new TimeSpan(0, 8, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "AvaliableDateId", "DistanceToPickUp", "DriverLocation", "ShiftId", "VehicleSize" },
                values: new object[,]
                {
                    { new Guid("1b1ae87e-4e2c-47a3-9994-78ec0887e241"), new Guid("3f97053e-3e6d-4dbc-a8fd-30656901fc70"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (52.506272 10.377722)"), new Guid("b104ed68-3919-4e89-a9d2-49adcacca423"), 0 },
                    { new Guid("8da8ba30-cc43-4abc-958f-ba8534e0c851"), new Guid("aadfe685-6183-4edd-aa37-dfeb37876bdc"), 2.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (52.516272 13.377722)"), new Guid("b70c4e67-87f8-4e8b-9d14-0216988f9c3b"), 1 },
                    { new Guid("b8d0cf5f-0a15-4553-9ab3-796efda31222"), new Guid("ce8d1020-58f7-49cf-8829-12d9980a5ff9"), 4.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.503333 -0.119722)"), new Guid("da854648-ae35-436c-8499-145b798e05fe"), 2 },
                    { new Guid("cc8366c1-08a7-421a-b996-17d301d18e46"), new Guid("8848e8d0-725c-4b22-b726-185ae1a09cd3"), 1.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (59.3275 18.0675)"), new Guid("32f5b362-ca05-4757-9b22-ebea8cd67027"), 0 },
                    { new Guid("efff30c0-87a4-4ace-9a63-41a0196fd5cf"), new Guid("ed21818a-6923-4273-bfe9-49d42e39f2a3"), 5.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.518 7.45425)"), new Guid("5db02059-1ae2-478d-834d-23296316007e"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Helpers",
                columns: new[] { "Id", "AvaliableDateId", "DistanceToPickUp", "HelperLocation", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("70cc46b5-d095-41a1-81fd-5c3990230b17"), new Guid("ce8d1020-58f7-49cf-8829-12d9980a5ff9"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.503333 -0.119722)"), new Guid("ee136e11-1d82-49fe-9260-9b51a41c999d") },
                    { new Guid("9c3f02b0-bb38-4578-9bd3-1dd19b3ed08c"), new Guid("3f97053e-3e6d-4dbc-a8fd-30656901fc70"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (59.3275 18.0675)"), new Guid("b70c4e67-87f8-4e8b-9d14-0216988f9c3b") },
                    { new Guid("cfaf13c9-f75d-400b-8148-bba542ae579a"), new Guid("ed21818a-6923-4273-bfe9-49d42e39f2a3"), 5.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.518 7.45425)"), new Guid("5db02059-1ae2-478d-834d-23296316007e") }
                });

            migrationBuilder.InsertData(
                table: "AvailableDateDriver",
                columns: new[] { "AvailableDatesId", "DriversId" },
                values: new object[,]
                {
                    { new Guid("3f97053e-3e6d-4dbc-a8fd-30656901fc70"), new Guid("1b1ae87e-4e2c-47a3-9994-78ec0887e241") },
                    { new Guid("8848e8d0-725c-4b22-b726-185ae1a09cd3"), new Guid("cc8366c1-08a7-421a-b996-17d301d18e46") },
                    { new Guid("aadfe685-6183-4edd-aa37-dfeb37876bdc"), new Guid("8da8ba30-cc43-4abc-958f-ba8534e0c851") },
                    { new Guid("ce8d1020-58f7-49cf-8829-12d9980a5ff9"), new Guid("b8d0cf5f-0a15-4553-9ab3-796efda31222") },
                    { new Guid("ed21818a-6923-4273-bfe9-49d42e39f2a3"), new Guid("efff30c0-87a4-4ace-9a63-41a0196fd5cf") }
                });

            migrationBuilder.InsertData(
                table: "AvailableDateHelper",
                columns: new[] { "AvailableDatesId", "HelpersId" },
                values: new object[,]
                {
                    { new Guid("3f97053e-3e6d-4dbc-a8fd-30656901fc70"), new Guid("9c3f02b0-bb38-4578-9bd3-1dd19b3ed08c") },
                    { new Guid("ce8d1020-58f7-49cf-8829-12d9980a5ff9"), new Guid("70cc46b5-d095-41a1-81fd-5c3990230b17") },
                    { new Guid("ed21818a-6923-4273-bfe9-49d42e39f2a3"), new Guid("cfaf13c9-f75d-400b-8148-bba542ae579a") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AvailableDateDriver",
                keyColumns: new[] { "AvailableDatesId", "DriversId" },
                keyValues: new object[] { new Guid("3f97053e-3e6d-4dbc-a8fd-30656901fc70"), new Guid("1b1ae87e-4e2c-47a3-9994-78ec0887e241") });

            migrationBuilder.DeleteData(
                table: "AvailableDateDriver",
                keyColumns: new[] { "AvailableDatesId", "DriversId" },
                keyValues: new object[] { new Guid("8848e8d0-725c-4b22-b726-185ae1a09cd3"), new Guid("cc8366c1-08a7-421a-b996-17d301d18e46") });

            migrationBuilder.DeleteData(
                table: "AvailableDateDriver",
                keyColumns: new[] { "AvailableDatesId", "DriversId" },
                keyValues: new object[] { new Guid("aadfe685-6183-4edd-aa37-dfeb37876bdc"), new Guid("8da8ba30-cc43-4abc-958f-ba8534e0c851") });

            migrationBuilder.DeleteData(
                table: "AvailableDateDriver",
                keyColumns: new[] { "AvailableDatesId", "DriversId" },
                keyValues: new object[] { new Guid("ce8d1020-58f7-49cf-8829-12d9980a5ff9"), new Guid("b8d0cf5f-0a15-4553-9ab3-796efda31222") });

            migrationBuilder.DeleteData(
                table: "AvailableDateDriver",
                keyColumns: new[] { "AvailableDatesId", "DriversId" },
                keyValues: new object[] { new Guid("ed21818a-6923-4273-bfe9-49d42e39f2a3"), new Guid("efff30c0-87a4-4ace-9a63-41a0196fd5cf") });

            migrationBuilder.DeleteData(
                table: "AvailableDateHelper",
                keyColumns: new[] { "AvailableDatesId", "HelpersId" },
                keyValues: new object[] { new Guid("3f97053e-3e6d-4dbc-a8fd-30656901fc70"), new Guid("9c3f02b0-bb38-4578-9bd3-1dd19b3ed08c") });

            migrationBuilder.DeleteData(
                table: "AvailableDateHelper",
                keyColumns: new[] { "AvailableDatesId", "HelpersId" },
                keyValues: new object[] { new Guid("ce8d1020-58f7-49cf-8829-12d9980a5ff9"), new Guid("70cc46b5-d095-41a1-81fd-5c3990230b17") });

            migrationBuilder.DeleteData(
                table: "AvailableDateHelper",
                keyColumns: new[] { "AvailableDatesId", "HelpersId" },
                keyValues: new object[] { new Guid("ed21818a-6923-4273-bfe9-49d42e39f2a3"), new Guid("cfaf13c9-f75d-400b-8148-bba542ae579a") });

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("3f97053e-3e6d-4dbc-a8fd-30656901fc70"));

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("8848e8d0-725c-4b22-b726-185ae1a09cd3"));

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("aadfe685-6183-4edd-aa37-dfeb37876bdc"));

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("ce8d1020-58f7-49cf-8829-12d9980a5ff9"));

            migrationBuilder.DeleteData(
                table: "AvailableDate",
                keyColumn: "Id",
                keyValue: new Guid("ed21818a-6923-4273-bfe9-49d42e39f2a3"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("1b1ae87e-4e2c-47a3-9994-78ec0887e241"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("8da8ba30-cc43-4abc-958f-ba8534e0c851"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("b8d0cf5f-0a15-4553-9ab3-796efda31222"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("cc8366c1-08a7-421a-b996-17d301d18e46"));

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: new Guid("efff30c0-87a4-4ace-9a63-41a0196fd5cf"));

            migrationBuilder.DeleteData(
                table: "Helpers",
                keyColumn: "Id",
                keyValue: new Guid("70cc46b5-d095-41a1-81fd-5c3990230b17"));

            migrationBuilder.DeleteData(
                table: "Helpers",
                keyColumn: "Id",
                keyValue: new Guid("9c3f02b0-bb38-4578-9bd3-1dd19b3ed08c"));

            migrationBuilder.DeleteData(
                table: "Helpers",
                keyColumn: "Id",
                keyValue: new Guid("cfaf13c9-f75d-400b-8148-bba542ae579a"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("32f5b362-ca05-4757-9b22-ebea8cd67027"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("5db02059-1ae2-478d-834d-23296316007e"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("b104ed68-3919-4e89-a9d2-49adcacca423"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("b70c4e67-87f8-4e8b-9d14-0216988f9c3b"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("da854648-ae35-436c-8499-145b798e05fe"));

            migrationBuilder.DeleteData(
                table: "Shift",
                keyColumn: "Id",
                keyValue: new Guid("ee136e11-1d82-49fe-9260-9b51a41c999d"));

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
    }
}
