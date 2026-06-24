// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.XmlSerializer`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.IO;
using System.Xml.Serialization;

namespace EleWise.ELMA.Serialization
{
  /// <summary>Типизированный сериализатор XML</summary>
  /// <typeparam name="T">Тип объекта сериализации</typeparam>
  public static class XmlSerializer<T>
  {
    internal static object y37C2dB5VLyDqKhsDIOM;

    /// <summary>Сериализовать объект в файл</summary>
    /// <param name="obj">Объект</param>
    /// <returns>Сериализованные данные</returns>
    public static string Serialize(object obj)
    {
      int num1 = 2;
      XmlSerializer xmlSerializer;
      StringWriter stringWriter;
      while (true)
      {
        switch (num1)
        {
          case 1:
            stringWriter = new StringWriter();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 3 : 0;
            continue;
          case 2:
            xmlSerializer = new XmlSerializer(typeof (T));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_14;
        }
      }
label_2:
      string str;
      try
      {
        xmlSerializer.Serialize((TextWriter) stringWriter, obj);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_14;
            default:
              str = stringWriter.ToString();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
              continue;
          }
        }
      }
      finally
      {
        int num3;
        if (stringWriter == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
        else
          goto label_9;
label_8:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_9:
        stringWriter.Dispose();
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        {
          num3 = 0;
          goto label_8;
        }
        else
          goto label_8;
      }
label_14:
      return str;
    }

    /// <summary>Десериализовать объект из файла</summary>
    /// <param name="data">Сериализованные данные</param>
    /// <returns>Объект</returns>
    public static T Deserialize(string data)
    {
      using (StringReader stringReader = new StringReader(data))
        return (T) new XmlSerializer(typeof (T)).Deserialize((TextReader) stringReader);
    }

    /// <summary>Сериализовать объект в файл</summary>
    /// <param name="fileName">Полное имя файла</param>
    /// <param name="obj">Объект</param>
    public static void SerializeToFile(string fileName, object obj)
    {
      int num1 = 2;
      FileStream fileStream;
      XmlSerializer xmlSerializer;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_13;
          case 1:
            fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            num1 = 3;
            continue;
          case 2:
            xmlSerializer = new XmlSerializer(typeof (T));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_4;
          default:
            goto label_8;
        }
      }
label_13:
      return;
label_8:
      return;
label_4:
      try
      {
        xmlSerializer.Serialize((Stream) fileStream, obj);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        if (fileStream != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                fileStream.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
    }

    /// <summary>Десериализовать объект из файла</summary>
    /// <param name="fileName">Полное имя файла</param>
    /// <returns>Объект</returns>
    public static T DeserializeFromFile(string fileName)
    {
      using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
        return (T) new XmlSerializer(typeof (T)).Deserialize((Stream) fileStream);
    }

    internal static bool INo7RNB5SGOU11UxLByT() => XmlSerializer<T>.y37C2dB5VLyDqKhsDIOM == null;

    internal static object M6ObSwB5iG38rFOXb4uy() => XmlSerializer<T>.y37C2dB5VLyDqKhsDIOM;
  }
}
