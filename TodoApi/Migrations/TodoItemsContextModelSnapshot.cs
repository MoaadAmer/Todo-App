﻿// <auto-generated />
using System;
using Controller_based_APIs.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Controller_based_APIs.Migrations
{
    [DbContext(typeof(TodoItemsContext))]
    partial class TodoItemsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.13");

            modelBuilder.Entity("Controller_based_APIs.Entities.TodoItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DueDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("StartDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DueDate = new DateTime(2025, 3, 11, 23, 24, 12, 39, DateTimeKind.Local).AddTicks(8493),
                            IsComplete = false,
                            Name = "Item 1",
                            StartDate = new DateTime(2025, 3, 10, 23, 24, 12, 39, DateTimeKind.Local).AddTicks(8299)
                        },
                        new
                        {
                            Id = 2L,
                            DueDate = new DateTime(2025, 3, 12, 23, 24, 12, 39, DateTimeKind.Local).AddTicks(8505),
                            IsComplete = false,
                            Name = "Item 2",
                            StartDate = new DateTime(2025, 3, 11, 23, 24, 12, 39, DateTimeKind.Local).AddTicks(8501)
                        },
                        new
                        {
                            Id = 3L,
                            DueDate = new DateTime(2025, 3, 13, 23, 24, 12, 39, DateTimeKind.Local).AddTicks(8515),
                            IsComplete = false,
                            Name = "Item 3",
                            StartDate = new DateTime(2025, 3, 12, 23, 24, 12, 39, DateTimeKind.Local).AddTicks(8511)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
