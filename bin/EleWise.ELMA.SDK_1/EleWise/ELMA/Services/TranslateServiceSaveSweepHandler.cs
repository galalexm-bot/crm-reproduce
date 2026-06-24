// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.TranslateServiceSaveSweepHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Services
{
  [Component]
  internal class TranslateServiceSaveSweepHandler : ISweepHandler, IThreadPoolContainer
  {
    private readonly ThreadSubPool _sweepPool;
    private readonly ThreadSubPool _createPool;
    private readonly int _processingCount;
    internal static readonly ConcurrentDictionary<LocalizationOperation, object> _processingItems;
    private static TranslateServiceSaveSweepHandler iVmw9RB7DtoNMoY6wCXl;

    public TranslateServiceSaveSweepHandler()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              EleWise.ELMA.SR.GetSetting<int>((string) TranslateServiceSaveSweepHandler.eWgF0DB74A3KyxZIOJpL(-345420348 ^ -345501000), 10);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_7;
            case 4:
              goto label_3;
            case 5:
              this._processingCount = 10;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 0;
              continue;
            case 6:
              this._createPool = new ThreadSubPool((string) TranslateServiceSaveSweepHandler.eWgF0DB74A3KyxZIOJpL(825385222 ^ 825441824), 1);
              num2 = 2;
              continue;
            default:
              if (this._processingCount > 0)
              {
                num2 = 4;
                continue;
              }
              goto case 5;
          }
        }
label_7:
        this._sweepPool = new ThreadSubPool(1);
        num1 = 6;
      }
label_6:
      return;
label_3:;
    }

    IThreadPool IThreadPoolContainer.Pool => (IThreadPool) this._sweepPool;

    void ISweepHandler.Execute()
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            TranslateServiceSaveSweepHandler.d7RFUPB7609LHo4A8vpv(false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_25;
          default:
            goto label_3;
        }
      }
label_25:
      return;
label_3:
      try
      {
        List<LocalizationOperation>.Enumerator enumerator = ((TranslateService) TranslateServiceSaveSweepHandler.Jh5dlbB7H7Ii99Q3j8fe()).GetTopOperations(this._processingCount).GetEnumerator();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
label_12:
              if (enumerator.MoveNext())
                goto label_14;
              else
                goto label_13;
label_9:
              LocalizationOperation current;
              int num3;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_20;
                  case 1:
                    goto label_12;
                  case 2:
                    goto label_14;
                  case 3:
                    new TranslateServiceSaveSweepHandler.PoFilesProcessingResolver((TranslateService) TranslateServiceSaveSweepHandler.Jh5dlbB7H7Ii99Q3j8fe(), current, (IThreadPool) this._createPool).Send();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
                    continue;
                  case 4:
                    if (TranslateServiceSaveSweepHandler._processingItems.TryAdd(current, (object) null))
                    {
                      num3 = 3;
                      continue;
                    }
                    goto label_12;
                  default:
                    goto label_16;
                }
              }
label_20:
              break;
label_16:
              break;
