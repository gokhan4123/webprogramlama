﻿using System;
using System.Collections.Generic;
using System.Text;
using HayvanBarinagiCalisma.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HayvanBarinagiCalisma.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Hayvan> Hayvan { get; set; }
        public DbSet<Tur> Tur { get; set; }
        public DbSet<Cins> Cins { get; set; }
        public DbSet<Bolum> Bolum { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // any unique string id
            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";

            const string ADMIN_ID2 = "a18be9c0-aa65-4af8-bd17-00bd9344e576";
            const string ADMIN_ID3 = "a18be9c0-aa65-4af8-bd17-00bd9344e577";

            const string ROLE_ID = "1";
            const string ROLE_ID2 = "2";

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ROLE_ID,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = ROLE_ID2,
                    Name = "Uye",
                    NormalizedName = "UYE"
                }
            );

            var hasher = new PasswordHasher<CustomUser>();
            builder.Entity<CustomUser>().HasData(
                new CustomUser
                {
                    Id = ADMIN_ID,
                    UserName = "g161210381@sakarya.edu.tr",
                    NormalizedUserName = "g161210381@SAKARYA.EDU.TR",
                    Email = "g161210381@sakarya.edu.tr",
                    NormalizedEmail = "g161210381@@SAKARYA.EDU.TR",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123"),
                    SecurityStamp = string.Empty
                },
                new CustomUser
                {
                    Id=ADMIN_ID2,
                    UserName= "U161210061@SAKARYA.EDU.TR",
                    NormalizedUserName = "U161210061@SAKARYA.EDU.TR",
                    Email = "U161210061@SAKARYA.EDU.TR",
                    NormalizedEmail = "U161210061@SAKARYA.EDU.TR",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123"),
                    SecurityStamp = string.Empty
                }
               
            );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ROLE_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = ROLE_ID,
                    UserId = ADMIN_ID2
                },
                new IdentityUserRole<string>
                {
                    RoleId = ROLE_ID,
                    UserId = ADMIN_ID3
                }
                );
        }
    }
}
