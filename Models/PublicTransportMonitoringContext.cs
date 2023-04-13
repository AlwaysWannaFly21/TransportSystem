using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TransportSystem.Models;

public partial class PublicTransportMonitoringContext : DbContext
{
    public PublicTransportMonitoringContext()
    {
    }

    public PublicTransportMonitoringContext(DbContextOptions<PublicTransportMonitoringContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NfcTag> NfcTags { get; set; }

    public virtual DbSet<RegistrationInfo> RegistrationInfos { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Route> Routes { get; set; }

    public virtual DbSet<RouteStation> RouteStations { get; set; }

    public virtual DbSet<Sensor> Sensors { get; set; }

    public virtual DbSet<SensorInfo> SensorInfos { get; set; }

    public virtual DbSet<Station> Stations { get; set; }

    public virtual DbSet<TicketPurchase> TicketPurchases { get; set; }

    public virtual DbSet<TicketType> TicketTypes { get; set; }

    public virtual DbSet<Timetable> Timetables { get; set; }

    public virtual DbSet<TransportUnit> TransportUnits { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=public_transport_monitoring;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NfcTag>(entity =>
        {
            entity.HasKey(e => e.TagId).HasName("PK__nfc_tags__4296A2B6BE5C39A9");

            entity.ToTable("nfc_tag");

            entity.HasIndex(e => e.TransportUnitId, "IX_nfc_tag_transport_unit_id");

            entity.Property(e => e.TagId)
                .ValueGeneratedNever()
                .HasColumnName("tag_id");
            entity.Property(e => e.TransportUnitId).HasColumnName("transport_unit_id");

            entity.HasOne(d => d.TransportUnit).WithMany(p => p.NfcTags)
                .HasForeignKey(d => d.TransportUnitId)
                .HasConstraintName("FK__nfc_tags__bus_id__3E52440B");
        });

        modelBuilder.Entity<RegistrationInfo>(entity =>
        {
            entity.HasKey(e => e.RegistrationInfoId).HasName("PK__registra__899C8A683E8B3806");

            entity.ToTable("registration_info");

            entity.HasIndex(e => e.TransportUnitId, "IX_registration_info_transport_unit_id");

            entity.HasIndex(e => e.UserId, "IX_registration_info_user_id");

            entity.Property(e => e.RegistrationInfoId)
                .ValueGeneratedNever()
                .HasColumnName("registration_info_id");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("expiry_date");
            entity.Property(e => e.ReadingTime)
                .HasColumnType("datetime")
                .HasColumnName("reading_time");
            entity.Property(e => e.TransportUnitId).HasColumnName("transport_unit_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.TransportUnit).WithMany(p => p.RegistrationInfos)
                .HasForeignKey(d => d.TransportUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__registrat__trans__282DF8C2");

            entity.HasOne(d => d.User).WithMany(p => p.RegistrationInfos)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__registrat__user___2739D489");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__roles__760965CC34C89DFD");

            entity.ToTable("role");

            entity.HasIndex(e => e.RoleName, "UQ__roles__783254B15D4C363F")
                .IsUnique()
                .HasFilter("([role_name] IS NOT NULL)");

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("role_id");
            entity.Property(e => e.RoleName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<Route>(entity =>
        {
            entity.HasKey(e => e.RouteId).HasName("PK__route__28F706FEF3067B06");

            entity.ToTable("route");

            entity.Property(e => e.RouteId)
                .ValueGeneratedNever()
                .HasColumnName("route_id");
            entity.Property(e => e.RouteName)
                .HasMaxLength(40)
                .HasColumnName("route_name");
        });

        modelBuilder.Entity<RouteStation>(entity =>
        {
            entity.HasKey(e => e.RouteStationId).HasName("PK__route_st__F8B46055CEAD0E73");

            entity.ToTable("route_station");

            entity.HasIndex(e => e.RouteId, "IX_route_station_route_id");

            entity.HasIndex(e => e.StationId, "IX_route_station_station_id");

            entity.Property(e => e.RouteStationId)
                .ValueGeneratedNever()
                .HasColumnName("route_station_id");
            entity.Property(e => e.RouteId).HasColumnName("route_id");
            entity.Property(e => e.StationId).HasColumnName("station_id");

            entity.HasOne(d => d.Route).WithMany(p => p.RouteStations)
                .HasForeignKey(d => d.RouteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__route_sta__route__3E1D39E1");

            entity.HasOne(d => d.Station).WithMany(p => p.RouteStations)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__route_sta__stati__3F115E1A");
        });

        modelBuilder.Entity<Sensor>(entity =>
        {
            entity.HasKey(e => e.SensorId).HasName("PK__ir_trans__29154BAE42A7B68C");

            entity.ToTable("sensor");

            entity.HasIndex(e => e.TransportUnitId, "IX_sensor_transport_unit_id");

            entity.Property(e => e.SensorId)
                .ValueGeneratedNever()
                .HasColumnName("sensor_id");
            entity.Property(e => e.TransportUnitId).HasColumnName("transport_unit_id");

            entity.HasOne(d => d.TransportUnit).WithMany(p => p.Sensors)
                .HasForeignKey(d => d.TransportUnitId)
                .HasConstraintName("FK__ir_transm__bus_i__3B75D760");
        });

        modelBuilder.Entity<SensorInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__sensor_i__3213E83FCDD8452F");

            entity.ToTable("sensor_info");

            entity.HasIndex(e => e.IrTransmittersId, "IX_sensor_info_ir_transmitters_id");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IrTransmittersId).HasColumnName("ir_transmitters_id");
            entity.Property(e => e.PassengerCount).HasColumnName("passenger_count");
            entity.Property(e => e.ReadingTime)
                .HasColumnType("datetime")
                .HasColumnName("reading_time");

            entity.HasOne(d => d.IrTransmitters).WithMany(p => p.SensorInfos)
                .HasForeignKey(d => d.IrTransmittersId)
                .HasConstraintName("FK__sensor_in__ir_tr__02FC7413");
        });

        modelBuilder.Entity<Station>(entity =>
        {
            entity.HasKey(e => e.StationId).HasName("PK__stations__44B370E982BDC572");

            entity.ToTable("station");

            entity.Property(e => e.StationId)
                .ValueGeneratedNever()
                .HasColumnName("station_id");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.StationName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("station_name");
        });

        modelBuilder.Entity<TicketPurchase>(entity =>
        {
            entity.HasKey(e => e.TicketPurchaseId).HasName("PK__ticket_p__C23802A226ADD058");

            entity.ToTable("ticket_purchase");

            entity.HasIndex(e => e.BusId, "IX_ticket_purchase_bus_id");

            entity.HasIndex(e => e.TicketTypeId, "IX_ticket_purchase_ticket_type_id");

            entity.HasIndex(e => e.UserId, "IX_ticket_purchase_user_id");

            entity.Property(e => e.TicketPurchaseId)
                .ValueGeneratedNever()
                .HasColumnName("ticket_purchase_id");
            entity.Property(e => e.BusId).HasColumnName("bus_id");
            entity.Property(e => e.PurchaseTime)
                .HasColumnType("datetime")
                .HasColumnName("purchase_time");
            entity.Property(e => e.TicketTypeId).HasColumnName("ticket_type_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Bus).WithMany(p => p.TicketPurchases)
                .HasForeignKey(d => d.BusId)
                .HasConstraintName("FK__ticket_pu__bus_i__5DCAEF64");

            entity.HasOne(d => d.TicketType).WithMany(p => p.TicketPurchases)
                .HasForeignKey(d => d.TicketTypeId)
                .HasConstraintName("FK__ticket_pu__ticke__60A75C0F");

            entity.HasOne(d => d.User).WithMany(p => p.TicketPurchases)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__ticket_pu__user___5CD6CB2B");
        });

        modelBuilder.Entity<TicketType>(entity =>
        {
            entity.HasKey(e => e.TicketTypeId).HasName("PK__ticket_t__9531B7D17C0267C7");

            entity.ToTable("ticket_type");

            entity.Property(e => e.TicketTypeId)
                .ValueGeneratedNever()
                .HasColumnName("ticket_type_id");
            entity.Property(e => e.TicketPrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ticket_price");
            entity.Property(e => e.TicketTypeName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ticket_type_name");
        });

        modelBuilder.Entity<Timetable>(entity =>
        {
            entity.HasKey(e => e.TimetableId).HasName("PK__timetabl__26DC9588DF28C0EB");

            entity.ToTable("timetable");

            entity.HasIndex(e => e.StationId, "IX_timetable_station_id");

            entity.HasIndex(e => e.TransportUnitId, "IX_timetable_transport_unit_id");

            entity.Property(e => e.TimetableId)
                .ValueGeneratedNever()
                .HasColumnName("timetable_id");
            entity.Property(e => e.ArrivalTime).HasColumnName("arrival_time");
            entity.Property(e => e.StationId).HasColumnName("station_id");
            entity.Property(e => e.TransportUnitId).HasColumnName("transport_unit_id");

            entity.HasOne(d => d.Station).WithMany(p => p.Timetables)
                .HasForeignKey(d => d.StationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__timetable__stati__72C60C4A");

            entity.HasOne(d => d.TransportUnit).WithMany(p => p.Timetables)
                .HasForeignKey(d => d.TransportUnitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__timetable__bus_i__71D1E811");
        });

        modelBuilder.Entity<TransportUnit>(entity =>
        {
            entity.HasKey(e => e.TransportUnitId).HasName("PK__buses__6ACEF8ED25B1A061");

            entity.ToTable("transport_unit");

            entity.HasIndex(e => e.DriverId, "IX_transport_unit_driver_id");

            entity.HasIndex(e => e.RouteId, "IX_transport_unit_route_id");

            entity.Property(e => e.TransportUnitId)
                .ValueGeneratedNever()
                .HasColumnName("transport_unit_id");
            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.DriverId).HasColumnName("driver_id");
            entity.Property(e => e.RouteId).HasColumnName("route_id");

            entity.HasOne(d => d.Driver).WithMany(p => p.TransportUnits)
                .HasForeignKey(d => d.DriverId)
                .HasConstraintName("FK__buses__user_id__4F7CD00D");

            entity.HasOne(d => d.Route).WithMany(p => p.TransportUnits)
                .HasForeignKey(d => d.RouteId)
                .HasConstraintName("FK__transport__route__4D5F7D71");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__users__B9BE370F09AB4DB9");

            entity.ToTable("user");

            entity.HasIndex(e => e.RoleId, "IX_user_role_id");

            entity.HasIndex(e => e.Username, "UQ__users__F3DBC5725D4A6B6A")
                .IsUnique()
                .HasFilter("([username] IS NOT NULL)");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.PasswordHash).HasColumnName("password_hash");
            entity.Property(e => e.PasswordSalt).HasColumnName("password_salt");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__users__role_id__4E88ABD4");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
