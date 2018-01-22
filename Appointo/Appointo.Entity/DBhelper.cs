using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Appointo.Entity
{
  public class DBhelper
  {
    private AppointoDBContext db = new AppointoDBContext();

    public List<Appointments> ViewAppointments()
    {
      return db.Appointments.ToList();
    }

    public void AddAppointment(DateTime Aptdate, Duration Time, string Aptreason)
    {
      db.Appointments.Add(new Appointments { Date = Aptdate, Duration = Time, Reason = Aptreason });
      db.SaveChanges();
    }

    public List<Doctors> ViewDoctors()
    {
      return db.Doctors.ToList();
    }

    public void AddDoctors(string FName, string LName, Specialty specialty)
    {
      db.Doctors.Add(new Doctors { FirstName = FName, LastName = LName, Specialty = specialty });
      db.SaveChanges();
    }

    public List<Rooms> ViewRooms()
    {
      return db.Rooms.ToList();
    }

    public void AddRoom(int num)
    {
      db.Rooms.Add(new Rooms { RoomNum = num });
      db.SaveChanges();
    }

    public List<Addresses> ViewAddress()
    {
      return db.Addresses.ToList();
    }

    public void AddAddress(string AddL1, string AddL2, string cit, string st, int zip)
    {
      db.Addresses.Add(new Addresses { AddressLine1 = AddL1, AddressLine2 = AddL2, City = cit, State = st, ZipCode = zip });
      db.SaveChanges();
    }

    public void AddAddress(string AddL1, string cit, string st, int zip)
    {
      db.Addresses.Add(new Addresses { AddressLine1 = AddL1, City = cit, State = st, ZipCode = zip });
      db.SaveChanges();
    }

    public List<Patients> ViewPatients()
    {
      return db.Patients.ToList();
    }

    public void AddPatients(string FName, string LName, int DOB, int Add)
    {
      db.Patients.Add(new Patients { FirstName = FName, LastName = LName, DateOfBirth = DOB, AddressId = Add });
      db.SaveChanges();
    }

    public List<Receptionists> ViewReceptionist()
    {
      return db.Receptionists.ToList();
    }

    public void AddReceptionist(int Log, string FName, string LName)
    {
      db.Receptionists.Add(new Receptionists { LoginId = Log, FirstName = FName, LastName = LName });
      db.SaveChanges();
    }

    public void AddDoctorPatientAppointment(int doc, int apt, int pat)
    {
      db.DoctorPatientAppointments.Add(new DoctorPatientAppointments { DoctorId = doc, AppointmentId = apt, PatientId = pat });
      db.SaveChanges();
    }

    public List<DoctorPatientAppointments> ViewDoctorPatientAppointments()
    {
      return db.DoctorPatientAppointments.ToList();
    }
  }
}
