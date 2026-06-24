// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationPartialExtensionTemplate
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>Частичный шаблон для вставки через метод</summary>
  public class NotificationPartialExtensionTemplate : INotificationPartialTemplate
  {
    internal static NotificationPartialExtensionTemplate Qm1pYBDkNReM2XsvbsL;

    /// <summary>
    /// Список имен зон, в которые должен вставляться данный шаблон
    /// </summary>
    public List<string> Zones { get; set; }

    /// <summary>Содержимое</summary>
    public string Content
    {
      get => this.\u003CContent\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CContent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public NotificationPartialExtensionTemplate()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool YdxhupDnGYO4eVITGOW() => NotificationPartialExtensionTemplate.Qm1pYBDkNReM2XsvbsL == null;

    internal static NotificationPartialExtensionTemplate RnbMJdDOg13B31LmchK() => NotificationPartialExtensionTemplate.Qm1pYBDkNReM2XsvbsL;
  }
}
