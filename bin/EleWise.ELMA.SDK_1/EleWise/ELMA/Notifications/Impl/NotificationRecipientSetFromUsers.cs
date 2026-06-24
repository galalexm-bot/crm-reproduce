// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationRecipientSetFromUsers
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>
  /// Набор получателей оповещения из коллекции пользователей
  /// </summary>
  internal sealed class NotificationRecipientSetFromUsers : NotificationRecipientSet
  {
    private readonly IEnumerable<IUser> users;

    /// <summary>Ctor</summary>
    /// <param name="users">Список пользователей для получения оповещений</param>
    public NotificationRecipientSetFromUsers(IEnumerable<IUser> users)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.users = users;
      this.Name = string.Empty;
    }

    /// <inheritdoc />
    public override IEnumerable<object> GetRecipients(INotification notification) => (IEnumerable<object>) this.users;
  }
}
