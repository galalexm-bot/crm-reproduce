// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ModuleVersion
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Версия модуля</summary>
  [DataContract]
  [Serializable]
  internal sealed class ModuleVersion
  {
    internal static ModuleVersion la9Dr5bNdkeJ1EJRLAVT;

    /// <summary>Ctor</summary>
    /// <param name="metadata">Метаданные модуля</param>
    /// <param name="header">Заголовок версии модуля</param>
    internal ModuleVersion(ModuleInfoMetadata metadata, ModuleVersionHeader header)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Metadata = metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.Header = header;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Заголовок</summary>
    public ModuleVersionHeader Header { get; }

    /// <summary>Метаданные</summary>
    public ModuleInfoMetadata Metadata { get; }

    /// <summary>Построить версию из элемента</summary>
    /// <param name="item">Элемент метаданных модуля</param>
    /// <returns>Версия модуля</returns>
    internal static ModuleVersion FromItem(ModuleMetadataItem item)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ModuleVersion.tBPLL5bN54DkNJ1BQQxb((object) item, ModuleVersion.MEQXI6bNgq0PoPxO01cm(2045296739 + 1688595713 ^ -561117926));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return new ModuleVersion((ModuleInfoMetadata) ModuleVersion.mYYXbnbNj9MjQ2ehXF4l((object) item), (ModuleVersionHeader) ModuleVersion.fv3rHlbNYcex9xW1CuXG((object) item));
    }

    internal static bool jOdMPsbNl9nMFci8BnUW() => ModuleVersion.la9Dr5bNdkeJ1EJRLAVT == null;

    internal static ModuleVersion J2544TbNrP62Nb2sWFGx() => ModuleVersion.la9Dr5bNdkeJ1EJRLAVT;

    internal static object MEQXI6bNgq0PoPxO01cm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void tBPLL5bN54DkNJ1BQQxb([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object mYYXbnbNj9MjQ2ehXF4l([In] object obj0) => ((ModuleMetadataItem) obj0).Metadata;

    internal static object fv3rHlbNYcex9xW1CuXG([In] object obj0) => (object) ModuleVersionHeader.FromItem((ModuleMetadataItem) obj0);
  }
}
