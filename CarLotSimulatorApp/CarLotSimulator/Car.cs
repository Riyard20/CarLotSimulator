﻿using System;

namespace CarLotSimulator;

public class Car
{
   public int Year { get; set; }
   public string Make { get; set; }
   public string Model { get; set; }
   public string EngineNoise { get; set; }
   public string HonkNoise { get; set; }
   public bool isDriveable { get; set; }

   public void MakeEngineNoise(string enginenoise)
   {
      EngineNoise = enginenoise;
      Console.WriteLine($"{Make} {Model} had an noise that sounds like {enginenoise}");
   }

   public void MakeHonkNoise(string honkNoise)
   {
      HonkNoise = honkNoise;
      Console.WriteLine($"{Make} {Model} had a honk noise that sounds like {HonkNoise},");
   }

   public Car()
   {
      
   }

   public Car(string make, string model, int year, bool isDriveable)
   {
      Make = make;
      Model = model;
      year = year;
      isDriveable = isDriveable;
   }
}  