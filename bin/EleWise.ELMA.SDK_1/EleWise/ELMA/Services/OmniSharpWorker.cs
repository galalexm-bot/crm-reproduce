// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.OmniSharpWorker
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;
using EleWise.ELMA.OmniSharp.Infrastructure;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scripts.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Services
{
  /// <summary>Элемент для работы с сервером OmniSharp</summary>
  [Service]
  internal sealed class OmniSharpWorker : IOmniSharpWorker, ISweepHandler
  {
    private Process process;
    private bool omnisharpWasTerminatedUnexpectedly;
    private string completionLibsPath;
    private string clientCompletionLibsPath;
    private readonly Dictionary<string, Workspace> workspaces;
    private readonly ILogger omniSharpLog;
    private static readonly ILogger workerLog;
    private readonly TimeSpan reportInterval;
    private DateTime lastReport;
    private static SemaphoreSlim initSemaphore;
    private static readonly ManualResetEventSlim readyState;
    private SimpleWebClient client;
    private OmniSharpConnectionMonitor connectionMonitor;
    internal static OmniSharpWorker IvN1aeBwL2d8wXosp48f;

    /// <summary>Ctor</summary>
    public OmniSharpWorker()
    {
      OmniSharpWorker.iKg9trBwcVDgUydNTHip();
      this.workspaces = new Dictionary<string, Workspace>();
      this.omniSharpLog = (ILogger) OmniSharpWorker.Gy5pd1BwzKeEIWRAIUB3((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146559521));
      this.reportInterval = OmniSharpWorker.skgQwsB4FxnadpFNyx5Z(1.0);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              if (OmniSharpWorker.tYBRPSB4hqjok8fIDKaU((object) this.completionLibsPath))
                goto case 3;
              else
                goto label_8;
            case 3:
              this.lastReport = OmniSharpWorker.AkK7hpB4E7bg61xGvgZK();
              num2 = 6;
              continue;
            case 4:
              if (!string.IsNullOrWhiteSpace(str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 5:
              str = (string) OmniSharpWorker.xtADK4B4Bo78OE8oVyPo((object) ConfigurationManager.AppSettings, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882207110));
              num2 = 4;
              continue;
            case 6:
              OmniSharpWorker.initSemaphore = new SemaphoreSlim(1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
              continue;
            case 7:
              this.clientCompletionLibsPath = (string) OmniSharpWorker.spGdxKB4bD9kl4p5q7ft(OmniSharpWorker.QOIFj9B4oOt7I36s652m((object) this.completionLibsPath, OmniSharpWorker.pVInvoB4GeBCvkm5d406(~289714581 ^ -289797804)));
              num2 = 3;
              continue;
            default:
              this.completionLibsPath = (string) OmniSharpWorker.spGdxKB4bD9kl4p5q7ft(OmniSharpWorker.QOIFj9B4oOt7I36s652m(OmniSharpWorker.uDwe0QB4WHbZldmIZevX((object) AppDomain.CurrentDomain), (object) str));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 1;
              continue;
          }
        }
label_8:
        num1 = 7;
      }
label_3:;
    }

    /// <inheritdoc />
    public void Execute()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Report();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 3 : 1;
            continue;
          case 2:
            if (OmniSharpWorker.wU3jFTB4fZmCJZUDUZ4K(this.lastReport.Add(this.reportInterval), OmniSharpWorker.AkK7hpB4E7bg61xGvgZK()))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 1;
              continue;
            }
            goto label_7;
          case 3:
            this.lastReport = OmniSharpWorker.AkK7hpB4E7bg61xGvgZK();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:
      return;
label_7:;
    }

    private void Report()
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        long? nullable1;
        while (true)
        {
          long? nullable2;
          int num3;
          switch (num2)
          {
            case 1:
              nullable1 = new long?();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            case 2:
label_4:
              nullable2 = new long?();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 1;
              continue;
            case 3:
            case 4:
              nullable2 = new long?(OmniSharpWorker.f1XF1KB4CMVS3R3t1GZh((object) this.process));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 6 : 3;
              continue;
            case 5:
              goto label_9;
            case 6:
              goto label_7;
            case 7:
              num3 = 1;
              break;
            case 8:
              Process process = this.process;
              if (process == null)
              {
                num2 = 7;
                continue;
              }
              num3 = OmniSharpWorker.SF2i6UB4QUuuIwk7ostK((object) process) ? 1 : 0;
              break;
            default:
              OmniSharpWorker.bNDWYxB48GuPvcYC1NuA((object) OmniSharpWorker.workerLog, (object) string.Format((string) OmniSharpWorker.pVInvoB4GeBCvkm5d406(-441065788 ^ -2092910478 ^ 1727275512), (object) OmniSharpWorker.kjUAoFB4vQHKWxcGCOiw((object) this.workspaces), (object) ToMbString(nullable2), (object) ToMbString(nullable1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 5 : 1;
              continue;
          }
          if (num3 == 0)
            num2 = 4;
          else
            goto label_4;
        }
label_7:
        nullable1 = new long?(this.process.VirtualMemorySize64);
        num1 = 9;
      }
label_9:

      static string ToMbString(long? value) => !value.HasValue ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35941859) : (value.Value / 1048576L).ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787398979);
    }

    /// <inheritdoc />
    public string CompletionLibsPath => this.completionLibsPath;

    /// <inheritdoc />
    public string ClientCompletionLibsPath => this.clientCompletionLibsPath;

    /// <inheritdoc />
    public void Start(bool needRestart)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (OmniSharpWorker.PPe55tB4unVDrjxPEIFP((object) OmniSharpWorker.initSemaphore) != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 8 : 6;
              continue;
            }
            break;
          case 2:
            OmniSharpWorker.bNDWYxB48GuPvcYC1NuA((object) OmniSharpWorker.workerLog, OmniSharpWorker.W0bUD0B4ZqQOylSxlLNm(OmniSharpWorker.pVInvoB4GeBCvkm5d406(-606654180 ^ -606701294), (object) needRestart));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
            continue;
          case 3:
          case 7:
