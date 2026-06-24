// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Settings.Events.GlobalSettingsEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Settings.Events
{
  /// <summary>Базовый класс событий глобальной настройки</summary>
  public class GlobalSettingsEventArgs : AuditEventArgs
  {
    protected PropertyInfo property;
    internal static GlobalSettingsEventArgs o8txwtWGwVyW5CJCdBrA;

    public GlobalSettingsEventArgs(PropertyInfo property)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.property = property;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public string Name => (string) GlobalSettingsEventArgs.k93uXLWGHo4uYsyl39u1((object) this.property);

    internal static bool jtJ4LkWG4auVeghSPSUH() => GlobalSettingsEventArgs.o8txwtWGwVyW5CJCdBrA == null;

    internal static GlobalSettingsEventArgs ybFGapWG6evOUQ7EyZgB() => GlobalSettingsEventArgs.o8txwtWGwVyW5CJCdBrA;

    internal static object k93uXLWGHo4uYsyl39u1([In] object obj0) => (object) ((MemberInfo) obj0).Name;
  }
}
