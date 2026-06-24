// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.FormAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрибут указывает представление формы для класса или интерфейса
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
  public class FormAttribute : Attribute
  {
    private FormViewItem form;
    private Type typeOfAssembly;
    private string resourceName;
    private static FormAttribute enhHLCoCkqoMyAVnwxt8;

    /// <summary>Ctor</summary>
    /// <param name="typeOfAssembly">Тип из сборки с ресурсом, содержащим форму</param>
    /// <param name="resourceName">Имя ресурса с формой в сериализованном виде</param>
    public FormAttribute(Type typeOfAssembly, string resourceName)
    {
      FormAttribute.vaWaP5oC23WOiASI7Hvh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.resourceName = resourceName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          case 2:
            this.typeOfAssembly = typeOfAssembly;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 1;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Представление</summary>
    public FormViewItem Form
    {
      get
      {
        int num = 2;
        FormViewItem form1;
        FormViewItem form2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.form = form1 = (FormViewItem) FormAttribute.NcAjH0oCeGL6d62TOcRN(this.typeOfAssembly, (object) this.resourceName);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            case 2:
              form2 = this.form;
              if (form2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return form2;
label_6:
        return form1;
      }
    }

    private static FormViewItem DeserializeForm(Type typeOfAssembly, object resourceName)
    {
      int num1 = 1;
      Stream input;
      while (true)
      {
        switch (num1)
        {
          case 1:
            input = (Stream) FormAttribute.ag6eDCoCPkAeUkPSurlB((object) typeOfAssembly.Assembly, resourceName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_24;
          default:
            goto label_2;
        }
      }
label_2:
      FormViewItem formViewItem;
      try
      {
        int num2;
        if (input != null)
          num2 = 3;
        else
          goto label_6;
label_5:
        XmlTextReader reader;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
              reader = new XmlTextReader(input);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 2;
              continue;
            case 2:
              goto label_8;
            case 4:
              goto label_24;
            default:
              goto label_6;
          }
        }
label_8:
        try
        {
          // ISSUE: type reference
          formViewItem = (FormViewItem) ClassSerializationHelper.DeserializeObjectByXml(FormAttribute.ovoSEUoC1Of1r1YaJR5r(__typeref (FormViewItem)), (XmlReader) reader);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
            num3 = 0;
          switch (num3)
          {
            default:
              goto label_24;
          }
        }
        finally
        {
          if (reader != null)
          {
            int num4 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
              num4 = 1;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  FormAttribute.D8cJUuoCNOS8swXiSTA1((object) reader);
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_16;
              }
            }
          }
label_16:;
        }
label_6:
        formViewItem = (FormViewItem) null;
        num2 = 4;
        goto label_5;
      }
      finally
      {
        if (input != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_22;
              default:
                FormAttribute.D8cJUuoCNOS8swXiSTA1((object) input);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_22:;
      }
label_24:
      return formViewItem;
    }

    internal static void vaWaP5oC23WOiASI7Hvh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool IyGGHnoCnCniIT3u4IDJ() => FormAttribute.enhHLCoCkqoMyAVnwxt8 == null;

    internal static FormAttribute NPuyKwoCOj0PayrsxOF5() => FormAttribute.enhHLCoCkqoMyAVnwxt8;

    internal static object NcAjH0oCeGL6d62TOcRN(Type typeOfAssembly, [In] object obj1) => (object) FormAttribute.DeserializeForm(typeOfAssembly, obj1);

    internal static object ag6eDCoCPkAeUkPSurlB([In] object obj0, [In] object obj1) => (object) ((Assembly) obj0).GetReflectionManifestResourceStream((string) obj1);

    internal static Type ovoSEUoC1Of1r1YaJR5r([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void D8cJUuoCNOS8swXiSTA1([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