label_5:
            OmniSharpWorker.bNDWYxB48GuPvcYC1NuA((object) OmniSharpWorker.workerLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154032923));
            num1 = 9;
            continue;
          case 4:
          case 8:
            OmniSharpWorker.JJbDsXB4I8dCfm3MYpDI((object) OmniSharpWorker.readyState);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 6 : 2;
            continue;
          case 5:
            try
            {
              OmniSharpWorker.bNDWYxB48GuPvcYC1NuA((object) OmniSharpWorker.workerLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993518119));
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
                num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    this.StartInternal(needRestart);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_5;
                }
              }
            }
            catch (Exception ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_5;
                  default:
                    OmniSharpWorker.jYMYLrB4SjNNG6fEetF5((object) OmniSharpWorker.workerLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751227840), (object) ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
                    continue;
                }
              }
            }
            finally
            {
              OmniSharpWorker.x3xyXIB4iViytYBVxgLT((object) OmniSharpWorker.initSemaphore);
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
                num4 = 0;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_22;
                  default:
                    OmniSharpWorker.JQo7rJB4RhDRFWRFjtRy((object) OmniSharpWorker.readyState);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
                    continue;
                }
              }
label_22:;
            }
          case 6:
            OmniSharpWorker.TdPhRIB4Vx46BJoffVHj((object) OmniSharpWorker.initSemaphore);
            num1 = 5;
            continue;
          case 9:
            goto label_20;
          case 10:
            OmniSharpWorker.readyState.Wait();
            num1 = 7;
            continue;
        }
        OmniSharpWorker.bNDWYxB48GuPvcYC1NuA((object) OmniSharpWorker.workerLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867742664));
        num1 = 10;
      }
label_20:;
    }

    private void StartInternal(bool needRestart)
    {
      int num1 = 14;
      while (true)
      {
        int num2 = num1;
        string path;
        string port;
        bool setting;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_29;
            case 1:
              if (this.process != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 14 : 18;
                continue;
              }
              goto case 21;
            case 2:
              goto label_5;
            case 3:
              this.RestoreRemoteWorkspaces();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
              continue;
            case 4:
              port = (string) OmniSharpWorker.xtADK4B4Bo78OE8oVyPo(OmniSharpWorker.w6tyY5B4X08nifjT6XEc(), OmniSharpWorker.pVInvoB4GeBCvkm5d406(1925118608 << 2 ^ -889544692));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 15 : 6;
              continue;
            case 5:
              OmniSharpWorker.bNDWYxB48GuPvcYC1NuA((object) OmniSharpWorker.workerLog, OmniSharpWorker.pVInvoB4GeBCvkm5d406(-2107978722 ^ -2107930648));
              num2 = 10;
              continue;
            case 6:
              this.StartServer(path, port, setting, false);
              num2 = 12;
              continue;
            case 7:
              goto label_17;
            case 8:
              goto label_15;
            case 9:
              OmniSharpWorker.workerLog.Info(OmniSharpWorker.pVInvoB4GeBCvkm5d406(~-122002947 ^ 121951372));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 6;
              continue;
            case 10:
              OmniSharpWorker.StopServer((object) this.process);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 15 : 16;
              continue;
            case 11:
              goto label_18;
            case 12:
              this.RestoreRemoteWorkspaces();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 2;
              continue;
            case 13:
            case 19:
              string omniSharpTempPath = OmniSharpWorker.GetOmniSharpTempPath();
              OmniSharpWorker.DeployOmniSharpIfNeeded((object) omniSharpTempPath, (object) (string) OmniSharpWorker.jUawgAB4KDGWeiZyrMto());
              path = (string) OmniSharpWorker.QOIFj9B4oOt7I36s652m((object) omniSharpTempPath, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333688372));
              num2 = 4;
              continue;
            case 14:
              if (!OmniSharpWorker.PVLNTYB4qqLpEgNsgYFO((object) this.completionLibsPath))
              {
                num2 = 13;
                continue;
              }
              goto case 17;
            case 15:
              setting = EleWise.ELMA.SR.GetSetting<bool>((string) OmniSharpWorker.pVInvoB4GeBCvkm5d406(-1852837372 ^ -1852917656));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 1;
              continue;
            case 16:
              this.StartServer(path, port, setting, !needRestart);
              num2 = 3;
              continue;
            case 17:
              this.FillCompletionLibsFolder();
              num2 = 19;
              continue;
            case 18:
              if (!needRestart)
              {
                num2 = 7;
                continue;
              }
              goto case 5;
            case 20:
              ((IEnumerable<Process>) OmniSharpWorker.fCZvD4B4TXMRM6spXS4h((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538471474))).ForEach<Process>(new Action<Process>(OmniSharpWorker.StopServer));
              num2 = 11;
              continue;
            case 21:
              if (!this.omnisharpWasTerminatedUnexpectedly)
              {
                OmniSharpWorker.workerLog.Info(OmniSharpWorker.pVInvoB4GeBCvkm5d406(-2107978722 ^ -2107930814));
                num2 = 20;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 9 : 1;
              continue;
            default:
              goto label_14;
          }
        }
label_18:
        this.StartServer(path, port, setting);
        num1 = 8;
      }
label_29:
      return;
label_5:
      return;
label_17:
      return;
label_15:
      return;
label_14:;
    }

    /// <inheritdoc />
    public void Stop()
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_19;
          case 1:
            try
            {
              if (this.process != null)
              {
                int num2 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
                  num2 = 0;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      goto label_23;
                    default:
                      OmniSharpWorker.PPTyf9B4kuIZlSAtnIE0((object) this.process);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
              else
                goto case 3;
            }
            catch (Exception ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_23;
                  default:
                    OmniSharpWorker.jYMYLrB4SjNNG6fEetF5(OmniSharpWorker.ByR5VjB4nV8UjiA9M5yQ(), OmniSharpWorker.W8STW6B4OmRIUwohRnj9(OmniSharpWorker.pVInvoB4GeBCvkm5d406(-680446928 - -370807692 ^ -309720238)), (object) ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
                    continue;
                }
              }
            }
            finally
            {
              this.ClearAllCaches();
              int num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
                num4 = 4;
              while (true)
              {
                switch (num4)
                {
                  case 2:
                    goto label_21;
                  case 3:
                    this.omnisharpWasTerminatedUnexpectedly = false;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 2 : 1;
                    continue;
                  case 4:
                    Process process = this.process;
                    if (process == null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                      continue;
                    }
                    OmniSharpWorker.iOOunoB42eQHA14psSIu((object) process);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
                    continue;
                  default:
                    this.process = (Process) null;
                    num4 = 3;
                    continue;
                }
              }
label_21:;
            }
          case 2:
            OmniSharpWorker.workerLog.Info(OmniSharpWorker.pVInvoB4GeBCvkm5d406(1514961705 ^ 1515009925));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
            continue;
          case 3:
