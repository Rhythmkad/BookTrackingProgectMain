﻿// <auto-generated />
using BookTrackingProgectMain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookTrackingProgectMain.Migrations
{
    [DbContext(typeof(BookTrackingProgectMainContext))]
    partial class BookTrackingProgectMainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookTrackingProgectMain.Models.Books", b =>
                {
                    b.Property<string>("ISBM")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookAuther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.HasKey("ISBM");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookTrackingProgectMain.Models.Categorys", b =>
                {
                    b.Property<string>("NameToken")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BookDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("NameToken");

                    b.ToTable("Categorys");
                });

            modelBuilder.Entity("BookTrackingProgectMain.Models.CategorysType", b =>
                {
                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Type");

                    b.ToTable("CategorysType");
                });
#pragma warning restore 612, 618
        }
    }
}
