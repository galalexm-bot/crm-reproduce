// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.DataReaderExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Memory;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db
{
  /// <summary>
  /// Методы расширения для <see cref="T:System.Data.IDataReader" />
  /// </summary>
  public static class DataReaderExtensions
  {
    internal static DataReaderExtensions xhkxcyW8KqwbR1dlaR8K;

    /// <summary>
    /// Считать массив <see cref="T:System.Byte" /> из <see cref="T:System.Data.IDataReader" />
    /// </summary>
    /// <param name="reader">Читатель БД</param>
    /// <param name="columnName">Название колонки</param>
    /// <returns>Массив byte[]</returns>
    public static byte[] GetBytes([NotNull] this IDataReader reader, [NotNull] string columnName) => reader.GetBytes(reader.GetOrdinal(columnName));

    /// <summary>
    /// Считать массив <see cref="T:System.Byte" /> из <see cref="T:System.Data.IDataReader" />
    /// </summary>
    /// <param name="reader">Читатель БД</param>
    /// <param name="column">Номер колонки</param>
    /// <returns>Массив byte[]</returns>
    public static byte[] GetBytes([NotNull] this IDataReader reader, int column)
    {
      int num = 2;
      int minimumBufferLength;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(DataReaderExtensions.ueexaJW8kHyrsNo8uBmK((object) reader, column) is DBNull))
            {
              minimumBufferLength = (int) DataReaderExtensions.G0G5WVW8nQAHI5no9v9d((object) reader, column, 0L, (object) null, 0, 0);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 3;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) reader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70058458));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            goto label_5;
          case 5:
            goto label_6;
          default:
            if (minimumBufferLength != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 5;
              continue;
            }
            goto label_5;
        }
      }
label_2:
      return (byte[]) null;
label_5:
      return Array.Empty<byte>();
label_6:
      return MemoryHelper.ActionWithMemoryBuffer<byte, (IDataReader, int), byte[]>(minimumBufferLength, (reader, column), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (IDataReader, int), byte[]>(DataReaderExtensions.GetBytesAction));
    }

    /// <summary>
    /// Считать <see cref="T:System.IO.MemoryStream" /> из <see cref="T:System.Data.IDataReader" />
    /// </summary>
    /// <param name="reader">Читатель БД</param>
    /// <param name="columnName">Название колонки</param>
    /// <returns>Массив byte[]</returns>
    public static MemoryStream GetStream([NotNull] this IDataReader reader, [NotNull] string columnName) => (MemoryStream) DataReaderExtensions.piw5GpW824gx0LQm0Zba((object) reader, DataReaderExtensions.QcBb0fW8OSFbqW6ZHaRE((object) reader, (object) columnName));

    /// <summary>
    /// Считать <see cref="T:System.IO.MemoryStream" /> из <see cref="T:System.Data.IDataReader" />
    /// </summary>
    /// <param name="reader">Читатель БД</param>
    /// <param name="column">Номер колонки</param>
    /// <returns>Поток в памяти</returns>
    public static MemoryStream GetStream(this IDataReader reader, int column)
    {
      int num1 = 4;
      int bytes;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              if (bytes != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 3:
              if (DataReaderExtensions.ueexaJW8kHyrsNo8uBmK((object) reader, column) is DBNull)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 1;
                continue;
              }
              goto label_5;
            case 4:
              DataReaderExtensions.V5qOejW8PtO8cmhtyLRj((object) reader, DataReaderExtensions.FddvqVW8eLAnKsdU1R76(-1426456882 ^ 2009939514 ^ -583700238));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 3 : 3;
              continue;
            default:
              goto label_8;
          }
        }
label_5:
        bytes = (int) reader.GetBytes(column, 0L, (byte[]) null, 0, 0);
        num1 = 2;
      }
label_4:
      return (MemoryStream) null;
label_8:
      return MemoryHelper.ActionWithMemoryBuffer<byte, (IDataReader, int), MemoryStream>(bytes, (reader, column), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (IDataReader, int), MemoryStream>(DataReaderExtensions.GetStreamAction));
label_9:
      return (MemoryStream) null;
    }

    private static MemoryStream GetStreamAction(
      object buffer,
      int offset,
      int length,
      (IDataReader, int) param)
    {
      (IDataReader, int) tuple = param;
      tuple.Item1.GetBytes(tuple.Item2, 0L, (byte[]) buffer, offset, length);
      MemoryStream memoryStream = MemoryHelper.GetMemoryStream(length);
      memoryStream.Write((byte[]) buffer, offset, length);
      memoryStream.Seek(0L, SeekOrigin.Begin);
      return memoryStream;
    }

    private static byte[] GetBytesAction(
      object buffer,
      int offset,
      int length,
      (IDataReader, int) param)
    {
      (IDataReader, int) tuple = param;
      tuple.Item1.GetBytes(tuple.Item2, 0L, (byte[]) buffer, offset, length);
      byte[] destinationArray = new byte[length];
      Array.Copy((Array) buffer, offset, (Array) destinationArray, 0, length);
      return destinationArray;
    }

    internal static bool ytd3y9W8XstbfY03OfcG() => DataReaderExtensions.xhkxcyW8KqwbR1dlaR8K == null;

    internal static DataReaderExtensions cPuCOXW8TZNwp4Zalcrd() => DataReaderExtensions.xhkxcyW8KqwbR1dlaR8K;

    internal static object ueexaJW8kHyrsNo8uBmK([In] object obj0, [In] int obj1) => ((IDataRecord) obj0)[obj1];

    internal static long G0G5WVW8nQAHI5no9v9d(
      [In] object obj0,
      [In] int obj1,
      [In] long obj2,
      [In] object obj3,
      [In] int obj4,
      [In] int obj5)
    {
      return ((IDataRecord) obj0).GetBytes(obj1, obj2, (byte[]) obj3, obj4, obj5);
    }

    internal static int QcBb0fW8OSFbqW6ZHaRE([In] object obj0, [In] object obj1) => ((IDataRecord) obj0).GetOrdinal((string) obj1);

    internal static object piw5GpW824gx0LQm0Zba([In] object obj0, int column) => (object) ((IDataReader) obj0).GetStream(column);

    internal static object FddvqVW8eLAnKsdU1R76(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void V5qOejW8PtO8cmhtyLRj([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);
  }
}
