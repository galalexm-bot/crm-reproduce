// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.DefaultContainerViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views.Toolbox;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Контейнер для свойств по умолчанию</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_DefaultContainerViewItem), "DisplayName")]
  [Serializable]
  public class DefaultContainerViewItem : ViewItem
  {
    public static readonly Guid ItemUid;
    private static DefaultContainerViewItem tVYkIao2obZffZfq2TZM;

    public override Guid Uid
    {
      get => DefaultContainerViewItem.ItemUid;
      set
      {
      }
    }

    /// <summary>
    /// С какой колонки начать добавлять свойства, если данный шаблон является контейнером по умолчанию
    /// </summary>
    [DefaultValue(0)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public int StartColumnIndex
    {
      get => this.\u003CStartColumnIndex\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CStartColumnIndex\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
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

    [DefaultValue(false)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public bool ReadOnly
    {
      get => this.\u003CReadOnly\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CReadOnly\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
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

    [DefaultValue(false)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public bool OnlyUserProperties
    {
      get => this.\u003COnlyUserProperties\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003COnlyUserProperties\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
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

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(parentViewItem is FormViewItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_6;
          default:
            if (!(parentViewItem is ColumnsLayoutViewItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 2 : 1;
              continue;
            }
            goto label_7;
        }
      }
label_6:
      return parentViewItem is ColumnViewItem;
label_7:
      return true;
    }

    public override bool IsChildValid(ViewItem childViewItem) => false;

    private List<PropertyViewItem> GetProperties(
      ClassMetadata metadata,
      ViewType viewType,
      ItemType itemType,
      RootViewItem parentViewItem = null,
      Func<IPropertyMetadata, bool> propertieFilter = null,
      List<Guid> existsProperties = null)
    {
      List<IPropertyMetadata> source = metadata is IEntityMetadata entityMetadata ? entityMetadata.GetPropertiesAndTableParts().ToList<IPropertyMetadata>() : metadata.Properties.Cast<IPropertyMetadata>().ToList<IPropertyMetadata>();
      // ISSUE: reference to a compiler-generated method
      IPropertyMetadata propertyMetadata = source.FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p => p.Uid == DefaultContainerViewItem.\u003C\u003Ec__DisplayClass19_0.y6Yok3CfesL74FC3ZjqW((object) metadata)));
      if (propertyMetadata != null && metadata.TitlePropertyUid != Guid.Empty && source.IndexOf(propertyMetadata) > 0)
      {
        source.Remove(propertyMetadata);
        source.Insert(0, propertyMetadata);
      }
      return source.Where<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (p =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (propertieFilter == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return propertieFilter(p);
label_5:
        return true;
      })).Select(p =>
      {
        PropertyViewSettings viewSettings = p is PropertyMetadata ? (p as PropertyMetadata).ViewSettings : (PropertyViewSettings) null;
        if (viewSettings == null)
        {
          TablePartMetadata tablePart = p as TablePartMetadata;
          // ISSUE: reference to a compiler-generated method
          if (tablePart != null && tablePart.IsActivePermissionMetadata() && tablePart.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (a => DefaultContainerViewItem.\u003C\u003Ec__DisplayClass19_1.ol8SUUCf322F6mq5qPPh(a.Uid, tablePart.ParentPropertyUid))) != null)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            viewSettings = tablePart.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (a => DefaultContainerViewItem.\u003C\u003Ec__DisplayClass19_1.ol8SUUCf322F6mq5qPPh(DefaultContainerViewItem.\u003C\u003Ec__DisplayClass19_1.RHyfDdCfpsi0eBW9SrEx((object) a), tablePart.ParentPropertyUid))).ViewSettings;
          }
        }
        ViewAttribute forView = viewSettings?.GetForView(viewType, itemType);
        // ISSUE: object of a compiler-generated type is created
        return new \u003C\u003Ef__AnonymousType13<IPropertyMetadata, Guid, bool, bool>(p, p.PropertyUid, forView == null || forView.Visible, this.ReadOnly || (forView != null ? forView.ReadOnly : viewType == ViewType.Display));
      }).Where(p =>
      {
        if (!p.Visible)
          return false;
        return existsProperties == null || !existsProperties.Contains(p.PropertyUid);
      }).Select(p =>
      {
        PropertyViewItem properties = new PropertyViewItem()
        {
          Uid = p.PropertyUid,
          PropertyUid = p.PropertyUid,
          Parent = parentViewItem,
          Attributes = {
            ReadOnly = new bool?(p.ReadOnly)
          }
        };
        if (p.Property is ITablePartMetadata property2)
          this.GetProperties((ClassMetadata) property2, viewType, itemType, parentViewItem).Each<PropertyViewItem>(new Action<PropertyViewItem>(((EventedList<ViewItem>) properties.Items).Add));
        return properties;
      }).ToList<PropertyViewItem>();
    }

    public bool CheckOnlySystemProperties(ClassMetadata metadata, ViewType viewType)
    {
      int num = 1;
      DefaultContainerViewItem containerViewItem;
      ViewType viewType1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            viewType1 = viewType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 2;
            continue;
          default:
            containerViewItem = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 3 : 3;
            continue;
        }
      }
