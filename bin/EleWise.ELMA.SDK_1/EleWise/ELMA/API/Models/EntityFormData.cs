// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.EntityFormData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.API.Models
{
  /// <summary>
  /// Данные для отображения формы сущности. Используется в WebAPI
  /// </summary>
  public class EntityFormData
  {
    internal static EntityFormData K1dGZOf1DAP0lXQOCcKs;

    public EntityFormData()
    {
      EntityFormData.g9wDkDf14YLHP13ENw9B();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Items = new List<PropertyFormItemData>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public EntityFormData(Type entityType, RootViewItem viewItem)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
        num1 = 0;
      while (true)
      {
        int num2;
        IMetadataRuntimeService serviceNotNull;
        IEnumerable<IEntityFilterProvider> extensionPoints;
        switch (num1)
        {
          case 1:
            extensionPoints = ((ComponentManager) EntityFormData.ceiXQpf16xWDmE2pcHOY()).GetExtensionPoints<IEntityFilterProvider>();
            num2 = 2;
            break;
          case 2:
            this.Items = EntityFormData.CreateItems(entityType, (object) viewItem, (object) serviceNotNull, extensionPoints);
            num2 = 3;
            break;
          case 3:
            goto label_4;
          default:
            serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
            continue;
        }
        num1 = num2;
      }
label_4:;
    }

    /// <summary>Элементы формы</summary>
    public List<PropertyFormItemData> Items { get; set; }

    private static Guid ProcessSubTypeUid(Guid subTypeUid)
    {
      int num = 4;
      IMetadata metadata1;
      while (true)
      {
        Type typeByUidOrNull;
        IMetadata metadata2;
        switch (num)
        {
          case 1:
            if (metadata1 == null)
            {
              num = 5;
              continue;
            }
            goto label_10;
          case 2:
            metadata2 = (IMetadata) null;
            break;
          case 3:
            goto label_2;
          case 4:
            if (!(subTypeUid == Guid.Empty))
            {
              typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(subTypeUid);
              num = 6;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 3 : 0;
            continue;
          case 5:
            goto label_9;
          case 6:
            if (EntityFormData.l3yXjuf1Hpa8JKdSjYIW(typeByUidOrNull, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          default:
            metadata2 = MetadataLoader.LoadMetadata(typeByUidOrNull);
            break;
        }
        metadata1 = metadata2;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
      }
label_2:
      return subTypeUid;
label_9:
      return subTypeUid;
label_10:
      return EntityFormData.j2nMiqf1ACBonPDk7H3I((object) metadata1);
    }

    private static List<PropertyFormItemData> CreateItems(
      Type type,
      object viewItem,
      object metadataService,
      IEnumerable<IEntityFilterProvider> providers)
    {
      IEnumerable<PropertyViewItem> allProperties = ((RootViewItem) viewItem).GetAllProperties();
      List<PropertyFormItemData> items = new List<PropertyFormItemData>();
      ClassMetadata classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(type);
      IEnumerable<IPropertyMetadata> source = classMetadata is IEntityMetadata entityMetadata ? entityMetadata.GetPropertiesAndTableParts() : (IEnumerable<IPropertyMetadata>) classMetadata.Properties;
      foreach (PropertyViewItem propertyViewItem in allProperties)
      {
        PropertyViewItem propertyItem = propertyViewItem;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        IPropertyMetadata p = source.FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p1 => EntityFormData.\u003C\u003Ec__DisplayClass7_0.x0vXAsZBwiAufbZt3S0I(EntityFormData.\u003C\u003Ec__DisplayClass7_0.nBhdtWZBDEiIiSdvXCat((object) p1), EntityFormData.\u003C\u003Ec__DisplayClass7_0.P8SP0uZBt0bt6udZCkjJ((object) propertyItem))));
        if (p != null)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          PropertyFormItemData propertyFormItemData = new PropertyFormItemData()
          {
            Name = p.Name,
            DisplayName = !string.IsNullOrEmpty(propertyItem.Attributes.LocalizableName) ? propertyItem.Attributes.LocalizableName : p.DisplayName,
            Description = propertyItem.Attributes.LocalizableDescription ?? p.Description,
            TypeUid = p.TypeUid,
            SubTypeUid = EntityFormData.ProcessSubTypeUid(p.SubTypeUid),
            Settings = p.Settings,
            Required = propertyItem.Attributes.Required,
            ReadOnly = propertyItem.IsReadOnly(),
            Visible = propertyItem.Attributes.Visible,
            CustomView = !string.IsNullOrWhiteSpace(propertyItem.CustomViewName) || ComponentManager.Current.GetExtensionPoints<IPropertyCustomView>().Any<IPropertyCustomView>((Func<IPropertyCustomView, bool>) (pcv => EntityFormData.\u003C\u003Ec__DisplayClass7_1.ENvX23ZBx2dG8c5nbGtD((object) pcv, (object) p, EntityFormData.\u003C\u003Ec__DisplayClass7_1.OVZtbtZB7rvi1d2MSppK((object) propertyItem)))),
            HideEmpty = propertyItem.IsHideEmpty((RootViewItem) null)
          };
          PropertyMetadata propertyMetadata = p as PropertyMetadata;
          if (providers != null && propertyMetadata != null && propertyMetadata.Settings is EntitySettings)
          {
            foreach (IEntityFilterProvider provider in providers)
            {
              string filterProviderData = provider.GetFilterProviderData(type, propertyMetadata, propertyItem.Attributes);
              if (filterProviderData != null)
              {
                propertyFormItemData.FilterProviderUid = provider.ProviderUid;
                propertyFormItemData.FilterProviderData = filterProviderData;
                break;
              }
            }
          }
          items.Add(propertyFormItemData);
          if (p is ITablePartMetadata)
          {
            Type typeByUidOrNull = ((IMetadataRuntimeService) metadataService).GetTypeByUidOrNull(p.Uid);
            if (typeByUidOrNull != (Type) null)
              propertyFormItemData.Items = EntityFormData.CreateItems(typeByUidOrNull, (object) propertyItem, metadataService, providers);
          }
          else if (propertyItem.Items.Count > 0)
          {
            Guid uid = p.SubTypeUid != Guid.Empty ? p.SubTypeUid : p.TypeUid;
            Type typeByUidOrNull = ((IMetadataRuntimeService) metadataService).GetTypeByUidOrNull(uid);
            if (typeByUidOrNull != (Type) null)
              propertyFormItemData.Items = EntityFormData.CreateItems(typeByUidOrNull, (object) propertyItem, metadataService, providers);
          }
        }
      }
      return items;
    }

    public static void GetDescriptor(TypeSerializationDescriptorBuilder builder)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            builder.ItemWithDescriptor((string) EntityFormData.Names.Items, (Action<TypeSerializationDescriptorBuilder>) (i =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ((TypeSerializationDescriptorBuilder) EntityFormData.\u003C\u003Ec.KUI443ZBd6hQRV7T666y((object) i, EntityFormData.\u003C\u003Ec.SXpF6vZB9frrgcATsTUb(EntityFormData.\u003C\u003Ec.ULE5L4ZBJStk8waiBMEH(-2138958856 ^ -2138832118)))).IsArray(new Action<TypeSerializationDescriptorBuilder>(PropertyFormItemData.GetDescriptor));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public WebData ToWebData()
    {
      int num = 3;
      Dictionary<string, object> dicObj;
      while (true)
      {
        switch (num)
        {
          case 2:
            if (this.Items == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 3:
            dicObj = new Dictionary<string, object>();
            num = 2;
            continue;
          case 4:
            dicObj[(string) EntityFormData.Names.Items] = (object) new SerializableList<object>((IEnumerable<object>) this.Items.Select<PropertyFormItemData, WebData>((Func<PropertyFormItemData, WebData>) (fi => fi.ToWebData())));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return new WebData((IDictionary<string, object>) dicObj);
    }

    internal static void g9wDkDf14YLHP13ENw9B() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool tik3ref1tqLk8mDRgJZ9() => EntityFormData.K1dGZOf1DAP0lXQOCcKs == null;

    internal static EntityFormData XbGC02f1wsiMgFUtJQnR() => EntityFormData.K1dGZOf1DAP0lXQOCcKs;

    internal static object ceiXQpf16xWDmE2pcHOY() => (object) ComponentManager.Current;

    internal static bool l3yXjuf1Hpa8JKdSjYIW([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static Guid j2nMiqf1ACBonPDk7H3I([In] object obj0) => ((IMetadata) obj0).Uid;

    private static class Names
    {
      public static readonly object Items;
      internal static object TbPwctZB2LOcgEXGCrpr;

      static Names()
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EntityFormData.Names.Items = (object) LinqUtils.NameOf<EntityFormData>((Expression<Func<EntityFormData, object>>) (parameterExpression => parameterExpression.Items));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: type reference
              ParameterExpression parameterExpression1 = Expression.Parameter(EntityFormData.Names.x4TQHSZB1ALBCchopEF3(__typeref (EntityFormData)), (string) EntityFormData.Names.Avk3BPZBNFsLc3781fDO(2045296739 + 1688595713 ^ -561096460));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
              continue;
            case 3:
              TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return;
label_6:;
      }

      internal static Type x4TQHSZB1ALBCchopEF3([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static object Avk3BPZBNFsLc3781fDO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool z5mo9ZZBe0kXKorwGlyZ() => EntityFormData.Names.TbPwctZB2LOcgEXGCrpr == null;

      internal static EntityFormData.Names bAip6PZBPFCmJsgfhUJ5() => (EntityFormData.Names) EntityFormData.Names.TbPwctZB2LOcgEXGCrpr;
    }
  }
}