label_23:
            OmniSharpWorker.bNDWYxB48GuPvcYC1NuA((object) OmniSharpWorker.workerLog, OmniSharpWorker.pVInvoB4GeBCvkm5d406(-1350312861 << 3 ^ 2082450998));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          default:
            goto label_14;
        }
      }
label_19:
      return;
label_14:;
    }

    /// <inheritdoc />
    public Task<string> GetResult(string command, string postData, string fileName) => this.GetWorkspace(fileName).Query(new OmniSharpRequest()
    {
      Command = command,
      PostData = postData,
      FileName = fileName
    });

    /// <inheritdoc />
    public Task InitWorkspace(string fileName, string projectPath)
    {
      int num = 4;
      Workspace workspace;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.workspaces.Add((string) OmniSharpWorker.Y7Jga2B4NeDcnZg9ZcGR((object) workspace), workspace);
            num = 2;
            continue;
          case 2:
            goto label_4;
          case 3:
            if (!this.workspaces.ContainsKey(fileName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 4:
            OmniSharpWorker.workerLog.Info(OmniSharpWorker.GjVgXfB4PfsTP1WLmaik((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638483051), (object) projectPath, OmniSharpWorker.pVInvoB4GeBCvkm5d406(-105199646 ^ -105149918), OmniSharpWorker.sILAGdB4e44QN2C6vqDU((object) fileName)));
            num = 3;
            continue;
          case 5:
            goto label_7;
          default:
            workspace = new Workspace(fileName, projectPath, new Func<string, string>(GetCsprojPath), this.client, (IConnectionMonitor) this.connectionMonitor, OmniSharpWorker.workerLog);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 1;
            continue;
        }
      }
label_4:
      return (Task) workspace.Create();
label_7:
      return (Task) OmniSharpWorker.LalpHkB41MKL8cGtIXNN();

      string GetCsprojPath(string projectFolderPath)
      {
        int num = 1;
        string csprojPath;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              csprojPath = Directory.EnumerateFiles(projectFolderPath, (string) OmniSharpWorker.\u003C\u003Ec.uFUguFQTb0oggmaAZttW(-1146510045 ^ -1146301639)).FirstOrDefault<string>();
              if (csprojPath == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return csprojPath;
label_5:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        throw new ArgumentException((string) OmniSharpWorker.\u003C\u003Ec.waAUiZQTh4Co7Jm4N8X5(OmniSharpWorker.\u003C\u003Ec.uFUguFQTb0oggmaAZttW(--1333735954 ^ 1333412924)));
      }
    }

    /// <inheritdoc />
    public Task AddReferences(
      IEnumerable<string> assembliesPath,
      IEnumerable<string> webReferencesPath,
      string projectPath,
      string fileName)
    {
      Workspace workspace = this.GetWorkspace(fileName);
      OmniSharpWorker.workerLog.Info((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951565252) + workspace.ProjectFolder + z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516889860) + assembliesPath.ToCommaSeparatedString<string>() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461710259) + webReferencesPath.ToCommaSeparatedString<string>()));
      return (Task) workspace.AddReferences(assembliesPath, webReferencesPath);
    }

    /// <inheritdoc />
    public Task RemoveReferences(
      IEnumerable<string> assembliesPath,
      IEnumerable<string> webReferencesPath,
      string projectPath,
      string fileName)
    {
      Workspace workspace = this.GetWorkspace(fileName);
      OmniSharpWorker.workerLog.Info((object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088387694) + workspace.ProjectFolder + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3380716) + assembliesPath.ToCommaSeparatedString<string>() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124557988) + webReferencesPath.ToCommaSeparatedString<string>()));
      return (Task) workspace.RemoveReferences(assembliesPath, webReferencesPath);
    }

    private void ClearAllCaches()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            OmniSharpWorker.bNDWYxB48GuPvcYC1NuA((object) OmniSharpWorker.workerLog, OmniSharpWorker.pVInvoB4GeBCvkm5d406(694673736 ^ -23604109 ^ -672040001));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 2:
            this.workspaces.Clear();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    private Workspace GetWorkspace(string fileName) => this.workspaces.GetValueOrDefault<string, Workspace>(fileName, (Workspace) null) ?? throw new Exception((string) OmniSharpWorker.Fj50O8B43W8Lr4x3ki9P(OmniSharpWorker.pVInvoB4GeBCvkm5d406(-951514650 ^ -951564462), (object) fileName, OmniSharpWorker.pVInvoB4GeBCvkm5d406(-1334993905 ^ -1335000751)));

    private void FillCompletionLibsFolder()
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        string path1;
        string str;
        string path2;
        string path3;
        List<string> files;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.completionLibsPath = (string) OmniSharpWorker.jOeueXB4pf0cIu3OC1Zd((object) path1, OmniSharpWorker.pVInvoB4GeBCvkm5d406(-2112703338 ^ -2112619554), OmniSharpWorker.pVInvoB4GeBCvkm5d406(1514961705 ^ 1515009141));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 16 : 11;
              continue;
            case 2:
              this.clientCompletionLibsPath = (string) OmniSharpWorker.QOIFj9B4oOt7I36s652m((object) this.completionLibsPath, OmniSharpWorker.pVInvoB4GeBCvkm5d406(-2112703338 ^ -2112621656));
              num2 = 8;
              continue;
            case 3:
              Directory.CreateDirectory(this.clientCompletionLibsPath);
              num2 = 7;
              continue;
            case 4:
            case 7:
              str = Path.Combine(path1, (string) OmniSharpWorker.pVInvoB4GeBCvkm5d406(1642859704 ^ 1642939332), (string) OmniSharpWorker.pVInvoB4GeBCvkm5d406(-1837662597 ^ -1837747723), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113862049));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 9 : 9;
              continue;
            case 5:
              OmniSharpWorker.FaDN7iB4DWSmaRMJryf6((object) this.completionLibsPath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 2;
              continue;
            case 6:
              this.CopyFiles(Directory.EnumerateFiles(path2, (string) OmniSharpWorker.pVInvoB4GeBCvkm5d406(-812025778 ^ -812106616)), this.completionLibsPath);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
              continue;
            case 8:
              if (!Directory.Exists(this.clientCompletionLibsPath))
                goto case 3;
              else
                goto label_8;
            case 9:
              files = new List<string>()
              {
                (string) OmniSharpWorker.jOeueXB4pf0cIu3OC1Zd((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633434733), OmniSharpWorker.pVInvoB4GeBCvkm5d406(-1978478350 ^ -1978425584)),
                (string) OmniSharpWorker.jOeueXB4pf0cIu3OC1Zd((object) str, OmniSharpWorker.pVInvoB4GeBCvkm5d406(~1767720452 ^ -1767639491), OmniSharpWorker.pVInvoB4GeBCvkm5d406(-138018305 ^ -137933307)),
                (string) OmniSharpWorker.jOeueXB4pf0cIu3OC1Zd((object) str, OmniSharpWorker.pVInvoB4GeBCvkm5d406(-1255365154 ^ 596875508 ^ -1765903636), OmniSharpWorker.pVInvoB4GeBCvkm5d406(1304605005 ^ 1304682853))
              };
              num2 = 10;
              continue;
            case 10:
              this.CopyFiles((IEnumerable<string>) files, this.clientCompletionLibsPath);
              num2 = 15;
              continue;
            case 11:
              path1 = (string) OmniSharpWorker.uDwe0QB4WHbZldmIZevX((object) AppDomain.CurrentDomain);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
              continue;
            case 12:
              OmniSharpWorker.workerLog.Info(OmniSharpWorker.pVInvoB4GeBCvkm5d406(-97972138 ^ -98017622));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 3 : 11;
              continue;
            case 13:
              goto label_18;
            case 14:
              goto label_14;
            case 15:
              goto label_4;
            case 16:
              if (!OmniSharpWorker.JtsK2OB4aSme8pbxfwyn((object) this.completionLibsPath))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 2 : 5;
                continue;
              }
              goto case 2;
            default:
              path3 = Path.Combine(path1, (string) OmniSharpWorker.pVInvoB4GeBCvkm5d406(~210725948 ^ -210641781), z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521188312));
              num2 = 14;
              continue;
          }
        }
