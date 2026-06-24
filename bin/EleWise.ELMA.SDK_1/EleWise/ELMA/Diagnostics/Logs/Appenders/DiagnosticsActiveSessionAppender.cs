// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Logs.Appenders.DiagnosticsActiveSessionAppender
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Events;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using log4net.Appender;
using log4net.Core;
using log4net.Util;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EleWise.ELMA.Diagnostics.Logs.Appenders
{
  /// <summary>Аппендер для записи активных сессий диагностики.</summary>
  internal sealed class DiagnosticsActiveSessionAppender : IAppender, IOptionHandler
  {
    private Task workerTask;
    private static BlockingCollection<DiagnosticsEvent> eventQueue;
    private static string sessionDirectory;
    private static readonly Type[] StartEventTypes;
    private static readonly Type IgnoredEventType;
    private static readonly Type[] EndEventTypes;
    private static DiagnosticsActiveSessionAppender wUCSNAESFGkY4BInsxrT;

    /// <inheritdoc />
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

    /// <summary>Директория для сохранения</summary>
    public string Directory
    {
      get => this.\u003CDirectory\u003Ek__BackingField;
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
              this.\u003CDirectory\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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

    /// <inheritdoc />
    public void Close()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            DiagnosticsActiveSessionAppender.PBkf7UESbCkXYGhlkqUr((object) this.workerTask);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            if (DiagnosticsActiveSessionAppender.eventQueue == null)
            {
              num = 3;
              continue;
            }
            goto case 5;
          case 5:
            DiagnosticsActiveSessionAppender.Y8Mk9AESogCT6bVM0JWG((object) DiagnosticsActiveSessionAppender.eventQueue);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
            continue;
          default:
            this.workerTask.Wait();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 2;
            continue;
        }
      }
label_4:
      return;
label_2:;
    }

    /// <inheritdoc />
    public void DoAppend(LoggingEvent loggingEvent)
    {
      int num = 5;
      DiagnosticsEvent o;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_13;
          case 2:
            DiagnosticsActiveSessionAppender.CqiHnpESf498DKNdXGZa(DiagnosticsActiveSessionAppender.YK8qe0ESGmcf2BfxN2mE(), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108403868), DiagnosticsActiveSessionAppender.BHQmymESEUX8Uq53xpLI((object) o)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 6 : 6;
            continue;
          case 3:
            if (!DiagnosticsActiveSessionAppender.IgnoredEventType.IsInstanceOfType((object) o))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
              continue;
            }
            goto label_12;
          case 4:
            if (o == null)
            {
              num = 7;
              continue;
            }
            goto case 3;
          case 5:
            o = DiagnosticsActiveSessionAppender.rdCVw0EShElBmTB0fiGB((object) loggingEvent) as DiagnosticsEvent;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 4;
            continue;
          case 6:
            goto label_3;
          case 7:
            goto label_2;
          default:
            if (!DiagnosticsActiveSessionAppender.eventQueue.TryAdd(o))
            {
              num = 2;
              continue;
            }
            goto label_14;
        }
      }
label_13:
      return;
label_3:
      return;
label_2:
      return;
label_14:
      return;
