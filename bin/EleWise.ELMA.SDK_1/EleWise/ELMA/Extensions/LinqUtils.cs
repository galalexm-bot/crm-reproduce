// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.LinqUtils
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  public static class LinqUtils
  {
    internal static LinqUtils l6XGApG6t9722F8bdHrS;

    /// <summary>Получить имя члена класса из выражения</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="f"></param>
    /// <returns></returns>
    public static string NameOf<T>(Expression<Func<T, object>> f) => LinqUtils.GetMemberInfo((object) f).Name;

    /// <summary>Получить имя члена класса из выражения</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="f"></param>
    /// <returns></returns>
    public static string NameOf<T, RT>(Expression<Func<T, RT>> f) => LinqUtils.GetMemberInfo((object) f).Name;

    /// <summary>Получить информацию о члене класса из выражения</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="f"></param>
    /// <returns></returns>
    public static MemberInfo MemberOf<T>(Expression<Func<T, object>> f) => LinqUtils.GetMemberInfo((object) f);

    /// <summary>Получить информацию о члене класса из выражения</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="f"></param>
    /// <returns></returns>
    public static MemberInfo MemberOf<T, RT>(Expression<Func<T, RT>> f) => LinqUtils.GetMemberInfo((object) f);

    /// <summary>Получить информацию о члене класса из выражения</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="f"></param>
    /// <returns></returns>
    public static MemberInfo MemberOf<T>(Expression<Action<T>> f) => LinqUtils.GetMemberInfo((object) f);

    private static MemberInfo GetMemberInfo(object method)
    {
      int num = 2;
      MemberExpression memberExpression;
      MemberInfo memberInfo;
      LambdaExpression lambdaExpression;
      MethodCallExpression methodCallExpression;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (lambdaExpression != null)
            {
              num = 6;
              continue;
            }
            goto label_21;
          case 2:
            lambdaExpression = method as LambdaExpression;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
            continue;
          case 3:
            if (LinqUtils.stwYXZG67gCWvx0U5aNY(LinqUtils.T32SXkG6xiCEEZkxqWao((object) lambdaExpression)) == ExpressionType.Convert)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 8 : 13;
              continue;
            }
            goto case 7;
          case 4:
            memberInfo = (MemberInfo) LinqUtils.oukiABG60IXN96ksgeIV((object) (MethodCallExpression) LinqUtils.T32SXkG6xiCEEZkxqWao((object) lambdaExpression));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 12 : 1;
            continue;
          case 5:
            memberInfo = (MemberInfo) methodCallExpression.Method;
            num = 16;
            continue;
          case 6:
            memberInfo = (MemberInfo) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 9 : 0;
            continue;
          case 7:
          case 12:
          case 14:
          case 16:
            if (memberInfo == (MemberInfo) null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 10 : 0;
              continue;
            }
            goto label_17;
          case 8:
            if (LinqUtils.stwYXZG67gCWvx0U5aNY((object) lambdaExpression.Body) == ExpressionType.Call)
            {
              num = 4;
              continue;
            }
            goto case 3;
          case 9:
            memberExpression = (MemberExpression) LinqUtils.A5D1KeG6HpaJMNRrHvQR((object) lambdaExpression);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 11 : 9;
            continue;
          case 10:
            goto label_16;
          case 11:
            if (memberExpression != null)
            {
              num = 17;
              continue;
            }
            goto case 8;
          case 13:
            methodCallExpression = LinqUtils.f9ujHBG6m98wfZCdH3vn((object) (UnaryExpression) LinqUtils.T32SXkG6xiCEEZkxqWao((object) lambdaExpression)) as MethodCallExpression;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          case 15:
            goto label_21;
          case 17:
            memberInfo = (MemberInfo) LinqUtils.FsKFNaG6AHB4kT4ehweY((object) memberExpression);
            num = 14;
            continue;
          default:
            if (methodCallExpression == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 7 : 0;
              continue;
            }
            goto case 5;
        }
      }
label_16:
      throw new ArgumentException((string) LinqUtils.XRQikAG66X35QdD14WUw(-867826612 ^ -867755686));
