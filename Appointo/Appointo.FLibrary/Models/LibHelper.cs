using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using System.Data.Common;
using DB = Appointo.Entity;


/************************************************
 * This will be more or less a duplicate of the DBhelper just so that core projects have something to talk to.
 * 
 * 
 * *********************************************/

namespace Appointo.Library.Models
{
	public class LibHelper
	{
		private static DB.DBhelper dbhelper = new DB.DBhelper();
		private static List<Appointment> Appointments;
		private static List<Doctor> Doctors;
		private static List<Location> Locations;

		//might be good to make this a singleton deal, but doesn't matter for now given time constraints
		public LibHelper()
		{
		}

		public List<Appointment> ViewAppointments()
		{
			List<DB.Appointment> dblist = dbhelper.ViewAppointments();
			Appointments = new List<Appointment>();
			foreach (var item in dblist)
			{
				Appointments.Add(new Appointment(item));
			}
			return Appointments;
		}

		//there needs to be some logic in here to avoid overlap
		public void AddAppointment(DateTime Aptdate, int Time, string Aptreason)
		{
			dbhelper.AddAppointment(Aptdate, Time, Aptreason);
		}

		public List<Location> ViewLocations()
		{
			List<DB.Location> dblist = dbhelper.ViewLocations();
			Locations = new List<Location>();
			foreach (var item in dblist)
			{
				Locations.Add(new Location(item));
			}
			return Locations;
		}

		public void AddLocation(int num)
		{
			dbhelper.AddLocation(num);
		}

//The rest of this should look like the location thing above

		//public List<Doctor> ViewDoctors()
		//{
		//	return db.Doctors.ToList();
		//}

		//public void AddDoctors(string FName, string LName, Specialty specialty)
		//{
		//	db.Doctors.Add(new Doctor { FirstName = FName, LastName = LName, Specialty = specialty });
		//	db.SaveChanges();
		//}

		

		//public List<Address> ViewAddress()
		//{
		//	return db.Addresses.ToList();
		//}

		//public void AddAddress(string AddL1, string AddL2, string cit, string st, string zip)
		//{
		//	db.Addresses.Add(new Address { AddressLine1 = AddL1, AddressLine2 = AddL2, City = cit, State = st, ZipCode = zip });
		//	db.SaveChanges();
		//}

		//public List<Patient> ViewPatients()
		//{
		//	return db.Patients.ToList();
		//}

		//public void AddPatients(string FName, string LName, string DOB, int Add)
		//{
		//	db.Patients.Add(new Patient { FirstName = FName, LastName = LName, DateOfBirth = DOB, AddressId = Add });
		//	db.SaveChanges();
		//}

		//public List<Receptionist> ViewReceptionist()
		//{
		//	return db.Receptionists.ToList();
		//}

		//public void AddReceptionist(int Log, string FName, string LName)
		//{
		//	db.Receptionists.Add(new Receptionist { LoginId = Log, FirstName = FName, LastName = LName });
		//	db.SaveChanges();
		//}

		//public void AddDoctorPatientAppointment(int doc, int apt, int pat)
		//{
		//	db.DoctorPatientAppointments.Add(new DoctorPatientAppointment { DoctorId = doc, AppointmentId = apt, PatientId = pat });
		//	db.SaveChanges();
		//}
	}
}