label_12:;
    }

    /// <inheritdoc />
    public void ActivateOptions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DiagnosticsActiveSessionAppender.eventQueue = new BlockingCollection<DiagnosticsEvent>();
            num = 3;
            continue;
          case 2:
            DiagnosticsActiveSessionAppender.sessionDirectory = (string) DiagnosticsActiveSessionAppender.nNue31ESQFDpX65tvQJ3((object) this.Directory);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
            continue;
          case 3:
            this.workerTask = ((TaskFactory) DiagnosticsActiveSessionAppender.vBXLfIESCfDquBbGhpYJ()).StartNew(new System.Action(DiagnosticsActiveSessionAppender.EventQueueWoker), TaskCreationOptions.LongRunning);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    private static void EventQueueWoker()
    {
      int num1 = 2;
      Dictionary<long, FileStream>.Enumerator enumerator1;
      BlockingCollection<DiagnosticsEvent> eventQueue;
      Dictionary<long, FileStream> dictionary;
      while (true)
      {
        switch (num1)
        {
          case 1:
            eventQueue = DiagnosticsActiveSessionAppender.eventQueue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          case 2:
            dictionary = new Dictionary<long, FileStream>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_88;
          case 4:
            enumerator1 = dictionary.GetEnumerator();
            num1 = 6;
            continue;
          case 5:
label_2:
            DiagnosticsActiveSessionAppender.eventQueue = (BlockingCollection<DiagnosticsEvent>) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 4 : 4;
            continue;
          case 6:
            goto label_3;
          default:
            try
            {
              IEnumerator<DiagnosticsEvent> enumerator2 = DiagnosticsActiveSessionAppender.eventQueue.GetConsumingEnumerable().GetEnumerator();
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
                num2 = 0;
              switch (num2)
              {
                case 1:
                  goto label_2;
                default:
                  try
                  {
label_38:
                    if (DiagnosticsActiveSessionAppender.EKddO3ES1jOeNXbsdNj7((object) enumerator2))
                      goto label_62;
                    else
                      goto label_39;
label_30:
                    int num3;
                    while (true)
                    {
                      IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent;
                      string s1;
                      FileStream fileStream1;
                      FileStream fileStream2;
                      FileStream fileStream3;
                      string s2;
                      string name;
                      string str;
                      DiagnosticsEvent @event;
                      switch (num3)
                      {
                        case 1:
                          @event = enumerator2.Current;
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 14 : 13;
                          continue;
                        case 2:
                          goto label_2;
                        case 3:
                          diagnosticsCallInfoEvent = @event as IDiagnosticsCallInfoEvent;
                          num3 = 19;
                          continue;
                        case 4:
                          DiagnosticsActiveSessionAppender.To2xpJESODNe1xmsqj9l((object) name);
                          num3 = 20;
                          continue;
                        case 5:
                          fileStream1 = new FileStream((string) DiagnosticsActiveSessionAppender.EmLiUcESR4fhjeIXIkdU((object) DiagnosticsActiveSessionAppender.sessionDirectory, DiagnosticsActiveSessionAppender.nRUQXFESiAWuURCR0hsM((object) new object[4]
                          {
                            DiagnosticsActiveSessionAppender.sVYPngESu3fOHYcla9fy(DiagnosticsActiveSessionAppender.C5s5wAESZN5HUsDCZtcC((object) @event)),
                            (object) DiagnosticsActiveSessionAppender.wJUCtWESI0pt0YWtnFNN().ToString((string) DiagnosticsActiveSessionAppender.BtaSqDESVCGSIespQv1J(-105199646 ^ -104950272)),
                            (object) DiagnosticsActiveSessionAppender.CRrimEESS2acMmvZnSLk((object) @event),
                            DiagnosticsActiveSessionAppender.BtaSqDESVCGSIespQv1J(-244066886 - -48452443 ^ -195855601)
                          })), FileMode.Append, FileAccess.Write);
                          num3 = 28;
                          continue;
                        case 6:
                          if (fileStream2 != null)
                          {
                            num3 = 3;
                            continue;
                          }
                          goto label_38;
                        case 7:
                          if (!DiagnosticsActiveSessionAppender.LjIq39ESnFw7iSIw2ABe((object) name))
                          {
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 13 : 21;
                            continue;
                          }
                          goto case 4;
                        case 8:
                          DiagnosticsActiveSessionAppender.tRMUTHES8GdBU8lX3KLy((object) DiagnosticsActiveSessionAppender.sessionDirectory);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 5 : 5;
                          continue;
                        case 9:
                          DiagnosticsActiveSessionAppender.FnTGmaESX83YqN40ZWY9((object) fileStream1);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 22 : 10;
                          continue;
                        case 10:
                          dictionary.Remove(DiagnosticsActiveSessionAppender.CRrimEESS2acMmvZnSLk((object) @event));
                          num3 = 30;
                          continue;
                        case 11:
                        case 16:
                        case 20:
                        case 21:
                        case 22:
                          goto label_38;
                        case 12:
                          if (fileStream3 != null)
                          {
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 14 : 34;
                            continue;
                          }
                          goto label_38;
                        case 14:
                          if (!((IEnumerable<Type>) DiagnosticsActiveSessionAppender.StartEventTypes).Any<Type>((Func<Type, bool>) (t => t.IsInstanceOfType((object) @event))))
                          {
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                            continue;
                          }
                          goto case 17;
                        case 15:
                        case 32:
                          if (!dictionary.TryGetValue(@event.CallContextInfoId, out fileStream2))
                          {
                            num3 = 16;
                            continue;
                          }
                          goto case 6;
                        case 17:
                          if (!DiagnosticsActiveSessionAppender.HQOiddESvbhgKJIfb4DC((object) DiagnosticsActiveSessionAppender.sessionDirectory))
                          {
                            num3 = 8;
                            continue;
                          }
                          goto case 5;
                        case 18:
                          DiagnosticsActiveSessionAppender.FnTGmaESX83YqN40ZWY9((object) fileStream2);
                          num3 = 11;
                          continue;
                        case 19:
                          if (diagnosticsCallInfoEvent == null)
                          {
                            num3 = 25;
                            continue;
                          }
                          str = new string(' ', DiagnosticsActiveSessionAppender.R0mCMUESe7kaM1AYI7b7(DiagnosticsActiveSessionAppender.QiLKEtES2BJloX1EAGy2((object) diagnosticsCallInfoEvent)));
                          break;
                        case 23:
                          MemoryHelper.ActionWithMemoryBuffer<byte, (FileStream, string)>(((Encoding) DiagnosticsActiveSessionAppender.cYQ4K1ESKjaVRgiWiZfj()).GetByteCount(s2), (fileStream2, s2), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (FileStream, string)>(DiagnosticsActiveSessionAppender.WriteFileAction));
                          num3 = 18;
                          continue;
                        case 24:
                          MemoryHelper.ActionWithMemoryBuffer<byte, (FileStream, string)>(((Encoding) DiagnosticsActiveSessionAppender.cYQ4K1ESKjaVRgiWiZfj()).GetByteCount(s1), (fileStream1, s1), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (FileStream, string)>(DiagnosticsActiveSessionAppender.WriteFileAction));
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 8 : 9;
                          continue;
                        case 25:
                          str = "";
                          break;
                        case 26:
                          goto label_62;
                        case 27:
                          s1 = (string) DiagnosticsActiveSessionAppender.Grwi3hESqKTsNPl0BN8u(DiagnosticsActiveSessionAppender.BHQmymESEUX8Uq53xpLI((object) @event), (object) Environment.NewLine);
                          num3 = 24;
                          continue;
                        case 28:
                          dictionary.Add(DiagnosticsActiveSessionAppender.CRrimEESS2acMmvZnSLk((object) @event), fileStream1);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 18 : 27;
                          continue;
                        case 29:
                          if (dictionary.TryGetValue(DiagnosticsActiveSessionAppender.CRrimEESS2acMmvZnSLk((object) @event), out fileStream3))
                          {
                            num3 = 12;
                            continue;
                          }
                          goto label_38;
                        case 30:
                          DiagnosticsActiveSessionAppender.Ok8Qp9ESTtx9AGhGNxdp((object) fileStream3);
                          num3 = 31;
                          continue;
                        case 31:
                          DiagnosticsActiveSessionAppender.cmAiMbESkAJ2c9t0un5a((object) fileStream3);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 7 : 2;
                          continue;
                        case 33:
                          s2 = (string) DiagnosticsActiveSessionAppender.nKc9qlESPbwkw5DvBsLM((object) s2, DiagnosticsActiveSessionAppender.BHQmymESEUX8Uq53xpLI((object) @event), (object) Environment.NewLine);
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 23 : 14;
                          continue;
                        case 34:
                          name = fileStream3.Name;
                          num3 = 10;
                          continue;
                        default:
                          if (!((IEnumerable<Type>) DiagnosticsActiveSessionAppender.EndEventTypes).Any<Type>((Func<Type, bool>) (t => t.IsInstanceOfType((object) @event))))
                          {
                            num3 = 32;
                            continue;
                          }
                          goto case 29;
                      }
                      s2 = str;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 23 : 33;
                    }
label_39:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 2 : 1;
                    goto label_30;
label_62:
                    num3 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
                    {
                      num3 = 1;
                      goto label_30;
                    }
                    else
                      goto label_30;
                  }
                  finally
                  {
                    int num4;
                    if (enumerator2 == null)
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                    else
                      goto label_75;
label_74:
                    switch (num4)
                    {
                      case 1:
                        break;
                      default:
                    }
label_75:
                    DiagnosticsActiveSessionAppender.O0dFY5ESNwaMMZml0Ocf((object) enumerator2);
                    num4 = 2;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
                    {
                      num4 = 2;
                      goto label_74;
                    }
                    else
                      goto label_74;
                  }
              }
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    goto label_2;
                  default:
                    ((EleWise.ELMA.Logging.ILogger) DiagnosticsActiveSessionAppender.YK8qe0ESGmcf2BfxN2mE()).Error(DiagnosticsActiveSessionAppender.T5WBJVES3vY0b7553YfR(DiagnosticsActiveSessionAppender.BtaSqDESVCGSIespQv1J(~1767720452 ^ -1767445539)), ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 1 : 1;
                    continue;
                }
              }
            }
            finally
            {
              int num6;
              if (eventQueue == null)
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
              else
                goto label_86;
label_84:
              switch (num6)
              {
                case 2:
                  break;
                default:
              }
label_86:
              DiagnosticsActiveSessionAppender.O0dFY5ESNwaMMZml0Ocf((object) eventQueue);
              num6 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
              {
                num6 = 1;
                goto label_84;
              }
              else
                goto label_84;
            }
        }
      }
