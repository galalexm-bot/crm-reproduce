// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Logs.Appenders.DiagnosticsCompleteSessionAppender
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Events;
using EleWise.ELMA.Diagnostics.Serialization;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Serialization;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using j3AmrhgkCleVTGdEwA;
using log4net.Appender;
using log4net.Core;
using log4net.Util;
using Newtonsoft.Json;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.Diagnostics.Logs.Appenders
{
  /// <summary>Аппендер для записи завершенных сессий диагностики.</summary>
  internal sealed class DiagnosticsCompleteSessionAppender : IAppender
  {
    private readonly object lockObject;
    private long nextClear;
    private List<CallContextInfo> contextInfo;
    private static readonly Type[] SupportedEventTypes;
    private static DiagnosticsCompleteSessionAppender wA8DLgESDktciDGer4KA;

    /// <summary>ctor</summary>
    public DiagnosticsCompleteSessionAppender()
    {
      DiagnosticsCompleteSessionAppender.POTTO9ES4W1N3E3Jh6cH();
      this.lockObject = new object();
      this.nextClear = long.MinValue;
      this.contextInfo = new List<CallContextInfo>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ClearOlderHours = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
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

    /// <summary>
    /// Очищать старые сессии, старше указанного значения (в часах)
    /// </summary>
    public int ClearOlderHours
    {
      get => this.\u003CClearOlderHours\u003Ek__BackingField;
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
              this.\u003CClearOlderHours\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
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

    /// <summary>Размер очереди событий</summary>
    public long QueueSize
    {
      get => this.\u003CQueueSize\u003Ek__BackingField;
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
              this.\u003CQueueSize\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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
      int num1 = 3;
      object lockObject;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_14;
          case 1:
            goto label_2;
          case 2:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
            continue;
          case 3:
            lockObject = this.lockObject;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 2;
            continue;
          default:
            goto label_13;
        }
      }
label_14:
      return;
label_13:
      return;
label_2:
      try
      {
        Monitor.Enter(lockObject, ref lockTaken);
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_9;
            case 2:
              if (DiagnosticsCompleteSessionAppender.Uy6Bs5ES6pnSu9DGIxWm((object) this.contextInfo) <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
                continue;
              }
              break;
            case 3:
              this.contextInfo = new List<CallContextInfo>();
              num2 = 4;
              continue;
            case 4:
              goto label_8;
          }
          DiagnosticsCompleteSessionAppender.hHB3H7ESHj97PE0MPCMS((object) new WaitCallback(this.InternalSave), (object) this.contextInfo);
          num2 = 3;
        }
label_9:
        return;
label_8:;
      }
      finally
      {
        int num3;
        if (!lockTaken)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
        else
          goto label_15;
label_12:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_15:
        DiagnosticsCompleteSessionAppender.UGYSfvESAVExIQ1VPsGF(lockObject);
        num3 = 2;
        goto label_12;
      }
    }

    /// <inheritdoc />
    public void DoAppend(LoggingEvent loggingEvent)
    {
      int num1 = 7;
      object lockObject;
      bool lockTaken;
      DiagnosticsEvent @event;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_31;
            case 1:
              if (((IEnumerable<Type>) DiagnosticsCompleteSessionAppender.SupportedEventTypes).Any<Type>((Func<Type, bool>) (t => t.IsInstanceOfType((object) @event))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 2 : 2;
                continue;
              }
              goto label_20;
            case 2:
              lockObject = this.lockObject;
              num2 = 9;
              continue;
            case 3:
              if (@event != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
                continue;
              }
              goto label_29;
            case 4:
              goto label_6;
            case 5:
              goto label_8;
            case 6:
              @event = DiagnosticsCompleteSessionAppender.efQJBZES7DC1tB07E8yN((object) loggingEvent) as DiagnosticsEvent;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 3 : 1;
              continue;
            case 7:
              goto label_30;
            case 8:
              goto label_3;
            case 9:
              lockTaken = false;
              num2 = 5;
              continue;
            default:
              goto label_23;
          }
        }
