// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Impl.MimeMappingService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Properties;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Services.Impl
{
  [Service]
  internal class MimeMappingService : IMimeMappingService
  {
    private readonly ConcurrentDictionary<string, string> mimeTypes;
    internal static MimeMappingService hYkk04BMAcPrDSfh1Nnq;

    public MimeMappingService()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.mimeTypes = new ConcurrentDictionary<string, string>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 2;
      XmlNodeList xmlNodeList;
      IEnumerator enumerator;
      XmlDocument xmlDocument;
      XmlTextReader reader;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (xmlNodeList != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 3 : 3;
              continue;
            }
            goto label_24;
          case 2:
            xmlDocument = new XmlDocument();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          case 3:
            enumerator = (IEnumerator) MimeMappingService.zTG6L1BMMECsAyyeBqCH((object) xmlNodeList);
            num1 = 7;
            continue;
          case 4:
            goto label_25;
          case 5:
label_31:
            xmlNodeList = (XmlNodeList) MimeMappingService.SWZGnGBMyivRUDEbbS89((object) xmlDocument, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411140625));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
            continue;
          case 6:
            try
            {
              xmlDocument.Load((XmlReader) reader);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_31;
              }
            }
            finally
            {
              int num3;
              if (reader == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
              else
                goto label_26;
label_23:
              switch (num3)
              {
                case 2:
                  break;
                default:
              }
label_26:
              MimeMappingService.M4yXI9BMm8euhTlwXSsn((object) reader);
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
              {
                num3 = 1;
                goto label_23;
              }
              else
                goto label_23;
            }
          case 7:
            goto label_4;
          default:
            reader = new XmlTextReader((TextReader) new StringReader((string) MimeMappingService.oypH0OBM0kqKJvbwJaLS()));
            num1 = 6;
            continue;
        }
      }
label_25:
      return;
label_24:
      return;
label_4:
      try
      {
label_7:
        if (MimeMappingService.juYxmqBMrkSFq4WivalT((object) enumerator))
          goto label_9;
        else
          goto label_8;
label_5:
        XmlNode xmlNode;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_20;
            case 2:
              goto label_9;
            case 3:
              goto label_7;
            default:
              this.mimeTypes.TryAdd((string) MimeMappingService.W9WfRoBMlpxTbPViA4cb(MimeMappingService.RgQlyjBMdoX3UcvIYpCW((object) xmlNode, MimeMappingService.LYlhgDBM9rj4yOCmyAZx(1819636893 << 3 ^ 1672138378))), (string) MimeMappingService.W9WfRoBMlpxTbPViA4cb(MimeMappingService.RgQlyjBMdoX3UcvIYpCW((object) xmlNode, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710499162))));
              num4 = 3;
              continue;
          }
        }
label_20:
        return;
label_8:
        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 1;
        goto label_5;
label_9:
        xmlNode = (XmlNode) MimeMappingService.SeDR9hBMJ0DjExOaWarS((object) enumerator);
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        {
          num4 = 0;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num5 = 2;
        while (true)
        {
          switch (num5)
          {
            case 1:
              MimeMappingService.M4yXI9BMm8euhTlwXSsn((object) disposable);
              num5 = 3;
              continue;
            case 2:
              if (disposable == null)
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            default:
              goto label_16;
          }
        }
label_16:;
      }
    }

    /// <summary>Получить тип по расширению</summary>
    /// <param name="extension"></param>
    /// <returns></returns>
    public virtual string GetTypeByExtension(string extension)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!this.mimeTypes.ContainsKey(extension))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154040405);
label_5:
      return this.mimeTypes[extension];
    }

    /// <summary>Зарегистрировать новый тип</summary>
    /// <param name="ext"></param>
    /// <param name="mimeType"></param>
    public virtual void RegisterMimeType(string ext, string mimeType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            if (!this.mimeTypes.TryRemove(ext, out string _))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_2;
          case 3:
            this.mimeTypes.TryAdd(ext, mimeType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 2 : 2;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_2:
      return;
label_7:;
    }

    internal static object oypH0OBM0kqKJvbwJaLS() => (object) Resources.MimeTypes;

    internal static void M4yXI9BMm8euhTlwXSsn([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object SWZGnGBMyivRUDEbbS89([In] object obj0, [In] object obj1) => (object) ((XmlNode) obj0).SelectNodes((string) obj1);

    internal static object zTG6L1BMMECsAyyeBqCH([In] object obj0) => (object) ((XmlNodeList) obj0).GetEnumerator();

    internal static object SeDR9hBMJ0DjExOaWarS([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static object LYlhgDBM9rj4yOCmyAZx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object RgQlyjBMdoX3UcvIYpCW([In] object obj0, [In] object obj1) => (object) ((XmlNode) obj0).SelectSingleNode((string) obj1);

    internal static object W9WfRoBMlpxTbPViA4cb([In] object obj0) => (object) ((XmlNode) obj0).InnerText;

    internal static bool juYxmqBMrkSFq4WivalT([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool tQGB0oBM7goHWk9EAISc() => MimeMappingService.hYkk04BMAcPrDSfh1Nnq == null;

    internal static MimeMappingService ro1AM3BMxIrpSMZVZmmJ() => MimeMappingService.hYkk04BMAcPrDSfh1Nnq;
  }
}
