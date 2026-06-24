// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Deploy.Import.ComponentMetadataItemImportSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
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
  /// Действия, выполняемые при сохранении <see cref="T:EleWise.ELMA.UI.Models.ComponentMetadataItem" />
  /// </summary>
  internal sealed class ComponentMetadataItemImportSaveActions : EntityImportSaveActions
  {
    private static readonly Guid Uid;
    private readonly ComponentMetadataItemHeaderManager headerManager;
    private readonly IFeatureFlagService featureFlagService;
    internal static ComponentMetadataItemImportSaveActions xEbiMrd5ajh8prCg1YO;

    /// <summary>Ctor</summary>
    /// <param name="headerManager">Менеджер заголовков метаданных функций</param>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    public ComponentMetadataItemImportSaveActions(
      ComponentMetadataItemHeaderManager headerManager,
      IFeatureFlagService featureFlagService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.headerManager = headerManager;
            num = 2;
            continue;
          case 2:
            this.featureFlagService = featureFlagService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <inheritdoc />
    public override bool IsSupported(Guid typeGuid) => typeGuid == ComponentMetadataItemImportSaveActions.Uid;

    /// <inheritdoc />
    public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
    {
      int num1 = 30;
      string xml;
      Guid result1;
      while (true)
      {
        int num2 = num1;
        XmlReader xmlReader;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_53;
            case 1:
            case 5:
            case 9:
            case 25:
            case 34:
            case 36:
              ComponentMetadataItemImportSaveActions.rJgnQRlGVl3MT79bSue((object) xmlReader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 20 : 5;
              continue;
            case 2:
              if (ComponentMetadataItemImportSaveActions.v2pg0PlbuOQxVcVjmda((object) xmlReader, ComponentMetadataItemImportSaveActions.SmT6MolF1wofNHdPNBt(-420743386 ^ -420789776)) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 25;
                continue;
              }
              goto case 26;
            case 3:
              xml = "";
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 6 : 13;
              continue;
            case 4:
              if (ComponentMetadataItemImportSaveActions.B9QNcolBsPCoBbkk59i(ComponentMetadataItemImportSaveActions.NsDIqNdzuN9rAQk2iGk((object) xmlReader), ComponentMetadataItemImportSaveActions.SmT6MolF1wofNHdPNBt(901793403 ^ 901837001)))
              {
                num2 = 14;
                continue;
              }
              goto case 17;
            case 6:
              xml = (string) ComponentMetadataItemImportSaveActions.QVrcODlhtcrOVbRg5Gn((object) xmlReader);
              num2 = 7;
              continue;
            case 7:
              xmlReader.Read();
              num2 = 34;
              continue;
            case 8:
              Guid.TryParse((string) ComponentMetadataItemImportSaveActions.S7MTD1lorB028BcUoDC((object) xmlReader), out result1);
              num2 = 11;
              continue;
            case 10:
              ComponentMetadataItemImportSaveActions.iampsDdU0N65PeZEnKU((object) xmlReader);
              num2 = 15;
              continue;
            case 11:
              xmlReader.Read();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
              continue;
            case 12:
              if (!ComponentMetadataItemImportSaveActions.B9QNcolBsPCoBbkk59i(ComponentMetadataItemImportSaveActions.NsDIqNdzuN9rAQk2iGk((object) xmlReader), ComponentMetadataItemImportSaveActions.SmT6MolF1wofNHdPNBt(-105199646 ^ -105221856)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 9 : 6;
                continue;
              }
              goto case 24;
            case 13:
              result1 = Guid.Empty;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 23;
              continue;
            case 14:
              if (ComponentMetadataItemImportSaveActions.VeyVx5lW0O1jq58WT9S((object) xmlReader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 6 : 35;
                continue;
              }
              goto case 27;
            case 15:
              goto label_57;
            case 16:
              goto label_20;
            case 17:
            case 28:
            case 35:
              if (!xmlReader.IsStartElement())
              {
                num2 = 36;
                continue;
              }
              goto case 12;
            case 18:
              if (!ComponentMetadataItemImportSaveActions.H4rei6lvqcA963ZeMHY((object) xml))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 16;
                continue;
              }
              goto label_58;
            case 19:
              ComponentMetadataItemImportSaveActions.J2JBsrdsxHdrVhUsHGd((object) xmlReader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 6 : 10;
              continue;
            case 20:
              goto label_63;
            case 21:
              xmlReader.MoveToElement();
              num2 = 6;
              continue;
            case 22:
              goto label_68;
            case 23:
            case 37:
              if (ComponentMetadataItemImportSaveActions.PZ8n2tlf9cc5Kl2uqAI((object) xmlReader) == XmlNodeType.EndElement)
              {
                num2 = 33;
                continue;
              }
              goto case 31;
            case 24:
              if (xmlReader.IsEmptyElement)
              {
                num2 = 5;
                continue;
              }
              goto case 2;
            case 26:
              ComponentMetadataItemImportSaveActions.iampsDdU0N65PeZEnKU((object) xmlReader);
              num2 = 21;
              continue;
            case 27:
              ComponentMetadataItemImportSaveActions.J2JBsrdsxHdrVhUsHGd((object) xmlReader);
              num2 = 8;
              continue;
            case 29:
              ComponentMetadataItemImportSaveActions.iampsDdU0N65PeZEnKU((object) xmlReader);
              num2 = 19;
              continue;
            case 30:
              xmlReader = (XmlReader) ComponentMetadataItemImportSaveActions.bn1IxSdLjCxfe5B0wCY((object) data);
              num2 = 29;
              continue;
            case 31:
              if (!ComponentMetadataItemImportSaveActions.wjlDDRdcjUHUpJupPVx((object) xmlReader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 3 : 17;
                continue;
              }
              goto case 4;
            case 32:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) ComponentMetadataItemImportSaveActions.SmT6MolF1wofNHdPNBt(-97972138 ^ -97927666), (object) result1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            case 33:
              if (!ComponentMetadataItemImportSaveActions.qROCHRlQgZ1uFeFhlVX((object) this.featureFlagService, ComponentMetadataItemImportSaveActions.SmT6MolF1wofNHdPNBt(272623989 ^ 272582527), false))
              {
                num2 = 32;
                continue;
              }
              goto label_65;
            default:
              goto label_37;
          }
        }
label_57:
        ComponentMetadataItemImportSaveActions.J2JBsrdsxHdrVhUsHGd((object) xmlReader);
        num1 = 3;
        continue;
label_63:
        int num3 = (int) ComponentMetadataItemImportSaveActions.AZh5qUlEN2hlo0nblxH((object) xmlReader);
        num1 = 37;
        continue;
label_65:
        if (ComponentMetadataItemImportSaveActions.n5cc3KlC6dTng4JKLPy(result1, Guid.Empty))
          num1 = 18;
        else
          goto label_50;
      }
label_53:
      return;
label_68:
      return;
label_37:
      return;
label_20:
      try
      {
        string str = (string) ComponentMetadataItemImportSaveActions.ucFdChlZV1KMVYFOR74((object) xml, 0, ComponentMetadataItemImportSaveActions.jHHFfxl8o1XlHniewDi((object) xml, ComponentMetadataItemImportSaveActions.SmT6MolF1wofNHdPNBt(-244066886 - -48452443 ^ -195598637)));
        int num4 = 10;
        while (true)
        {
          int num5 = num4;
          string errorMessage1;
          Type type;
          ComponentMetadata componentMetadata;
          string errorMessage2;
          while (true)
          {
            switch (num5)
            {
              case 1:
                result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) ComponentMetadataItemImportSaveActions.SmT6MolF1wofNHdPNBt(~289714581 ^ -289671016), (object) result1, (object) str)));
                num5 = 9;
                continue;
              case 2:
              case 12:
                if (componentMetadata == null)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
                  continue;
                }
                goto case 4;
              case 3:
                if (this.headerManager.ValidateDisplayName(result1, (string) ComponentMetadataItemImportSaveActions.l8K6KblSJ8kYqbZV6so((object) componentMetadata), out errorMessage2))
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 8 : 1;
                  continue;
                }
                goto case 6;
              case 4:
                if (!this.headerManager.ValidateName(result1, (string) ComponentMetadataItemImportSaveActions.CRLdpKlVLGCa5aQrD0m((object) componentMetadata), out errorMessage1))
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 5 : 5;
                  continue;
                }
                goto case 3;
              case 5:
                result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) ComponentMetadataItemImportSaveActions.SmT6MolF1wofNHdPNBt(1142330761 ^ 1541959139 ^ 536760304), (object) result1, (object) errorMessage1)));
                num5 = 3;
                continue;
              case 6:
                result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) ComponentMetadataItemImportSaveActions.SmT6MolF1wofNHdPNBt(-1921202237 ^ -1921224615), (object) result1, (object) errorMessage2)));
                num5 = 14;
                continue;
              case 7:
                componentMetadata = (ComponentMetadata) null;
                num5 = 15;
                continue;
              case 8:
                goto label_48;
              case 9:
                goto label_46;
              case 10:
                goto label_24;
              case 11:
                goto label_25;
              case 13:
                goto label_27;
              case 14:
                goto label_42;
              case 15:
                if (!(type != (Type) null))
                {
                  num5 = 2;
                  continue;
                }
                goto default;
              default:
                if (typeof (ComponentMetadata).IsAssignableFrom(type))
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 4 : 13;
                  continue;
                }
                goto case 2;
            }
          }
