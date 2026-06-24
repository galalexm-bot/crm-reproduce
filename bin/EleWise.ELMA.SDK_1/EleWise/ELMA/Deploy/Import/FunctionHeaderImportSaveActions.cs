// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.FunctionHeaderImportSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>
  /// Действия, выполняемые при сохранении сущности <see cref="T:EleWise.ELMA.Model.Metadata.FunctionMetadataItemHeader" />
  /// </summary>
  internal sealed class FunctionHeaderImportSaveActions : EntityImportSaveActions
  {
    private readonly IFunctionMetadataItemHeaderManager headerManager;
    private readonly IFunctionMetadataItemManager itemManager;
    private readonly IFeatureFlagService featureFlagService;
    private static readonly Guid Uid;
    internal static FunctionHeaderImportSaveActions kTdM6WE080aGuSGVZLC5;

    /// <summary>Ctor</summary>
    /// <param name="headerManager">Менеджер заголовка метаданных функций</param>
    /// <param name="itemManager">Менеджер метаданных функций</param>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    public FunctionHeaderImportSaveActions(
      IFunctionMetadataItemHeaderManager headerManager,
      IFunctionMetadataItemManager itemManager,
      IFeatureFlagService featureFlagService)
    {
      FunctionHeaderImportSaveActions.vFvkbPE0Irs1CxtRkCWo();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.itemManager = itemManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 2 : 2;
            continue;
          case 2:
            this.featureFlagService = featureFlagService;
            num = 3;
            continue;
          case 3:
            goto label_3;
          default:
            this.headerManager = headerManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override bool IsSupported(Guid typeGuid) => typeGuid == FunctionHeaderImportSaveActions.Uid;

    /// <inheritdoc />
    public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
    {
      int num1 = 30;
      while (true)
      {
        int num2 = num1;
        XmlReader reader;
        Guid result1;
        string str;
        string name;
        string errorMessage;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 45:
              if (this.headerManager.ValidateDisplayName(result1, str, out errorMessage))
              {
                num2 = 31;
                continue;
              }
              goto label_44;
            case 3:
              if (FunctionHeaderImportSaveActions.MbZBTdE0k6mFfcNSFZdm((object) this.featureFlagService, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867784122), false))
              {
                if (!FunctionHeaderImportSaveActions.GypEuRE0OjK1HXoD5OTE(result1, Guid.Empty))
                {
                  num2 = 36;
                  continue;
                }
                goto case 35;
              }
              else
                goto label_47;
            case 4:
              goto label_41;
            case 6:
              if (!FunctionHeaderImportSaveActions.FrS85YE0X2b0xW5JRkIZ((object) reader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 24 : 24;
                continue;
              }
              goto case 12;
            case 7:
              ((BPMAppFakeManifest) FunctionHeaderImportSaveActions.IaYVJIE0etSyS4tAp4BX((object) data.ConfigImportSettings)).GetOrCreateChapterByUid(FunctionExportConsts.ExportExtensionUid).GetOrCreateItemByUid(result1, str);
              num2 = 40;
              continue;
            case 8:
              FunctionHeaderImportSaveActions.hJKkZIE0VBc5Rtk0lt7N((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 22 : 26;
              continue;
            case 9:
              goto label_44;
            case 10:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) FunctionHeaderImportSaveActions.ddymVfE0nC1CD9eYuDAg(-710283084 ^ -537863435 ^ 173902379), (object) str)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 34 : 14;
              continue;
            case 11:
              FunctionHeaderImportSaveActions.stsDk2E0SeE6UCbfhQGH((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 19 : 38;
              continue;
            case 12:
            case 16:
            case 26:
            case 32:
            case 49:
              reader.Skip();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 4;
              continue;
            case 13:
              if (!((string) FunctionHeaderImportSaveActions.wbC3vxE0R8J7RB9P2pb9((object) reader) == FunctionMetadataItemHeaderManager._Resources_PropertyNames.DisplayName))
              {
                num2 = 32;
                continue;
              }
              goto case 6;
            case 14:
              FunctionHeaderImportSaveActions.stsDk2E0SeE6UCbfhQGH((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 43 : 15;
              continue;
            case 17:
            case 20:
            case 33:
            case 53:
              if (!FunctionHeaderImportSaveActions.v06mQuE0ikRqGy4UykO6((object) reader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                continue;
              }
              goto case 44;
            case 18:
              FunctionHeaderImportSaveActions.stsDk2E0SeE6UCbfhQGH((object) reader);
              num2 = 48;
              continue;
            case 19:
              if (reader.IsEmptyElement)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 30 : 33;
                continue;
              }
              goto case 21;
            case 21:
              reader.MoveToElement();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 22 : 22;
              continue;
            case 22:
              Guid.TryParse((string) FunctionHeaderImportSaveActions.anYQfPE0K89b2JAFfeZ9((object) reader), out result1);
              num2 = 27;
              continue;
            case 23:
            case 28:
              if (FunctionHeaderImportSaveActions.zaQ6KwE0T80dwBGa4q8g((object) reader) == XmlNodeType.EndElement)
              {
                num2 = 3;
                continue;
              }
              goto case 37;
            case 24:
              reader.MoveToElement();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 38 : 39;
              continue;
            case 25:
            case 31:
              if (FunctionHeaderImportSaveActions.srIlhNE023tZ6OWHZXgc(result1, Guid.Empty))
              {
                num2 = 7;
                continue;
              }
              goto label_57;
            case 27:
              reader.Read();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 12 : 11;
              continue;
            case 29:
              FunctionHeaderImportSaveActions.hJKkZIE0VBc5Rtk0lt7N((object) reader);
              num2 = 11;
              continue;
            case 30:
              reader = data.Reader;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 29 : 13;
              continue;
            case 34:
              goto label_60;
            case 35:
              FunctionHeaderImportSaveActions.AddTestImportMessage(result.Messages, (object) EleWise.ELMA.SR.T((string) FunctionHeaderImportSaveActions.ddymVfE0nC1CD9eYuDAg(~-306453669 ^ 306232772), (object) name));
              num2 = 52;
              continue;
            case 36:
              if (this.headerManager.ValidateName(result1, name, out errorMessage))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 1;
                continue;
              }
              goto case 51;
            case 37:
              if (!FunctionHeaderImportSaveActions.v06mQuE0ikRqGy4UykO6((object) reader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 10 : 17;
                continue;
              }
              goto case 47;
            case 38:
              FunctionHeaderImportSaveActions.hJKkZIE0VBc5Rtk0lt7N((object) reader);
              num2 = 18;
              continue;
            case 39:
              str = (string) FunctionHeaderImportSaveActions.anYQfPE0K89b2JAFfeZ9((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 8;
              continue;
            case 40:
              goto label_15;
            case 41:
              result1 = Guid.Empty;
              num2 = 23;
              continue;
            case 42:
              str = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 5 : 41;
              continue;
            case 43:
              name = (string) FunctionHeaderImportSaveActions.anYQfPE0K89b2JAFfeZ9((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 23 : 50;
              continue;
            case 44:
              if (!FunctionHeaderImportSaveActions.wOJmvME0qPVCxVXRwZj4(FunctionHeaderImportSaveActions.wbC3vxE0R8J7RB9P2pb9((object) reader), (object) FunctionMetadataItemHeaderManager._Resources_PropertyNames.Name))
              {
                num2 = 5;
                continue;
              }
              goto case 46;
            case 46:
              if (FunctionHeaderImportSaveActions.FrS85YE0X2b0xW5JRkIZ((object) reader))
              {
                num2 = 2;
                continue;
              }
              goto case 14;
            case 47:
              if (!FunctionHeaderImportSaveActions.wOJmvME0qPVCxVXRwZj4(FunctionHeaderImportSaveActions.wbC3vxE0R8J7RB9P2pb9((object) reader), (object) FunctionMetadataItemHeaderManager._Resources_PropertyNames.Uid))
              {
                num2 = 53;
                continue;
              }
              goto case 19;
            case 48:
              name = (string) null;
              num2 = 42;
              continue;
            case 50:
              reader.Read();
              num2 = 16;
              continue;
            case 51:
              FunctionHeaderImportSaveActions.AddTestImportMessage(result.Messages, (object) EleWise.ELMA.SR.T((string) FunctionHeaderImportSaveActions.ddymVfE0nC1CD9eYuDAg(1304605005 ^ 1304826699), (object) name, (object) errorMessage));
              num2 = 45;
              continue;
            case 52:
              goto label_29;
            default:
              if (!FunctionHeaderImportSaveActions.v06mQuE0ikRqGy4UykO6((object) reader))
              {
                num2 = 49;
                continue;
              }
              goto case 13;
          }
        }
label_41:
        int content = (int) reader.MoveToContent();
        num1 = 28;
        continue;
label_44:
        FunctionHeaderImportSaveActions.AddTestImportMessage(result.Messages, (object) EleWise.ELMA.SR.T((string) FunctionHeaderImportSaveActions.ddymVfE0nC1CD9eYuDAg(-1487388570 ^ -1487343304), (object) str, (object) errorMessage));
        num1 = 25;
        continue;
label_47:
        num1 = 10;
      }
label_60:
      return;
label_15:
      return;
label_29:
      return;
label_57:;
    }

    /// <inheritdoc />
    public override bool CanBeSaved(
      Dictionary<string, object> propValues,
      ImportEntityCanBeSavedData data)
    {
      if (propValues == null)
      {
        AddDeployMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669342301)));
        return false;
      }
      object obj1;
      if (propValues.TryGetValue(FunctionMetadataItemHeaderManager._Resources_PropertyNames.Name, out obj1) && string.IsNullOrEmpty(obj1.ToString()))
      {
        AddDeployMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112747868)));
        return false;
      }
      Guid result = Guid.Empty;
      object obj2;
      if (propValues.TryGetValue(FunctionMetadataItemHeaderManager._Resources_PropertyNames.Uid, out obj2))
        Guid.TryParse(obj2.ToString(), out result);
      if (!(result == Guid.Empty))
        return true;
      AddDeployMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012107827)));
      return false;

      void AddDeployMessage(string message)
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
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
      if (!(entity is FunctionMetadataItemHeader metadataItemHeader))
      {
        Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2120939643));
        return new List<TestImportMessages>()
        {
          new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858665819), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418661374))))
        };
      }
      List<TestImportMessages> messages = new List<TestImportMessages>();
      string errorMessage;
      if (!this.headerManager.ValidateName(metadataItemHeader.Uid, metadataItemHeader.Name, out errorMessage))
      {
        int num = 0;
        string name = !string.IsNullOrEmpty(metadataItemHeader.Name) ? metadataItemHeader.Name : z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218658552);
        do
        {
          ++num;
          name += (string) (object) num;
        }
        while (!this.headerManager.ValidateName(metadataItemHeader.Uid, name, out errorMessage) && num < 100);
        if (num <= 100)
        {
          messages.Add(new TestImportMessages(TestImportMessagesType.Warning, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675792263), (object) metadataItemHeader.Name, (object) name)));
          ((NamedMetadata) metadataItemHeader.Draft.Metadata).Name = name;
          string sourceCode = this.itemManager.GenerateCode(new GenerateFunctionCodeRequest()
          {
            OldName = metadataItemHeader.Name,
            GenerateName = true
          }).SourceCode;
          metadataItemHeader.Draft.ScriptModule.SourceCode = sourceCode;
        }
        else
          FunctionHeaderImportSaveActions.AddTestImportMessage(messages, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082096934), (object) metadataItemHeader.Name));
      }
      if (!this.headerManager.ValidateDisplayName(metadataItemHeader.Uid, metadataItemHeader.DisplayName, out errorMessage))
      {
        int num = 0;
        string displayName = !string.IsNullOrEmpty(metadataItemHeader.DisplayName) ? metadataItemHeader.DisplayName : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35757471);
        do
        {
          ++num;
          displayName += (string) (object) num;
        }
        while (!this.headerManager.ValidateDisplayName(metadataItemHeader.Uid, displayName, out errorMessage) && num < 100);
        if (num <= 100)
        {
          FunctionHeaderImportSaveActions.AddTestImportMessage(messages, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998318598), (object) metadataItemHeader.DisplayName, (object) displayName));
          metadataItemHeader.DisplayName = displayName;
        }
        else
          FunctionHeaderImportSaveActions.AddTestImportMessage(messages, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917036460), (object) metadataItemHeader.Name));
      }
      return messages;
    }

    private static void AddTestImportMessage(List<TestImportMessages> messages, object message) => messages.Add(new TestImportMessages(TestImportMessagesType.Warning, (string) message));

    static FunctionHeaderImportSaveActions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FunctionHeaderImportSaveActions.Uid = InterfaceActivator.UID<FunctionMetadataItemHeader>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
            continue;
          case 2:
            FunctionHeaderImportSaveActions.vFvkbPE0Irs1CxtRkCWo();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void vFvkbPE0Irs1CxtRkCWo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool TZbogRE0ZW1Q8rhZ0CpU() => FunctionHeaderImportSaveActions.kTdM6WE080aGuSGVZLC5 == null;

    internal static FunctionHeaderImportSaveActions Ykb8MNE0uoymd8m8apiN() => FunctionHeaderImportSaveActions.kTdM6WE080aGuSGVZLC5;

    internal static bool hJKkZIE0VBc5Rtk0lt7N([In] object obj0) => ((XmlReader) obj0).Read();

    internal static bool stsDk2E0SeE6UCbfhQGH([In] object obj0) => ((XmlReader) obj0).MoveToElement();

    internal static bool v06mQuE0ikRqGy4UykO6([In] object obj0) => ((XmlReader) obj0).IsStartElement();

    internal static object wbC3vxE0R8J7RB9P2pb9([In] object obj0) => (object) ((XmlReader) obj0).Name;

    internal static bool wOJmvME0qPVCxVXRwZj4([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object anYQfPE0K89b2JAFfeZ9([In] object obj0) => (object) ((XmlReader) obj0).ReadString();

    internal static bool FrS85YE0X2b0xW5JRkIZ([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static XmlNodeType zaQ6KwE0T80dwBGa4q8g([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static bool MbZBTdE0k6mFfcNSFZdm([In] object obj0, [In] object obj1, bool defaultEnabled) => ((IFeatureFlagService) obj0).Enabled((string) obj1, defaultEnabled);

    internal static object ddymVfE0nC1CD9eYuDAg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool GypEuRE0OjK1HXoD5OTE([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool srIlhNE023tZ6OWHZXgc([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object IaYVJIE0etSyS4tAp4BX([In] object obj0) => (object) ((IConfigImportSettings) obj0).FakeManifest;
  }
}
