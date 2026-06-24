// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.TemplateGenerator.NotificationFunctionEvaluator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Web.Mvc;

namespace EleWise.ELMA.Notifications.Impl.TemplateGenerator
{
  /// <summary>Вычислитель функций с поддержкой специфики оповещений</summary>
  public class NotificationFunctionEvaluator : ElmaGeneratorFunctionEvaluator
  {
    private NotificationTemplateBase notificationTemplate;
    private static NotificationFunctionEvaluator BvfcYP6lpHXgorr9li6;

    /// <summary>Ctor</summary>
    /// <param name="context">Контекст процесса генерации</param>
    /// <param name="notificationTemplate">Шаблон оповещения</param>
    public NotificationFunctionEvaluator(
      GenerationContext context,
      NotificationTemplateBase notificationTemplate = null)
    {
      NotificationFunctionEvaluator.ylwbR765bcT5EJiEtyo();
      // ISSUE: explicit constructor call
      base.\u002Ector(context);
      int num1 = 6;
      while (true)
      {
        IEnumerator<INotificationFunctions> enumerator;
        IEnumerable<INotificationFunctions> service;
        switch (num1)
        {
          case 1:
            NotificationFunctionEvaluator.xFom3c6scb5pFefQy7e((object) this, NotificationFunctionEvaluator.ICZBW86UjY7x7Rr2tFL(323422137 << 2 ^ 1293717280), (object) NotificationFunctionEvaluator.tvJQDh6cK7GHCCqwhEn((object) this).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439578610), BindingFlags.Instance | BindingFlags.NonPublic), (object) this);
            num1 = 2;
            continue;
          case 2:
            goto label_14;
          case 3:
            service = Locator.GetService<IEnumerable<INotificationFunctions>>();
            num1 = 8;
            continue;
          case 4:
            enumerator = service.GetEnumerator();
            num1 = 7;
            continue;
          case 5:
            NotificationFunctionEvaluator.jS0JsW6jYuycMi41E3U((object) this, typeof (NotificationFunctions));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 3;
            continue;
          case 6:
            this.notificationTemplate = notificationTemplate;
            num1 = 5;
            continue;
          case 7:
            try
            {
label_6:
              if (NotificationFunctionEvaluator.re2SCo6YqoDsUdVqixg((object) enumerator))
                goto label_4;
              else
                goto label_7;
label_3:
              INotificationFunctions current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    this.RegisterFunctionsContainerType(current.GetType());
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_4;
                  case 3:
                    goto label_16;
                  default:
                    goto label_6;
                }
              }
label_4:
              current = enumerator.Current;
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
              {
                num2 = 1;
                goto label_3;
              }
              else
                goto label_3;
label_7:
              num2 = 3;
              goto label_3;
            }
            finally
            {
              int num3;
              if (enumerator == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              else
                goto label_12;
label_11:
              switch (num3)
              {
                case 2:
                  break;
                default:
              }
label_12:
              NotificationFunctionEvaluator.hwetkv6LuZiLhfq6i3c((object) enumerator);
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
              {
                num3 = 1;
                goto label_11;
              }
              else
                goto label_11;
            }
          case 8:
            if (service != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 4 : 2;
              continue;
            }
            break;
        }
label_16:
        NotificationFunctionEvaluator.xFom3c6scb5pFefQy7e((object) this, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654269163), (object) this.GetType().GetMethod((string) NotificationFunctionEvaluator.ICZBW86UjY7x7Rr2tFL(-1146510045 ^ -1146538863), BindingFlags.Instance | BindingFlags.NonPublic), (object) this);
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 1;
      }
