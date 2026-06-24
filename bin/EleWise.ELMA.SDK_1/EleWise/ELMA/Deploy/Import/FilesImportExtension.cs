// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.FilesImportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Services;
using EleWise.ELMA.Files;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>
  /// Класс, обрабатывающий вложенные пользовательские файлы импортируемого пакета
  /// </summary>
  [Component(Order = 50)]
  public class FilesImportExtension : ConfigImportExtension
  {
    private string shouldReadDocuments;
    /// <summary>Сервис работы с дополнительными файлами</summary>
    private readonly IAdditionalFilesService additionalFilesService;
    internal static FilesImportExtension lnfcjuEmEMY47Cnt1iLT;

    /// <summary>Ctor</summary>
    /// <param name="additionalFilesService">Среда исполнения приложения</param>
    public FilesImportExtension(IAdditionalFilesService additionalFilesService)
    {
      FilesImportExtension.r2dYaBEmCNZlUeM4t7h0();
      this.shouldReadDocuments = (string) FilesImportExtension.X3q3jJEm8EwQW6t9YDs4(FilesImportExtension.BdOPWmEmv1oM1QSYDT8J(1218962250 ^ 1218661072));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.additionalFilesService = additionalFilesService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override void OnPostCompleteTest(PostCompleteTestImportParameters parameters)
    {
      int num1 = 5;
      IEnumerator<DeploySystemMessage> enumerator;
      while (true)
      {
        int num2 = num1;
        IEnumerable<DeploySystemMessage> source;
        while (true)
        {
          string str1;
          string src;
          string str2;
          ElmaStoreComponentManifest componentManifest;
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              goto label_49;
            case 3:
              if (FilesImportExtension.AjYxbjEmuiR6m6lhMk2P(FilesImportExtension.WGEFoWEmZtMQCGQlaIXb((object) parameters)))
              {
                num2 = 17;
                continue;
              }
              str2 = Path.Combine(parameters.ServerFolderName, (string) FilesImportExtension.BdOPWmEmv1oM1QSYDT8J(1917256330 ^ 1917025476));
              break;
            case 4:
              goto label_25;
            case 5:
              if (parameters.Manifest == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 4 : 2;
                continue;
              }
              goto case 3;
            case 6:
              componentManifest = (ElmaStoreComponentManifest) null;
              goto label_46;
            case 7:
              goto label_18;
            case 8:
              if (!source.Any<DeploySystemMessage>())
              {
                num2 = 18;
                continue;
              }
              goto default;
            case 9:
              enumerator = source.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 1;
              continue;
            case 10:
              goto label_48;
            case 11:
              FilesImportExtension.maxSqDEmitUnebfGxfoJ((object) str1, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 16 : 14;
              continue;
            case 12:
              if (!FilesImportExtension.AjYxbjEmuiR6m6lhMk2P((object) src))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 15 : 15;
                continue;
              }
              goto label_42;
            case 13:
              if (Directory.Exists(str1))
              {
                num2 = 11;
                continue;
              }
              goto case 16;
            case 14:
              goto label_16;
            case 15:
              if (!FilesImportExtension.rlxEIPEmIl8APf9ZqenK((object) src))
              {
                num2 = 2;
                continue;
              }
              goto case 21;
            case 16:
              Directory.CreateDirectory(str1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 3 : 20;
              continue;
            case 17:
              str2 = (string) null;
              break;
            case 18:
              goto label_13;
            case 19:
              if (FilesImportExtension.cxK67QEmRWrOsfjGR30r((object) parameters) is ConfigImportSettings configImportSettings)
              {
                componentManifest = configImportSettings.Manifest;
                goto label_46;
              }
              else
                goto label_43;
            case 20:
              FileUtils.CopyDirectory(src, str1);
              num2 = 19;
              continue;
            case 21:
              str1 = (string) FilesImportExtension.OWHkQlEmSdx7NFMN6UZB((object) this.additionalFilesService, FilesImportExtension.sW5Wh8EmVZPPjBMpGC4x((object) parameters));
              num2 = 13;
              continue;
            default:
              parameters.Messages.Add(new TestImportMessages(TestImportMessagesType.InfoCommon, this.shouldReadDocuments));
              num2 = 9;
              continue;
          }
          src = str2;
          num2 = 12;
          continue;
label_46:
          if (componentManifest == null)
            num2 = 14;
          else
            goto label_48;
        }
label_43:
        num1 = 6;
        continue;
label_48:
        List<DeploySystemMessage> systemMessages = parameters.SystemMessages;
        // ISSUE: reference to a compiler-generated field
        Func<DeploySystemMessage, bool> func = FilesImportExtension.\u003C\u003Ec.\u003C\u003E9__3_0;
        Func<DeploySystemMessage, bool> predicate;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          FilesImportExtension.\u003C\u003Ec.\u003C\u003E9__3_0 = predicate = (Func<DeploySystemMessage, bool>) (m => (string) FilesImportExtension.\u003C\u003Ec.CiLWVM8DNkRYGrjrE1ZH((object) m) == (string) FilesImportExtension.\u003C\u003Ec.moa8dc8D3AKyrOtsmYaD(~289714581 ^ -289413970));
        }
        else
          goto label_52;
label_51:
        source = systemMessages.Where<DeploySystemMessage>(predicate);
        num1 = 8;
        continue;
label_52:
        predicate = func;
        goto label_51;
      }
label_49:
      return;
label_25:
      return;
label_18:
      return;
label_16:
      return;
label_13:
      return;
label_3:
      try
      {
label_5:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_6;
label_4:
        DeploySystemMessage current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_34;
            case 2:
              goto label_5;
            case 3:
              parameters.Messages.Add(new TestImportMessages(TestImportMessagesType.InfoCommon, (string) FilesImportExtension.d3lfh8EmqiAGjZpjQtFL((object) current)));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 2;
              continue;
            default:
              goto label_7;
          }
        }
label_34:
        return;
label_6:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
        goto label_4;
label_7:
        current = enumerator.Current;
        num3 = 3;
        goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                enumerator.Dispose();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
                continue;
              default:
                goto label_15;
            }
          }
        }
