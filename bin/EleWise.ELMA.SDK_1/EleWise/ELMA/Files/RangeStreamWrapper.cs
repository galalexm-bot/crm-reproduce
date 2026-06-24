// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.RangeStreamWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files
{
  public class RangeStreamWrapper : Stream
  {
    private readonly Stream baseStream;
    private readonly long offsetStart;
    private readonly long offsetEnd;
    private long position;
    private static RangeStreamWrapper YrgCfqGX7ZD88JchgfG2;

    public RangeStreamWrapper([NotNull] Stream stream, long offsetStart, long offsetEnd)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
        num1 = 1;
      long num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            if (stream != null)
            {
              if (!stream.CanRead)
              {
                num1 = 8;
                continue;
              }
              if (offsetEnd <= offsetStart)
              {
                num1 = 13;
                continue;
              }
              if (offsetEnd >= stream.Length)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 7;
                continue;
              }
              this.baseStream = stream;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 4 : 1;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 1;
            continue;
          case 3:
            this.offsetEnd = offsetEnd;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 0 : 0;
            continue;
          case 4:
            this.offsetStart = offsetStart;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 3;
            continue;
          case 5:
            RangeStreamWrapper.EJeUbCGXJ6BY5Kg9Ojco((object) this, 0L);
            num1 = 6;
            continue;
          case 6:
            goto label_13;
          case 7:
            goto label_27;
          case 8:
            goto label_10;
          case 9:
            if (num2 >= offsetStart)
            {
              num1 = 14;
              continue;
            }
            goto case 5;
          case 10:
            goto label_9;
          case 11:
            this.Position = offsetEnd - offsetStart;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 7 : 12;
            continue;
          case 12:
            goto label_6;
          case 13:
            goto label_24;
          case 14:
            if (num2 <= offsetEnd)
            {
              RangeStreamWrapper.EJeUbCGXJ6BY5Kg9Ojco((object) this, num2 - offsetStart);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 10 : 9;
              continue;
            }
            num1 = 11;
            continue;
          default:
            num2 = RangeStreamWrapper.os8v7bGXMCs8GoaRxAOJ((object) stream);
            num1 = 9;
            continue;
        }
      }
label_13:
      return;
label_9:
      return;
label_6:
      return;
label_3:
      throw new ArgumentNullException((string) RangeStreamWrapper.CnnoiRGXmDFTsgB57bu4(-740338220 ^ -740521112));
label_10:
      throw new ArgumentException((string) RangeStreamWrapper.mu7oVBGXyUKysLKZ1MWo(RangeStreamWrapper.CnnoiRGXmDFTsgB57bu4(1642859704 ^ 1643106932)), (string) RangeStreamWrapper.CnnoiRGXmDFTsgB57bu4(647913418 ^ 647856502));
label_24:
      throw new ArgumentOutOfRangeException((string) RangeStreamWrapper.mu7oVBGXyUKysLKZ1MWo((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306693036)));
label_27:
      throw new ArgumentOutOfRangeException((string) RangeStreamWrapper.mu7oVBGXyUKysLKZ1MWo(RangeStreamWrapper.CnnoiRGXmDFTsgB57bu4(-951514650 ^ -951396678)));
    }

    public override void Flush() => throw new NotSupportedException((string) RangeStreamWrapper.mu7oVBGXyUKysLKZ1MWo(RangeStreamWrapper.CnnoiRGXmDFTsgB57bu4(-1146510045 ^ -1146455317)));

    public override long Seek(long offset, SeekOrigin origin)
    {
      int num1 = 22;
      long num2;
      while (true)
      {
        int num3 = num1;
        long num4;
        long num5;
        long num6;
        while (true)
        {
          switch (num3)
          {
            case 2:
              num5 = this.offsetEnd;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 18 : 10;
              continue;
            case 3:
              num4 = this.offsetEnd;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 5 : 3;
              continue;
            case 4:
            case 8:
              goto label_4;
            case 5:
            case 6:
              num2 = RangeStreamWrapper.lp4SC6GXd7Au6pVIMQm5((object) this.baseStream, num4, SeekOrigin.Begin);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 2 : 11;
              continue;
            case 7:
              if (offset <= 0L)
              {
                num3 = 17;
                continue;
              }
              goto label_20;
            case 9:
label_29:
              num5 = RangeStreamWrapper.os8v7bGXMCs8GoaRxAOJ((object) this.baseStream) + offset;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 13 : 5;
              continue;
            case 10:
              num6 = this.offsetStart;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 21 : 25;
              continue;
            case 11:
            case 12:
            case 15:
              goto label_5;
            case 13:
              if (num5 >= this.offsetStart)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                continue;
              }
              goto case 14;
            case 14:
              num5 = this.offsetStart;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 1;
              continue;
            case 16:
              goto label_20;
            case 17:
              switch (origin)
              {
                case SeekOrigin.Begin:
                  goto label_8;
                case SeekOrigin.Current:
                  goto label_29;
                case SeekOrigin.End:
                  goto label_27;
                default:
                  num3 = 8;
                  continue;
              }
            case 18:
              num2 = RangeStreamWrapper.lp4SC6GXd7Au6pVIMQm5((object) this.baseStream, num5, SeekOrigin.Begin);
              num3 = 15;
              continue;
            case 19:
            case 25:
              goto label_32;
            case 20:
              if (num4 <= this.offsetEnd)
              {
                num3 = 6;
                continue;
              }
              goto case 3;
            case 21:
              goto label_23;
            case 22:
              if (!RangeStreamWrapper.rQ4RZJGX9kIRqTF0LyA7((object) this))
              {
                num3 = 21;
                continue;
              }
              if (origin == SeekOrigin.End)
              {
                num3 = 7;
                continue;
              }
              goto case 17;
            case 23:
label_8:
              num4 = this.offsetStart + offset;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 3 : 20;
              continue;
            case 24:
label_27:
              num6 = this.offsetEnd + offset;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 17 : 26;
              continue;
            case 26:
              if (num6 >= this.offsetStart)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 12 : 19;
                continue;
              }
              goto case 10;
            case 27:
              goto label_28;
            default:
              if (num5 > this.offsetEnd)
              {
                num3 = 2;
                continue;
              }
              goto case 18;
          }
        }