label_4:
        path2 = Path.Combine(path1, (string) OmniSharpWorker.pVInvoB4GeBCvkm5d406(-16752921 ^ -16686379));
        num1 = 6;
        continue;
label_8:
        num1 = 4;
        continue;
label_14:
        this.CopyFiles(Directory.EnumerateFiles(path3, (string) OmniSharpWorker.pVInvoB4GeBCvkm5d406(-710283084 ^ -537863435 ^ 173567623)), this.completionLibsPath);
        num1 = 13;
      }
label_18:;
    }

    private void CopyFiles(IEnumerable<string> files, string path)
    {
      foreach (string str1 in files.Where<string>(new Func<string, bool>(File.Exists)))
      {
        string withoutExtension = Path.GetFileNameWithoutExtension(str1);
        File.Copy(str1, Path.Combine(path, withoutExtension + z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957774086)), true);
        string str2 = Path.ChangeExtension(str1, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669244885));
        if (File.Exists(str2))
          File.Copy(str2, Path.Combine(path, withoutExtension + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672161958)), true);
      }
    }

    /// <summary>Запустить сервер OmniSharp</summary>
    /// <param name="path">Путь до exe-файла</param>
    private void StartServer(string path, string port, bool debug, bool clearScripts = true)
    {
      int num1 = 33;
      while (true)
      {
        int num2 = num1;
        string str1;
        while (true)
        {
          string setting;
          string baseUrl;
          string str2;
          int num3;
          object obj1;
          switch (num2)
          {
            case 1:
              OmniSharpWorker.sqrm82B4tK5yBbfJW46h();
              num2 = 35;
              continue;
            case 2:
              num3 = OmniSharpWorker.H2yuj7B44nUSVNsnhWR9();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 19 : 21;
              continue;
            case 3:
              OmniSharpWorker.B6RqulB47xjwiko26tWQ(OmniSharpWorker.vDZaaxB46iNtY3OWrCFk((object) this.process), false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 19 : 27;
              continue;
            case 4:
            case 8:
              if (!OmniSharpWorker.KCxGs3B4JnFHSdR5Lfdu((object) this.process))
              {
                num2 = 19;
                continue;
              }
              goto case 11;
            case 5:
            case 14:
              OmniSharpWorker.jLG14AB4MxFR4GS8LHen((object) this.process.StartInfo, ProcessWindowStyle.Hidden);
              num2 = 8;
              continue;
            case 6:
              if (this.client != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 8 : 13;
                continue;
              }
              goto case 15;
            case 7:
              baseUrl = (string) OmniSharpWorker.AhmEJTB4l3AJmRYRaAmf((object) new string[5]
              {
                str1,
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16762157),
                setting,
                (string) OmniSharpWorker.pVInvoB4GeBCvkm5d406(132912447 ^ 132990077),
                port
              });
              num2 = 6;
              continue;
            case 9:
              this.process.EnableRaisingEvents = true;
              num2 = 16;
              continue;
            case 10:
              obj1 = OmniSharpWorker.zZk6MvB4wvV0MDKUMaF0();
              break;
            case 11:
              OmniSharpWorker.BJ7ShhB49QxOys72kigs((object) this.process);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 9 : 18;
              continue;
            case 12:
            case 17:
              if (this.connectionMonitor == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 6 : 22;
                continue;
              }
              goto label_35;
            case 13:
            case 28:
              OmniSharpWorker.ieDATdB4ruRQovdpJfWi((object) this.client, (object) baseUrl);
              num2 = 17;
              continue;
            case 15:
              this.client = new SimpleWebClient(baseUrl);
              num2 = 12;
              continue;
            case 16:
              goto label_29;
            case 18:
              setting = EleWise.ELMA.SR.GetSetting((string) OmniSharpWorker.pVInvoB4GeBCvkm5d406(--1867379187 ^ 1867292975));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 25 : 3;
              continue;
            case 19:
              goto label_40;
            case 20:
              OmniSharpWorker.i21BOTB40c3vTGR3aCrl(OmniSharpWorker.vDZaaxB46iNtY3OWrCFk((object) this.process), true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 9 : 0;
              continue;
            case 21:
              this.process = new Process();
              num2 = 30;
              continue;
            case 22:
              goto label_30;
            case 23:
              goto label_17;
            case 24:
              object obj2 = OmniSharpWorker.vDZaaxB46iNtY3OWrCFk((object) this.process);
              OmniSharpWorker.XH8OD5B4AnnKloOG1AvC(obj2, OmniSharpWorker.bQs7d4B4yes3OP8jt89V(OmniSharpWorker.NGwg6nB4mYo8yQgOYvqy(obj2), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917211214)));
              num2 = 4;
              continue;
            case 25:
              if (OmniSharpWorker.lwhbBnB4daM8ZJZ3hSQ8((object) ((NameValueCollection) OmniSharpWorker.w6tyY5B4X08nifjT6XEc())[(string) OmniSharpWorker.pVInvoB4GeBCvkm5d406(-2138160520 ^ -2138107260)], OmniSharpWorker.pVInvoB4GeBCvkm5d406(1142330761 ^ 1541959139 ^ 536797796)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 26 : 21;
                continue;
              }
              goto label_17;
            case 26:
              goto label_43;
            case 27:
              OmniSharpWorker.I31TSLB4xpVDF9trInsF(OmniSharpWorker.vDZaaxB46iNtY3OWrCFk((object) this.process), true);
              num2 = 20;
              continue;
            case 29:
              this.process.OutputDataReceived += new DataReceivedEventHandler(this.OmniSharpOutputDataReceived);
              num2 = 34;
              continue;
            case 30:
              ((ProcessStartInfo) OmniSharpWorker.vDZaaxB46iNtY3OWrCFk((object) this.process)).FileName = path;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
              continue;
            case 31:
              goto label_31;
            case 32:
            case 35:
              if (!OmniSharpWorker.JtsK2OB4aSme8pbxfwyn((object) this.completionLibsPath))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 10 : 9;
                continue;
              }
              obj1 = (object) this.completionLibsPath;
              break;
            case 33:
              if (!clearScripts)
              {
                num2 = 32;
                continue;
              }
              goto case 1;
            case 34:
              if (!debug)
              {
                num2 = 5;
                continue;
              }
              goto case 24;
            default:
              OmniSharpWorker.XH8OD5B4AnnKloOG1AvC((object) this.process.StartInfo, OmniSharpWorker.dBUJi6B4Hqkt8f0cYIyr(OmniSharpWorker.pVInvoB4GeBCvkm5d406(-218496594 ^ -218410710), (object) str2, (object) port, (object) num3));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 2 : 3;
              continue;
          }
          str2 = (string) obj1;
          num2 = 2;
        }
label_17:
        object obj = OmniSharpWorker.pVInvoB4GeBCvkm5d406(-1380439818 << 3 ^ 1841371850);
        goto label_44;
label_29:
        this.process.Exited += new EventHandler(this.OmniSharpExited);
        num1 = 29;
        continue;
label_30:
        this.connectionMonitor = new OmniSharpConnectionMonitor(this.client, OmniSharpWorker.workerLog);
        num1 = 31;
        continue;
label_43:
        obj = (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825438258);
label_44:
        str1 = (string) obj;
        num1 = 7;
      }
label_40:
      return;
label_31:
      return;
label_35:;
    }

    private void OmniSharpExited(object sender, EventArgs e)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            OmniSharpWorker.bNDWYxB48GuPvcYC1NuA((object) OmniSharpWorker.workerLog, OmniSharpWorker.pVInvoB4GeBCvkm5d406(1581325282 << 3 ^ -234254760));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_28;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 5 : 3;
            continue;
          case 5:
            goto label_8;
          default:
            if (this.process != null)
            {
              num1 = 4;
              continue;
            }
            goto label_25;
        }
      }
