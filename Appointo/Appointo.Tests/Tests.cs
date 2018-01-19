using System;
using Xunit;
using Appointo.Library.Models;

namespace Appointo.Tests
{
  public class Tests
  {
    LibHelper Test = new LibHelper();

    [Fact]
    public void ViewPatients()
    {
      Assert.True(Test.ViewPatients().Count > 1);
    }

    [Fact]
    public void ViewDoctors()
    {
      Assert.True(Test.ViewDoctors().Count > 1);
    }

    [Fact]
    public void ViewAddresses()
    {
      Assert.True(Test.ViewAddress().Count > 1);
    }

    [Fact]
    public void ViewReceptionists()
    {
      Assert.True(Test.ViewReceptionist().Count > 1);
    }

    [Fact]
    public void ViewRooms()
    {
      Assert.True(Test.ViewRooms().Count > 1);
    }

    [Fact]
    public void ViewAppointments()
    {
      Assert.True(Test.ViewAppointments().Count > 1);
    }
  }
}
