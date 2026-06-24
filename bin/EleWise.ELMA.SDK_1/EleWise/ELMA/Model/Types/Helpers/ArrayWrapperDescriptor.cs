// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.ArrayWrapperDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component(Order = 1000)]
  public class ArrayWrapperDescriptor : ITypeWrapperDescriptor
  {
    internal static ArrayWrapperDescriptor yDEDOMbhrAUMLPWmQKAv;

    public Type OriginalType => ArrayWrapperDescriptor.m8kuI5bhjeYCKH8bCO9Q(__typeref (Array));

    public Type WrapperType => ArrayWrapperDescriptor.m8kuI5bhjeYCKH8bCO9Q(__typeref (ArrayWrapper));

    public object CreateWrapper(object obj) => (object) new ArrayWrapper((ICollection) obj);

    public object GetObject(object wrapper)
    {
      int num = 1;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ArrayWrapperDescriptor.vpK1nxbhYLdfSew1EDhw((object) (ArrayWrapper) wrapper) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 2:
            goto label_7;
          case 3:
            str = ((ArrayWrapper) wrapper).Value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 2;
            continue;
          default:
            if (ArrayWrapperDescriptor.pBS2MYbhUdNdQSIYBPig(ArrayWrapperDescriptor.XKWe1MbhLgehmh3SOq4D((object) (ArrayWrapper) wrapper)))
            {
              num = 3;
              continue;
            }
            goto label_8;
        }
      }
label_7:
      return ArrayWrapperDescriptor.iU4tJLbhsWmWAOigpJqd(ReflectionType.GetType((string) ArrayWrapperDescriptor.XKWe1MbhLgehmh3SOq4D((object) (ArrayWrapper) wrapper)), (object) str);
label_8:
      return (object) null;
    }

    public Type[] GenericArgumentsTypes => (Type[]) null;

    public bool TestType(Type type) => ArrayWrapperDescriptor.m8kuI5bhjeYCKH8bCO9Q(__typeref (Array)).IsAssignableFrom(type);

    public ArrayWrapperDescriptor()
    {
      ArrayWrapperDescriptor.KhvOLPbhcxdJVTBVe9CT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type m8kuI5bhjeYCKH8bCO9Q([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool WB2NDjbhgwGyXI8qnCKf() => ArrayWrapperDescriptor.yDEDOMbhrAUMLPWmQKAv == null;

    internal static ArrayWrapperDescriptor HresPZbh5pCwqwf32lgm() => ArrayWrapperDescriptor.yDEDOMbhrAUMLPWmQKAv;

    internal static object vpK1nxbhYLdfSew1EDhw([In] object obj0) => (object) ((ArrayWrapper) obj0).Value;

    internal static object XKWe1MbhLgehmh3SOq4D([In] object obj0) => (object) ((ArrayWrapper) obj0).ArrayTypeName;

    internal static bool pBS2MYbhUdNdQSIYBPig([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object iU4tJLbhsWmWAOigpJqd(Type typeObject, [In] object obj1) => ClassSerializationHelper.DeserializeObjectByJson(typeObject, (string) obj1);

    internal static void KhvOLPbhcxdJVTBVe9CT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
