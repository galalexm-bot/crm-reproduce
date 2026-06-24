// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Attributes.FeatureFlagManagedAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ActorModel.Attributes
{
  /// <summary>
  /// Атрибут, указывающий что активация актора на узле фермы управляется за счет флага функций
  /// </summary>
  [AttributeUsage(AttributeTargets.Interface)]
  public sealed class FeatureFlagManagedAttribute : Attribute
  {
    private static FeatureFlagManagedAttribute UBTNw8fDGeKDhONlSPx6;

    /// <summary>Ctor</summary>
    /// <param name="featureFlagName">Название флага функций</param>
    /// <param name="defaultEnabled">Значение флага по умолчанию</param>
    public FeatureFlagManagedAttribute(string featureFlagName, bool defaultEnabled)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.DefaultEnabled = defaultEnabled;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.FeatureFlagName = featureFlagName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Название флага функций</summary>
    public string FeatureFlagName { get; }

    /// <summary>Значение флага по умолчанию</summary>
    public bool DefaultEnabled { get; }

    internal static bool L42LBffDEAugflCuQZbt() => FeatureFlagManagedAttribute.UBTNw8fDGeKDhONlSPx6 == null;

    internal static FeatureFlagManagedAttribute KicjtgfDfFkvqxflBqEU() => FeatureFlagManagedAttribute.UBTNw8fDGeKDhONlSPx6;
  }
}
