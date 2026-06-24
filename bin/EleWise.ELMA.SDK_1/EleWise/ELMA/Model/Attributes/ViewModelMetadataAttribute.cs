// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ViewModelMetadataAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
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
  /// Атрибут указывает файл ресурсов с метаданными модели отображения для класса или интерфейса
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
  public sealed class ViewModelMetadataAttribute : Attribute
  {
    private readonly Type typeOfAssembly;
    private readonly string resourceName;
    private DataClassMetadata viewModelMetadata;
    private static ViewModelMetadataAttribute K5S8wgofppsjCeZJgLiC;

    /// <summary>Ctor</summary>
    /// <param name="typeOfAssembly">Тип из сборки с ресурсом, содержащим метаданные модели отображения</param>
    /// <param name="resourceName">Имя ресурса с метаданными модели отображения в сериализованном виде</param>
    public ViewModelMetadataAttribute(Type typeOfAssembly, string resourceName)
    {
      ViewModelMetadataAttribute.NJLXQkoftUmlSNoySoQp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.resourceName = resourceName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 1;
            continue;
          default:
            this.typeOfAssembly = typeOfAssembly;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Метаданные модели отобрпажения</summary>
    internal DataClassMetadata ViewModelMetadata
    {
      get
      {
        int num = 1;
        DataClassMetadata viewModelMetadata1;
        DataClassMetadata viewModelMetadata2;
        while (true)
        {
          switch (num)
          {
            case 1:
              viewModelMetadata2 = this.viewModelMetadata;
              if (viewModelMetadata2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.viewModelMetadata = viewModelMetadata1 = (DataClassMetadata) ViewModelMetadataAttribute.TlYKQBofwKDqexLHeyKE(this.typeOfAssembly, (object) this.resourceName);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 2;
              continue;
          }
        }
label_2:
        return viewModelMetadata2;
label_6:
        return viewModelMetadata1;
      }
    }

    private static DataClassMetadata DeserializeMetadata(Type typeOfAssembly, object resourceName)
    {
      int num1 = 1;
      Stream input;
      while (true)
      {
        switch (num1)
        {
          case 1:
            input = (Stream) ViewModelMetadataAttribute.x1B3Yxof4Vjk9EpVB5q9((object) typeOfAssembly.Assembly, resourceName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_25;
          default:
            goto label_2;
        }
      }
label_2:
      DataClassMetadata dataClassMetadata;
      try
      {
        int num2;
        if (input != null)
          num2 = 3;
        else
          goto label_7;
label_5:
        XmlTextReader reader;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_25;
            case 2:
              goto label_9;
            case 4:
              goto label_7;
            default:
              reader = new XmlTextReader(input);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 2 : 2;
              continue;
          }
        }
label_9:
        try
        {
          dataClassMetadata = (DataClassMetadata) ClassSerializationHelper.DeserializeObjectByXml(typeof (DataClassMetadata), (XmlReader) reader);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
            num3 = 0;
          switch (num3)
          {
            default:
              goto label_25;
          }
        }
        finally
        {
          if (reader != null)
          {
            int num4 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
              num4 = 0;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  goto label_17;
                default:
                  ViewModelMetadataAttribute.lonTmtof6CSvJWdRVNqC((object) reader);
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
                  continue;
              }
            }
          }
label_17:;
        }
label_7:
        dataClassMetadata = (DataClassMetadata) null;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        {
          num2 = 1;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        int num5;
        if (input == null)
          num5 = 2;
        else
          goto label_21;
label_20:
        switch (num5)
        {
          case 1:
            break;
          default:
        }
label_21:
        input.Dispose();
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        {
          num5 = 0;
          goto label_20;
        }
        else
          goto label_20;
      }
label_25:
      return dataClassMetadata;
    }

    internal static void NJLXQkoftUmlSNoySoQp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool fdoVjUofa3f9RcgqPpcM() => ViewModelMetadataAttribute.K5S8wgofppsjCeZJgLiC == null;

    internal static ViewModelMetadataAttribute HOMoOoofDvXHdx6eFLJ9() => ViewModelMetadataAttribute.K5S8wgofppsjCeZJgLiC;

    internal static object TlYKQBofwKDqexLHeyKE(Type typeOfAssembly, [In] object obj1) => (object) ViewModelMetadataAttribute.DeserializeMetadata(typeOfAssembly, obj1);

    internal static object x1B3Yxof4Vjk9EpVB5q9([In] object obj0, [In] object obj1) => (object) ((Assembly) obj0).GetReflectionManifestResourceStream((string) obj1);

    internal static void lonTmtof6CSvJWdRVNqC([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
