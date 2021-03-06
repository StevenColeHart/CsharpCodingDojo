﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using beltexam.Models;

namespace beltexam.Migrations
{
    [DbContext(typeof(BeltExamContext))]
    partial class BeltExamContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("beltexam.Models.Bid", b =>
                {
                    b.Property<int>("BidId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProductId");

                    b.Property<int?>("UserId");

                    b.Property<int>("highestbid");

                    b.HasKey("BidId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("beltexam.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("created_at");

                    b.Property<int?>("creatorUserId");

                    b.Property<string>("description")
                        .IsRequired();

                    b.Property<DateTime?>("ending")
                        .IsRequired();

                    b.Property<string>("name")
                        .IsRequired();

                    b.Property<int>("startingbid");

                    b.HasKey("ProductId");

                    b.HasIndex("creatorUserId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("beltexam.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("confirm_password");

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("firstname")
                        .IsRequired();

                    b.Property<string>("lastname")
                        .IsRequired();

                    b.Property<string>("password")
                        .IsRequired();

                    b.Property<string>("username")
                        .IsRequired();

                    b.Property<int>("wallet");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("beltexam.Models.Bid", b =>
                {
                    b.HasOne("beltexam.Models.Product", "Product")
                        .WithMany("bid")
                        .HasForeignKey("ProductId");

                    b.HasOne("beltexam.Models.User", "User")
                        .WithMany("bids")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("beltexam.Models.Product", b =>
                {
                    b.HasOne("beltexam.Models.User", "creator")
                        .WithMany("products")
                        .HasForeignKey("creatorUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