label_88:
      return;
label_3:
      try
      {
label_5:
        if (enumerator1.MoveNext())
          goto label_7;
        else
          goto label_6;
label_4:
        KeyValuePair<long, FileStream> current;
        int num7;
        while (true)
        {
          switch (num7)
          {
            case 1:
              goto label_7;
            case 2:
              goto label_5;
            case 3:
              goto label_85;
            case 4:
              goto label_9;
            default:
              if (current.Value != null)
              {
                num7 = 4;
                continue;
              }
              goto label_5;
          }
        }
label_85:
        return;
label_9:
        try
        {
          current.Value.Close();
          int num8 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
            num8 = 0;
          while (true)
          {
            switch (num8)
            {
              case 1:
                goto label_5;
              default:
                DiagnosticsActiveSessionAppender.cmAiMbESkAJ2c9t0un5a((object) current.Value);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
                continue;
            }
          }
        }
        catch (Exception ex)
        {
          int num9 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
            num9 = 0;
          while (true)
          {
            switch (num9)
            {
              case 1:
                goto label_5;
              default:
                ((EleWise.ELMA.Logging.ILogger) DiagnosticsActiveSessionAppender.YK8qe0ESGmcf2BfxN2mE()).Error(DiagnosticsActiveSessionAppender.T5WBJVES3vY0b7553YfR(DiagnosticsActiveSessionAppender.BtaSqDESVCGSIespQv1J(-1120607109 - 305487170 ^ -1426336481)), ex);
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 1;
                continue;
            }
          }
        }
label_6:
        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 2 : 3;
        goto label_4;
label_7:
        current = enumerator1.Current;
        num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
        {
          num7 = 0;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        enumerator1.Dispose();
        int num10 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
          num10 = 0;
        switch (num10)
        {
          default:
        }
      }
    }

    private static void WriteFileAction(
      object buffer,
      int offset,
      int length,
      (FileStream, string) param)
    {
      (FileStream fileStream, string s) = param;
      Encoding.UTF8.GetBytes(s, 0, s.Length, (byte[]) buffer, offset);
      fileStream.Write((byte[]) buffer, offset, length);
    }

    private static int CallInfoDepth(object callInfo)
    {
      int num1 = 2;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 2:
            num2 = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_6;
          case 4:
            ++num2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 5 : 5;
            continue;
          case 5:
            callInfo = DiagnosticsActiveSessionAppender.jBB7QfESplg1frjaVmcI(callInfo);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          default:
            if (DiagnosticsActiveSessionAppender.jBB7QfESplg1frjaVmcI(callInfo) == null)
            {
              num1 = 3;
              continue;
            }
            goto case 4;
        }
      }
