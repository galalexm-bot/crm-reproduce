// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.UseImplementationTypeAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Указывает для свойства автореализуемых интерфейсов, что в реализации должен браться тип реализации свойства (т.е. если в интерфейсе тип свойства IUser - в реализации будет User)
  /// </summary>
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Parameter)]
  public class UseImplementationTypeAttribute : Attribute
  {
    private static UseImplementationTypeAttribute J9PEpGoQK5cn3etp0BgY;

    public UseImplementationTypeAttribute()
    {
      UseImplementationTypeAttribute.P8qr8loQkW0LgZ6eKJNK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void P8qr8loQkW0LgZ6eKJNK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool tZHVoooQX7G94CNdZbc7() => UseImplementationTypeAttribute.J9PEpGoQK5cn3etp0BgY == null;

    internal static UseImplementationTypeAttribute Sh4E5xoQThN2PXJrm2PJ() => UseImplementationTypeAttribute.J9PEpGoQK5cn3etp0BgY;
  }
}