label_3:
      return;
label_28:
      return;
label_25:
      return;
label_8:
      try
      {
        int num2;
        if (OmniSharpWorker.Ny91t9B452WUmdK2RUrv(OmniSharpWorker.ebXdJVB4gbUWnInDsHkM((object) this.process)))
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
        else
          goto label_14;
label_10:
        string format;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_23;
            case 1:
              ((ILogger) OmniSharpWorker.ByR5VjB4nV8UjiA9M5yQ()).ErrorFormat(format);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 4 : 2;
              continue;
            case 2:
              goto label_19;
            case 3:
              if (string.IsNullOrEmpty(format))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 2 : 1;
                continue;
              }
              goto case 1;
            case 4:
              goto label_18;
            case 5:
              goto label_14;
            default:
              goto label_13;
          }
        }
label_23:
        return;
label_19:
        return;
label_18:
        return;
label_13:
        return;
label_14:
        format = (string) OmniSharpWorker.E6rgSxB4jSNl5Uya8HwO(OmniSharpWorker.ebXdJVB4gbUWnInDsHkM((object) this.process));
        num2 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
        {
          num2 = 1;
          goto label_10;
        }
        else
          goto label_10;
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_11;
            case 1:
              Logger.Log.ErrorFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106571174), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_11:
        return;
label_2:;
      }
      finally
      {
        this.process.Dispose();
        int num4 = 2;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_31;
            case 2:
              this.process = (Process) null;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            default:
              this.omnisharpWasTerminatedUnexpectedly = true;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
              continue;
          }
        }
