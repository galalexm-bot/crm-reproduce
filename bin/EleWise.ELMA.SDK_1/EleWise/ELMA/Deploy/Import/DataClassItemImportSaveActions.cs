// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.DataClassItemImportSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.FeatureFlags.Services;
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
  /// Действия, выполняемые при сохранении сущности <see cref="T:EleWise.ELMA.Model.Metadata.DataClassMetadataItem" />
  /// </summary>
  internal sealed class DataClassItemImportSaveActions : EntityImportSaveActions
  {
    private static readonly Guid Uid;
    private readonly DataClassMetadataItemHeaderManager headerManager;
    private readonly IFeatureFlagService featureFlagService;
    private static DataClassItemImportSaveActions KbuFX7ExENMsZMfgfbem;

    /// <summary>Ctor</summary>
    /// <param name="headerManager">Менеджер заголовков метаданных DataClass</param>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    public DataClassItemImportSaveActions(
      DataClassMetadataItemHeaderManager headerManager,
      IFeatureFlagService featureFlagService)
    {
      DataClassItemImportSaveActions.dp6iveExCpVIYR9OlSQT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.featureFlagService = featureFlagService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
            continue;
          default:
            this.headerManager = headerManager;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override bool IsSupported(Guid typeGuid) => DataClassItemImportSaveActions.JYpItsExvsOZi3ORb5G2(typeGuid, DataClassItemImportSaveActions.Uid);

    /// <inheritdoc />
    public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
    {
      int num1 = 30;
      Guid result1;
      string xml;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          XmlReader xmlReader;
          switch (num2)
          {
            case 1:
              goto label_28;
            case 2:
              if (!DataClassItemImportSaveActions.FddSwTEx2lalgdDbeyPV((object) xml))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 19 : 11;
                continue;
              }
              goto label_57;
            case 3:
            case 20:
            case 34:
              DataClassItemImportSaveActions.qPPdZ8ExTOVq27bACBLg((object) xmlReader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 26 : 5;
              continue;
            case 4:
              DataClassItemImportSaveActions.xnuuUBExuLDmUsrMQFjq((object) xmlReader);
              num2 = 10;
              continue;
            case 5:
            case 33:
              if (DataClassItemImportSaveActions.EHGKE0ExIh1Bq9tZVkbO((object) xmlReader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 2 : 13;
                continue;
              }
              goto case 3;
            case 6:
              Guid.TryParse((string) DataClassItemImportSaveActions.fRjm7fExR0ZeXRr3jl7U((object) xmlReader), out result1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 28 : 22;
              continue;
            case 7:
              DataClassItemImportSaveActions.xk1RpVExZrAxONLbCYip((object) xmlReader);
              num2 = 32;
              continue;
            case 8:
            case 16:
              if (DataClassItemImportSaveActions.dfY2KhExn8dJZFvBTQ5n((object) xmlReader) == XmlNodeType.EndElement)
              {
                num2 = 25;
                continue;
              }
              goto case 14;
            case 9:
              if (xmlReader.IsEmptyElement)
                goto case 3;
              else
                goto label_6;
            case 10:
              DataClassItemImportSaveActions.xk1RpVExZrAxONLbCYip((object) xmlReader);
              num2 = 23;
              continue;
            case 11:
              if (!DataClassItemImportSaveActions.aFKqdyExOPxvt8p5gApO(result1, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 1;
                continue;
              }
              goto case 2;
            case 12:
              goto label_58;
            case 13:
              if (!DataClassItemImportSaveActions.Y3k9xRExSumP2uXh5v24(DataClassItemImportSaveActions.Pn4RlCExVWhHnBs149fA((object) xmlReader), DataClassItemImportSaveActions.nuqgCgExqUsLrhftbMqO(901793403 ^ 901836985)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 20 : 5;
                continue;
              }
              goto case 9;
            case 14:
              if (DataClassItemImportSaveActions.EHGKE0ExIh1Bq9tZVkbO((object) xmlReader))
              {
                num2 = 17;
                continue;
              }
              goto case 5;
            case 15:
              if (DataClassItemImportSaveActions.EF1LNYExK9BEtBXNWg30((object) xmlReader, DataClassItemImportSaveActions.nuqgCgExqUsLrhftbMqO(-2138160520 ^ -2138114898)) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 6 : 7;
                continue;
              }
              goto case 3;
            case 17:
              if (!DataClassItemImportSaveActions.Y3k9xRExSumP2uXh5v24(DataClassItemImportSaveActions.Pn4RlCExVWhHnBs149fA((object) xmlReader), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536760024)))
              {
                num2 = 33;
                continue;
              }
              goto case 22;
            case 18:
              DataClassItemImportSaveActions.xk1RpVExZrAxONLbCYip((object) xmlReader);
              num2 = 3;
              continue;
            case 19:
              xml = (string) DataClassItemImportSaveActions.of0JEHExPyewHMjHYexu((object) xml, 0, DataClassItemImportSaveActions.IUUguyExegRvCwkKQy2q((object) xml, DataClassItemImportSaveActions.nuqgCgExqUsLrhftbMqO(-643786247 ^ -643770817)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 8 : 24;
              continue;
            case 21:
              result1 = Guid.Empty;
              num2 = 8;
              continue;
            case 22:
              if (!DataClassItemImportSaveActions.CXJepaExi2eirqECV4tG((object) xmlReader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 3 : 31;
                continue;
              }
              goto case 5;
            case 23:
              DataClassItemImportSaveActions.xnuuUBExuLDmUsrMQFjq((object) xmlReader);
              num2 = 35;
              continue;
            case 24:
              goto label_40;
            case 25:
              if (!this.featureFlagService.Enabled((string) DataClassItemImportSaveActions.nuqgCgExqUsLrhftbMqO(381945751 ^ 1158627804 ^ 1405872193), false))
                break;
              goto label_8;
            case 26:
              int num3 = (int) DataClassItemImportSaveActions.UDa0dwExkf9QkkYNLAj3((object) xmlReader);
              num2 = 16;
              continue;
            case 27:
              xml = (string) DataClassItemImportSaveActions.gkwHVJExX1UFlv2dJm8A((object) xmlReader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 18 : 3;
              continue;
            case 28:
              DataClassItemImportSaveActions.xk1RpVExZrAxONLbCYip((object) xmlReader);
              num2 = 34;
              continue;
            case 29:
              DataClassItemImportSaveActions.xk1RpVExZrAxONLbCYip((object) xmlReader);
              num2 = 4;
              continue;
            case 30:
              xmlReader = (XmlReader) DataClassItemImportSaveActions.lcgYCZEx8G2jga7h1sFC((object) data);
              num2 = 29;
              continue;
            case 31:
              DataClassItemImportSaveActions.xnuuUBExuLDmUsrMQFjq((object) xmlReader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 6;
              continue;
            case 32:
              DataClassItemImportSaveActions.xnuuUBExuLDmUsrMQFjq((object) xmlReader);
              num2 = 27;
              continue;
            case 35:
              xml = "";
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 21 : 8;
              continue;
            case 36:
              goto label_55;
          }
          result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597301508), (object) result1)));
          num2 = 12;
        }
label_6:
        num1 = 15;
        continue;
label_8:
        num1 = 11;
      }
label_28:
      return;
label_58:
      return;
label_55:
      return;
label_40:
      try
      {
        // ISSUE: type reference
        DataClassMetadata dataClassMetadata = ClassSerializationHelper.DeserializeObjectByXml(DataClassItemImportSaveActions.jGYyo4Ex1D23RxPpvSZU(__typeref (DataClassMetadata)), xml) as DataClassMetadata;
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
          num4 = 0;
        string errorMessage1;
        string errorMessage2;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_51;
            case 2:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) DataClassItemImportSaveActions.nuqgCgExqUsLrhftbMqO(~-397266137 ^ 396972084), (object) result1, (object) errorMessage1)));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
              continue;
            case 3:
            case 6:
              if (this.headerManager.ValidateDisplayName(result1, (string) DataClassItemImportSaveActions.YoGNd9ExNjWShB7C44JS((object) dataClassMetadata), out errorMessage1))
              {
                num4 = 5;
                continue;
              }
              goto case 2;
            case 4:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) DataClassItemImportSaveActions.nuqgCgExqUsLrhftbMqO(1251470110 >> 2 ^ 312567339), (object) result1, (object) errorMessage2)));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 3 : 2;
              continue;
            case 5:
              goto label_45;
            default:
              if (this.headerManager.ValidateName(result1, dataClassMetadata.Name, out errorMessage2))
              {
                num4 = 6;
                continue;
              }
              goto case 4;
          }
        }
