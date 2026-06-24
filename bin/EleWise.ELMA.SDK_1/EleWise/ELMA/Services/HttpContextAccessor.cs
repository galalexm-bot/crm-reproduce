// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.HttpContextAccessor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Web;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Доступ к текущему контексту через <see cref="P:System.Web.HttpContext.Current" />
  /// Для работы с <see cref="P:System.Web.HttpContextBase.Items" /> используйте <see cref="T:EleWise.ELMA.Services.ContextVars" />
  /// </summary>
  [Service(Scope = ServiceScope.Application, EnableInterceptors = false, InjectProperties = false)]
  public class HttpContextAccessor : IHttpContextAccessor
  {
    private Func<HttpContextBase> getCurrentIfNull;
    private static HttpContextAccessor sL44E0BxXVH91eADn7Ax;

    /// <summary>
    /// Получить текущий контекст из локатора при помощи <see cref="M:EleWise.ELMA.Services.IHttpContextAccessor.Current" />
    /// Для работы с <see cref="P:System.Web.HttpContextBase.Items" /> используйте <see cref="T:EleWise.ELMA.Services.ContextVars" />
    /// </summary>
    public static HttpContextBase CurrentContext => (HttpContextBase) HttpContextAccessor.cOVYZlBxn0lkshkEwBx5((object) Locator.GetServiceNotNull<IHttpContextAccessor>());

    public HttpContextBase Current()
    {
      int num = 3;
      HttpContext staticProperty;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (staticProperty != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
              continue;
            }
            if (this.getCurrentIfNull != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          case 3:
            staticProperty = HttpContextAccessor.GetStaticProperty();
            num = 2;
            continue;
          case 4:
            goto label_2;
          default:
            goto label_7;
        }
      }
label_2:
      return (HttpContextBase) null;
label_3:
      return this.getCurrentIfNull();
label_7:
      return (HttpContextBase) new HttpContextWrapper(staticProperty);
    }

    /// <summary>
    /// Установить функцию для получения текущего контекста, если не найден в <see cref="M:EleWise.ELMA.Services.IHttpContextAccessor.Current" />
    /// </summary>
    /// <param name="getFunc">Функция получения текущего контекста</param>
    public void SetCurrentIfNull(Func<HttpContextBase> getFunc) => this.getCurrentIfNull = getFunc;

    private static HttpContext GetStaticProperty()
    {
      int num1 = 2;
      HttpContext staticProperty1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (staticProperty1 != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 4 : 1;
              continue;
            }
            goto label_13;
          case 2:
            staticProperty1 = (HttpContext) HttpContextAccessor.cgx1SVBxOk3OG23wwcgB();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_13;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 5 : 1;
            continue;
          case 5:
            goto label_2;
          default:
            goto label_11;
        }
      }
label_2:
      HttpContext staticProperty2;
      try
      {
        int num2;
        if (HttpContextAccessor.f5YammBx2VGibICy4ivU((object) staticProperty1) != null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
        else
          goto label_5;
label_4:
        switch (num2)
        {
          case 1:
            break;
          case 2:
            goto label_12;
          default:
            goto label_11;
        }
label_5:
        staticProperty2 = (HttpContext) null;
        num2 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              staticProperty2 = (HttpContext) null;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            default:
              goto label_12;
          }
        }
      }
label_12:
      return staticProperty2;
label_11:
      return staticProperty1;
label_13:
      return (HttpContext) null;
    }

    public HttpContextAccessor()
    {
      HttpContextAccessor.jS41CfBxeAOFst9uY1Zc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object cOVYZlBxn0lkshkEwBx5([In] object obj0) => (object) ((IHttpContextAccessor) obj0).Current();

    internal static bool e2gSGWBxTEMtLCPfqFYx() => HttpContextAccessor.sL44E0BxXVH91eADn7Ax == null;

    internal static HttpContextAccessor P6MhL5Bxk9URGKBbYpqi() => HttpContextAccessor.sL44E0BxXVH91eADn7Ax;

    internal static object cgx1SVBxOk3OG23wwcgB() => (object) HttpContext.Current;

    internal static object f5YammBx2VGibICy4ivU([In] object obj0) => (object) ((HttpContext) obj0).Request;

    internal static void jS41CfBxeAOFst9uY1Zc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
