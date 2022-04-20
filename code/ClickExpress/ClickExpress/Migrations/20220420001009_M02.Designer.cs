﻿// <auto-generated />
using System;
using ClickExpress.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClickExpress.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220420001009_M02")]
    partial class M02
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClickExpress.Models.Usuario", b =>
                {
                    b.Property<int>("Id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Num_endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cpf_cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_usuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ClickExpress.Models.Cliente", b =>
                {
                    b.HasBaseType("ClickExpress.Models.Usuario");

                    b.Property<string>("Desc_pedido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Dt_pedido")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_pedido")
                        .HasColumnType("int");

                    b.Property<int>("Qtde_pedidos")
                        .HasColumnType("int");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ClickExpress.Models.Prestador", b =>
                {
                    b.HasBaseType("ClickExpress.Models.Usuario");

                    b.Property<DateTime>("Dt_entrega")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id_entrega")
                        .HasColumnType("int");

                    b.Property<int>("Qtde_entregas")
                        .HasColumnType("int");

                    b.Property<string>("Veiculo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Prestadores");
                });

            modelBuilder.Entity("ClickExpress.Models.Cliente", b =>
                {
                    b.HasOne("ClickExpress.Models.Usuario", null)
                        .WithOne()
                        .HasForeignKey("ClickExpress.Models.Cliente", "Id_usuario")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClickExpress.Models.Prestador", b =>
                {
                    b.HasOne("ClickExpress.Models.Usuario", null)
                        .WithOne()
                        .HasForeignKey("ClickExpress.Models.Prestador", "Id_usuario")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
