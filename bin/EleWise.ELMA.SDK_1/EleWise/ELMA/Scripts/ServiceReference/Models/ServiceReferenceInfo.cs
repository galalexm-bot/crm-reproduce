// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.ServiceReference.Models.ServiceReferenceInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Scripts.ServiceReference.Models
{
  /// <summary>Информация о веб-сервисе</summary>
  public sealed class ServiceReferenceInfo
  {
    private static ServiceReferenceInfo NyEHmQWBZHusRcpLSGyV;

    /// <summary>Ctor</summary>
    public ServiceReferenceInfo()
    {
      ServiceReferenceInfo.ap3WJMWBVFeyZk3nMSBB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.MethodNames = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Имя</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
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

    /// <summary>Имена методов</summary>
    public List<string> MethodNames { get; set; }

    internal static void ap3WJMWBVFeyZk3nMSBB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool EkCcCxWBu6N2PGXobBQu() => ServiceReferenceInfo.NyEHmQWBZHusRcpLSGyV == null;

    internal static ServiceReferenceInfo c67Fg5WBIiChTcOMf7d3() => ServiceReferenceInfo.NyEHmQWBZHusRcpLSGyV;
  }
}
