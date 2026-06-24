// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.HierarchicalMetadataService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Services
{
  [Component]
  internal class HierarchicalMetadataService : IHierarchicalMetadataService
  {
    internal static HierarchicalMetadataService x38iZ0b8I5OCBCPwGrRk;

    public string ProcessingParentForForm(
      Guid propertyUid,
      Guid propertyTypeUid,
      Guid propertySubTypeUid,
      RelationType? relationType,
      EntityMetadata entityMd)
    {
      if (entityMd == null || entityMd.Properties == null)
        return (string) null;
      if (!this.CanBeParentForChild(propertyUid, propertyTypeUid, propertySubTypeUid, relationType, (ClassMetadata) entityMd).Any<KeyValuePair<Guid, string>>())
        return (string) null;
      if (Locator.GetService<IMetadataEditorService>() == null)
        return (string) null;
      MetadataLoader.GetPropertiesAndTableParts((ClassMetadata) entityMd).OfType<PropertyMetadata>().Where<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (pMd =>
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (HierarchicalMetadataService.\u003C\u003Ec__DisplayClass0_0.NF3bchC2vtlf6XlyBkjM((object) pMd) is EntitySettings)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
            case 5:
            case 7:
            case 9:
              goto label_3;
            case 3:
              // ISSUE: reference to a compiler-generated method
              if (HierarchicalMetadataService.\u003C\u003Ec__DisplayClass0_0.aKRSIYC2feds7cGTyRbC((object) pMd))
              {
                num = 2;
                continue;
              }
              goto case 4;
            case 4:
              // ISSUE: reference to a compiler-generated method
              if (!(HierarchicalMetadataService.\u003C\u003Ec__DisplayClass0_0.DP1E50C2QnBlDgAHxD4y((object) pMd) != propertyUid))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 9 : 1;
                continue;
              }
              goto case 8;
            case 6:
              if (!(pMd.SubTypeUid == propertySubTypeUid))
              {
                num = 5;
                continue;
              }
              goto case 1;
            case 8:
              // ISSUE: reference to a compiler-generated method
              if (!(HierarchicalMetadataService.\u003C\u003Ec__DisplayClass0_0.sl91NiC2CjP1rFta9hDu((object) pMd) == propertyTypeUid))
              {
                num = 7;
                continue;
              }
              goto case 6;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return HierarchicalMetadataService.\u003C\u003Ec__DisplayClass0_0.wFEfxdC28N9hb5NYRsoh((object) (HierarchicalMetadataService.\u003C\u003Ec__DisplayClass0_0.NF3bchC2vtlf6XlyBkjM((object) pMd) as EntitySettings)) == RelationType.OneToOne;
label_3:
        return false;
      })).ToList<PropertyMetadata>();
      return (string) null;
    }

    public List<KeyValuePair<string, int>> ProcessingChildsForForm(
      Guid propertyUid,
      Guid propertyTypeUid,
      Guid propertySubTypeUid,
      RelationType? relationType,
      EntityMetadata entityMd)
    {
      if (entityMd == null || entityMd.Properties == null)
        return (List<KeyValuePair<string, int>>) null;
      if (!this.CanBeChild(propertyTypeUid, propertySubTypeUid, relationType))
        return (List<KeyValuePair<string, int>>) null;
      if (Locator.GetService<IMetadataEditorService>() == null)
        return (List<KeyValuePair<string, int>>) null;
      MetadataLoader.GetPropertiesAndTableParts((ClassMetadata) entityMd).OfType<PropertyMetadata>().Where<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (pMd =>
      {
        int num = 7;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (HierarchicalMetadataService.\u003C\u003Ec__DisplayClass1_0.eLEkeYC2KPX9sTb5K4Ft(HierarchicalMetadataService.\u003C\u003Ec__DisplayClass1_0.CQJaweC2qUIFKUcQVs78((object) pMd), propertyTypeUid))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
            case 5:
              goto label_5;
            case 3:
              // ISSUE: reference to a compiler-generated method
              if (HierarchicalMetadataService.\u003C\u003Ec__DisplayClass1_0.UFPNR1C2XH5AopfFXbKj((object) pMd) is EntitySettings)
              {
                num = 4;
                continue;
              }
              goto label_5;
            case 4:
              goto label_4;
            case 6:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!HierarchicalMetadataService.\u003C\u003Ec__DisplayClass1_0.NE6et0C2RAqhXjHMartW(HierarchicalMetadataService.\u003C\u003Ec__DisplayClass1_0.pPJAjPC2iko8Xgmq9Cn6((object) pMd), propertyUid))
              {
                num = 2;
                continue;
              }
              goto case 1;
            case 7:
              // ISSUE: reference to a compiler-generated method
              if (!HierarchicalMetadataService.\u003C\u003Ec__DisplayClass1_0.sg4xpvC2SF1jlcMcxNjk((object) pMd))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 4 : 6;
                continue;
              }
              goto label_5;
            default:
              // ISSUE: reference to a compiler-generated method
              if (!HierarchicalMetadataService.\u003C\u003Ec__DisplayClass1_0.eLEkeYC2KPX9sTb5K4Ft(pMd.SubTypeUid, propertySubTypeUid))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 5;
                continue;
              }
              goto case 3;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return HierarchicalMetadataService.\u003C\u003Ec__DisplayClass1_0.uY77XcC2TgnDTyBol92t((object) (HierarchicalMetadataService.\u003C\u003Ec__DisplayClass1_0.UFPNR1C2XH5AopfFXbKj((object) pMd) as EntitySettings)) == RelationType.OneToOne;
