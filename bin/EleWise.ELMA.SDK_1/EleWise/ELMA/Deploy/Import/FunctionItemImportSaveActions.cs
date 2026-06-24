// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.FunctionItemImportSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>
  /// Действия, выполняемые при сохранении сущности <see cref="T:EleWise.ELMA.Model.Metadata.FunctionMetadataItem" />
  /// </summary>
  internal sealed class FunctionItemImportSaveActions : EntityImportSaveActions
  {
    private static readonly Guid Uid;
    private readonly FunctionMetadataItemHeaderManager headerManager;
    private readonly IFeatureFlagService featureFlagService;
    private static FunctionItemImportSaveActions cF1FPWE0PCBwq475OV9M;

    /// <summary>Ctor</summary>
    /// <param name="headerManager">Менеджер заголовков метаданных функций</param>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    public FunctionItemImportSaveActions(
      FunctionMetadataItemHeaderManager headerManager,
      IFeatureFlagService featureFlagService)
    {
      FunctionItemImportSaveActions.utSKOKE03ia0kk5jUj6D();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
        num = 0;
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    public override bool IsSupported(Guid typeGuid) => FunctionItemImportSaveActions.OjUThPE0p8SgtYUHpGyb(typeGuid, FunctionItemImportSaveActions.Uid);

    /// <inheritdoc />
    public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
    {
      int num1 = 18;
      Guid result1;
      string xml;
      while (true)
      {
        int num2 = num1;
        XmlReader xmlReader;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (FunctionItemImportSaveActions.xHdCmYE0yl0GkUhd7KOv((object) this.featureFlagService, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132954933), false))
              {
                num2 = 24;
                continue;
              }
              goto case 28;
            case 2:
              goto label_5;
            case 3:
              goto label_37;
            case 4:
            case 25:
              if (!FunctionItemImportSaveActions.SRNXuxE0HhpMuyFjJes2((object) xmlReader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 9;
                continue;
              }
              goto default;
            case 5:
            case 19:
              if (FunctionItemImportSaveActions.zNS8jSE0meppR7KXY7CV((object) xmlReader) == XmlNodeType.EndElement)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 0;
                continue;
              }
              goto case 8;
            case 6:
              FunctionItemImportSaveActions.IGFcopE0DF0ioxidA9d1((object) xmlReader);
              num2 = 10;
              continue;
            case 7:
              if (string.IsNullOrWhiteSpace(xml))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 2 : 2;
                continue;
              }
              goto label_12;
            case 8:
              if (xmlReader.IsStartElement())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 26 : 25;
                continue;
              }
              goto case 4;
            case 9:
            case 11:
            case 14:
            case 35:
              FunctionItemImportSaveActions.r2SXZKE00vUcdt2lkuiX((object) xmlReader);
              num2 = 12;
              continue;
            case 10:
              xml = (string) FunctionItemImportSaveActions.I8ei1wE0x0K5qQ4krElx((object) xmlReader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 23 : 18;
              continue;
            case 12:
              int content = (int) xmlReader.MoveToContent();
              num2 = 5;
              continue;
            case 13:
              goto label_9;
            case 15:
              goto label_12;
            case 16:
              goto label_50;
            case 17:
              xmlReader.Read();
              num2 = 31;
              continue;
            case 18:
              xmlReader = (XmlReader) FunctionItemImportSaveActions.GAAQI6E0agInUsIMQNba((object) data);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 7 : 17;
              continue;
            case 20:
              if (FunctionItemImportSaveActions.DPVNhKE0AWhOBN61f6PP((object) xmlReader))
                goto case 9;
              else
                goto label_31;
            case 21:
              goto label_39;
            case 22:
              Guid.TryParse(xmlReader.ReadString(), out result1);
              num2 = 29;
              continue;
            case 23:
              FunctionItemImportSaveActions.sxW2TGE06FRFAs6EHNDM((object) xmlReader);
              num2 = 11;
              continue;
            case 24:
              if (FunctionItemImportSaveActions.YS8pSOE0MZkCueVx08br(result1, Guid.Empty))
              {
                num2 = 7;
                continue;
              }
              goto label_59;
            case 26:
              if (!FunctionItemImportSaveActions.C9TN5yE04EOXl3t2OAZ9(FunctionItemImportSaveActions.chShcEE0tT6HoFlrA7nB((object) xmlReader), FunctionItemImportSaveActions.EBKRrFE0wDqG9o0kFpvm(-70007027 ^ -70028865)))
                goto case 4;
              else
                goto label_34;
            case 27:
              goto label_38;
            case 28:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) FunctionItemImportSaveActions.EBKRrFE0wDqG9o0kFpvm(-643786247 ^ -643548781), (object) result1)));
              num2 = 32;
              continue;
            case 29:
              FunctionItemImportSaveActions.sxW2TGE06FRFAs6EHNDM((object) xmlReader);
              num2 = 14;
              continue;
            case 30:
              goto label_36;
            case 31:
              FunctionItemImportSaveActions.IGFcopE0DF0ioxidA9d1((object) xmlReader);
              num2 = 27;
              continue;
            case 32:
              goto label_62;
            case 33:
              result1 = Guid.Empty;
              num2 = 19;
              continue;
            case 34:
              if (xmlReader.IsEmptyElement)
              {
                num2 = 25;
                continue;
              }
              goto label_37;
            case 36:
              xml = "";
              num2 = 33;
              continue;
            case 37:
              if (FunctionItemImportSaveActions.sdihShE07DobLyouWLtm((object) xmlReader, FunctionItemImportSaveActions.EBKRrFE0wDqG9o0kFpvm(-1146510045 ^ -1146547211)) == null)
                goto case 9;
              else
                goto label_57;
            default:
              if (!FunctionItemImportSaveActions.C9TN5yE04EOXl3t2OAZ9(FunctionItemImportSaveActions.chShcEE0tT6HoFlrA7nB((object) xmlReader), FunctionItemImportSaveActions.EBKRrFE0wDqG9o0kFpvm(712480695 ^ 712450421)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 25 : 35;
                continue;
              }
              goto case 20;
          }
        }
