﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Appointo.Entity
{
  public class DBhelper
  {
    private DataEntityModelContainer db = new DataEntityModelContainer();

    public void ViewAppointments()
    {
      db.Appointments.ToList();
    }

    public void AddAppointment (DateTime Aptdate, int Time, string Aptreason)
    {
      db.Appointments.Add(new Appointment { Date = Aptdate, Duration = Time, Reason = Aptreason });
      db.SaveChanges();
    }

    public void ViewDoctors()
    {
      db.Doctors.ToList();
    }

    public void AddDoctors(string FName, string LName, Specialty specialty)
    {
      db.Doctors.Add(new Doctor { FirstName = FName, LastName = LName, Specialty = specialty });
      db.SaveChanges();
    }

    public void ViewLocations()
    {
      db.Locations.ToList();
    }

    public void AddLocations(int num)
    {
      db.Locations.Add(new Location { RoomNumber = num });
      db.SaveChanges();
    }

    public void ViewAddress()
    {
      db.Addresses.ToList();
    }

    public void AddAddress(string AddL1, string AddL2, string cit, string st, string zip)
    {
      db.Addresses.Add(new Address { AddressLine1 = AddL1, AddressLine2 = AddL2, City = cit, State = st, ZipCode = zip });
      db.SaveChanges();
    }

    public void ViewPatients()
    {
      db.Patients.ToList();
    }

    public void AddPatients(string FName, string LName, string DOB, int Add)
    {
      db.Patients.Add(new Patient { FirstName = FName, LastName = LName, DateOfBirth = DOB, AddressId = Add });
      db.SaveChanges();
    }

    public void ViewReceptionist()
    {
      db.Receptionists.ToList();
    }

    public void AddReceptionist(int Log, string FName, string LName)
    {
      db.Receptionists.Add(new Receptionist { LoginId = Log, FirstName = FName, LastName = LName });
      db.SaveChanges();
    }
  }
}