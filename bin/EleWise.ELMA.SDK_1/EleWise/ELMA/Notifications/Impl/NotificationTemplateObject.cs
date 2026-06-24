// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.NotificationTemplateObject
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
  public class NotificationTemplateObject
  {
    private readonly ExpressionTemplateEvaluator expressionEvaluator;
    internal static NotificationTemplateObject w27EkJ6BZObj1mcEa1r;

    /// <summary>Шаблон выражения, задающий идентификатор объекта</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
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

    /// <summary>Ctor</summary>
    public NotificationTemplateObject()
    {
      NotificationTemplateObject.l4Fs4K6bM9nCp5YqgqY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public string GetObjectId(object notificationDataSource)
    {
      int num1 = 4;
      FormatedValue formatedValue;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              goto label_10;
            case 3:
              goto label_4;
            case 4:
              if (this.expressionEvaluator != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 3 : 3;
                continue;
              }
              goto label_3;
            case 5:
              if (formatedValue != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 1;
                continue;
              }
              goto label_9;
            default:
              goto label_9;
          }
        }
label_4:
        formatedValue = (FormatedValue) NotificationTemplateObject.cXX34e6huD3NDiC1Ak5((object) this.expressionEvaluator, notificationDataSource);
        num1 = 5;
      }
label_3:
      return (string) null;
label_9:
      object obj = (object) null;
      goto label_11;
label_10:
      obj = formatedValue.Value;
label_11:
      return (string) NotificationTemplateObject.zyiC656GEACMKufYitx(obj);
    }

    public NotificationTemplateObject(XmlElement node)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      int num1 = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_15;
          case 1:
            this.ExpressionText = (string) NotificationTemplateObject.rsC3PV6QBJOeQ23wEV7(NotificationTemplateObject.jO8CD86EcUthf62eV2D((object) node), (object) ((string) NotificationTemplateObject.cYlD7r6fRRnfMsYAMqJ(-1978478350 ^ -1978497346)).ToCharArray());
            num1 = 2;
            continue;
          case 2:
            goto label_5;
          default:
            goto label_11;
        }
      }
label_15:
      return;
label_11:
      return;
label_5:
      try
      {
        if (string.IsNullOrEmpty(this.ExpressionText))
          return;
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            default:
              this.expressionEvaluator = new ExpressionTemplateEvaluator(this.ExpressionText);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new Exception((string) NotificationTemplateObject.WDbcdr6CfuAXus1SkNQ(NotificationTemplateObject.cYlD7r6fRRnfMsYAMqJ(1253244298 - 1829393894 ^ -576184300), (object) this.ExpressionText), ex);
        }
      }
    }

    internal static bool F5SUy66WULLHqAXm2uR() => NotificationTemplateObject.w27EkJ6BZObj1mcEa1r == null;

    internal static NotificationTemplateObject k7kwdM6oL37F5MiuhGh() => NotificationTemplateObject.w27EkJ6BZObj1mcEa1r;

    internal static void l4Fs4K6bM9nCp5YqgqY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object cXX34e6huD3NDiC1Ak5([In] object obj0, [In] object obj1) => (object) ((ExpressionEvaluator) obj0).Evaluate(obj1);

    internal static object zyiC656GEACMKufYitx([In] object obj0) => (object) Convert.ToString(obj0);

    internal static object jO8CD86EcUthf62eV2D([In] object obj0) => (object) ((XmlNode) obj0).InnerXml;

    internal static object cYlD7r6fRRnfMsYAMqJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object rsC3PV6QBJOeQ23wEV7([In] object obj0, [In] object obj1) => (object) ((string) obj0).Trim((char[]) obj1);

    internal static object WDbcdr6CfuAXus1SkNQ([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);
  }
}
