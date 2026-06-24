// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Hubs.Attributes.HubNameAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Hubs.Attributes
{
  /// <summary>
  /// Атрибут, позволяющий задавать произвольное имя для хаба
  /// </summary>
  [AttributeUsage(AttributeTargets.Class, Inherited = false)]
  public sealed class HubNameAttribute : Attribute
  {
    internal static HubNameAttribute g8X17bh5RB8cVhV0E6wC;

    public HubNameAttribute(string hubName)
    {
      HubNameAttribute.iUSkRNh5XYNGHosVnOMK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            HubNameAttribute.ehA7XYh5TK9wE67TsKmM((object) hubName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675347229));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          default:
            this.HubName = hubName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public string HubName { get; }

    internal static void iUSkRNh5XYNGHosVnOMK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void ehA7XYh5TK9wE67TsKmM([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static bool PPwlFXh5qu5KKxTNOl0X() => HubNameAttribute.g8X17bh5RB8cVhV0E6wC == null;

    internal static HubNameAttribute rT9tPWh5KB10FlV1t90g() => HubNameAttribute.g8X17bh5RB8cVhV0E6wC;
  }
}
