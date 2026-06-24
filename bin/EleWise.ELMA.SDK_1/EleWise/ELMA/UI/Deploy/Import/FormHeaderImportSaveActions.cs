// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Deploy.Import.FormHeaderImportSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;
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
  /// <summary>Действия для импорта заголовка формы</summary>
  public class FormHeaderImportSaveActions : EntityImportSaveActions
  {
    public static readonly Guid UID;
    internal static FormHeaderImportSaveActions lYPG7dlTD8vER6Qg4dX;

    public override bool IsSupported(Guid typeGuid) => FormHeaderImportSaveActions.flQp1MlO1lxZC7E5txs(typeGuid, FormHeaderImportSaveActions.UID);

    public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
    {
      int num1 = 62;
      while (true)
      {
        int num2 = num1;
        XmlReader xmlReader;
        Guid result1;
        FormMetadataItemHeaderManager serviceNotNull;
        Guid result2;
        string str;
        string errorMessage;
        string name;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!((string) FormHeaderImportSaveActions.f5V90nlN3nRo5H7Z6b6((object) xmlReader) == FormMetadataItemHeaderManager.PropertyNames.MetadataType))
              {
                num2 = 49;
                continue;
              }
              goto default;
            case 2:
            case 26:
            case 30:
            case 36:
            case 59:
            case 64:
              FormHeaderImportSaveActions.W8ODYulDJ5rp2ce57gO((object) xmlReader);
              num2 = 28;
              continue;
            case 3:
              FormHeaderImportSaveActions.ViZ2GSle4SZK4O4rG3s((object) xmlReader);
              num2 = 36;
              continue;
            case 4:
              goto label_56;
            case 5:
              if (xmlReader.IsEmptyElement)
              {
                num2 = 8;
                continue;
              }
              goto case 39;
            case 6:
              if (!FormHeaderImportSaveActions.ttA7t3lp2HlwYwZvfRw((object) xmlReader))
              {
                num2 = 19;
                continue;
              }
              goto case 2;
            case 7:
            case 38:
              if (!FormHeaderImportSaveActions.flQp1MlO1lxZC7E5txs(result2, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 25 : 35;
                continue;
              }
              goto case 20;
            case 8:
            case 10:
            case 25:
            case 57:
              if (FormHeaderImportSaveActions.St3I82l1htgWeiixhg3((object) xmlReader))
                goto case 52;
              else
                goto label_4;
            case 9:
              ((BPMAppFakeManifest) FormHeaderImportSaveActions.aQqDvOl635KXuJQpCaV(FormHeaderImportSaveActions.BSohMTlwHYsgQDtaG8n((object) data))).GetOrCreateChapterByUid(UIFormExportConsts.ExportExtensionUidPortlet).GetOrCreateItemByUid(result2, str);
              num2 = 38;
              continue;
            case 11:
              goto label_72;
            case 12:
            case 23:
            case 49:
              if (!FormHeaderImportSaveActions.St3I82l1htgWeiixhg3((object) xmlReader))
              {
                num2 = 10;
                continue;
              }
              goto case 27;
            case 13:
              if (!FormHeaderImportSaveActions.ttA7t3lp2HlwYwZvfRw((object) xmlReader))
              {
                num2 = 56;
                continue;
              }
              goto case 31;
            case 14:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Warning, EleWise.ELMA.SR.T((string) FormHeaderImportSaveActions.nMcFaZlHXqnYRocCvtM(1012087039 ^ 1012107511), (object) name, (object) errorMessage)));
              num2 = 43;
              continue;
            case 15:
              goto label_52;
            case 16:
              if (FormHeaderImportSaveActions.WePJbnl4HkkVkTHF5eZ(result2, new Guid()))
              {
                num2 = 37;
                continue;
              }
              goto case 7;
            case 17:
              if (FormHeaderImportSaveActions.PPjfiil3xxRgxxxFZmK(FormHeaderImportSaveActions.f5V90nlN3nRo5H7Z6b6((object) xmlReader), (object) FormMetadataItemHeaderManager.PropertyNames.Uid))
              {
                num2 = 13;
                continue;
              }
              goto case 31;
            case 18:
              FormHeaderImportSaveActions.ViZ2GSle4SZK4O4rG3s((object) xmlReader);
              num2 = 64;
              continue;
            case 19:
              FormHeaderImportSaveActions.yVDYaWlPOC4Rx9pkmRI((object) xmlReader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 41 : 0;
              continue;
            case 20:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Warning, EleWise.ELMA.SR.T((string) FormHeaderImportSaveActions.nMcFaZlHXqnYRocCvtM(-606654180 ^ -606630784), (object) name)));
              num2 = 46;
              continue;
            case 21:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Warning, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867781358), (object) str, (object) errorMessage)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 3 : 11;
              continue;
            case 22:
              FormHeaderImportSaveActions.yVDYaWlPOC4Rx9pkmRI((object) xmlReader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 14 : 33;
              continue;
            case 24:
              Guid.TryParse((string) FormHeaderImportSaveActions.rL8YculaQBor4l2pOG0((object) xmlReader), out result1);
              num2 = 3;
              continue;
            case 27:
              if (!FormHeaderImportSaveActions.PPjfiil3xxRgxxxFZmK((object) xmlReader.Name, (object) FormMetadataItemHeaderManager.PropertyNames.Name))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 25 : 3;
                continue;
              }
              goto case 5;
            case 28:
              int content = (int) xmlReader.MoveToContent();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 27 : 42;
              continue;
            case 29:
              if (!FormHeaderImportSaveActions.St3I82l1htgWeiixhg3((object) xmlReader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 5 : 31;
                continue;
              }
              goto case 17;
            case 31:
            case 40:
              if (!xmlReader.IsStartElement())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 12 : 1;
                continue;
              }
              goto case 1;
            case 32:
              name = (string) FormHeaderImportSaveActions.rL8YculaQBor4l2pOG0((object) xmlReader);
              num2 = 34;
              continue;
            case 33:
              name = (string) null;
              num2 = 58;
              continue;
            case 34:
              FormHeaderImportSaveActions.ViZ2GSle4SZK4O4rG3s((object) xmlReader);
              num2 = 26;
              continue;
            case 35:
              if (!FormHeaderImportSaveActions.flQp1MlO1lxZC7E5txs(result1, Guid.Empty))
              {
                serviceNotNull = Locator.GetServiceNotNull<FormMetadataItemHeaderManager>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 60 : 31;
                continue;
              }
              goto label_54;
            case 37:
              if (!(result1 == PageMetadata.TypeUid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 54 : 52;
                continue;
              }
              goto case 50;
            case 39:
              xmlReader.MoveToElement();
              num2 = 32;
              continue;
            case 41:
              str = xmlReader.ReadString();
              num2 = 48;
              continue;
            case 42:
            case 47:
              if (FormHeaderImportSaveActions.CgoLX4lt0cnRVwbrMKS((object) xmlReader) != XmlNodeType.EndElement)
                goto case 29;
              else
                goto label_51;
            case 43:
              if (!serviceNotNull.ValidateDisplayName(result2, result1, str, out errorMessage))
              {
                num2 = 21;
                continue;
              }
              goto label_62;
            case 44:
            case 54:
              if (FormHeaderImportSaveActions.flQp1MlO1lxZC7E5txs(result1, PortletMetadata.TypeUid))
              {
                num2 = 9;
                continue;
              }
              goto case 7;
            case 45:
              Guid.TryParse((string) FormHeaderImportSaveActions.rL8YculaQBor4l2pOG0((object) xmlReader), out result2);
              num2 = 18;
              continue;
            case 46:
              goto label_69;
            case 48:
              FormHeaderImportSaveActions.ViZ2GSle4SZK4O4rG3s((object) xmlReader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 20 : 30;
              continue;
            case 50:
              ((BPMAppFakeManifest) FormHeaderImportSaveActions.aQqDvOl635KXuJQpCaV(FormHeaderImportSaveActions.BSohMTlwHYsgQDtaG8n((object) data))).GetOrCreateChapterByUid(UIFormExportConsts.ExportExtensionUidPage).GetOrCreateItemByUid(result2, str);
              num2 = 44;
              continue;
            case 51:
              if (FormHeaderImportSaveActions.BSohMTlwHYsgQDtaG8n((object) data) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 7 : 6;
                continue;
              }
              goto case 16;
            case 52:
              if (!FormHeaderImportSaveActions.PPjfiil3xxRgxxxFZmK((object) xmlReader.Name, (object) FormMetadataItemHeaderManager.PropertyNames.DisplayName))
              {
                num2 = 59;
                continue;
              }
              goto case 6;
            case 53:
              xmlReader.MoveToElement();
              num2 = 24;
              continue;
            case 55:
              xmlReader.MoveToElement();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 4;
              continue;
            case 56:
              goto label_49;
            case 58:
              goto label_74;
            case 60:
              if (!serviceNotNull.ValidateName(result2, result1, name, out errorMessage))
              {
                num2 = 14;
                continue;
              }
              goto case 43;
            case 61:
              FormHeaderImportSaveActions.ViZ2GSle4SZK4O4rG3s((object) xmlReader);
              num2 = 55;
              continue;
            case 62:
              xmlReader = (XmlReader) FormHeaderImportSaveActions.NBPB9El28BMBLFYjO4t((object) data);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 48 : 61;
              continue;
            case 63:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Warning, EleWise.ELMA.SR.T((string) FormHeaderImportSaveActions.nMcFaZlHXqnYRocCvtM(-675505729 ^ -675534971), (object) name)));
              num2 = 15;
              continue;
            case 65:
              result2 = Guid.Empty;
              num2 = 66;
              continue;
            case 66:
              result1 = Guid.Empty;
              num2 = 47;
              continue;
            default:
              if (!FormHeaderImportSaveActions.ttA7t3lp2HlwYwZvfRw((object) xmlReader))
              {
                num2 = 53;
                continue;
              }
              goto case 12;
          }
        }
