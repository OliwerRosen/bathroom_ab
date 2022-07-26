using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
  public class ArticleCategory
  {
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public ICollection<Article>? Articles { get; set; }
  }
}