﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using deovrScraper.DB;

#nullable disable

namespace deovrScraper.DB.Migrations
{
    [DbContext(typeof(DeovrScraperContext))]
    [Migration("20241010194649_Settings")]
    partial class Settings
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("DbStarDbVideoItem", b =>
                {
                    b.Property<long>("StarsId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("VideosId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StarsId", "VideosId");

                    b.HasIndex("VideosId");

                    b.ToTable("DbStarDbVideoItem");
                });

            modelBuilder.Entity("DbTagDbVideoItem", b =>
                {
                    b.Property<long>("TagsId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("VideosId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TagsId", "VideosId");

                    b.HasIndex("VideosId");

                    b.ToTable("DbTagDbVideoItem");
                });

            modelBuilder.Entity("deovrScraper.DB.Models.DbDeoVrTab", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ActressBlacklist")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ActressWhitelist")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TagBlacklist")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TagWhitelist")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VideoBlacklist")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VideoWhitelist")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tabs");
                });

            modelBuilder.Entity("deovrScraper.DB.Models.DbSetting", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Key");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("deovrScraper.DB.Models.DbStar", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Stars");
                });

            modelBuilder.Entity("deovrScraper.DB.Models.DbTag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("deovrScraper.DB.Models.DbVideoItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DataVp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Disliked")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Favorite")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsVr")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Liked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Link")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ParsedDetails")
                        .HasColumnType("INTEGER");

                    b.Property<long>("PlayCount")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("PlayDurationEst")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quality")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Rating")
                        .HasColumnType("REAL");

                    b.Property<string>("Site")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SiteVideoId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Uploader")
                        .HasColumnType("TEXT");

                    b.Property<long?>("Views")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Site", "SiteVideoId")
                        .IsUnique();

                    b.ToTable("VideoItems");
                });

            modelBuilder.Entity("DbStarDbVideoItem", b =>
                {
                    b.HasOne("deovrScraper.DB.Models.DbStar", null)
                        .WithMany()
                        .HasForeignKey("StarsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("deovrScraper.DB.Models.DbVideoItem", null)
                        .WithMany()
                        .HasForeignKey("VideosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DbTagDbVideoItem", b =>
                {
                    b.HasOne("deovrScraper.DB.Models.DbTag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("deovrScraper.DB.Models.DbVideoItem", null)
                        .WithMany()
                        .HasForeignKey("VideosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
