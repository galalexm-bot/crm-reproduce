// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.StreamExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Расширения для IO потоков (Stream)</summary>
  public static class StreamExtensions
  {
    internal static StreamExtensions E4bIBFGtgUKZRfUjQRP3;

    /// <summary>Прочитать поток полностью до конца</summary>
    /// <remarks>Перенесено из NuGet в неизменном виде</remarks>
    /// <param name="stream">Поток</param>
    /// <returns>Массив прочитанных байтов</returns>
    public static byte[] ReadAllBytes(this Stream stream)
    {
      int num1 = 1;
      MemoryStream memoryStream1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (stream is MemoryStream memoryStream2)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
              continue;
            }
            memoryStream1 = memoryStream2 = MemoryHelper.GetMemoryStream();
            num1 = 3;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_5;
          default:
            goto label_15;
        }
      }
label_2:
      byte[] numArray;
      return numArray;
label_5:
      try
      {
        StreamExtensions.bwy9YgGtYY1sMB7KL3Kj((object) stream, (object) memoryStream2);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_2;
            default:
              numArray = (byte[]) StreamExtensions.IQtKajGtLDWaD8tvXf14((object) memoryStream2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 1;
              continue;
          }
        }
      }
      finally
      {
        int num3;
        if (memoryStream1 == null)
          num3 = 2;
        else
          goto label_12;
label_11:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_12:
        memoryStream1.Dispose();
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        {
          num3 = 1;
          goto label_11;
        }
        else
          goto label_11;
      }
label_15:
      return memoryStream2.ToArray();
    }

    /// <summary>
    /// Скопировать всё из потока-источника в поток-получатель. После операции потоки уничтожаются (Dispose).
    /// </summary>
    /// <param name="source">Поток-источник.</param>
    /// <param name="destination">Поток-получатель.</param>
    public static void CopyAllBytesToStream(this Stream source, Stream destination)
    {
      int num1 = 3;
      Stream stream1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_23;
          case 1:
            goto label_3;
          case 2:
            Contract.ArgumentNotNull((object) destination, (string) StreamExtensions.UBsgpoGtU2OS2em8vEpU(--1418440330 ^ 1418219718));
            num1 = 4;
            continue;
          case 3:
            StreamExtensions.lhiySPGts4yfY1NHyQP3((object) source, StreamExtensions.UBsgpoGtU2OS2em8vEpU(-97972138 ^ -97969424));
            num1 = 2;
            continue;
          case 4:
            stream1 = source;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 1;
            continue;
          default:
            goto label_15;
        }
      }
label_23:
      return;
label_15:
      return;
label_3:
      try
      {
        Stream stream2 = destination;
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              StreamExtensions.bwy9YgGtYY1sMB7KL3Kj((object) source, (object) destination);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
                num3 = 0;
              switch (num3)
              {
                case 0:
                  return;
                default:
                  return;
              }
            }
            finally
            {
              int num4;
              if (stream2 == null)
                num4 = 2;
              else
                goto label_16;
label_13:
              switch (num4)
              {
                case 1:
                case 2:
              }
label_16:
              StreamExtensions.hTSvXYGtcVrIeG1eEnLl((object) stream2);
              num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
              {
                num4 = 1;
                goto label_13;
              }
              else
                goto label_13;
            }
        }
      }
      finally
      {
        if (stream1 != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_25;
              default:
                stream1.Dispose();
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_25:;
      }
    }

    /// <summary>Сохранить все содержимое потока в файл</summary>
    /// <param name="stream">Поток-источник</param>
    /// <param name="filePath">Полный путь файла сохранения</param>
    public static void SaveToFile(this Stream stream, string filePath)
    {
      int num1 = 2;
      FileStream fileStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            StreamExtensions.W0KuAOGtzP5R2s4xZ1h5((object) filePath, StreamExtensions.UBsgpoGtU2OS2em8vEpU(-710283084 ^ -537863435 ^ 173724711));
            num1 = 5;
            continue;
          case 2:
            StreamExtensions.lhiySPGts4yfY1NHyQP3((object) stream, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883231884));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_10;
          case 4:
label_13:
            StreamExtensions.U3UoMBGwF9AmFlcD8L9O((object) stream, 0L, SeekOrigin.Begin);
            num1 = 3;
            continue;
          case 5:
            fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          default:
            try
            {
              StreamExtensions.bwy9YgGtYY1sMB7KL3Kj((object) stream, (object) fileStream);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_13;
              }
            }
            finally
            {
              if (fileStream != null)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_12;
                    default:
                      StreamExtensions.hTSvXYGtcVrIeG1eEnLl((object) fileStream);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_12:;
            }
        }
      }
