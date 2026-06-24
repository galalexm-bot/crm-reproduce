// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling._NamespaceInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>
  /// Информация о пространстве имен EleWise.ELMA.Scheduling
  /// </summary>
  [MetadataType(typeof (NamespaceMetadata))]
  [Uid("338ff2ea-505b-414a-bfa9-f7d33d2e3b44")]
  internal class _NamespaceInfo : NamespaceInfo
  {
    /// <summary>Уникальный идентификатор данного класса</summary>
    public const string UID_S = "338ff2ea-505b-414a-bfa9-f7d33d2e3b44";
    private static Guid _UID;
    private static _NamespaceInfo nLaqGlBKgeQAmeZyBoSK;

    /// <summary>Уникальный идентификатор данного класса</summary>
    public static Guid UID => _NamespaceInfo._UID;

    /// <summary>Отображаемое название</summary>
    public override string DisplayName => EleWise.ELMA.SR.T((string) _NamespaceInfo.l9mLgPBKYSujaH0QZUds(654297945 ^ 654241757));

    public _NamespaceInfo()
    {
      _NamespaceInfo.UcKNwABKLsjnNgoangP0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
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
            _NamespaceInfo.UcKNwABKLsjnNgoangP0();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            _NamespaceInfo._UID = new Guid((string) _NamespaceInfo.l9mLgPBKYSujaH0QZUds(-1921202237 ^ -1921129635));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object l9mLgPBKYSujaH0QZUds(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool k4uDUWBK5i5BbciyBgsL() => _NamespaceInfo.nLaqGlBKgeQAmeZyBoSK == null;

    internal static _NamespaceInfo BwLOxwBKj52TE7LeOIhh() => _NamespaceInfo.nLaqGlBKgeQAmeZyBoSK;

    internal static void UcKNwABKLsjnNgoangP0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
