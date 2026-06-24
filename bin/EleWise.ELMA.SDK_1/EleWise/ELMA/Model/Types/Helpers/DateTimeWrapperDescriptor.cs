// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.DateTimeWrapperDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component(Order = 1000)]
  public class DateTimeWrapperDescriptor : ITypeWrapperDescriptor
  {
    internal static DateTimeWrapperDescriptor AQu2d1bQvFspOf616kXj;

    public Type OriginalType => typeof (DateTime);

    public Type WrapperType => typeof (DateTimeWrapper);

    public object CreateWrapper(object obj) => (object) new DateTimeWrapper((DateTime?) obj);

    public object GetObject(object wrapper) => (object) ((DateTimeWrapper) wrapper).Value;

    public Type[] GenericArgumentsTypes => (Type[]) null;

    public bool TestType(Type type) => false;

    public DateTimeWrapperDescriptor()
    {
      DateTimeWrapperDescriptor.qGgv6CbQu82VeTg3WfOH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool gAwdVqbQ8ADE9Pi7YpZO() => DateTimeWrapperDescriptor.AQu2d1bQvFspOf616kXj == null;

    internal static DateTimeWrapperDescriptor VUttRqbQZUaE9SRO0YdD() => DateTimeWrapperDescriptor.AQu2d1bQvFspOf616kXj;

    internal static void qGgv6CbQu82VeTg3WfOH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
