﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
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
    [Migration("20180505171215_ManyToManyInManyMigration_cnameChange")]
    partial class ManyToManyInManyMigration_cnameChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("CountryId");

                    b.Property<string>("Phone");

                    b.Property<int>("RegionId");

                    b.Property<string>("UserId");

                    b.Property<int>("ZipId");

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

                    b.Property<int>("Pages");

                    b.Property<string>("Picture");

                    b.Property<double>("Price");

                    b.Property<bool>("Published");

                    b.Property<int>("PublisherId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GenreEn");

                    b.Property<int>("GenreIs");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Help", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnswerEN");

                    b.Property<int>("AnswerIS");

                    b.Property<string>("Question");

                    b.Property<int>("TypeId");

                    b.HasKey("Id");

                    b.ToTable("Helps");
                });

            modelBuilder.Entity("TheBookCave.Data.EntityModels.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("TypeId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Orders");
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

                    b.Property<int>("Description");

                    b.Property<int>("Discount");

                    b.Property<int>("Published");

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

                    b.Property<int>("AddressId");

                    b.Property<int>("FavoriteBookId");

                    b.Property<string>("Name");

                    b.Property<int>("OrderId");

                    b.Property<string>("Password");

                    b.Property<bool>("Permission");

                    b.Property<string>("Picture");

                    b.Property<int>("SubscriptionId");

                    b.HasKey("Id");

                    b.ToTable("Users");
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
#pragma warning restore 612, 618
        }
    }
}
