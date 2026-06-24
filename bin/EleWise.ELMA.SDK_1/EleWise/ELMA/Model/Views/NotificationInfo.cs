// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.NotificationInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Информация об уведомлении</summary>
  public sealed class NotificationInfo
  {
    internal static NotificationInfo vwnGtUoRBqpKWjTgaVbY;

    /// <summary>Ctor</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="type">Тип уведомления</param>
    public NotificationInfo(string message, NotificationType type)
    {
      NotificationInfo.Jf7TWToRboYmK9uFvFfB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Message = message;
            num = 2;
            continue;
          case 2:
            this.Type = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Сообщение</summary>
    public string Message { get; }

    /// <summary>Тип уведомления</summary>
    public NotificationType Type { get; }

    internal static void Jf7TWToRboYmK9uFvFfB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool YHeHefoRWSVaPLdvwfVN() => NotificationInfo.vwnGtUoRBqpKWjTgaVbY == null;

    internal static NotificationInfo FN2J3HoRoHw163XHvQQb() => NotificationInfo.vwnGtUoRBqpKWjTgaVbY;
  }
}