label_14:;
    }

    /// <summary>Вставить частичный шаблон</summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    private FormatedValue Partial(FunctionEvaluationContext context)
    {
      int num1 = 12;
      string str;
      while (true)
      {
        int num2 = num1;
        string name;
        NotificationTemplateGenerator templateGenerator;
        object obj;
        NotificationPartialTemplate partialTemplate;
        TemplateRenderMode renderMode;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 17:
              goto label_18;
            case 2:
              if (NotificationFunctionEvaluator.KJv0Vo6znn6MPHeI3S8((object) context.Parameters[0]) is string)
              {
                num2 = 19;
                continue;
              }
              goto label_3;
            case 3:
              if (partialTemplate != null)
              {
                num2 = 13;
                continue;
              }
              goto label_22;
            case 4:
              if (context.Parameters.Count != 0)
              {
                num2 = 7;
                continue;
              }
              goto label_3;
            case 5:
              if (str == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 17;
                continue;
              }
              goto case 18;
            case 6:
              if (!((GenerationContext) NotificationFunctionEvaluator.v1v6tGHBgCHdaM6nkae((object) context)).ExtendedProperties.TryGetValue((string) NotificationFunctionEvaluator.ICZBW86UjY7x7Rr2tFL(-1334993905 ^ -1335030291), out obj))
              {
                num2 = 10;
                continue;
              }
              goto case 15;
            case 7:
              if (context.Parameters[0] != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 2;
                continue;
              }
              goto label_3;
            case 8:
              goto label_22;
            case 9:
            case 11:
              goto label_3;
            case 12:
              if (this.notificationTemplate == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 11 : 3;
                continue;
              }
              goto case 4;
            case 13:
              renderMode = ((GenerationContext) NotificationFunctionEvaluator.v1v6tGHBgCHdaM6nkae((object) context)).GetRenderMode();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 11 : 14;
              continue;
            case 14:
              goto label_17;
            case 15:
              templateGenerator.Provider.TemplateTimeZoneOffset = (int?) obj;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
            case 16:
              if (string.IsNullOrEmpty(name))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 10 : 20;
                continue;
              }
              partialTemplate = ((NotificationTemplateLoader) NotificationFunctionEvaluator.xJ0qBDHFtn16l4nP1eF((object) this.notificationTemplate.FileInfo)).GetPartialTemplate(this.notificationTemplate.FileInfo, name);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 3 : 3;
              continue;
            case 18:
              if (renderMode != TemplateRenderMode.HTML)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 1;
                continue;
              }
              goto label_19;
            case 19:
              name = (string) context.Parameters[0].Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 16 : 2;
              continue;
            case 20:
              goto label_24;
            default:
              str = (string) NotificationFunctionEvaluator.xZmiYZHb6TwAl0l5b2a((object) templateGenerator, NotificationFunctionEvaluator.wD651AHo25Vq4nRqsUN((object) context));
              num2 = 5;
              continue;
          }
        }
label_17:
        templateGenerator = new NotificationTemplateGenerator((string) NotificationFunctionEvaluator.pUnT3OHWraespVYsg22((object) partialTemplate), this.notificationTemplate, renderMode);
        num1 = 6;
      }
label_3:
      return new FormatedValue((object) string.Empty);
label_18:
      return new FormatedValue((object) str);
label_19:
      return new FormatedValue((object) MvcHtmlString.Create(str));
label_22:
      return new FormatedValue((object) string.Empty);
label_24:
      return new FormatedValue((object) string.Empty);
    }

    /// <summary>Зона для вставки частичных шаблонов через расширения</summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    private FormatedValue ExtensionZone(FunctionEvaluationContext context)
    {
      int num1 = 9;
      TemplateRenderMode renderMode;
      StringBuilder stringBuilder;
      List<INotificationPartialTemplate>.Enumerator enumerator;
      string zone;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (context.Parameters[0].Value is string)
            {
              zone = (string) context.Parameters[0].Value;
              num1 = 7;
              continue;
            }
            num1 = 6;
            continue;
          case 2:
            try
            {
label_17:
              if (enumerator.MoveNext())
                goto label_15;
              else
                goto label_18;
label_12:
              string str;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_15;
                  case 2:
                    goto label_2;
                  case 3:
                    if (NotificationFunctionEvaluator.oPtocWHE9P7rWWhGFD8((object) str))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                      continue;
                    }
                    goto case 4;
                  case 4:
                    NotificationFunctionEvaluator.NH8w0iHf3rTVLfws0n7((object) stringBuilder, (object) str);
                    num2 = 5;
                    continue;
                  default:
                    goto label_17;
                }
              }
label_15:
              str = (string) NotificationFunctionEvaluator.xZmiYZHb6TwAl0l5b2a((object) new NotificationTemplateGenerator((string) NotificationFunctionEvaluator.IaaxUJHGhQcYFCVSEy0((object) enumerator.Current), this.notificationTemplate, renderMode), NotificationFunctionEvaluator.wD651AHo25Vq4nRqsUN((object) context));
              num2 = 3;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
              {
                num2 = 1;
                goto label_12;
              }
              else
                goto label_12;
