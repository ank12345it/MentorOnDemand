﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserMentor.Context;

namespace UserMentor.Migrations
{
    [DbContext(typeof(UserMentorContext))]
    [Migration("20191114101853_UserMig_1")]
    partial class UserMig_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UserMentor.Models.Mentor", b =>
                {
                    b.Property<long>("Mentor_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Mentor_Availability")
                        .HasColumnType("bit");

                    b.Property<string>("Mentor_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_Exp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_From_TimeSlot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mentor_Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("Mentor_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_PrimarySkill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mentor_To_TimeSlot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Mentor_active")
                        .HasColumnType("bit");

                    b.HasKey("Mentor_Id");

                    b.ToTable("Mentor");
                });

            modelBuilder.Entity("UserMentor.Models.User", b =>
                {
                    b.Property<long>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("User_Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("User_Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("User_active")
                        .HasColumnType("bit");

                    b.HasKey("User_Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
