using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointo.Data.Models
{
	public class AppointoContext : DbContext
	{
		public AppointoContext() : base()
		{

		}

		public DbSet<Patient> Patients { get; set; }
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Receptionist> Receptionists { get; set; }
		public DbSet<PatientAppointment> PatientAppointments { get; set; }
		public DbSet<Appointment> Appointments { get; set; }
		public DbSet<Location> Locations { get; set; }
		public DbSet<DoctorAppointment> DoctorAppointments { get; set; }
		public DbSet<Login> Logins { get; set; }
	}
}