label_51:
        return;
label_45:
        return;
      }
      catch (Exception ex)
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
          num5 = 0;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_44;
            default:
              result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) DataClassItemImportSaveActions.nuqgCgExqUsLrhftbMqO(372753449 ^ 372463965), (object) result1)));
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
              continue;
          }
        }
label_44:
        return;
      }
label_57:;
    }

    /// <inheritdoc />
    public override void ExecPostSaveActions(
      IEntity entity,
      Type type,
      Dictionary<string, object> values,
      Dictionary<string, string> serviceData,
      LinksDictionary links)
    {
      serviceData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281815428)] = string.Empty;
      base.ExecPostSaveActions(entity, type, values, serviceData, links);
    }

    static DataClassItemImportSaveActions()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DataClassItemImportSaveActions.dp6iveExCpVIYR9OlSQT();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            DataClassItemImportSaveActions.Uid = InterfaceActivator.UID<DataClassMetadataItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void dp6iveExCpVIYR9OlSQT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool btbtRwExfQ5xR2mLE87H() => DataClassItemImportSaveActions.KbuFX7ExENMsZMfgfbem == null;

    internal static DataClassItemImportSaveActions MepgcwExQe7k7ZNTLAFq() => DataClassItemImportSaveActions.KbuFX7ExENMsZMfgfbem;

    internal static bool JYpItsExvsOZi3ORb5G2([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static object lcgYCZEx8G2jga7h1sFC([In] object obj0) => (object) ((ImportTestReadData) obj0).Reader;

    internal static bool xk1RpVExZrAxONLbCYip([In] object obj0) => ((XmlReader) obj0).Read();

    internal static bool xnuuUBExuLDmUsrMQFjq([In] object obj0) => ((XmlReader) obj0).MoveToElement();

    internal static bool EHGKE0ExIh1Bq9tZVkbO([In] object obj0) => ((XmlReader) obj0).IsStartElement();

    internal static object Pn4RlCExVWhHnBs149fA([In] object obj0) => (object) ((XmlReader) obj0).Name;

    internal static bool Y3k9xRExSumP2uXh5v24([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool CXJepaExi2eirqECV4tG([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static object fRjm7fExR0ZeXRr3jl7U([In] object obj0) => (object) ((XmlReader) obj0).ReadString();

    internal static object nuqgCgExqUsLrhftbMqO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object EF1LNYExK9BEtBXNWg30([In] object obj0, [In] object obj1) => (object) ((XmlReader) obj0).GetAttribute((string) obj1);

    internal static object gkwHVJExX1UFlv2dJm8A([In] object obj0) => (object) ((XmlReader) obj0).Value;

    internal static void qPPdZ8ExTOVq27bACBLg([In] object obj0) => ((XmlReader) obj0).Skip();

    internal static XmlNodeType UDa0dwExkf9QkkYNLAj3([In] object obj0) => ((XmlReader) obj0).MoveToContent();

    internal static XmlNodeType dfY2KhExn8dJZFvBTQ5n([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static bool aFKqdyExOPxvt8p5gApO([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool FddSwTEx2lalgdDbeyPV([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static int IUUguyExegRvCwkKQy2q([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

    internal static object of0JEHExPyewHMjHYexu([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Remove(obj1, obj2);

    internal static Type jGYyo4Ex1D23RxPpvSZU([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object YoGNd9ExNjWShB7C44JS([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;
  }
}
