using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
  public class Review
  {
    public int Id { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = "";
  }
}