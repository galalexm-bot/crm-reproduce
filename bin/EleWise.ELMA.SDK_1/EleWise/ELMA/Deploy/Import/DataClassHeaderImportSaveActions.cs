// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.DataClassHeaderImportSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>
  /// Действия, выполняемые при сохранении сущности <see cref="T:EleWise.ELMA.Model.Metadata.DataClassMetadataItemHeader" />
  /// </summary>
  internal sealed class DataClassHeaderImportSaveActions : EntityImportSaveActions
  {
    private static readonly Guid Uid;
    private readonly IFeatureFlagService featureFlagService;
    private static DataClassHeaderImportSaveActions cB9Qe1ExxEKmTUothhRQ;

    /// <summary>Ctor</summary>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    public DataClassHeaderImportSaveActions(IFeatureFlagService featureFlagService)
    {
      DataClassHeaderImportSaveActions.yRstKgExybHk0HXyo43U();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.featureFlagService = featureFlagService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override bool IsSupported(Guid typeGuid) => typeGuid == DataClassHeaderImportSaveActions.Uid;

    /// <inheritdoc />
    public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
    {
      int num1 = 14;
      while (true)
      {
        int num2 = num1;
        XmlReader xmlReader;
        Guid result1;
        string title;
        while (true)
        {
          switch (num2)
          {
            case 1:
              title = (string) null;
              num2 = 18;
              continue;
            case 2:
              if (!DataClassHeaderImportSaveActions.YX06nnExU32SGHHKgZL7(result1, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 33 : 3;
                continue;
              }
              goto case 23;
            case 3:
              DataClassHeaderImportSaveActions.NZLG6AExJKlueaiFRJSd((object) xmlReader);
              num2 = 20;
              continue;
            case 4:
              if (!DataClassHeaderImportSaveActions.h5hrQvExr4s85og1Z3Jr((object) xmlReader))
              {
                num2 = 21;
                continue;
              }
              goto case 32;
            case 5:
              xmlReader.Read();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 17 : 22;
              continue;
            case 6:
              xmlReader.Read();
              num2 = 12;
              continue;
            case 7:
              Guid.TryParse(xmlReader.ReadString(), out result1);
              num2 = 6;
              continue;
            case 8:
            case 17:
              if (DataClassHeaderImportSaveActions.nCXyvCExYljfyyMxeMAU((object) xmlReader) == XmlNodeType.EndElement)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 18 : 35;
                continue;
              }
              goto case 27;
            case 9:
              if (DataClassHeaderImportSaveActions.hRkNPGExlZAG7rNaWxtv(DataClassHeaderImportSaveActions.OOf4v5ExdFcJ3IUrZHgm((object) xmlReader), (object) DataClassMetadataItemHeaderManager._Resources_PropertyNames.Uid))
              {
                num2 = 4;
                continue;
              }
              goto case 32;
            case 10:
              xmlReader.MoveToElement();
              num2 = 36;
              continue;
            case 11:
              if (!DataClassHeaderImportSaveActions.h5hrQvExr4s85og1Z3Jr((object) xmlReader))
              {
                num2 = 3;
                continue;
              }
              goto default;
            case 12:
            case 22:
            case 28:
            case 30:
            case 34:
              DataClassHeaderImportSaveActions.SUHBoNExjuXt9Kjfts5i((object) xmlReader);
              num2 = 37;
              continue;
            case 13:
              xmlReader.Read();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 25 : 16;
              continue;
            case 14:
              xmlReader = (XmlReader) DataClassHeaderImportSaveActions.r1kTWeExMFlkxrD8ehw5((object) data);
              num2 = 13;
              continue;
            case 15:
              goto label_5;
            case 16:
              goto label_20;
            case 18:
              goto label_25;
            case 19:
              goto label_40;
            case 20:
              xmlReader.ReadString();
              num2 = 5;
              continue;
            case 21:
              DataClassHeaderImportSaveActions.NZLG6AExJKlueaiFRJSd((object) xmlReader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 3 : 7;
              continue;
            case 23:
              ((BPMAppFakeManifest) DataClassHeaderImportSaveActions.t0JkTxExcTYQ5JQHLYPr(DataClassHeaderImportSaveActions.M5D3tCExsLNI1xo9sTW7((object) data))).GetOrCreateChapterByUid(ObjectsExportConsts.ExportExtensionUidDataClass).GetOrCreateItemByUid(result1, title);
              num2 = 19;
              continue;
            case 24:
              DataClassHeaderImportSaveActions.gWrklqEx9vFnL7iRxEYU((object) xmlReader);
              num2 = 31;
              continue;
            case 25:
              DataClassHeaderImportSaveActions.NZLG6AExJKlueaiFRJSd((object) xmlReader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 14 : 24;
              continue;
            case 26:
              if (DataClassHeaderImportSaveActions.hRkNPGExlZAG7rNaWxtv(DataClassHeaderImportSaveActions.OOf4v5ExdFcJ3IUrZHgm((object) xmlReader), (object) DataClassMetadataItemHeaderManager._Resources_PropertyNames.DisplayName))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 38 : 38;
                continue;
              }
              goto case 12;
            case 27:
              if (xmlReader.IsStartElement())
              {
                num2 = 9;
                continue;
              }
              goto case 32;
            case 29:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) DataClassHeaderImportSaveActions.JCoYkjExLwDbi1ceKJDh(-218496594 ^ -218195428), (object) title)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 15 : 10;
              continue;
            case 31:
              DataClassHeaderImportSaveActions.NZLG6AExJKlueaiFRJSd((object) xmlReader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
              continue;
            case 32:
              if (DataClassHeaderImportSaveActions.t3aUyHExg1s20VZETltj((object) xmlReader))
              {
                num2 = 39;
                continue;
              }
              goto default;
            case 33:
              goto label_36;
            case 35:
              if (this.featureFlagService.Enabled((string) DataClassHeaderImportSaveActions.JCoYkjExLwDbi1ceKJDh(-542721635 ^ -542763113), false))
              {
                num2 = 2;
                continue;
              }
              goto case 29;
            case 36:
              title = (string) DataClassHeaderImportSaveActions.YNqqxFEx5oyqDVHNsT4M((object) xmlReader);
              num2 = 16;
              continue;
            case 37:
              int content = (int) xmlReader.MoveToContent();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 8 : 6;
              continue;
            case 38:
              if (DataClassHeaderImportSaveActions.h5hrQvExr4s85og1Z3Jr((object) xmlReader))
              {
                num2 = 34;
                continue;
              }
              goto case 10;
            case 39:
              if (!DataClassHeaderImportSaveActions.hRkNPGExlZAG7rNaWxtv(DataClassHeaderImportSaveActions.OOf4v5ExdFcJ3IUrZHgm((object) xmlReader), (object) DataClassMetadataItemHeaderManager._Resources_PropertyNames.Name))
                goto default;
              else
                goto label_13;
            default:
              if (!DataClassHeaderImportSaveActions.t3aUyHExg1s20VZETltj((object) xmlReader))
              {
                num2 = 28;
                continue;
              }
              goto case 26;
          }
        }
label_13:
        num1 = 11;
        continue;
label_20:
        DataClassHeaderImportSaveActions.gWrklqEx9vFnL7iRxEYU((object) xmlReader);
        num1 = 30;
        continue;
label_25:
        result1 = Guid.Empty;
        num1 = 17;
      }
label_5:
      return;
label_40:
      return;
label_36:;
    }

    static DataClassHeaderImportSaveActions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DataClassHeaderImportSaveActions.Uid = InterfaceActivator.UID<DataClassMetadataItemHeader>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void yRstKgExybHk0HXyo43U() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool B8WpaREx0ib5Q4f8Qf7P() => DataClassHeaderImportSaveActions.cB9Qe1ExxEKmTUothhRQ == null;

    internal static DataClassHeaderImportSaveActions XoUOSZExmsdPv4Nq8mUe() => DataClassHeaderImportSaveActions.cB9Qe1ExxEKmTUothhRQ;

    internal static object r1kTWeExMFlkxrD8ehw5([In] object obj0) => (object) ((ImportTestReadData) obj0).Reader;

    internal static bool NZLG6AExJKlueaiFRJSd([In] object obj0) => ((XmlReader) obj0).MoveToElement();

    internal static bool gWrklqEx9vFnL7iRxEYU([In] object obj0) => ((XmlReader) obj0).Read();

    internal static object OOf4v5ExdFcJ3IUrZHgm([In] object obj0) => (object) ((XmlReader) obj0).Name;

    internal static bool hRkNPGExlZAG7rNaWxtv([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool h5hrQvExr4s85og1Z3Jr([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static bool t3aUyHExg1s20VZETltj([In] object obj0) => ((XmlReader) obj0).IsStartElement();

    internal static object YNqqxFEx5oyqDVHNsT4M([In] object obj0) => (object) ((XmlReader) obj0).ReadString();

    internal static void SUHBoNExjuXt9Kjfts5i([In] object obj0) => ((XmlReader) obj0).Skip();

    internal static XmlNodeType nCXyvCExYljfyyMxeMAU([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static object JCoYkjExLwDbi1ceKJDh(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool YX06nnExU32SGHHKgZL7([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object M5D3tCExsLNI1xo9sTW7([In] object obj0) => (object) ((ImportTestReadData) obj0).ConfigImportSettings;

    internal static object t0JkTxExcTYQ5JQHLYPr([In] object obj0) => (object) ((IConfigImportSettings) obj0).FakeManifest;
  }
}
