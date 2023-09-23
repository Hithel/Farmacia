
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;
    public class UserConfiguration : IEntityTypeConfiguration<User>
        {
            public void Configure(EntityTypeBuilder<User> builder)
            {
                builder.ToTable("User");
    
                builder.Property(p => p.UserName)
                .HasColumnName("username")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();


                builder.Property(p => p.Password)
                .HasColumnName("password")
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

                builder.HasOne(e => e.Persona)
                .WithOne(p => p.User)
                .HasForeignKey<User>(p => p.IdPersonaFk);

                builder.HasOne(p => p.Rol)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.IdRol);


            }
        }
