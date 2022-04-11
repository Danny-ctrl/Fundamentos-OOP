using System;
using grupo.NotificationContext;

namespace grupo.SharedContext
{

  public abstract class Base : Notifiable
  {

    public Base()
    {
      Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
  }
}