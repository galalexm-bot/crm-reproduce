// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.MeansImplicitUseAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Should be used on attributes and causes ReSharper to not mark symbols marked with such attributes
  /// as unused (as well as by other usage inspections)
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
  public sealed class MeansImplicitUseAttribute : Attribute
  {
    internal static MeansImplicitUseAttribute KiOuFdffHQmPdORnijvn;

    public MeansImplicitUseAttribute()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(ImplicitUseKindFlags.Default, ImplicitUseTargetFlags.Default);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
    {
      MeansImplicitUseAttribute.tjaVMkffxevT0c99DD3v();
      // ISSUE: explicit constructor call
      this.\u002Ector(useKindFlags, ImplicitUseTargetFlags.Default);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
    {
      MeansImplicitUseAttribute.tjaVMkffxevT0c99DD3v();
      // ISSUE: explicit constructor call
      this.\u002Ector(ImplicitUseKindFlags.Default, targetFlags);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public MeansImplicitUseAttribute(
      ImplicitUseKindFlags useKindFlags,
      ImplicitUseTargetFlags targetFlags)
    {
      MeansImplicitUseAttribute.tjaVMkffxevT0c99DD3v();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.TargetFlags = targetFlags;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
            continue;
          default:
            this.UseKindFlags = useKindFlags;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    [UsedImplicitly]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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

    [UsedImplicitly]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
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

    internal static bool BH6drfffARxkYj1UfQAq() => MeansImplicitUseAttribute.KiOuFdffHQmPdORnijvn == null;

    internal static MeansImplicitUseAttribute WNkkdkff72Ljfi2GRn3J() => MeansImplicitUseAttribute.KiOuFdffHQmPdORnijvn;

    internal static void tjaVMkffxevT0c99DD3v() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
