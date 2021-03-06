﻿// <auto-generated />
using EmpleadoController.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmpleadoController.Migrations
{
    [DbContext(typeof(EmpleadoContext))]
    partial class EmpleadoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Empleado.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<string>("Area");

                    b.Property<string>("Nombre");

                    b.Property<string>("NumeroDeDocumento");

                    b.Property<string>("SubArea");

                    b.Property<string>("TipoDeDocumento");

                    b.HasKey("Id");

                    b.ToTable("Empleado");
                });
#pragma warning restore 612, 618
        }
    }
}
