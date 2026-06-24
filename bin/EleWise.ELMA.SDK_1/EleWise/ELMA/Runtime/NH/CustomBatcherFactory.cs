// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomBatcherFactory
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.AdoNet;
using NHibernate.Cfg;
using NHibernate.Connection;
using NHibernate.Engine;
using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  public class CustomBatcherFactory : IBatcherFactory
  {
    private static readonly ConcurrentDictionary<Type, IBatcherFactory> InnerFactoryList;
    private static CustomBatcherFactory yeJlsIWtfHvQg0PHUcRa;

    public virtual IBatcher CreateBatcher(
      ConnectionManager connectionManager,
      IInterceptor interceptor)
    {
      int num1 = 8;
      IBatcher batcher;
      while (true)
      {
        IEmbeddedBatcherFactoryProvider batcherFactoryProvider;
        Type tBatcher;
        switch (num1)
        {
          case 1:
          case 9:
            if (batcher == null)
            {
              num1 = 12;
              continue;
            }
            goto label_16;
          case 2:
            batcherFactoryProvider = CustomBatcherFactory.hl0SXgWtuWdKQLJRMYwf(CustomBatcherFactory.bexXN5WtZbdDv8TKiuyb(CustomBatcherFactory.Sm7f2bWtvK79eJUjxmGQ((object) connectionManager))) as IEmbeddedBatcherFactoryProvider;
            num1 = 6;
            continue;
          case 3:
          case 11:
            if (CustomBatcherFactory.y8fZ0fWtV3xQnsudZgYY(tBatcher, (Type) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 5;
              continue;
            }
            goto case 1;
          case 4:
            tBatcher = batcherFactoryProvider.BatcherFactoryClass;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 7 : 11;
            continue;
          case 5:
            batcher = (IBatcher) CustomBatcherFactory.RijFgPWtS55s7a23V74L((object) CustomBatcherFactory.InnerFactoryList.GetOrAdd(tBatcher, (Func<Type, IBatcherFactory>) (type =>
            {
              IBatcherFactory qdex4T1MiZdLqE;
              switch (1)
              {
                case 1:
                  try
                  {
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    qdex4T1MiZdLqE = (IBatcherFactory) CustomBatcherFactory.\u003C\u003Ec__DisplayClass1_0.PV04ToQdex4T1MIZdLqE(CustomBatcherFactory.\u003C\u003Ec__DisplayClass1_0.lmQASOQd2dF8A1b6M0Q4(CustomBatcherFactory.\u003C\u003Ec__DisplayClass1_0.Qfdm0kQdORjCeDA6KFpv()), tBatcher);
                    int num2 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
                      num2 = 0;
                    switch (num2)
                    {
                    }
                  }
                  catch (Exception ex)
                  {
                    int num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
                      num3 = 0;
                    switch (num3)
                    {
                      default:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        throw new HibernateException((string) CustomBatcherFactory.\u003C\u003Ec__DisplayClass1_0.du7wDCQd1KwlZZfaUnvO(CustomBatcherFactory.\u003C\u003Ec__DisplayClass1_0.OlGK42QdPhJInwepeOmy(1052221104 - 768835541 ^ 283218543), (object) tBatcher.FullName), ex);
                    }
                  }
                  break;
              }
              return qdex4T1MiZdLqE;
            })), (object) connectionManager, (object) interceptor);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
            continue;
          case 6:
            if (batcherFactoryProvider == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 3 : 2;
              continue;
            }
            goto case 14;
          case 7:
            if (CustomBatcherFactory.cBHtH4Wt8dwK6Lt9tknK((object) ((ISessionFactoryImplementor) CustomBatcherFactory.Sm7f2bWtvK79eJUjxmGQ((object) connectionManager)).Settings) <= 0)
            {
              num1 = 9;
              continue;
            }
            break;
          case 8:
            batcher = (IBatcher) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 7 : 1;
            continue;
          case 10:
            tBatcher = (Type) null;
            num1 = 2;
            continue;
          case 12:
            batcher = (IBatcher) new NonBatchingBatcher(connectionManager, interceptor);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 13 : 2;
            continue;
          case 13:
            goto label_16;
          case 14:
            if (CustomBatcherFactory.y8fZ0fWtV3xQnsudZgYY(CustomBatcherFactory.P6pMBgWtIpbYXa2Q7iPb((object) batcherFactoryProvider), (Type) null))
            {
              num1 = 4;
              continue;
            }
            goto case 3;
        }
        num1 = 10;
      }
label_16:
      return (IBatcher) new CustomBatcher(batcher, interceptor);
    }

    public CustomBatcherFactory()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static CustomBatcherFactory()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            CustomBatcherFactory.InnerFactoryList = new ConcurrentDictionary<Type, IBatcherFactory>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          case 2:
            CustomBatcherFactory.vD0EMgWtiJHwUNZMusNr();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object Sm7f2bWtvK79eJUjxmGQ([In] object obj0) => (object) ((ConnectionManager) obj0).Factory;

    internal static int cBHtH4Wt8dwK6Lt9tknK([In] object obj0) => ((Settings) obj0).AdoBatchSize;

    internal static object bexXN5WtZbdDv8TKiuyb([In] object obj0) => (object) ((ISessionFactoryImplementor) obj0).ConnectionProvider;

    internal static object hl0SXgWtuWdKQLJRMYwf([In] object obj0) => (object) ((IConnectionProvider) obj0).Driver;

    internal static Type P6pMBgWtIpbYXa2Q7iPb([In] object obj0) => ((IEmbeddedBatcherFactoryProvider) obj0).BatcherFactoryClass;

    internal static bool y8fZ0fWtV3xQnsudZgYY([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object RijFgPWtS55s7a23V74L([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IBatcherFactory) obj0).CreateBatcher((ConnectionManager) obj1, (IInterceptor) obj2);

    internal static bool Ui0MaHWtQyeuXyoeptit() => CustomBatcherFactory.yeJlsIWtfHvQg0PHUcRa == null;

    internal static CustomBatcherFactory IkxPS3WtCuE7GM94vNEP() => CustomBatcherFactory.yeJlsIWtfHvQg0PHUcRa;

    internal static void vD0EMgWtiJHwUNZMusNr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
