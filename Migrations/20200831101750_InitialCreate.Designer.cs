﻿// <auto-generated />
using System;
using CoreWebAPIApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CoreWebAPIApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200831101750_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CoreWebAPIApp.API.Models.DBLoan", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<float>("LoanSize")
                        .HasColumnType("real");

                    b.Property<DateTime>("RepaymentTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ID");

                    b.ToTable("loans");
                });
#pragma warning restore 612, 618
        }
    }
}
