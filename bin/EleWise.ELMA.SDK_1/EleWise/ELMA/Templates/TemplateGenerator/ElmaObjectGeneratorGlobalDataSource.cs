// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.TemplateGenerator.ElmaObjectGeneratorGlobalDataSource
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Templates.GlobalValueTemplateGenerator;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.DataSources;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates.TemplateGenerator
{
  /// <summary>
  /// Источник данных на основе объекта с поддержкой специфики ELMA SDK
  /// </summary>
  /// <remarks>
  /// Дополнительно поддерживаются интерфейсы
  /// <see cref="T:EleWise.ELMA.Dynamic.IDynamicObject" />,
  /// <see cref="T:EleWise.ELMA.Dynamic.IExtendedPropertiesContainer" />
  /// </remarks>
  public class ElmaObjectGeneratorGlobalDataSource : DefaultObjectGeneratorGlobalDataSource
  {
    private ClassMetadata dataSourceObjectMetadata;
    private static ElmaObjectGeneratorGlobalDataSource Upinc7B310L4gdrN8EGG;

    /// <summary>Ctor</summary>
    /// <param name="dataSourceObject">Объект источника данных</param>
    public ElmaObjectGeneratorGlobalDataSource(object dataSourceObject)
    {
      ElmaObjectGeneratorGlobalDataSource.Oa6VKdB3pWtPOjPJvoZp();
      // ISSUE: explicit constructor call
      base.\u002Ector(ElmaObjectGeneratorGlobalDataSource.wuMJ5HB3atN5qhIj6CPT(dataSourceObject));
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            this.dataSourceObjectMetadata = dataSourceObject == null ? (ClassMetadata) null : MetadataLoader.LoadMetadata(ElmaObjectGeneratorGlobalDataSource.wuMJ5HB3atN5qhIj6CPT(dataSourceObject).GetType()) as ClassMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_5:
      return;
label_3:;
    }

    protected override FormatedValue GetValue(string[] propertyNames)
    {
      switch (1)
      {
        case 1:
          FormatedValue formatedValue1;
          try
          {
            if (propertyNames != null)
            {
              int num1 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
                num1 = 0;
              IEnumerable<IElmaParserGlobalValue> extensionPoints;
              IEnumerator<IElmaParserGlobalValue> enumerator;
              while (true)
              {
                switch (num1)
                {
                  case 1:
                    extensionPoints = ((ComponentManager) ElmaObjectGeneratorGlobalDataSource.RIvbVvB3DeNrftUyEKqw()).GetExtensionPoints<IElmaParserGlobalValue>();
                    num1 = 4;
                    continue;
                  case 2:
                  case 3:
                  case 7:
                    goto label_30;
                  case 4:
                    if (extensionPoints.Count<IElmaParserGlobalValue>() <= 0)
                    {
                      num1 = 7;
                      continue;
                    }
                    goto case 5;
                  case 5:
                    enumerator = extensionPoints.GetEnumerator();
                    num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 6 : 6;
                    continue;
                  case 6:
                    goto label_6;
                  default:
                    if (((IEnumerable<string>) propertyNames).Count<string>() <= 0)
                    {
                      num1 = 2;
                      continue;
                    }
                    goto case 1;
                }
              }
label_6:
              try
              {
label_10:
                if (ElmaObjectGeneratorGlobalDataSource.L7BiWSB3wF40tPBYZQ4n((object) enumerator))
                  goto label_12;
                else
                  goto label_11;
label_7:
                FormatedValue formatedValue2;
                int num2;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      goto label_30;
                    case 2:
                      formatedValue1 = formatedValue2;
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 6;
                      continue;
                    case 3:
                      if (formatedValue2 == null)
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 4 : 5;
                        continue;
                      }
                      goto case 2;
                    case 4:
                      goto label_12;
                    case 6:
                      goto label_31;
                    default:
                      goto label_10;
                  }
                }
label_11:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
                goto label_7;
label_12:
                formatedValue2 = (FormatedValue) ElmaObjectGeneratorGlobalDataSource.jEHWyCB3tVio7F85mmGT((object) enumerator.Current, (object) propertyNames);
                num2 = 3;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
                {
                  num2 = 3;
                  goto label_7;
                }
                else
                  goto label_7;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num3 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
                    num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        enumerator.Dispose();
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_20;
                    }
                  }
                }
label_20:;
              }
            }
            else
              break;
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  ElmaObjectGeneratorGlobalDataSource.e1HxbmB3AZPj3kx2MW7r(ElmaObjectGeneratorGlobalDataSource.jKFSruB349eRQZbLduOv(), ElmaObjectGeneratorGlobalDataSource.jiCjiPB3HdAJQWGrIbuk((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867744238), ElmaObjectGeneratorGlobalDataSource.GTmJgrB36QH4OarXWbek((object) ex)), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_30;
              }
            }
          }
label_31:
          return formatedValue1;
      }
label_30:
      FormatedValue formatedValue3 = new FormatedValue();
      ElmaObjectGeneratorGlobalDataSource.zndtamB375iZ53uYbQst((object) formatedValue3, (object) "");
      return formatedValue3;
    }

    internal static void Oa6VKdB3pWtPOjPJvoZp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object wuMJ5HB3atN5qhIj6CPT([In] object obj0) => obj0.CastAsRealType();

    internal static bool KQbxWEB3Nuck6x60ZiqX() => ElmaObjectGeneratorGlobalDataSource.Upinc7B310L4gdrN8EGG == null;

    internal static ElmaObjectGeneratorGlobalDataSource IVLVgEB33quK7VT0KDPw() => ElmaObjectGeneratorGlobalDataSource.Upinc7B310L4gdrN8EGG;

    internal static object RIvbVvB3DeNrftUyEKqw() => (object) ComponentManager.Current;

    internal static object jEHWyCB3tVio7F85mmGT([In] object obj0, [In] object obj1) => (object) ((IElmaParserGlobalValue) obj0).Parse((string[]) obj1);

    internal static bool L7BiWSB3wF40tPBYZQ4n([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object jKFSruB349eRQZbLduOv() => (object) Logger.Log;

    internal static object GTmJgrB36QH4OarXWbek([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static object jiCjiPB3HdAJQWGrIbuk([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void e1HxbmB3AZPj3kx2MW7r([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void zndtamB375iZ53uYbQst([In] object obj0, [In] object obj1) => ((FormatedValue) obj0).Value = obj1;
  }
}
