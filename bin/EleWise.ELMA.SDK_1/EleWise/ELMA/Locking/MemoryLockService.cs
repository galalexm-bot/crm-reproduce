// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Locking.MemoryLockService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Locking
{
  /// <summary>Сервис блокировок на памяти</summary>
  internal class MemoryLockService : LockService<MemoryLockServiceSettings>
  {
    internal static MemoryLockService tqVNdshgkwXSYLA5LVTE;

    /// <inheritdoc />
    protected override Lock AcquireLockInternalImpl(
      string name,
      TimeSpan maxValidFor,
      TimeSpan timeout,
      TimeSpan repeatInterval)
    {
      return new Lock(name, maxValidFor, (System.Action) null);
    }

    /// <inheritdoc />
    protected override Task<Lock> AcquireLockInternalAsyncImpl(
      string name,
      CancellationToken token,
      TimeSpan maxValidFor,
      TimeSpan timeout,
      TimeSpan repeatInterval)
    {
      return Task.FromResult<Lock>(this.AcquireLockInternalImpl(name, maxValidFor, timeout, repeatInterval));
    }

    /// <inheritdoc />
    protected override string GetInternalLockName(string name) => (string) MemoryLockService.X3UWUPhgeey4JYUfPT53(MemoryLockService.yQbD2chg2eq2ESKniJSu(-1350312861 << 3 ^ 2082307634), (object) name);

    public MemoryLockService()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool xqHFxPhgnkTloMyTyTp4() => MemoryLockService.tqVNdshgkwXSYLA5LVTE == null;

    internal static MemoryLockService zLGf1ShgOsbhY2h2660S() => MemoryLockService.tqVNdshgkwXSYLA5LVTE;

    internal static object yQbD2chg2eq2ESKniJSu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object X3UWUPhgeey4JYUfPT53([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);
  }
}
