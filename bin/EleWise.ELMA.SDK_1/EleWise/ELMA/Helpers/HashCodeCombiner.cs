// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.HashCodeCombiner
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  public class HashCodeCombiner
  {
    private long combinedHash;
    private static HashCodeCombiner xyXyXdhssTtQq13QLEfc;

    public HashCodeCombiner()
    {
      HashCodeCombiner.LyqkIxhcFJaMN2vxLfKB();
      // ISSUE: explicit constructor call
      this.\u002Ector(5381L);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public HashCodeCombiner(long init)
    {
      HashCodeCombiner.LyqkIxhcFJaMN2vxLfKB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.combinedHash = init;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public void AddInt(int n)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.combinedHash = (this.combinedHash << 5) + this.combinedHash ^ (long) n;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void AddEnumerable(IEnumerable source)
    {
      int num1 = 3;
      IEnumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_22;
          case 1:
            goto label_3;
          case 2:
            goto label_14;
          case 3:
            if (source == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 2 : 2;
              continue;
            }
            goto case 4;
          case 4:
            enumerator = (IEnumerator) HashCodeCombiner.qH6l2BhcBMP1pEGSIQnF((object) source);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_22:
      return;
label_14:
      return;
label_2:
      return;
label_3:
      try
      {
label_9:
        if (HashCodeCombiner.RoA8QIhcoWFwIhpdpC8e((object) enumerator))
          goto label_7;
        else
          goto label_10;
label_4:
        object o;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_11;
            case 1:
              this.AddObject(o);
              num2 = 2;
              continue;
            case 2:
              goto label_9;
            case 3:
              goto label_7;
            default:
              goto label_5;
          }
        }
label_11:
        return;
label_5:
        return;
label_7:
        o = HashCodeCombiner.imxw7shcWHckE275mVYj((object) enumerator);
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
label_10:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
        goto label_4;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num3 = 2;
        while (true)
        {
          switch (num3)
          {
            case 1:
              HashCodeCombiner.s5RwathcbpesaVuLtkdN((object) disposable);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            case 2:
              if (disposable != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
                continue;
              }
              goto label_18;
            default:
              goto label_18;
          }
        }
label_18:;
      }
    }

    public void AddObject(object o)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            this.AddInt(o.GetHashCode());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (o == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 2;
              continue;
            }
            goto case 1;
          default:
            goto label_7;
        }
      }
label_5:
      return;
label_2:
      return;
label_7:;
    }

    public void AddDateTime(DateTime dt)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AddInt(dt.GetHashCode());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void AddFile(string fileName)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            goto label_2;
          case 3:
            if (!HashCodeCombiner.UlrFvfhchkCE0BP9VCVf((object) fileName))
            {
              num = 2;
              continue;
            }
            break;
        }
        this.AddExistingFile(fileName);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
      }
label_3:
      return;
label_2:;
    }

    public void AddFile(FileInfo info)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            if (HashCodeCombiner.l8WiGrhcGHGVdXYdG7Qm((object) info))
            {
              num = 3;
              continue;
            }
            goto label_9;
          case 2:
            if (info != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
              continue;
            }
            goto label_8;
          case 3:
            this.AddExistingFile(info);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          default:
            goto label_10;
        }
      }
label_2:
      return;
label_10:
      return;
label_8:
      return;
label_9:;
    }

    public long CombinedHash => this.combinedHash;

    public int CombinedHash32 => this.combinedHash.GetHashCode();

    public string CombinedHashString => this.combinedHash.ToString((string) HashCodeCombiner.f1xbhOhcEM0qaksFT91P(1505778440 - 1981636111 ^ -475996727), (IFormatProvider) HashCodeCombiner.uayH07hcfVybvCkNJ2aD());

    private void AddExistingFile(string fileName)
    {
      int num1 = 1;
      FileInfo fileInfo;
      DateTime dt;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            fileInfo = new FileInfo(fileName);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          case 2:
            this.AddFileSize(fileInfo.Length);
            num1 = 5;
            continue;
          case 3:
            num2 = dt.Second % 2;
            num1 = 4;
            continue;
          case 4:
            dt = HashCodeCombiner.zEPFN0hcCVoPm8YavSqV(dt.Date, TimeSpan.FromSeconds((double) ((int) dt.TimeOfDay.TotalSeconds - num2)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 6;
            continue;
          case 5:
            goto label_2;
          case 6:
            this.AddDateTime(dt);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 2 : 2;
            continue;
          default:
            dt = HashCodeCombiner.h8WJT5hcQOSGyvmorwat((object) fileInfo);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 3;
            continue;
        }
      }
label_2:;
    }

    private void AddExistingFile(FileInfo info)
    {
      int num1 = 4;
      DateTime dt;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.AddFileSize(info.Length);
            num1 = 5;
            continue;
          case 2:
            dt = HashCodeCombiner.zEPFN0hcCVoPm8YavSqV(dt.Date, HashCodeCombiner.gwSW56hcvhpuXQpOZC21((double) ((int) dt.TimeOfDay.TotalSeconds - num2)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          case 3:
            num2 = dt.Second % 2;
            num1 = 2;
            continue;
          case 4:
            dt = HashCodeCombiner.h8WJT5hcQOSGyvmorwat((object) info);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 3 : 3;
            continue;
          case 5:
            goto label_2;
          default:
            this.AddDateTime(dt);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    private void AddFileSize(long fileSize)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AddInt(fileSize.GetHashCode());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void LyqkIxhcFJaMN2vxLfKB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Dw0mW9hscmwyJpmMIqTG() => HashCodeCombiner.xyXyXdhssTtQq13QLEfc == null;

    internal static HashCodeCombiner n5HYpJhszKtlOr9FFCGf() => HashCodeCombiner.xyXyXdhssTtQq13QLEfc;

    internal static object qH6l2BhcBMP1pEGSIQnF([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object imxw7shcWHckE275mVYj([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static bool RoA8QIhcoWFwIhpdpC8e([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void s5RwathcbpesaVuLtkdN([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool UlrFvfhchkCE0BP9VCVf([In] object obj0) => File.Exists((string) obj0);

    internal static bool l8WiGrhcGHGVdXYdG7Qm([In] object obj0) => ((FileSystemInfo) obj0).Exists;

    internal static object f1xbhOhcEM0qaksFT91P(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object uayH07hcfVybvCkNJ2aD() => (object) CultureInfo.InvariantCulture;

    internal static DateTime h8WJT5hcQOSGyvmorwat([In] object obj0) => ((FileSystemInfo) obj0).LastWriteTime;

    internal static DateTime zEPFN0hcCVoPm8YavSqV([In] DateTime obj0, [In] TimeSpan obj1) => obj0 + obj1;

    internal static TimeSpan gwSW56hcvhpuXQpOZC21([In] double obj0) => TimeSpan.FromSeconds(obj0);
  }
}
