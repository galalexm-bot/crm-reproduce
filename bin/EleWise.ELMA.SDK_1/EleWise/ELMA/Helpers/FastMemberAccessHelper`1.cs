// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.FastMemberAccessHelper`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Reflection.Emit;

namespace EleWise.ELMA.Helpers
{
  /// <summary>
  /// Утилитарный класс для быстрого доступа к значениям именам полей и свойств объектов,
  /// по сути быстрый аналог PropertyInfo.GetValue
  /// код взят отсюда http://www.codeproject.com/KB/cs/DynamicCodeVsReflection.aspx
  /// </summary>
  public class FastMemberAccessHelper<TObjectType>
  {
    private static readonly ConcurrentDictionary<string, Delegate> _memberGetDelegates;
    internal static object iIflUThsYuLY4uXaKKXk;

    public static FastMemberAccessHelper<TObjectType>.MemberGetDelegate<TMemberType> GetMemberGetDelegate<TMemberType>(
      string memberName)
    {
      Type type = typeof (TObjectType);
      PropertyInfo reflectionProperty = type.GetReflectionProperty(memberName);
      FieldInfo reflectionField = type.GetReflectionField(memberName);
      if (reflectionProperty != (PropertyInfo) null)
      {
        MethodInfo getMethod = reflectionProperty.GetGetMethod();
        return getMethod != (MethodInfo) null ? (FastMemberAccessHelper<TObjectType>.MemberGetDelegate<TMemberType>) Delegate.CreateDelegate(typeof (FastMemberAccessHelper<TObjectType>.MemberGetDelegate<TMemberType>), getMethod) : throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 88022173), (object) memberName, (object) type.Name));
      }
      if (!(reflectionField != (FieldInfo) null))
        throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521294714), (object) memberName, (object) type.Name));
      DynamicMethod dynamicMethod = new DynamicMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786963308) + memberName, typeof (TMemberType), new Type[1]
      {
        type
      }, type);
      ILGenerator ilGenerator = dynamicMethod.GetILGenerator();
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Ldfld, reflectionField);
      ilGenerator.Emit(OpCodes.Ret);
      return (FastMemberAccessHelper<TObjectType>.MemberGetDelegate<TMemberType>) dynamicMethod.CreateDelegate(typeof (FastMemberAccessHelper<TObjectType>.MemberGetDelegate<TMemberType>));
    }

    public static FastMemberAccessHelper<TObjectType>.MemberGetDelegate<MemberType> GetCachedMemberGetDelegate<MemberType>(
      string memberName)
    {
      if (FastMemberAccessHelper<TObjectType>._memberGetDelegates.ContainsKey(memberName))
        return (FastMemberAccessHelper<TObjectType>.MemberGetDelegate<MemberType>) FastMemberAccessHelper<TObjectType>._memberGetDelegates[memberName];
      FastMemberAccessHelper<TObjectType>.MemberGetDelegate<MemberType> memberGetDelegate = FastMemberAccessHelper<TObjectType>.GetMemberGetDelegate<MemberType>(memberName);
      lock (FastMemberAccessHelper<TObjectType>._memberGetDelegates)
        FastMemberAccessHelper<TObjectType>._memberGetDelegates[memberName] = (Delegate) memberGetDelegate;
      return memberGetDelegate;
    }

    public FastMemberAccessHelper()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static FastMemberAccessHelper()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FastMemberAccessHelper<TObjectType>._memberGetDelegates = new ConcurrentDictionary<string, Delegate>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool cCUQtohsLJWA5UDaC5tM() => FastMemberAccessHelper<TObjectType>.iIflUThsYuLY4uXaKKXk == null;

    internal static object KB6cn8hsUvqFyqvrlLH9() => FastMemberAccessHelper<TObjectType>.iIflUThsYuLY4uXaKKXk;

    public delegate MemberType MemberGetDelegate<out MemberType>(TObjectType obj);
  }
}
