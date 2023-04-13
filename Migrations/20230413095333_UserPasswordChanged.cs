using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportSystem.Migrations
{
    /// <inheritdoc />
    public partial class UserPasswordChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "role",
            //    columns: table => new
            //    {
            //        role_id = table.Column<int>(type: "int", nullable: false),
            //        role_name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__roles__760965CC34C89DFD", x => x.role_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "route",
            //    columns: table => new
            //    {
            //        route_id = table.Column<int>(type: "int", nullable: false),
            //        route_name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__route__28F706FEF3067B06", x => x.route_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "station",
            //    columns: table => new
            //    {
            //        station_id = table.Column<int>(type: "int", nullable: false),
            //        station_name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        longitude = table.Column<double>(type: "float", nullable: false),
            //        latitude = table.Column<double>(type: "float", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__stations__44B370E982BDC572", x => x.station_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ticket_type",
            //    columns: table => new
            //    {
            //        ticket_type_id = table.Column<int>(type: "int", nullable: false),
            //        ticket_type_name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
            //        ticket_price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__ticket_t__9531B7D17C0267C7", x => x.ticket_type_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "user",
            //    columns: table => new
            //    {
            //        user_id = table.Column<int>(type: "int", nullable: false),
            //        username = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
            //        password = table.Column<byte[]>(type: "varbinary(255)", unicode: false, maxLength: 255, nullable: true),
            //        role_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__users__B9BE370F09AB4DB9", x => x.user_id);
            //        table.ForeignKey(
            //            name: "FK__users__role_id__4E88ABD4",
            //            column: x => x.role_id,
            //            principalTable: "role",
            //            principalColumn: "role_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "route_station",
            //    columns: table => new
            //    {
            //        route_station_id = table.Column<int>(type: "int", nullable: false),
            //        route_id = table.Column<int>(type: "int", nullable: false),
            //        station_id = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__route_st__F8B46055CEAD0E73", x => x.route_station_id);
            //        table.ForeignKey(
            //            name: "FK__route_sta__route__3E1D39E1",
            //            column: x => x.route_id,
            //            principalTable: "route",
            //            principalColumn: "route_id");
            //        table.ForeignKey(
            //            name: "FK__route_sta__stati__3F115E1A",
            //            column: x => x.station_id,
            //            principalTable: "station",
            //            principalColumn: "station_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "transport_unit",
            //    columns: table => new
            //    {
            //        transport_unit_id = table.Column<int>(type: "int", nullable: false),
            //        capacity = table.Column<int>(type: "int", nullable: true),
            //        driver_id = table.Column<int>(type: "int", nullable: true),
            //        route_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__buses__6ACEF8ED25B1A061", x => x.transport_unit_id);
            //        table.ForeignKey(
            //            name: "FK__buses__user_id__4F7CD00D",
            //            column: x => x.driver_id,
            //            principalTable: "user",
            //            principalColumn: "user_id");
            //        table.ForeignKey(
            //            name: "FK__transport__route__4D5F7D71",
            //            column: x => x.route_id,
            //            principalTable: "route",
            //            principalColumn: "route_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "nfc_tag",
            //    columns: table => new
            //    {
            //        tag_id = table.Column<int>(type: "int", nullable: false),
            //        transport_unit_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__nfc_tags__4296A2B6BE5C39A9", x => x.tag_id);
            //        table.ForeignKey(
            //            name: "FK__nfc_tags__bus_id__3E52440B",
            //            column: x => x.transport_unit_id,
            //            principalTable: "transport_unit",
            //            principalColumn: "transport_unit_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "registration_info",
            //    columns: table => new
            //    {
            //        registration_info_id = table.Column<int>(type: "int", nullable: false),
            //        reading_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        user_id = table.Column<int>(type: "int", nullable: false),
            //        transport_unit_id = table.Column<int>(type: "int", nullable: false),
            //        expiry_date = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__registra__899C8A683E8B3806", x => x.registration_info_id);
            //        table.ForeignKey(
            //            name: "FK__registrat__trans__282DF8C2",
            //            column: x => x.transport_unit_id,
            //            principalTable: "transport_unit",
            //            principalColumn: "transport_unit_id");
            //        table.ForeignKey(
            //            name: "FK__registrat__user___2739D489",
            //            column: x => x.user_id,
            //            principalTable: "user",
            //            principalColumn: "user_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "sensor",
            //    columns: table => new
            //    {
            //        sensor_id = table.Column<int>(type: "int", nullable: false),
            //        transport_unit_id = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__ir_trans__29154BAE42A7B68C", x => x.sensor_id);
            //        table.ForeignKey(
            //            name: "FK__ir_transm__bus_i__3B75D760",
            //            column: x => x.transport_unit_id,
            //            principalTable: "transport_unit",
            //            principalColumn: "transport_unit_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ticket_purchase",
            //    columns: table => new
            //    {
            //        ticket_purchase_id = table.Column<int>(type: "int", nullable: false),
            //        user_id = table.Column<int>(type: "int", nullable: true),
            //        bus_id = table.Column<int>(type: "int", nullable: true),
            //        ticket_type_id = table.Column<int>(type: "int", nullable: true),
            //        purchase_time = table.Column<DateTime>(type: "datetime", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__ticket_p__C23802A226ADD058", x => x.ticket_purchase_id);
            //        table.ForeignKey(
            //            name: "FK__ticket_pu__bus_i__5DCAEF64",
            //            column: x => x.bus_id,
            //            principalTable: "transport_unit",
            //            principalColumn: "transport_unit_id");
            //        table.ForeignKey(
            //            name: "FK__ticket_pu__ticke__60A75C0F",
            //            column: x => x.ticket_type_id,
            //            principalTable: "ticket_type",
            //            principalColumn: "ticket_type_id");
            //        table.ForeignKey(
            //            name: "FK__ticket_pu__user___5CD6CB2B",
            //            column: x => x.user_id,
            //            principalTable: "user",
            //            principalColumn: "user_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "timetable",
            //    columns: table => new
            //    {
            //        timetable_id = table.Column<int>(type: "int", nullable: false),
            //        transport_unit_id = table.Column<int>(type: "int", nullable: false),
            //        station_id = table.Column<int>(type: "int", nullable: false),
            //        arrival_time = table.Column<TimeSpan>(type: "time", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__timetabl__26DC9588DF28C0EB", x => x.timetable_id);
            //        table.ForeignKey(
            //            name: "FK__timetable__bus_i__71D1E811",
            //            column: x => x.transport_unit_id,
            //            principalTable: "transport_unit",
            //            principalColumn: "transport_unit_id");
            //        table.ForeignKey(
            //            name: "FK__timetable__stati__72C60C4A",
            //            column: x => x.station_id,
            //            principalTable: "station",
            //            principalColumn: "station_id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "sensor_info",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false),
            //        ir_transmitters_id = table.Column<int>(type: "int", nullable: true),
            //        reading_time = table.Column<DateTime>(type: "datetime", nullable: false),
            //        passenger_count = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__sensor_i__3213E83FCDD8452F", x => x.id);
            //        table.ForeignKey(
            //            name: "FK__sensor_in__ir_tr__02FC7413",
            //            column: x => x.ir_transmitters_id,
            //            principalTable: "sensor",
            //            principalColumn: "sensor_id");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_nfc_tag_transport_unit_id",
            //    table: "nfc_tag",
            //    column: "transport_unit_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_registration_info_transport_unit_id",
            //    table: "registration_info",
            //    column: "transport_unit_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_registration_info_user_id",
            //    table: "registration_info",
            //    column: "user_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__roles__783254B15D4C363F",
            //    table: "role",
            //    column: "role_name",
            //    unique: true,
            //    filter: "[role_name] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_route_station_route_id",
            //    table: "route_station",
            //    column: "route_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_route_station_station_id",
            //    table: "route_station",
            //    column: "station_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_sensor_transport_unit_id",
            //    table: "sensor",
            //    column: "transport_unit_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_sensor_info_ir_transmitters_id",
            //    table: "sensor_info",
            //    column: "ir_transmitters_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ticket_purchase_bus_id",
            //    table: "ticket_purchase",
            //    column: "bus_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ticket_purchase_ticket_type_id",
            //    table: "ticket_purchase",
            //    column: "ticket_type_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ticket_purchase_user_id",
            //    table: "ticket_purchase",
            //    column: "user_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_timetable_station_id",
            //    table: "timetable",
            //    column: "station_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_timetable_transport_unit_id",
            //    table: "timetable",
            //    column: "transport_unit_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_transport_unit_driver_id",
            //    table: "transport_unit",
            //    column: "driver_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_transport_unit_route_id",
            //    table: "transport_unit",
            //    column: "route_id");

            //migrationBuilder.CreateIndex(
            //    name: "IX_user_role_id",
            //    table: "user",
            //    column: "role_id");

            //migrationBuilder.CreateIndex(
            //    name: "UQ__users__F3DBC5725D4A6B6A",
            //    table: "user",
            //    column: "username",
            //    unique: true,
            //    filter: "[username] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "nfc_tag");

            migrationBuilder.DropTable(
                name: "registration_info");

            migrationBuilder.DropTable(
                name: "route_station");

            migrationBuilder.DropTable(
                name: "sensor_info");

            migrationBuilder.DropTable(
                name: "ticket_purchase");

            migrationBuilder.DropTable(
                name: "timetable");

            migrationBuilder.DropTable(
                name: "sensor");

            migrationBuilder.DropTable(
                name: "ticket_type");

            migrationBuilder.DropTable(
                name: "station");

            migrationBuilder.DropTable(
                name: "transport_unit");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "route");

            migrationBuilder.DropTable(
                name: "role");
        }
    }
}