label_9:
        FunctionItemImportSaveActions.sxW2TGE06FRFAs6EHNDM((object) xmlReader);
        num1 = 6;
        continue;
label_12:
        xml = (string) FunctionItemImportSaveActions.QNpZGKE093Q4gKrEWiQd((object) xml, 0, FunctionItemImportSaveActions.Ymcn4xE0JYrxGmkA4IXd((object) xml, FunctionItemImportSaveActions.EBKRrFE0wDqG9o0kFpvm(-867826612 ^ -867808374)));
        num1 = 21;
        continue;
label_31:
        num1 = 37;
        continue;
label_34:
        num1 = 34;
        continue;
label_36:
        FunctionItemImportSaveActions.IGFcopE0DF0ioxidA9d1((object) xmlReader);
        num1 = 36;
        continue;
label_37:
        FunctionItemImportSaveActions.IGFcopE0DF0ioxidA9d1((object) xmlReader);
        num1 = 22;
        continue;
label_38:
        xmlReader.Read();
        num1 = 30;
        continue;
label_57:
        num1 = 13;
      }
label_5:
      return;
label_50:
      return;
label_62:
      return;
label_59:
      return;
label_39:
      try
      {
        // ISSUE: type reference
        FunctionMetadata functionMetadata = ClassSerializationHelper.DeserializeObjectByXml(FunctionItemImportSaveActions.VOvvL0E0dlx7m3K7ua6T(__typeref (FunctionMetadata)), xml) as FunctionMetadata;
        int num3 = 5;
        string errorMessage1;
        string errorMessage2;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_55;
            case 1:
            case 2:
              if (this.headerManager.ValidateDisplayName(result1, (string) FunctionItemImportSaveActions.sbFSUDE0raCqXbDeTp5j((object) functionMetadata), out errorMessage1))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 3:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) FunctionItemImportSaveActions.EBKRrFE0wDqG9o0kFpvm(-1445902765 ^ -1980277732 ^ 539148251), (object) result1, (object) errorMessage2)));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 1;
              continue;
            case 4:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) FunctionItemImportSaveActions.EBKRrFE0wDqG9o0kFpvm(1051276242 - 990076387 ^ 60911739), (object) result1, (object) errorMessage1)));
              num3 = 6;
              continue;
            case 5:
              if (this.headerManager.ValidateName(result1, (string) FunctionItemImportSaveActions.im0O1SE0lPYPMKMeUpdI((object) functionMetadata), out errorMessage2))
              {
                num3 = 2;
                continue;
              }
              goto case 3;
            case 6:
              goto label_54;
            default:
              goto label_53;
          }
        }
label_55:
        return;
label_54:
        return;
