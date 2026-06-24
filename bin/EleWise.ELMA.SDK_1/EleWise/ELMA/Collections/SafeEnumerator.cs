// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.SafeEnumerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Collections
{
  /// <summary>Thread safe Enumerator implementation</summary>
  /// <remarks>http://www.codeproject.com/Articles/56575/Thread-safe-enumeration-in-C</remarks>
  public sealed class SafeEnumerator : IEnumerator, IDisposable
  {
    private readonly IEnumerator inner;
    private readonly ReaderWriterLockSlim lockSlim;
    private static SafeEnumerator arSBp10yMb3WQM9R0E7;

    public SafeEnumerator(IEnumerator inner, ReaderWriterLockSlim lockSlim)
    {
      SafeEnumerator.NBiTsV09N0Y6icnZ0tZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.lockSlim = lockSlim;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 2 : 1;
            continue;
          case 2:
            SafeEnumerator.fYEgma0dKEMHRWCWBpp((object) lockSlim);
            num = 3;
            continue;
          case 3:
            goto label_3;
          default:
            this.inner = inner;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            SafeEnumerator.d1ENNO0lRisEFwfRCg1((object) this.lockSlim);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public bool MoveNext() => this.inner.MoveNext();

    public void Reset()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.inner.Reset();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public object Current => SafeEnumerator.bRiWQn0r0DxIC154NNF((object) this.inner);

    internal static void NBiTsV09N0Y6icnZ0tZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void fYEgma0dKEMHRWCWBpp([In] object obj0) => ((ReaderWriterLockSlim) obj0).EnterUpgradeableReadLock();

    internal static bool ki9LUg0MCvyGn8ouOiI() => SafeEnumerator.arSBp10yMb3WQM9R0E7 == null;

    internal static SafeEnumerator hLgeI30JtPua3fsP9P8() => SafeEnumerator.arSBp10yMb3WQM9R0E7;

    internal static void d1ENNO0lRisEFwfRCg1([In] object obj0) => ((ReaderWriterLockSlim) obj0).ExitUpgradeableReadLock();

    internal static object bRiWQn0r0DxIC154NNF([In] object obj0) => ((IEnumerator) obj0).Current;
  }
}
