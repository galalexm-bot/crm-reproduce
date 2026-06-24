// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata._NamespaceInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Информация о пространстве имен EleWise.ELMA.Model.Metadata
  /// </summary>
  [Uid("1a970bc7-ef0d-4ff6-a2c9-da06ddd2aec1")]
  [MetadataType(typeof (NamespaceMetadata))]
  internal class _NamespaceInfo : NamespaceInfo
  {
    /// <summary>Уникальный идентификатор данного класса</summary>
    public const string UID_S = "1a970bc7-ef0d-4ff6-a2c9-da06ddd2aec1";
    private static Guid _UID;
    private static _NamespaceInfo EDWt0Jb7AhBRRgkF6UN8;

    /// <summary>Уникальный идентификатор данного класса</summary>
    public static Guid UID => _NamespaceInfo._UID;

    /// <summary>Отображаемое название</summary>
    public override string DisplayName => (string) _NamespaceInfo.t1e6oLb7mQdDAPVRv785(_NamespaceInfo.j8rranb70YdGQZedmxTY(-1978478350 ^ -1978517562));

    public _NamespaceInfo()
    {
      _NamespaceInfo.ATTQhOb7yC69M1rXV2lk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static _NamespaceInfo()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            _NamespaceInfo.ATTQhOb7yC69M1rXV2lk();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            _NamespaceInfo._UID = new Guid((string) _NamespaceInfo.j8rranb70YdGQZedmxTY(-1380439818 << 3 ^ 1841541314));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static object j8rranb70YdGQZedmxTY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object t1e6oLb7mQdDAPVRv785([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool ffah8ib77R033Ux1BgpN() => _NamespaceInfo.EDWt0Jb7AhBRRgkF6UN8 == null;

    internal static _NamespaceInfo fwO6h2b7xYGOhFfytJXR() => _NamespaceInfo.EDWt0Jb7AhBRRgkF6UN8;

    internal static void ATTQhOb7yC69M1rXV2lk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