label_24:
          type = ComponentMetadataItemImportSaveActions.xC93g8luBlA95Dh1J1R((object) str);
          num4 = 11;
          continue;
label_25:
          xml = (string) ComponentMetadataItemImportSaveActions.DfZbZxlII2lFNHsdknH((object) xml, 0, xml.IndexOf((string) ComponentMetadataItemImportSaveActions.SmT6MolF1wofNHdPNBt(-1426456882 ^ 2009939514 ^ -583758030)));
          num4 = 7;
          continue;
label_27:
          componentMetadata = ClassSerializationHelper.DeserializeObjectByXml(type, xml) as ComponentMetadata;
          num4 = 12;
        }
label_48:
        return;
label_46:
        return;
label_42:
        return;
      }
      catch (Exception ex)
      {
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
          num6 = 0;
        while (true)
        {
          switch (num6)
          {
            case 1:
              goto label_41;
            default:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538550254), (object) result1)));
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
              continue;
          }
        }
label_41:
        return;
      }
label_58:
      return;
label_50:;
    }

    /// <inheritdoc />
    public override List<TestImportMessages> ExecPreSaveActions(
      IEntity entity,
      ImportEntityPreSaveData data)
    {
      List<TestImportMessages> messages = new List<TestImportMessages>();
      if (!(entity is ComponentMetadataItem componentMetadataItem))
      {
        Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021428487));
        AddMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647948082)));
        return messages;
      }
      if (componentMetadataItem.Header == null)
      {
        Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012105669));
        AddMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195584665)));
        return messages;
      }
      if (!(componentMetadataItem.Metadata is ComponentMetadata metadata))
      {
        Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475904713));
        AddMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909134111)));
        return messages;
      }
      metadata.Name = componentMetadataItem.Header.Name;
      metadata.DisplayName = componentMetadataItem.Header.DisplayName;
      return messages;

      void AddMessage(string message)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87300211), (object) message)));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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
    public override void ExecPostSaveActions(
      IEntity entity,
      Type type,
      Dictionary<string, object> values,
      Dictionary<string, string> serviceData,
      LinksDictionary links)
    {
      serviceData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413584603)] = string.Empty;
      base.ExecPostSaveActions(entity, type, values, serviceData, links);
    }

    static ComponentMetadataItemImportSaveActions()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ComponentMetadataItemImportSaveActions.MDCo3Mli4atTkHmHSmH();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ComponentMetadataItemImportSaveActions.Uid = InterfaceActivator.UID<ComponentMetadataItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool oWVQvrdjGM4I4ietD3O() => ComponentMetadataItemImportSaveActions.xEbiMrd5ajh8prCg1YO == null;

    internal static ComponentMetadataItemImportSaveActions wrck3TdYfI7fSFkxtxS() => ComponentMetadataItemImportSaveActions.xEbiMrd5ajh8prCg1YO;

    internal static object bn1IxSdLjCxfe5B0wCY([In] object obj0) => (object) ((ImportTestReadData) obj0).Reader;

    internal static bool iampsDdU0N65PeZEnKU([In] object obj0) => ((XmlReader) obj0).Read();

    internal static bool J2JBsrdsxHdrVhUsHGd([In] object obj0) => ((XmlReader) obj0).MoveToElement();

    internal static bool wjlDDRdcjUHUpJupPVx([In] object obj0) => ((XmlReader) obj0).IsStartElement();

    internal static object NsDIqNdzuN9rAQk2iGk([In] object obj0) => (object) ((XmlReader) obj0).Name;

    internal static object SmT6MolF1wofNHdPNBt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool B9QNcolBsPCoBbkk59i([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool VeyVx5lW0O1jq58WT9S([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static object S7MTD1lorB028BcUoDC([In] object obj0) => (object) ((XmlReader) obj0).ReadString();

    internal static object v2pg0PlbuOQxVcVjmda([In] object obj0, [In] object obj1) => (object) ((XmlReader) obj0).GetAttribute((string) obj1);

    internal static object QVrcODlhtcrOVbRg5Gn([In] object obj0) => (object) ((XmlReader) obj0).Value;

    internal static void rJgnQRlGVl3MT79bSue([In] object obj0) => ((XmlReader) obj0).Skip();

    internal static XmlNodeType AZh5qUlEN2hlo0nblxH([In] object obj0) => ((XmlReader) obj0).MoveToContent();

    internal static XmlNodeType PZ8n2tlf9cc5Kl2uqAI([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static bool qROCHRlQgZ1uFeFhlVX([In] object obj0, [In] object obj1, bool defaultEnabled) => ((IFeatureFlagService) obj0).Enabled((string) obj1, defaultEnabled);

    internal static bool n5cc3KlC6dTng4JKLPy([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool H4rei6lvqcA963ZeMHY([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static int jHHFfxl8o1XlHniewDi([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

    internal static object ucFdChlZV1KMVYFOR74([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static Type xC93g8luBlA95Dh1J1R([In] object obj0) => Type.GetType((string) obj0);

    internal static object DfZbZxlII2lFNHsdknH([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Remove(obj1, obj2);

    internal static object CRLdpKlVLGCa5aQrD0m([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object l8K6KblSJ8kYqbZV6so([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void MDCo3Mli4atTkHmHSmH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
