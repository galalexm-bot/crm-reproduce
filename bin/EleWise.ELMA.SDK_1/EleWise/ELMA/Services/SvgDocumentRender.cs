// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.SvgDocumentRender
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using EleWise.ELMA.Text;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using Svg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;

namespace EleWise.ELMA.Services
{
  /// <summary>
  /// Класс предоставляющий запись кастомных аттрибутов в тэг <see cref="T:SVG" />
  /// Используется при типизации в <seealso cref="T:EleWise.ELMA.Services.SvgHelper" />
  /// </summary>
  internal class SvgDocumentRender : SvgDocument
  {
    private IDictionary<string, string> htmlAttributes;
    internal static SvgDocumentRender vQb12OB6ltTaBZ2xyMgU;

    /// <summary>Записать аттрибуты</summary>
    /// <param name="writer">XmlTextWriter</param>
    protected override void WriteAttributes(XmlTextWriter writer)
    {
      int num1 = 2;
      IEnumerator<string> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_15;
          case 1:
            try
            {
label_5:
              if (enumerator.MoveNext())
                goto label_7;
              else
                goto label_6;
label_3:
              string current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_5;
                  case 2:
                    goto label_17;
                  case 3:
                    goto label_7;
                  default:
                    SvgDocumentRender.LLR9toB658GJkdZKQEj9((object) this, (object) current, (object) this.htmlAttributes[current], 0);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
                    continue;
                }
              }
label_6:
              num2 = 2;
              goto label_3;
label_7:
              current = enumerator.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
              {
                num2 = 0;
                goto label_3;
              }
              else
                goto label_3;
            }
            finally
            {
              int num3;
              if (enumerator == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              else
                goto label_13;
label_11:
              switch (num3)
              {
                case 2:
                  break;
                default:
              }
label_13:
              SvgDocumentRender.cddSAaB6j06TEOqoOd1S((object) enumerator);
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
              {
                num3 = 1;
                goto label_11;
              }
              else
                goto label_11;
            }
          case 2:
            enumerator = this.htmlAttributes.Keys.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
            continue;
          case 3:
label_17:
            SvgDocumentRender.puOpxPB6YlKBwYp7BQgH((object) this, (object) writer);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          default:
            goto label_12;
        }
      }
label_15:
      return;
label_12:;
    }

    /// <summary>Записать html аттрибуты</summary>
    /// <param name="htmlAttributes">HtmlAttributes</param>
    /// <returns>Содержимое элемента</returns>
    public string MergeAttributes(IDictionary<string, string> htmlAttributes)
    {
      Contract.NotNull((object) htmlAttributes, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021324625));
      this.htmlAttributes = htmlAttributes;
      using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream())
      {
        this.Write((Stream) memoryStream, false);
        if (memoryStream.Length > 0L)
          return memoryStream.AsString((Encoding) EncodingCache.UTF8WithoutEmitIdentifier);
      }
      return string.Empty;
    }

    public SvgDocumentRender()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void LLR9toB658GJkdZKQEj9([In] object obj0, [In] object obj1, [In] object obj2, [In] int obj3) => ((SvgElement) obj0).AddStyle((string) obj1, (string) obj2, obj3);

    internal static void cddSAaB6j06TEOqoOd1S([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void puOpxPB6YlKBwYp7BQgH([In] object obj0, [In] object obj1) => __nonvirtual (((SvgElement) obj0).WriteAttributes((XmlTextWriter) obj1));

    internal static bool ifb8eNB6r16jdnFTg7Jd() => SvgDocumentRender.vQb12OB6ltTaBZ2xyMgU == null;

    internal static SvgDocumentRender iuuWMCB6gwae7uK3f0lA() => SvgDocumentRender.vQb12OB6ltTaBZ2xyMgU;
  }
}
