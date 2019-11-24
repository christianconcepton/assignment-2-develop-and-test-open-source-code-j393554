﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
  public class Journey
  {
    public int Id { get; private set; }
    private readonly Vehicle vehicle;
    public int VehicleId
    {
      get
      {
        return vehicle.Id;
      }
    }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int StartOdometer { get; set; }
    public int EndOdometer { get; set; }

    public string ExternalStartDate {
      get
      {
        return StartDate.ToString("yyyy-MM-dd HH:mm tt");
      }
    }

    public string ExternalEndDate
    {
      get
      {
        return EndDate.ToString("yyyy-MM-dd HH:mm tt");
      }
    }

    public int Distance
    {
      get
      {
        return EndOdometer - StartOdometer;
      }
    }

    public Journey( int id, Vehicle vehicle )
    {
      this.vehicle = vehicle;
      Id = id;
    }
  }
}