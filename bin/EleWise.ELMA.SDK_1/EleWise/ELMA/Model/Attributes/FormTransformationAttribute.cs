// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.FormTransformationAttribute
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
  public class FormTransformationAttribute : Attribute
  {
    private FormViewItemTransformation transformation;
    private Type typeOfAssembly;
    private string resourceName;
    private static FormTransformationAttribute xL5npIoCtpk3MsmyMVIW;

    /// <summary>Ctor</summary>
    /// <param name="typeOfAssembly">Тип из сборки с ресурсом, содержащим преобразование формы</param>
    /// <param name="resourceName">Имя ресурса с преобразованием формы в сериализованном виде</param>
    public FormTransformationAttribute(Type typeOfAssembly, string resourceName)
    {
      FormTransformationAttribute.tciBHvoC6vt7FfIAlnDY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.resourceName = resourceName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          case 2:
            this.typeOfAssembly = typeOfAssembly;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Представление</summary>
    public FormViewItemTransformation Transformation
    {
      get
      {
        int num = 1;
        FormViewItemTransformation transformation1;
        FormViewItemTransformation transformation2;
        while (true)
        {
          switch (num)
          {
            case 1:
              transformation2 = this.transformation;
              if (transformation2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.transformation = transformation1 = (FormViewItemTransformation) FormTransformationAttribute.XKS9yooCHVWVMK7VbofG(this.typeOfAssembly, (object) this.resourceName);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        return transformation2;
label_6:
        return transformation1;
      }
    }

    private static FormViewItemTransformation DeserializeTransformation(
      Type typeOfAssembly,
      object resourceName)
    {
      int num1 = 1;
      Stream input;
      while (true)
      {
        switch (num1)
        {
          case 1:
            input = (Stream) FormTransformationAttribute.XS91Z7oCAIpJGttbDu2B((object) typeOfAssembly.Assembly, resourceName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_24;
          default:
            goto label_3;
        }
      }
label_3:
      FormViewItemTransformation itemTransformation;
      try
      {
        int num2;
        if (input != null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
        else
          goto label_7;
label_6:
        XmlTextReader reader;
        while (true)
        {
          switch (num2)
          {
            case 2:
              goto label_24;
            case 3:
              goto label_7;
            case 4:
              goto label_9;
            default:
              reader = new XmlTextReader(input);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 3 : 4;
              continue;
          }
        }
label_9:
        try
        {
          // ISSUE: type reference
          itemTransformation = (FormViewItemTransformation) ClassSerializationHelper.DeserializeObjectByXml(FormTransformationAttribute.wKAZ1eoC7f9uBXB3bep1(__typeref (FormViewItemTransformation)), (XmlReader) reader);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
            num3 = 0;
          switch (num3)
          {
            default:
              goto label_24;
          }
        }
        finally
        {
          int num4;
          if (reader == null)
            num4 = 2;
          else
            goto label_15;
label_14:
          switch (num4)
          {
            case 1:
            case 2:
          }
label_15:
          FormTransformationAttribute.gffGZWoCxboKbCUDk0a9((object) reader);
          num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
          {
            num4 = 0;
            goto label_14;
          }
          else
            goto label_14;
        }
label_7:
        itemTransformation = (FormViewItemTransformation) null;
        num2 = 2;
        goto label_6;
      }
      finally
      {
        int num5;
        if (input == null)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
        else
          goto label_21;
label_20:
        switch (num5)
        {
          case 2:
            break;
          default:
        }
label_21:
        FormTransformationAttribute.gffGZWoCxboKbCUDk0a9((object) input);
        num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        {
          num5 = 1;
          goto label_20;
        }
        else
          goto label_20;
      }
label_24:
      return itemTransformation;
    }

    internal static void tciBHvoC6vt7FfIAlnDY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FiveUQoCwjoZTRW59poZ() => FormTransformationAttribute.xL5npIoCtpk3MsmyMVIW == null;

    internal static FormTransformationAttribute xPfAALoC4Xt79aS905T1() => FormTransformationAttribute.xL5npIoCtpk3MsmyMVIW;

    internal static object XKS9yooCHVWVMK7VbofG(Type typeOfAssembly, [In] object obj1) => (object) FormTransformationAttribute.DeserializeTransformation(typeOfAssembly, obj1);

    internal static object XS91Z7oCAIpJGttbDu2B([In] object obj0, [In] object obj1) => (object) ((Assembly) obj0).GetReflectionManifestResourceStream((string) obj1);

    internal static Type wKAZ1eoC7f9uBXB3bep1([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void gffGZWoCxboKbCUDk0a9([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
