﻿// <auto-generated />
using System;
using BookManagementSystem.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookManagementSystem.API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231202163509_yourmigration")]
    partial class yourmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.Property<Guid>("BooksId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenresId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BooksId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("BookGenre");
                });

            modelBuilder.Entity("BookManagementSystem.API.Models.Domain.ApplicationUser", b =>
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int>("TokensAvailable")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1699067d-437a-40db-b729-6532de6fc769",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fdb5ea99-8746-43e5-a578-b1c5aaaa4430",
                            Email = "admin@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Admin",
                            NormalizedEmail = "ADMIN@TEST.COM",
                            NormalizedUserName = "ADMIN@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEErxMan9URPw2O/BeDEKEFYierikKOMaQdIolumOiUFZF2VYPqLDjJGgfKtDG32Xzg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "409e9546-7ef7-42ef-919b-2fd07f6ef677",
                            TokensAvailable = 0,
                            TwoFactorEnabled = false,
                            UserName = "admin@test.com"
                        },
                        new
                        {
                            Id = "0328a630-b6f3-415f-b3a3-8d5c8e187f0d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4719144f-b5d6-4adb-ad37-67c30f8b6e85",
                            Email = "swatantra@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Swatantra",
                            NormalizedEmail = "SWATANTRA@TEST.COM",
                            NormalizedUserName = "SWATANTRA@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEH7fsrBxDCTYfJbUwIHZOEeIczizMQzmX8kEQQDn9wNQPEetzZcblVWeyHvU0KEZvA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "923ced21-d617-426f-9611-a1f7b40cc9df",
                            TokensAvailable = 1,
                            TwoFactorEnabled = false,
                            UserName = "swatantra@test.com"
                        },
                        new
                        {
                            Id = "000baffb-cab4-41b3-8ec9-7dcda6df0e30",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1d1b11dc-ce31-414f-acf4-687d385bd9ef",
                            Email = "avinash@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Avinash",
                            NormalizedEmail = "AVINASH@TEST.COM",
                            NormalizedUserName = "AVINASH@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAECDtDftlubTOs762r7hsHyA39p7EYzs/pJh1mKULwb2eBN1wk8d4jnPxp2FnQyWYzw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bb77af58-8f28-46a1-8149-798ce8ecc64a",
                            TokensAvailable = 1,
                            TwoFactorEnabled = false,
                            UserName = "avinash@test.com"
                        },
                        new
                        {
                            Id = "bda14ead-e719-4182-aea9-732ceaa3545c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8addac29-8653-4d55-b2fa-bd5706e3bf2c",
                            Email = "abhishek@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Abhishek",
                            NormalizedEmail = "ABHISHEK@TEST.COM",
                            NormalizedUserName = "ABHISHEK@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEIlCcJPs/Qyrc0PvCg4eXO1E2n4Avm1/e45wdk2BHAKj43dXMJA3XjS1eOSFDHGSJQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7ab561a8-0f2e-4b27-b207-333c53ec3c8c",
                            TokensAvailable = 1,
                            TwoFactorEnabled = false,
                            UserName = "abhishek@test.com"
                        },
                        new
                        {
                            Id = "cf3167a8-cda9-440e-bac2-79523e51401b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d92a42a6-6868-48d1-bee5-7b34e3145b74",
                            Email = "pranav@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Pranav",
                            NormalizedEmail = "PRANAV@TEST.COM",
                            NormalizedUserName = "PRANAV@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAVcbPALPT58Vk5pHoi2JGE0vmilObBfu6vSIAXticKylxo6Nnrop4xX+AWWFoEn9w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f6559256-6b17-4704-b90c-49e02df1bd23",
                            TokensAvailable = 1,
                            TwoFactorEnabled = false,
                            UserName = "pranav@test.com"
                        });
                });

            modelBuilder.Entity("BookManagementSystem.API.Models.Domain.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentlyBorrowedByUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeaturedImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("LentByUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Ratings")
                        .HasColumnType("float");

                    b.Property<string>("UrlHandle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("59e04f5c-3f96-4401-ba87-ce9d5749593e"),
                            Author = "J.K Rolling",
                            Description = "Harry Potter and the Sorcerer's Stone, also known as Harry Potter and the Philosopher's Stone outside of the United States, is a fantasy novel written by British author J. K. Rowling. The novel chronicles the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are first-year students at Hogwarts School of Witchcraft and Wizardry. The story covers Harry's first discovery of his magical heritage, his enrollment at Hogwarts, his making of close friends and enemies, and his confrontation with the dark wizard Lord Voldemort. The novel was first published in the United Kingdom by Bloomsbury Ltd. on 26 June 1997.\r\n\r\nA lonely orphan living with his unwelcoming aunt, uncle, and cousin, Harry Potter learns on his eleventh birthday that he is an orphaned wizard and is famous throughout the wizarding world as the boy who survived the attack by Lord Voldemort, a powerful dark wizard who killed Harry's parents in their attempt to thwart his bid for power. Harry is summoned from his life as an unwanted child by his parents' friend Rubeus Hagrid, a giant and Hogwarts' Keeper of Keys and Grounds, who reveals to him that he is a wizard and has been accepted at Hogwarts School of Witchcraft and Wizardry.\r\n\r\nAt Hogwarts, Harry is sorted into Gryffindor House and befriends Ron Weasley and Hermione Granger. Together, they learn about magic, defend themselves from dark creatures, and uncover a plot by Voldemort, who has returned to power and is hiding within the school, to steal the Sorcerer's Stone, a powerful object that would grant him immortality.",
                            FeaturedImageUrl = "https://images.pexels.com/photos/8391515/pexels-photo-8391515.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                            IsAvailable = true,
                            LentByUserId = "1699067d-437a-40db-b729-6532de6fc769",
                            Name = "Harry Potter",
                            Ratings = 0.0,
                            UrlHandle = "Harry Potter and the Sorcerer's Stone"
                        },
                        new
                        {
                            Id = new Guid("576c4358-1fd8-4b73-8c6c-834d66b203d3"),
                            Author = "Bhagat Singh",
                            Description = " Bhagat Singh's Jail Diary is a poignant and thought-provoking collection of writings penned by the Indian revolutionary during his imprisonment in Lahore Central Jail from 1929 to 1931. It offers a glimpse into his mind and soul, revealing his deep love for his country, his unwavering commitment to social justice, and his unwavering belief in the power of revolution.  The diary is a tapestry of personal reflections, political treatises, and literary musings, reflecting Singh's multifaceted personality and his wide-ranging intellectual interests. He delves into topics such as imperialism, capitalism, socialism, atheism, and religion, engaging with the ideas of prominent thinkers like Karl Marx, Vladimir Lenin, and Fyodor Dostoevsky.  Singh's writings are characterized by their clarity, passion, and sincerity. He fearlessly exposes the injustices of British rule in India and the plight of the oppressed masses. He calls for a radical transformation of society, advocating for a classless, egalitarian society based on the principles of socialism and communism.  The Jail Diary is not just a historical document; it is a testament to the indomitable spirit of a young man who dared to challenge the status quo and fight for a better world. It continues to inspire and challenge readers, reminding us of the power of individual action and the importance of fighting for what is right.",
                            FeaturedImageUrl = "https://m.media-amazon.com/images/I/51h5ch+vZIL.jpg",
                            IsAvailable = true,
                            LentByUserId = "1699067d-437a-40db-b729-6532de6fc769",
                            Name = "Jail Diary",
                            Ratings = 0.0,
                            UrlHandle = "Jail Diary By Bhagat Singh"
                        });
                });

            modelBuilder.Entity("BookManagementSystem.API.Models.Domain.BookImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookImages");
                });

            modelBuilder.Entity("BookManagementSystem.API.Models.Domain.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlHandle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c497a3d9-6d82-4457-b791-3853cdd16331"),
                            Name = "Fantasy",
                            UrlHandle = "/Fantasy"
                        },
                        new
                        {
                            Id = new Guid("c93f21b5-c45d-4dfd-ab7e-305b73beb8b7"),
                            Name = "Novel",
                            UrlHandle = "/Novel"
                        },
                        new
                        {
                            Id = new Guid("6c9efb98-bebc-4dc3-b30d-416c0e5fc1f6"),
                            Name = "Science Fiction",
                            UrlHandle = "Science Fiction"
                        },
                        new
                        {
                            Id = new Guid("421b10ef-a2c5-46b4-afd6-18293ed8aade"),
                            Name = "Others",
                            UrlHandle = "/Others"
                        });
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

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1",
                            ConcurrencyStamp = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1",
                            Name = "Reader",
                            NormalizedName = "READER"
                        },
                        new
                        {
                            Id = "95cb1e1c-d8b6-45a2-b240-6d211c06fd00",
                            ConcurrencyStamp = "95cb1e1c-d8b6-45a2-b240-6d211c06fd00",
                            Name = "Writer",
                            NormalizedName = "WRITER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "1699067d-437a-40db-b729-6532de6fc769",
                            RoleId = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1"
                        },
                        new
                        {
                            UserId = "1699067d-437a-40db-b729-6532de6fc769",
                            RoleId = "95cb1e1c-d8b6-45a2-b240-6d211c06fd00"
                        },
                        new
                        {
                            UserId = "0328a630-b6f3-415f-b3a3-8d5c8e187f0d",
                            RoleId = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1"
                        },
                        new
                        {
                            UserId = "000baffb-cab4-41b3-8ec9-7dcda6df0e30",
                            RoleId = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1"
                        },
                        new
                        {
                            UserId = "bda14ead-e719-4182-aea9-732ceaa3545c",
                            RoleId = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1"
                        },
                        new
                        {
                            UserId = "cf3167a8-cda9-440e-bac2-79523e51401b",
                            RoleId = "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.HasOne("BookManagementSystem.API.Models.Domain.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookManagementSystem.API.Models.Domain.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("BookManagementSystem.API.Models.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BookManagementSystem.API.Models.Domain.ApplicationUser", null)
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

                    b.HasOne("BookManagementSystem.API.Models.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BookManagementSystem.API.Models.Domain.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
