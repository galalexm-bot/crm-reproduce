// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.EnumMetadataImportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.Helpers;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для обработки EnumMetadata при импорте конфигурации
  /// </summary>
  [Component]
  internal class EnumMetadataImportExtension : NamedMetadataImportExtension<EnumMetadata>
  {
    private readonly MetadataItemManager metadataItemManager;
    private readonly MetadataItemGroupManager metadataItemGroupManager;
    private readonly IModelManager modelManager;
    private static EnumMetadataImportExtension J7b50VE9KN4rNt1pGDc0;

    /// <summary>Конструктор</summary>
    /// <param name="metadataItemManager">Менеджер элементов метаданных</param>
    /// <param name="metadataItemGroupManager">Менеджер групп элементов метаданных</param>
    /// <param name="modelManager">Менеджер управления моделями приложения через дизайнер ELMA</param>
    public EnumMetadataImportExtension(
      MetadataItemManager metadataItemManager,
      MetadataItemGroupManager metadataItemGroupManager,
      IModelManager modelManager)
    {
      EnumMetadataImportExtension.zGLDqeE9kKOpjYdaNxgD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.metadataItemGroupManager = metadataItemGroupManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 3 : 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.modelManager = modelManager;
            num = 2;
            continue;
          default:
            this.metadataItemManager = metadataItemManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    protected override bool CheckSystemMetadata(
      EnumMetadata eMdImported,
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      int num = 3;
      EnumMetadata metadata;
      EnumMetadata eMdImported1;
      while (true)
      {
        switch (num)
        {
          case 1:
            parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) EnumMetadataImportExtension.C1BaRyE9OxipopCJ5AOu(333888594 ^ 1075625116 ^ 1409205304), (object) eMdImported1.DisplayName, EnumMetadataImportExtension.aGAItWE92eioB0aVgUWn((object) eMdImported1), (object) EnumMetadataImportExtension.MMjaTkE9eo1GaemWcpuk((object) eMdImported1))));
            num = 5;
            continue;
          case 2:
            eMdImported1 = eMdImported;
            num = 7;
            continue;
          case 3:
            num = 2;
            continue;
          case 4:
            if (metadata.IsSystem())
            {
              num = 10;
              continue;
            }
            goto label_15;
          case 5:
            goto label_7;
          case 6:
            goto label_14;
          case 7:
            if (!EnumMetadataImportExtension.VsUHi2E9n844xeqHOnsD((object) eMdImported1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 8:
            if (metadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 9;
              continue;
            }
            goto case 4;
          case 9:
            goto label_15;
          case 10:
            EnumMetadataImportExtension.fhKF9UE9Nm6H7Egx1uEj((object) parameters, (object) new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) EnumMetadataImportExtension.C1BaRyE9OxipopCJ5AOu(-643786247 ^ -643539833), EnumMetadataImportExtension.boB35vE91gwiyoFIeJMq((object) metadata), (object) metadata.Name, (object) metadata.Uid)));
            num = 6;
            continue;
          default:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            metadata = ((IMetadataService) EnumMetadataImportExtension.dybCulE9PMVtf6l3gGW6((object) this)).GetMetadataList().FirstOrDefault<IMetadata>((Func<IMetadata, bool>) (md => EnumMetadataImportExtension.\u003C\u003Ec__DisplayClass4_0.zwJOrN86OycexfhF4QbN(EnumMetadataImportExtension.\u003C\u003Ec__DisplayClass4_0.XrWfA686kmBEV1qWYWPO((object) md), EnumMetadataImportExtension.\u003C\u003Ec__DisplayClass4_0.rbcgu286nvkmkKVja7Cv((object) eMdImported1)))) as EnumMetadata;
            num = 8;
            continue;
        }
      }
label_7:
      return false;
label_14:
      return false;
