using HospitalMenegment.DAL.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Formats.Asn1.AsnWriter;

namespace HospitalManagement.WebAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts)
        {

        }
        public DbSet<Appointment> appointments { get; set; }
        public DbSet<Doctor> doctors { get; set; }

        public DbSet<Hospital> hospitals { get; set; }
        public DbSet<Medicine> medicines { get; set; }
        public DbSet<Nurse> nurses { get; set; }
        public DbSet<Patient> patients { get; set; }
    }
}