label_15:;
      }
label_42:;
    }

    /// <inheritdoc />
    public override void OnPostReadPackets(PostReadPacketsParameters parameters)
    {
      int num1 = 16;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string str;
          object obj;
          switch (num2)
          {
            case 1:
              goto label_23;
            case 2:
              if (!FilesImportExtension.rlxEIPEmIl8APf9ZqenK((object) str))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 7 : 7;
                continue;
              }
              goto case 3;
            case 3:
              if (!string.IsNullOrEmpty((string) FilesImportExtension.G9Nq1yEmn1fo75FLOjT2(FilesImportExtension.rjnO34EmX74OkyjsSWbj((object) parameters))))
                goto case 5;
              else
                goto label_22;
            case 4:
              goto label_6;
            case 5:
              FilesImportExtension.G9Nq1yEmn1fo75FLOjT2(FilesImportExtension.rjnO34EmX74OkyjsSWbj((object) parameters));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 6 : 3;
              continue;
            case 6:
            case 9:
              parameters.SystemMessages.Add(new DeploySystemMessage(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979738490), (string) FilesImportExtension.iXkkFyEmOM23a5QWnvoe((object) this.additionalFilesService, (object) parameters.Manifest)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
              continue;
            case 7:
              goto label_3;
            case 8:
              if (FilesImportExtension.AjYxbjEmuiR6m6lhMk2P(FilesImportExtension.XhYB43EmTMhrlddrbCcb((object) parameters)))
              {
                num2 = 14;
                continue;
              }
              obj = FilesImportExtension.qgkmgZEmk7K2K8NFHwom(FilesImportExtension.XhYB43EmTMhrlddrbCcb((object) parameters), FilesImportExtension.BdOPWmEmv1oM1QSYDT8J(-1255365154 ^ 596875508 ^ -1766112412));
              break;
            case 10:
              if (FilesImportExtension.AjYxbjEmuiR6m6lhMk2P((object) str))
              {
                num2 = 4;
                continue;
              }
              goto case 2;
            case 11:
              goto label_29;
            case 12:
              string id = ((ElmaStoreComponentManifest) FilesImportExtension.rjnO34EmX74OkyjsSWbj((object) parameters)).Id;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 9 : 2;
              continue;
            case 13:
              parameters.SystemMessages.Add(new DeploySystemMessage((string) FilesImportExtension.BdOPWmEmv1oM1QSYDT8J(1461825605 - 1531863589 ^ -69737182), parameters.Manifest.HelpFileName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
              continue;
            case 14:
              obj = (object) null;
              break;
            case 15:
              if (FilesImportExtension.rjnO34EmX74OkyjsSWbj((object) parameters) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 4 : 8;
                continue;
              }
              goto label_10;
            case 16:
              if (FilesImportExtension.n3mmJbEmKBVx71yZDuAI((object) parameters) == 2)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 13 : 15;
                continue;
              }
              goto label_11;
            default:
              if (string.IsNullOrEmpty(((ElmaStoreComponentManifest) FilesImportExtension.rjnO34EmX74OkyjsSWbj((object) parameters)).HelpFileName))
              {
                num2 = 11;
                continue;
              }
              goto case 13;
          }
          str = (string) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 4 : 10;
        }
label_22:
        num1 = 12;
      }