label_15:
      return true;
    }

    /// <inheritdoc />
    protected override void CheckNewMetadata(
      EnumMetadata mdImported,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.CheckEnumValues(mdImported, parameters, isTestRead);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    protected override bool CheckMetadata(
      EnumMetadata eMdImported,
      EnumMetadata mdDraft,
      ReadMetadataParameters parameters)
    {
      int num = 4;
      bool flag;
      while (true)
      {
        switch (num)
        {
          case 1:
            flag = false;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 2:
            EnumMetadataImportExtension.fhKF9UE9Nm6H7Egx1uEj((object) parameters, (object) new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) EnumMetadataImportExtension.C1BaRyE9OxipopCJ5AOu(-1872275253 >> 6 ^ -29009763), (object) eMdImported.DisplayName, (object) EnumMetadataImportExtension.MMjaTkE9eo1GaemWcpuk((object) eMdImported), EnumMetadataImportExtension.boB35vE91gwiyoFIeJMq((object) mdDraft), EnumMetadataImportExtension.aGAItWE92eioB0aVgUWn((object) eMdImported), (object) mdDraft.Name, (object) EnumMetadataImportExtension.MMjaTkE9eo1GaemWcpuk((object) mdDraft))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 0;
            continue;
          case 3:
            if (EnumMetadataImportExtension.nWO2fNE93F43IBwVkIUi(EnumMetadataImportExtension.aGAItWE92eioB0aVgUWn((object) mdDraft), EnumMetadataImportExtension.aGAItWE92eioB0aVgUWn((object) eMdImported)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 1;
              continue;
            }
            goto label_3;
          case 4:
            flag = true;
            num = 3;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return flag;
    }

    /// <inheritdoc />
    protected override void MergeMetadata(
      EnumMetadata eMdImported,
      EnumMetadata mdDraft,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      int num1 = 3;
      List<EnumValueMetadata>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_52;
          case 2:
            enumerator = eMdImported.Values.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 3:
            base.MergeMetadata(eMdImported, mdDraft, isTestRead, parameters);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 2;
            continue;
          default:
            goto label_4;
        }
      }
label_52:
      return;
label_4:
      try
      {
label_43:
        if (enumerator.MoveNext())
          goto label_33;
        else
          goto label_44;
label_7:
        int num2;
        while (true)
        {
          int num3;
          EnumValueMetadata enumValueMetadata;
          int? intValue1;
          int? intValue2;
          EnumValueMetadata valueImported;
          switch (num2)
          {
            case 1:
              num2 = 8;
              continue;
            case 2:
label_25:
              if (enumValueMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 5 : 4;
                continue;
              }
              goto case 12;
            case 3:
              mdDraft.Values.Add(valueImported);
              num2 = 4;
              continue;
            case 5:
              try
              {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                enumValueMetadata = mdDraft.Values.SingleOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v => EnumMetadataImportExtension.\u003C\u003Ec__DisplayClass7_0.leaBmP86aRNyVO6aZ744(EnumMetadataImportExtension.\u003C\u003Ec__DisplayClass7_0.Pi3Xp486pO60fSkLDMP4((object) v), EnumMetadataImportExtension.\u003C\u003Ec__DisplayClass7_0.Pi3Xp486pO60fSkLDMP4((object) valueImported))));
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                    goto label_27;
                }
              }
              catch (InvalidOperationException ex)
              {
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                    goto label_43;
                }
              }
            case 6:
              intValue2 = valueImported.IntValue;
              num2 = 9;
              continue;
            case 7:
              EnumMetadataImportExtension.I5JSc7E9tqKraisAObyh((object) valueImported, EnumMetadataImportExtension.MMjaTkE9eo1GaemWcpuk((object) enumValueMetadata));
              num2 = 14;
              continue;
            case 8:
              try
              {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                enumValueMetadata = mdDraft.Values.SingleOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v => EnumMetadataImportExtension.\u003C\u003Ec__DisplayClass7_0.tUCtSP863BbooHbylqmG(EnumMetadataImportExtension.\u003C\u003Ec__DisplayClass7_0.yomt1T86Nr9hldvHiqwX((object) v), EnumMetadataImportExtension.\u003C\u003Ec__DisplayClass7_0.yomt1T86Nr9hldvHiqwX((object) valueImported))));
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                    goto label_25;
                }
              }
              catch (InvalidOperationException ex)
              {
                int num7 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
                  num7 = 1;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740584660), EnumMetadataImportExtension.aGAItWE92eioB0aVgUWn((object) mdDraft), (object) EnumMetadataImportExtension.MMjaTkE9eo1GaemWcpuk((object) valueImported))));
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_43;
                  }
                }
              }
            case 9:
              if (!(intValue1.GetValueOrDefault() == intValue2.GetValueOrDefault() & intValue1.HasValue == intValue2.HasValue))
              {
                num3 = 15;
                break;
              }
              goto case 26;
            case 10:
              EnumMetadataImportExtension.fhKF9UE9Nm6H7Egx1uEj((object) parameters, (object) new TestImportMessages(TestImportMessagesType.InfoMetadata, EleWise.ELMA.SR.T((string) EnumMetadataImportExtension.C1BaRyE9OxipopCJ5AOu(-2092274397 << 4 ^ 883037512), EnumMetadataImportExtension.aGAItWE92eioB0aVgUWn((object) mdDraft), (object) EnumMetadataImportExtension.MMjaTkE9eo1GaemWcpuk((object) valueImported), (object) enumValueMetadata.Uid, EnumMetadataImportExtension.boB35vE91gwiyoFIeJMq((object) mdDraft), EnumMetadataImportExtension.boB35vE91gwiyoFIeJMq((object) valueImported), EnumMetadataImportExtension.boB35vE91gwiyoFIeJMq((object) enumValueMetadata), (object) valueImported.Name, EnumMetadataImportExtension.aGAItWE92eioB0aVgUWn((object) enumValueMetadata))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 11 : 13;
              continue;
            case 11:
label_27:
              if (enumValueMetadata == null)
              {
                num3 = 12;
                break;
              }
              goto case 10;
            case 12:
            case 13:
              if (enumValueMetadata == null)
              {
                num2 = 20;
                continue;
              }
              goto case 23;
            case 14:
              mdDraft.Values.Remove(enumValueMetadata);
              num2 = 3;
              continue;
            case 15:
              parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) EnumMetadataImportExtension.C1BaRyE9OxipopCJ5AOu(572119659 - -337058038 ^ 909392653), EnumMetadataImportExtension.boB35vE91gwiyoFIeJMq((object) mdDraft), (object) valueImported.Uid, (object) EnumMetadataImportExtension.MMjaTkE9eo1GaemWcpuk((object) enumValueMetadata), EnumMetadataImportExtension.aGAItWE92eioB0aVgUWn((object) mdDraft), (object) valueImported.DisplayName, EnumMetadataImportExtension.boB35vE91gwiyoFIeJMq((object) enumValueMetadata))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            case 16:
              EnumMetadataImportExtension.PxUqLPE9DWhKFCejUe8Y(EnumMetadataImportExtension.cLGoFvE9pNqH52iOS01n((object) parameters), EnumMetadataImportExtension.MMjaTkE9eo1GaemWcpuk((object) eMdImported), EnumMetadataImportExtension.aGAItWE92eioB0aVgUWn((object) valueImported), EnumMetadataImportExtension.aGAItWE92eioB0aVgUWn((object) enumValueMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 7 : 3;
              continue;
            case 17:
              mdDraft.Values.Add(valueImported);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 19 : 27;
              continue;
            case 18:
              goto label_33;
            case 19:
            case 20:
              if (this.CheckNewValue(mdDraft, valueImported, mdDraft.Values, parameters))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 10 : 17;
                continue;
              }
              goto label_43;
            case 22:
              if (valueImported == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 21 : 13;
                continue;
              }
              goto case 1;
            case 23:
              intValue1 = enumValueMetadata.IntValue;
              num2 = 6;
              continue;
            case 24:
              valueImported = enumerator.Current;
              num2 = 22;
              continue;
            case 25:
              goto label_48;
            case 26:
              EnumMetadataImportExtension.BqBSZSE9aRjCJ1nmQnQs(EnumMetadataImportExtension.cLGoFvE9pNqH52iOS01n((object) parameters), EnumMetadataImportExtension.MMjaTkE9eo1GaemWcpuk((object) eMdImported), EnumMetadataImportExtension.MMjaTkE9eo1GaemWcpuk((object) valueImported), EnumMetadataImportExtension.MMjaTkE9eo1GaemWcpuk((object) enumValueMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 16 : 16;
              continue;
            default:
              goto label_43;
          }
          num2 = num3;
        }
label_48:
        return;
label_33:
        num2 = 24;
        goto label_7;
label_44:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 25 : 18;
        goto label_7;
      }
      finally
      {
        enumerator.Dispose();
        int num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
          num8 = 0;
        switch (num8)
        {
          default:
        }
      }
    }

    /// <inheritdoc />
    protected override void SaveMetadata(EnumMetadata eMdMerged, ReadMetadataParameters parameters)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        IMetadataItemGroup metadataItemGroup1;
        long num3;
        string key;
        while (true)
        {
          MetadataItemDTO metadataItemDto1;
          // ISSUE: variable of a compiler-generated type
          EnumMetadataImportExtension.\u003C\u003Ec__DisplayClass8_0 cDisplayClass80;
          IMetadataItemGroup metadataItemGroup2;
          Guid result;
          List<MetadataItemDTO> metadataItemDtoList;
          IMetadataItem source;
          IMetadataItemGroup metadataItemGroup3;
          MetadataItemDTO metadataItemDto2;
          switch (num2)
          {
            case 1:
              if (metadataItemGroup3 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 6 : 6;
                continue;
              }
              goto case 29;
            case 2:
            case 6:
            case 15:
            case 28:
              if (num3 != 0L)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 21 : 7;
                continue;
              }
              goto case 16;
            case 3:
              source = this.metadataItemManager.LoadOrNull(EnumMetadataImportExtension.MMjaTkE9eo1GaemWcpuk((object) eMdMerged));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 3 : 27;
              continue;
            case 4:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass80 = new EnumMetadataImportExtension.\u003C\u003Ec__DisplayClass8_0();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 3 : 1;
              continue;
            case 5:
              if (metadataItemGroup2 == null)
                goto case 12;
              else
                goto label_21;
            case 7:
              goto label_28;
            case 8:
              EnumMetadataImportExtension.atUcAbE943d1vprSZmWG((object) metadataItemDto1, (object) eMdMerged);
              num2 = 7;
              continue;
            case 9:
              goto label_34;
            case 10:
              metadataItemDto2 = new MetadataItemDTO();
              EnumMetadataImportExtension.HuTTO7E9wSIa8mCTcobp((object) metadataItemDto2, EnumMetadataImportExtension.MMjaTkE9eo1GaemWcpuk((object) eMdMerged));
              break;
            case 11:
              goto label_26;
            case 12:
            case 21:
              metadataItemDto1.HeaderGroupId = num3;
              num2 = 9;
              continue;
            case 13:
              if (metadataItemGroup1 == null)
              {
                num2 = 28;
                continue;
              }
              goto label_27;
            case 14:
              metadataItemDto2 = Mapper.Map<IMetadataItem, MetadataItemDTO>(source);
              break;
            case 16:
              MetadataItemGroupManager itemGroupManager1 = this.metadataItemGroupManager;
              // ISSUE: type reference
              ParameterExpression parameterExpression1 = (ParameterExpression) EnumMetadataImportExtension.fnX6xRE99oZJCkrtEhwY(EnumMetadataImportExtension.pIXWAjE9A1slVIxiEq9o(__typeref (IMetadataItemGroup)), EnumMetadataImportExtension.C1BaRyE9OxipopCJ5AOu(516838154 ^ 516859018));
              // ISSUE: method reference
              // ISSUE: type reference
              Expression<Func<IMetadataItemGroup, bool>> condition1 = Expression.Lambda<Func<IMetadataItemGroup, bool>>((Expression) EnumMetadataImportExtension.eKjP1YE9MwYGdTrmrQca((object) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IMetadataItemGroup.get_Namespace))), EnumMetadataImportExtension.jidCpIE90bvqrBlh8Bri(EnumMetadataImportExtension.C1BaRyE9OxipopCJ5AOu(95909607 + 343705423 ^ 439826326), EnumMetadataImportExtension.pIXWAjE9A1slVIxiEq9o(__typeref (string)))), parameterExpression1);
              object obj1 = EnumMetadataImportExtension.NkY7bdE9JqKYvIxfr4eg();
              metadataItemGroup2 = itemGroupManager1.Find(condition1, (FetchOptions) obj1).FirstOrDefault<IMetadataItemGroup>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 5;
              continue;
            case 17:
              goto label_27;
            case 18:
              // ISSUE: reference to a compiler-generated field
              if (parameters.ServiceData.TryGetValue(key, out cDisplayClass80.tmp))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                continue;
              }
              goto case 24;
            case 19:
              metadataItemGroup3 = this.metadataItemGroupManager.LoadOrNull(result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
              continue;
            case 20:
              num3 = metadataItemGroup2.Id;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 12 : 1;
              continue;
            case 22:
            case 25:
              MetadataItemGroupManager itemGroupManager2 = this.metadataItemGroupManager;
              // ISSUE: type reference
              ParameterExpression parameterExpression2 = Expression.Parameter(EnumMetadataImportExtension.pIXWAjE9A1slVIxiEq9o(__typeref (IMetadataItemGroup)), (string) EnumMetadataImportExtension.C1BaRyE9OxipopCJ5AOu(-867826612 ^ -867765300));
              // ISSUE: method reference
              // ISSUE: type reference
              // ISSUE: field reference
              Expression<Func<IMetadataItemGroup, bool>> condition2 = Expression.Lambda<Func<IMetadataItemGroup, bool>>((Expression) EnumMetadataImportExtension.eKjP1YE9MwYGdTrmrQca(EnumMetadataImportExtension.yaYejKE9xFNOAZpRbJxq((object) parameterExpression2, (object) (MethodInfo) EnumMetadataImportExtension.yqDgnIE97Zh5lru4Z6QA(__methodref (IMetadataItemGroup.get_Namespace))), EnumMetadataImportExtension.JDl8NAE9yqUnlQLCZuLB(EnumMetadataImportExtension.jidCpIE90bvqrBlh8Bri((object) cDisplayClass80, EnumMetadataImportExtension.pIXWAjE9A1slVIxiEq9o(__typeref (EnumMetadataImportExtension.\u003C\u003Ec__DisplayClass8_0))), EnumMetadataImportExtension.VMwxxJE9mcbR3wqDFTXV(__fieldref (EnumMetadataImportExtension.\u003C\u003Ec__DisplayClass8_0.tmp)))), parameterExpression2);
              object obj2 = EnumMetadataImportExtension.NkY7bdE9JqKYvIxfr4eg();
              metadataItemGroup1 = itemGroupManager2.Find(condition2, (FetchOptions) obj2).FirstOrDefault<IMetadataItemGroup>();
              num2 = 13;
              continue;
            case 23:
              // ISSUE: reference to a compiler-generated field
              if (!Guid.TryParse(cDisplayClass80.tmp, out result))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 25 : 7;
                continue;
              }
              goto case 19;
            case 24:
              metadataItemDtoList = this.modelManager.SaveMetadataItems(new List<MetadataItemDTO>()
              {
                metadataItemDto1
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 30 : 23;
              continue;
            case 26:
              parameters.Headers.Add(EnumMetadataImportExtension.aWJ3TUE9dFMwvrJlIPgJ((object) metadataItemDtoList[0]));
              num2 = 11;
              continue;
            case 27:
              if (source != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 6 : 14;
                continue;
              }
              goto case 10;
            case 29:
              num3 = metadataItemGroup3.Id;
              num2 = 15;
              continue;
            case 30:
              parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T((string) EnumMetadataImportExtension.C1BaRyE9OxipopCJ5AOu(1470440286 ^ 1470229126), (object) EnumMetadataImportExtension.MMjaTkE9eo1GaemWcpuk((object) eMdMerged), (object) eMdMerged.DisplayName, (object) eMdMerged.Name), false));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 10 : 26;
              continue;
            default:
              num3 = 0L;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 12 : 23;
              continue;
          }
          metadataItemDto1 = metadataItemDto2;
          num2 = 8;
        }
