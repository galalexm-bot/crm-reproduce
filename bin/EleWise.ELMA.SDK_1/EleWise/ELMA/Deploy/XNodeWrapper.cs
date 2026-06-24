// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.XNodeWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Linq;

namespace EleWise.ELMA.Deploy
{
  /// <summary>
  /// Класс-обертка над содержимым XML узла для работы с ним как с потоком (XmlReader-ом)
  /// </summary>
  internal sealed class XNodeWrapper : IDisposable
  {
    /// <summary>Узел XML документа, содержащий элемент Entity</summary>
    private XNode xnode;
    /// <summary>Содержимое элемента Entity</summary>
    private string nodeContext;
    /// <summary>Список созданных в процессе работе StringReader-ов</summary>
    private List<StringReader> stringReaderList;
    /// <summary>Список созданных в процессе работе XmlReader-ов</summary>
    private List<XmlReader> xmlReaderList;
    private static XNodeWrapper OgqHBfE26PLwlBI7x5ls;

    /// <summary>Ctor</summary>
    /// <param name="reader">Исходный XmlReader файла настроек</param>
    internal XNodeWrapper(XmlReader reader)
    {
      XNodeWrapper.BwD8oZE27YJ7WhUuMpLV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!XNodeWrapper.YQwEgoE2xJr47mPlFwU5((object) reader))
            {
              num = 3;
              continue;
            }
            goto case 6;
          case 2:
            this.stringReaderList = new List<StringReader>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          case 3:
          case 5:
            goto label_6;
          case 4:
            if (!XNodeWrapper.ecjFrFE2Mx3gLXCEpxiQ((object) reader))
            {
              num = 7;
              continue;
            }
            goto label_6;
          case 6:
            if (!XNodeWrapper.xF5thBE2yA6aOubSANeu(XNodeWrapper.qVr6FhE20ruFGeEIpvvx((object) reader), XNodeWrapper.E34kksE2mQc5unKe0BvO(1232639661 >> 3 ^ 153832665)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 5;
              continue;
            }
            goto case 4;
          case 7:
            this.xnode = (XNode) XNodeWrapper.qfqiOOE2JZckHYS6dnwA((object) reader);
            num = 8;
            continue;
          case 8:
            this.nodeContext = this.xnode.ToString();
            num = 2;
            continue;
          case 9:
            goto label_11;
          default:
            this.xmlReaderList = new List<XmlReader>();
            num = 9;
            continue;
        }
      }
label_11:
      return;
label_6:
      throw new ArgumentException((string) XNodeWrapper.E34kksE2mQc5unKe0BvO(--1360331293 ^ 1360092161));
    }

    /// <summary>Очистка ресурсов</summary>
    public void Dispose()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.stringReaderList.Clear();
            num = 4;
            continue;
          case 2:
            XNodeWrapper.i3fvaUE29a4u4tG9qYb0((object) this.xmlReaderList);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            this.xmlReaderList.ForEach((Action<XmlReader>) (x => XNodeWrapper.\u003C\u003Ec.PPMtUW8Xz26yJmk8oMyy((object) x)));
            num = 2;
            continue;
          case 4:
            goto label_2;
          default:
            // ISSUE: reference to a compiler-generated method
            this.stringReaderList.ForEach((Action<StringReader>) (x => XNodeWrapper.\u003C\u003Ec.R2Ut5v8TFoPsAli9Xo5Z((object) x)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Получить значение TypeUid для данного Entity</summary>
    /// <returns>Guid типа</returns>
    internal Guid GetTypeUid()
    {
      int num = 1;
      Guid result;
      while (true)
      {
        switch (num)
        {
          case 1:
            XmlReader xmlReader = this.GetXmlReader();
            XNodeWrapper.SxxLPXE2dLgCfgFFj8pI((object) xmlReader, XNodeWrapper.E34kksE2mQc5unKe0BvO(95909607 + 343705423 ^ 439598164));
            Guid.TryParse(xmlReader.GetAttribute((string) XNodeWrapper.E34kksE2mQc5unKe0BvO(1925118608 << 2 ^ -889477086)), out result);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return result;
    }

    /// <summary>
    /// Возвращает новый XmlReader, спозиционированный на начало сущности
    /// </summary>
    /// <returns>XmlReader</returns>
    internal XmlReader GetXmlReader()
    {
      XmlReader xmlReader = this.CreateXmlReader();
      xmlReader.ReadToFollowing((string) XNodeWrapper.E34kksE2mQc5unKe0BvO(~541731958 ^ -542012027));
      return xmlReader;
    }

    /// <summary>
    /// Создание XmlReader по содержимому XML узла (внутри класс XmlTextReaderImpl, такой же как при создании из файла)
    /// XmlTextReaderImpl удобнее, чем стандартный XNodeReader так как хранит позицию курсора.
    /// </summary>
    private XmlReader CreateXmlReader()
    {
      int num = 2;
      XmlTextReader xmlReader;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.xmlReaderList.Add((XmlReader) xmlReader);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 2:
            xmlReader = new XmlTextReader((TextReader) this.CreateStringReader());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (XmlReader) xmlReader;
    }

    /// <summary>Создание StringReader по содержимому XML узла</summary>
    private StringReader CreateStringReader()
    {
      int num = 1;
      StringReader stringReader;
      while (true)
      {
        switch (num)
        {
          case 1:
            stringReader = new StringReader(this.nodeContext);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.stringReaderList.Add(stringReader);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return stringReader;
    }

    internal static void BwD8oZE27YJ7WhUuMpLV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool YQwEgoE2xJr47mPlFwU5([In] object obj0) => ((XmlReader) obj0).IsStartElement();

    internal static object qVr6FhE20ruFGeEIpvvx([In] object obj0) => (object) ((XmlReader) obj0).Name;

    internal static object E34kksE2mQc5unKe0BvO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool xF5thBE2yA6aOubSANeu([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool ecjFrFE2Mx3gLXCEpxiQ([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static object qfqiOOE2JZckHYS6dnwA([In] object obj0) => (object) XNode.ReadFrom((XmlReader) obj0);

    internal static bool dSTPiJE2HWGdDgMiicah() => XNodeWrapper.OgqHBfE26PLwlBI7x5ls == null;

    internal static XNodeWrapper JORCqFE2AjsT8gMuKf19() => XNodeWrapper.OgqHBfE26PLwlBI7x5ls;

    internal static void i3fvaUE29a4u4tG9qYb0([In] object obj0) => ((List<XmlReader>) obj0).Clear();

    internal static bool SxxLPXE2dLgCfgFFj8pI([In] object obj0, [In] object obj1) => ((XmlReader) obj0).MoveToAttribute((string) obj1);
  }
}