label_31:;
      }
    }

    private void OmniSharpOutputDataReceived(object sender, DataReceivedEventArgs e)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            OmniSharpWorker.vbWS9lB4Llyei9SVhNkm((object) this.omniSharpLog, (object) e.Data);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (string.IsNullOrEmpty((string) OmniSharpWorker.EClP1AB4Yf0vIXLqZQn9((object) e)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 2 : 2;
              continue;
            }
            goto case 1;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_2:
      return;
label_7:;
    }

    private void RestoreRemoteWorkspaces()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            OmniSharpWorker.bNDWYxB48GuPvcYC1NuA((object) OmniSharpWorker.workerLog, OmniSharpWorker.pVInvoB4GeBCvkm5d406(-2138160520 ^ -2138106970));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.workspaces.ForEach<KeyValuePair<string, Workspace>>((Action<KeyValuePair<string, Workspace>>) (m => m.Value.ForceRestore()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    private static void StopServer(object process)
    {
      switch (1)
      {
        case 1:
          try
          {
            int num;
            if (process == null)
              num = 4;
            else
              goto label_11;
label_4:
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_15;
                case 1:
                  OmniSharpWorker.EteOtyB4UnlAn2Qfbebb(process);
                  num = 2;
                  continue;
                case 2:
                  ((Process) process).WaitForExit(5000);
                  num = 5;
                  continue;
                case 3:
                  goto label_11;
                case 4:
                  goto label_5;
                case 5:
                  OmniSharpWorker.WkC7nMB4sVgQOwxo3Wns(process);
                  num = 7;
                  continue;
                case 6:
                  ((Process) process).EnableRaisingEvents = false;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 1;
                  continue;
                case 7:
                  process = (object) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
                  continue;
                default:
                  goto label_1;
              }
            }
label_15:
            break;
label_5:
            break;
label_1:
            break;
label_11:
            if (OmniSharpWorker.SF2i6UB4QUuuIwk7ostK(process))
              break;
            num = 6;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
            {
              num = 6;
              goto label_4;
            }
            else
              goto label_4;
          }
          catch (Win32Exception ex)
          {
            int num = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_22;
                case 1:
                  OmniSharpWorker.doxVnIB4zqceqN52jEVu(OmniSharpWorker.ByR5VjB4nV8UjiA9M5yQ(), (object) EleWise.ELMA.SR.T((string) OmniSharpWorker.pVInvoB4GeBCvkm5d406(--1867379187 ^ 1867293659), (object) OmniSharpWorker.JXoTZpB4ctumW40nn6gn(process)));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_23;
              }
            }
label_22:
            break;
label_23:
            break;
          }
      }
    }

    private static void ClearScriptsFolder()
    {
      int num1 = 1;
      string path;
      while (true)
      {
        switch (num1)
        {
          case 1:
            OmniSharpWorker.bNDWYxB48GuPvcYC1NuA((object) OmniSharpWorker.workerLog, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876107661));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          case 2:
            if (Directory.Exists(path))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 4 : 5;
              continue;
            }
            num1 = 4;
            continue;
          case 3:
            goto label_17;
          case 4:
            goto label_2;
          case 5:
            goto label_4;
          default:
            path = (string) OmniSharpWorker.QOIFj9B4oOt7I36s652m(OmniSharpWorker.mYdB5JB6FqkvhJVtbDOy(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825438744));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 2;
            continue;
        }
      }
label_17:
      return;
label_2:
      return;
label_4:
      try
      {
        string[] directories = Directory.GetDirectories(path);
        int num2 = 4;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ++index;
              num2 = 5;
              continue;
            case 2:
              goto label_15;
            case 3:
              Directory.Delete(directories[index], true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 1;
              continue;
            case 4:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
              continue;
            default:
              if (index >= directories.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 2;
                continue;
              }
              goto case 3;
          }
        }
label_15:;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_11;
            default:
              OmniSharpWorker.doxVnIB4zqceqN52jEVu(OmniSharpWorker.ByR5VjB4nV8UjiA9M5yQ(), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
              continue;
          }
        }
label_11:;
      }
    }

    private static void DeployOmniSharpIfNeeded(object tempFolderPath, object sourcePath)
    {
      int num = 6;
      FileInfo[] second;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            FileUtils.CopyDirectory((string) sourcePath, (string) tempFolderPath, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 3 : 3;
            continue;
          case 2:
            OmniSharpWorker.bNDWYxB48GuPvcYC1NuA((object) OmniSharpWorker.workerLog, OmniSharpWorker.pVInvoB4GeBCvkm5d406(-2112703338 ^ -2112624730));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 4 : 2;
            continue;
          case 3:
            goto label_2;
          case 4:
            ((IEnumerable<Process>) Process.GetProcessesByName((string) OmniSharpWorker.pVInvoB4GeBCvkm5d406(1113862659 ^ 1113946587))).ForEach<Process>(new Action<Process>(OmniSharpWorker.StopServer));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 1;
            continue;
          case 5:
            if (!((IEnumerable<FileInfo>) OmniSharpWorker.Hda1hCB6BvramFBePFBl((object) new DirectoryInfo((string) sourcePath), OmniSharpWorker.pVInvoB4GeBCvkm5d406(1470440286 ^ 1470452724), SearchOption.AllDirectories)).Except<FileInfo>((IEnumerable<FileInfo>) second, (IEqualityComparer<FileInfo>) new OmniSharpWorker.FileComparer()).Any<FileInfo>())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 6:
            second = (FileInfo[]) OmniSharpWorker.Hda1hCB6BvramFBePFBl((object) new DirectoryInfo((string) tempFolderPath), OmniSharpWorker.pVInvoB4GeBCvkm5d406(381945751 ^ 1158627804 ^ 1405826785), SearchOption.AllDirectories);
            num = 5;
            continue;
          default:
            goto label_10;
        }
      }
label_5:
      return;
label_2:
      return;
