﻿// <auto-generated />
using Letsgo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LetsGo.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240109135731_thirdmigration")]
    partial class thirdmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Letsgo.Model.Lets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("lets_descricao");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("lets_genre");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("lets_name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("lets_preco");

                    b.Property<string>("letsURL")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("lets_url");

                    b.HasKey("Id");

                    b.ToTable("viagens");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "",
                            Genre = "RPG",
                            Name = "The Witcher 3",
                            Price = 59.99m,
                            letsURL = "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "",
                            Genre = "RPG",
                            Name = "The Witcher 2",
                            Price = 19.99m,
                            letsURL = "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "",
                            Genre = "RPG",
                            Name = "The Witcher",
                            Price = 9.99m,
                            letsURL = "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "",
                            Genre = "RPG",
                            Name = "Cyberpunk 2077",
                            Price = 59.99m,
                            letsURL = "https://images.gog-statics.com/d7178b692f8a605a6f3f67f27eadecc8e11282f5005c145e402d47f343dc2925_product_card_v2_logo_480x285.png"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
