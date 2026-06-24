// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.HashCodeCombiner
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace Microsoft.Web.Mvc.ExpressionUtil
{
  internal class HashCodeCombiner
  {
    private long _combinedHash64;
    private static HashCodeCombiner V5e0ecooWE0W4sWghET;

    public int CombinedHash => this._combinedHash64.GetHashCode();

    public void AddFingerprint(ExpressionFingerprint fingerprint)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (fingerprint == null)
            {
              this.AddInt32(0);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_2;
          default:
            HashCodeCombiner.koVIHGoGL6awLqFuU6g((object) fingerprint, (object) this);
            num = 3;
            continue;
        }
      }
label_3:
      return;
label_2:;
    }

    public void AddEnumerable(IEnumerable e)
    {
      int num1 = 2;
      while (true)
      {
        int i;
        IEnumerator enumerator;
        switch (num1)
        {
          case 1:
            this.AddInt32(0);
            num1 = 4;
            continue;
          case 2:
            if (e != null)
            {
              i = 0;
              num1 = 6;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_2;
          case 4:
            goto label_15;
          case 5:
            try
            {
label_10:
              if (HashCodeCombiner.kA7WuvoQ00J4T8lTAIp((object) enumerator))
                goto label_6;
              else
                goto label_11;
label_5:
              object o;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_6;
                  case 2:
                    goto label_24;
                  case 3:
                    this.AddObject(o);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
                    continue;
                  case 4:
                    goto label_10;
                  default:
                    ++i;
                    num2 = 4;
                    continue;
                }
              }
label_6:
              o = HashCodeCombiner.AZM1bfof9ISPjVFjj2R((object) enumerator);
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
              {
                num2 = 3;
                goto label_5;
              }
              else
                goto label_5;
label_11:
              num2 = 2;
              goto label_5;
            }
            finally
            {
              IDisposable disposable = enumerator as IDisposable;
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    disposable.Dispose();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 1;
                    continue;
                  case 2:
                    goto label_19;
                  default:
                    if (disposable != null)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
                      continue;
                    }
                    goto label_19;
                }
              }
label_19:;
            }
          case 6:
            enumerator = (IEnumerator) HashCodeCombiner.w3PN6MoEriNOiprdXiq((object) e);
            num1 = 5;
            continue;
        }
label_24:
        this.AddInt32(i);
        num1 = 3;
      }
label_2:
      return;
label_15:;
    }

    public void AddInt32(int i)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this._combinedHash64 = (this._combinedHash64 << 5) + this._combinedHash64 ^ (long) i;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void AddObject(object o)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.AddInt32(o != null ? o.GetHashCode() : 0);
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

    public HashCodeCombiner()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this._combinedHash64 = 5381L;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool S1jsrLoboVDDbjuwoOb() => HashCodeCombiner.V5e0ecooWE0W4sWghET == null;

    internal static HashCodeCombiner A3G0l5ohSXKStv7rMJQ() => HashCodeCombiner.V5e0ecooWE0W4sWghET;

    internal static void koVIHGoGL6awLqFuU6g([In] object obj0, [In] object obj1) => ((ExpressionFingerprint) obj0).AddToHashCodeCombiner((HashCodeCombiner) obj1);

    internal static object w3PN6MoEriNOiprdXiq([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object AZM1bfof9ISPjVFjj2R([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static bool kA7WuvoQ00J4T8lTAIp([In] object obj0) => ((IEnumerator) obj0).MoveNext();
  }
}
