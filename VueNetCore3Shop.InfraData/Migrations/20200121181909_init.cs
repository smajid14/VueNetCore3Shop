﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VueNetCore3Shop.InfraData.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Province = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Mobile = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Category",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatTitle = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Category", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_FirstSubCategory",
                columns: table => new
                {
                    FirstSubCatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatId_FK = table.Column<int>(nullable: false),
                    FirstSubCatTitle = table.Column<string>(maxLength: 50, nullable: false),
                    Picture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_FirstSubCategory", x => x.FirstSubCatId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_LastSubCategory",
                columns: table => new
                {
                    LastSubCatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecondSubCatId_FK = table.Column<int>(nullable: false),
                    LastSubCatTitle = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_LastSubCategory", x => x.LastSubCatId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleTitle = table.Column<string>(nullable: false),
                    RoleName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_SecondSubCategory",
                columns: table => new
                {
                    SecondSubCatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstSubCatId_FK = table.Column<int>(nullable: false),
                    SecondSubCatTitle = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_SecondSubCategory", x => x.SecondSubCatId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Server",
                columns: table => new
                {
                    ServerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerTitle = table.Column<string>(maxLength: 100, nullable: false),
                    IP = table.Column<string>(nullable: false),
                    FtpUsername = table.Column<string>(maxLength: 100, nullable: false),
                    FtpPassword = table.Column<string>(maxLength: 200, nullable: false),
                    Path = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    HttpDomain = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Server", x => x.ServerId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_SettingSite",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Smpt = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailPwd = table.Column<string>(nullable: true),
                    PageNumber = table.Column<int>(nullable: false),
                    SmsNumber = table.Column<string>(nullable: true),
                    SmsApiService = table.Column<string>(nullable: true),
                    SmsSecretKey = table.Column<string>(nullable: true),
                    Tax = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_SettingSite", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_UserAccess",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId_FK = table.Column<string>(nullable: true),
                    RoleId_FK = table.Column<int>(nullable: false),
                    AddPost = table.Column<bool>(nullable: false),
                    DeletePost = table.Column<bool>(nullable: false),
                    EditPost = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_UserAccess", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tbl_UserAccess_Tbl_Role_RoleId_FK",
                        column: x => x.RoleId_FK,
                        principalTable: "Tbl_Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_UserAccess_AspNetUsers_UserId_FK",
                        column: x => x.UserId_FK,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(nullable: false),
                    ProductNameFA = table.Column<string>(maxLength: 100, nullable: false),
                    ProductNameEN = table.Column<string>(maxLength: 100, nullable: false),
                    DefaultPic = table.Column<string>(nullable: true),
                    CategoryId_FK = table.Column<int>(nullable: false),
                    FirstSubCat_FK = table.Column<int>(nullable: false),
                    SecondSubCat_FK = table.Column<int>(nullable: false),
                    LastSubCat_FK = table.Column<int>(nullable: false),
                    SeeProduct = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    IsShowProduct = table.Column<bool>(nullable: false),
                    OffProduct = table.Column<int>(nullable: false),
                    CountProduct = table.Column<int>(nullable: false),
                    DateProduct = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    UserId_FK = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Tbl_Products_Tbl_Category_CategoryId_FK",
                        column: x => x.CategoryId_FK,
                        principalTable: "Tbl_Category",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Products_Tbl_FirstSubCategory_FirstSubCat_FK",
                        column: x => x.FirstSubCat_FK,
                        principalTable: "Tbl_FirstSubCategory",
                        principalColumn: "FirstSubCatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Products_Tbl_LastSubCategory_LastSubCat_FK",
                        column: x => x.LastSubCat_FK,
                        principalTable: "Tbl_LastSubCategory",
                        principalColumn: "LastSubCatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Products_Tbl_SecondSubCategory_SecondSubCat_FK",
                        column: x => x.SecondSubCat_FK,
                        principalTable: "Tbl_SecondSubCategory",
                        principalColumn: "SecondSubCatId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Products_AspNetUsers_UserId_FK",
                        column: x => x.UserId_FK,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Files",
                columns: table => new
                {
                    FileId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerId_FK = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: true),
                    FileName = table.Column<string>(maxLength: 100, nullable: false),
                    Alt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Files", x => x.FileId);
                    table.ForeignKey(
                        name: "FK_Tbl_Files_Tbl_Server_ServerId_FK",
                        column: x => x.ServerId_FK,
                        principalTable: "Tbl_Server",
                        principalColumn: "ServerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId_FK = table.Column<int>(nullable: false),
                    UserId_FK = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    IP = table.Column<string>(nullable: true),
                    DateComment = table.Column<DateTime>(nullable: false),
                    ConfirmComment = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Tbl_Comments_Tbl_Products_ProductId_FK",
                        column: x => x.ProductId_FK,
                        principalTable: "Tbl_Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Comments_AspNetUsers_UserId_FK",
                        column: x => x.UserId_FK,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Gallery",
                columns: table => new
                {
                    PictureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId_FK = table.Column<int>(nullable: false),
                    TitlePic = table.Column<string>(maxLength: 100, nullable: false),
                    PictureName = table.Column<string>(nullable: false),
                    DefaultPicProduct = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Gallery", x => x.PictureId);
                    table.ForeignKey(
                        name: "FK_Tbl_Gallery_Tbl_Products_ProductId_FK",
                        column: x => x.ProductId_FK,
                        principalTable: "Tbl_Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ShoppingCart",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId_FK = table.Column<int>(nullable: false),
                    UserId_FK = table.Column<string>(nullable: true),
                    ProductCount = table.Column<int>(nullable: false),
                    DateShop = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    InvoiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ShoppingCart", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tbl_ShoppingCart_Tbl_Products_ProductId_FK",
                        column: x => x.ProductId_FK,
                        principalTable: "Tbl_Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_ShoppingCart_AspNetUsers_UserId_FK",
                        column: x => x.UserId_FK,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Slider",
                columns: table => new
                {
                    SliderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileId_FK = table.Column<int>(nullable: false),
                    SliderTitle = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 300, nullable: false),
                    Link = table.Column<string>(nullable: false),
                    Sort = table.Column<int>(nullable: false),
                    ServerUpload = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Slider", x => x.SliderId);
                    table.ForeignKey(
                        name: "FK_Tbl_Slider_Tbl_Files_FileId_FK",
                        column: x => x.FileId_FK,
                        principalTable: "Tbl_Files",
                        principalColumn: "FileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Comments_ProductId_FK",
                table: "Tbl_Comments",
                column: "ProductId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Comments_UserId_FK",
                table: "Tbl_Comments",
                column: "UserId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Files_ServerId_FK",
                table: "Tbl_Files",
                column: "ServerId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Gallery_ProductId_FK",
                table: "Tbl_Gallery",
                column: "ProductId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_CategoryId_FK",
                table: "Tbl_Products",
                column: "CategoryId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_FirstSubCat_FK",
                table: "Tbl_Products",
                column: "FirstSubCat_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_LastSubCat_FK",
                table: "Tbl_Products",
                column: "LastSubCat_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_ProductNameFA",
                table: "Tbl_Products",
                column: "ProductNameFA");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_SecondSubCat_FK",
                table: "Tbl_Products",
                column: "SecondSubCat_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_UserId_FK",
                table: "Tbl_Products",
                column: "UserId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ShoppingCart_ProductId_FK",
                table: "Tbl_ShoppingCart",
                column: "ProductId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ShoppingCart_UserId_FK",
                table: "Tbl_ShoppingCart",
                column: "UserId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Slider_FileId_FK",
                table: "Tbl_Slider",
                column: "FileId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_UserAccess_RoleId_FK",
                table: "Tbl_UserAccess",
                column: "RoleId_FK");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_UserAccess_UserId_FK",
                table: "Tbl_UserAccess",
                column: "UserId_FK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Tbl_Comments");

            migrationBuilder.DropTable(
                name: "Tbl_Gallery");

            migrationBuilder.DropTable(
                name: "Tbl_SettingSite");

            migrationBuilder.DropTable(
                name: "Tbl_ShoppingCart");

            migrationBuilder.DropTable(
                name: "Tbl_Slider");

            migrationBuilder.DropTable(
                name: "Tbl_UserAccess");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Tbl_Products");

            migrationBuilder.DropTable(
                name: "Tbl_Files");

            migrationBuilder.DropTable(
                name: "Tbl_Role");

            migrationBuilder.DropTable(
                name: "Tbl_Category");

            migrationBuilder.DropTable(
                name: "Tbl_FirstSubCategory");

            migrationBuilder.DropTable(
                name: "Tbl_LastSubCategory");

            migrationBuilder.DropTable(
                name: "Tbl_SecondSubCategory");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tbl_Server");
        }
    }
}
