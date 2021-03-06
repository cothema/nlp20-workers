﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nlp20Crawler.ORM.Context;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Nlp20Crawler.Migrations
{
    [DbContext(typeof(PostgreSqlContext))]
    [Migration("20200424142908_20200424_4")]
    partial class _20200424_4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Nlp20Crawler.ORM.Entities.CrawlerWebsite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Crawled")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("crawled")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("CrawledTimestamp")
                        .HasColumnName("crawled_timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Html")
                        .HasColumnName("html")
                        .HasColumnType("text");

                    b.Property<int?>("ResponseCode")
                        .HasColumnName("response_code")
                        .HasColumnType("integer");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnName("url")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_crawler_websites");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("ix_crawler_websites_id");

                    b.ToTable("crawler_websites");
                });

            modelBuilder.Entity("Nlp20Crawler.ORM.Entities.CsWordNounSpecification", b =>
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

                    b.HasKey("Id")
                        .HasName("pk_cs_word_noun_specifications");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("ix_cs_word_noun_specifications_id");

                    b.HasIndex("PatternWordId")
                        .HasName("ix_cs_word_noun_specifications_pattern_word_id");

                    b.HasIndex("WordId", "Gender", "DeclensionPl1", "DeclensionPl2", "DeclensionPl3", "DeclensionPl4", "DeclensionPl5", "DeclensionPl6", "DeclensionPl7", "DeclensionSg1", "DeclensionSg2", "DeclensionSg3", "DeclensionSg4", "DeclensionSg5", "DeclensionSg6", "DeclensionSg7", "PatternWordId", "Life")
                        .IsUnique()
                        .HasName("ix_cs_word_noun_specifications_word_id_gender_declension_pl1_d");

                    b.ToTable("cs_word_noun_specifications");
                });

            modelBuilder.Entity("Nlp20Crawler.ORM.Entities.CsWordUniSpecification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool?>("IsNegative")
                        .HasColumnName("is_negative")
                        .HasColumnType("boolean")
                        .HasComment("null: N/A / true: is negative / false: is positive");

                    b.Property<int>("LemmaWordId")
                        .HasColumnName("lemma_word_id")
                        .HasColumnType("integer")
                        .HasComment("Word in basic representative form used for dictionaries.");

                    b.Property<int>("VerbalType")
                        .HasColumnName("verbal_type")
                        .HasColumnType("integer")
                        .HasComment("0: interjection, 1 - 9: noun - adverb")
                        .HasMaxLength(1);

                    b.Property<int>("WordId")
                        .HasColumnName("word_id")
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("pk_cs_word_uni_specifications");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("ix_cs_word_uni_specifications_id");

                    b.HasIndex("LemmaWordId")
                        .HasName("ix_cs_word_uni_specifications_lemma_word_id");

                    b.HasIndex("WordId")
                        .IsUnique()
                        .HasName("ix_cs_word_uni_specifications_word_id");

                    b.ToTable("cs_word_uni_specifications");
                });

            modelBuilder.Entity("Nlp20Crawler.ORM.Entities.Meaning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Note")
                        .HasColumnName("note")
                        .HasColumnType("text");

                    b.Property<string>("WikipediaUrl")
                        .HasColumnName("wikipedia_url")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_meanings");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("ix_meanings_id");

                    b.ToTable("meanings");
                });

            modelBuilder.Entity("Nlp20Crawler.ORM.Entities.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("CrawlerMeaningCheckProposed")
                        .HasColumnName("crawler_meaning_check_proposed")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("CrawlerMeaningCheckProposedTime")
                        .HasColumnName("crawler_meaning_check_proposed_time")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Lang")
                        .IsRequired()
                        .HasColumnName("lang")
                        .HasColumnType("character varying(6)")
                        .HasMaxLength(6);

                    b.Property<int>("OccurenceCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("occurence_count")
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<int>("Probability")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("probability")
                        .HasColumnType("integer")
                        .HasComment("-100 - +100 (-100 means not possible, 100 means 100% probability)")
                        .HasMaxLength(3)
                        .HasDefaultValue(0);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnName("text")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("pk_words");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("ix_words_id");

                    b.HasIndex("Text", "Lang")
                        .IsUnique()
                        .HasName("ix_words_text_lang");

                    b.ToTable("words");
                });

            modelBuilder.Entity("Nlp20Crawler.ORM.Entities.WordMeaning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("MeaningId")
                        .HasColumnName("meaning_id")
                        .HasColumnType("integer");

                    b.Property<string>("Note")
                        .HasColumnName("note")
                        .HasColumnType("text");

                    b.Property<int>("WordId")
                        .HasColumnName("word_id")
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("pk_word_meaning");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("ix_word_meaning_id");

                    b.HasIndex("MeaningId")
                        .HasName("ix_word_meaning_meaning_id");

                    b.HasIndex("WordId")
                        .HasName("ix_word_meaning_word_id");

                    b.ToTable("word_meaning");
                });

            modelBuilder.Entity("Nlp20Crawler.ORM.Entities.CsWordNounSpecification", b =>
                {
                    b.HasOne("Nlp20Crawler.ORM.Entities.Word", "PatternWord")
                        .WithMany("CsWordsNounSpecificationPatternWord")
                        .HasForeignKey("PatternWordId")
                        .HasConstraintName("fk_cs_word_noun_specifications_words_pattern_word_id");

                    b.HasOne("Nlp20Crawler.ORM.Entities.Word", "Word")
                        .WithMany("CsWordsNounSpecificationWord")
                        .HasForeignKey("WordId")
                        .HasConstraintName("fk_cs_word_noun_specifications_words_word_id")
                        .IsRequired();
                });

            modelBuilder.Entity("Nlp20Crawler.ORM.Entities.CsWordUniSpecification", b =>
                {
                    b.HasOne("Nlp20Crawler.ORM.Entities.Word", "LemmaWord")
                        .WithMany("CsWordLexemes")
                        .HasForeignKey("LemmaWordId")
                        .HasConstraintName("fk_cs_word_uni_specifications_words_lemma_word_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nlp20Crawler.ORM.Entities.Word", "Word")
                        .WithMany("CsWordsUniSpecificationWord")
                        .HasForeignKey("WordId")
                        .HasConstraintName("fk_cs_word_uni_specifications_words_word_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Nlp20Crawler.ORM.Entities.WordMeaning", b =>
                {
                    b.HasOne("Nlp20Crawler.ORM.Entities.Meaning", "Meaning")
                        .WithMany("WordMeaning")
                        .HasForeignKey("MeaningId")
                        .HasConstraintName("fk_word_meaning_meanings_meaning_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Nlp20Crawler.ORM.Entities.Word", "Word")
                        .WithMany("WordMeaning")
                        .HasForeignKey("WordId")
                        .HasConstraintName("fk_word_meaning_words_word_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