label_30:
        num1 = 6;
      }
label_31:
      return;
label_6:
      return;
label_3:
      return;
label_23:
      return;
label_20:
      return;
label_8:
      try
      {
        Monitor.Enter(lockObject, ref lockTaken);
        int num3 = 3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              if ((long) DiagnosticsCompleteSessionAppender.Uy6Bs5ES6pnSu9DGIxWm((object) this.contextInfo) >= this.QueueSize)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            case 2:
              goto label_16;
            case 3:
              this.contextInfo.Add((CallContextInfo) DiagnosticsCompleteSessionAppender.dMomgtESxp2se9N6eX2H((object) @event));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 1;
              continue;
            case 4:
              this.contextInfo = new List<CallContextInfo>();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 2 : 0;
              continue;
            default:
              DiagnosticsCompleteSessionAppender.hHB3H7ESHj97PE0MPCMS((object) new WaitCallback(this.InternalSave), (object) this.contextInfo);
              num3 = 4;
              continue;
          }
        }
label_16:
        return;
label_10:
        return;
      }
      finally
      {
        int num4;
        if (!lockTaken)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
        else
          goto label_21;
label_19:
        switch (num4)
        {
          case 2:
            break;
          default:
        }
label_21:
        DiagnosticsCompleteSessionAppender.UGYSfvESAVExIQ1VPsGF(lockObject);
        num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        {
          num4 = 1;
          goto label_19;
        }
        else
          goto label_19;
      }
label_29:;
    }

    private void InternalSave(object infoData)
    {
      int num1 = 2;
      IEnumerable<CallContextInfo> enumeration1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_62;
          case 1:
            if (enumeration1 != null)
            {
              num1 = 4;
              continue;
            }
            goto label_61;
          case 2:
            enumeration1 = infoData as IEnumerable<CallContextInfo>;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_63;
          case 4:
            num1 = 5;
            continue;
          case 5:
            goto label_4;
          default:
            goto label_59;
        }
      }
label_62:
      return;
label_63:
      return;
label_59:
      return;
label_61:
      return;
