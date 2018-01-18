using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Appointo.Entity
{
  public class DBhelper
  {
    private DataEntityModelContainer db = new DataEntityModelContainer();

    public Array ViewAppointments()
    {
      Array Appoint = db.Appointments.ToArray();
      return Appoint;
    }

    public void AddAppointment(DateTime Aptdate, int Time, string Aptreason)
    {
      db.Appointments.Add(new Appointment { Date = Aptdate, Duration = Time, Reason = Aptreason });
      db.SaveChanges();
    }

    public Array ViewDoctors()
    {
      Array Doc = db.Doctors.ToArray();
      return Doc;
    }

    public void AddDoctors(string FName, string LName, Specialty specialty)
    {
      db.Doctors.Add(new Doctor { FirstName = FName, LastName = LName, Specialty = specialty });
      db.SaveChanges();
    }

    public Array ViewLocations()
    {
      Array Room = db.Locations.ToArray();
      return Room;
    }

    public void AddLocations(int num)
    {
      db.Locations.Add(new Location { RoomNumber = num });
      db.SaveChanges();
    }

    public Array ViewAddress()
    {
      Array Address = db.Addresses.ToArray();
      return Address;
    }

    public void AddAddress(string AddL1, string AddL2, string cit, string st, string zip)
    {
      db.Addresses.Add(new Address { AddressLine1 = AddL1, AddressLine2 = AddL2, City = cit, State = st, ZipCode = zip });
      db.SaveChanges();
    }

    public Array ViewPatients()
    {
      Array Patients = db.Patients.ToArray();
      return Patients;
    }

    public void AddPatients(string FName, string LName, string DOB, int Add)
    {
      db.Patients.Add(new Patient { FirstName = FName, LastName = LName, DateOfBirth = DOB, AddressId = Add });
      db.SaveChanges();
    }

    public Array ViewReceptionist()
    {
      Array Reception = db.Receptionists.ToArray();
      return Reception;
    }

    public void AddReceptionist(int Log, string FName, string LName)
    {
      db.Receptionists.Add(new Receptionist { LoginId = Log, FirstName = FName, LastName = LName });
      db.SaveChanges();
    }

    public void AddDoctorPatientAppointment(int doc, int apt, int pat)
    {
      db.DoctorPatientAppointments.Add(new DoctorPatientAppointment { DoctorId = doc, AppointmentId = apt, PatientId = pat });
      db.SaveChanges();
    }
  }
}