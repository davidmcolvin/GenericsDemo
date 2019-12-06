using System;

namespace ConsoleUI
{
  internal class LogEntry
  {
    public string Message { get; internal set; }
    public int ErrorCode { get; internal set; }
    public DateTime TimeOfEvent { get; set; } = DateTime.UtcNow;
  }
}