label_17:
      return memberInfo;
label_21:
      throw new ArgumentNullException((string) LinqUtils.XRQikAG66X35QdD14WUw(44884861 ^ 44957291));
    }

    public static MemberExpression GetMemberExpression(LambdaExpression lambda)
    {
      int num = 5;
      MemberExpression memberExpression;
      while (true)
      {
        switch (num)
        {
          case 2:
            if (LinqUtils.stwYXZG67gCWvx0U5aNY(LinqUtils.T32SXkG6xiCEEZkxqWao((object) lambda)) == ExpressionType.MemberAccess)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 3 : 3;
              continue;
            }
            goto label_6;
          case 3:
            memberExpression = LinqUtils.T32SXkG6xiCEEZkxqWao((object) lambda) as MemberExpression;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
            continue;
          case 4:
            if (LinqUtils.stwYXZG67gCWvx0U5aNY(LinqUtils.T32SXkG6xiCEEZkxqWao((object) lambda)) == ExpressionType.Convert)
            {
              num = 6;
              continue;
            }
            goto case 2;
          case 5:
            memberExpression = (MemberExpression) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 4 : 4;
            continue;
          case 6:
            memberExpression = LinqUtils.f9ujHBG6m98wfZCdH3vn((object) (UnaryExpression) LinqUtils.T32SXkG6xiCEEZkxqWao((object) lambda)) as MemberExpression;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return memberExpression;
    }

    /// <summary>Получить полное имя члена класса из выражения</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="f"></param>
    /// <returns></returns>
    public static string FullNameOf<T>(Expression<Func<T, object>> f) => string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021403569), LinqUtils.FillNamesOfMemberExpression((object) f.Body));

    /// <summary>Получить полное имя члена класса из выражения</summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="RT"></typeparam>
    /// <param name="f"></param>
    /// <returns></returns>
    public static string FullNameOf<T, RT>(Expression<Func<T, RT>> f) => string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138154820), LinqUtils.FillNamesOfMemberExpression((object) f.Body));

    private static IEnumerable<string> FillNamesOfMemberExpression(object expression)
    {
      switch (((Expression) expression).NodeType)
      {
        case ExpressionType.Convert:
          MemberExpression operand = (expression as UnaryExpression).Operand as MemberExpression;
          return LinqUtils.FillNamesOfMemberExpression((object) operand.Expression).Union<string>((IEnumerable<string>) new string[1]
          {
            operand.Member.Name
          });
        case ExpressionType.MemberAccess:
          MemberExpression memberExpression = expression as MemberExpression;
          return LinqUtils.FillNamesOfMemberExpression((object) memberExpression.Expression).Union<string>((IEnumerable<string>) new string[1]
          {
            memberExpression.Member.Name
          });
        default:
          return (IEnumerable<string>) new string[0];
      }
    }

    internal static object XRQikAG66X35QdD14WUw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object A5D1KeG6HpaJMNRrHvQR([In] object obj0) => (object) LinqUtils.GetMemberExpression((LambdaExpression) obj0);

    internal static object FsKFNaG6AHB4kT4ehweY([In] object obj0) => (object) ((MemberExpression) obj0).Member;

    internal static ExpressionType stwYXZG67gCWvx0U5aNY([In] object obj0) => ((Expression) obj0).NodeType;

    internal static object T32SXkG6xiCEEZkxqWao([In] object obj0) => (object) ((LambdaExpression) obj0).Body;

    internal static object oukiABG60IXN96ksgeIV([In] object obj0) => (object) ((MethodCallExpression) obj0).Method;

    internal static object f9ujHBG6m98wfZCdH3vn([In] object obj0) => (object) ((UnaryExpression) obj0).Operand;

    internal static bool cJiEJvG6wvY0RTYkPEWB() => LinqUtils.l6XGApG6t9722F8bdHrS == null;

    internal static LinqUtils LuMThQG64PXS1wQaR3O5() => LinqUtils.l6XGApG6t9722F8bdHrS;
  }
}