label_4:
        num1 = 2;
        continue;
label_49:
        FormHeaderImportSaveActions.yVDYaWlPOC4Rx9pkmRI((object) xmlReader);
        num1 = 45;
        continue;
label_51:
        num1 = 51;
        continue;
label_54:
        num1 = 63;
        continue;
label_56:
        xmlReader.Read();
        num1 = 22;
        continue;
label_74:
        str = (string) null;
        num1 = 65;
      }
label_72:
      return;
label_52:
      return;
label_69:
      return;
label_62:;
    }

    public override bool CanBeSaved(
      Dictionary<string, object> propValues,
      ImportEntityCanBeSavedData data)
    {
      if (propValues == null)
      {
        data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852881998))));
        return false;
      }
      Locator.GetServiceNotNull<FormMetadataItemHeaderManager>();
      if (string.IsNullOrWhiteSpace(propValues.ContainsKey(FormMetadataItemHeaderManager.PropertyNames.Name) ? propValues[FormMetadataItemHeaderManager.PropertyNames.Name].ToString() : (string) null))
      {
        data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542766161))));
        return false;
      }
      Guid result1 = Guid.Empty;
      if (propValues.ContainsKey(FormMetadataItemHeaderManager.PropertyNames.Uid) && propValues[FormMetadataItemHeaderManager.PropertyNames.Uid] != null)
        Guid.TryParse(propValues[FormMetadataItemHeaderManager.PropertyNames.Uid].ToString(), out result1);
      if (result1 == Guid.Empty)
      {
        data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675533965))));
        return false;
      }
      Guid result2 = Guid.Empty;
      if (propValues.ContainsKey(FormMetadataItemHeaderManager.PropertyNames.MetadataType) && propValues[FormMetadataItemHeaderManager.PropertyNames.MetadataType] != null)
        Guid.TryParse(propValues[FormMetadataItemHeaderManager.PropertyNames.MetadataType].ToString(), out result2);
      if (!(result2 == Guid.Empty))
        return true;
      data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874045691))));
      return false;
    }

    public override List<TestImportMessages> ExecPreSaveActions(
      IEntity entity,
      ImportEntityPreSaveData data)
    {
      IFormMetadataItemHeader metadataItemHeader = entity as IFormMetadataItemHeader;
      Func<string, TestImportMessages> func = (Func<string, TestImportMessages>) (e => new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406136033), (object) e)));
      if (metadataItemHeader == null)
      {
        Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538548402));
        return new List<TestImportMessages>()
        {
          func(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77715515)))
        };
      }
      List<TestImportMessages> testImportMessagesList = new List<TestImportMessages>();
      FormMetadataItemHeaderManager serviceNotNull = Locator.GetServiceNotNull<FormMetadataItemHeaderManager>();
      string errorMessage;
      if (!serviceNotNull.ValidateName(metadataItemHeader.Uid, metadataItemHeader.MetadataType, metadataItemHeader.Name, out errorMessage))
      {
        int num = 0;
        string name;
        do
        {
          ++num;
          name = (!string.IsNullOrEmpty(metadataItemHeader.Name) ? (object) metadataItemHeader.Name : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123678310)).ToString() + (object) num;
        }
        while (!serviceNotNull.ValidateName(metadataItemHeader.Uid, metadataItemHeader.MetadataType, name, out errorMessage) && num < 100);
        if (num <= 100)
        {
          testImportMessagesList.Add(new TestImportMessages(TestImportMessagesType.Warning, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217483063), (object) metadataItemHeader.Name, (object) name)));
          metadataItemHeader.Name = name;
        }
        else
          testImportMessagesList.Add(new TestImportMessages(TestImportMessagesType.Warning, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867247631), (object) metadataItemHeader.Name)));
      }
      if (!serviceNotNull.ValidateDisplayName(metadataItemHeader.Uid, metadataItemHeader.MetadataType, metadataItemHeader.DisplayName, out errorMessage))
      {
        int num = 0;
        string displayName;
        do
        {
          ++num;
          displayName = (!string.IsNullOrEmpty(metadataItemHeader.DisplayName) ? (object) metadataItemHeader.DisplayName : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319501784)).ToString() + (object) num;
        }
        while (!serviceNotNull.ValidateDisplayName(metadataItemHeader.Uid, metadataItemHeader.MetadataType, displayName, out errorMessage) && num < 100);
        if (num <= 100)
        {
          testImportMessagesList.Add(new TestImportMessages(TestImportMessagesType.Warning, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939361170), (object) metadataItemHeader.DisplayName, (object) displayName)));
          metadataItemHeader.DisplayName = displayName;
        }
        else
          testImportMessagesList.Add(new TestImportMessages(TestImportMessagesType.Warning, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597028850), (object) metadataItemHeader.Name)));
      }
      return testImportMessagesList;
    }

    public FormHeaderImportSaveActions()
    {
      FormHeaderImportSaveActions.u90P8klAn0dcegeReYS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static FormHeaderImportSaveActions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FormHeaderImportSaveActions.UID = new Guid((string) FormHeaderImportSaveActions.nMcFaZlHXqnYRocCvtM(1917256330 ^ 1917305636));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 2:
            FormHeaderImportSaveActions.u90P8klAn0dcegeReYS();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool flQp1MlO1lxZC7E5txs([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool IcNciKlkIAVNxLasUNj() => FormHeaderImportSaveActions.lYPG7dlTD8vER6Qg4dX == null;

    internal static FormHeaderImportSaveActions N8qnwilnqvM1CAbR9HA() => FormHeaderImportSaveActions.lYPG7dlTD8vER6Qg4dX;

    internal static object NBPB9El28BMBLFYjO4t([In] object obj0) => (object) ((ImportTestReadData) obj0).Reader;

    internal static bool ViZ2GSle4SZK4O4rG3s([In] object obj0) => ((XmlReader) obj0).Read();

    internal static bool yVDYaWlPOC4Rx9pkmRI([In] object obj0) => ((XmlReader) obj0).MoveToElement();

    internal static bool St3I82l1htgWeiixhg3([In] object obj0) => ((XmlReader) obj0).IsStartElement();

    internal static object f5V90nlN3nRo5H7Z6b6([In] object obj0) => (object) ((XmlReader) obj0).Name;

    internal static bool PPjfiil3xxRgxxxFZmK([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool ttA7t3lp2HlwYwZvfRw([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static object rL8YculaQBor4l2pOG0([In] object obj0) => (object) ((XmlReader) obj0).ReadString();

    internal static void W8ODYulDJ5rp2ce57gO([In] object obj0) => ((XmlReader) obj0).Skip();

    internal static XmlNodeType CgoLX4lt0cnRVwbrMKS([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static object BSohMTlwHYsgQDtaG8n([In] object obj0) => (object) ((ImportTestReadData) obj0).ConfigImportSettings;

    internal static bool WePJbnl4HkkVkTHF5eZ([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object aQqDvOl635KXuJQpCaV([In] object obj0) => (object) ((IConfigImportSettings) obj0).FakeManifest;

    internal static object nMcFaZlHXqnYRocCvtM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void u90P8klAn0dcegeReYS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
