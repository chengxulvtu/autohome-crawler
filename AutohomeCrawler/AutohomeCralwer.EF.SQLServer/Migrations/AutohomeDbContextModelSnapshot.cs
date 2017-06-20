using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AutohomeCralwer.EF.SQLServer;

namespace AutohomeCralwer.EF.SQLServer.Migrations
{
    [DbContext(typeof(AutohomeDbContext))]
    partial class AutohomeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutohomeCralwer.EF.SQLServer.Entities.Brand", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("FirstLetter")
                        .HasMaxLength(1);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("PinYin")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });
        }
    }
}