label_4:
      try
      {
        string path1 = (string) DiagnosticsCompleteSessionAppender.icGbpcES0TgBVgRMCS7h((object) this.Directory);
        int num2 = 3;
        while (true)
        {
          int num3;
          DateTime dateTime;
          FileStream baseOutputStream;
          long nextClear;
          string path2;
          DateTime older;
          switch (num2)
          {
            case 1:
              try
              {
                int num4 = 3;
                ZipOutputStream zipStream;
                DiagnosticsCompleteSessionAppender completeSessionAppender;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_46;
                    case 2:
                      zipStream = new ZipOutputStream((Stream) baseOutputStream);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
                      continue;
                    case 3:
                      completeSessionAppender = this;
                      num4 = 2;
                      continue;
                    default:
                      goto label_13;
                  }
                }
label_13:
                try
                {
                  zipStream.SetLevel(5);
                  int num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
                    num5 = 0;
                  while (true)
                  {
                    int num6;
                    switch (num5)
                    {
                      case 1:
                        DiagnosticsCompleteSessionAppender.dEIHFBES5OTIk2L4kUu4((object) zipStream);
                        num6 = 2;
                        break;
                      case 2:
                        goto label_46;
                      case 3:
                        DiagnosticsCompleteSessionAppender.GoC2a4ESgceir8Tk1Uox((object) zipStream);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 1;
                        continue;
                      default:
                        enumeration1.ForEach<CallContextInfo>((Action<CallContextInfo>) (a =>
                        {
                          int num7 = 4;
                          ZipEntry entry;
                          string s;
                          while (true)
                          {
                            switch (num7)
                            {
                              case 0:
                                goto label_2;
                              case 1:
                                MemoryHelper.ActionWithMemoryBuffer<byte, (ZipOutputStream, string)>(Encoding.UTF8.GetByteCount(s), (zipStream, s), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (ZipOutputStream, string)>(completeSessionAppender.InternalSaveWriteZipStream));
                                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                                continue;
                              case 2:
                                s = ClassSerializationHelper.SerializeObjectByJsonNet((object) a, (IEnumerable<JsonConverter>) new DiagnosticsMethodInfoConverter[1]
                                {
                                  DiagnosticsMethodInfoConverter.Instance
                                });
                                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 1;
                                continue;
                              case 3:
                                zipStream.PutNextEntry(entry);
                                num7 = 2;
                                continue;
                              case 4:
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                ZipEntry zipEntry = new ZipEntry((string) DiagnosticsCompleteSessionAppender.\u003C\u003Ec__DisplayClass19_0.hkPd7D8KgvcyUKYmdNL2((object) DiagnosticsCompleteSessionAppender.\u003C\u003Ec__DisplayClass19_0.e00x3Y8KrYaiUDWs9TKC((object) a), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021613041)));
                                // ISSUE: reference to a compiler-generated method
                                DiagnosticsCompleteSessionAppender.\u003C\u003Ec__DisplayClass19_0.dhXsvE8K58bOMgBm9NP3((object) zipEntry, DateTime.Now);
                                entry = zipEntry;
                                num7 = 3;
                                continue;
                              default:
                                goto label_7;
                            }
                          }
label_2:
                          return;
label_7:;
                        }));
                        num6 = 3;
                        break;
                    }
                    num5 = num6;
                  }
                }
                finally
                {
                  int num8;
                  if (zipStream == null)
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                  else
                    goto label_25;
label_23:
                  switch (num8)
                  {
                    case 1:
                      break;
                    default:
                  }
label_25:
                  DiagnosticsCompleteSessionAppender.sTtEa4ESjSXKYJTNCyrY((object) zipStream);
                  num8 = 2;
                  goto label_23;
                }
              }
              finally
              {
                if (baseOutputStream != null)
                {
                  int num9 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
                    num9 = 1;
                  while (true)
                  {
                    switch (num9)
                    {
                      case 1:
                        DiagnosticsCompleteSessionAppender.sTtEa4ESjSXKYJTNCyrY((object) baseOutputStream);
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_34;
                    }
                  }
                }
label_34:;
              }
            case 2:
              File.Delete(path2);
              num2 = 11;
              continue;
            case 3:
              if (!DiagnosticsCompleteSessionAppender.sL5bWPESmQdC8Y78GAOE((object) path1))
              {
                num2 = 6;
                continue;
              }
              goto case 14;
            case 4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              IEnumerable<FileSystemInfo> enumeration2 = new DirectoryInfo(path1).EnumerateFileSystemInfos((string) DiagnosticsCompleteSessionAppender.CkDXTwESYOdiw6gQ9kL7((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234058388), DiagnosticsCompleteSessionAppender.mxcT8qESJyAuW8yPuFGF(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87095623)), SearchOption.TopDirectoryOnly).Where<FileSystemInfo>((Func<FileSystemInfo, bool>) (f => DiagnosticsCompleteSessionAppender.\u003C\u003Ec__DisplayClass19_1.WxFlXi8Kcl7HOstq9WhU(DiagnosticsCompleteSessionAppender.\u003C\u003Ec__DisplayClass19_1.HDwPnG8KsNIboPb4gvlp((object) f), older)));
              // ISSUE: reference to a compiler-generated field
              Action<FileSystemInfo> action1 = DiagnosticsCompleteSessionAppender.\u003C\u003Ec.\u003C\u003E9__19_2;
              Action<FileSystemInfo> action2;
              if (action1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                DiagnosticsCompleteSessionAppender.\u003C\u003Ec.\u003C\u003E9__19_2 = action2 = (Action<FileSystemInfo>) (f => f.Delete());
              }
              else
                goto label_66;