label_53:;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_52;
            default:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) FunctionItemImportSaveActions.EBKRrFE0wDqG9o0kFpvm(1033719030 - 2012070891 ^ -978637583), (object) result1)));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
              continue;
          }
        }
label_52:;
      }
    }

    /// <inheritdoc />
    public override List<TestImportMessages> ExecPreSaveActions(
      IEntity entity,
      ImportEntityPreSaveData data)
    {
      if (!(entity is FunctionMetadataItem functionMetadataItem))
      {
        Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35756111));
        return new List<TestImportMessages>()
        {
          CreateErrorMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -69736250)))
        };
      }
      if (functionMetadataItem.Header == null)
      {
        Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283163129));
        return new List<TestImportMessages>()
        {
          CreateErrorMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234062748)))
        };
      }
      if (!(functionMetadataItem.Metadata is FunctionMetadata metadata))
      {
        Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281556212));
        return new List<TestImportMessages>()
        {
          CreateErrorMessage(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413326965)))
        };
      }
      metadata.Name = functionMetadataItem.Header.Name;
      metadata.DisplayName = functionMetadataItem.Header.DisplayName;
      return new List<TestImportMessages>();

      static TestImportMessages CreateErrorMessage(string error) => new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) FunctionItemImportSaveActions.EBKRrFE0wDqG9o0kFpvm(-1852837372 ^ -1853138258), (object) error));
    }

    /// <inheritdoc />
    public override void ExecPostSaveActions(
      IEntity entity,
      Type type,
      Dictionary<string, object> values,
      Dictionary<string, string> serviceData,
      LinksDictionary links)
    {
      serviceData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333758166)] = string.Empty;
      base.ExecPostSaveActions(entity, type, values, serviceData, links);
    }

    static FunctionItemImportSaveActions()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            FunctionItemImportSaveActions.utSKOKE03ia0kk5jUj6D();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            FunctionItemImportSaveActions.Uid = InterfaceActivator.UID<FunctionMetadataItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void utSKOKE03ia0kk5jUj6D() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool f2r1dgE01Eyu28osPrqc() => FunctionItemImportSaveActions.cF1FPWE0PCBwq475OV9M == null;

    internal static FunctionItemImportSaveActions nn5B1SE0NCahYMCH8Nv0() => FunctionItemImportSaveActions.cF1FPWE0PCBwq475OV9M;

    internal static bool OjUThPE0p8SgtYUHpGyb([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object GAAQI6E0agInUsIMQNba([In] object obj0) => (object) ((ImportTestReadData) obj0).Reader;

    internal static bool IGFcopE0DF0ioxidA9d1([In] object obj0) => ((XmlReader) obj0).MoveToElement();

    internal static object chShcEE0tT6HoFlrA7nB([In] object obj0) => (object) ((XmlReader) obj0).Name;

    internal static object EBKRrFE0wDqG9o0kFpvm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool C9TN5yE04EOXl3t2OAZ9([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool sxW2TGE06FRFAs6EHNDM([In] object obj0) => ((XmlReader) obj0).Read();

    internal static bool SRNXuxE0HhpMuyFjJes2([In] object obj0) => ((XmlReader) obj0).IsStartElement();

    internal static bool DPVNhKE0AWhOBN61f6PP([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static object sdihShE07DobLyouWLtm([In] object obj0, [In] object obj1) => (object) ((XmlReader) obj0).GetAttribute((string) obj1);

    internal static object I8ei1wE0x0K5qQ4krElx([In] object obj0) => (object) ((XmlReader) obj0).Value;

    internal static void r2SXZKE00vUcdt2lkuiX([In] object obj0) => ((XmlReader) obj0).Skip();

    internal static XmlNodeType zNS8jSE0meppR7KXY7CV([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static bool xHdCmYE0yl0GkUhd7KOv([In] object obj0, [In] object obj1, bool defaultEnabled) => ((IFeatureFlagService) obj0).Enabled((string) obj1, defaultEnabled);

    internal static bool YS8pSOE0MZkCueVx08br([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static int Ymcn4xE0JYrxGmkA4IXd([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

    internal static object QNpZGKE093Q4gKrEWiQd([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Remove(obj1, obj2);

    internal static Type VOvvL0E0dlx7m3K7ua6T([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object im0O1SE0lPYPMKMeUpdI([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object sbFSUDE0raCqXbDeTp5j([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;
  }
}