label_4:
      return MetadataLoader.GetBaseClassMetadataList(metadata, true).Any<ClassMetadata>((Func<ClassMetadata, bool>) (md => containerViewItem.VisibleSystemProperties(md, viewType1)));
    }

    private bool VisibleSystemProperties(ClassMetadata metadata, ViewType viewType)
    {
      int num1 = 3;
      ViewType viewType1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            viewType1 = viewType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            goto label_7;
          default:
            if (metadata is EntityMetadata)
            {
              num1 = 4;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      List<IPropertyMetadata> list = metadata.Properties.Cast<IPropertyMetadata>().ToList<IPropertyMetadata>();
      goto label_8;
label_7:
      list = ((EntityMetadata) metadata).GetPropertiesAndTableParts().ToList<IPropertyMetadata>();
label_8:
      Func<IPropertyMetadata, bool> predicate = (Func<IPropertyMetadata, bool>) (property =>
      {
        int num2 = 4;
        ViewAttribute viewAttribute;
        while (true)
        {
          PropertyViewSettings propertyViewSettings1;
          PropertyViewSettings propertyViewSettings2;
          object obj;
          switch (num2)
          {
            case 1:
              obj = (object) null;
              goto label_15;
            case 2:
              if (viewAttribute != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 6 : 5;
                continue;
              }
              goto label_3;
            case 3:
              propertyViewSettings2 = (property as PropertyMetadata).ViewSettings;
              break;
            case 4:
              if (property is PropertyMetadata)
              {
                num2 = 3;
                continue;
              }
              goto default;
            case 5:
              if (propertyViewSettings1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
                continue;
              }
              // ISSUE: reference to a compiler-generated method
              obj = DefaultContainerViewItem.\u003C\u003Ec__DisplayClass21_0.bK6JkCCf7XQpwR1fv5C3((object) propertyViewSettings1, viewType1);
              goto label_15;
            case 6:
              goto label_2;
            default:
              propertyViewSettings2 = (PropertyViewSettings) null;
              break;
          }
          propertyViewSettings1 = propertyViewSettings2;
          num2 = 5;
          continue;
label_15:
          viewAttribute = (ViewAttribute) obj;
          num2 = 2;
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return DefaultContainerViewItem.\u003C\u003Ec__DisplayClass21_0.GIigaLCfxRGf85IsNgMq((object) viewAttribute);
label_3:
        return true;
      });
      return list.Where<IPropertyMetadata>(predicate).Any<IPropertyMetadata>();
    }

    public virtual IEnumerable<PropertyViewItem> NotIncludedProperies(
      FormViewItem formViewItem,
      ViewType viewType,
      ItemType itemType,
      object entity,
      RootViewItem parentViewItem)
    {
      ClassMetadata metadata = formViewItem.MetadataUid.HasValue ? MetadataLoader.LoadMetadata(formViewItem.MetadataUid.Value) as ClassMetadata : (ClassMetadata) null;
      if (metadata == null)
        return (IEnumerable<PropertyViewItem>) new PropertyViewItem[0];
      string name = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539261445), (object) formViewItem.MetadataUid, (object) formViewItem.Uid, (object) viewType);
      return (IEnumerable<PropertyViewItem>) Locator.GetServiceNotNull<IContextBoundVariableService>().GetOrAdd<List<PropertyViewItem>>(name, (Func<List<PropertyViewItem>>) (() =>
      {
        Func<IPropertyMetadata, bool> propertieFilter = (Func<IPropertyMetadata, bool>) null;
        if (this.OnlyUserProperties)
        {
          IMetadataRuntimeService mdRuntime = Locator.GetServiceNotNull<IMetadataRuntimeService>();
          propertieFilter = (Func<IPropertyMetadata, bool>) (propertyMetadata =>
          {
            int num4 = 8;
            TablePartMetadata tablePartMetadata;
            EntityMetadata entityMetadata;
            IPropertyMetadata propertyMetadata2;
            while (true)
            {
              int num5 = num4;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    if (tablePartMetadata == null)
                    {
                      num5 = 3;
                      continue;
                    }
                    goto label_4;
                  case 2:
                    goto label_4;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    if (DefaultContainerViewItem.\u003C\u003Ec__DisplayClass22_1.DfVrRsCfg5byxDWNHtar((object) propertyMetadata2) == (Type) null)
                    {
                      num5 = 4;
                      continue;
                    }
                    // ISSUE: reference to a compiler-generated method
                    entityMetadata = MetadataLoader.LoadMetadata(DefaultContainerViewItem.\u003C\u003Ec__DisplayClass22_1.DfVrRsCfg5byxDWNHtar((object) propertyMetadata2)) as EntityMetadata;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                    continue;
                  case 4:
                    goto label_15;
                  case 5:
                    tablePartMetadata = propertyMetadata2 as TablePartMetadata;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
                    continue;
                  case 6:
                    goto label_17;
                  case 7:
                    propertyMetadata2 = propertyMetadata;
                    num5 = 5;
                    continue;
                  case 8:
                    goto label_3;
                  case 9:
                    if (entityMetadata.ImplementedExtensionUids != null)
                    {
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 6 : 4;
                      continue;
                    }
                    goto label_20;
                  default:
                    if (entityMetadata != null)
                    {
                      num5 = 9;
                      continue;
                    }
                    goto label_20;
                }
              }
label_3:
              num4 = 7;
            }
label_4:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return DefaultContainerViewItem.\u003C\u003Ec__DisplayClass22_1.I3EPftCfrXkebZbg6GF5(DefaultContainerViewItem.\u003C\u003Ec__DisplayClass22_1.tCMOcvCfl1Wc1USiOgxm((object) tablePartMetadata));
label_15:
            return false;
label_17:
            List<Guid> implementedExtensionUids = entityMetadata.ImplementedExtensionUids;
            // ISSUE: reference to a compiler-generated field
            Func<Guid, bool> func = DefaultContainerViewItem.\u003C\u003Ec.\u003C\u003E9__22_3;
            Func<Guid, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              DefaultContainerViewItem.\u003C\u003Ec.\u003C\u003E9__22_3 = predicate = (Func<Guid, bool>) (extensionUid => DefaultContainerViewItem.\u003C\u003Ec.PoAFVMCQhLlwMmJSKIOI(extensionUid));
            }
            else
              goto label_21;
label_19:
            return implementedExtensionUids.Where<Guid>(predicate).Select<Guid, Type>((Func<Guid, Type>) (extensionUid => mdRuntime.GetTypeByUid(extensionUid, false))).Any<Type>((Func<Type, bool>) (extType =>
            {
              int num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (DefaultContainerViewItem.\u003C\u003Ec__DisplayClass22_2.SAiiEPCfU8ofAiMxuQGp(extType, (Type) null))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_5;
                  default:
                    goto label_4;
                }
              }
label_4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return ((IEnumerable<PropertyInfo>) DefaultContainerViewItem.\u003C\u003Ec__DisplayClass22_2.EyFqtFCfsB4ppjYstj6h(extType)).Any<PropertyInfo>((Func<PropertyInfo, bool>) (p => DefaultContainerViewItem.\u003C\u003Ec__DisplayClass22_2.MFMpQbCQFjbQXKhVn4Eo(DefaultContainerViewItem.\u003C\u003Ec__DisplayClass22_2.qy9sLLCfc2NUpttrtMW7((object) p), DefaultContainerViewItem.\u003C\u003Ec__DisplayClass22_2.I8rEyaCfzvry6I9cRXsJ((object) propertyMetadata2))));
label_5:
              return false;
            }));
label_21:
            predicate = func;
            goto label_19;
label_20:
            return false;
          });
        }
        // ISSUE: reference to a compiler-generated method
        return this.GetProperties(metadata, viewType, itemType, parentViewItem, propertieFilter, formViewItem.GetAllItems(false).OfType<PropertyViewItem>().Select<PropertyViewItem, Guid>((Func<PropertyViewItem, Guid>) (p => DefaultContainerViewItem.\u003C\u003Ec.IJr2w8CQGnhd7AFk60KF((object) p))).ToList<Guid>());
      }));
    }

    public virtual IEnumerable<PropertyViewItem> NotIncludedProperies(
      FormViewItem formViewItem,
      ViewType viewType,
      ItemType itemType,
      object entity)
    {
      return this.NotIncludedProperies(formViewItem, viewType, itemType, entity, (RootViewItem) null);
    }

    public virtual FormViewItemTransformation Transformation(
      FormViewItem formViewItem,
      ViewType viewType,
      ItemType itemType,
      object entity)
    {
      int num1 = 11;
      // ISSUE: variable of a compiler-generated type
      DefaultContainerViewItem.\u003C\u003Ec__DisplayClass24_0 cDisplayClass240;
      while (true)
      {
        int num2 = num1;
        ColumnViewItem columnViewItem1;
        // ISSUE: variable of a compiler-generated type
        DefaultContainerViewItem.\u003C\u003Ec__DisplayClass24_1 cDisplayClass241;
        ColumnViewItem columnViewItem2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              if (this.Parent is ColumnViewItem)
              {
                num2 = 17;
                continue;
              }
              goto case 25;
            case 3:
            case 20:
              goto label_14;
            case 4:
              goto label_9;
            case 5:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass241 = new DefaultContainerViewItem.\u003C\u003Ec__DisplayClass24_1();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 14 : 22;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass241.CS\u0024\u003C\u003E8__locals1.transformation.Items.Add((ViewItemTransformation) ViewItemTransformation.Add(cDisplayClass241.CS\u0024\u003C\u003E8__locals1.parent, (ViewItem) columnViewItem2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 7 : 1;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass241.columns.Add(columnViewItem2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 14 : 7;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass240.transformation.Items.Add((ViewItemTransformation) DefaultContainerViewItem.it4F37o2fRII4TWMdAAt(this.Uid));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 6 : 16;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass240.prevItem = new Guid?(DefaultContainerViewItem.OSCm5xo2EnW3loUPiXVp((object) this));
              num2 = 8;
              continue;
            case 10:
              if (!DefaultContainerViewItem.uRYaISo2GlfRkh57IXnk((object) this))
              {
                // ISSUE: reference to a compiler-generated field
                cDisplayClass240.transformation = new FormViewItemTransformation();
                num2 = 18;
                continue;
              }
              num2 = 4;
              continue;
            case 11:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass240 = new DefaultContainerViewItem.\u003C\u003Ec__DisplayClass24_0();
              num2 = 10;
              continue;
            case 12:
              // ISSUE: reference to a compiler-generated field
              if (DefaultContainerViewItem.LIDhhco2CplrKN1HlohW((object) cDisplayClass241.columns) == 0)
              {
                num2 = 15;
                continue;
              }
              goto case 14;
            case 13:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass240.transformation.Items.Add((ViewItemTransformation) ViewItemTransformation.Add(cDisplayClass240.parent, (ViewItem) columnViewItem1, cDisplayClass240.prevItem));
              num2 = 19;
              continue;
            case 14:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass241.startColumnIndex = this.StartColumnIndex;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
              continue;
            case 15:
              ColumnViewItem columnViewItem3 = new ColumnViewItem();
              columnViewItem3.Uid = DefaultContainerViewItem.FrR16Do2vDCQNavbMYEX();
              columnViewItem2 = columnViewItem3;
              num2 = 6;
              continue;
            case 16:
              if (!(this.Parent is ColumnsLayoutViewItem))
              {
                num2 = 2;
                continue;
              }
              goto case 5;
            case 17:
            case 21:
              // ISSUE: reference to a compiler-generated method
              this.NotIncludedProperies(formViewItem, viewType, itemType, entity, this.Parent).Each<PropertyViewItem>(new Action<PropertyViewItem>(cDisplayClass240.\u003CTransformation\u003Eb__0));
              num2 = 20;
              continue;
            case 18:
              goto label_23;
            case 19:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass240.parent = DefaultContainerViewItem.OSCm5xo2EnW3loUPiXVp((object) columnViewItem1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 19 : 23;
              continue;
            case 22:
              goto label_15;
            case 23:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass240.prevItem = new Guid?();
              num2 = 21;
              continue;
            case 24:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              cDisplayClass241.columns = ((IEnumerable<ViewItem>) DefaultContainerViewItem.Rjr8Eto2QUBWWZVKTwYW((object) this.Parent)).Where<ViewItem>((Func<ViewItem, bool>) (i => !DefaultContainerViewItem.\u003C\u003Ec.wO996cCQEmuZrhjulmRl((object) i))).OfType<ColumnViewItem>().ToList<ColumnViewItem>();
              num2 = 12;
              continue;
            case 25:
              ColumnViewItem columnViewItem4 = new ColumnViewItem();
              DefaultContainerViewItem.hb1o7Do28n42pjQFt95i((object) columnViewItem4, DefaultContainerViewItem.FrR16Do2vDCQNavbMYEX());
              columnViewItem1 = columnViewItem4;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 13 : 8;
              continue;
            default:
              // ISSUE: reference to a compiler-generated method
              this.NotIncludedProperies(formViewItem, viewType, itemType, entity, this.Parent).Each<PropertyViewItem>(new Action<PropertyViewItem, int>(cDisplayClass241.\u003CTransformation\u003Eb__2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 3 : 3;
              continue;
          }
        }
label_15:
        // ISSUE: reference to a compiler-generated field
        cDisplayClass241.CS\u0024\u003C\u003E8__locals1 = cDisplayClass240;
        num1 = 24;
        continue;
label_23:
        // ISSUE: reference to a compiler-generated field
        cDisplayClass240.parent = DefaultContainerViewItem.OSCm5xo2EnW3loUPiXVp((object) this.Parent);
        num1 = 9;
      }
label_9:
      return (FormViewItemTransformation) null;
label_14:
      // ISSUE: reference to a compiler-generated field
      return cDisplayClass240.transformation;
    }

    public virtual int CheckPropertyAddOrder => int.MaxValue;

    /// <summary>
    /// Проверить, что в указанный контейнер можно поместить свойства из переданных метаданных
    /// </summary>
    /// <param name="metadata"></param>
    /// <returns></returns>
    public virtual bool CheckPropertyAdd(ClassMetadata metadata)
    {
      int num1 = 12;
      while (true)
      {
        IMetadataService serviceOrNull;
        Guid? metadataUid;
        Guid guid;
        int num2;
        switch (num1)
        {
          case 1:
          case 3:
            if (metadata != null)
            {
              num1 = 4;
              continue;
            }
            goto label_9;
          case 2:
            if (serviceOrNull != null)
            {
              num1 = 3;
              continue;
            }
            goto label_5;
          case 4:
            guid = DefaultContainerViewItem.lu04HFo2ZpOC71v4julu((object) metadata);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 9 : 1;
            continue;
          case 5:
            num2 = 0;
            break;
          case 6:
            num2 = DefaultContainerViewItem.AiFCdmo2uq6FdqxsT4Cb(guid, metadataUid.GetValueOrDefault()) ? 1 : 0;
            break;
          case 7:
            goto label_5;
          case 8:
            goto label_9;
          case 9:
            metadataUid = this.FormViewItem.MetadataUid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
            continue;
          case 10:
            goto label_2;
          case 11:
            if (metadataUid.HasValue)
            {
              serviceOrNull = MetadataServiceContext.ServiceOrNull;
              num1 = 2;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 9 : 10;
            continue;
          case 12:
            metadataUid = this.FormViewItem.MetadataUid;
            num1 = 11;
            continue;
          case 13:
            goto label_14;
          default:
            if (metadataUid.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 6 : 2;
              continue;
            }
            goto case 5;
        }
        if (num2 == 0)
        {
          metadata = serviceOrNull.GetMetadata(DefaultContainerViewItem.DhNT5Jo2IEIIkAjVoAEw((object) metadata)) as ClassMetadata;
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 1;
        }
        else
          num1 = 13;
      }
label_2:
      return true;
label_5:
      return true;
label_9:
      return false;
label_14:
      return true;
    }

    public virtual PropertyViewItem CreatePropertyViewItem() => new PropertyViewItem();

    public DefaultContainerViewItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DefaultContainerViewItem()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DefaultContainerViewItem.YS0TxHo2VotWaipJf47a();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            DefaultContainerViewItem.ItemUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813498147));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool afmXPWo2bRTqFjmmgDCB() => DefaultContainerViewItem.tVYkIao2obZffZfq2TZM == null;

    internal static DefaultContainerViewItem gD0iJjo2hZ3UbCcjScJB() => DefaultContainerViewItem.tVYkIao2obZffZfq2TZM;

    internal static bool uRYaISo2GlfRkh57IXnk([In] object obj0) => ((ViewItem) obj0).Hide;

    internal static Guid OSCm5xo2EnW3loUPiXVp([In] object obj0) => ((ViewItem) obj0).Uid;

    internal static object it4F37o2fRII4TWMdAAt(Guid itemUid) => (object) ViewItemTransformation.Hide(itemUid);

    internal static object Rjr8Eto2QUBWWZVKTwYW([In] object obj0) => (object) ((RootViewItem) obj0).Items;

    internal static int LIDhhco2CplrKN1HlohW([In] object obj0) => ((List<ColumnViewItem>) obj0).Count;

    internal static Guid FrR16Do2vDCQNavbMYEX() => Guid.NewGuid();

    internal static void hb1o7Do28n42pjQFt95i([In] object obj0, Guid value) => ((ViewItem) obj0).Uid = value;

    internal static Guid lu04HFo2ZpOC71v4julu([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool AiFCdmo2uq6FdqxsT4Cb([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid DhNT5Jo2IEIIkAjVoAEw([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static void YS0TxHo2VotWaipJf47a() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class ToolboxItem : AdditionalViewItemToolboxItem<DefaultContainerViewItem>
    {
      private static object eWY3WoCfKD66T6h1DIoM;

      public override bool IsAvailable(IMetadata metadata) => !(metadata is FormContextMetadata);

      public ToolboxItem()
      {
        DefaultContainerViewItem.ToolboxItem.nnjhFjCfkrRknJg5Zc2W();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool lGnrYPCfX655vPXcxWPg() => DefaultContainerViewItem.ToolboxItem.eWY3WoCfKD66T6h1DIoM == null;

      internal static DefaultContainerViewItem.ToolboxItem pGgnUmCfTf0TKV6wRl5O() => (DefaultContainerViewItem.ToolboxItem) DefaultContainerViewItem.ToolboxItem.eWY3WoCfKD66T6h1DIoM;

      internal static void nnjhFjCfkrRknJg5Zc2W() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