label_18:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 2;
              goto label_12;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 3:
            if (context.Parameters[0] == null)
            {
              num1 = 4;
              continue;
            }
            goto case 1;
          case 4:
          case 6:
            goto label_4;
          case 5:
label_2:
            if (renderMode != TemplateRenderMode.HTML)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
              continue;
            }
            goto label_25;
          case 7:
            List<INotificationPartialTemplate> list = ((ComponentManager) NotificationFunctionEvaluator.QF09ofHhUA6VDe6SPvu()).GetExtensionPoints<INotificationTemplateLoader>().SelectMany<INotificationTemplateLoader, INotificationPartialTemplate>((Func<INotificationTemplateLoader, IEnumerable<INotificationPartialTemplate>>) (l => l.GetExtensionTemplates(zone))).ToList<INotificationPartialTemplate>();
            renderMode = ((GenerationContext) NotificationFunctionEvaluator.v1v6tGHBgCHdaM6nkae((object) context)).GetRenderMode();
            stringBuilder = new StringBuilder();
            enumerator = list.GetEnumerator();
            num1 = 2;
            continue;
          case 8:
            if (context.Parameters.Count != 0)
            {
              num1 = 3;
              continue;
            }
            goto label_4;
          case 9:
            num1 = 8;
            continue;
          default:
            goto label_24;
        }
      }
label_4:
      return new FormatedValue((object) string.Empty);
label_24:
      return new FormatedValue((object) stringBuilder.ToString());
label_25:
      return new FormatedValue(NotificationFunctionEvaluator.B4STDlHQYtNO8k3OD4W((object) stringBuilder.ToString()));
    }

    internal static void ylwbR765bcT5EJiEtyo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void jS0JsW6jYuycMi41E3U([In] object obj0, [In] Type obj1) => ((GeneratorFunctionEvaluator) obj0).RegisterFunctionsContainerType(obj1);

    internal static bool re2SCo6YqoDsUdVqixg([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void hwetkv6LuZiLhfq6i3c([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object ICZBW86UjY7x7Rr2tFL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void xFom3c6scb5pFefQy7e([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((GeneratorFunctionEvaluator) obj0).RegisterFunction((string) obj1, (MethodInfo) obj2, obj3);

    internal static Type tvJQDh6cK7GHCCqwhEn([In] object obj0) => obj0.GetType();

    internal static bool SiHapY6raGFYUCklbOe() => NotificationFunctionEvaluator.BvfcYP6lpHXgorr9li6 == null;

    internal static NotificationFunctionEvaluator IVDkpc6g3DpIJ5uFhuS() => NotificationFunctionEvaluator.BvfcYP6lpHXgorr9li6;

    internal static object KJv0Vo6znn6MPHeI3S8([In] object obj0) => ((FormatedValue) obj0).Value;

    internal static object xJ0qBDHFtn16l4nP1eF([In] object obj0) => (object) ((NotificationTemplateFileInfo) obj0).Loader;

    internal static object v1v6tGHBgCHdaM6nkae([In] object obj0) => (object) ((FunctionEvaluationContext) obj0).GenerationContext;

    internal static object pUnT3OHWraespVYsg22([In] object obj0) => (object) ((NotificationPartialTemplate) obj0).Content;

    internal static object wD651AHo25Vq4nRqsUN([In] object obj0) => (object) ((FunctionEvaluationContext) obj0).DataSource;

    internal static object xZmiYZHb6TwAl0l5b2a([In] object obj0, [In] object obj1) => (object) ((TextGenerator) obj0).Generate((IGeneratorDataSource) obj1);

    internal static object QF09ofHhUA6VDe6SPvu() => (object) ComponentManager.Current;

    internal static object IaaxUJHGhQcYFCVSEy0([In] object obj0) => (object) ((INotificationPartialTemplate) obj0).Content;

    internal static bool oPtocWHE9P7rWWhGFD8([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object NH8w0iHf3rTVLfws0n7([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).AppendLine((string) obj1);

    internal static object B4STDlHQYtNO8k3OD4W([In] object obj0) => (object) MvcHtmlString.Create((string) obj0);
  }
}
