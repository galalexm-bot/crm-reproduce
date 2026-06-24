// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ModuleNotFoundException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Modules;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>Ошибка если не найден опубликованный модуль</summary>
  [Serializable]
  internal class ModuleNotFoundException : Exception
  {
    private static ModuleNotFoundException rW9KVNGgOwiyH4A9KKAJ;

    /// <summary>Ctor</summary>
    /// <param name="moduleUid">Идентификатор модуля</param>
    public ModuleNotFoundException(Guid moduleUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(moduleUid, string.Empty);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="moduleUid">Идентификатор модуля</param>
    /// <param name="disabledReason">Причина отключения модуля</param>
    public ModuleNotFoundException(Guid moduleUid, ModuleDisabledReason disabledReason)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(moduleUid, EleWise.ELMA.SR.T((string) ModuleNotFoundException.i4ViPuGgPlA6DMk8QvQB(-1380439818 << 3 ^ 1841648282)));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.DisabledReason = disabledReason;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="moduleUid">Идентификатор модуля</param>
    /// <param name="additionalInfo">Дополнительная информация</param>
    public ModuleNotFoundException(Guid moduleUid, string additionalInfo)
    {
      ModuleNotFoundException.MCWmlTGg16PfjXoMxYcp();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082141760), (object) moduleUid));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.AdditionalInformation = additionalInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override string ToString()
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = string.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 2:
            str = (string) ModuleNotFoundException.jW6IqNGg3fMtqg5hCDoR((object) str, ModuleNotFoundException.i4ViPuGgPlA6DMk8QvQB(1218962250 ^ 1218947688), (object) this.AdditionalInformation);
            num = 6;
            continue;
          case 3:
            str += EleWise.ELMA.SR.T((string) ModuleNotFoundException.i4ViPuGgPlA6DMk8QvQB(~210725948 ^ -210467251), (object) this.DisabledReason);
            num = 4;
            continue;
          case 4:
          case 5:
            if (!ModuleNotFoundException.CwIvP0GgNlrdqEUBNIek((object) this.AdditionalInformation))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 2 : 2;
              continue;
            }
            goto label_3;
          case 6:
            goto label_3;
          default:
            if (this.DisabledReason == ModuleDisabledReason.Unknown)
            {
              num = 5;
              continue;
            }
            goto case 3;
        }
      }
label_3:
      return (string) ModuleNotFoundException.jW6IqNGg3fMtqg5hCDoR((object) str, ModuleNotFoundException.i4ViPuGgPlA6DMk8QvQB(87862435 ^ 87876993), ModuleNotFoundException.NbPfQvGgp3MZY67TUWID((object) this));
    }

    /// <summary>Причина отключения модуля</summary>
    public ModuleDisabledReason DisabledReason { get; }

    /// <summary>Дополнительная информация об ошибке</summary>
    public string AdditionalInformation { get; }

    internal static bool qa0yeKGg2LmiIP0iRIe8() => ModuleNotFoundException.rW9KVNGgOwiyH4A9KKAJ == null;

    internal static ModuleNotFoundException GfwgwkGgeIIV0w9Tgb5t() => ModuleNotFoundException.rW9KVNGgOwiyH4A9KKAJ;

    internal static object i4ViPuGgPlA6DMk8QvQB(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void MCWmlTGg16PfjXoMxYcp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool CwIvP0GgNlrdqEUBNIek([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object jW6IqNGg3fMtqg5hCDoR([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object NbPfQvGgp3MZY67TUWID([In] object obj0) => (object) __nonvirtual (((Exception) obj0).ToString());
  }
}
