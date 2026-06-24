// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.TimeSpanWrapperDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component(Order = 1000)]
  public class TimeSpanWrapperDescriptor : ITypeWrapperDescriptor
  {
    private static TimeSpanWrapperDescriptor HRd3cbbbny5kaGXvkiFs;

    public Type OriginalType => TimeSpanWrapperDescriptor.cJhCxAbbe2qwsU75bXhH(__typeref (TimeSpan));

    public Type WrapperType => TimeSpanWrapperDescriptor.cJhCxAbbe2qwsU75bXhH(__typeref (TimeSpanWrapper));

    public object CreateWrapper(object obj) => (object) new TimeSpanWrapper((TimeSpan?) obj);

    public object GetObject(object wrapper) => (object) ((TimeSpanWrapper) wrapper).Value;

    public Type[] GenericArgumentsTypes => (Type[]) null;

    public bool TestType(Type type) => false;

    public TimeSpanWrapperDescriptor()
    {
      TimeSpanWrapperDescriptor.CUJk6ObbPnhufhdIGj9t();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type cJhCxAbbe2qwsU75bXhH([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool tdrjJLbbOxqnI5wQXfA6() => TimeSpanWrapperDescriptor.HRd3cbbbny5kaGXvkiFs == null;

    internal static TimeSpanWrapperDescriptor FKYRZDbb2k4797MGt0k5() => TimeSpanWrapperDescriptor.HRd3cbbbny5kaGXvkiFs;

    internal static void CUJk6ObbPnhufhdIGj9t() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
