﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _03_SecondHomeWorkViewModel.Data;

#nullable disable

namespace _03_SecondHomeWorkViewModel.Migrations
{
    [DbContext(typeof(MercedesDbContext))]
    partial class MercedesDbContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_03_SecondHomeWorkViewModel.Entities.BrandOfCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BrandOfCars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mercedes-Benz"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Mercedes-AMG"
                        });
                });

            modelBuilder.Entity("_03_SecondHomeWorkViewModel.Entities.Mercedes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandOfCarId")
                        .HasColumnType("int");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("HorsePower")
                        .HasColumnType("int");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<double>("Volume")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandOfCarId");

                    b.ToTable("Mercedes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandOfCarId = 1,
                            Class = "E-Class",
                            Discount = 2,
                            HorsePower = 375,
                            ImgUrl = "https://images.netdirector.co.uk/gforces-auto/image/upload/w_548,h_365,q_auto,c_fill,f_auto,fl_lossy/auto-client/5d18acbf1848174117e1b0223235a361/e_220_d_4matic.png",
                            Model = "E450 4MATIC",
                            Price = 3735256,
                            Volume = 3.0,
                            Year = 2024
                        },
                        new
                        {
                            Id = 2,
                            BrandOfCarId = 1,
                            Class = "E-Class",
                            Discount = 5,
                            HorsePower = 194,
                            ImgUrl = "https://images.netdirector.co.uk/gforces-auto/image/upload/w_548,h_365,q_auto,c_fill,f_auto,fl_lossy/auto-client/acfe7552173b3f6c863cee630a2345a0/e_220_d.png",
                            Model = "E 220 d",
                            Price = 2823744,
                            Volume = 2.0,
                            Year = 2024
                        },
                        new
                        {
                            Id = 3,
                            BrandOfCarId = 1,
                            Class = "A-Class",
                            Discount = 2,
                            HorsePower = 136,
                            ImgUrl = "https://images.netdirector.co.uk/gforces-auto/image/upload/w_548,h_365,q_auto,c_fill,f_auto,fl_lossy/auto-client/aae4042503cc00d78b7772f9c12f7271/a180.png",
                            Model = "A 180",
                            Price = 1998166,
                            Volume = 1.95,
                            Year = 2024
                        },
                        new
                        {
                            Id = 4,
                            BrandOfCarId = 2,
                            Class = "A-Class",
                            Discount = 0,
                            HorsePower = 306,
                            ImgUrl = "https://images.netdirector.co.uk/gforces-auto/image/upload/w_548,h_365,q_auto,c_fill,f_auto,fl_lossy/auto-client/3172c0ee5ae878080765fbc455e54e6e/a35.png",
                            Model = "A 35 AMG 4MATIC",
                            Price = 2794320,
                            Volume = 2.0,
                            Year = 2024
                        },
                        new
                        {
                            Id = 5,
                            BrandOfCarId = 1,
                            Class = "C-Class",
                            Discount = 15,
                            HorsePower = 168,
                            ImgUrl = "https://images.netdirector.co.uk/gforces-auto/image/upload/w_548,h_365,q_auto,c_fill,f_auto,fl_lossy/auto-client/6cc5b5823b68a44ccafcb0d49ebdb4d7/c_200.png",
                            Model = "C 180",
                            Price = 2148646,
                            Volume = 1.5,
                            Year = 2024
                        });
                });

            modelBuilder.Entity("_03_SecondHomeWorkViewModel.Entities.Mercedes", b =>
                {
                    b.HasOne("_03_SecondHomeWorkViewModel.Entities.BrandOfCar", "BrandOfCar")
                        .WithMany("Mercedeses")
                        .HasForeignKey("BrandOfCarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BrandOfCar");
                });

            modelBuilder.Entity("_03_SecondHomeWorkViewModel.Entities.BrandOfCar", b =>
                {
                    b.Navigation("Mercedeses");
                });
#pragma warning restore 612, 618
        }
    }
}
