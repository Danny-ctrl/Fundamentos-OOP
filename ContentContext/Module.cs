using System.Collections.Generic;
using grupo.SharedContext;

namespace grupo.ContentContext
{
  public class Module : Base
  {
    public Module()
    {
      Lectures = new List<Lecture>();
    }
    public Module(int order, string title)
    {
      this.Order = order;
      this.Title = title;

    }
    public int Order { get; set; }
    public string Title { get; set; }
    public IList<Lecture> Lectures { get; set; }

  }
}