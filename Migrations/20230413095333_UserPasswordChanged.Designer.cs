﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransportSystem.Models;

#nullable disable

namespace TransportSystem.Migrations
{
    [DbContext(typeof(PublicTransportMonitoringContext))]
    [Migration("20230413095333_UserPasswordChanged")]
    partial class UserPasswordChanged
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TransportSystem.Models.NfcTag", b =>
                {
                    b.Property<int>("TagId")
                        .HasColumnType("int")
                        .HasColumnName("tag_id");

                    b.Property<int?>("TransportUnitId")
                        .HasColumnType("int")
                        .HasColumnName("transport_unit_id");

                    b.HasKey("TagId")
                        .HasName("PK__nfc_tags__4296A2B6BE5C39A9");

                    b.HasIndex("TransportUnitId");

                    b.ToTable("nfc_tag", (string)null);
                });

            modelBuilder.Entity("TransportSystem.Models.RegistrationInfo", b =>
                {
                    b.Property<int>("RegistrationInfoId")
                        .HasColumnType("int")
                        .HasColumnName("registration_info_id");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("datetime")
                        .HasColumnName("expiry_date");

                    b.Property<DateTime>("ReadingTime")
                        .HasColumnType("datetime")
                        .HasColumnName("reading_time");

                    b.Property<int>("TransportUnitId")
                        .HasColumnType("int")
                        .HasColumnName("transport_unit_id");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("RegistrationInfoId")
                        .HasName("PK__registra__899C8A683E8B3806");

                    b.HasIndex("TransportUnitId");

                    b.HasIndex("UserId");

                    b.ToTable("registration_info", (string)null);
                });

            modelBuilder.Entity("TransportSystem.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<string>("RoleName")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("role_name");

                    b.HasKey("RoleId")
                        .HasName("PK__roles__760965CC34C89DFD");

                    b.HasIndex(new[] { "RoleName" }, "UQ__roles__783254B15D4C363F")
                        .IsUnique()
                        .HasFilter("[role_name] IS NOT NULL");

                    b.ToTable("role", (string)null);
                });

            modelBuilder.Entity("TransportSystem.Models.Route", b =>
                {
                    b.Property<int>("RouteId")
                        .HasColumnType("int")
                        .HasColumnName("route_id");

                    b.Property<string>("RouteName")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("route_name");

                    b.HasKey("RouteId")
                        .HasName("PK__route__28F706FEF3067B06");

                    b.ToTable("route", (string)null);
                });

            modelBuilder.Entity("TransportSystem.Models.RouteStation", b =>
                {
                    b.Property<int>("RouteStationId")
                        .HasColumnType("int")
                        .HasColumnName("route_station_id");

                    b.Property<int>("RouteId")
                        .HasColumnType("int")
                        .HasColumnName("route_id");

                    b.Property<int>("StationId")
                        .HasColumnType("int")
                        .HasColumnName("station_id");

                    b.HasKey("RouteStationId")
                        .HasName("PK__route_st__F8B46055CEAD0E73");

                    b.HasIndex("RouteId");

                    b.HasIndex("StationId");

                    b.ToTable("route_station", (string)null);
                });

            modelBuilder.Entity("TransportSystem.Models.Sensor", b =>
                {
                    b.Property<int>("SensorId")
                        .HasColumnType("int")
                        .HasColumnName("sensor_id");

                    b.Property<int?>("TransportUnitId")
                        .HasColumnType("int")
                        .HasColumnName("transport_unit_id");

                    b.HasKey("SensorId")
                        .HasName("PK__ir_trans__29154BAE42A7B68C");

                    b.HasIndex("TransportUnitId");

                    b.ToTable("sensor", (string)null);
                });

            modelBuilder.Entity("TransportSystem.Models.SensorInfo", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("IrTransmittersId")
                        .HasColumnType("int")
                        .HasColumnName("ir_transmitters_id");

                    b.Property<int?>("PassengerCount")
                        .HasColumnType("int")
                        .HasColumnName("passenger_count");

                    b.Property<DateTime>("ReadingTime")
                        .HasColumnType("datetime")
                        .HasColumnName("reading_time");

                    b.HasKey("Id")
                        .HasName("PK__sensor_i__3213E83FCDD8452F");

                    b.HasIndex("IrTransmittersId");

                    b.ToTable("sensor_info", (string)null);
                });

            modelBuilder.Entity("TransportSystem.Models.Station", b =>
                {
                    b.Property<int>("StationId")
                        .HasColumnType("int")
                        .HasColumnName("station_id");

                    b.Property<double>("Latitude")
                        .HasColumnType("float")
                        .HasColumnName("latitude");

                    b.Property<double>("Longitude")
                        .HasColumnType("float")
                        .HasColumnName("longitude");

                    b.Property<string>("StationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("station_name");

                    b.HasKey("StationId")
                        .HasName("PK__stations__44B370E982BDC572");

                    b.ToTable("station", (string)null);
                });

            modelBuilder.Entity("TransportSystem.Models.TicketPurchase", b =>
                {
                    b.Property<int>("TicketPurchaseId")
                        .HasColumnType("int")
                        .HasColumnName("ticket_purchase_id");

                    b.Property<int?>("BusId")
                        .HasColumnType("int")
                        .HasColumnName("bus_id");

                    b.Property<DateTime?>("PurchaseTime")
                        .HasColumnType("datetime")
                        .HasColumnName("purchase_time");

                    b.Property<int?>("TicketTypeId")
                        .HasColumnType("int")
                        .HasColumnName("ticket_type_id");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("TicketPurchaseId")
                        .HasName("PK__ticket_p__C23802A226ADD058");

                    b.HasIndex("BusId");

                    b.HasIndex("TicketTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("ticket_purchase", (string)null);
                });

            modelBuilder.Entity("TransportSystem.Models.TicketType", b =>
                {
                    b.Property<int>("TicketTypeId")
                        .HasColumnType("int")
                        .HasColumnName("ticket_type_id");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("ticket_price");

                    b.Property<string>("TicketTypeName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("ticket_type_name");

                    b.HasKey("TicketTypeId")
                        .HasName("PK__ticket_t__9531B7D17C0267C7");

                    b.ToTable("ticket_type", (string)null);
                });

            modelBuilder.Entity("TransportSystem.Models.Timetable", b =>
                {
                    b.Property<int>("TimetableId")
                        .HasColumnType("int")
                        .HasColumnName("timetable_id");

                    b.Property<TimeSpan>("ArrivalTime")
                        .HasColumnType("time")
                        .HasColumnName("arrival_time");

                    b.Property<int>("StationId")
                        .HasColumnType("int")
                        .HasColumnName("station_id");

                    b.Property<int>("TransportUnitId")
                        .HasColumnType("int")
                        .HasColumnName("transport_unit_id");

                    b.HasKey("TimetableId")
                        .HasName("PK__timetabl__26DC9588DF28C0EB");

                    b.HasIndex("StationId");

                    b.HasIndex("TransportUnitId");

                    b.ToTable("timetable", (string)null);
                });

            modelBuilder.Entity("TransportSystem.Models.TransportUnit", b =>
                {
                    b.Property<int>("TransportUnitId")
                        .HasColumnType("int")
                        .HasColumnName("transport_unit_id");

                    b.Property<int?>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("capacity");

                    b.Property<int?>("DriverId")
                        .HasColumnType("int")
                        .HasColumnName("driver_id");

                    b.Property<int?>("RouteId")
                        .HasColumnType("int")
                        .HasColumnName("route_id");

                    b.HasKey("TransportUnitId")
                        .HasName("PK__buses__6ACEF8ED25B1A061");

                    b.HasIndex("DriverId");

                    b.HasIndex("RouteId");

                    b.ToTable("transport_unit", (string)null);
                });

            modelBuilder.Entity("TransportSystem.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<byte[]>("Password")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varbinary(255)")
                        .HasColumnName("password");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<string>("Username")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("username");

                    b.HasKey("UserId")
                        .HasName("PK__users__B9BE370F09AB4DB9");

                    b.HasIndex("RoleId");

                    b.HasIndex(new[] { "Username" }, "UQ__users__F3DBC5725D4A6B6A")
                        .IsUnique()
                        .HasFilter("[username] IS NOT NULL");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("TransportSystem.Models.NfcTag", b =>
                {
                    b.HasOne("TransportSystem.Models.TransportUnit", "TransportUnit")
                        .WithMany("NfcTags")
                        .HasForeignKey("TransportUnitId")
                        .HasConstraintName("FK__nfc_tags__bus_id__3E52440B");

                    b.Navigation("TransportUnit");
                });

            modelBuilder.Entity("TransportSystem.Models.RegistrationInfo", b =>
                {
                    b.HasOne("TransportSystem.Models.TransportUnit", "TransportUnit")
                        .WithMany("RegistrationInfos")
                        .HasForeignKey("TransportUnitId")
                        .IsRequired()
                        .HasConstraintName("FK__registrat__trans__282DF8C2");

                    b.HasOne("TransportSystem.Models.User", "User")
                        .WithMany("RegistrationInfos")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__registrat__user___2739D489");

                    b.Navigation("TransportUnit");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TransportSystem.Models.RouteStation", b =>
                {
                    b.HasOne("TransportSystem.Models.Route", "Route")
                        .WithMany("RouteStations")
                        .HasForeignKey("RouteId")
                        .IsRequired()
                        .HasConstraintName("FK__route_sta__route__3E1D39E1");

                    b.HasOne("TransportSystem.Models.Station", "Station")
                        .WithMany("RouteStations")
                        .HasForeignKey("StationId")
                        .IsRequired()
                        .HasConstraintName("FK__route_sta__stati__3F115E1A");

                    b.Navigation("Route");

                    b.Navigation("Station");
                });

            modelBuilder.Entity("TransportSystem.Models.Sensor", b =>
                {
                    b.HasOne("TransportSystem.Models.TransportUnit", "TransportUnit")
                        .WithMany("Sensors")
                        .HasForeignKey("TransportUnitId")
                        .HasConstraintName("FK__ir_transm__bus_i__3B75D760");

                    b.Navigation("TransportUnit");
                });

            modelBuilder.Entity("TransportSystem.Models.SensorInfo", b =>
                {
                    b.HasOne("TransportSystem.Models.Sensor", "IrTransmitters")
                        .WithMany("SensorInfos")
                        .HasForeignKey("IrTransmittersId")
                        .HasConstraintName("FK__sensor_in__ir_tr__02FC7413");

                    b.Navigation("IrTransmitters");
                });

            modelBuilder.Entity("TransportSystem.Models.TicketPurchase", b =>
                {
                    b.HasOne("TransportSystem.Models.TransportUnit", "Bus")
                        .WithMany("TicketPurchases")
                        .HasForeignKey("BusId")
                        .HasConstraintName("FK__ticket_pu__bus_i__5DCAEF64");

                    b.HasOne("TransportSystem.Models.TicketType", "TicketType")
                        .WithMany("TicketPurchases")
                        .HasForeignKey("TicketTypeId")
                        .HasConstraintName("FK__ticket_pu__ticke__60A75C0F");

                    b.HasOne("TransportSystem.Models.User", "User")
                        .WithMany("TicketPurchases")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__ticket_pu__user___5CD6CB2B");

                    b.Navigation("Bus");

                    b.Navigation("TicketType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TransportSystem.Models.Timetable", b =>
                {
                    b.HasOne("TransportSystem.Models.Station", "Station")
                        .WithMany("Timetables")
                        .HasForeignKey("StationId")
                        .IsRequired()
                        .HasConstraintName("FK__timetable__stati__72C60C4A");

                    b.HasOne("TransportSystem.Models.TransportUnit", "TransportUnit")
                        .WithMany("Timetables")
                        .HasForeignKey("TransportUnitId")
                        .IsRequired()
                        .HasConstraintName("FK__timetable__bus_i__71D1E811");

                    b.Navigation("Station");

                    b.Navigation("TransportUnit");
                });

            modelBuilder.Entity("TransportSystem.Models.TransportUnit", b =>
                {
                    b.HasOne("TransportSystem.Models.User", "Driver")
                        .WithMany("TransportUnits")
                        .HasForeignKey("DriverId")
                        .HasConstraintName("FK__buses__user_id__4F7CD00D");

                    b.HasOne("TransportSystem.Models.Route", "Route")
                        .WithMany("TransportUnits")
                        .HasForeignKey("RouteId")
                        .HasConstraintName("FK__transport__route__4D5F7D71");

                    b.Navigation("Driver");

                    b.Navigation("Route");
                });

            modelBuilder.Entity("TransportSystem.Models.User", b =>
                {
                    b.HasOne("TransportSystem.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK__users__role_id__4E88ABD4");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("TransportSystem.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("TransportSystem.Models.Route", b =>
                {
                    b.Navigation("RouteStations");

                    b.Navigation("TransportUnits");
                });

            modelBuilder.Entity("TransportSystem.Models.Sensor", b =>
                {
                    b.Navigation("SensorInfos");
                });

            modelBuilder.Entity("TransportSystem.Models.Station", b =>
                {
                    b.Navigation("RouteStations");

                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("TransportSystem.Models.TicketType", b =>
                {
                    b.Navigation("TicketPurchases");
                });

            modelBuilder.Entity("TransportSystem.Models.TransportUnit", b =>
                {
                    b.Navigation("NfcTags");

                    b.Navigation("RegistrationInfos");

                    b.Navigation("Sensors");

                    b.Navigation("TicketPurchases");

                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("TransportSystem.Models.User", b =>
                {
                    b.Navigation("RegistrationInfos");

                    b.Navigation("TicketPurchases");

                    b.Navigation("TransportUnits");
                });
#pragma warning restore 612, 618
        }
    }
}
