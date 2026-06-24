// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.AutoRegisterUserTypeConvention`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using NHibernate.UserTypes;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>
  /// Автоматически регистрируемое соглашение для пользовательского типа NHibernate
  /// </summary>
  /// <typeparam name="TUserType"></typeparam>
  [Component]
  public class AutoRegisterUserTypeConvention<TUserType> : IAutoRegisterConvention where TUserType : IUserType, new()
  {
    private static object WmORf2WDmiooddNnQPhs;

    public AutoRegisterUserTypeConvention()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool RGmaHEWDyfM3wQSTDmHY() => AutoRegisterUserTypeConvention<TUserType>.WmORf2WDmiooddNnQPhs == null;

    internal static object FkFtMSWDMJuh0DQUVBdi() => AutoRegisterUserTypeConvention<TUserType>.WmORf2WDmiooddNnQPhs;
  }
}
