// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Models.BaseExportCheckingResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Export.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Export.Models
{
  /// <summary>Результат проверки экспорта</summary>
  public sealed class BaseExportCheckingResult : IExportCheckingResult
  {
    private List<ExportCheckingMessage> messages;
    internal static BaseExportCheckingResult PTQgEQELOFQedUFs9AxD;

    /// <inheritdoc />
    public IReadOnlyCollection<ExportCheckingMessage> Messages => (IReadOnlyCollection<ExportCheckingMessage>) this.messages;

    /// <inheritdoc />
    public void AddMessage(ExportCheckingMessageType type, string text)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            BaseExportCheckingResult.ryIesOEL1vlt4T4hNu2n((object) text, BaseExportCheckingResult.x3B1cNELP73DnbX1NR0K(~1767720452 ^ -1767674949));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            List<ExportCheckingMessage> messages = this.messages;
            ExportCheckingMessage exportCheckingMessage = new ExportCheckingMessage();
            BaseExportCheckingResult.tWdUSEELNS2spCkVTeRb((object) exportCheckingMessage, type);
            exportCheckingMessage.Text = text;
            messages.Add(exportCheckingMessage);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public void AddMessage(ExportCheckingMessageType type, string text, Guid uid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            BaseExportCheckingResult.ryIesOEL1vlt4T4hNu2n((object) text, BaseExportCheckingResult.x3B1cNELP73DnbX1NR0K(236071375 ^ 236190607));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            List<ExportCheckingMessage> messages = this.messages;
            ExportCheckingMessage exportCheckingMessage = new ExportCheckingMessage();
            BaseExportCheckingResult.tWdUSEELNS2spCkVTeRb((object) exportCheckingMessage, type);
            exportCheckingMessage.Text = text;
            BaseExportCheckingResult.lxeNM9EL3TmxoMpeS618((object) exportCheckingMessage, uid);
            messages.Add(exportCheckingMessage);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public void AddMessage(ExportCheckingMessage message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            BaseExportCheckingResult.cAjbSLELpj4pW1Wm81ii((object) message, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -868024270));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.messages.Add(message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public void AddMessages(IEnumerable<ExportCheckingMessage> messages)
    {
      Contract.ArgumentNotNull((object) messages, z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516618358));
      this.messages.AddRange(messages);
    }

    public BaseExportCheckingResult()
    {
      BaseExportCheckingResult.m9LlXTELalZ5L6BuXcpZ();
      this.messages = new List<ExportCheckingMessage>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object x3B1cNELP73DnbX1NR0K(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void ryIesOEL1vlt4T4hNu2n([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static void tWdUSEELNS2spCkVTeRb([In] object obj0, ExportCheckingMessageType value) => ((ExportCheckingMessage) obj0).Type = value;

    internal static bool q8rMA8EL2FIXvANsXmSw() => BaseExportCheckingResult.PTQgEQELOFQedUFs9AxD == null;

    internal static BaseExportCheckingResult isdfjjELegt2UFUyIQW0() => BaseExportCheckingResult.PTQgEQELOFQedUFs9AxD;

    internal static void lxeNM9EL3TmxoMpeS618([In] object obj0, Guid value) => ((ExportCheckingMessage) obj0).Uid = value;

    internal static void cAjbSLELpj4pW1Wm81ii([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void m9LlXTELalZ5L6BuXcpZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
