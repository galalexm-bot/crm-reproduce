// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Groups.SimpleTypesDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Groups
{
  /// <summary>Группа простых типов данных</summary>
  [Component(Order = 100)]
  public class SimpleTypesDescriptor : TypesGroupDescriptor
  {
    /// <summary>Uid группы</summary>
    public const string UID_S = "{8507516F-C146-4317-8A32-9B164D25885D}";
    /// <summary>Uid группы</summary>
    public static readonly Guid UID;
    private static SimpleTypesDescriptor RLj1VRortLHJxoqoRAbV;

    /// <summary>Uid группы</summary>
    public override Guid Uid => SimpleTypesDescriptor.UID;

    /// <summary>Имя "Простые"</summary>
    public override string Name => (string) SimpleTypesDescriptor.Eoy1nqorHHSjdZFsbTcV(SimpleTypesDescriptor.ASnmC1or6TVnhnmS3dXu(572119659 - -337058038 ^ 909267441));

    /// <summary>Выстраивать ли типы по имени</summary>
    protected override bool OrderTypesByName => false;

    public SimpleTypesDescriptor()
    {
      SimpleTypesDescriptor.zb8pweorAT3Lhve0J03l();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static SimpleTypesDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            SimpleTypesDescriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536632008));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 2:
            SimpleTypesDescriptor.zb8pweorAT3Lhve0J03l();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object ASnmC1or6TVnhnmS3dXu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Eoy1nqorHHSjdZFsbTcV([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool loRqTLorwgfhOqFBNG7L() => SimpleTypesDescriptor.RLj1VRortLHJxoqoRAbV == null;

    internal static SimpleTypesDescriptor USVJ0Uor4XFjndLKoTwX() => SimpleTypesDescriptor.RLj1VRortLHJxoqoRAbV;

    internal static void zb8pweorAT3Lhve0J03l() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
