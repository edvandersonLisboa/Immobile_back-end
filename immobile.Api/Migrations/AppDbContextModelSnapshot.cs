﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using immobile.Api.Infraestructs;

#nullable disable

namespace immobile.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("immobile.Api.Entities.AddressEntity", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postal_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("immobile.Api.Entities.ContactEntity", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("DDD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DDI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("immobile.Api.Entities.Contact_and_immobile", b =>
                {
                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<int>("ImmobileId")
                        .HasColumnType("int");

                    b.HasKey("ContactId", "ImmobileId");

                    b.HasIndex("ImmobileId");

                    b.ToTable("Contact_and_immobile");
                });

            modelBuilder.Entity("immobile.Api.Entities.ImmobileEntity", b =>
                {
                    b.Property<int>("ImmobileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImmobileId"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TagImmobileTypeId")
                        .HasColumnType("int");

                    b.HasKey("ImmobileId");

                    b.HasIndex("AddressId");

                    b.HasIndex("TagImmobileTypeId");

                    b.ToTable("Immobile");
                });

            modelBuilder.Entity("immobile.Api.Entities.PriceEntity", b =>
                {
                    b.Property<int>("PriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PriceId"));

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("PriceId");

                    b.ToTable("Price");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagAdvertiseTypeEntity", b =>
                {
                    b.Property<int>("TagAdvertiseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagAdvertiseTypeId"));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagAdvertiseTypeId");

                    b.ToTable("TagAdvertiseType");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagAdvertiseType_and_immobile", b =>
                {
                    b.Property<int>("TagAdvertiseTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ImmobileId")
                        .HasColumnType("int");

                    b.HasKey("TagAdvertiseTypeId", "ImmobileId");

                    b.HasIndex("ImmobileId");

                    b.ToTable("TagAdvertiseType_and_immobile");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagBusinessEntity", b =>
                {
                    b.Property<int>("TagBusinessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagBusinessId"));

                    b.Property<int>("ImmobileId")
                        .HasColumnType("int");

                    b.Property<int>("PriceId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagBusinessId");

                    b.HasIndex("ImmobileId");

                    b.HasIndex("PriceId");

                    b.ToTable("TagBusiness");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagCommonAreaEntity", b =>
                {
                    b.Property<int>("TagCommonAreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagCommonAreaId"));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagCommonAreaId");

                    b.ToTable("TagCommonArea");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagCommonArea_and_Immobile", b =>
                {
                    b.Property<int>("TagCommonAreaId")
                        .HasColumnType("int");

                    b.Property<int>("ImmobileId")
                        .HasColumnType("int");

                    b.HasKey("TagCommonAreaId", "ImmobileId");

                    b.HasIndex("ImmobileId");

                    b.ToTable("TagCommonArea_and_Immobile");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagImmobileTypeEntity", b =>
                {
                    b.Property<int>("TagImmobileTipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagImmobileTipeId"));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagImmobileTipeId");

                    b.ToTable("TagImmobileType");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagPrivateAreaEntity", b =>
                {
                    b.Property<int>("TagPrivateAreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagPrivateAreaId"));

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagPrivateAreaId");

                    b.ToTable("TagPrivateArea");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagPrivateArea_and_immobile", b =>
                {
                    b.Property<int>("TagPrivateAreaId")
                        .HasColumnType("int");

                    b.Property<int>("ImmobileId")
                        .HasColumnType("int");

                    b.HasKey("TagPrivateAreaId", "ImmobileId");

                    b.HasIndex("ImmobileId");

                    b.ToTable("TagPrivateArea_and_immobile");
                });

            modelBuilder.Entity("immobile.Api.Entities.Contact_and_immobile", b =>
                {
                    b.HasOne("immobile.Api.Entities.ContactEntity", "Contact")
                        .WithMany("Immobile")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("immobile.Api.Entities.ImmobileEntity", "Immobile")
                        .WithMany("Contacts")
                        .HasForeignKey("ImmobileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("Immobile");
                });

            modelBuilder.Entity("immobile.Api.Entities.ImmobileEntity", b =>
                {
                    b.HasOne("immobile.Api.Entities.AddressEntity", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("immobile.Api.Entities.TagImmobileTypeEntity", "TagImmobileType")
                        .WithMany("Immobile")
                        .HasForeignKey("TagImmobileTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("TagImmobileType");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagAdvertiseType_and_immobile", b =>
                {
                    b.HasOne("immobile.Api.Entities.ImmobileEntity", "Immobile")
                        .WithMany("TagsAdvertiseTypes")
                        .HasForeignKey("ImmobileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("immobile.Api.Entities.TagAdvertiseTypeEntity", "TagAdvertiseType")
                        .WithMany("Immobile")
                        .HasForeignKey("TagAdvertiseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Immobile");

                    b.Navigation("TagAdvertiseType");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagBusinessEntity", b =>
                {
                    b.HasOne("immobile.Api.Entities.ImmobileEntity", "Immobile")
                        .WithMany("TagsBusiness")
                        .HasForeignKey("ImmobileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("immobile.Api.Entities.PriceEntity", "Price")
                        .WithMany()
                        .HasForeignKey("PriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Immobile");

                    b.Navigation("Price");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagCommonArea_and_Immobile", b =>
                {
                    b.HasOne("immobile.Api.Entities.ImmobileEntity", "Immobile")
                        .WithMany("TagsCommonsArea")
                        .HasForeignKey("ImmobileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("immobile.Api.Entities.TagCommonAreaEntity", "TagCommonArea")
                        .WithMany("Immobile")
                        .HasForeignKey("TagCommonAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Immobile");

                    b.Navigation("TagCommonArea");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagPrivateArea_and_immobile", b =>
                {
                    b.HasOne("immobile.Api.Entities.ImmobileEntity", "Immobile")
                        .WithMany("TagsPrivateArea")
                        .HasForeignKey("ImmobileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("immobile.Api.Entities.TagPrivateAreaEntity", "TagPrivateArea")
                        .WithMany("Immobile")
                        .HasForeignKey("TagPrivateAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Immobile");

                    b.Navigation("TagPrivateArea");
                });

            modelBuilder.Entity("immobile.Api.Entities.ContactEntity", b =>
                {
                    b.Navigation("Immobile");
                });

            modelBuilder.Entity("immobile.Api.Entities.ImmobileEntity", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("TagsAdvertiseTypes");

                    b.Navigation("TagsBusiness");

                    b.Navigation("TagsCommonsArea");

                    b.Navigation("TagsPrivateArea");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagAdvertiseTypeEntity", b =>
                {
                    b.Navigation("Immobile");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagCommonAreaEntity", b =>
                {
                    b.Navigation("Immobile");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagImmobileTypeEntity", b =>
                {
                    b.Navigation("Immobile");
                });

            modelBuilder.Entity("immobile.Api.Entities.TagPrivateAreaEntity", b =>
                {
                    b.Navigation("Immobile");
                });
#pragma warning restore 612, 618
        }
    }
}
