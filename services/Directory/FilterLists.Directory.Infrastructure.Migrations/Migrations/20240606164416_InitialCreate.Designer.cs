﻿// <auto-generated />
using FilterLists.Directory.Infrastructure.Persistence.Queries.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilterLists.Directory.Infrastructure.Migrations.Migrations
{
    [DbContext(typeof(QueryDbContext))]
    [Migration("20240606164416_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Latin1_General_100_CI_AS_SC")
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Dependent", b =>
                {
                    b.Property<int>("DependencyFilterListId")
                        .HasColumnType("int");

                    b.Property<int>("DependentFilterListId")
                        .HasColumnType("int");

                    b.HasKey("DependencyFilterListId", "DependentFilterListId");

                    b.HasIndex("DependentFilterListId");

                    b.ToTable("Dependent");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ChatUrl")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DonateUrl")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ForumUrl")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("HomeUrl")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("IssuesUrl")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<int>("LicenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(5);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("OnionUrl")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("PolicyUrl")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("SubmissionUrl")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.HasKey("Id");

                    b.HasIndex("LicenseId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("FilterList");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListLanguage", b =>
                {
                    b.Property<int>("FilterListId")
                        .HasColumnType("int");

                    b.Property<short>("LanguageId")
                        .HasColumnType("smallint");

                    b.HasKey("FilterListId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("FilterListLanguage");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListMaintainer", b =>
                {
                    b.Property<int>("FilterListId")
                        .HasColumnType("int");

                    b.Property<int>("MaintainerId")
                        .HasColumnType("int");

                    b.HasKey("FilterListId", "MaintainerId");

                    b.HasIndex("MaintainerId");

                    b.ToTable("FilterListMaintainer");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListSyntax", b =>
                {
                    b.Property<int>("FilterListId")
                        .HasColumnType("int");

                    b.Property<short>("SyntaxId")
                        .HasColumnType("smallint");

                    b.HasKey("FilterListId", "SyntaxId");

                    b.HasIndex("SyntaxId");

                    b.ToTable("FilterListSyntax");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListTag", b =>
                {
                    b.Property<int>("FilterListId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("FilterListId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("FilterListTag");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Fork", b =>
                {
                    b.Property<int>("UpstreamFilterListId")
                        .HasColumnType("int");

                    b.Property<int>("ForkFilterListId")
                        .HasColumnType("int");

                    b.HasKey("UpstreamFilterListId", "ForkFilterListId");

                    b.HasIndex("ForkFilterListId");

                    b.ToTable("Fork");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Language", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"));

                    b.Property<string>("Iso6391")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nchar(2)")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("Iso6391")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Language");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.License", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<bool>("PermitsCommercialUse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("PermitsDistribution")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("PermitsModification")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Url")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("License");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Maintainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("TwitterHandle")
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Url")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Maintainer");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Merge", b =>
                {
                    b.Property<int>("IncludedInFilterListId")
                        .HasColumnType("int");

                    b.Property<int>("IncludesFilterListId")
                        .HasColumnType("int");

                    b.HasKey("IncludedInFilterListId", "IncludesFilterListId");

                    b.HasIndex("IncludesFilterListId");

                    b.ToTable("Merge");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Software", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DownloadUrl")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("HomeUrl")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<bool>("SupportsAbpUrlScheme")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Software");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.SoftwareSyntax", b =>
                {
                    b.Property<short>("SoftwareId")
                        .HasColumnType("smallint");

                    b.Property<short>("SyntaxId")
                        .HasColumnType("smallint");

                    b.HasKey("SoftwareId", "SyntaxId");

                    b.HasIndex("SyntaxId");

                    b.ToTable("SoftwareSyntax");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Syntax", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Url")
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Syntax");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Dependent", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "DependencyFilterList")
                        .WithMany("DependentFilterLists")
                        .HasForeignKey("DependencyFilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "DependentFilterList")
                        .WithMany("DependencyFilterLists")
                        .HasForeignKey("DependentFilterListId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("DependencyFilterList");

                    b.Navigation("DependentFilterList");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.License", "License")
                        .WithMany("FilterLists")
                        .HasForeignKey("LicenseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.OwnsMany("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListViewUrl", "ViewUrls", b1 =>
                        {
                            b1.Property<int>("FilterListId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<short>("Primariness")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("smallint")
                                .HasDefaultValue((short)1);

                            b1.Property<short>("SegmentNumber")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("smallint")
                                .HasDefaultValue((short)1);

                            b1.Property<string>("Url")
                                .IsRequired()
                                .HasMaxLength(512)
                                .HasColumnType("nvarchar(512)");

                            b1.HasKey("FilterListId", "Id");

                            b1.HasIndex("FilterListId", "SegmentNumber", "Primariness")
                                .IsUnique();

                            b1.ToTable("FilterListViewUrl");

                            b1.WithOwner("FilterList")
                                .HasForeignKey("FilterListId");

                            b1.Navigation("FilterList");
                        });

                    b.Navigation("License");

                    b.Navigation("ViewUrls");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListLanguage", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "FilterList")
                        .WithMany("FilterListLanguages")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Language", "Language")
                        .WithMany("FilterListLanguages")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilterList");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListMaintainer", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "FilterList")
                        .WithMany("FilterListMaintainers")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Maintainer", "Maintainer")
                        .WithMany("FilterListMaintainers")
                        .HasForeignKey("MaintainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilterList");

                    b.Navigation("Maintainer");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListSyntax", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "FilterList")
                        .WithMany("FilterListSyntaxes")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Syntax", "Syntax")
                        .WithMany("FilterListSyntaxes")
                        .HasForeignKey("SyntaxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilterList");

                    b.Navigation("Syntax");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterListTag", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "FilterList")
                        .WithMany("FilterListTags")
                        .HasForeignKey("FilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Tag", "Tag")
                        .WithMany("FilterListTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilterList");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Fork", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "ForkFilterList")
                        .WithMany("UpstreamFilterLists")
                        .HasForeignKey("ForkFilterListId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "UpstreamFilterList")
                        .WithMany("ForkFilterLists")
                        .HasForeignKey("UpstreamFilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ForkFilterList");

                    b.Navigation("UpstreamFilterList");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Merge", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "IncludedInFilterList")
                        .WithMany("IncludesFilterLists")
                        .HasForeignKey("IncludedInFilterListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", "IncludesFilterList")
                        .WithMany("IncludedInFilterLists")
                        .HasForeignKey("IncludesFilterListId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("IncludedInFilterList");

                    b.Navigation("IncludesFilterList");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.SoftwareSyntax", b =>
                {
                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Software", "Software")
                        .WithMany("SoftwareSyntaxes")
                        .HasForeignKey("SoftwareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Syntax", "Syntax")
                        .WithMany("SoftwareSyntaxes")
                        .HasForeignKey("SyntaxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Software");

                    b.Navigation("Syntax");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.FilterList", b =>
                {
                    b.Navigation("DependencyFilterLists");

                    b.Navigation("DependentFilterLists");

                    b.Navigation("FilterListLanguages");

                    b.Navigation("FilterListMaintainers");

                    b.Navigation("FilterListSyntaxes");

                    b.Navigation("FilterListTags");

                    b.Navigation("ForkFilterLists");

                    b.Navigation("IncludedInFilterLists");

                    b.Navigation("IncludesFilterLists");

                    b.Navigation("UpstreamFilterLists");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Language", b =>
                {
                    b.Navigation("FilterListLanguages");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.License", b =>
                {
                    b.Navigation("FilterLists");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Maintainer", b =>
                {
                    b.Navigation("FilterListMaintainers");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Software", b =>
                {
                    b.Navigation("SoftwareSyntaxes");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Syntax", b =>
                {
                    b.Navigation("FilterListSyntaxes");

                    b.Navigation("SoftwareSyntaxes");
                });

            modelBuilder.Entity("FilterLists.Directory.Infrastructure.Persistence.Queries.Entities.Tag", b =>
                {
                    b.Navigation("FilterListTags");
                });
#pragma warning restore 612, 618
        }
    }
}
