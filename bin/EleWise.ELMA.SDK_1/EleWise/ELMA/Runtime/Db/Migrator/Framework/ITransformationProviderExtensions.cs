// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Framework.ITransformationProviderExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework
{
  /// <summary>
  /// Расширение интерфейса <see cref="T:EleWise.ELMA.Runtime.Db.Migrator.Framework.ITransformationProvider" />
  /// </summary>
  public static class ITransformationProviderExtensions
  {
    private static ITransformationProviderExtensions uXPFljWOpGv1IUrCoYcu;

    /// <summary>
    /// Выполнить действие, и повторить попытку в случае возникновения DeadLock-а
    /// </summary>
    /// <param name="provider">Провайдер преобразования БД</param>
    /// <param name="action">Действие</param>
    public static void RetryOnDeadlock(this ITransformationProvider provider, System.Action action)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ITransformationProviderExtensions.chKcqSWOtkr9m52pBFvV((object) provider, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210695603));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ITransformationProviderExtensions.dsTf8gWOwS9kXSV8hTl5((object) provider, (object) action, int.MinValue);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static void chKcqSWOtkr9m52pBFvV([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void dsTf8gWOwS9kXSV8hTl5([In] object obj0, [In] object obj1, int retryCount) => ((ITransformationProvider) obj0).RetryOnDeadlock((System.Action) obj1, retryCount);

    internal static bool OrDh9FWOaPPgcjqQsXTR() => ITransformationProviderExtensions.uXPFljWOpGv1IUrCoYcu == null;

    internal static ITransformationProviderExtensions nybEVpWODliWU4OFLYbd() => ITransformationProviderExtensions.uXPFljWOpGv1IUrCoYcu;
  }
}
