﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
  internal class OriginalTextFileProcessor
  {

    internal static List<Person> LoadPeople(string filePath)
    {
      List<Person> output = new List<Person>();
      Person p;
      var lines = System.IO.File.ReadAllLines(filePath).ToList();

      //Remove the header row
      lines.RemoveAt(0);

      foreach (var line in lines)
      {
        var vals = line.Split(',');
        p = new Person();

        p.FirstName = vals[0];
        p.IsAlive = bool.Parse(vals[1]);
        p.LastName = vals[2];

        output.Add(p);
      }

      return output;
    }


    internal static List<LogEntry> LoadLogs(string filePath)
    {
      List<LogEntry> output = new List<LogEntry>();
      LogEntry log;
      var lines = System.IO.File.ReadAllLines(filePath).ToList();

      //Remove the header row
      lines.RemoveAt(0);

      foreach (var line in lines)
      {
        var vals = line.Split(',');
        log = new LogEntry();

        log.ErrorCode = int.Parse(vals[0]);
        log.Message = vals[1];
        log.TimeOfEvent = DateTime.Parse(vals[2]);

        output.Add(log);
      }

      return output;
    }


    internal static void SavePeople(List<Person> people, string filePath)
    {
      List<string> lines = new List<string>();

      // Add a header row
      lines.Add("FirstName,IsAlive,LastName");

      foreach (var p in people)
      {
        lines.Add($"{p.FirstName},{p.IsAlive},{p.LastName}");
      }

      System.IO.File.WriteAllLines(filePath, lines);
    }


    internal static void SaveLogs(List<LogEntry> logs, string filePath)
    {
      List<string> lines = new List<string>();

      // Add a header row
      lines.Add("ErrorCode,Message,TimeOfEvent");

      foreach (var log in logs)
      {
        lines.Add($"{log.ErrorCode},{log.Message},{log.TimeOfEvent}");
      }

      System.IO.File.WriteAllLines(filePath, lines);
    }
  }
}