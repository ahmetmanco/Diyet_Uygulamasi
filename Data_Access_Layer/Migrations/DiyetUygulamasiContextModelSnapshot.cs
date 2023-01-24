﻿// <auto-generated />
using System;
using Data_Access_Layer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(DiyetUygulamasiContext))]
    partial class DiyetUygulamasiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler", (string)null);
                });

            modelBuilder.Entity("Entity.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("Eposta")
                        .IsUnique();

                    b.ToTable("Kullanicilar", (string)null);
                });

            modelBuilder.Entity("Entity.Ogun", b =>
                {
                    b.Property<int>("OgunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgunId"));

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("OgunNo")
                        .HasColumnType("int");

                    b.Property<int>("OgunTipi")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("date");

                    b.HasKey("OgunId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Ogunler", (string)null);
                });

            modelBuilder.Entity("Entity.Yemek", b =>
                {
                    b.Property<int>("YemekId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YemekId"));

                    b.Property<string>("Fotograf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Kalori")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("YemekAdi")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("YemekId");

                    b.HasIndex("KategoriId");

                    b.ToTable("Yemekler", (string)null);
                });

            modelBuilder.Entity("Entity.YemekOgun", b =>
                {
                    b.Property<int>("YemekOgunId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YemekOgunId"));

                    b.Property<int>("OgunId")
                        .HasColumnType("int");

                    b.Property<int>("YemekId")
                        .HasColumnType("int");

                    b.Property<decimal>("Porsiyon")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("YemekOgunId", "OgunId", "YemekId");

                    b.HasIndex("OgunId");

                    b.HasIndex("YemekId");

                    b.ToTable("YemekOgun");
                });

            modelBuilder.Entity("Entity.Ogun", b =>
                {
                    b.HasOne("Entity.Kullanici", "Kullanici")
                        .WithMany("Ogunler")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("Entity.Yemek", b =>
                {
                    b.HasOne("Entity.Kategori", "Kategori")
                        .WithMany("Yemekler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("Entity.YemekOgun", b =>
                {
                    b.HasOne("Entity.Ogun", "Ogun")
                        .WithMany("Yemek")
                        .HasForeignKey("OgunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Yemek", "Yemek")
                        .WithMany("Ogun")
                        .HasForeignKey("YemekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogun");

                    b.Navigation("Yemek");
                });

            modelBuilder.Entity("Entity.Kategori", b =>
                {
                    b.Navigation("Yemekler");
                });

            modelBuilder.Entity("Entity.Kullanici", b =>
                {
                    b.Navigation("Ogunler");
                });

            modelBuilder.Entity("Entity.Ogun", b =>
                {
                    b.Navigation("Yemek");
                });

            modelBuilder.Entity("Entity.Yemek", b =>
                {
                    b.Navigation("Ogun");
                });
#pragma warning restore 612, 618
        }
    }
}