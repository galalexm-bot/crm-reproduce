// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Groups.SystemTypesDescriptor
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
  [Component(Order = 700)]
  public class SystemTypesDescriptor : TypesGroupDescriptor
  {
    /// <summary>Uid группы</summary>
    public const string UID_S = "{8E69E7B8-EBD1-41FC-ADE0-E44084861B85}";
    /// <summary>Uid группы</summary>
    public static readonly Guid UID;
    private static SystemTypesDescriptor SjGLfoor1gMsYu9g7BRs;

    /// <summary>Uid группы</summary>
    public override Guid Uid => SystemTypesDescriptor.UID;

    /// <summary>Имя "Простые"</summary>
    public override string Name => (string) SystemTypesDescriptor.SepbeyorpLEl2VjXLgqX((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811869596));

    public SystemTypesDescriptor()
    {
      SystemTypesDescriptor.DcmLNforaw3wDG6cWwgv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static SystemTypesDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            SystemTypesDescriptor.DcmLNforaw3wDG6cWwgv();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            SystemTypesDescriptor.UID = new Guid((string) SystemTypesDescriptor.u4OogyorDW6ZPhr8LDOF(1574260816 ^ 1574433296));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object SepbeyorpLEl2VjXLgqX([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool gG45wForNyXUTINsxl7d() => SystemTypesDescriptor.SjGLfoor1gMsYu9g7BRs == null;

    internal static SystemTypesDescriptor kX7UUjor30hjwSdv0VR2() => SystemTypesDescriptor.SjGLfoor1gMsYu9g7BRs;

    internal static void DcmLNforaw3wDG6cWwgv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object u4OogyorDW6ZPhr8LDOF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