label_54:
              enumeration2.ForEach<FileSystemInfo>(action2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 5 : 5;
              continue;
label_66:
              action2 = action1;
              goto label_54;
            case 5:
              goto label_55;
            case 6:
              DiagnosticsCompleteSessionAppender.vHNakTESy570IM0oKsCb((object) path1);
              num3 = 14;
              break;
            case 7:
              dateTime = DiagnosticsCompleteSessionAppender.minE3LES9WrRkoBdC1NF();
              num2 = 15;
              continue;
            case 8:
              if (this.ClearOlderHours > 0)
              {
                num2 = 12;
                continue;
              }
              goto label_27;
            case 9:
              dateTime = DiagnosticsCompleteSessionAppender.minE3LES9WrRkoBdC1NF();
              older = dateTime.AddHours((double) -this.ClearOlderHours);
              num3 = 4;
              break;
            case 10:
              if (DiagnosticsCompleteSessionAppender.Lwr6bjESrQhFxXUX99tO((object) path2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 2 : 2;
                continue;
              }
              goto case 11;
            case 11:
              baseOutputStream = File.Create(path2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 1;
              continue;
            case 12:
              num2 = 9;
              continue;
            case 13:
label_46:
              nextClear = this.nextClear;
              num2 = 7;
              continue;
            case 14:
              string str1 = path1;
              string[] strArray = new string[5]
              {
                (string) DiagnosticsCompleteSessionAppender.V8jcLvESMh9liOgDrBId(1012087039 ^ 1012361859),
                (string) DiagnosticsCompleteSessionAppender.mxcT8qESJyAuW8yPuFGF(),
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876066091),
                null,
                null
              };
              dateTime = DiagnosticsCompleteSessionAppender.minE3LES9WrRkoBdC1NF();
              strArray[3] = (string) DiagnosticsCompleteSessionAppender.kR778bESd43VaJgEqFRP((object) dateTime.ToString((string) DiagnosticsCompleteSessionAppender.V8jcLvESMh9liOgDrBId(-1867198571 ^ -1867473609)), DiagnosticsCompleteSessionAppender.V8jcLvESMh9liOgDrBId(-1921202237 ^ -1921196793), DiagnosticsCompleteSessionAppender.V8jcLvESMh9liOgDrBId(-1350312861 << 3 ^ 2082402146));
              strArray[4] = (string) DiagnosticsCompleteSessionAppender.V8jcLvESMh9liOgDrBId(-420743386 ^ -420834234);
              string str2 = string.Concat(strArray);
              path2 = (string) DiagnosticsCompleteSessionAppender.dRLSe2ESl92KJaBK584H((object) str1, (object) str2);
              num2 = 10;
              continue;
            case 15:
              if (dateTime.Ticks >= nextClear)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                continue;
              }
              goto label_52;
            default:
              ref long local = ref this.nextClear;
              dateTime = DiagnosticsCompleteSessionAppender.minE3LES9WrRkoBdC1NF();
              dateTime = dateTime.AddMinutes(10.0);
              long ticks = dateTime.Ticks;
              if (Interlocked.Exchange(ref local, ticks) == nextClear)
              {
                num2 = 8;
                continue;
              }
              goto label_32;
          }
          num2 = num3;
        }
label_55:
        return;
label_52:
        return;
label_32:
        return;