label_21:
        num1 = 20;
        continue;
label_27:
        num3 = metadataItemGroup1.Id;
        num1 = 2;
        continue;
label_28:
        key = (string) EnumMetadataImportExtension.JdSNlHE9HXmjVnD2mQFT((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123936914), (object) EnumMetadataImportExtension.mUrLJAE96CniX5O2QmIy((object) eMdMerged));
        num1 = 18;
        continue;
label_34:
        eMdMerged.GroupId = num3;
        num1 = 24;
      }
label_26:;
    }

    /// <summary>
    /// Проверка на возможность добавления нового значения перечисления
    /// </summary>
    private bool CheckNewValue(
      EnumMetadata metadata,
      EnumValueMetadata value,
      List<EnumValueMetadata> allValues,
      ReadMetadataParameters parameters)
    {
      bool flag = true;
      string str1 = MetadataImportHelper.CheckEnumValueDisplayName(value, value.DisplayName, allValues);
      if (str1 != null)
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281565550), (object) value.DisplayName, (object) value.Name, (object) value.IntValue, (object) metadata.DisplayName, (object) metadata.Name, (object) metadata.Uid, (object) str1)));
        flag = false;
      }
      string str2 = MetadataImportHelper.CheckEnumValueName(value, value.Name, allValues);
      if (str2 != null)
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106204690), (object) value.DisplayName, (object) value.Name, (object) value.IntValue, (object) metadata.DisplayName, (object) metadata.Name, (object) metadata.Uid, (object) str2)));
        flag = false;
      }
      string str3 = MetadataImportHelper.CheckEnumIntValue(value, value.IntValue, allValues);
      if (str3 != null)
      {
        parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461348787), (object) value.DisplayName, (object) value.Name, (object) value.IntValue, (object) metadata.DisplayName, (object) metadata.Name, (object) metadata.Uid, (object) str3)));
        flag = false;
      }
      return flag;
    }

    /// <summary>
    /// Проверка возможности создания значений перечисления, для которого не существует имеющегося перечисления
    /// </summary>
    private void CheckEnumValues(
      EnumMetadata eMdImported,
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      int num1 = 5;
      List<EnumValueMetadata> allValues;
      List<EnumValueMetadata>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_5:
            if (EnumMetadataImportExtension.y8DTvyE9lxQPfYxGGMHU((object) allValues) != EnumMetadataImportExtension.y8DTvyE9lxQPfYxGGMHU((object) eMdImported.Values))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 3 : 3;
              continue;
            }
            goto label_16;
          case 2:
            goto label_20;
          case 3:
            eMdImported.Values = allValues;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 0;
            continue;
          case 4:
            enumerator = eMdImported.Values.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 5:
            allValues = new List<EnumValueMetadata>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 4 : 0;
            continue;
          default:
            try
            {
label_12:
              if (enumerator.MoveNext())
                goto label_14;
              else
                goto label_13;
label_9:
              EnumValueMetadata current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_14;
                  case 2:
                    goto label_12;
                  case 3:
                    if (this.CheckNewValue(eMdImported, current, allValues, parameters) | isTestRead)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 4 : 1;
                      continue;
                    }
                    goto label_12;
                  case 4:
                    allValues.Add(current);
                    num2 = 2;
                    continue;
                  default:
                    goto label_5;
                }
              }
