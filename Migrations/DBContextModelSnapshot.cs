﻿// <auto-generated />
using System;
using CoolMate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoolMate.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CoolMate.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("AddressLine")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("address_line");

                    b.Property<string>("Commune")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("commune");

                    b.Property<string>("District")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("district");

                    b.Property<string>("Province")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("province");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("address", (string)null);
                });

            modelBuilder.Entity("CoolMate.Models.OrderLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<int?>("Price")
                        .HasColumnType("int")
                        .HasColumnName("price");

                    b.Property<int?>("ProductItemId")
                        .HasColumnType("int")
                        .HasColumnName("product_item_id");

                    b.Property<int?>("Qty")
                        .HasColumnType("int")
                        .HasColumnName("qty");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "OrderId" }, "fk_orderline_order");

                    b.HasIndex(new[] { "ProductItemId" }, "fk_orderline_proditem");

                    b.ToTable("order_line", (string)null);
                });

            modelBuilder.Entity("CoolMate.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<int?>("PriceInt")
                        .HasColumnType("int")
                        .HasColumnName("price_int");

                    b.Property<string>("PriceStr")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("price_str");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CategoryId" }, "fk_category");

                    b.ToTable("product", (string)null);
                });

            modelBuilder.Entity("CoolMate.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("category_name");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("parent_category_id");

                    b.Property<string>("Slug")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("slug");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("product_category", (string)null);
                });

            modelBuilder.Entity("CoolMate.Models.ProductItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Color")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("color");

                    b.Property<string>("ColorImage")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("color_image");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int?>("QtyInStock")
                        .HasColumnType("int")
                        .HasColumnName("qty_in_stock");

                    b.Property<string>("Size")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("size");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ProductId" }, "fk_proditem_product");

                    b.ToTable("product_item", (string)null);
                });

            modelBuilder.Entity("CoolMate.Models.ProductItemImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("ProductItemId")
                        .HasColumnType("int")
                        .HasColumnName("product_item_id");

                    b.Property<string>("Url")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("url");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ProductItemId" }, "fk_product_item_id");

                    b.ToTable("product_item_image", (string)null);
                });

            modelBuilder.Entity("CoolMate.Models.ShippingFee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("ShippingAddress")
                        .HasColumnType("int")
                        .HasColumnName("shipping_address");

                    b.Property<int?>("Value")
                        .HasColumnType("int")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ShippingAddress" }, "fk_shippingfee_shipaddress");

                    b.ToTable("shipping_fee", (string)null);
                });

            modelBuilder.Entity("CoolMate.Models.ShopOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime")
                        .HasColumnName("order_date");

                    b.Property<int?>("OrderStatus")
                        .HasColumnType("int")
                        .HasColumnName("order_status");

                    b.Property<int?>("OrderTotal")
                        .HasColumnType("int")
                        .HasColumnName("order_total");

                    b.Property<int?>("PaymentMethodId")
                        .HasColumnType("int")
                        .HasColumnName("payment_method_id");

                    b.Property<string>("ShippingAddress")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("shipping_address");

                    b.Property<int?>("ShippingMethod")
                        .HasColumnType("int")
                        .HasColumnName("shipping_method");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "PaymentMethodId" }, "fk_shoporder_paymethod");

                    b.HasIndex(new[] { "ShippingMethod" }, "fk_shoporder_shipmethod");

                    b.HasIndex(new[] { "OrderStatus" }, "fk_shoporder_status");

                    b.HasIndex(new[] { "UserId" }, "fk_shoporder_user");

                    b.ToTable("shop_order", (string)null);
                });

            modelBuilder.Entity("CoolMate.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "UserId" }, "fk_shopcart_user");

                    b.ToTable("shopping_cart", (string)null);
                });

            modelBuilder.Entity("CoolMate.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("CartId")
                        .HasColumnType("int")
                        .HasColumnName("cart_id");

                    b.Property<int?>("ProductItemId")
                        .HasColumnType("int")
                        .HasColumnName("product_item_id");

                    b.Property<int?>("Qty")
                        .HasColumnType("int")
                        .HasColumnName("qty");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ProductItemId" }, "fk_shopcartitem_proditem");

                    b.HasIndex(new[] { "CartId" }, "fk_shopcartitem_shopcart");

                    b.ToTable("shopping_cart_item", (string)null);
                });

            modelBuilder.Entity("CoolMate.Models.SiteUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Birthday")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("birthday");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("longtext");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Gender")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("gender");

                    b.Property<int?>("Height")
                        .HasColumnType("int")
                        .HasColumnName("height");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone_number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.Property<int?>("Weight")
                        .HasColumnType("int")
                        .HasColumnName("weight");

                    b.HasKey("Id");

                    b.ToTable("site_user", (string)null);
                });

            modelBuilder.Entity("CoolMate.Models.UserAddress", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("address_id");

                    b.Property<int?>("IsDefault")
                        .HasColumnType("int")
                        .HasColumnName("is_default");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext")
                        .HasColumnName("phone_number");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "AddressId" }, "fk_useradd_address");

                    b.HasIndex(new[] { "UserId" }, "fk_useradd_user");

                    b.ToTable("user_address", (string)null);
                });

            modelBuilder.Entity("CoolMate.Models.UserReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Comment")
                        .HasMaxLength(2000)
                        .HasColumnType("varchar(2000)")
                        .HasColumnName("comment");

                    b.Property<int?>("OrderedProductId")
                        .HasColumnType("int")
                        .HasColumnName("ordered_product_id");

                    b.Property<int?>("RatingValue")
                        .HasColumnType("int")
                        .HasColumnName("rating_value");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "OrderedProductId" }, "fk_review_product");

                    b.HasIndex(new[] { "UserId" }, "fk_review_user");

                    b.ToTable("user_review", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .HasColumnType("longtext");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("CoolMate.Models.OrderLine", b =>
                {
                    b.HasOne("CoolMate.Models.ShopOrder", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("fk_orderline_order");

                    b.HasOne("CoolMate.Models.ProductItem", "ProductItem")
                        .WithMany("OrderLines")
                        .HasForeignKey("ProductItemId")
                        .HasConstraintName("fk_orderline_proditem");

                    b.Navigation("Order");

                    b.Navigation("ProductItem");
                });

            modelBuilder.Entity("CoolMate.Models.Product", b =>
                {
                    b.HasOne("CoolMate.Models.ProductCategory", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("fk_category");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CoolMate.Models.ProductItem", b =>
                {
                    b.HasOne("CoolMate.Models.Product", "Product")
                        .WithMany("ProductItems")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk_proditem_product");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("CoolMate.Models.ProductItemImage", b =>
                {
                    b.HasOne("CoolMate.Models.ProductItem", "ProductItem")
                        .WithMany("ProductItemImages")
                        .HasForeignKey("ProductItemId")
                        .HasConstraintName("fk_product_item_id");

                    b.Navigation("ProductItem");
                });

            modelBuilder.Entity("CoolMate.Models.ShippingFee", b =>
                {
                    b.HasOne("CoolMate.Models.Address", "ShippingAddressNavigation")
                        .WithMany("ShippingFees")
                        .HasForeignKey("ShippingAddress")
                        .HasConstraintName("fk_shippingfee_shipaddress");

                    b.Navigation("ShippingAddressNavigation");
                });

            modelBuilder.Entity("CoolMate.Models.ShopOrder", b =>
                {
                    b.HasOne("CoolMate.Models.SiteUser", "User")
                        .WithMany("ShopOrders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_shoporder_user");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CoolMate.Models.ShoppingCart", b =>
                {
                    b.HasOne("CoolMate.Models.SiteUser", "User")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_shopcart_user");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CoolMate.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("CoolMate.Models.ShoppingCart", "Cart")
                        .WithMany("ShoppingCartItems")
                        .HasForeignKey("CartId")
                        .HasConstraintName("fk_shopcartitem_shopcart");

                    b.HasOne("CoolMate.Models.ProductItem", "ProductItem")
                        .WithMany("ShoppingCartItems")
                        .HasForeignKey("ProductItemId")
                        .HasConstraintName("fk_shopcartitem_proditem");

                    b.Navigation("Cart");

                    b.Navigation("ProductItem");
                });

            modelBuilder.Entity("CoolMate.Models.UserAddress", b =>
                {
                    b.HasOne("CoolMate.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .HasConstraintName("fk_useradd_address");

                    b.HasOne("CoolMate.Models.SiteUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_useradd_user");

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CoolMate.Models.UserReview", b =>
                {
                    b.HasOne("CoolMate.Models.OrderLine", "OrderedProduct")
                        .WithMany("UserReviews")
                        .HasForeignKey("OrderedProductId")
                        .HasConstraintName("fk_review_product");

                    b.HasOne("CoolMate.Models.SiteUser", "User")
                        .WithMany("UserReviews")
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_review_user");

                    b.Navigation("OrderedProduct");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CoolMate.Models.Address", b =>
                {
                    b.Navigation("ShippingFees");
                });

            modelBuilder.Entity("CoolMate.Models.OrderLine", b =>
                {
                    b.Navigation("UserReviews");
                });

            modelBuilder.Entity("CoolMate.Models.Product", b =>
                {
                    b.Navigation("ProductItems");
                });

            modelBuilder.Entity("CoolMate.Models.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CoolMate.Models.ProductItem", b =>
                {
                    b.Navigation("OrderLines");

                    b.Navigation("ProductItemImages");

                    b.Navigation("ShoppingCartItems");
                });

            modelBuilder.Entity("CoolMate.Models.ShopOrder", b =>
                {
                    b.Navigation("OrderLines");
                });

            modelBuilder.Entity("CoolMate.Models.ShoppingCart", b =>
                {
                    b.Navigation("ShoppingCartItems");
                });

            modelBuilder.Entity("CoolMate.Models.SiteUser", b =>
                {
                    b.Navigation("ShopOrders");

                    b.Navigation("ShoppingCarts");

                    b.Navigation("UserReviews");
                });
#pragma warning restore 612, 618
        }
    }
}
