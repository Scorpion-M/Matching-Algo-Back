using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace MatchingAlgo.Migrations
{
    public partial class DBInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvailableDate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AvaialbeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HelperId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableDate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shift",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartAvailableTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAvailableTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HelperId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shift", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleSize = table.Column<int>(type: "int", nullable: false),
                    DriverLocation = table.Column<Point>(type: "geography", nullable: false),
                    AvaliableDateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShiftId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistanceToPickUp = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drivers_Shift_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shift",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Helpers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HelperLocation = table.Column<Point>(type: "geography", nullable: false),
                    AvaliableDateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShiftId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistanceToPickUp = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Helpers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Helpers_Shift_ShiftId",
                        column: x => x.ShiftId,
                        principalTable: "Shift",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AvailableDateDriver",
                columns: table => new
                {
                    AvailableDatesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriversId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableDateDriver", x => new { x.AvailableDatesId, x.DriversId });
                    table.ForeignKey(
                        name: "FK_AvailableDateDriver_AvailableDate_AvailableDatesId",
                        column: x => x.AvailableDatesId,
                        principalTable: "AvailableDate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvailableDateDriver_Drivers_DriversId",
                        column: x => x.DriversId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AvailableDateHelper",
                columns: table => new
                {
                    AvailableDatesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HelpersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvailableDateHelper", x => new { x.AvailableDatesId, x.HelpersId });
                    table.ForeignKey(
                        name: "FK_AvailableDateHelper_AvailableDate_AvailableDatesId",
                        column: x => x.AvailableDatesId,
                        principalTable: "AvailableDate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AvailableDateHelper_Helpers_HelpersId",
                        column: x => x.HelpersId,
                        principalTable: "Helpers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AvailableDate",
                columns: new[] { "Id", "AvaialbeDate", "DriverId", "HelperId" },
                values: new object[,]
                {
                    { new Guid("448b917a-2ae3-4016-afa8-8fba36230d05"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6ac16ade-f293-4083-9c90-9af2397fd346"), new Guid("a4f4865e-eec9-4d98-b0f5-c66fa3a87eed") },
                    { new Guid("8584a437-f91c-41fc-9bbf-86d5ffbff0b0"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e4f265b4-f564-4417-82e6-e5039a87908c"), new Guid("e8f2b04d-6b60-4c35-8c6f-9f9454091821") },
                    { new Guid("c50e9108-a833-43be-96b9-91ccdd770c15"), new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eeaad275-a039-4828-89a1-b56657863794"), null },
                    { new Guid("fe1151f7-57d7-4e14-a55d-8146201d4633"), new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7baec409-db0d-49a3-8122-9e8cad6f593b"), new Guid("d2759648-0c35-47fc-8d7f-b9adbe6b7f20") },
                    { new Guid("ff192931-d7e5-4077-ba8e-c4d130032321"), new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2558296f-7a0c-4730-ac1c-904ca1b2352c"), null }
                });

            migrationBuilder.InsertData(
                table: "Shift",
                columns: new[] { "Id", "DriverId", "EndAvailableTime", "HelperId", "StartAvailableTime" },
                values: new object[,]
                {
                    { new Guid("35bc3a02-934a-4c8b-bc4c-2a7fbb5a6ef2"), new Guid("6ac16ade-f293-4083-9c90-9af2397fd346"), new DateTime(2022, 1, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), new Guid("a4f4865e-eec9-4d98-b0f5-c66fa3a87eed"), new DateTime(2022, 1, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75cd05ca-94be-464c-b1ab-796c57a3ba81"), new Guid("e4f265b4-f564-4417-82e6-e5039a87908c"), new DateTime(2022, 1, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7970e097-9128-41a0-9894-24d964fc8a61"), new Guid("7baec409-db0d-49a3-8122-9e8cad6f593b"), new DateTime(2022, 1, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("972728ce-c9f0-4382-baa3-38701b3e454c"), new Guid("2558296f-7a0c-4730-ac1c-904ca1b2352c"), new DateTime(2022, 1, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2022, 1, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b4a096f5-4958-4859-aee8-2ec591c7d9ef"), new Guid("eeaad275-a039-4828-89a1-b56657863794"), new DateTime(2022, 1, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), new Guid("e8f2b04d-6b60-4c35-8c6f-9f9454091821"), new DateTime(2022, 1, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c0f4fa61-a2e6-4c74-b26e-db4fe1409146"), null, new DateTime(2022, 1, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), new Guid("d2759648-0c35-47fc-8d7f-b9adbe6b7f20"), new DateTime(2022, 1, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "AvaliableDateId", "DistanceToPickUp", "DriverLocation", "ShiftId", "VehicleSize" },
                values: new object[,]
                {
                    { new Guid("2558296f-7a0c-4730-ac1c-904ca1b2352c"), new Guid("ff192931-d7e5-4077-ba8e-c4d130032321"), 1.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (59.3275 18.0675)"), new Guid("972728ce-c9f0-4382-baa3-38701b3e454c"), 0 },
                    { new Guid("6ac16ade-f293-4083-9c90-9af2397fd346"), new Guid("448b917a-2ae3-4016-afa8-8fba36230d05"), 5.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.518 7.45425)"), new Guid("35bc3a02-934a-4c8b-bc4c-2a7fbb5a6ef2"), 0 },
                    { new Guid("7baec409-db0d-49a3-8122-9e8cad6f593b"), new Guid("fe1151f7-57d7-4e14-a55d-8146201d4633"), 4.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.503333 -0.119722)"), new Guid("7970e097-9128-41a0-9894-24d964fc8a61"), 2 },
                    { new Guid("e4f265b4-f564-4417-82e6-e5039a87908c"), new Guid("8584a437-f91c-41fc-9bbf-86d5ffbff0b0"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (52.506272 10.377722)"), new Guid("75cd05ca-94be-464c-b1ab-796c57a3ba81"), 0 },
                    { new Guid("eeaad275-a039-4828-89a1-b56657863794"), new Guid("c50e9108-a833-43be-96b9-91ccdd770c15"), 2.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (52.516272 13.377722)"), new Guid("b4a096f5-4958-4859-aee8-2ec591c7d9ef"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Helpers",
                columns: new[] { "Id", "AvaliableDateId", "DistanceToPickUp", "HelperLocation", "ShiftId" },
                values: new object[,]
                {
                    { new Guid("a4f4865e-eec9-4d98-b0f5-c66fa3a87eed"), new Guid("448b917a-2ae3-4016-afa8-8fba36230d05"), 5.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.518 7.45425)"), new Guid("35bc3a02-934a-4c8b-bc4c-2a7fbb5a6ef2") },
                    { new Guid("d2759648-0c35-47fc-8d7f-b9adbe6b7f20"), new Guid("fe1151f7-57d7-4e14-a55d-8146201d4633"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.503333 -0.119722)"), new Guid("c0f4fa61-a2e6-4c74-b26e-db4fe1409146") },
                    { new Guid("e8f2b04d-6b60-4c35-8c6f-9f9454091821"), new Guid("8584a437-f91c-41fc-9bbf-86d5ffbff0b0"), 3.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (59.3275 18.0675)"), new Guid("b4a096f5-4958-4859-aee8-2ec591c7d9ef") }
                });

            migrationBuilder.InsertData(
                table: "AvailableDateDriver",
                columns: new[] { "AvailableDatesId", "DriversId" },
                values: new object[,]
                {
                    { new Guid("448b917a-2ae3-4016-afa8-8fba36230d05"), new Guid("6ac16ade-f293-4083-9c90-9af2397fd346") },
                    { new Guid("8584a437-f91c-41fc-9bbf-86d5ffbff0b0"), new Guid("e4f265b4-f564-4417-82e6-e5039a87908c") },
                    { new Guid("c50e9108-a833-43be-96b9-91ccdd770c15"), new Guid("eeaad275-a039-4828-89a1-b56657863794") },
                    { new Guid("fe1151f7-57d7-4e14-a55d-8146201d4633"), new Guid("7baec409-db0d-49a3-8122-9e8cad6f593b") },
                    { new Guid("ff192931-d7e5-4077-ba8e-c4d130032321"), new Guid("2558296f-7a0c-4730-ac1c-904ca1b2352c") }
                });

            migrationBuilder.InsertData(
                table: "AvailableDateHelper",
                columns: new[] { "AvailableDatesId", "HelpersId" },
                values: new object[,]
                {
                    { new Guid("448b917a-2ae3-4016-afa8-8fba36230d05"), new Guid("a4f4865e-eec9-4d98-b0f5-c66fa3a87eed") },
                    { new Guid("8584a437-f91c-41fc-9bbf-86d5ffbff0b0"), new Guid("e8f2b04d-6b60-4c35-8c6f-9f9454091821") },
                    { new Guid("fe1151f7-57d7-4e14-a55d-8146201d4633"), new Guid("d2759648-0c35-47fc-8d7f-b9adbe6b7f20") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AvailableDateDriver_DriversId",
                table: "AvailableDateDriver",
                column: "DriversId");

            migrationBuilder.CreateIndex(
                name: "IX_AvailableDateHelper_HelpersId",
                table: "AvailableDateHelper",
                column: "HelpersId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_ShiftId",
                table: "Drivers",
                column: "ShiftId");

            migrationBuilder.CreateIndex(
                name: "IX_Helpers_ShiftId",
                table: "Helpers",
                column: "ShiftId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvailableDateDriver");

            migrationBuilder.DropTable(
                name: "AvailableDateHelper");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "AvailableDate");

            migrationBuilder.DropTable(
                name: "Helpers");

            migrationBuilder.DropTable(
                name: "Shift");
        }
    }
}
