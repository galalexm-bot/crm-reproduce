// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Memory.MemoryStreamExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.IO;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Memory
{
  /// <summary>
  /// Методы расширения для <see cref="T:System.IO.MemoryStream" />
  /// </summary>
  public static class MemoryStreamExtensions
  {
    internal static MemoryStreamExtensions VEA5S1BexftnL2DSP5lV;

    /// <summary>
    /// Преобразовать <see cref="T:System.IO.MemoryStream" /> к незакрываемому
    /// </summary>
    /// <param name="memoryStream">Поток в памяти</param>
    /// <returns>Поток в памяти</returns>
    public static MemoryStream AsNoClose(this MemoryStream memoryStream)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(memoryStream is MemoryStreamExtensions.NoCloseMemoryStream))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return memoryStream;
label_3:
      return (MemoryStream) new MemoryStreamExtensions.NoCloseMemoryStream(memoryStream);
    }

    /// <summary>
    /// Преобразовать <see cref="T:System.IO.MemoryStream" /> в потокобезопасный <see cref="T:System.IO.MemoryStream" /> доступный только для чтения
    /// </summary>
    /// <param name="memoryStream">Поток в памяти</param>
    /// <returns>Поток в памяти только для чтения</returns>
    public static MemoryStream AsReadOnly(this MemoryStream memoryStream)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!(memoryStream is MemoryStreamExtensions.MultipleReadingMemoryStream))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return memoryStream;
label_5:
      return (MemoryStream) new MemoryStreamExtensions.MultipleReadingMemoryStream(memoryStream);
    }

    /// <summary>
    /// Преобразовать <see cref="T:System.IO.MemoryStream" /> в строку c использование указанной кодировки
    /// </summary>
    /// <param name="memoryStream">Поток в памяти&gt;</param>
    /// <param name="encoding">Кодировка символов</param>
    /// <returns>Результирующая строка</returns>
    public static string AsString(this MemoryStream memoryStream, Encoding encoding)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            MemoryStreamExtensions.XLBDCPBeMfO4OqLpDDAg((object) encoding, MemoryStreamExtensions.WEjkkkBeyVImbamepCcu(1242972401 >> 4 ^ 77617797));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
            continue;
          case 3:
            MemoryStreamExtensions.XLBDCPBeMfO4OqLpDDAg((object) memoryStream, MemoryStreamExtensions.WEjkkkBeyVImbamepCcu(-87337865 ^ -87397863));
            num = 2;
            continue;
          case 4:
            goto label_5;
          default:
            if (!(memoryStream is NativeMemoryStream nativeMemoryStream))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 4 : 2;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      return (string) MemoryStreamExtensions.rOxKuiBeJrwxIHgYYSbX((object) nativeMemoryStream, (object) encoding);
label_5:
      return encoding.GetString((byte[]) MemoryStreamExtensions.gjaxuxBe9gXbBVDBgkSU((object) memoryStream), 0, (int) memoryStream.Length);
    }

    /// <summary>
    /// Получить хек-код содержимого внутренного буфера <see cref="T:System.IO.MemoryStream" />
    /// </summary>
    /// <param name="memoryStream">Поток в памяти</param>
    /// <returns>Хеш-код</returns>
    public static int GetContentHashCode(this MemoryStream memoryStream)
    {
      int num1 = 10;
      int contentHashCode;
      int num2;
      ArraySegment<byte> buffer;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 13:
            contentHashCode *= 31;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 2;
            continue;
          case 2:
            contentHashCode += (int) buffer.Array[buffer.Offset + num2];
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          case 3:
            contentHashCode = 1;
            num1 = 4;
            continue;
          case 4:
            num2 = 0;
            num1 = 6;
            continue;
          case 5:
            goto label_2;
          case 6:
          case 8:
            if (num2 < buffer.Count)
            {
              num1 = 13;
              continue;
            }
            goto label_2;
          case 7:
            goto label_3;
          case 9:
            if (!(memoryStream is NativeMemoryStream nativeMemoryStream))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 14 : 1;
              continue;
            }
            goto label_10;
          case 10:
            MemoryStreamExtensions.XLBDCPBeMfO4OqLpDDAg((object) memoryStream, MemoryStreamExtensions.WEjkkkBeyVImbamepCcu(589593376 ^ -1977315327 ^ -1459497649));
            num1 = 9;
            continue;
          case 11:
            if (buffer.Array == null)
            {
              num1 = 7;
              continue;
            }
            goto case 3;
          case 12:
            goto label_10;
          case 14:
            if (memoryStream.TryGetBuffer(out buffer))
            {
              num1 = 11;
              continue;
            }
            goto label_3;
          default:
            ++num2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 8 : 2;
            continue;
        }
      }
label_2:
      return contentHashCode;
label_3:
      return 1;
