// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Deploy.Import.ComponentMetadataItemHeaderImportSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.UI.Deploy.Export;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.UI.Deploy.Import
{
  /// <summary>
  /// Действия, выполняемые при сохранении <see cref="T:EleWise.ELMA.UI.Models.ComponentMetadataItemHeader" />
  /// </summary>
  internal sealed class ComponentMetadataItemHeaderImportSaveActions : EntityImportSaveActions
  {
    private static readonly Guid Uid;
    private readonly IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager;
    private readonly IFeatureFlagService featureFlagService;
    private static ComponentMetadataItemHeaderImportSaveActions xHAaPZdt19SM8bdIJmy;

    /// <summary>Ctor</summary>
    /// <param name="componentMetadataItemHeaderManager">Менеджер заголовков метаданных компонента</param>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    public ComponentMetadataItemHeaderImportSaveActions(
      IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager,
      IFeatureFlagService featureFlagService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.componentMetadataItemHeaderManager = componentMetadataItemHeaderManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.featureFlagService = featureFlagService;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override bool IsSupported(Guid typeGuid) => typeGuid == ComponentMetadataItemHeaderImportSaveActions.Uid;

    /// <inheritdoc />
    public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
    {
      int num1 = 66;
      while (true)
      {
        int num2 = num1;
        Guid result1;
        string str;
        string errorMessage;
        XmlReader reader;
        string name;
        Guid result2;
        BPMAppManifestFakeChapter chapterByUid;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 11:
            case 24:
            case 30:
              if (!reader.IsStartElement())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 2 : 12;
                continue;
              }
              goto case 20;
            case 2:
            case 53:
            case 54:
              chapterByUid.GetOrCreateItemByUid(result1, str);
              num2 = 7;
              continue;
            case 3:
              chapterByUid = ((BPMAppFakeManifest) ComponentMetadataItemHeaderImportSaveActions.OfQWFTdgCuEc8oRCXQ7(ComponentMetadataItemHeaderImportSaveActions.FZV5oxdrcHBdLvNwRv4((object) data))).GetOrCreateChapterByUid(UIFormExportConsts.ExportExtensionUidPortlet);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 5 : 54;
              continue;
            case 4:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Warning, EleWise.ELMA.SR.T((string) ComponentMetadataItemHeaderImportSaveActions.SR4Dn5d9IkNOKEYC9my(1113862659 ^ 1113883485), (object) str, (object) errorMessage)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 19 : 5;
              continue;
            case 5:
              name = reader.ReadString();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 50 : 42;
              continue;
            case 6:
              if (ComponentMetadataItemHeaderImportSaveActions.kTaFQ1d0Wc0t3ZRb0lw((object) reader))
              {
                num2 = 24;
                continue;
              }
              goto case 39;
            case 7:
              goto label_12;
            case 8:
              reader.MoveToElement();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 12 : 17;
              continue;
            case 9:
              chapterByUid = ((BPMAppFakeManifest) ComponentMetadataItemHeaderImportSaveActions.OfQWFTdgCuEc8oRCXQ7(ComponentMetadataItemHeaderImportSaveActions.FZV5oxdrcHBdLvNwRv4((object) data))).GetOrCreateChapterByUid(UIFormExportConsts.ExportExtensionUidPage);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 2 : 53;
              continue;
            case 10:
              str = (string) ComponentMetadataItemHeaderImportSaveActions.ENaoYqdmoVb0IpgBn72((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 29 : 42;
              continue;
            case 12:
            case 61:
              if (!ComponentMetadataItemHeaderImportSaveActions.hysUC4dAEHxn7eY9rEi((object) reader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 23 : 32;
                continue;
              }
              goto case 48;
            case 13:
              int num3 = (int) ComponentMetadataItemHeaderImportSaveActions.VMeIbidM17CNxhilK4i((object) reader);
              num2 = 27;
              continue;
            case 14:
              name = (string) null;
              num2 = 28;
              continue;
            case 15:
              goto label_7;
            case 16:
              if (!ComponentMetadataItemHeaderImportSaveActions.VpAX7bdx8DFq476gF7E(ComponentMetadataItemHeaderImportSaveActions.CuFidsd7FcbhWixlLDm((object) reader), (object) ComponentMetadataItemHeaderManager._Resources_PropertyNames.MetadataTypeUid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 17 : 31;
                continue;
              }
              goto case 64;
            case 17:
              ComponentMetadataItemHeaderImportSaveActions.FHpqg1d6f0232ZtOjjK((object) reader);
              num2 = 56;
              continue;
            case 18:
              if (!ComponentMetadataItemHeaderImportSaveActions.VpAX7bdx8DFq476gF7E(ComponentMetadataItemHeaderImportSaveActions.CuFidsd7FcbhWixlLDm((object) reader), (object) ComponentMetadataItemHeaderManager._Resources_PropertyNames.Uid))
              {
                num2 = 11;
                continue;
              }
              goto case 6;
            case 19:
              if (result1 != Guid.Empty)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 63 : 42;
                continue;
              }
              goto label_75;
            case 20:
              if (ComponentMetadataItemHeaderImportSaveActions.VpAX7bdx8DFq476gF7E(ComponentMetadataItemHeaderImportSaveActions.CuFidsd7FcbhWixlLDm((object) reader), (object) ComponentMetadataItemHeaderManager._Resources_PropertyNames.Name))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                continue;
              }
              goto case 12;
            case 21:
            case 23:
            case 26:
            case 31:
            case 37:
            case 51:
              ComponentMetadataItemHeaderImportSaveActions.tQFOVudyMOrHtsbR5Wt((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 2 : 13;
              continue;
            case 22:
              if (ComponentMetadataItemHeaderImportSaveActions.kTaFQ1d0Wc0t3ZRb0lw((object) reader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 55 : 0;
                continue;
              }
              goto case 52;
            case 25:
              if (!ComponentMetadataItemHeaderImportSaveActions.hysUC4dAEHxn7eY9rEi((object) reader))
              {
                num2 = 30;
                continue;
              }
              goto case 18;
            case 27:
            case 58:
              if (ComponentMetadataItemHeaderImportSaveActions.dJkcSrdJ6yeta6qwM85((object) reader) != XmlNodeType.EndElement)
                goto case 25;
              else
                goto label_18;
            case 28:
              str = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 39 : 47;
              continue;
            case 29:
              Guid.TryParse((string) ComponentMetadataItemHeaderImportSaveActions.ENaoYqdmoVb0IpgBn72((object) reader), out result2);
              num2 = 57;
              continue;
            case 32:
            case 45:
            case 55:
              if (!ComponentMetadataItemHeaderImportSaveActions.hysUC4dAEHxn7eY9rEi((object) reader))
              {
                num2 = 23;
                continue;
              }
              goto case 16;
            case 33:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Warning, EleWise.ELMA.SR.T((string) ComponentMetadataItemHeaderImportSaveActions.SR4Dn5d9IkNOKEYC9my(323422137 << 2 ^ 1293726140), (object) name)));
              num2 = 15;
              continue;
            case 34:
              chapterByUid = ((BPMAppFakeManifest) ComponentMetadataItemHeaderImportSaveActions.OfQWFTdgCuEc8oRCXQ7(ComponentMetadataItemHeaderImportSaveActions.FZV5oxdrcHBdLvNwRv4((object) data))).GetOrCreateChapterByUid(ComponentExportConsts.ExportExtensionUid);
              num2 = 2;
              continue;
            case 35:
              goto label_76;
            case 36:
              if (ComponentMetadataItemHeaderImportSaveActions.D1Gbsndl7ddSXxhlkWN(result2, PortletComponentMetadata.TypeUid))
              {
                num2 = 3;
                continue;
              }
              goto case 34;
            case 38:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) ComponentMetadataItemHeaderImportSaveActions.SR4Dn5d9IkNOKEYC9my(272623989 ^ 272582445), (object) str)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 35 : 23;
              continue;
            case 39:
              ComponentMetadataItemHeaderImportSaveActions.ljNQKydHBMpXxvELvYG((object) reader);
              num2 = 46;
              continue;
            case 40:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Warning, EleWise.ELMA.SR.T((string) ComponentMetadataItemHeaderImportSaveActions.SR4Dn5d9IkNOKEYC9my(92412609 - 1050237057 ^ -957844920), (object) name, (object) errorMessage)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 19 : 62;
              continue;
            case 41:
              result2 = Guid.Empty;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 12 : 58;
              continue;
            case 42:
              ComponentMetadataItemHeaderImportSaveActions.FHpqg1d6f0232ZtOjjK((object) reader);
              num2 = 51;
              continue;
            case 43:
            case 62:
              if (!this.componentMetadataItemHeaderManager.ValidateDisplayName(result1, str, out errorMessage))
              {
                num2 = 4;
                continue;
              }
              goto case 19;
            case 44:
              ComponentMetadataItemHeaderImportSaveActions.ljNQKydHBMpXxvELvYG((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 29 : 14;
              continue;
            case 46:
              Guid.TryParse(reader.ReadString(), out result1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 49 : 59;
              continue;
            case 47:
              result1 = Guid.Empty;
              num2 = 41;
              continue;
            case 48:
              if (ComponentMetadataItemHeaderImportSaveActions.VpAX7bdx8DFq476gF7E(ComponentMetadataItemHeaderImportSaveActions.CuFidsd7FcbhWixlLDm((object) reader), (object) ComponentMetadataItemHeaderManager._Resources_PropertyNames.DisplayName))
              {
                num2 = 22;
                continue;
              }
              goto case 32;
            case 49:
              if (ComponentMetadataItemHeaderImportSaveActions.aCVNpQddKeTW63E7lw4((object) this.featureFlagService, ComponentMetadataItemHeaderImportSaveActions.SR4Dn5d9IkNOKEYC9my(1113862659 ^ 1113889801), false))
              {
                if (ComponentMetadataItemHeaderImportSaveActions.D1Gbsndl7ddSXxhlkWN(result1, Guid.Empty))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 33 : 20;
                  continue;
                }
                if (this.componentMetadataItemHeaderManager.ValidateName(result1, name, out errorMessage))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 43 : 22;
                  continue;
                }
                goto case 40;
              }
              else
                goto label_38;
            case 50:
              ComponentMetadataItemHeaderImportSaveActions.FHpqg1d6f0232ZtOjjK((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 26 : 26;
              continue;
            case 52:
              ComponentMetadataItemHeaderImportSaveActions.ljNQKydHBMpXxvELvYG((object) reader);
              num2 = 10;
              continue;
            case 56:
              ComponentMetadataItemHeaderImportSaveActions.ljNQKydHBMpXxvELvYG((object) reader);
              num2 = 14;
              continue;
            case 57:
              goto label_77;
            case 59:
              reader.Read();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 21 : 5;
              continue;
            case 60:
              ComponentMetadataItemHeaderImportSaveActions.ljNQKydHBMpXxvELvYG((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 4 : 5;
              continue;
            case 63:
              if (ComponentMetadataItemHeaderImportSaveActions.D1Gbsndl7ddSXxhlkWN(result2, PageComponentMetadata.TypeUid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 9 : 5;
                continue;
              }
              goto case 36;
            case 64:
              if (!reader.IsEmptyElement)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 16 : 44;
                continue;
              }
              goto case 21;
            case 65:
              goto label_43;
            case 66:
              reader = data.Reader;
              num2 = 65;
              continue;
            default:
              if (!ComponentMetadataItemHeaderImportSaveActions.kTaFQ1d0Wc0t3ZRb0lw((object) reader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 60 : 51;
                continue;
              }
              goto case 12;
          }
        }
label_18:
        num1 = 49;
        continue;
label_38:
        num1 = 38;
        continue;
label_43:
        ComponentMetadataItemHeaderImportSaveActions.FHpqg1d6f0232ZtOjjK((object) reader);
        num1 = 8;
        continue;
label_77:
        reader.Read();
        num1 = 37;
      }
label_12:
      return;
label_7:
      return;
label_76:
      return;
label_75:;
    }

    /// <inheritdoc />
    public override bool CanBeSaved(
      Dictionary<string, object> propValues,
      ImportEntityCanBeSavedData data)
    {
      if (propValues == null)
      {
        CreateDeployMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822926930)));
        return false;
      }
      string empty = string.Empty;
      object obj1;
      if (propValues.TryGetValue(ComponentMetadataItemHeaderManager._Resources_PropertyNames.Name, out obj1))
        empty = obj1.ToString();
      if (string.IsNullOrWhiteSpace(empty))
      {
        CreateDeployMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767765047)));
        return false;
      }
      Guid result = Guid.Empty;
      object obj2;
      if (propValues.TryGetValue(ComponentMetadataItemHeaderManager._Resources_PropertyNames.Uid, out obj2) && obj2 != null)
        Guid.TryParse(obj2.ToString(), out result);
      if (!(result == Guid.Empty))
        return true;
      CreateDeployMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61171491)));
      return false;

      void CreateDeployMessage(string message)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, message));
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

    /// <inheritdoc />
    public override List<TestImportMessages> ExecPreSaveActions(
      IEntity entity,
      ImportEntityPreSaveData data)
    {
      List<TestImportMessages> messages = new List<TestImportMessages>();
      if (!(entity is ComponentMetadataItemHeader metadataItemHeader))
      {
        Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113882983));
        messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979469892), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218450468)))));
        return messages;
      }
      string errorMessage;
      if (!this.componentMetadataItemHeaderManager.ValidateName(metadataItemHeader.Uid, metadataItemHeader.Name, out errorMessage))
      {
        int num = 0;
        string name;
        do
        {
          ++num;
          name = (!string.IsNullOrEmpty(metadataItemHeader.Name) ? (object) metadataItemHeader.Name : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514983327)).ToString() + (object) num;
        }
        while (!this.componentMetadataItemHeaderManager.ValidateName(metadataItemHeader.Uid, name, out errorMessage) && num < 100);
        if (num <= 100)
        {
          AddImportMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852881208), (object) metadataItemHeader.Name, (object) name));
          metadataItemHeader.Name = name;
        }
        else
          AddImportMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426115981), (object) metadataItemHeader.Name));
      }
      if (!this.componentMetadataItemHeaderManager.ValidateDisplayName(metadataItemHeader.Uid, metadataItemHeader.DisplayName, out errorMessage))
      {
        int num = 0;
        string displayName;
        do
        {
          ++num;
          displayName = (!string.IsNullOrEmpty(metadataItemHeader.DisplayName) ? (object) metadataItemHeader.DisplayName : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173645559)).ToString() + (object) num;
        }
        while (!this.componentMetadataItemHeaderManager.ValidateDisplayName(metadataItemHeader.Uid, displayName, out errorMessage) && num < 100);
        if (num <= 100)
        {
          AddImportMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317754622), (object) metadataItemHeader.DisplayName, (object) displayName));
          metadataItemHeader.DisplayName = displayName;
        }
        else
          AddImportMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217485049), (object) metadataItemHeader.Name));
      }
      return messages;

      void AddImportMessage(string message)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              messages.Add(new TestImportMessages(TestImportMessagesType.Warning, message));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
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

    static ComponentMetadataItemHeaderImportSaveActions()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ComponentMetadataItemHeaderImportSaveActions.Uid = InterfaceActivator.UID<ComponentMetadataItemHeader>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static bool wX0vN7dwHu3FxqWunuk() => ComponentMetadataItemHeaderImportSaveActions.xHAaPZdt19SM8bdIJmy == null;

    internal static ComponentMetadataItemHeaderImportSaveActions DfRnyid4qeMOMkEcaR0() => ComponentMetadataItemHeaderImportSaveActions.xHAaPZdt19SM8bdIJmy;

    internal static bool FHpqg1d6f0232ZtOjjK([In] object obj0) => ((XmlReader) obj0).Read();

    internal static bool ljNQKydHBMpXxvELvYG([In] object obj0) => ((XmlReader) obj0).MoveToElement();

    internal static bool hysUC4dAEHxn7eY9rEi([In] object obj0) => ((XmlReader) obj0).IsStartElement();

    internal static object CuFidsd7FcbhWixlLDm([In] object obj0) => (object) ((XmlReader) obj0).Name;

    internal static bool VpAX7bdx8DFq476gF7E([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool kTaFQ1d0Wc0t3ZRb0lw([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static object ENaoYqdmoVb0IpgBn72([In] object obj0) => (object) ((XmlReader) obj0).ReadString();

    internal static void tQFOVudyMOrHtsbR5Wt([In] object obj0) => ((XmlReader) obj0).Skip();

    internal static XmlNodeType VMeIbidM17CNxhilK4i([In] object obj0) => ((XmlReader) obj0).MoveToContent();

    internal static XmlNodeType dJkcSrdJ6yeta6qwM85([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static object SR4Dn5d9IkNOKEYC9my(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool aCVNpQddKeTW63E7lw4([In] object obj0, [In] object obj1, bool defaultEnabled) => ((IFeatureFlagService) obj0).Enabled((string) obj1, defaultEnabled);

    internal static bool D1Gbsndl7ddSXxhlkWN([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object FZV5oxdrcHBdLvNwRv4([In] object obj0) => (object) ((ImportTestReadData) obj0).ConfigImportSettings;

    internal static object OfQWFTdgCuEc8oRCXQ7([In] object obj0) => (object) ((IConfigImportSettings) obj0).FakeManifest;
  }
}