label_5:
        return false;
      })).ToList<PropertyMetadata>();
      return (List<KeyValuePair<string, int>>) null;
    }

    public Dictionary<Guid, string> CanBeParentForChild(
      Guid propertyUid,
      Guid propertyTypeUid,
      Guid propertySubTypeUid,
      RelationType? relationType,
      ClassMetadata entityMd)
    {
      Dictionary<Guid, string> result = new Dictionary<Guid, string>();
      if (entityMd == null || entityMd.Properties == null || !this.CanBeChild(propertyTypeUid, propertySubTypeUid, relationType) || Locator.GetService<IMetadataEditorService>() == null)
        return result;
      List<PropertyMetadata> list = MetadataLoader.GetPropertiesAndTableParts(entityMd).OfType<PropertyMetadata>().Where<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (pMd =>
      {
        int num1 = 2;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 4:
                goto label_12;
              case 2:
                // ISSUE: reference to a compiler-generated method
                if (HierarchicalMetadataService.\u003C\u003Ec__DisplayClass2_0.svXrUZC22Of2lbTTOwif((object) pMd))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 0;
                  continue;
                }
                goto case 5;
              case 3:
                goto label_9;
              case 5:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (HierarchicalMetadataService.\u003C\u003Ec__DisplayClass2_0.xatO73C2PvGZ7jnvrZMw(HierarchicalMetadataService.\u003C\u003Ec__DisplayClass2_0.KhXD4AC2eoycgE7MiqWn((object) pMd), propertyUid))
                {
                  num2 = 6;
                  continue;
                }
                goto label_12;
              case 6:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (HierarchicalMetadataService.\u003C\u003Ec__DisplayClass2_0.wBtll9C2NcjPWJofE92C(HierarchicalMetadataService.\u003C\u003Ec__DisplayClass2_0.jDL4tHC21Tt6eqA0lJq6((object) pMd), propertyTypeUid))
                {
                  num2 = 7;
                  continue;
                }
                goto label_12;
              case 7:
                // ISSUE: reference to a compiler-generated method
                if (HierarchicalMetadataService.\u003C\u003Ec__DisplayClass2_0.wBtll9C2NcjPWJofE92C(pMd.SubTypeUid, propertySubTypeUid))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 3 : 3;
                  continue;
                }
                goto label_12;
              default:
                goto label_11;
            }
          }
label_9:
          if (!(pMd.Settings is EntitySettings))
            num1 = 4;
          else
            break;
        }
label_11:
        return (pMd.Settings as EntitySettings).RelationType == RelationType.OneToOne;