label_10:
      return MemoryStreamExtensions.cqeSeCBedblOl1DHlHLZ((object) nativeMemoryStream);
    }

    /// <summary>
    /// Создать копию <see cref="T:System.IO.MemoryStream" />
    /// </summary>
    /// <param name="originalMemoryStream">Оригинальный <see cref="T:System.IO.MemoryStream" /></param>
    /// <returns>Копия</returns>
    public static MemoryStream CloneMemoryStream(this MemoryStream originalMemoryStream)
    {
      int num = 5;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num)
        {
          case 1:
            MemoryStreamExtensions.PfKi3HBegS83KtaF6MDY((object) originalMemoryStream, 0L, SeekOrigin.Begin);
            num = 6;
            continue;
          case 2:
            MemoryStreamExtensions.PfKi3HBegS83KtaF6MDY((object) memoryStream, 0L, SeekOrigin.Begin);
            num = 3;
            continue;
          case 3:
            goto label_7;
          case 4:
            memoryStream = (MemoryStream) MemoryStreamExtensions.FsuLujBerLEblBfx3Qmv((int) MemoryStreamExtensions.wKxvwuBelNc2RryNrM9p((object) originalMemoryStream));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
            continue;
          case 5:
            if (originalMemoryStream != null)
            {
              num = 4;
              continue;
            }
            goto label_8;
          case 6:
            MemoryStreamExtensions.tYb9e5Be5BTtNjYdeeDl((object) originalMemoryStream, (object) memoryStream);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          default:
            MemoryStreamExtensions.PfKi3HBegS83KtaF6MDY((object) originalMemoryStream, 0L, SeekOrigin.Begin);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 2;
            continue;
        }
      }
label_7:
      return memoryStream;
