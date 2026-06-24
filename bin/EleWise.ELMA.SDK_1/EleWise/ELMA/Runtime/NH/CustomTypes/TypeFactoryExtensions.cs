// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.TypeFactoryExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Extensions.Dynamic;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  public static class TypeFactoryExtensions
  {
    private static readonly System.Type GetNullableTypeWithLengthType;
    private static TypeFactoryExtensions R140bvWmt5GCgsJY2ZhT;

    public static void ReRegisterType(
      IType nhibernateType,
      IEnumerable<string> aliases,
      Func<int, NullableType> ctorLength)
    {
      foreach (string key in new List<string>(aliases)
      {
        nhibernateType.Name
      })
      {
        TypeFactoryExtensions.typeByTypeOfName[key] = nhibernateType;
        object delegatesWithLength = TypeFactoryExtensions.getTypeDelegatesWithLength;
        // ISSUE: reference to a compiler-generated field
        if (TypeFactoryExtensions.\u003C\u003Eo__1.\u003C\u003Ep__0 == null)
        {
          // ISSUE: reference to a compiler-generated field
          TypeFactoryExtensions.\u003C\u003Eo__1.\u003C\u003Ep__0 = CallSite<Action<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323048618), (IEnumerable<System.Type>) null, typeof (TypeFactoryExtensions), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        TypeFactoryExtensions.\u003C\u003Eo__1.\u003C\u003Ep__0.Target((CallSite) TypeFactoryExtensions.\u003C\u003Eo__1.\u003C\u003Ep__0, delegatesWithLength, key);
        // ISSUE: reference to a compiler-generated field
        if (TypeFactoryExtensions.\u003C\u003Eo__1.\u003C\u003Ep__1 == null)
        {
          // ISSUE: reference to a compiler-generated field
          TypeFactoryExtensions.\u003C\u003Eo__1.\u003C\u003Ep__1 = CallSite<Action<CallSite, object, string, Delegate>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121203255), (IEnumerable<System.Type>) null, typeof (TypeFactoryExtensions), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[3]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        TypeFactoryExtensions.\u003C\u003Eo__1.\u003C\u003Ep__1.Target((CallSite) TypeFactoryExtensions.\u003C\u003Eo__1.\u003C\u003Ep__1, delegatesWithLength, key, DelegateExtensions.Cast((Delegate) ctorLength, TypeFactoryExtensions.GetNullableTypeWithLengthType));
      }
    }

    public static void ReRegisterType(
      System.Type systemType,
      IType nhibernateType,
      IEnumerable<string> aliases,
      Func<int, NullableType> ctorLength)
    {
      List<string> aliases1 = new List<string>(aliases);
      aliases1.AddRange(TypeFactoryExtensions.GetClrTypeAliases(systemType));
      TypeFactoryExtensions.ReRegisterType(nhibernateType, (IEnumerable<string>) aliases1, ctorLength);
    }

    public static NullableType GetType(
      NullableType defaultUnqualifiedType,
      int length,
      Func<int, NullableType> ctorDelegate)
    {
      // ISSUE: reference to a compiler-generated method
      return (NullableType) ((IEnumerable<MethodInfo>) typeof (TypeFactory).GetMethods(BindingFlags.Static | BindingFlags.NonPublic)).First<MethodInfo>((Func<MethodInfo, bool>) (m => ((IEnumerable<ParameterInfo>) TypeFactoryExtensions.\u003C\u003Ec.ANIHvZQY7Nwy6YpUhdYT((object) m)).Count<ParameterInfo>() == 3)).Invoke((object) null, new object[3]
      {
        (object) defaultUnqualifiedType,
        (object) length,
        (object) ctorDelegate
      });
    }

    private static IEnumerable<string> GetClrTypeAliases(System.Type systemType) => (IEnumerable<string>) typeof (TypeFactory).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561215902), BindingFlags.Static | BindingFlags.NonPublic).Invoke((object) null, new object[1]
    {
      (object) systemType
    });

    private static ConcurrentDictionary<string, IType> typeByTypeOfName => (ConcurrentDictionary<string, IType>) typeof (TypeFactory).GetField(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234163140), BindingFlags.Static | BindingFlags.NonPublic).GetValue((object) null);

    private static object getTypeDelegatesWithLength => ExposedObject.From(TypeFactoryExtensions.xJqebbWmHMBF7WniRtUo((object) typeof (TypeFactory).GetField((string) TypeFactoryExtensions.CFngsEWm66ILw16LZNsW(-1317790512 ^ -1317652608), BindingFlags.Static | BindingFlags.NonPublic), (object) null));

    static TypeFactoryExtensions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TypeFactoryExtensions.GetNullableTypeWithLengthType = TypeFactoryExtensions.XPLHIGWm7mqfyWwIyBUN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516716674), true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
            continue;
          case 2:
            TypeFactoryExtensions.uoeZgEWmAgQTCTjUj97g();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object CFngsEWm66ILw16LZNsW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object xJqebbWmHMBF7WniRtUo([In] object obj0, [In] object obj1) => ((FieldInfo) obj0).GetValue(obj1);

    internal static bool rGLTUMWmwZrE4PlmJGSa() => TypeFactoryExtensions.R140bvWmt5GCgsJY2ZhT == null;

    internal static TypeFactoryExtensions y3KqaxWm4VBH41scVxVj() => TypeFactoryExtensions.R140bvWmt5GCgsJY2ZhT;

    internal static void uoeZgEWmAgQTCTjUj97g() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static System.Type XPLHIGWm7mqfyWwIyBUN([In] object obj0, [In] bool obj1) => System.Type.GetType((string) obj0, obj1);
  }
}
