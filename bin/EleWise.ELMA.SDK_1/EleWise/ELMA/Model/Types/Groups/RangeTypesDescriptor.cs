// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Groups.RangeTypesDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Groups
{
  /// <summary>Группа типов "Диапазоны"</summary>
  public class RangeTypesDescriptor : TypesGroupDescriptor
  {
    /// <summary>Uid группы</summary>
    public const string UID_S = "{66F80085-FD42-4840-9155-B20F2E947A22}";
    /// <summary>Uid группы</summary>
    public static readonly Guid UID;
    private static RangeTypesDescriptor thlJGmorkO0CsGVcN1Uc;

    /// <summary>Uid группы</summary>
    public override Guid Uid => RangeTypesDescriptor.UID;

    /// <summary>Имя "Диапазоны"</summary>
    public override string Name => (string) RangeTypesDescriptor.pMuBo4or2604xJY9vlV6((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334886965));

    public RangeTypesDescriptor()
    {
      RangeTypesDescriptor.XqtkcDoreQjjmBBex7hs();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static RangeTypesDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            RangeTypesDescriptor.XqtkcDoreQjjmBBex7hs();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            RangeTypesDescriptor.UID = new Guid((string) RangeTypesDescriptor.mG79KTorPnLr5JKD6UAb(-1998538950 ^ -1998448928));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object pMuBo4or2604xJY9vlV6([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool qRfZN7ornXyiMPVnUw11() => RangeTypesDescriptor.thlJGmorkO0CsGVcN1Uc == null;

    internal static RangeTypesDescriptor sugBSLorOw5KD6Pf5GWr() => RangeTypesDescriptor.thlJGmorkO0CsGVcN1Uc;

    internal static void XqtkcDoreQjjmBBex7hs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object mG79KTorPnLr5JKD6UAb(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
