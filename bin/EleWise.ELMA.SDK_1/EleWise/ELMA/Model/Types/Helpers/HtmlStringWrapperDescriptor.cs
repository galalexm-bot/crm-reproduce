// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.HtmlStringWrapperDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Web;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component(Order = 1000)]
  public class HtmlStringWrapperDescriptor : ITypeWrapperDescriptor
  {
    internal static HtmlStringWrapperDescriptor X7B3WWbba6BBg4RhA08N;

    public Type OriginalType => HtmlStringWrapperDescriptor.u10x1Kbbw4oeWKvXeeHN(__typeref (HtmlString));

    public Type WrapperType => HtmlStringWrapperDescriptor.u10x1Kbbw4oeWKvXeeHN(__typeref (HtmlStringWrapper));

    public object CreateWrapper(object obj) => (object) new HtmlStringWrapper((HtmlString) obj);

    public object GetObject(object wrapper)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (wrapper is HtmlStringWrapper)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) null;
label_3:
      return HtmlStringWrapperDescriptor.fr0hLqbb4jUXhQDA6vSj((object) (HtmlStringWrapper) wrapper);
    }

    public Type[] GenericArgumentsTypes => (Type[]) null;

    public bool TestType(Type type) => false;

    public HtmlStringWrapperDescriptor()
    {
      HtmlStringWrapperDescriptor.FBMxUmbb6VpCaxk51QYv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type u10x1Kbbw4oeWKvXeeHN([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool LqxGfrbbDY635u2HFsE6() => HtmlStringWrapperDescriptor.X7B3WWbba6BBg4RhA08N == null;

    internal static HtmlStringWrapperDescriptor qBJHRFbbtm8N8yp9xxtr() => HtmlStringWrapperDescriptor.X7B3WWbba6BBg4RhA08N;

    internal static object fr0hLqbb4jUXhQDA6vSj([In] object obj0) => (object) ((HtmlStringWrapper) obj0).Value;

    internal static void FBMxUmbb6VpCaxk51QYv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
