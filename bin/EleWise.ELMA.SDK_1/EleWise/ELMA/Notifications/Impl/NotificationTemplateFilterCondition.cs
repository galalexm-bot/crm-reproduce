// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationTemplateFilterCondition
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Notifications.Impl
{
  /// <summary>Условие для фильтра оповещения</summary>
  public class NotificationTemplateFilterCondition
  {
    private readonly ExpressionTemplateEvaluator expressionEvaluator;
    private static NotificationTemplateFilterCondition nKPJ19th44Nr9SHEVM9;

    /// <summary>Шаблон выражения, задающий условие</summary>
    public string ExpressionText
    {
      get => this.\u003CExpressionText\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CExpressionText\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Вычислить значение</summary>
    /// <param name="notificationDataSource">Источник данных для вычисления</param>
    /// <returns>Истинность условия</returns>
    public bool Evaluate(object notificationDataSource)
    {
      int num = 1;
      FormatedValue formatedValue;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.expressionEvaluator != null)
            {
              formatedValue = (FormatedValue) NotificationTemplateFilterCondition.jGJ1Xwtfjks98G6CuTc((object) this.expressionEvaluator, notificationDataSource);
              num = 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
            continue;
          case 2:
            if (NotificationTemplateFilterCondition.UdAcYjtQFA4jAyFTQoo((object) formatedValue) is bool)
            {
              num = 4;
              continue;
            }
            goto label_9;
          case 3:
            if (formatedValue != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 2 : 2;
              continue;
            }
            goto label_9;
          case 4:
            goto label_8;
          default:
            goto label_4;
        }
      }
label_4:
      return false;
label_8:
      return (bool) NotificationTemplateFilterCondition.UdAcYjtQFA4jAyFTQoo((object) formatedValue);
label_9:
      return false;
    }

    /// <summary>Ctor</summary>
    /// <param name="expressionText">Шаблон выражения, задающий условие</param>
    public NotificationTemplateFilterCondition(string expressionText)
    {
      NotificationTemplateFilterCondition.FeTyN0tCdWdGCIXZTRL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_15;
          case 2:
            this.ExpressionText = expressionText;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_15:
      return;
label_4:
      try
      {
        if (string.IsNullOrEmpty(this.ExpressionText))
          return;
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_9;
            case 1:
              this.expressionEvaluator = new ExpressionTemplateEvaluator(this.ExpressionText);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_9:
        return;
label_2:;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new Exception((string) NotificationTemplateFilterCondition.Hofl91t8loCutPp5kZ5(NotificationTemplateFilterCondition.AW2EQjtvsBb7WmBQWql(--1333735954 ^ 1333769634), (object) this.ExpressionText), ex);
        }
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="node">Элемент документа XML</param>
    public NotificationTemplateFilterCondition(XmlElement node)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(((string) NotificationTemplateFilterCondition.AnkpTHtZjMU8WYXlGlq((object) node)).Trim((char[]) NotificationTemplateFilterCondition.viYODStubxZ72lNCLfJ(NotificationTemplateFilterCondition.AW2EQjtvsBb7WmBQWql(-244066886 - -48452443 ^ -195592359))));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool qaGa1OtGvNeBmmtE5Z7() => NotificationTemplateFilterCondition.nKPJ19th44Nr9SHEVM9 == null;

    internal static NotificationTemplateFilterCondition VS0LRFtEROKZihbqr4O() => NotificationTemplateFilterCondition.nKPJ19th44Nr9SHEVM9;

    internal static object jGJ1Xwtfjks98G6CuTc([In] object obj0, [In] object obj1) => (object) ((ExpressionEvaluator) obj0).Evaluate(obj1);

    internal static object UdAcYjtQFA4jAyFTQoo([In] object obj0) => ((FormatedValue) obj0).Value;

    internal static void FeTyN0tCdWdGCIXZTRL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object AW2EQjtvsBb7WmBQWql(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Hofl91t8loCutPp5kZ5([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object AnkpTHtZjMU8WYXlGlq([In] object obj0) => (object) ((XmlNode) obj0).InnerXml;

    internal static object viYODStubxZ72lNCLfJ([In] object obj0) => (object) ((string) obj0).ToCharArray();
  }
}
