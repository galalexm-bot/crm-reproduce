// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.UriWrapperDescriptor
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
  public class UriWrapperDescriptor : ITypeWrapperDescriptor
  {
    internal static UriWrapperDescriptor CM9qRjbbEgEKwnCTJkrR;

    public Type OriginalType => UriWrapperDescriptor.hdRNxvbbC1j5CixULPCj(__typeref (Uri));

    public Type WrapperType => UriWrapperDescriptor.hdRNxvbbC1j5CixULPCj(__typeref (UriWrapper));

    public object CreateWrapper(object obj) => (object) new UriWrapper((Uri) obj);

    public object GetObject(object wrapper) => (object) ((UriWrapper) wrapper).Value;

    public Type[] GenericArgumentsTypes => (Type[]) null;

    public bool TestType(Type type) => false;

    public UriWrapperDescriptor()
    {
      UriWrapperDescriptor.VT1a2RbbvlhS3ubvNNjR();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type hdRNxvbbC1j5CixULPCj([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool LR5OtIbbfYLt0nRu0DhT() => UriWrapperDescriptor.CM9qRjbbEgEKwnCTJkrR == null;

    internal static UriWrapperDescriptor CEqUypbbQL4Ll5w2llBK() => UriWrapperDescriptor.CM9qRjbbEgEKwnCTJkrR;

    internal static void VT1a2RbbvlhS3ubvNNjR() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
