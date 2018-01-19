namespace Appointo.Entity
{
  using System;
  using System.Runtime.Serialization;

  public enum Duration : int
  {
    Hour = 60,
    [EnumMember(Value = "Half Hour")]
    HalfHour = 30
  }
}