// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.MoneyWrapperDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component(Order = 1000)]
  public class MoneyWrapperDescriptor : ITypeWrapperDescriptor
  {
    private static MoneyWrapperDescriptor BG17j1bf6NhsLc0CkIp6;

    public Type OriginalType => MoneyWrapperDescriptor.MutU6ebf7Ys1cZTRbJCt(__typeref (Money));

    public Type WrapperType => MoneyWrapperDescriptor.MutU6ebf7Ys1cZTRbJCt(__typeref (MoneyWrapper));

    public object CreateWrapper(object obj) => (object) new MoneyWrapper((Money) obj);

    public object GetObject(object wrapper) => (object) ((MoneyWrapper) wrapper).Value;

    public Type[] GenericArgumentsTypes => (Type[]) null;

    public bool TestType(Type type) => false;

    public MoneyWrapperDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type MutU6ebf7Ys1cZTRbJCt([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool Dhe8EHbfHm9gCHvdiTic() => MoneyWrapperDescriptor.BG17j1bf6NhsLc0CkIp6 == null;

    internal static MoneyWrapperDescriptor cyqakUbfAh3ie854L1qF() => MoneyWrapperDescriptor.BG17j1bf6NhsLc0CkIp6;
  }
}
