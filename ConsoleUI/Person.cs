﻿namespace ConsoleUI
{
  internal class Person
  {
    public string FirstName { get; internal set; }
    public string LastName { get; internal set; }
    public bool IsAlive { get; internal set; } = true;
  }
}