label_10:;
    }

    /// <summary>Прочитать из потока асинхронно.</summary>
    /// <remarks>
    /// Код позаимстован из Samples for Parallel Programming with the .NET Framework 4
    /// </remarks>
    /// <param name="stream">Поток.</param>
    /// <param name="buffer">Массив байтов, который будет заполняться операцией чтения.</param>
    /// <param name="offset">Смещение в массиве, по которому следует начать размещение прочитанного.</param>
    /// <param name="count">Количество байт, которое требуется прочитать.</param>
    /// <returns>Системная задача с результатом "количество прочитанных байт".</returns>
    public static Task<int> ReadAsync(this Stream stream, byte[] buffer, int offset, int count)
    {
      Contract.ArgumentNotNull((object) stream, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710657930));
      return Task<int>.Factory.FromAsync<byte[], int, int>(new Func<byte[], int, int, AsyncCallback, object, IAsyncResult>(stream.BeginRead), new Func<IAsyncResult, int>(stream.EndRead), buffer, offset, count, (object) stream);
    }

    /// <summary>Записать в поток асинхронно.</summary>
    /// <remarks>
    /// Код позаимстован из Samples for Parallel Programming with the .NET Framework 4
    /// </remarks>
    /// <param name="stream">Поток.</param>
    /// <param name="buffer">Массив байтов, которые требуется записать.</param>
    /// <param name="offset">Смещение в массиве, по которому следует начать считывание записываемых данных.</param>
    /// <param name="count">Количество байт, которые требуется записать.</param>
    /// <returns>Системная задача.</returns>
    public static Task WriteAsync(this Stream stream, byte[] buffer, int offset, int count)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) stream, (string) StreamExtensions.UBsgpoGtU2OS2em8vEpU(-1852837372 ^ -1853084488));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return ((TaskFactory) StreamExtensions.d5PmTLGwBAoMSoxX4RRX()).FromAsync<byte[], int, int>(new Func<byte[], int, int, AsyncCallback, object, IAsyncResult>(stream.BeginWrite), new Action<IAsyncResult>(stream.EndWrite), buffer, offset, count, (object) stream);
    }

    /// <summary>
    /// Прочитать всё содержимое потока асинхронно и закрыть его.
    /// </summary>
    /// <remarks>
    /// Код позаимстован из Samples for Parallel Programming with the .NET Framework 4
    /// </remarks>
    /// <param name="stream">Поток.</param>
    /// <returns>Системная задача с результатом "содержимое потока".</returns>
    public static Task<byte[]> ReadAllBytesAsync(this Stream stream)
    {
      Contract.ArgumentNotNull((object) stream, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137538190));
      MemoryStream readData = MemoryHelper.GetMemoryStream(stream.CanSeek ? (int) stream.Length : 0);
      return stream.CopyStreamToStreamAsync((Stream) readData).ContinueWith<byte[]>((Func<Task, byte[]>) (t =>
      {
        int num1 = 2;
        Stream stream1;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_3;
            case 2:
              stream1 = stream;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        byte[] numArray;
        return numArray;
label_3:
        try
        {
          MemoryStream memoryStream = readData;
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
            num2 = 0;
          switch (num2)
          {
            default:
              try
              {
                // ISSUE: reference to a compiler-generated method
                StreamExtensions.\u003C\u003Ec__DisplayClass6_0.KPqWS58boA5Usir6DaRQ((object) t);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_2;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      numArray = (byte[]) StreamExtensions.\u003C\u003Ec__DisplayClass6_0.uPV9AS8bbC7GoAt0X3Xj((object) readData);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
              finally
              {
                if (memoryStream != null)
                {
                  int num4 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_16;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        StreamExtensions.\u003C\u003Ec__DisplayClass6_0.lQC6Ul8bh9A0NFnw1XjS((object) memoryStream);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 0;
                        continue;
                    }
                  }
                }
label_16:;
              }
          }
        }
        finally
        {
          if (stream1 != null)
          {
            int num5 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
              num5 = 1;
            while (true)
            {
              switch (num5)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  StreamExtensions.\u003C\u003Ec__DisplayClass6_0.lQC6Ul8bh9A0NFnw1XjS((object) stream1);
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_22;
              }
            }
          }
label_22:;
        }
      }));
    }

    /// <summary>
    /// Скопировать содержимое одного потока в другой асинхронно.
    /// </summary>
    /// <remarks>
    /// Код позаимстован из Samples for Parallel Programming with the .NET Framework 4
    /// </remarks>
    /// <param name="source">Поток-источник.</param>
    /// <param name="destination">Поток-получатель.</param>
    /// <returns>Системная задача.</returns>
    public static Task CopyStreamToStreamAsync(this Stream source, Stream destination)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            StreamExtensions.lhiySPGts4yfY1NHyQP3((object) source, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539365609));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            Contract.ArgumentNotNull((object) destination, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575972888));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 2 : 0;
            continue;
        }
      }
label_4:
      return Task.Factory.Iterate((IEnumerable<object>) StreamExtensions.CopyStreamIterator((object) source, (object) destination));
    }

    private static IEnumerable<Task> CopyStreamIterator(object input, object output) => (IEnumerable<Task>) new StreamExtensions.\u003CCopyStreamIterator\u003Ed__8(-2)
    {
      \u003C\u003E3__input = (Stream) input,
      \u003C\u003E3__output = (Stream) output
    };

    internal static void bwy9YgGtYY1sMB7KL3Kj([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static object IQtKajGtLDWaD8tvXf14([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();

    internal static bool GO9h7YGt5wbFUILjvjpV() => StreamExtensions.E4bIBFGtgUKZRfUjQRP3 == null;

    internal static StreamExtensions WmqOa3GtjqVp9IrCnfp4() => StreamExtensions.E4bIBFGtgUKZRfUjQRP3;

    internal static object UBsgpoGtU2OS2em8vEpU(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void lhiySPGts4yfY1NHyQP3([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void hTSvXYGtcVrIeG1eEnLl([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void W0KuAOGtzP5R2s4xZ1h5([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static long U3UoMBGwF9AmFlcD8L9O([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static object d5PmTLGwBAoMSoxX4RRX() => (object) Task.Factory;
  }
}
