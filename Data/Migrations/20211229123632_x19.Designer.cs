﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(DBbrella))]
    [Migration("20211229123632_x19")]
    partial class x19
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("family")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("forgotPassTimeSpan")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<DateTime>("tokenCreationTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Data.Entities.Element1", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("languageId")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("languageId");

                    b.ToTable("element1s");
                });

            modelBuilder.Entity("Data.Entities.Element2", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("languageId")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("languageId");

                    b.ToTable("element2s");
                });

            modelBuilder.Entity("Data.Entities.Element3", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("languageId")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("languageId");

                    b.ToTable("element3s");
                });

            modelBuilder.Entity("Data.Entities.Element4", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("languageId")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("languageId");

                    b.ToTable("element4s");
                });

            modelBuilder.Entity("Data.Entities.ElementProp", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrderDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutUsLongDes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("aboutUsShortDes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactUsDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactUsTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("e1Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("e1PreTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("e1Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("e2Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("e2PreTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("e2Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("e2img")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("e3Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("e3PreTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("e3Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("e3img")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("e4PreTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("e4Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("e4img")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("e5ButtonLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("e5ButtonText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("e5Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("e5Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instaLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("languageId")
                        .HasColumnType("int");

                    b.Property<byte[]>("mainLogo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("secondaryLogo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("telegramLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("languageId");

                    b.ToTable("elementProps");
                });

            modelBuilder.Entity("Data.Entities.Group", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleteForAdmin")
                        .HasColumnType("bit");

                    b.Property<DateTime>("lastMessageTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("groups");
                });

            modelBuilder.Entity("Data.Entities.Inbox", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsConfirm")
                        .HasColumnType("bit");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameFamily")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phonenumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("inboxes");
                });

            modelBuilder.Entity("Data.Entities.Language", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("faTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("languages");
                });

            modelBuilder.Entity("Data.Entities.Message", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleteForAdmin")
                        .HasColumnType("bit");

                    b.Property<DateTime>("createTime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("file")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("groupId")
                        .HasColumnType("int");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("groupId");

                    b.HasIndex("userId");

                    b.ToTable("messages");
                });

            modelBuilder.Entity("Data.Entities.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsAdminConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("payTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<int>("trackingCode")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Data.Entities.Post", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsEmail")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSms")
                        .HasColumnType("bit");

                    b.Property<DateTime>("createTime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("detailImg")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("languageId")
                        .HasColumnType("int");

                    b.Property<string>("longDecpription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortDecpription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("thumbNail")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("languageId");

                    b.HasIndex("userId");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("Data.Entities.Project", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEmail")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSms")
                        .HasColumnType("bit");

                    b.Property<byte[]>("detailImg")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("languageId")
                        .HasColumnType("int");

                    b.Property<byte[]>("thumbNail")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("languageId");

                    b.HasIndex("userId");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("Data.Entities.SlideBar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("buttonLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("buttonTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("img")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("languageId")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("languageId");

                    b.ToTable("slideBars");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Data.Entities.Element1", b =>
                {
                    b.HasOne("Data.Entities.Language", "language")
                        .WithMany("element1s")
                        .HasForeignKey("languageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("language");
                });

            modelBuilder.Entity("Data.Entities.Element2", b =>
                {
                    b.HasOne("Data.Entities.Language", "language")
                        .WithMany("element2s")
                        .HasForeignKey("languageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("language");
                });

            modelBuilder.Entity("Data.Entities.Element3", b =>
                {
                    b.HasOne("Data.Entities.Language", "language")
                        .WithMany("element3s")
                        .HasForeignKey("languageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("language");
                });

            modelBuilder.Entity("Data.Entities.Element4", b =>
                {
                    b.HasOne("Data.Entities.Language", "language")
                        .WithMany("element4s")
                        .HasForeignKey("languageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("language");
                });

            modelBuilder.Entity("Data.Entities.ElementProp", b =>
                {
                    b.HasOne("Data.Entities.Language", "language")
                        .WithMany("elementProps")
                        .HasForeignKey("languageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("language");
                });

            modelBuilder.Entity("Data.Entities.Message", b =>
                {
                    b.HasOne("Data.Entities.Group", "group")
                        .WithMany("messages")
                        .HasForeignKey("groupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.ApplicationUser", "applicationUser")
                        .WithMany("messages")
                        .HasForeignKey("userId");

                    b.Navigation("applicationUser");

                    b.Navigation("group");
                });

            modelBuilder.Entity("Data.Entities.Order", b =>
                {
                    b.HasOne("Data.Entities.ApplicationUser", "applicationUser")
                        .WithMany("orders")
                        .HasForeignKey("userId");

                    b.Navigation("applicationUser");
                });

            modelBuilder.Entity("Data.Entities.Post", b =>
                {
                    b.HasOne("Data.Entities.Language", "language")
                        .WithMany("posts")
                        .HasForeignKey("languageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("posts")
                        .HasForeignKey("userId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("language");
                });

            modelBuilder.Entity("Data.Entities.Project", b =>
                {
                    b.HasOne("Data.Entities.Language", "language")
                        .WithMany("projects")
                        .HasForeignKey("languageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("projects")
                        .HasForeignKey("userId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("language");
                });

            modelBuilder.Entity("Data.Entities.SlideBar", b =>
                {
                    b.HasOne("Data.Entities.Language", "language")
                        .WithMany("slideBars")
                        .HasForeignKey("languageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("language");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Data.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.ApplicationUser", b =>
                {
                    b.Navigation("messages");

                    b.Navigation("orders");

                    b.Navigation("posts");

                    b.Navigation("projects");
                });

            modelBuilder.Entity("Data.Entities.Group", b =>
                {
                    b.Navigation("messages");
                });

            modelBuilder.Entity("Data.Entities.Language", b =>
                {
                    b.Navigation("element1s");

                    b.Navigation("element2s");

                    b.Navigation("element3s");

                    b.Navigation("element4s");

                    b.Navigation("elementProps");

                    b.Navigation("posts");

                    b.Navigation("projects");

                    b.Navigation("slideBars");
                });
#pragma warning restore 612, 618
        }
    }
}