label_8:
      return (MemoryStream) null;
    }

    internal static bool cAkMRrBe0M0ltEDpcEfY() => MemoryStreamExtensions.VEA5S1BexftnL2DSP5lV == null;

    internal static MemoryStreamExtensions TEUppdBemKlCHl0pCCeD() => MemoryStreamExtensions.VEA5S1BexftnL2DSP5lV;

    internal static object WEjkkkBeyVImbamepCcu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void XLBDCPBeMfO4OqLpDDAg([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object rOxKuiBeJrwxIHgYYSbX([In] object obj0, [In] object obj1) => (object) ((NativeMemoryStream) obj0).AsString((Encoding) obj1);

    internal static object gjaxuxBe9gXbBVDBgkSU([In] object obj0) => (object) ((MemoryStream) obj0).GetBuffer();

    internal static int cqeSeCBedblOl1DHlHLZ([In] object obj0) => ((NativeMemoryStream) obj0).GetContentHashCode();

    internal static long wKxvwuBelNc2RryNrM9p([In] object obj0) => ((Stream) obj0).Length;

    internal static object FsuLujBerLEblBfx3Qmv(int requiredSize) => (object) MemoryHelper.GetMemoryStream(requiredSize);

    internal static long PfKi3HBegS83KtaF6MDY([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static void tYb9e5Be5BTtNjYdeeDl([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    /// <summary>
    /// Обертка над <see cref="T:System.IO.MemoryStream" />
    /// </summary>
    private sealed class NoCloseMemoryStream : MemoryStream
    {
      private readonly object memoryStream;
      internal static object cmo2MBQRp20vRRBXA9WH;

      /// <summary>Ctor</summary>
      /// <param name="memoryStream"><see cref="T:System.IO.MemoryStream" /></param>
      public NoCloseMemoryStream(MemoryStream memoryStream)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.memoryStream = (object) memoryStream;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }

      /// <inheritdoc />
      public override bool CanRead => MemoryStreamExtensions.NoCloseMemoryStream.IaBWihQRtKJ9oAjI5gYP(this.memoryStream);

      /// <inheritdoc />
      public override bool CanSeek => ((Stream) this.memoryStream).CanSeek;

      /// <inheritdoc />
      public override bool CanWrite => ((Stream) this.memoryStream).CanWrite;

      /// <inheritdoc />
      public override int Capacity
      {
        get => MemoryStreamExtensions.NoCloseMemoryStream.eVcOAoQRwbYUlFqvIMlK(this.memoryStream);
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                ((MemoryStream) this.memoryStream).Capacity = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <inheritdoc />
      public override long Length => MemoryStreamExtensions.NoCloseMemoryStream.Uk05cvQR4LXYyKbMA6Nn(this.memoryStream);

      /// <inheritdoc />
      public override long Position
      {
        get => MemoryStreamExtensions.NoCloseMemoryStream.zKqXO4QR6hP1YAFuS2RT(this.memoryStream);
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                ((Stream) this.memoryStream).Position = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <inheritdoc />
      public override bool CanTimeout => MemoryStreamExtensions.NoCloseMemoryStream.Qk199lQRHRkEaxmjPsEX(this.memoryStream);

      /// <inheritdoc />
      public override int ReadTimeout
      {
        get => MemoryStreamExtensions.NoCloseMemoryStream.eOVswLQRAXun0m1jaFSg(this.memoryStream);
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                MemoryStreamExtensions.NoCloseMemoryStream.xCR2HKQR7VR6pmYgplq2(this.memoryStream, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <inheritdoc />
      public override int WriteTimeout
      {
        get => MemoryStreamExtensions.NoCloseMemoryStream.OiUnuhQRxtugJYIJ98Y8(this.memoryStream);
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                MemoryStreamExtensions.NoCloseMemoryStream.Ki6o6TQR00cbXq4VxZhc(this.memoryStream, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <inheritdoc />
      public override void Flush()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              MemoryStreamExtensions.NoCloseMemoryStream.XCh1hHQRmdpbvvGf2UQ9(this.memoryStream);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <inheritdoc />
      public override Task FlushAsync(CancellationToken cancellationToken) => (Task) MemoryStreamExtensions.NoCloseMemoryStream.x1YdSuQRyynTxcuy4uxF(this.memoryStream, cancellationToken);

      /// <inheritdoc />
      public override byte[] GetBuffer() => ((MemoryStream) this.memoryStream).GetBuffer();

      /// <inheritdoc />
      public override bool TryGetBuffer(out ArraySegment<byte> buffer) => ((MemoryStream) this.memoryStream).TryGetBuffer(out buffer);

      /// <inheritdoc />
      public override int Read(byte[] buffer, int offset, int count) => MemoryStreamExtensions.NoCloseMemoryStream.arTTIiQRMskjSATd1FtP(this.memoryStream, (object) buffer, offset, count);

      /// <inheritdoc />
      public override Task<int> ReadAsync(
        byte[] buffer,
        int offset,
        int count,
        CancellationToken cancellationToken)
      {
        return ((Stream) this.memoryStream).ReadAsync(buffer, offset, count, cancellationToken);
      }

      /// <inheritdoc />
      public override int ReadByte() => MemoryStreamExtensions.NoCloseMemoryStream.xRVjLqQRJ41ompXrEL6k(this.memoryStream);

      /// <inheritdoc />
      public override Task CopyToAsync(
        Stream destination,
        int bufferSize,
        CancellationToken cancellationToken)
      {
        return (Task) MemoryStreamExtensions.NoCloseMemoryStream.RqxcDoQR9B7LS7FBArbW(this.memoryStream, (object) destination, bufferSize, cancellationToken);
      }

      /// <inheritdoc />
      public override long Seek(long offset, SeekOrigin loc) => MemoryStreamExtensions.NoCloseMemoryStream.rf6VxUQRdhJS4yS4X8j8(this.memoryStream, offset, loc);

      /// <inheritdoc />
      public override void SetLength(long value)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              MemoryStreamExtensions.NoCloseMemoryStream.NScDFhQRliSLicJDLXgD(this.memoryStream, value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <inheritdoc />
      public override byte[] ToArray() => ((MemoryStream) this.memoryStream).ToArray();

      /// <inheritdoc />
      public override void Write(byte[] buffer, int offset, int count)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              MemoryStreamExtensions.NoCloseMemoryStream.CIakDyQRrpaNIIfb5XBg(this.memoryStream, (object) buffer, offset, count);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <inheritdoc />
      public override Task WriteAsync(
        byte[] buffer,
        int offset,
        int count,
        CancellationToken cancellationToken)
      {
        return ((Stream) this.memoryStream).WriteAsync(buffer, offset, count, cancellationToken);
      }

      /// <inheritdoc />
      public override void WriteByte(byte value)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              MemoryStreamExtensions.NoCloseMemoryStream.yMUNFgQRg7Rx0lRlTVTP(this.memoryStream, value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <inheritdoc />
      public override void WriteTo(Stream stream)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ((MemoryStream) this.memoryStream).WriteTo(stream);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <inheritdoc />
      public override void Close()
      {
      }

      /// <inheritdoc />
      public override IAsyncResult BeginRead(
        byte[] buffer,
        int offset,
        int count,
        AsyncCallback callback,
        object state)
      {
        return ((Stream) this.memoryStream).BeginRead(buffer, offset, count, callback, state);
      }

      /// <inheritdoc />
      public override int EndRead(IAsyncResult asyncResult) => MemoryStreamExtensions.NoCloseMemoryStream.ye3xFvQR5aYnlP1NEcBW(this.memoryStream, (object) asyncResult);

      /// <inheritdoc />
      public override IAsyncResult BeginWrite(
        byte[] buffer,
        int offset,
        int count,
        AsyncCallback callback,
        object state)
      {
        return (IAsyncResult) MemoryStreamExtensions.NoCloseMemoryStream.cLvvL9QRjdH56ZFMA4mv(this.memoryStream, (object) buffer, offset, count, (object) callback, state);
      }

      /// <inheritdoc />
      public override void EndWrite(IAsyncResult asyncResult)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              MemoryStreamExtensions.NoCloseMemoryStream.eVApOpQRYCLv8GTc6dHe(this.memoryStream, (object) asyncResult);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <inheritdoc />
      public override object InitializeLifetimeService() => MemoryStreamExtensions.NoCloseMemoryStream.mCKXwTQRLYEZhcoDhhRA(this.memoryStream);

      /// <inheritdoc />
      public override ObjRef CreateObjRef(Type requestedType) => (ObjRef) MemoryStreamExtensions.NoCloseMemoryStream.QWiqurQRUHrgtjhV4OsF(this.memoryStream, requestedType);

      /// <inheritdoc />
      public override string ToString() => this.memoryStream.ToString();

      /// <inheritdoc />
      public override bool Equals(object obj) => this.memoryStream.Equals(obj);

      /// <inheritdoc />
      public override int GetHashCode() => this.memoryStream.GetHashCode();

      /// <inheritdoc />
      protected override void Dispose(bool disposing)
      {
      }

      internal static bool O5TbPMQRa0Z8JkBF2RM5() => MemoryStreamExtensions.NoCloseMemoryStream.cmo2MBQRp20vRRBXA9WH == null;

      internal static MemoryStreamExtensions.NoCloseMemoryStream eiGttUQRDaCofBOf1Slj() => (MemoryStreamExtensions.NoCloseMemoryStream) MemoryStreamExtensions.NoCloseMemoryStream.cmo2MBQRp20vRRBXA9WH;

      internal static bool IaBWihQRtKJ9oAjI5gYP([In] object obj0) => ((Stream) obj0).CanRead;

      internal static int eVcOAoQRwbYUlFqvIMlK([In] object obj0) => ((MemoryStream) obj0).Capacity;

      internal static long Uk05cvQR4LXYyKbMA6Nn([In] object obj0) => ((Stream) obj0).Length;

      internal static long zKqXO4QR6hP1YAFuS2RT([In] object obj0) => ((Stream) obj0).Position;

      internal static bool Qk199lQRHRkEaxmjPsEX([In] object obj0) => ((Stream) obj0).CanTimeout;

      internal static int eOVswLQRAXun0m1jaFSg([In] object obj0) => ((Stream) obj0).ReadTimeout;

      internal static void xCR2HKQR7VR6pmYgplq2([In] object obj0, [In] int obj1) => ((Stream) obj0).ReadTimeout = obj1;

      internal static int OiUnuhQRxtugJYIJ98Y8([In] object obj0) => ((Stream) obj0).WriteTimeout;

      internal static void Ki6o6TQR00cbXq4VxZhc([In] object obj0, [In] int obj1) => ((Stream) obj0).WriteTimeout = obj1;

      internal static void XCh1hHQRmdpbvvGf2UQ9([In] object obj0) => ((Stream) obj0).Flush();

      internal static object x1YdSuQRyynTxcuy4uxF([In] object obj0, [In] CancellationToken obj1) => (object) ((Stream) obj0).FlushAsync(obj1);

      internal static int arTTIiQRMskjSATd1FtP([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Read((byte[]) obj1, obj2, obj3);

      internal static int xRVjLqQRJ41ompXrEL6k([In] object obj0) => ((Stream) obj0).ReadByte();

      internal static object RqxcDoQR9B7LS7FBArbW(
        [In] object obj0,
        [In] object obj1,
        [In] int obj2,
        [In] CancellationToken obj3)
      {
        return (object) ((Stream) obj0).CopyToAsync((Stream) obj1, obj2, obj3);
      }

      internal static long rf6VxUQRdhJS4yS4X8j8([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

      internal static void NScDFhQRliSLicJDLXgD([In] object obj0, [In] long obj1) => ((Stream) obj0).SetLength(obj1);

      internal static void CIakDyQRrpaNIIfb5XBg([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Write((byte[]) obj1, obj2, obj3);

      internal static void yMUNFgQRg7Rx0lRlTVTP([In] object obj0, [In] byte obj1) => ((Stream) obj0).WriteByte(obj1);

      internal static int ye3xFvQR5aYnlP1NEcBW([In] object obj0, [In] object obj1) => ((Stream) obj0).EndRead((IAsyncResult) obj1);

      internal static object cLvvL9QRjdH56ZFMA4mv(
        [In] object obj0,
        [In] object obj1,
        [In] int obj2,
        [In] int obj3,
        [In] object obj4,
        [In] object obj5)
      {
        return (object) ((Stream) obj0).BeginWrite((byte[]) obj1, obj2, obj3, (AsyncCallback) obj4, obj5);
      }

      internal static void eVApOpQRYCLv8GTc6dHe([In] object obj0, [In] object obj1) => ((Stream) obj0).EndWrite((IAsyncResult) obj1);

      internal static object mCKXwTQRLYEZhcoDhhRA([In] object obj0) => ((MarshalByRefObject) obj0).InitializeLifetimeService();

      internal static object QWiqurQRUHrgtjhV4OsF([In] object obj0, [In] Type obj1) => (object) ((MarshalByRefObject) obj0).CreateObjRef(obj1);
    }

    /// <summary>
    /// Обертка над <see cref="T:System.IO.MemoryStream" /> обеспечивающая поддержку потокобезопасного параллельного чтения
    /// </summary>
    private sealed class MultipleReadingMemoryStream : MemoryStream
    {
      private readonly object memoryStream;
      private static readonly AsyncLocal<long> asyncLocalPosition;
      private readonly object semaphore;
      private static object n1tKm7QRsJxoC2YUplyQ;

      /// <summary>Ctor</summary>
      /// <param name="memoryStream"><see cref="T:System.IO.MemoryStream" /></param>
      public MultipleReadingMemoryStream(MemoryStream memoryStream)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.semaphore = (object) new SemaphoreSlim(1, 1);
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.memoryStream = (object) memoryStream;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      /// <inheritdoc />
      public override bool CanRead => MemoryStreamExtensions.MultipleReadingMemoryStream.sutriAQqF2g3mhBaLUOW(this.memoryStream);

      /// <inheritdoc />
      public override bool CanSeek => MemoryStreamExtensions.MultipleReadingMemoryStream.DpQGobQqBUnyrDedqNRx(this.memoryStream);

      /// <inheritdoc />
      public override bool CanWrite => false;

      /// <inheritdoc />
      public override int Capacity
      {
        get => MemoryStreamExtensions.MultipleReadingMemoryStream.YegFwMQqWehZXAVRrgKG(this.memoryStream);
        set => throw new NotImplementedException();
      }

      /// <inheritdoc />
      public override long Length => MemoryStreamExtensions.MultipleReadingMemoryStream.BCf4cLQqoJXMJ7FSlnRG(this.memoryStream);

      /// <inheritdoc />
      public override long Position
      {
        get => MemoryStreamExtensions.MultipleReadingMemoryStream.asyncLocalPosition.Value;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                MemoryStreamExtensions.MultipleReadingMemoryStream.asyncLocalPosition.Value = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <inheritdoc />
      public override bool CanTimeout => MemoryStreamExtensions.MultipleReadingMemoryStream.dOLj0iQqbbYZoFuZ03dL(this.memoryStream);

      /// <inheritdoc />
      public override int ReadTimeout
      {
        get => MemoryStreamExtensions.MultipleReadingMemoryStream.CwIyt1QqhuZNc11uLCZ8(this.memoryStream);
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                MemoryStreamExtensions.MultipleReadingMemoryStream.eFhiNEQqGv4penf1uRKZ(this.memoryStream, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      /// <inheritdoc />
      public override int WriteTimeout
      {
        get => MemoryStreamExtensions.MultipleReadingMemoryStream.zbHVE8QqEHgTJPiYrvTR(this.memoryStream);
        set => throw new NotImplementedException();
      }

      /// <inheritdoc />
      public override void Flush() => throw new NotImplementedException();

      /// <inheritdoc />
      public override Task FlushAsync(CancellationToken cancellationToken) => throw new NotImplementedException();

      /// <inheritdoc />
      public override byte[] GetBuffer() => (byte[]) MemoryStreamExtensions.MultipleReadingMemoryStream.EQPW8QQqfZ5aDL2PyJbK(this.memoryStream);

      /// <inheritdoc />
      public override bool TryGetBuffer(out ArraySegment<byte> buffer) => ((MemoryStream) this.memoryStream).TryGetBuffer(out buffer);

      /// <inheritdoc />
      public override int Read(byte[] buffer, int offset, int count)
      {
        int num1;
        switch (1)
        {
          case 1:
            try
            {
              MemoryStreamExtensions.MultipleReadingMemoryStream.f7VBRHQqQPZ1cwDgLlQr(this.semaphore);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
                num2 = 0;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    int num3 = MemoryStreamExtensions.MultipleReadingMemoryStream.EUwXZ4Qq81dXExT6yQ2j(this.memoryStream, (object) buffer, offset, count);
                    this.Position = MemoryStreamExtensions.MultipleReadingMemoryStream.dAqq7oQqCtV6Y6DeW0s2(this.memoryStream);
                    num1 = num3;
                    num2 = 2;
                    continue;
                  case 2:
                    goto label_10;
                  default:
                    MemoryStreamExtensions.MultipleReadingMemoryStream.He1CCgQqvPsvO1fHd1mI(this.memoryStream, MemoryStreamExtensions.MultipleReadingMemoryStream.dAqq7oQqCtV6Y6DeW0s2((object) this));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 1;
                    continue;
                }
              }
            }
            finally
            {
              ((SemaphoreSlim) this.semaphore).Release();
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
                num4 = 0;
              switch (num4)
              {
                default:
              }
            }
        }
label_10:
        return num1;
      }

      /// <inheritdoc />
      public override async Task<int> ReadAsync(
        byte[] buffer,
        int offset,
        int count,
        CancellationToken cancellationToken)
      {
        int num1 = 3;
        int num2;
        MemoryStreamExtensions.MultipleReadingMemoryStream readingMemoryStream;
        int result1;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_52;
            case 1:
label_2:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = -2;
              num1 = 5;
              continue;
            case 2:
              readingMemoryStream = this;
              num1 = 4;
              continue;
            case 3:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              num2 = (^this).\u003C\u003E1__state;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 2;
              continue;
            case 4:
              try
              {
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
                  num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_8;
                  }
                }
label_8:
                try
                {
                  int num4;
                  if (num2 != 0)
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 5 : 0;
                  else
                    goto label_25;
label_12:
                  TaskAwaiter taskAwaiter1;
                  TaskAwaiter awaiter1;
                  while (true)
                  {
                    TaskAwaiter<int> taskAwaiter2;
                    int num5;
                    TaskAwaiter<int> awaiter2;
                    switch (num4)
                    {
                      case 1:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 0;
                        num5 = 8;
                        break;
                      case 2:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, MemoryStreamExtensions.MultipleReadingMemoryStream.\u003CReadAsync\u003Ed__31>(ref awaiter2, this);
                        num4 = 15;
                        continue;
                      case 3:
                        taskAwaiter1 = new TaskAwaiter();
                        num4 = 9;
                        continue;
                      case 4:
                        taskAwaiter2 = awaiter2;
                        num4 = 2;
                        continue;
                      case 5:
                        if (num2 != 1)
                        {
                          num4 = 21;
                          continue;
                        }
                        goto case 12;
                      case 6:
                        goto label_2;
                      case 7:
                        int result2 = awaiter2.GetResult();
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        MemoryStreamExtensions.MultipleReadingMemoryStream.\u003CReadAsync\u003Ed__31.s1coYHZvkTSq6pbV1uJX((object) readingMemoryStream, MemoryStreamExtensions.MultipleReadingMemoryStream.\u003CReadAsync\u003Ed__31.DslmUVZvTw5hEQOUQTkV(readingMemoryStream.memoryStream));
                        result1 = result2;
                        num4 = 6;
                        continue;
                      case 8:
                        taskAwaiter1 = awaiter1;
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 22 : 5;
                        continue;
                      case 9:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = -1;
                        num4 = 18;
                        continue;
                      case 10:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = -1;
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 7 : 7;
                        continue;
                      case 11:
                        if (!awaiter2.IsCompleted)
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 16 : 11;
                          continue;
                        }
                        goto case 7;
                      case 12:
                        awaiter2 = taskAwaiter2;
                        num4 = 13;
                        continue;
                      case 13:
                        taskAwaiter2 = new TaskAwaiter<int>();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 10 : 1;
                        continue;
                      case 14:
                        goto label_43;
                      case 15:
                        goto label_38;
                      case 16:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003E1__state = num2 = 1;
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 4 : 4;
                        continue;
                      case 17:
                        goto label_25;
                      case 18:
                        awaiter1.GetResult();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                        continue;
                      case 19:
                        if (!awaiter1.IsCompleted)
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
                          continue;
                        }
                        goto case 18;
                      case 20:
                        awaiter2 = ((Stream) readingMemoryStream.memoryStream).ReadAsync(buffer, offset, count, cancellationToken).GetAwaiter();
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 11 : 11;
                        continue;
                      case 21:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        awaiter1 = MemoryStreamExtensions.MultipleReadingMemoryStream.\u003CReadAsync\u003Ed__31.UAr2u5ZvXjo9OvDmnjyA(MemoryStreamExtensions.MultipleReadingMemoryStream.\u003CReadAsync\u003Ed__31.wgVnZCZvKY2EUoOxOv61(readingMemoryStream.semaphore, cancellationToken));
                        num4 = 19;
                        continue;
                      case 22:
                        // ISSUE: explicit reference operation
                        // ISSUE: reference to a compiler-generated field
                        (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, MemoryStreamExtensions.MultipleReadingMemoryStream.\u003CReadAsync\u003Ed__31>(ref awaiter1, this);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 14 : 4;
                        continue;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        ((Stream) readingMemoryStream.memoryStream).Position = MemoryStreamExtensions.MultipleReadingMemoryStream.\u003CReadAsync\u003Ed__31.DslmUVZvTw5hEQOUQTkV((object) readingMemoryStream);
                        num5 = 20;
                        break;
                    }
                    num4 = num5;
                  }
label_43:
                  return;
label_38:
                  return;
label_25:
                  awaiter1 = taskAwaiter1;
                  num4 = 3;
                  goto label_12;
                }
                finally
                {
                  if (num2 < 0)
                  {
                    int num6 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
                      num6 = 0;
                    while (true)
                    {
                      switch (num6)
                      {
                        case 1:
                          goto label_45;
                        default:
                          // ISSUE: reference to a compiler-generated method
                          MemoryStreamExtensions.MultipleReadingMemoryStream.\u003CReadAsync\u003Ed__31.CCM7r2ZvngEbrAcjiuug(readingMemoryStream.semaphore);
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
                          continue;
                      }
                    }
                  }
label_45:;
                }
              }
              catch (Exception ex)
              {
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
                  num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 0:
                      goto label_28;
                    case 1:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = -2;
                      num7 = 2;
                      continue;
                    case 2:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.SetException(ex);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_26;
                  }
                }
label_28:
                return;
label_26:
                return;
              }
            case 5:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003Et__builder.SetResult(result1);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            default:
              goto label_49;
          }
        }
label_52:
        return;
label_49:;
      }

      /// <inheritdoc />
      public override int ReadByte()
      {
        int num1;
        switch (1)
        {
          case 1:
            try
            {
              MemoryStreamExtensions.MultipleReadingMemoryStream.f7VBRHQqQPZ1cwDgLlQr(this.semaphore);
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    int num3 = ((Stream) this.memoryStream).ReadByte();
                    MemoryStreamExtensions.MultipleReadingMemoryStream.He1CCgQqvPsvO1fHd1mI((object) this, MemoryStreamExtensions.MultipleReadingMemoryStream.dAqq7oQqCtV6Y6DeW0s2(this.memoryStream));
                    num1 = num3;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
                    continue;
                  case 2:
                    MemoryStreamExtensions.MultipleReadingMemoryStream.He1CCgQqvPsvO1fHd1mI(this.memoryStream, MemoryStreamExtensions.MultipleReadingMemoryStream.dAqq7oQqCtV6Y6DeW0s2((object) this));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_1;
                }
              }
            }
            finally
            {
              MemoryStreamExtensions.MultipleReadingMemoryStream.A7uFiPQqZ6ukpNFAVSII(this.semaphore);
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
                num4 = 0;
              switch (num4)
              {
                default:
              }
            }
        }
label_1:
        return num1;
      }

      /// <inheritdoc />
      public override Task CopyToAsync(
        Stream destination,
        int bufferSize,
        CancellationToken cancellationToken)
      {
        int num = 4;
        // ISSUE: variable of a compiler-generated type
        MemoryStreamExtensions.MultipleReadingMemoryStream.\u003CCopyToAsync\u003Ed__33 stateMachine;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              stateMachine.cancellationToken = cancellationToken;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 6 : 8;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num = 7;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.destination = destination;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num = 3;
              continue;
            case 5:
              goto label_2;
            case 6:
              tBuilder.Start<MemoryStreamExtensions.MultipleReadingMemoryStream.\u003CCopyToAsync\u003Ed__33>(ref stateMachine);
              num = 5;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 2 : 6;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = MemoryStreamExtensions.MultipleReadingMemoryStream.nk4vocQqu1x8eqR9jxKK();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 1;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              stateMachine.bufferSize = bufferSize;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
              continue;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated field
        return stateMachine.\u003C\u003Et__builder.Task;
      }

      /// <inheritdoc />
      public override long Seek(long offset, SeekOrigin loc)
      {
        long num1;
        switch (1)
        {
          case 1:
            try
            {
              MemoryStreamExtensions.MultipleReadingMemoryStream.f7VBRHQqQPZ1cwDgLlQr(this.semaphore);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
                num2 = 0;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_10;
                  case 2:
                    long num3 = MemoryStreamExtensions.MultipleReadingMemoryStream.lG21r1QqIF4LAieE80jw(this.memoryStream, offset, loc);
                    MemoryStreamExtensions.MultipleReadingMemoryStream.He1CCgQqvPsvO1fHd1mI((object) this, MemoryStreamExtensions.MultipleReadingMemoryStream.dAqq7oQqCtV6Y6DeW0s2(this.memoryStream));
                    num1 = num3;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 1;
                    continue;
                  default:
                    ((Stream) this.memoryStream).Position = this.Position;
                    num2 = 2;
                    continue;
                }
              }
            }
            finally
            {
              ((SemaphoreSlim) this.semaphore).Release();
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
                num4 = 0;
              switch (num4)
              {
                default:
              }
            }
        }
label_10:
        return num1;
      }

      /// <inheritdoc />
      public override void SetLength(long value) => throw new NotImplementedException();

      /// <inheritdoc />
      public override byte[] ToArray() => (byte[]) MemoryStreamExtensions.MultipleReadingMemoryStream.rZp78qQqVG5n8ortMlQR(this.memoryStream);

      /// <inheritdoc />
      public override void Write(byte[] buffer, int offset, int count) => throw new NotImplementedException();

      /// <inheritdoc />
      public override Task WriteAsync(
        byte[] buffer,
        int offset,
        int count,
        CancellationToken cancellationToken)
      {
        throw new NotImplementedException();
      }

      /// <inheritdoc />
      public override void WriteByte(byte value) => throw new NotImplementedException();

      /// <inheritdoc />
      public override void WriteTo(Stream stream) => throw new NotImplementedException();

      /// <inheritdoc />
      public override void Close()
      {
      }

      /// <inheritdoc />
      public override IAsyncResult BeginRead(
        byte[] buffer,
        int offset,
        int count,
        AsyncCallback callback,
        object state)
      {
        return (IAsyncResult) MemoryStreamExtensions.MultipleReadingMemoryStream.JiJnmAQqSJn2Af07Fj58(this.memoryStream, (object) buffer, offset, count, (object) callback, state);
      }

      /// <inheritdoc />
      public override int EndRead(IAsyncResult asyncResult) => MemoryStreamExtensions.MultipleReadingMemoryStream.dxr3q7QqiyJJreE1WKmv(this.memoryStream, (object) asyncResult);

      /// <inheritdoc />
      public override IAsyncResult BeginWrite(
        byte[] buffer,
        int offset,
        int count,
        AsyncCallback callback,
        object state)
      {
        throw new NotImplementedException();
      }

      /// <inheritdoc />
      public override void EndWrite(IAsyncResult asyncResult) => throw new NotImplementedException();

      /// <inheritdoc />
      public override object InitializeLifetimeService() => MemoryStreamExtensions.MultipleReadingMemoryStream.YeilTsQqRGEU1JCFNJ1M(this.memoryStream);

      /// <inheritdoc />
      public override ObjRef CreateObjRef(Type requestedType) => ((MarshalByRefObject) this.memoryStream).CreateObjRef(requestedType);

      /// <inheritdoc />
      public override string ToString() => this.memoryStream.ToString();

      /// <inheritdoc />
      public override bool Equals(object obj) => this.memoryStream.Equals(obj);

      /// <inheritdoc />
      public override int GetHashCode() => this.memoryStream.GetHashCode();

      /// <inheritdoc />
      protected override void Dispose(bool disposing)
      {
      }

      static MultipleReadingMemoryStream()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              MemoryStreamExtensions.MultipleReadingMemoryStream.asyncLocalPosition = new AsyncLocal<long>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            case 2:
              MemoryStreamExtensions.MultipleReadingMemoryStream.KLCR6DQqqos8rAQVUAxX();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static bool vFWyetQRcjiuATAhV88t() => MemoryStreamExtensions.MultipleReadingMemoryStream.n1tKm7QRsJxoC2YUplyQ == null;

      internal static MemoryStreamExtensions.MultipleReadingMemoryStream d9F0V8QRzTxImd2ZAvuf() => (MemoryStreamExtensions.MultipleReadingMemoryStream) MemoryStreamExtensions.MultipleReadingMemoryStream.n1tKm7QRsJxoC2YUplyQ;

      internal static bool sutriAQqF2g3mhBaLUOW([In] object obj0) => ((Stream) obj0).CanRead;

      internal static bool DpQGobQqBUnyrDedqNRx([In] object obj0) => ((Stream) obj0).CanSeek;

      internal static int YegFwMQqWehZXAVRrgKG([In] object obj0) => ((MemoryStream) obj0).Capacity;

      internal static long BCf4cLQqoJXMJ7FSlnRG([In] object obj0) => ((Stream) obj0).Length;

      internal static bool dOLj0iQqbbYZoFuZ03dL([In] object obj0) => ((Stream) obj0).CanTimeout;

      internal static int CwIyt1QqhuZNc11uLCZ8([In] object obj0) => ((Stream) obj0).ReadTimeout;

      internal static void eFhiNEQqGv4penf1uRKZ([In] object obj0, [In] int obj1) => ((Stream) obj0).ReadTimeout = obj1;

      internal static int zbHVE8QqEHgTJPiYrvTR([In] object obj0) => ((Stream) obj0).WriteTimeout;

      internal static object EQPW8QQqfZ5aDL2PyJbK([In] object obj0) => (object) ((MemoryStream) obj0).GetBuffer();

      internal static void f7VBRHQqQPZ1cwDgLlQr([In] object obj0) => ((SemaphoreSlim) obj0).Wait();

      internal static long dAqq7oQqCtV6Y6DeW0s2([In] object obj0) => ((Stream) obj0).Position;

      internal static void He1CCgQqvPsvO1fHd1mI([In] object obj0, [In] long obj1) => ((Stream) obj0).Position = obj1;

      internal static int EUwXZ4Qq81dXExT6yQ2j([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Read((byte[]) obj1, obj2, obj3);

      internal static int A7uFiPQqZ6ukpNFAVSII([In] object obj0) => ((SemaphoreSlim) obj0).Release();

      internal static AsyncTaskMethodBuilder nk4vocQqu1x8eqR9jxKK() => AsyncTaskMethodBuilder.Create();

      internal static long lG21r1QqIF4LAieE80jw([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

      internal static object rZp78qQqVG5n8ortMlQR([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();

      internal static object JiJnmAQqSJn2Af07Fj58(
        [In] object obj0,
        [In] object obj1,
        [In] int obj2,
        [In] int obj3,
        [In] object obj4,
        [In] object obj5)
      {
        return (object) ((Stream) obj0).BeginRead((byte[]) obj1, obj2, obj3, (AsyncCallback) obj4, obj5);
      }

      internal static int dxr3q7QqiyJJreE1WKmv([In] object obj0, [In] object obj1) => ((Stream) obj0).EndRead((IAsyncResult) obj1);

      internal static object YeilTsQqRGEU1JCFNJ1M([In] object obj0) => ((MarshalByRefObject) obj0).InitializeLifetimeService();

      internal static void KLCR6DQqqos8rAQVUAxX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