label_5:
        this.position = RangeStreamWrapper.os8v7bGXMCs8GoaRxAOJ((object) this.baseStream) - this.offsetStart;
        num1 = 27;
        continue;
label_32:
        num2 = RangeStreamWrapper.lp4SC6GXd7Au6pVIMQm5((object) this.baseStream, num6, SeekOrigin.Begin);
        num1 = 12;
      }
label_4:
      throw new ArgumentOutOfRangeException((string) RangeStreamWrapper.CnnoiRGXmDFTsgB57bu4(-1380439818 << 3 ^ 1841473324));
label_20:
      throw new ArgumentException((string) RangeStreamWrapper.mu7oVBGXyUKysLKZ1MWo((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 88034553)), (string) RangeStreamWrapper.CnnoiRGXmDFTsgB57bu4(964881585 - -1459193222 ^ -1870687557));
label_23:
      throw new NotSupportedException(EleWise.ELMA.SR.T((string) RangeStreamWrapper.CnnoiRGXmDFTsgB57bu4(-1255365154 ^ 596875508 ^ -1766006058)));
label_28:
      return num2;
    }

    public override void SetLength(long value) => throw new NotSupportedException((string) RangeStreamWrapper.mu7oVBGXyUKysLKZ1MWo(RangeStreamWrapper.CnnoiRGXmDFTsgB57bu4(1669212571 ^ 1669199443)));

    public override int Read(byte[] buffer, int offset, int count)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            count = (int) (RangeStreamWrapper.H8xIWRGXlOFBhOo9st0G((object) this) - RangeStreamWrapper.os8v7bGXMCs8GoaRxAOJ((object) this));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
            continue;
          case 2:
            if (RangeStreamWrapper.os8v7bGXMCs8GoaRxAOJ((object) this) + (long) count > RangeStreamWrapper.H8xIWRGXlOFBhOo9st0G((object) this))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          default:
            goto label_5;
        }
      }
label_5:
      int num2 = this.baseStream.Read(buffer, offset, count);
      this.position = RangeStreamWrapper.os8v7bGXMCs8GoaRxAOJ((object) this.baseStream) - this.offsetStart;
      return num2;
    }

    public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException(EleWise.ELMA.SR.T((string) RangeStreamWrapper.CnnoiRGXmDFTsgB57bu4(901793403 ^ 902011315)));

    public override bool CanRead => this.baseStream.CanRead;

    public override bool CanSeek => this.baseStream.CanSeek;

    public override bool CanWrite => false;

    public override long Length => RangeStreamWrapper.Sk7BUUGXreMhlDQCE3KJ(0L, this.offsetEnd - this.offsetStart + 1L);

    public override long Position
    {
      get => this.position;
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
              RangeStreamWrapper.lp4SC6GXd7Au6pVIMQm5((object) this, value, SeekOrigin.Begin);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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

    /// <summary>Закрыть частичный поток.</summary>
    public override void Close()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            RangeStreamWrapper.FKT5I2GXgBJUIoHYCwqE((object) this.baseStream);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static object CnnoiRGXmDFTsgB57bu4(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object mu7oVBGXyUKysLKZ1MWo([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static long os8v7bGXMCs8GoaRxAOJ([In] object obj0) => ((Stream) obj0).Position;

    internal static void EJeUbCGXJ6BY5Kg9Ojco([In] object obj0, [In] long obj1) => ((Stream) obj0).Position = obj1;

    internal static bool j7AvxCGXxwUlYBssCLwy() => RangeStreamWrapper.YrgCfqGX7ZD88JchgfG2 == null;

    internal static RangeStreamWrapper bmOLI9GX0LRYBQ9Pnpwl() => RangeStreamWrapper.YrgCfqGX7ZD88JchgfG2;

    internal static bool rQ4RZJGX9kIRqTF0LyA7([In] object obj0) => ((Stream) obj0).CanSeek;

    internal static long lp4SC6GXd7Au6pVIMQm5([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static long H8xIWRGXlOFBhOo9st0G([In] object obj0) => ((Stream) obj0).Length;

    internal static long Sk7BUUGXreMhlDQCE3KJ([In] long obj0, [In] long obj1) => Math.Max(obj0, obj1);

    internal static void FKT5I2GXgBJUIoHYCwqE([In] object obj0) => ((Stream) obj0).Close();
  }
}
