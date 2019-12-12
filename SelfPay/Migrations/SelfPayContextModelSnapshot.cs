﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SelfPay.Data;

namespace SelfPay.Migrations
{
    [DbContext(typeof(SelfPayContext))]
    partial class SelfPayContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SelfPay.Models.Produto", b =>
                {
                    b.Property<int>("produto_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("produto_ativo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("produto_desc")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("produto_nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("produto_preco")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("produto_precoPromo")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("produto_id");

                    b.ToTable("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