label_23:
      return;
label_6:
      return;
label_3:
      return;
label_29:
      return;
label_11:
      return;
label_10:;
    }

    /// <inheritdoc />
    public override void OnImportSuccessfull(ImportSuccessfullParameters parameters)
    {
      int num1 = 4;
      IEnumerator<DeploySystemMessage> enumerator;
      while (true)
      {
        int num2 = num1;
        IEnumerable<DeploySystemMessage> source;
        while (true)
        {
          ElmaStoreComponentManifest componentManifest;
          switch (num2)
          {
            case 1:
              goto label_29;
            case 2:
              goto label_9;
            case 3:
              componentManifest = (ElmaStoreComponentManifest) null;
              break;
            case 4:
              if (!(FilesImportExtension.FT3RmBEm2vs1c86c1ijT((object) parameters) is ConfigImportSettings configImportSettings))
              {
                num2 = 3;
                continue;
              }
              componentManifest = configImportSettings.Manifest;
              break;
            case 5:
              if (source.Any<DeploySystemMessage>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                continue;
              }
              goto label_22;
            case 6:
              goto label_30;
            case 7:
              enumerator = source.GetEnumerator();
              num2 = 2;
              continue;
            default:
              parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, this.shouldReadDocuments));
              num2 = 7;
              continue;
          }
          if (componentManifest != null)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
          else
            goto label_19;
        }
label_29:
        List<DeploySystemMessage> systemMessages = parameters.SystemMessages;
        // ISSUE: reference to a compiler-generated field
        Func<DeploySystemMessage, bool> func = FilesImportExtension.\u003C\u003Ec.\u003C\u003E9__5_0;
        Func<DeploySystemMessage, bool> predicate;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          FilesImportExtension.\u003C\u003Ec.\u003C\u003E9__5_0 = predicate = (Func<DeploySystemMessage, bool>) (m => FilesImportExtension.\u003C\u003Ec.ILLH6Q8DpQw6lm1LJbiE(FilesImportExtension.\u003C\u003Ec.CiLWVM8DNkRYGrjrE1ZH((object) m), FilesImportExtension.\u003C\u003Ec.moa8dc8D3AKyrOtsmYaD(~289714581 ^ -289413970)));
        }
        else
          goto label_3;
label_32:
        source = systemMessages.Where<DeploySystemMessage>(predicate);
        num1 = 5;
        continue;
label_3:
        predicate = func;
        goto label_32;
      }