label_13:
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              goto label_9;
label_14:
              current = enumerator.Current;
              num3 = 4;
              goto label_9;
            }
            finally
            {
              enumerator.Dispose();
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
                num4 = 0;
              switch (num4)
              {
                default:
              }
            }
        }
      }
      finally
      {
        TranslateServiceSaveSweepHandler.d7RFUPB7609LHo4A8vpv(true);
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    public ILogger Logger
    {
      get => this.\u003CLogger\u003Ek__BackingField;
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
              this.\u003CLogger\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
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

    static TranslateServiceSaveSweepHandler()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TranslateServiceSaveSweepHandler.pKkEf3B7AD3H4sdb8n8r();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            TranslateServiceSaveSweepHandler._processingItems = new ConcurrentDictionary<LocalizationOperation, object>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object eWgF0DB74A3KyxZIOJpL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool Dw9NMHB7tFwM36gssVuG() => TranslateServiceSaveSweepHandler.iVmw9RB7DtoNMoY6wCXl == null;

    internal static TranslateServiceSaveSweepHandler rhBt5tB7wxLwpajPaTqs() => TranslateServiceSaveSweepHandler.iVmw9RB7DtoNMoY6wCXl;

    internal static void d7RFUPB7609LHo4A8vpv(bool value) => EventSettings.Enabled = value;

    internal static object Jh5dlbB7H7Ii99Q3j8fe() => (object) TranslateService.Instance;

    internal static void pKkEf3B7AD3H4sdb8n8r() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class PoFilesProcessingResolver
    {
      private readonly object _service;
      private readonly object _op;
      private readonly object _pool;
      internal static object Ey5Di1QnhLw1bytCkk5K;

      public PoFilesProcessingResolver(
        TranslateService service,
        LocalizationOperation op,
        IThreadPool pool)
      {
        TranslateServiceSaveSweepHandler.PoFilesProcessingResolver.KIc5mHQnf3dp5AUDLtV1();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              this._service = (object) service;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            case 3:
              this._pool = (object) pool;
              num = 2;
              continue;
            default:
              this._op = (object) op;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 1;
              continue;
          }
        }
label_2:;
      }

      public void Send()
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_2;
            case 1:
              TranslateServiceSaveSweepHandler.PoFilesProcessingResolver.AkSe14QnQMxrGhRDibvm(this._pool, (object) (ThreadStart) (() =>
              {
                switch (1)
                {
                  case 1:
                    try
                    {
                      new BackgroundTask((System.Action) (() =>
                      {
                        switch (1)
                        {
                          case 1:
                            try
                            {
                              ((LocalizationOperation) this._op).Execute();
                              int num4 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
                                num4 = 0;
                              switch (num4)
                              {
                                case 0:
                                  return;
                                default:
                                  return;
                              }
                            }
                            catch (Exception ex)
                            {
                              int num5 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
                                num5 = 0;
                              while (true)
                              {
                                switch (num5)
                                {
                                  case 1:
                                    goto label_1;
                                  default:
                                    EleWise.ELMA.Logging.Logger.Log.Debug(TranslateServiceSaveSweepHandler.PoFilesProcessingResolver.H6n74UQn86NycnvfPuvK((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -630185376), TranslateServiceSaveSweepHandler.PoFilesProcessingResolver.KC7GjVQnviPv2VuCJ3mp(this._op)), ex);
                                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 1;
                                    continue;
                                }
                              }
label_1:
                              break;
                            }
                        }
                      }), typeof (TranslateServiceSaveSweepHandler.PoFilesProcessingResolver), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642691088), (string) TranslateServiceSaveSweepHandler.PoFilesProcessingResolver.H6n74UQn86NycnvfPuvK(TranslateServiceSaveSweepHandler.PoFilesProcessingResolver.GHWikkQnCx6wCu9Cigwp(-649342099 - -1150814748 ^ 501656407), TranslateServiceSaveSweepHandler.PoFilesProcessingResolver.KC7GjVQnviPv2VuCJ3mp(this._op))).Execute();
                      int num6 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                        num6 = 0;
                      switch (num6)
                      {
                        case 0:
                          return;
                        default:
                          return;
                      }
                    }
                    finally
                    {
                      TranslateServiceSaveSweepHandler._processingItems.TryRemove((LocalizationOperation) this._op, out object _);
                      int num7 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
                        num7 = 0;
                      switch (num7)
                      {
                        default:
                      }
                    }
                }
              }));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static void KIc5mHQnf3dp5AUDLtV1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool R9dqIfQnGSvfrIydYRdY() => TranslateServiceSaveSweepHandler.PoFilesProcessingResolver.Ey5Di1QnhLw1bytCkk5K == null;

      internal static TranslateServiceSaveSweepHandler.PoFilesProcessingResolver VrxOSbQnEFGGdOcU5Mdp() => (TranslateServiceSaveSweepHandler.PoFilesProcessingResolver) TranslateServiceSaveSweepHandler.PoFilesProcessingResolver.Ey5Di1QnhLw1bytCkk5K;

      internal static void AkSe14QnQMxrGhRDibvm([In] object obj0, [In] object obj1) => ((IThreadPool) obj0).Queue((ThreadStart) obj1);

      internal static object GHWikkQnCx6wCu9Cigwp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object KC7GjVQnviPv2VuCJ3mp([In] object obj0) => (object) ((LocalizationOperation) obj0).Name;

      internal static object H6n74UQn86NycnvfPuvK([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);
    }
  }
}
