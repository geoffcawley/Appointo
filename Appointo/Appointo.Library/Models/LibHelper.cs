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
    private static List<Rooms> Rooms;
    private static List<Patient> Patients;
    private static List<Address> Addresses;
    private static List<Receptionist> Receptionists;
    

    //might be good to make this a singleton deal, but doesn't matter for now given time constraints
    public LibHelper()
    {
    }

    public List<Appointment> ViewAppointments()
    {
      List<DB.Appointments> dblist = dbhelper.ViewAppointments();
      Appointments = new List<Appointment>();
      foreach (var item in dblist)
      {
        Appointments.Add(new Appointment(item));
      }
      return Appointments;
    }

    //there needs to be some logic in here to avoid overlap
    public void AddAppointment(DateTime Aptdate, DB.Duration Time, string Aptreason)
    {
      dbhelper.AddAppointment(Aptdate, Time, Aptreason);
    }

    public List<Rooms> ViewRooms()
    {
      List<DB.Rooms> dblist = dbhelper.ViewRooms();
      Rooms = new List<Rooms>();
      foreach (var item in dblist)
      {
        Rooms.Add(new Rooms(item));
      }
      return Rooms;
    }

    public void AddRoom(int num)
    {
      dbhelper.AddRoom(num);
    }

        public List<Doctor> ViewDoctors()
        {
            List<DB.Doctors> dblist = dbhelper.ViewDoctors();
            Doctors = new List<Doctor>();
            foreach (var item in dblist)
            {
                Doctors.Add(new Doctor(item));
            }
            return Doctors;
              
        }

        public void AddDoctors(string FName, string LName, DB.Specialty specialty)
        {
            dbhelper.AddDoctors(FName, LName, specialty);
        }



    public List<Address> ViewAddress()
    {
      List<DB.Addresses> dblist = dbhelper.ViewAddress();
      Addresses = new List<Address>();
      foreach (var item in dblist)
      {
        Addresses.Add(new Address(item));
      }
      return Addresses;
    }

    public void AddAddress(string AddL1, string AddL2, string cit, string st, int zip)
    {
      dbhelper.AddAddress(AddL1, AddL2, cit, st, zip);
    }

    public void AddAddress(string AddL1, string cit, string st, int zip)
    {
      dbhelper.AddAddress(AddL1, cit, st, zip);
    }

    public List<Patient> ViewPatients()
    {
      List<DB.Patients> dblist = dbhelper.ViewPatients();
      Patients = new List<Patient>();
      foreach (var item in dblist)
      {
        Patients.Add(new Patient(item));
      }
      return Patients;
    }

    public void AddPatients(string FName, string LName, int DOB, int Add)
    {
      dbhelper.AddPatients( FName, LName, DOB, Add );
    }

    public List<Receptionist> ViewReceptionist()
    {
      List<DB.Receptionists> dblist = dbhelper.ViewReceptionist();
      Receptionists = new List<Receptionist>();
      foreach (var item in dblist)
      {
        Receptionists.Add(new Receptionist(item));
      }
      return Receptionists;
    }

    public void AddReceptionist(int Log, string FName, string LName)
    {
      dbhelper.AddReceptionist( Log, FName, LName );
    }

    public void AddDoctorPatientAppointment(int doc, int apt, int pat)
    {
      dbhelper.AddDoctorPatientAppointment( doc, apt, pat);
    }
  }
}