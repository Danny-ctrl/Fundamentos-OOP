using grupo.ContentContext.Enums;
using grupo.SharedContext;

namespace grupo.ContentContext
{

  public class Lecture : Base
  {

    public int Ordem { get; set; }
    public string Title { get; set; }

    public int DurationInMinutes { get; set; }
    public EcontentLevel Level { get; set; }
  }
}