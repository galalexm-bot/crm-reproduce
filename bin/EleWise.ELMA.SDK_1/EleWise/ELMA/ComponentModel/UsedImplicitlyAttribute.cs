// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.UsedImplicitlyAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Indicates that the marked symbol is used implicitly (e.g. via reflection, in external library),
  /// so this symbol will not be marked as unused (as well as by other usage inspections).
  /// </summary>
  [AttributeUsage(AttributeTargets.All)]
  public sealed class UsedImplicitlyAttribute : Attribute
  {
    private static UsedImplicitlyAttribute JI8P4LfftpIMGJXI4OCI;

    public UsedImplicitlyAttribute()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
    {
      UsedImplicitlyAttribute.yFCQfTff6vr4D5iCwupK();
      // ISSUE: explicit constructor call
      this.\u002Ector(useKindFlags, ImplicitUseTargetFlags.Default);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(ImplicitUseKindFlags.Default, targetFlags);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public UsedImplicitlyAttribute(
      ImplicitUseKindFlags useKindFlags,
      ImplicitUseTargetFlags targetFlags)
    {
      UsedImplicitlyAttribute.yFCQfTff6vr4D5iCwupK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.TargetFlags = targetFlags;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
            continue;
          default:
            this.UseKindFlags = useKindFlags;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    public ImplicitUseKindFlags UseKindFlags
    {
      get => this.\u003CUseKindFlags\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CUseKindFlags\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
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

    public ImplicitUseTargetFlags TargetFlags
    {
      get => this.\u003CTargetFlags\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CTargetFlags\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
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

    internal static bool t8PpI0ffwwpQ4v4DmbIk() => UsedImplicitlyAttribute.JI8P4LfftpIMGJXI4OCI == null;

    internal static UsedImplicitlyAttribute YPCGfXff4E5dn1PMAkLL() => UsedImplicitlyAttribute.JI8P4LfftpIMGJXI4OCI;

    internal static void yFCQfTff6vr4D5iCwupK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
