// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.DependencyServiceOptions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>Настройки для анализа зависимостей</summary>
  public sealed class DependencyServiceOptions
  {
    internal static DependencyServiceOptions Ct3joabCcmXjyf5vIEND;

    /// <summary>Пропускать ли зависимости из текущего модуля</summary>
    public bool SkipCurrentModule
    {
      get => this.\u003CSkipCurrentModule\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CSkipCurrentModule\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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

    public DependencyServiceOptions()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: reference to a compiler-generated field
      this.\u003CSkipCurrentModule\u003Ek__BackingField = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool KM849AbCzaJv0Fysg7QX() => DependencyServiceOptions.Ct3joabCcmXjyf5vIEND == null;

    internal static DependencyServiceOptions i4cDe6bvFtvAaH2FDVWL() => DependencyServiceOptions.Ct3joabCcmXjyf5vIEND;
  }
}