label_30:
      return;
label_22:
      return;
label_9:
      try
      {
label_11:
        if (FilesImportExtension.pvZsqUEmeRykuFTun5Tw((object) enumerator))
          goto label_13;
        else
          goto label_12;
label_10:
        DeploySystemMessage current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_13;
            case 2:
              goto label_15;
            case 3:
              parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, (string) FilesImportExtension.d3lfh8EmqiAGjZpjQtFL((object) current)));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            default:
              goto label_11;
          }
        }
label_15:
        return;
label_12:
        num3 = 2;
        goto label_10;
label_13:
        current = enumerator.Current;
        num3 = 3;
        goto label_10;
      }
      finally
      {
        int num4;
        if (enumerator == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
        else
          goto label_20;
label_18:
        switch (num4)
        {
          case 1:
          case 2:
        }
label_20:
        FilesImportExtension.N3r1UEEmPrxE6LaVEVJg((object) enumerator);
        num4 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        {
          num4 = 2;
          goto label_18;
        }
        else
          goto label_18;
      }
label_19:;
    }

    internal static void r2dYaBEmCNZlUeM4t7h0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object BdOPWmEmv1oM1QSYDT8J(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object X3q3jJEm8EwQW6t9YDs4([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool HSbCbYEmfe4S9y7C0lf1() => FilesImportExtension.lnfcjuEmEMY47Cnt1iLT == null;

    internal static FilesImportExtension KlLkqnEmQZ1YWRQHtPtI() => FilesImportExtension.lnfcjuEmEMY47Cnt1iLT;

    internal static object WGEFoWEmZtMQCGQlaIXb([In] object obj0) => (object) ((TestImportExtensionParameters) obj0).ServerFolderName;

    internal static bool AjYxbjEmuiR6m6lhMk2P([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool rlxEIPEmIl8APf9ZqenK([In] object obj0) => Directory.Exists((string) obj0);

    internal static object sW5Wh8EmVZPPjBMpGC4x([In] object obj0) => (object) ((TestImportExtensionParameters) obj0).Manifest;

    internal static object OWHkQlEmSdx7NFMN6UZB([In] object obj0, [In] object obj1) => (object) ((IAdditionalFilesService) obj0).GetStoreAdditionalFilesPath((ElmaStoreComponentManifest) obj1);

    internal static void maxSqDEmitUnebfGxfoJ([In] object obj0, [In] bool obj1) => Directory.Delete((string) obj0, obj1);

    internal static object cxK67QEmRWrOsfjGR30r([In] object obj0) => (object) ((PostCompleteTestImportParameters) obj0).ImportSettings;

    internal static object d3lfh8EmqiAGjZpjQtFL([In] object obj0) => (object) ((DeploySystemMessage) obj0).Value;

    internal static int n3mmJbEmKBVx71yZDuAI([In] object obj0) => ((ImportExtensionParameters) obj0).ImportStep;

    internal static object rjnO34EmX74OkyjsSWbj([In] object obj0) => (object) ((ImportExtensionParameters) obj0).Manifest;

    internal static object XhYB43EmTMhrlddrbCcb([In] object obj0) => (object) ((ImportExtensionParameters) obj0).ServerFolderName;

    internal static object qgkmgZEmk7K2K8NFHwom([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static object G9Nq1yEmn1fo75FLOjT2([In] object obj0) => (object) ((ElmaStoreComponentManifest) obj0).Title;

    internal static object iXkkFyEmOM23a5QWnvoe([In] object obj0, [In] object obj1) => (object) ((IAdditionalFilesService) obj0).GetStoreAdditionalFilesPathMessage((ElmaStoreComponentManifest) obj1);

    internal static object FT3RmBEm2vs1c86c1ijT([In] object obj0) => (object) ((ImportSuccessfullParameters) obj0).ImportSettings;

    internal static bool pvZsqUEmeRykuFTun5Tw([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void N3r1UEEmPrxE6LaVEVJg([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
