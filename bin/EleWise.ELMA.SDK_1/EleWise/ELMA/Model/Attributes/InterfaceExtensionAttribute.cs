// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.InterfaceExtensionAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут указывает, что для этот интерфейс является расширением указанного интерфейса
  /// </summary>
  [AttributeUsage(AttributeTargets.Interface)]
  public class InterfaceExtensionAttribute : Attribute
  {
    private Type extendedInterfaceType;
    internal static InterfaceExtensionAttribute CqfBZwov7rU4HhcjY6wv;

    /// <summary>Ctor</summary>
    /// <param name="extendedInterfaceType">Тип расширяемого интерфейса</param>
    public InterfaceExtensionAttribute(Type extendedInterfaceType)
    {
      InterfaceExtensionAttribute.WDvTJfovm7XhiVWdJjD2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            InterfaceExtensionAttribute.GLZCR0ovyPIOn44WP7rA((object) extendedInterfaceType, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574373506));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
            continue;
          default:
            this.extendedInterfaceType = extendedInterfaceType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип расширяемого интерфейса</summary>
    public Type ExtendedInterfaceType => this.extendedInterfaceType;

    internal static void WDvTJfovm7XhiVWdJjD2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void GLZCR0ovyPIOn44WP7rA([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool satmZlovxrVcfrvgMKCS() => InterfaceExtensionAttribute.CqfBZwov7rU4HhcjY6wv == null;

    internal static InterfaceExtensionAttribute TeAA7Mov0rKxE6MxRDA5() => InterfaceExtensionAttribute.CqfBZwov7rU4HhcjY6wv;
  }
}
