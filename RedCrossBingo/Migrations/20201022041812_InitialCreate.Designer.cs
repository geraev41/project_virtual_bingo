﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RedCrossBingo.Models;

namespace RedCrossBingo.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20201022041812_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("RedCrossBingo.Models.BingoCardNumbers", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("BingoCardsId")
                        .HasColumnName("bingo_cards_id")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsSelected")
                        .HasColumnName("is_selected")
                        .HasColumnType("boolean");

                    b.Property<long>("number")
                        .HasColumnName("number")
                        .HasColumnType("bigint");

                    b.HasKey("Id")
                        .HasName("pk_bingo_card_numbers");

                    b.HasIndex("BingoCardsId")
                        .HasName("ix_bingo_card_numbers_bingo_cards_id");

                    b.ToTable("bingo_card_numbers");
                });

            modelBuilder.Entity("RedCrossBingo.Models.BingoCards", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("RoomsId")
                        .HasColumnName("rooms_id")
                        .HasColumnType("bigint");

                    b.HasKey("Id")
                        .HasName("pk_bingo_cards");

                    b.HasIndex("RoomsId")
                        .HasName("ix_bingo_cards_rooms_id");

                    b.ToTable("bingo_cards");
                });

            modelBuilder.Entity("RedCrossBingo.Models.BingoNumbers", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("IsChosen")
                        .HasColumnName("is_chosen")
                        .HasColumnType("boolean");

                    b.Property<long>("RoomsId")
                        .HasColumnName("rooms_id")
                        .HasColumnType("bigint");

                    b.Property<long>("number")
                        .HasColumnName("number")
                        .HasColumnType("bigint");

                    b.HasKey("Id")
                        .HasName("pk_bingo_numbers");

                    b.HasIndex("RoomsId")
                        .HasName("ix_bingo_numbers_rooms_id");

                    b.ToTable("bingo_numbers");
                });

            modelBuilder.Entity("RedCrossBingo.Models.Rooms", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("name")
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .HasColumnName("url")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_rooms");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("RedCrossBingo.Models.Users", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnName("password")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users");
                });

            modelBuilder.Entity("RedCrossBingo.Models.BingoCardNumbers", b =>
                {
                    b.HasOne("RedCrossBingo.Models.BingoCards", "BingoCards")
                        .WithMany("BingoCardNumbers")
                        .HasForeignKey("BingoCardsId")
                        .HasConstraintName("fk_bingo_card_numbers_bingo_cards_bingo_cards_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RedCrossBingo.Models.BingoCards", b =>
                {
                    b.HasOne("RedCrossBingo.Models.Rooms", "Rooms")
                        .WithMany("BingoCards")
                        .HasForeignKey("RoomsId")
                        .HasConstraintName("fk_bingo_cards_rooms_rooms_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RedCrossBingo.Models.BingoNumbers", b =>
                {
                    b.HasOne("RedCrossBingo.Models.Rooms", "Rooms")
                        .WithMany("BingoNumbers")
                        .HasForeignKey("RoomsId")
                        .HasConstraintName("fk_bingo_numbers_rooms_rooms_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
