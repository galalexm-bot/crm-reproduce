// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.GlobalValueTemplateGenerator.ElmaTypeParserGlobalValue
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates.GlobalValueTemplateGenerator
{
  /// <summary>
  /// Получение значения по текстовому представлению содержимого для типов сущностей
  /// </summary>
  [Component]
  public class ElmaTypeParserGlobalValue : ElmaParserGlobalValue
  {
    internal static ElmaTypeParserGlobalValue V5dwHUBNyqBAhulUcue1;

    public override FormatedValue Parse(string[] propertyNames)
    {
      int num1 = 3;
      IMetadataService metadataService;
      IEnumerator<EntityMetadata> enumerator;
      string propertyName;
      while (true)
      {
        switch (num1)
        {
          case 1:
            propertyName = propertyNames[1];
            num1 = 5;
            continue;
          case 2:
            if (((IEnumerable<string>) propertyNames).Count<string>() == 2)
            {
              num1 = 10;
              continue;
            }
            goto label_26;
          case 3:
            if (propertyNames != null)
            {
              num1 = 2;
              continue;
            }
            goto label_26;
          case 4:
          case 11:
            goto label_26;
          case 5:
            metadataService = (IMetadataService) ElmaTypeParserGlobalValue.QRb2FVBNgPNP2WKXJTk7();
            num1 = 6;
            continue;
          case 6:
            if (metadataService == null)
            {
              num1 = 7;
              continue;
            }
            enumerator = metadataService.GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m => m.Type == EntityMetadataType.Interface)).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 8;
            continue;
          case 7:
            goto label_35;
          case 8:
            goto label_5;
          case 9:
            if (!ElmaTypeParserGlobalValue.fHYjOvBN9MvMcPOiTjk1((object) propertyNames[1]))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 1;
              continue;
            }
            goto label_26;
          case 10:
            if (!ElmaTypeParserGlobalValue.fHYjOvBN9MvMcPOiTjk1((object) propertyNames[0]))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            }
            goto label_26;
          default:
            if (!ElmaTypeParserGlobalValue.INQbdVBNrZyVIYYooT6C(ElmaTypeParserGlobalValue.OAMdwaBNd6BHkajyvt1q((object) propertyNames[0]), ElmaTypeParserGlobalValue.JZjMA5BNlK6MyjD6m735(1251470110 >> 2 ^ 312866533)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 10 : 11;
              continue;
            }
            goto case 9;
        }
      }
label_5:
      FormatedValue formatedValue1;
      try
      {
label_7:
        if (ElmaTypeParserGlobalValue.JNPeUEBNY1G8jb08YcAj((object) enumerator))
          goto label_9;
        else
          goto label_8;
label_6:
        EntityMetadata current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (current == null)
              {
                num2 = 6;
                continue;
              }
              goto case 4;
            case 2:
            case 6:
              goto label_7;
            case 3:
              FormatedValue formatedValue2 = new FormatedValue();
              ElmaTypeParserGlobalValue.tBQQqOBNjxHWvQ4OIUhB((object) formatedValue2, ElmaTypeParserGlobalValue.g4R8Y6BN5ZgsJC4HnIrR((object) this, current.ImplementationUid));
              formatedValue1 = formatedValue2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            case 4:
              if (ElmaTypeParserGlobalValue.INQbdVBNrZyVIYYooT6C((object) current.Name, (object) propertyName))
              {
                num2 = 3;
                continue;
              }
              goto label_7;
            case 5:
              goto label_9;
            case 7:
              goto label_26;
            default:
              goto label_27;
          }
        }
label_8:
        num2 = 7;
        goto label_6;
label_9:
        current = enumerator.Current;
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        {
          num2 = 1;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_21;
              default:
                enumerator.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_21:;
      }
label_27:
      return formatedValue1;
label_26:
      return (FormatedValue) null;
label_35:
      return (FormatedValue) null;
    }

    public ElmaTypeParserGlobalValue()
    {
      ElmaTypeParserGlobalValue.KZSiSVBNLp2B7uVIXaTm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool fHYjOvBN9MvMcPOiTjk1([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object OAMdwaBNd6BHkajyvt1q([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object JZjMA5BNlK6MyjD6m735(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool INQbdVBNrZyVIYYooT6C([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object QRb2FVBNgPNP2WKXJTk7() => (object) MetadataServiceContext.ServiceOrNull;

    internal static object g4R8Y6BN5ZgsJC4HnIrR([In] object obj0, Guid guid) => (object) ((ElmaParserGlobalValue) obj0).ParseGuid(guid);

    internal static void tBQQqOBNjxHWvQ4OIUhB([In] object obj0, [In] object obj1) => ((FormatedValue) obj0).Value = obj1;

    internal static bool JNPeUEBNY1G8jb08YcAj([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool nCHqjWBNM7eEG37SlaNb() => ElmaTypeParserGlobalValue.V5dwHUBNyqBAhulUcue1 == null;

    internal static ElmaTypeParserGlobalValue KtQU0oBNJ9EECqnu3Evt() => ElmaTypeParserGlobalValue.V5dwHUBNyqBAhulUcue1;

    internal static void KZSiSVBNLp2B7uVIXaTm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