label_12:
        return false;
      })).ToList<PropertyMetadata>();
      if (list.Any<PropertyMetadata>())
        list.ForEach((Action<PropertyMetadata>) (pMd =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                result.Add(HierarchicalMetadataService.\u003C\u003Ec__DisplayClass2_0.KhXD4AC2eoycgE7MiqWn((object) pMd), pMd.DisplayName);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
      return result;
    }

    public Dictionary<Guid, string> CanBeParentForChild(
      PropertyMetadata propertyMetadata,
      ClassMetadata entityMd)
    {
      Dictionary<Guid, string> result = new Dictionary<Guid, string>();
      if (propertyMetadata == null || propertyMetadata.TypeUid != EntityDescriptor.UID || !(propertyMetadata.Settings is EntitySettings) || !this.CanBeChild(propertyMetadata))
        return result;
      List<PropertyMetadata> list = MetadataLoader.GetPropertiesAndTableParts(entityMd).OfType<PropertyMetadata>().Where<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (pMd =>
      {
        int num1 = 5;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
              case 6:
                goto label_10;
              case 2:
                // ISSUE: reference to a compiler-generated method
                if (!(HierarchicalMetadataService.\u003C\u003Ec__DisplayClass3_0.B4L7DBC27u3vrYkSSBoZ((object) pMd) is EntitySettings))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 6 : 6;
                  continue;
                }
                goto label_9;
              case 3:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!HierarchicalMetadataService.\u003C\u003Ec__DisplayClass3_0.D2WDh0C2HiiuwS3ESh6t(HierarchicalMetadataService.\u003C\u003Ec__DisplayClass3_0.sugenEC2Ax6aP8lmDNYJ((object) pMd), HierarchicalMetadataService.\u003C\u003Ec__DisplayClass3_0.sugenEC2Ax6aP8lmDNYJ((object) propertyMetadata)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
                  continue;
                }
                goto case 2;
              case 4:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (HierarchicalMetadataService.\u003C\u003Ec__DisplayClass3_0.KE3G9UC24dHo8h1UWnmG(HierarchicalMetadataService.\u003C\u003Ec__DisplayClass3_0.hHW59sC2w3g2XkcRFf8F((object) pMd), HierarchicalMetadataService.\u003C\u003Ec__DisplayClass3_0.hHW59sC2w3g2XkcRFf8F((object) propertyMetadata)))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                  continue;
                }
                goto label_10;
              case 5:
                goto label_5;
              case 7:
                goto label_9;
              default:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (HierarchicalMetadataService.\u003C\u003Ec__DisplayClass3_0.D2WDh0C2HiiuwS3ESh6t(HierarchicalMetadataService.\u003C\u003Ec__DisplayClass3_0.gSjiNiC260u8Ne4Bgv0N((object) pMd), HierarchicalMetadataService.\u003C\u003Ec__DisplayClass3_0.gSjiNiC260u8Ne4Bgv0N((object) propertyMetadata)))
                {
                  num2 = 3;
                  continue;
                }
                goto label_10;
            }
          }
label_5:
          // ISSUE: reference to a compiler-generated method
          if (!HierarchicalMetadataService.\u003C\u003Ec__DisplayClass3_0.XRn2WXC2tsEIJi9rMnq8((object) pMd))
            num1 = 4;
          else
            goto label_10;
        }
label_9:
        // ISSUE: reference to a compiler-generated method
        return (HierarchicalMetadataService.\u003C\u003Ec__DisplayClass3_0.B4L7DBC27u3vrYkSSBoZ((object) pMd) as EntitySettings).RelationType == RelationType.OneToOne;
