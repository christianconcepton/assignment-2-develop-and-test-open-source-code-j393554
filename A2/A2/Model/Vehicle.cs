﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2
{
  public class Vehicle
  {
    public int Id { get; private set; }
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public int MakeYear { get; set; }
    public string RegistrationNumber { get; set; }
    public double TankCapacity { get; set; }
    public int Odometer { get; set; }
    public int ServiceLimit = 10000;
    public string Name
    {
      get
      {
        string name = "";

        if ( Manufacturer != "" )
        {
          name += Manufacturer;

          if ( Model != "" )
          {
            name += " " + Model;
            name += " (" + MakeYear.ToString() + ")";
          }
        }

        return name;
      }
    }

    public Vehicle( int id )
    {
      Id = id;
    }

    public int TotalDistanceTraveled( ObservableCollection<Journey> journeys )
    {
      int distanceTravelledByJourneys = 0;
      int vehicleOdometer = Odometer;

      foreach ( Journey journey in journeys )
      {
        distanceTravelledByJourneys += journey.Distance;
      }

      return vehicleOdometer + distanceTravelledByJourneys;
    }
  }
}