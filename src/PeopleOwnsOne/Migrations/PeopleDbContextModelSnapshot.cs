﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeopleOwnsOne;

namespace PeopleOwnsOne.Migrations
{
    [DbContext(typeof(PeopleDbContext))]
    partial class PeopleDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PeopleOwnsOne.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("PeopleOwnsOne.Person", b =>
                {
                    b.OwnsOne("PeopleOwnsOne.Address", "Address", b1 =>
                        {
                            b1.Property<int>("Id");

                            b1.Property<string>("City");

                            b1.Property<string>("Line1");

                            b1.Property<string>("Line2");

                            b1.Property<string>("State");

                            b1.Property<string>("Zipcode");

                            b1.HasKey("Id");

                            b1.ToTable("Addresses");

                            b1.HasOne("PeopleOwnsOne.Person")
                                .WithOne("Address")
                                .HasForeignKey("PeopleOwnsOne.Address", "Id")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("PeopleOwnsOne.EmailAddress", "EmailAddress", b1 =>
                        {
                            b1.Property<int>("PersonId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Address")
                                .HasColumnName("EmailAddress");

                            b1.HasKey("PersonId");

                            b1.ToTable("People");

                            b1.HasOne("PeopleOwnsOne.Person")
                                .WithOne("EmailAddress")
                                .HasForeignKey("PeopleOwnsOne.EmailAddress", "PersonId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
