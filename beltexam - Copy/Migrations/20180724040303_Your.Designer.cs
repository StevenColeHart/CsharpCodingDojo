﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using beltexam.Models;

namespace beltexam.Migrations
{
    [DbContext(typeof(BeltExamContext))]
    [Migration("20180724040303_Your")]
    partial class Your
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("beltexam.Models.User", b =>
                {
                    b.Property<int>("idUser")
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

                    b.HasKey("idUser");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