label_6:
      return num2;
    }

    public DiagnosticsActiveSessionAppender()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DiagnosticsActiveSessionAppender()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DiagnosticsActiveSessionAppender.xNKRyAESakfs5cfsUCc1();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            DiagnosticsActiveSessionAppender.IgnoredEventType = TypeOf<WebRequestAuthorizedEvent>.Raw;
            num = 4;
            continue;
          case 4:
            DiagnosticsActiveSessionAppender.EndEventTypes = new Type[4]
            {
              TypeOf<BackgroundThreadEndEvent>.Raw,
              TypeOf<BackgroundThreadErrorEvent>.Raw,
              TypeOf<WebRequestEndEvent>.Raw,
              TypeOf<WebRequestErrorEvent>.Raw
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 0;
            continue;
          default:
            DiagnosticsActiveSessionAppender.StartEventTypes = new Type[2]
            {
              TypeOf<BackgroundThreadStartEvent>.Raw,
              TypeOf<WebRequestStartEvent>.Raw
            };
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static bool LTo8MdESBx1ID2JC50m6() => DiagnosticsActiveSessionAppender.wUCSNAESFGkY4BInsxrT == null;

    internal static DiagnosticsActiveSessionAppender o2KIIwESWsiOsfnmQJ7w() => DiagnosticsActiveSessionAppender.wUCSNAESFGkY4BInsxrT;

    internal static void Y8Mk9AESogCT6bVM0JWG([In] object obj0) => ((BlockingCollection<DiagnosticsEvent>) obj0).CompleteAdding();

    internal static void PBkf7UESbCkXYGhlkqUr([In] object obj0) => ((Task) obj0).Dispose();

    internal static object rdCVw0EShElBmTB0fiGB([In] object obj0) => ((LoggingEvent) obj0).MessageObject;

    internal static object YK8qe0ESGmcf2BfxN2mE() => (object) Logger.Log;

    internal static object BHQmymESEUX8Uq53xpLI([In] object obj0) => (object) ((DiagnosticsEvent) obj0).Message;

    internal static void CqiHnpESf498DKNdXGZa([In] object obj0, [In] object obj1) => ((EleWise.ELMA.Logging.ILogger) obj0).Error(obj1);

    internal static object nNue31ESQFDpX65tvQJ3([In] object obj0) => (object) SystemInfo.ConvertToFullPath((string) obj0);

    internal static object vBXLfIESCfDquBbGhpYJ() => (object) Task.Factory;

    internal static bool HQOiddESvbhgKJIfb4DC([In] object obj0) => System.IO.Directory.Exists((string) obj0);

    internal static object tRMUTHES8GdBU8lX3KLy([In] object obj0) => (object) System.IO.Directory.CreateDirectory((string) obj0);

    internal static object C5s5wAESZN5HUsDCZtcC([In] object obj0) => (object) ((DiagnosticsEvent) obj0).CallContextInfo;

    internal static object sVYPngESu3fOHYcla9fy([In] object obj0) => (object) ((CallContextInfo) obj0).ServerHostName;

    internal static DateTime wJUCtWESI0pt0YWtnFNN() => DateTime.Now;

    internal static object BtaSqDESVCGSIespQv1J(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static long CRrimEESS2acMmvZnSLk([In] object obj0) => ((DiagnosticsEvent) obj0).CallContextInfoId;

    internal static object nRUQXFESiAWuURCR0hsM([In] object obj0) => (object) string.Concat((object[]) obj0);

    internal static object EmLiUcESR4fhjeIXIkdU([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object Grwi3hESqKTsNPl0BN8u([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object cYQ4K1ESKjaVRgiWiZfj() => (object) Encoding.UTF8;

    internal static void FnTGmaESX83YqN40ZWY9([In] object obj0) => ((Stream) obj0).Flush();

    internal static void Ok8Qp9ESTtx9AGhGNxdp([In] object obj0) => ((Stream) obj0).Close();

    internal static void cmAiMbESkAJ2c9t0un5a([In] object obj0) => ((Stream) obj0).Dispose();

    internal static bool LjIq39ESnFw7iSIw2ABe([In] object obj0) => File.Exists((string) obj0);

    internal static void To2xpJESODNe1xmsqj9l([In] object obj0) => File.Delete((string) obj0);

    internal static object QiLKEtES2BJloX1EAGy2([In] object obj0) => (object) ((IDiagnosticsCallInfoEvent) obj0).Info;

    internal static int R0mCMUESe7kaM1AYI7b7([In] object obj0) => DiagnosticsActiveSessionAppender.CallInfoDepth(obj0);

    internal static object nKc9qlESPbwkw5DvBsLM([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static bool EKddO3ES1jOeNXbsdNj7([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void O0dFY5ESNwaMMZml0Ocf([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object T5WBJVES3vY0b7553YfR([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object jBB7QfESplg1frjaVmcI([In] object obj0) => (object) ((AbstractCallInfo) obj0).ParentCall;

    internal static void xNKRyAESakfs5cfsUCc1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
