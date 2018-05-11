﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TheBookCave.Data;

namespace TheBookCave.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<int>("CountryId");

                    b.Property<string>("Phone");

                    b.Property<string>("Region");

                    b.Property<string>("UserId");

                    b.Property<string>("Zip");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("DescriptionEN");

                    b.Property<string>("DescriptionIS");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<string>("DetailsEN");

                    b.Property<string>("DetailsIS");

                    b.Property<int>("Discount");

                    b.Property<int>("GenreId");

                    b.Property<double>("Grade");

                    b.Property<string>("Name");

                    b.Property<int>("NrOfGrades");

                    b.Property<int>("Pages");

                    b.Property<string>("Picture");

                    b.Property<double>("Price");

                    b.Property<bool>("Published");

                    b.Property<int>("PublisherId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryCode");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GenreEN");

                    b.Property<string>("GenreIS");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Help", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnswerEN");

                    b.Property<string>("AnswerIS");

                    b.Property<string>("Question");

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.ToTable("Helps");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.HelpType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TypeEN");

                    b.Property<string>("TypeIS");

                    b.HasKey("Id");

                    b.ToTable("HelpType");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("OrderStatusId");

                    b.Property<int>("TypeId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<int>("Discount");

                    b.Property<int>("OrderId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.OrderItemBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AuthorId");

                    b.Property<int>("BookId");

                    b.Property<string>("DetailsEN");

                    b.Property<string>("DetailsIS");

                    b.Property<int>("Discount");

                    b.Property<int>("GenreId");

                    b.Property<double>("Grade");

                    b.Property<string>("Name");

                    b.Property<int>("NrOfGrades");

                    b.Property<int>("OrderItemId");

                    b.Property<int>("Pages");

                    b.Property<string>("Picture");

                    b.Property<double>("Price");

                    b.Property<bool>("Published");

                    b.Property<int>("PublisherId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.ToTable("OrderItemBook");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StatusEN");

                    b.Property<string>("StatusIS");

                    b.HasKey("Id");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.PaymentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<int>("CVC");

                    b.Property<string>("CardNumber");

                    b.Property<DateTime>("ExpiryDate");

                    b.Property<string>("NameOnCard");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("PaymentDetails");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.PromoCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Description");

                    b.Property<int>("Discount");

                    b.Property<bool>("Published");

                    b.HasKey("Id");

                    b.ToTable("PromoCodes");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.HasKey("Id");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescriptionEn");

                    b.Property<string>("DescriptionIn");

                    b.Property<bool>("Published");

                    b.Property<string>("TypeEn");

                    b.Property<string>("TypeIn");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("AddressId");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int>("FavoriteBookId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<string>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Picture");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.UserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("AspNetClaims");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.UserReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<DateTime>("Date");

                    b.Property<double>("Grade");

                    b.Property<string>("Review");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserReviews");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("AspNetUserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
