﻿// <auto-generated />
using System;
using MatchingAlgo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

#nullable disable

namespace MatchingAlgo.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AvailableDateDriver", b =>
                {
                    b.Property<Guid>("AvailableDatesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DriversId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AvailableDatesId", "DriversId");

                    b.HasIndex("DriversId");

                    b.ToTable("AvailableDateDriver");

                    b.HasData(
                        new
                        {
                            AvailableDatesId = new Guid("ed21818a-6923-4273-bfe9-49d42e39f2a3"),
                            DriversId = new Guid("efff30c0-87a4-4ace-9a63-41a0196fd5cf")
                        },
                        new
                        {
                            AvailableDatesId = new Guid("aadfe685-6183-4edd-aa37-dfeb37876bdc"),
                            DriversId = new Guid("8da8ba30-cc43-4abc-958f-ba8534e0c851")
                        },
                        new
                        {
                            AvailableDatesId = new Guid("8848e8d0-725c-4b22-b726-185ae1a09cd3"),
                            DriversId = new Guid("cc8366c1-08a7-421a-b996-17d301d18e46")
                        },
                        new
                        {
                            AvailableDatesId = new Guid("ce8d1020-58f7-49cf-8829-12d9980a5ff9"),
                            DriversId = new Guid("b8d0cf5f-0a15-4553-9ab3-796efda31222")
                        },
                        new
                        {
                            AvailableDatesId = new Guid("3f97053e-3e6d-4dbc-a8fd-30656901fc70"),
                            DriversId = new Guid("1b1ae87e-4e2c-47a3-9994-78ec0887e241")
                        });
                });

            modelBuilder.Entity("AvailableDateHelper", b =>
                {
                    b.Property<Guid>("AvailableDatesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HelpersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AvailableDatesId", "HelpersId");

                    b.HasIndex("HelpersId");

                    b.ToTable("AvailableDateHelper");

                    b.HasData(
                        new
                        {
                            AvailableDatesId = new Guid("ed21818a-6923-4273-bfe9-49d42e39f2a3"),
                            HelpersId = new Guid("cfaf13c9-f75d-400b-8148-bba542ae579a")
                        },
                        new
                        {
                            AvailableDatesId = new Guid("ce8d1020-58f7-49cf-8829-12d9980a5ff9"),
                            HelpersId = new Guid("70cc46b5-d095-41a1-81fd-5c3990230b17")
                        },
                        new
                        {
                            AvailableDatesId = new Guid("3f97053e-3e6d-4dbc-a8fd-30656901fc70"),
                            HelpersId = new Guid("9c3f02b0-bb38-4578-9bd3-1dd19b3ed08c")
                        });
                });

            modelBuilder.Entity("MatchingAlgo.Data.AvailableDate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AvaialbeDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DriverId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HelperId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AvailableDate");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ed21818a-6923-4273-bfe9-49d42e39f2a3"),
                            AvaialbeDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverId = new Guid("efff30c0-87a4-4ace-9a63-41a0196fd5cf"),
                            HelperId = new Guid("cfaf13c9-f75d-400b-8148-bba542ae579a")
                        },
                        new
                        {
                            Id = new Guid("aadfe685-6183-4edd-aa37-dfeb37876bdc"),
                            AvaialbeDate = new DateTime(2022, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverId = new Guid("8da8ba30-cc43-4abc-958f-ba8534e0c851")
                        },
                        new
                        {
                            Id = new Guid("8848e8d0-725c-4b22-b726-185ae1a09cd3"),
                            AvaialbeDate = new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverId = new Guid("cc8366c1-08a7-421a-b996-17d301d18e46")
                        },
                        new
                        {
                            Id = new Guid("ce8d1020-58f7-49cf-8829-12d9980a5ff9"),
                            AvaialbeDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverId = new Guid("b8d0cf5f-0a15-4553-9ab3-796efda31222"),
                            HelperId = new Guid("70cc46b5-d095-41a1-81fd-5c3990230b17")
                        },
                        new
                        {
                            Id = new Guid("3f97053e-3e6d-4dbc-a8fd-30656901fc70"),
                            AvaialbeDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DriverId = new Guid("1b1ae87e-4e2c-47a3-9994-78ec0887e241"),
                            HelperId = new Guid("9c3f02b0-bb38-4578-9bd3-1dd19b3ed08c")
                        });
                });

            modelBuilder.Entity("MatchingAlgo.Data.Driver", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AvaliableDateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DistanceToPickUp")
                        .HasColumnType("float");

                    b.Property<Point>("DriverLocation")
                        .IsRequired()
                        .HasColumnType("geography");

                    b.Property<Guid?>("ShiftId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("VehicleSize")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShiftId");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("efff30c0-87a4-4ace-9a63-41a0196fd5cf"),
                            AvaliableDateId = new Guid("ed21818a-6923-4273-bfe9-49d42e39f2a3"),
                            DistanceToPickUp = 5.0,
                            DriverLocation = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.518 7.45425)"),
                            ShiftId = new Guid("5db02059-1ae2-478d-834d-23296316007e"),
                            VehicleSize = 0
                        },
                        new
                        {
                            Id = new Guid("8da8ba30-cc43-4abc-958f-ba8534e0c851"),
                            AvaliableDateId = new Guid("aadfe685-6183-4edd-aa37-dfeb37876bdc"),
                            DistanceToPickUp = 2.0,
                            DriverLocation = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (52.516272 13.377722)"),
                            ShiftId = new Guid("b70c4e67-87f8-4e8b-9d14-0216988f9c3b"),
                            VehicleSize = 1
                        },
                        new
                        {
                            Id = new Guid("cc8366c1-08a7-421a-b996-17d301d18e46"),
                            AvaliableDateId = new Guid("8848e8d0-725c-4b22-b726-185ae1a09cd3"),
                            DistanceToPickUp = 1.0,
                            DriverLocation = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (59.3275 18.0675)"),
                            ShiftId = new Guid("32f5b362-ca05-4757-9b22-ebea8cd67027"),
                            VehicleSize = 0
                        },
                        new
                        {
                            Id = new Guid("b8d0cf5f-0a15-4553-9ab3-796efda31222"),
                            AvaliableDateId = new Guid("ce8d1020-58f7-49cf-8829-12d9980a5ff9"),
                            DistanceToPickUp = 4.0,
                            DriverLocation = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.503333 -0.119722)"),
                            ShiftId = new Guid("da854648-ae35-436c-8499-145b798e05fe"),
                            VehicleSize = 2
                        },
                        new
                        {
                            Id = new Guid("1b1ae87e-4e2c-47a3-9994-78ec0887e241"),
                            AvaliableDateId = new Guid("3f97053e-3e6d-4dbc-a8fd-30656901fc70"),
                            DistanceToPickUp = 3.0,
                            DriverLocation = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (52.506272 10.377722)"),
                            ShiftId = new Guid("b104ed68-3919-4e89-a9d2-49adcacca423"),
                            VehicleSize = 0
                        });
                });

            modelBuilder.Entity("MatchingAlgo.Data.Helper", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AvaliableDateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DistanceToPickUp")
                        .HasColumnType("float");

                    b.Property<Point>("HelperLocation")
                        .IsRequired()
                        .HasColumnType("geography");

                    b.Property<Guid?>("ShiftId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ShiftId");

                    b.ToTable("Helpers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cfaf13c9-f75d-400b-8148-bba542ae579a"),
                            AvaliableDateId = new Guid("ed21818a-6923-4273-bfe9-49d42e39f2a3"),
                            DistanceToPickUp = 5.0,
                            HelperLocation = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.518 7.45425)"),
                            ShiftId = new Guid("5db02059-1ae2-478d-834d-23296316007e")
                        },
                        new
                        {
                            Id = new Guid("70cc46b5-d095-41a1-81fd-5c3990230b17"),
                            AvaliableDateId = new Guid("ce8d1020-58f7-49cf-8829-12d9980a5ff9"),
                            DistanceToPickUp = 3.0,
                            HelperLocation = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (51.503333 -0.119722)"),
                            ShiftId = new Guid("ee136e11-1d82-49fe-9260-9b51a41c999d")
                        },
                        new
                        {
                            Id = new Guid("9c3f02b0-bb38-4578-9bd3-1dd19b3ed08c"),
                            AvaliableDateId = new Guid("3f97053e-3e6d-4dbc-a8fd-30656901fc70"),
                            DistanceToPickUp = 3.0,
                            HelperLocation = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (59.3275 18.0675)"),
                            ShiftId = new Guid("b70c4e67-87f8-4e8b-9d14-0216988f9c3b")
                        });
                });

            modelBuilder.Entity("MatchingAlgo.Data.Shift", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DriverId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeSpan>("EndAvailableTime")
                        .HasColumnType("time");

                    b.Property<Guid?>("HelperId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeSpan>("StartAvailableTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Shift");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5db02059-1ae2-478d-834d-23296316007e"),
                            DriverId = new Guid("efff30c0-87a4-4ace-9a63-41a0196fd5cf"),
                            EndAvailableTime = new TimeSpan(0, 11, 30, 0, 0),
                            HelperId = new Guid("cfaf13c9-f75d-400b-8148-bba542ae579a"),
                            StartAvailableTime = new TimeSpan(0, 9, 30, 0, 0)
                        },
                        new
                        {
                            Id = new Guid("ee136e11-1d82-49fe-9260-9b51a41c999d"),
                            EndAvailableTime = new TimeSpan(0, 10, 30, 0, 0),
                            HelperId = new Guid("70cc46b5-d095-41a1-81fd-5c3990230b17"),
                            StartAvailableTime = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            Id = new Guid("b70c4e67-87f8-4e8b-9d14-0216988f9c3b"),
                            DriverId = new Guid("8da8ba30-cc43-4abc-958f-ba8534e0c851"),
                            EndAvailableTime = new TimeSpan(0, 11, 30, 0, 0),
                            HelperId = new Guid("9c3f02b0-bb38-4578-9bd3-1dd19b3ed08c"),
                            StartAvailableTime = new TimeSpan(0, 9, 30, 0, 0)
                        },
                        new
                        {
                            Id = new Guid("32f5b362-ca05-4757-9b22-ebea8cd67027"),
                            DriverId = new Guid("cc8366c1-08a7-421a-b996-17d301d18e46"),
                            EndAvailableTime = new TimeSpan(0, 11, 30, 0, 0),
                            StartAvailableTime = new TimeSpan(0, 9, 30, 0, 0)
                        },
                        new
                        {
                            Id = new Guid("da854648-ae35-436c-8499-145b798e05fe"),
                            DriverId = new Guid("b8d0cf5f-0a15-4553-9ab3-796efda31222"),
                            EndAvailableTime = new TimeSpan(0, 11, 30, 0, 0),
                            StartAvailableTime = new TimeSpan(0, 9, 30, 0, 0)
                        },
                        new
                        {
                            Id = new Guid("b104ed68-3919-4e89-a9d2-49adcacca423"),
                            DriverId = new Guid("1b1ae87e-4e2c-47a3-9994-78ec0887e241"),
                            EndAvailableTime = new TimeSpan(0, 11, 30, 0, 0),
                            StartAvailableTime = new TimeSpan(0, 9, 30, 0, 0)
                        });
                });

            modelBuilder.Entity("AvailableDateDriver", b =>
                {
                    b.HasOne("MatchingAlgo.Data.AvailableDate", null)
                        .WithMany()
                        .HasForeignKey("AvailableDatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MatchingAlgo.Data.Driver", null)
                        .WithMany()
                        .HasForeignKey("DriversId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AvailableDateHelper", b =>
                {
                    b.HasOne("MatchingAlgo.Data.AvailableDate", null)
                        .WithMany()
                        .HasForeignKey("AvailableDatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MatchingAlgo.Data.Helper", null)
                        .WithMany()
                        .HasForeignKey("HelpersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MatchingAlgo.Data.Driver", b =>
                {
                    b.HasOne("MatchingAlgo.Data.Shift", "Shift")
                        .WithMany("Drivers")
                        .HasForeignKey("ShiftId");

                    b.Navigation("Shift");
                });

            modelBuilder.Entity("MatchingAlgo.Data.Helper", b =>
                {
                    b.HasOne("MatchingAlgo.Data.Shift", "Shift")
                        .WithMany("Helpers")
                        .HasForeignKey("ShiftId");

                    b.Navigation("Shift");
                });

            modelBuilder.Entity("MatchingAlgo.Data.Shift", b =>
                {
                    b.Navigation("Drivers");

                    b.Navigation("Helpers");
                });
#pragma warning restore 612, 618
        }
    }
}