label_10:
        return false;
      })).ToList<PropertyMetadata>();
      if (list.Any<PropertyMetadata>())
        list.ForEach((Action<PropertyMetadata>) (pMd =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                result.Add(HierarchicalMetadataService.\u003C\u003Ec__DisplayClass3_0.hHW59sC2w3g2XkcRFf8F((object) pMd), (string) HierarchicalMetadataService.\u003C\u003Ec__DisplayClass3_0.ViH36PC2xC1U3LZCoFWa((object) pMd));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
      return result;
    }

    public bool CanBeChild(
      Guid propertyTypeUid,
      Guid propertySubTypeUid,
      RelationType? relationType)
    {
      if (propertyTypeUid != EntityDescriptor.UID || !relationType.HasValue)
        return false;
      IMetadataEditorService service = Locator.GetService<IMetadataEditorService>();
      if (service == null)
        return false;
      EntityMetadata metadata = (EntityMetadata) service.GetMetadata(propertySubTypeUid);
      if (metadata != null && metadata.Hierarchical && metadata.HierarchyType == HierarchyType.Elements)
      {
        RelationType? nullable = relationType;
        RelationType relationType1 = RelationType.OneToOne;
        if (!(nullable.GetValueOrDefault() == relationType1 & nullable.HasValue))
        {
          nullable = relationType;
          RelationType relationType2 = RelationType.ManyToMany;
          if (!(nullable.GetValueOrDefault() == relationType2 & nullable.HasValue))
            goto label_8;
        }
        return true;
      }
label_8:
      return false;
    }

    public bool CanBeChild(PropertyMetadata propertyMetadata)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        EntitySettings entitySettings;
        EntityMetadata entityMetadata;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (propertyMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                continue;
              }
              goto label_21;
            case 2:
              goto label_14;
            case 3:
              if (entitySettings.RelationType != RelationType.OneToOne)
              {
                num2 = 8;
                continue;
              }
              goto label_13;
            case 4:
              goto label_9;
            case 5:
              if (entitySettings != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 12 : 0;
                continue;
              }
              goto label_17;
            case 6:
              if (entityMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 11 : 1;
                continue;
              }
              goto label_14;
            case 7:
              goto label_13;
            case 8:
              if (entitySettings.RelationType == RelationType.ManyToMany)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 3 : 7;
                continue;
              }
              goto label_14;
            case 9:
              goto label_21;
            case 10:
              goto label_17;
            case 11:
              if (!HierarchicalMetadataService.eA5TwEb8Xov7knZksyou((object) entityMetadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 2;
                continue;
              }
              goto label_9;
            case 12:
              entityMetadata = (EntityMetadata) MetadataLoader.LoadMetadata(HierarchicalMetadataService.OW5n2lb8KH3vgVw45xnj((object) propertyMetadata));
              num2 = 6;
              continue;
            default:
              if (HierarchicalMetadataService.Sm83Mrb8RPQjEDN8OZlQ(HierarchicalMetadataService.K6UPaGb8iwZM5BSTl5GM((object) propertyMetadata), EntityDescriptor.UID))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 9 : 0;
                continue;
              }
              entitySettings = HierarchicalMetadataService.imMtLAb8qv6OqcVA1msT((object) propertyMetadata) as EntitySettings;
              num2 = 5;
              continue;
          }
        }
label_9:
        if (HierarchicalMetadataService.S8xklbb8TA1Jiy1GiMif((object) entityMetadata) == HierarchyType.Elements)
          num1 = 3;
        else
          goto label_14;
      }
label_13:
      return true;
label_14:
      return false;
label_17:
      return false;
