// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.XmlObjectSerializableType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  /// <summary>
  /// Тип NHibernate для хранения произвольных объектов в XML-сериализованном виде
  /// </summary>
  [Serializable]
  public class XmlObjectSerializableType : XmlSerializableType<object>
  {
    private static XmlObjectSerializableType gXhekFWyuJblupI0GHiW;

    protected override void SaveObjectToStream(Stream stream, object obj)
    {
      int num1 = 2;
      StreamWriter streamWriter;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_22;
          case 1:
            goto label_2;
          case 2:
            streamWriter = new StreamWriter(stream);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
            continue;
          default:
            goto label_14;
        }
      }
label_22:
      return;
label_14:
      return;
label_2:
      try
      {
        XmlObjectSerializableType.HpKNQUWySHT4W8ZgPbZs((object) streamWriter, (object) obj.GetType().AssemblyQualifiedName);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
          num2 = 0;
        XmlWriter writer;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            default:
              writer = (XmlWriter) XmlObjectSerializableType.trJ80ZWyikEjhIMyf86S((object) streamWriter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
              continue;
          }
        }
label_6:
        try
        {
          ClassSerializationHelper.SerializeObjectByXml(obj, writer);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
            num3 = 0;
          switch (num3)
          {
          }
        }
        finally
        {
          int num4;
          if (writer == null)
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 2 : 0;
          else
            goto label_15;
label_12:
          switch (num4)
          {
            case 1:
              break;
            default:
          }
label_15:
          XmlObjectSerializableType.IodpApWyRFoH6AE7E3r4((object) writer);
          num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
          {
            num4 = 0;
            goto label_12;
          }
          else
            goto label_12;
        }
      }
      finally
      {
        if (streamWriter != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_24;
              default:
                streamWriter.Dispose();
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
                continue;
            }
          }
        }
label_24:;
      }
    }

    protected override object LoadObjectFromStream(Stream stream)
    {
      int num1 = 2;
      StreamReader input;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            input = new StreamReader(stream);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
            continue;
          default:
            goto label_22;
        }
      }
label_2:
      object obj;
      try
      {
        Type tp = XmlObjectSerializableType.j413faWyKfI0GGiE1pFN(XmlObjectSerializableType.FuwnqHWyqICsguRbl2en((object) input));
        int num2 = 2;
        XmlTextReader reader;
        while (true)
        {
          switch (num2)
          {
            case 1:
              reader = new XmlTextReader((TextReader) input);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
              continue;
            case 2:
              XmlObjectSerializableType.EcNq8AWyXlATYfdl1KfB((object) input);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        try
        {
          obj = ClassSerializationHelper.DeserializeObjectByXml(tp, (XmlReader) reader);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
            num3 = 0;
          switch (num3)
          {
          }
        }
        finally
        {
          int num4;
          if (reader == null)
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 2 : 2;
          else
            goto label_13;
label_12:
          switch (num4)
          {
            case 1:
            case 2:
          }
label_13:
          XmlObjectSerializableType.IodpApWyRFoH6AE7E3r4((object) reader);
          num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
          {
            num4 = 0;
            goto label_12;
          }
          else
            goto label_12;
        }
      }
      finally
      {
        if (input != null)
        {
          int num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                input.Dispose();
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                continue;
              default:
                goto label_21;
            }
          }
        }
label_21:;
      }
label_22:
      return obj;
    }

    public XmlObjectSerializableType()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void HpKNQUWySHT4W8ZgPbZs([In] object obj0, [In] object obj1) => ((TextWriter) obj0).WriteLine((string) obj1);

    internal static object trJ80ZWyikEjhIMyf86S([In] object obj0) => (object) XmlWriter.Create((TextWriter) obj0);

    internal static void IodpApWyRFoH6AE7E3r4([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool Em3nNqWyIVZAuhHYfchW() => XmlObjectSerializableType.gXhekFWyuJblupI0GHiW == null;

    internal static XmlObjectSerializableType m57LhsWyVvLsyAK0XFyW() => XmlObjectSerializableType.gXhekFWyuJblupI0GHiW;

    internal static object FuwnqHWyqICsguRbl2en([In] object obj0) => (object) ((TextReader) obj0).ReadLine();

    internal static Type j413faWyKfI0GGiE1pFN([In] object obj0) => Type.GetType((string) obj0);

    internal static void EcNq8AWyXlATYfdl1KfB([In] object obj0) => ((StreamReader) obj0).CheckAndCorrectInternalBOMSymbols();
  }
}
