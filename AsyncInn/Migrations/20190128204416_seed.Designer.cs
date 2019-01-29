﻿// <auto-generated />
using AsyncInn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsyncInn.Migrations
{
    [DbContext(typeof(HotelMgmtDBContext))]
    [Migration("20190128204416_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AsyncInn.Models.Amenities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("AmenitiesTable");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Balcony"
                        },
                        new
                        {
                            ID = 2,
                            Name = "In room kitchen"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Mini bar"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Jet tub"
                        },
                        new
                        {
                            ID = 5,
                            Name = "High speed internet"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("HotelTable");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "123 Fake Street Seattle, WA 98121",
                            Name = "J&J Hotel",
                            PhoneNumber = "206 123 4567"
                        },
                        new
                        {
                            ID = 2,
                            Address = "456 Fake Street Seattle, WA 98155",
                            Name = "JK Hotel",
                            PhoneNumber = "206 987 6543"
                        },
                        new
                        {
                            ID = 3,
                            Address = "789 Fake Street Seattle, WA 98040",
                            Name = "Seattle Hide Away Hotel",
                            PhoneNumber = "425 999 9999"
                        },
                        new
                        {
                            ID = 4,
                            Address = "123 Fake Lane Seattle, WA 98121",
                            Name = "Up & Up Hotel",
                            PhoneNumber = "206 112 2334"
                        },
                        new
                        {
                            ID = 5,
                            Address = "456 Fake Place Seattle, WA 98133",
                            Name = "No Wheres Land Hotel",
                            PhoneNumber = "206 998 7655"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.Property<int>("HotelID");

                    b.Property<int>("RoomNumber");

                    b.Property<bool>("PetFriendly");

                    b.Property<double>("Rate");

                    b.Property<int>("RoomID");

                    b.HasKey("HotelID", "RoomNumber");

                    b.HasIndex("RoomID");

                    b.ToTable("HotelRoomTable");
                });

            modelBuilder.Entity("AsyncInn.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Layout");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("RoomTable");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Layout = 0,
                            Name = "Sleepless in Seattle"
                        },
                        new
                        {
                            ID = 2,
                            Layout = 2,
                            Name = "Stay in Bed"
                        },
                        new
                        {
                            ID = 3,
                            Layout = 1,
                            Name = "Gogo"
                        },
                        new
                        {
                            ID = 4,
                            Layout = 2,
                            Name = "HoneyMoon"
                        },
                        new
                        {
                            ID = 5,
                            Layout = 2,
                            Name = "Red Solo Cup"
                        },
                        new
                        {
                            ID = 6,
                            Layout = 0,
                            Name = "Blue Solo Hen"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.Property<int>("AmenitiesID");

                    b.Property<int>("RoomID");

                    b.HasKey("AmenitiesID", "RoomID");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomAmenitiesTable");
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.HasOne("AsyncInn.Models.Hotel", "Hotel")
                        .WithMany()
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsyncInn.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.HasOne("AsyncInn.Models.Amenities", "Amenities")
                        .WithMany()
                        .HasForeignKey("AmenitiesID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsyncInn.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
