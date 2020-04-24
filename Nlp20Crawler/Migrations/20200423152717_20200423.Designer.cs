﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nlp20Crawler;
using Nlp20Crawler.ORM.Context;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Nlp20Crawler.Migrations
{
    [DbContext(typeof(PostgreSqlContext))]
    [Migration("20200423152717_20200423")]
    partial class _20200423
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Nlp20Crawler.CrawlerWebsite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Crawled")
                        .HasColumnName("crawled")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("CrawledTimestamp")
                        .HasColumnName("crawled_timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Html")
                        .HasColumnName("html")
                        .HasColumnType("text");

                    b.Property<int>("ResponseCode")
                        .HasColumnName("response_code")
                        .HasColumnType("integer");

                    b.Property<string>("Url")
                        .HasColumnName("url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("crawler_website");
                });

            modelBuilder.Entity("Nlp20Crawler.CsWordNounSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool?>("DeclensionPl1")
                        .HasColumnName("declension_pl1")
                        .HasColumnType("boolean");

                    b.Property<bool?>("DeclensionPl2")
                        .HasColumnName("declension_pl2")
                        .HasColumnType("boolean");

                    b.Property<bool?>("DeclensionPl3")
                        .HasColumnName("declension_pl3")
                        .HasColumnType("boolean");

                    b.Property<bool?>("DeclensionPl4")
                        .HasColumnName("declension_pl4")
                        .HasColumnType("boolean");

                    b.Property<bool?>("DeclensionPl5")
                        .HasColumnName("declension_pl5")
                        .HasColumnType("boolean");

                    b.Property<bool?>("DeclensionPl6")
                        .HasColumnName("declension_pl6")
                        .HasColumnType("boolean");

                    b.Property<bool?>("DeclensionPl7")
                        .HasColumnName("declension_pl7")
                        .HasColumnType("boolean");

                    b.Property<bool?>("DeclensionSg1")
                        .HasColumnName("declension_sg1")
                        .HasColumnType("boolean");

                    b.Property<bool?>("DeclensionSg2")
                        .HasColumnName("declension_sg2")
                        .HasColumnType("boolean");

                    b.Property<bool?>("DeclensionSg3")
                        .HasColumnName("declension_sg3")
                        .HasColumnType("boolean");

                    b.Property<bool?>("DeclensionSg4")
                        .HasColumnName("declension_sg4")
                        .HasColumnType("boolean");

                    b.Property<bool?>("DeclensionSg5")
                        .HasColumnName("declension_sg5")
                        .HasColumnType("boolean");

                    b.Property<bool?>("DeclensionSg6")
                        .HasColumnName("declension_sg6")
                        .HasColumnType("boolean");

                    b.Property<bool?>("DeclensionSg7")
                        .HasColumnName("declension_sg7")
                        .HasColumnType("boolean");

                    b.Property<short?>("Gender")
                        .HasColumnName("gender")
                        .HasColumnType("smallint")
                        .HasComment("0:male,1:female,2:it");

                    b.Property<bool?>("Life")
                        .HasColumnName("life")
                        .HasColumnType("boolean")
                        .HasComment("false: non life, true: life (for male patterns only)");

                    b.Property<int?>("PatternWordId")
                        .HasColumnName("pattern_word_id")
                        .HasColumnType("integer");

                    b.Property<bool>("VerifiedByHuman")
                        .HasColumnName("verified_by_human")
                        .HasColumnType("boolean");

                    b.Property<int?>("VerifiedReliability")
                        .HasColumnName("verified_reliability")
                        .HasColumnType("integer")
                        .HasComment("0: absolutely not verified, 100: verified by professional human");

                    b.Property<int>("WordId")
                        .HasColumnName("word_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("word_declension_id_uindex");

                    b.HasIndex("PatternWordId");

                    b.HasIndex("WordId", "Gender", "DeclensionPl1", "DeclensionPl2", "DeclensionPl3", "DeclensionPl4", "DeclensionPl5", "DeclensionPl6", "DeclensionPl7", "DeclensionSg1", "DeclensionSg2", "DeclensionSg3", "DeclensionSg4", "DeclensionSg5", "DeclensionSg6", "DeclensionSg7", "PatternWordId", "Life")
                        .IsUnique()
                        .HasName("cs_word_noun_specification_ui");

                    b.ToTable("cs_word_noun_specification");
                });

            modelBuilder.Entity("Nlp20Crawler.CsWordUniSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool?>("IsNegative")
                        .HasColumnName("is_negative")
                        .HasColumnType("boolean")
                        .HasComment("true: is negative, false: is positive");

                    b.Property<int>("WordId")
                        .HasColumnName("word_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("cs_word_uni_specification_id_uindex");

                    b.HasIndex("WordId")
                        .IsUnique()
                        .HasName("cs_word_uni_specification_word_id_uindex");

                    b.ToTable("cs_word_uni_specification");
                });

            modelBuilder.Entity("Nlp20Crawler.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Lang")
                        .IsRequired()
                        .HasColumnName("lang")
                        .HasColumnType("character varying(6)")
                        .HasMaxLength(6);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnName("text")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("word_id_uindex");

                    b.HasIndex("Text")
                        .IsUnique()
                        .HasName("word_pk_2");

                    b.HasIndex("Text", "Lang")
                        .IsUnique()
                        .HasName("word_word_lang_uindex");

                    b.ToTable("word");
                });

            modelBuilder.Entity("Nlp20Crawler.CsWordNounSpecification", b =>
                {
                    b.HasOne("Nlp20Crawler.Word", "PatternWord")
                        .WithMany("CsWordNounSpecificationPatternWord")
                        .HasForeignKey("PatternWordId")
                        .HasConstraintName("ix_cs_word_noun_specification_pattern_word_id");

                    b.HasOne("Nlp20Crawler.Word", "Word")
                        .WithMany("CsWordNounSpecificationWord")
                        .HasForeignKey("WordId")
                        .HasConstraintName("ix_cs_word_noun_specification_word_id")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
