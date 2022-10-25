using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace MatchingAlgo.Migrations
{
    public partial class DataBaseCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvailableDate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AvaialbeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HelperId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    StartAvailableTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndAvailableTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HelperId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