label_10:;
    }

    private static string GetOmniSharpSourcePath()
    {
      int num = 4;
      string omniSharpSourcePath;
      while (true)
      {
        switch (num)
        {
          case 2:
            omniSharpSourcePath = (string) OmniSharpWorker.QOIFj9B4oOt7I36s652m(OmniSharpWorker.uDwe0QB4WHbZldmIZevX(OmniSharpWorker.sY4XxUB6Wsk2TBYOr4yG()), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574175684));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          case 3:
            if (!OmniSharpWorker.PVLNTYB4qqLpEgNsgYFO((object) omniSharpSourcePath))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
              continue;
            }
            goto case 2;
          case 4:
            omniSharpSourcePath = ((NameValueCollection) OmniSharpWorker.w6tyY5B4X08nifjT6XEc())[(string) OmniSharpWorker.pVInvoB4GeBCvkm5d406(-97972138 ^ -98024670)];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 3 : 3;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return omniSharpSourcePath;
    }

    private static string GetOmniSharpTempPath()
    {
      int num = 1;
      string path;
      while (true)
      {
        switch (num)
        {
          case 1:
            path = Path.Combine((string) OmniSharpWorker.mYdB5JB6FqkvhJVtbDOy(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712426531));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
            continue;
          case 2:
            Directory.CreateDirectory(path);
            num = 4;
            continue;
          case 3:
          case 4:
            goto label_4;
          default:
            if (OmniSharpWorker.JtsK2OB4aSme8pbxfwyn((object) path))
            {
              num = 3;
              continue;
            }
            goto case 2;
        }
      }
label_4:
      return path;
    }

    static OmniSharpWorker()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            OmniSharpWorker.workerLog = (ILogger) OmniSharpWorker.Gy5pd1BwzKeEIWRAIUB3(OmniSharpWorker.pVInvoB4GeBCvkm5d406(-1822890472 ^ -1822837344));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 2 : 3;
            continue;
          case 2:
            OmniSharpWorker.iKg9trBwcVDgUydNTHip();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
            continue;
          case 3:
            OmniSharpWorker.readyState = new ManualResetEventSlim(true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static void iKg9trBwcVDgUydNTHip() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object Gy5pd1BwzKeEIWRAIUB3([In] object obj0) => (object) Logger.GetLogger((string) obj0);

    internal static TimeSpan skgQwsB4FxnadpFNyx5Z([In] double obj0) => TimeSpan.FromHours(obj0);

    internal static object xtADK4B4Bo78OE8oVyPo([In] object obj0, [In] object obj1) => (object) ((NameValueCollection) obj0)[(string) obj1];

    internal static object uDwe0QB4WHbZldmIZevX([In] object obj0) => (object) ((AppDomain) obj0).BaseDirectory;

    internal static object QOIFj9B4oOt7I36s652m([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object spGdxKB4bD9kl4p5q7ft([In] object obj0) => (object) Path.GetFullPath((string) obj0);

    internal static bool tYBRPSB4hqjok8fIDKaU([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object pVInvoB4GeBCvkm5d406(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static DateTime AkK7hpB4E7bg61xGvgZK() => DateTime.Now;

    internal static bool URidHEBwU12EmEXNydEi() => OmniSharpWorker.IvN1aeBwL2d8wXosp48f == null;

    internal static OmniSharpWorker wDVyO9BwswvHLxeOqEo0() => OmniSharpWorker.IvN1aeBwL2d8wXosp48f;

    internal static bool wU3jFTB4fZmCJZUDUZ4K([In] DateTime obj0, [In] DateTime obj1) => obj0 < obj1;

    internal static bool SF2i6UB4QUuuIwk7ostK([In] object obj0) => ((Process) obj0).HasExited;

    internal static long f1XF1KB4CMVS3R3t1GZh([In] object obj0) => ((Process) obj0).WorkingSet64;

    internal static int kjUAoFB4vQHKWxcGCOiw([In] object obj0) => ((Dictionary<string, Workspace>) obj0).Count;

    internal static void bNDWYxB48GuPvcYC1NuA([In] object obj0, [In] object obj1) => ((ILogger) obj0).Info(obj1);

    internal static object W0bUD0B4ZqQOylSxlLNm([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static int PPe55tB4unVDrjxPEIFP([In] object obj0) => ((SemaphoreSlim) obj0).CurrentCount;

    internal static void JJbDsXB4I8dCfm3MYpDI([In] object obj0) => ((ManualResetEventSlim) obj0).Reset();

    internal static void TdPhRIB4Vx46BJoffVHj([In] object obj0) => ((SemaphoreSlim) obj0).Wait();

    internal static void jYMYLrB4SjNNG6fEetF5([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static int x3xyXIB4iViytYBVxgLT([In] object obj0) => ((SemaphoreSlim) obj0).Release();

    internal static void JQo7rJB4RhDRFWRFjtRy([In] object obj0) => ((ManualResetEventSlim) obj0).Set();

    internal static bool PVLNTYB4qqLpEgNsgYFO([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object jUawgAB4KDGWeiZyrMto() => (object) OmniSharpWorker.GetOmniSharpSourcePath();

    internal static object w6tyY5B4X08nifjT6XEc() => (object) ConfigurationManager.AppSettings;

    internal static object fCZvD4B4TXMRM6spXS4h([In] object obj0) => (object) Process.GetProcessesByName((string) obj0);

    internal static void PPTyf9B4kuIZlSAtnIE0([In] object obj0) => OmniSharpWorker.StopServer(obj0);

    internal static object ByR5VjB4nV8UjiA9M5yQ() => (object) Logger.Log;

    internal static object W8STW6B4OmRIUwohRnj9([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void iOOunoB42eQHA14psSIu([In] object obj0) => __nonvirtual (((Component) obj0).Dispose());

    internal static object sILAGdB4e44QN2C6vqDU([In] object obj0) => (object) Path.GetFileName((string) obj0);

    internal static object GjVgXfB4PfsTP1WLmaik(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static object LalpHkB41MKL8cGtIXNN() => (object) Task.CompletedTask;

    internal static object Y7Jga2B4NeDcnZg9ZcGR([In] object obj0) => (object) ((Workspace) obj0).FileName;

    internal static object Fj50O8B43W8Lr4x3ki9P([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object jOeueXB4pf0cIu3OC1Zd([In] object obj0, [In] object obj1, [In] object obj2) => (object) Path.Combine((string) obj0, (string) obj1, (string) obj2);

    internal static bool JtsK2OB4aSme8pbxfwyn([In] object obj0) => Directory.Exists((string) obj0);

    internal static object FaDN7iB4DWSmaRMJryf6([In] object obj0) => (object) Directory.CreateDirectory((string) obj0);

    internal static void sqrm82B4tK5yBbfJW46h() => OmniSharpWorker.ClearScriptsFolder();

    internal static object zZk6MvB4wvV0MDKUMaF0() => (object) Directory.GetCurrentDirectory();

    internal static int H2yuj7B44nUSVNsnhWR9()
    {
      return GetElmaProcessId();

      static int GetElmaProcessId()
      {
        int num1 = 2;
        Process process;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_2;
            case 2:
              process = (Process) OmniSharpWorker.tGCKYvB6ovNd8IbsEphH();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
              continue;
            default:
              goto label_12;
          }
        }
label_2:
        int elmaProcessId;
        try
        {
          elmaProcessId = OmniSharpWorker.JXoTZpB4ctumW40nn6gn((object) process);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
            num2 = 0;
          switch (num2)
          {
          }
        }
        finally
        {
          int num3;
          if (process == null)
            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
          else
            goto label_8;
label_7:
          switch (num3)
          {
            case 2:
              break;
            default:
          }
label_8:
          OmniSharpWorker.rUM20sB6b2ITVjcHeCSC((object) process);
          num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
          {
            num3 = 1;
            goto label_7;
          }
          else
            goto label_7;
        }
label_12:
        return elmaProcessId;
      }
    }

    internal static object vDZaaxB46iNtY3OWrCFk([In] object obj0) => (object) ((Process) obj0).StartInfo;

    internal static object dBUJi6B4Hqkt8f0cYIyr(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static void XH8OD5B4AnnKloOG1AvC([In] object obj0, [In] object obj1) => ((ProcessStartInfo) obj0).Arguments = (string) obj1;

    internal static void B6RqulB47xjwiko26tWQ([In] object obj0, [In] bool obj1) => ((ProcessStartInfo) obj0).UseShellExecute = obj1;

    internal static void I31TSLB4xpVDF9trInsF([In] object obj0, [In] bool obj1) => ((ProcessStartInfo) obj0).RedirectStandardOutput = obj1;

    internal static void i21BOTB40c3vTGR3aCrl([In] object obj0, [In] bool obj1) => ((ProcessStartInfo) obj0).RedirectStandardError = obj1;

    internal static object NGwg6nB4mYo8yQgOYvqy([In] object obj0) => (object) ((ProcessStartInfo) obj0).Arguments;

    internal static object bQs7d4B4yes3OP8jt89V([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void jLG14AB4MxFR4GS8LHen([In] object obj0, [In] ProcessWindowStyle obj1) => ((ProcessStartInfo) obj0).WindowStyle = obj1;

    internal static bool KCxGs3B4JnFHSdR5Lfdu([In] object obj0) => ((Process) obj0).Start();

    internal static void BJ7ShhB49QxOys72kigs([In] object obj0) => ((Process) obj0).BeginOutputReadLine();

    internal static bool lwhbBnB4daM8ZJZ3hSQ8([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object AhmEJTB4l3AJmRYRaAmf([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static void ieDATdB4ruRQovdpJfWi([In] object obj0, [In] object obj1) => ((SimpleWebClient) obj0).SetBaseUrl((string) obj1);

    internal static object ebXdJVB4gbUWnInDsHkM([In] object obj0) => (object) ((Process) obj0).StandardError;

    internal static bool Ny91t9B452WUmdK2RUrv([In] object obj0) => ((StreamReader) obj0).EndOfStream;

    internal static object E6rgSxB4jSNl5Uya8HwO([In] object obj0) => (object) ((TextReader) obj0).ReadToEnd();

    internal static object EClP1AB4Yf0vIXLqZQn9([In] object obj0) => (object) ((DataReceivedEventArgs) obj0).Data;

    internal static void vbWS9lB4Llyei9SVhNkm([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static void EteOtyB4UnlAn2Qfbebb([In] object obj0) => ((Process) obj0).Kill();

    internal static void WkC7nMB4sVgQOwxo3Wns([In] object obj0) => ((Component) obj0).Dispose();

    internal static int JXoTZpB4ctumW40nn6gn([In] object obj0) => ((Process) obj0).Id;

    internal static void doxVnIB4zqceqN52jEVu([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static object mYdB5JB6FqkvhJVtbDOy() => (object) IOExtensions.GetTempPath();

    internal static object Hda1hCB6BvramFBePFBl([In] object obj0, [In] object obj1, [In] SearchOption obj2) => (object) ((DirectoryInfo) obj0).GetFiles((string) obj1, obj2);

    internal static object sY4XxUB6Wsk2TBYOr4yG() => (object) AppDomain.CurrentDomain;

    internal static object tGCKYvB6ovNd8IbsEphH() => (object) Process.GetCurrentProcess();

    internal static void rUM20sB6b2ITVjcHeCSC([In] object obj0) => ((IDisposable) obj0).Dispose();

    private class FileComparer : IEqualityComparer<FileInfo>
    {
      private static object xMlLNyQX5bg6P8c3EOI3;

      public bool Equals(FileInfo f1, FileInfo f2)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (OmniSharpWorker.FileComparer.NaIespQXU73NvqFOYGON((object) f1.Name, OmniSharpWorker.FileComparer.mXEndgQXLZVCINfLBPPL((object) f2)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              goto label_2;
            default:
              if (f1.Length == f2.Length)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 2 : 2;
                continue;
              }
              goto label_3;
          }
        }
label_2:
        return OmniSharpWorker.FileComparer.nHKmJlQXcMklyj7aF9fn(OmniSharpWorker.FileComparer.egisPQQXshs0XbwFl5Sy((object) f1), OmniSharpWorker.FileComparer.egisPQQXshs0XbwFl5Sy((object) f2));
label_3:
        return false;
      }

      public int GetHashCode(FileInfo fi) => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767884211), OmniSharpWorker.FileComparer.mXEndgQXLZVCINfLBPPL((object) fi), (object) OmniSharpWorker.FileComparer.PlU5v4QXzMiLLKsl0crb((object) fi), (object) OmniSharpWorker.FileComparer.egisPQQXshs0XbwFl5Sy((object) fi)).GetHashCode();

      public FileComparer()
      {
        OmniSharpWorker.FileComparer.WRCrROQTFH9KawPHT4c4();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object mXEndgQXLZVCINfLBPPL([In] object obj0) => (object) ((FileSystemInfo) obj0).Name;

      internal static bool NaIespQXU73NvqFOYGON([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

      internal static DateTime egisPQQXshs0XbwFl5Sy([In] object obj0) => ((FileSystemInfo) obj0).LastWriteTime;

      internal static bool nHKmJlQXcMklyj7aF9fn([In] DateTime obj0, [In] DateTime obj1) => obj0 == obj1;

      internal static bool yCE89BQXjTHsOdSnWnus() => OmniSharpWorker.FileComparer.xMlLNyQX5bg6P8c3EOI3 == null;

      internal static OmniSharpWorker.FileComparer m6hCdcQXYbdKmksVhZQy() => (OmniSharpWorker.FileComparer) OmniSharpWorker.FileComparer.xMlLNyQX5bg6P8c3EOI3;

      internal static long PlU5v4QXzMiLLKsl0crb([In] object obj0) => ((FileInfo) obj0).Length;

      internal static void WRCrROQTFH9KawPHT4c4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