label_13:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
              goto label_9;
label_14:
              current = enumerator.Current;
              num2 = 3;
              goto label_9;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
        }
      }
label_20:
      return;
label_16:;
    }

    internal static void zGLDqeE9kKOpjYdaNxgD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool sjkY9SE9XJ5pKwErcLIe() => EnumMetadataImportExtension.J7b50VE9KN4rNt1pGDc0 == null;

    internal static EnumMetadataImportExtension XCGyT1E9TGeeOKBTWqlY() => EnumMetadataImportExtension.J7b50VE9KN4rNt1pGDc0;

    internal static bool VsUHi2E9n844xeqHOnsD([In] object obj0) => ((IMetadata) obj0).IsSystem();

    internal static object C1BaRyE9OxipopCJ5AOu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object aGAItWE92eioB0aVgUWn([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static Guid MMjaTkE9eo1GaemWcpuk([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object dybCulE9PMVtf6l3gGW6([In] object obj0) => (object) ((NamedMetadataImportExtension<EnumMetadata>) obj0).MetadataRuntimeService;

    internal static object boB35vE91gwiyoFIeJMq([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void fhKF9UE9Nm6H7Egx1uEj([In] object obj0, [In] object obj1) => ((ReadMetadataParameters) obj0).TestMessagesAdd((TestImportMessages) obj1);

    internal static bool nWO2fNE93F43IBwVkIUi([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object cLGoFvE9pNqH52iOS01n([In] object obj0) => (object) ((ReadMetadataParameters) obj0).MergeReplace;

    internal static void BqBSZSE9aRjCJ1nmQnQs([In] object obj0, Guid mdUid, Guid uidFrom, Guid uidTo) => ((MergeReplace) obj0).SetUidReplaceProperty(mdUid, uidFrom, uidTo);

    internal static void PxUqLPE9DWhKFCejUe8Y([In] object obj0, Guid mdUid, [In] object obj2, [In] object obj3) => ((MergeReplace) obj0).SetNameReplaceProperty(mdUid, (string) obj2, (string) obj3);

    internal static void I5JSc7E9tqKraisAObyh([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static void HuTTO7E9wSIa8mCTcobp([In] object obj0, Guid value) => ((MetadataItemDTO) obj0).Uid = value;

    internal static void atUcAbE943d1vprSZmWG([In] object obj0, [In] object obj1) => ((MetadataItemDTO) obj0).Metadata = (IMetadata) obj1;

    internal static long mUrLJAE96CniX5O2QmIy([In] object obj0) => ((EnumMetadata) obj0).GroupId;

    internal static object JdSNlHE9HXmjVnD2mQFT([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static Type pIXWAjE9A1slVIxiEq9o([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object yqDgnIE97Zh5lru4Z6QA([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object yaYejKE9xFNOAZpRbJxq([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object jidCpIE90bvqrBlh8Bri([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object VMwxxJE9mcbR3wqDFTXV([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static object JDl8NAE9yqUnlQLCZuLB([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static object eKjP1YE9MwYGdTrmrQca([In] object obj0, [In] object obj1) => (object) Expression.Equal((Expression) obj0, (Expression) obj1);

    internal static object NkY7bdE9JqKYvIxfr4eg() => (object) FetchOptions.First;

    internal static object fnX6xRE99oZJCkrtEhwY([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static long aWJ3TUE9dFMwvrJlIPgJ([In] object obj0) => ((MetadataItemDTO) obj0).HeaderId;

    internal static int y8DTvyE9lxQPfYxGGMHU([In] object obj0) => ((List<EnumValueMetadata>) obj0).Count;
  }
}