label_27:;
      }
      catch (Exception ex)
      {
        int num10 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
          num10 = 0;
        while (true)
        {
          switch (num10)
          {
            case 1:
              goto label_24;
            default:
              DiagnosticsCompleteSessionAppender.QUZ6SYESsY88qp23Jb21(DiagnosticsCompleteSessionAppender.i3WjyIESLJ14i9aw7wHf(), DiagnosticsCompleteSessionAppender.yVcrklESUfvWdRmKSI5J(DiagnosticsCompleteSessionAppender.V8jcLvESMh9liOgDrBId(-244066886 - -48452443 ^ -195855413)), (object) ex);
              num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
              continue;
          }
        }
label_24:;
      }
    }

    private void InternalSaveWriteZipStream(
      byte[] buffer,
      int offset,
      int length,
      (ZipOutputStream, string) param)
    {
      (ZipOutputStream zipOutputStream, string s) = param;
      Encoding.UTF8.GetBytes(s, offset, s.Length, buffer, offset);
      zipOutputStream.Write(buffer, offset, length);
    }

    static DiagnosticsCompleteSessionAppender()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DiagnosticsCompleteSessionAppender.SupportedEventTypes = new Type[4]
            {
              TypeOf<BackgroundThreadEndEvent>.Raw,
              TypeOf<BackgroundThreadErrorEvent>.Raw,
              TypeOf<WebRequestEndEvent>.Raw,
              TypeOf<WebRequestErrorEvent>.Raw
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
            DiagnosticsCompleteSessionAppender.POTTO9ES4W1N3E3Jh6cH();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void POTTO9ES4W1N3E3Jh6cH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool LL7q2BEStFrljn7fnu7I() => DiagnosticsCompleteSessionAppender.wA8DLgESDktciDGer4KA == null;

    internal static DiagnosticsCompleteSessionAppender wP20jwESwSlwiwcHU22q() => DiagnosticsCompleteSessionAppender.wA8DLgESDktciDGer4KA;

    internal static int Uy6Bs5ES6pnSu9DGIxWm([In] object obj0) => ((List<CallContextInfo>) obj0).Count;

    internal static bool hHB3H7ESHj97PE0MPCMS([In] object obj0, [In] object obj1) => ThreadPool.QueueUserWorkItem((WaitCallback) obj0, obj1);

    internal static void UGYSfvESAVExIQ1VPsGF([In] object obj0) => Monitor.Exit(obj0);

    internal static object efQJBZES7DC1tB07E8yN([In] object obj0) => ((LoggingEvent) obj0).MessageObject;

    internal static object dMomgtESxp2se9N6eX2H([In] object obj0) => (object) ((DiagnosticsEvent) obj0).CallContextInfo;

    internal static object icGbpcES0TgBVgRMCS7h([In] object obj0) => (object) SystemInfo.ConvertToFullPath((string) obj0);

    internal static bool sL5bWPESmQdC8Y78GAOE([In] object obj0) => System.IO.Directory.Exists((string) obj0);

    internal static object vHNakTESy570IM0oKsCb([In] object obj0) => (object) System.IO.Directory.CreateDirectory((string) obj0);

    internal static object V8jcLvESMh9liOgDrBId(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object mxcT8qESJyAuW8yPuFGF() => (object) Environment.MachineName;

    internal static DateTime minE3LES9WrRkoBdC1NF() => DateTime.Now;

    internal static object kR778bESd43VaJgEqFRP([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object dRLSe2ESl92KJaBK584H([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool Lwr6bjESrQhFxXUX99tO([In] object obj0) => File.Exists((string) obj0);

    internal static void GoC2a4ESgceir8Tk1Uox([In] object obj0) => ((DeflaterOutputStream) obj0).Finish();

    internal static void dEIHFBES5OTIk2L4kUu4([In] object obj0) => ((Stream) obj0).Close();

    internal static void sTtEa4ESjSXKYJTNCyrY([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object CkDXTwESYOdiw6gQ9kL7([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object i3WjyIESLJ14i9aw7wHf() => (object) Logger.Log;

    internal static object yVcrklESUfvWdRmKSI5J([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void QUZ6SYESsY88qp23Jb21([In] object obj0, [In] object obj1, [In] object obj2) => ((EleWise.ELMA.Logging.ILogger) obj0).Error(obj1, (Exception) obj2);
  }
}