label_21:
      return false;
    }

    public Dictionary<long, string> GetAllHierarchicalEntities(
      IEntityMetadata metadata,
      long? parentId,
      int indent,
      int deep)
    {
      if (!(metadata is EntityMetadata entityMetadata))
        throw new NullReferenceException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824473271));
      if (deep > 30)
        deep = 30;
      if (indent > 30)
        indent = 30;
      if (deep < 0)
        deep = 0;
      if (indent < 0)
        indent = 0;
      if (indent == 0)
      {
        if (deep == 0)
          deep = 30;
      }
      else if (deep + indent > 30 || deep == 0)
        deep = 30 - indent;
      ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
      string tableName = entityMetadata.TableName;
      if (!serviceNotNull.TableExists(tableName))
        throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917171314), (object) tableName));
      string str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333764644);
      if (!serviceNotNull.ColumnExists(tableName, str1))
        throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108738786), (object) tableName, (object) str1));
      string nameColumnName = (string) null;
      if (((ClassMetadata) metadata).TitlePropertyUid != Guid.Empty)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        PropertyMetadata propertyMetadata = ((ClassMetadata) metadata).Properties.FirstOrDefault<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (p => HierarchicalMetadataService.\u003C\u003Ec__DisplayClass6_0.vUSTuIC29uQYAlq4hrba(HierarchicalMetadataService.\u003C\u003Ec__DisplayClass6_0.b7Dy63C2JteElv8KgbOp((object) p), ((ClassMetadata) metadata).TitlePropertyUid)));
        if (propertyMetadata != null && propertyMetadata.Settings is SimpleTypeSettings settings && !string.IsNullOrWhiteSpace(settings.FieldName))
          nameColumnName = settings.FieldName;
      }
      string hierarchicalChilds = serviceNotNull.GetSqlHierarchicalChilds(tableName, str1, nameColumnName, parentId, indent, deep);
      Dictionary<long, string> hierarchicalEntities = new Dictionary<long, string>();
      using (IDataReader dataReader = serviceNotNull.ExecuteQuery(hierarchicalChilds, (Dictionary<string, object>) null))
      {
        while (dataReader.Read())
        {
          long int64 = Convert.ToInt64(dataReader[0]);
          if (int64 > 0L && !hierarchicalEntities.ContainsKey(int64))
          {
            string str2 = string.IsNullOrWhiteSpace(nameColumnName) ? EleWise.ELMA.SR.Untitled : Convert.ToString(dataReader[1]);
            hierarchicalEntities.Add(int64, str2);
          }
        }
      }
      return hierarchicalEntities;
    }

    private bool IsHierarchicalProperty(IPropertyMetadata pMd)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        EntityMetadata metadata;
        while (true)
        {
          IMetadataEditorService service;
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              goto label_3;
            case 3:
              if (metadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 9;
                continue;
              }
              goto case 4;
            case 4:
              if (HierarchicalMetadataService.eA5TwEb8Xov7knZksyou((object) metadata))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
                continue;
              }
              goto label_4;
            case 5:
              if (!(pMd.TypeUid != EntityDescriptor.UID))
              {
                service = Locator.GetService<IMetadataEditorService>();
                num2 = 8;
                continue;
              }
              num2 = 10;
              continue;
            case 6:
              if (pMd != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 2 : 5;
                continue;
              }
              goto label_5;
            case 7:
            case 9:
              goto label_4;
            case 8:
              if (service == null)
              {
                num2 = 7;
                continue;
              }
              break;
            case 10:
              goto label_5;
          }
          metadata = service.GetMetadata(pMd.SubTypeUid) as EntityMetadata;
          num2 = 3;
        }
label_13:
        if (HierarchicalMetadataService.S8xklbb8TA1Jiy1GiMif((object) metadata) == HierarchyType.Elements)
          num1 = 2;
        else
          goto label_4;
      }
label_3:
      return true;
label_4:
      return false;
label_5:
      return false;
    }

    public HierarchicalMetadataService()
    {
      HierarchicalMetadataService.tQsyfDb8kLw8jt0XTnWy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid K6UPaGb8iwZM5BSTl5GM([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static bool Sm83Mrb8RPQjEDN8OZlQ([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object imMtLAb8qv6OqcVA1msT([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static Guid OW5n2lb8KH3vgVw45xnj([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static bool eA5TwEb8Xov7knZksyou([In] object obj0) => ((EntityMetadata) obj0).Hierarchical;

    internal static HierarchyType S8xklbb8TA1Jiy1GiMif([In] object obj0) => ((EntityMetadata) obj0).HierarchyType;

    internal static bool gQdjRhb8VPeaAfQfTDiv() => HierarchicalMetadataService.x38iZ0b8I5OCBCPwGrRk == null;

    internal static HierarchicalMetadataService g9YYDBb8Slj4DaK1TIRV() => HierarchicalMetadataService.x38iZ0b8I5OCBCPwGrRk;

    internal static void tQsyfDb8kLw8jt0XTnWy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
