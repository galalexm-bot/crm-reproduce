// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.Impl.SystemFileEventListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Runtime.Exceptions;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Providers.Impl
{
  [Component]
  internal class SystemFileEventListener : IUnitOfWorkEventListener
  {
    internal static SystemFileEventListener nkny86Wvp8PuVyZPIVrZ;

    public void OnStartUnitofWork(IUnitOfWork unitOfWork)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ContextVars.Set<bool>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 133020707), false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void OnPreFlushUnitofWork(IUnitOfWork unitOfWork, IEnumerable<object> entities)
    {
    }

    public void OnPreCommitUnitofWork(IUnitOfWork unitOfWork)
    {
      switch (1)
      {
        case 1:
          try
          {
            ContextVars.Set<bool>((string) SystemFileEventListener.bw27L2WvtkNoNQWy1u5g(-488881205 ^ -488772905), true);
            int num1 = 4;
            while (true)
            {
              int num2 = num1;
              BinaryFile binaryFile;
              Dictionary<Guid, BinaryFile> dictionary;
              while (true)
              {
                switch (num2)
                {
                  case 2:
                    Locator.GetServiceNotNull<IFileManager>().SaveFile(binaryFile);
                    num2 = 7;
                    continue;
                  case 3:
                    goto label_9;
                  case 4:
                    if (!ContextVars.TryGetValue<Dictionary<Guid, BinaryFile>>((string) SystemFileEventListener.bw27L2WvtkNoNQWy1u5g(-675505729 ^ -675466815), out dictionary))
                    {
                      num2 = 5;
                      continue;
                    }
                    goto label_7;
                  case 5:
                    goto label_4;
                  case 6:
                    if (binaryFile != null)
                    {
                      num2 = 2;
                      continue;
                    }
                    goto label_8;
                  case 7:
                    dictionary.Remove(SystemFileEventListener.kFtHtkWvw93NDPEhYGsF((object) binaryFile));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_7;
                }
              }
label_7:
              binaryFile = dictionary.Values.FirstOrDefault<BinaryFile>();
              num1 = 6;
            }
label_9:
            break;
label_4:
            break;
label_8:
            break;
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
              num = 0;
            switch (num)
            {
              default:
                throw new TransactionRollbackException((string) SystemFileEventListener.bw27L2WvtkNoNQWy1u5g(-1120607109 - 305487170 ^ -1426183697), ex);
            }
          }
      }
    }

    public void OnPostCommitUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnPostRollbackUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public void OnDisposeUnitofWork(IUnitOfWork unitOfWork)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ContextVars.Set<bool>((string) SystemFileEventListener.bw27L2WvtkNoNQWy1u5g(323422137 << 2 ^ 1293793272), true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void OnPostFlushUnitofWork(IUnitOfWork unitOfWork)
    {
    }

    public SystemFileEventListener()
    {
      SystemFileEventListener.Lt5haqWv4vKt54ildTUl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool MdJCvqWvafOxo1aMCHCx() => SystemFileEventListener.nkny86Wvp8PuVyZPIVrZ == null;

    internal static SystemFileEventListener WcIIMiWvDx7FG7qVFndx() => SystemFileEventListener.nkny86Wvp8PuVyZPIVrZ;

    internal static object bw27L2WvtkNoNQWy1u5g(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid kFtHtkWvw93NDPEhYGsF([In] object obj0) => ((BinaryFile) obj0).Uid;

    internal static void Lt5haqWv4vKt54ildTUl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
