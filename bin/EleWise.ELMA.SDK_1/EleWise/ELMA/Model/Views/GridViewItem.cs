// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.GridViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views.Toolbox;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Views
{
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_GridViewItem), "DisplayName")]
  [DebuggerTypeProxy(typeof (GridViewItem.DebugView))]
  [Serializable]
  public class GridViewItem : 
    RootViewItem,
    IHideEmptyViewItem,
    ICountViewItem,
    ISelectionItemViewItem
  {
    internal static GridViewItem Ix5hPEon2Pu4dvyjsMf8;

    public GridViewItem()
    {
      GridViewItem.U9dLl1on1DBk1XA1d6nh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            TableView tableView = new TableView();
            GridViewItem.nnIojwonphe3NpLitAWw((object) tableView, GridViewItem.lbVUsoon3alf2Lh605VY());
            GridViewItem.asS1qOona9isRUmwjEVP((object) tableView, ViewType.List);
            this.TableView = tableView;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
            continue;
          case 3:
            this.SortDescriptors = new List<TableViewSortDescriptor>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 2 : 2;
            continue;
          default:
            GridViewItem.Sap100onNjWrYN7rIgHO((object) this, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 3 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parentViewItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return GridViewItem.mBYXcRonD18kXfum4eRJ((object) parentViewItem, (object) this);
label_3:
      return true;
    }

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => childViewItem is IGridColumnViewItem;

    /// <summary>Настройки отображения таблицы</summary>
    [DefaultValue(null)]
    public TableView TableView
    {
      get => this.\u003CTableView\u003Ek__BackingField;
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
              this.\u003CTableView\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
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

    /// <summary>Тип сущности, которую нужно вывести</summary>
    [XmlElement("Entity")]
    public virtual Guid EntityUid
    {
      get => this.\u003CEntityUid\u003Ek__BackingField;
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
              this.\u003CEntityUid\u003Ek__BackingField = value;
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

    /// <summary>Свойство, по которому производится связь</summary>
    [XmlElement("Property")]
    [DefaultValue(null)]
    public virtual Guid? PropertyUid { get; set; }

    /// <summary>Свойство, по которому производится связь</summary>
    [DefaultValue(true)]
    public virtual bool ShowCount
    {
      get => this.\u003CShowCount\u003Ek__BackingField;
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
              this.\u003CShowCount\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
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

    /// <summary>EQL фильтр</summary>
    [DefaultValue(null)]
    public virtual string Query
    {
      get => this.\u003CQuery\u003Ek__BackingField;
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
              this.\u003CQuery\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
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

    /// <summary>Выбранные для отображения колонки</summary>
    [Obsolete("Use Items instead", false)]
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [XmlForceArray]
    public virtual Guid[] SelectedColumns
    {
      get => this.Items.OfType<GridPropertyColumnViewItem>().Select<GridPropertyColumnViewItem, Guid>((Func<GridPropertyColumnViewItem, Guid>) (p => GridViewItem.\u003C\u003Ec.PO5blbCfFmnLu6h169Rn((object) p))).ToArray<Guid>();
      set
      {
        int num1 = 2;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_2;
            case 1:
              ((IEnumerable<Guid>) value).Select<Guid, GridPropertyColumnViewItem>((Func<Guid, GridPropertyColumnViewItem>) (v =>
              {
                int num2 = 13;
                GridPropertyColumnViewItem propertyColumnViewItem1;
                while (true)
                {
                  int num3 = num2;
                  DynamicSlotViewItem parent;
                  PropertyValueViewItem propertyValueViewItem1;
                  PropertyCaptionViewItem propertyCaptionViewItem1;
                  Guid? propertyUid;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        PropertyCaptionViewItem propertyCaptionViewItem2 = new PropertyCaptionViewItem();
                        GridViewItem.plPFm5onyQs9Fa4pyBXI((object) propertyCaptionViewItem2, (object) new ViewAttributes());
                        propertyCaptionViewItem1 = propertyCaptionViewItem2;
                        num3 = 15;
                        continue;
                      case 2:
                      case 11:
                        goto label_16;
                      case 3:
                        List<Guid> propertyParents = propertyColumnViewItem1.PropertyParents;
                        propertyUid = this.PropertyUid;
                        Guid guid = propertyUid.Value;
                        propertyParents.Add(guid);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 4 : 4;
                        continue;
                      case 4:
                      case 20:
                      case 24:
                        parent = new DynamicSlotViewItem();
                        num3 = 5;
                        continue;
                      case 5:
                        GridViewItem.SsCH7Bon0ddb1dhT3E8W((object) parent, (object) propertyColumnViewItem1);
                        num3 = 8;
                        continue;
                      case 6:
                        propertyValueViewItem1.PropertyParents.AddRange((IEnumerable<Guid>) propertyColumnViewItem1.PropertyParents);
                        num3 = 19;
                        continue;
                      case 7:
                        propertyUid = this.PropertyUid;
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                        continue;
                      case 8:
                        GridViewItem.Y37qc9onmVsk5eyPONIG((object) parent, GridPropertyColumnViewItem.ContentSlotUid);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 14 : 0;
                        continue;
                      case 9:
                        goto label_11;
                      case 10:
                        GridViewItem.BVuIgBonlH4cWgB0nYq5((object) propertyCaptionViewItem1.Attributes, false);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 9 : 11;
                        continue;
                      case 12:
                        GridViewItem.SsCH7Bon0ddb1dhT3E8W((object) propertyColumnViewItem1, (object) this);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 27 : 2;
                        continue;
                      case 13:
                        goto label_9;
                      case 14:
                        PropertyValueViewItem propertyValueViewItem2 = new PropertyValueViewItem();
                        GridViewItem.plPFm5onyQs9Fa4pyBXI((object) propertyValueViewItem2, (object) new ViewAttributes());
                        propertyValueViewItem1 = propertyValueViewItem2;
                        num3 = 22;
                        continue;
                      case 15:
                        GridViewItem.SsCH7Bon0ddb1dhT3E8W((object) propertyCaptionViewItem1, (object) propertyColumnViewItem1);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 4 : 25;
                        continue;
                      case 16:
                        propertyColumnViewItem1.Items.Add((ViewItem) propertyCaptionViewItem1);
                        num3 = 9;
                        continue;
                      case 17:
                        propertyCaptionViewItem1.PropertyParents.AddRange((IEnumerable<Guid>) propertyColumnViewItem1.PropertyParents);
                        num3 = 10;
                        continue;
                      case 18:
                        ((EventedList<ViewItem>) GridViewItem.eYJ7bdonMTjPdT9se6IR((object) parent)).Add((ViewItem) propertyValueViewItem1);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
                        continue;
                      case 19:
                        GridViewItem.Od5Pl9on9XfkU21PYnP7(GridViewItem.JVxqIconJmT1AnDlKIQF((object) propertyValueViewItem1), false);
                        num3 = 23;
                        continue;
                      case 21:
                        GridViewItem.WylZsbonxYrShKgtlJYL((object) propertyValueViewItem1, propertyColumnViewItem1.PropertyUid);
                        num3 = 6;
                        continue;
                      case 22:
                        propertyValueViewItem1.InitNew((ViewItem) parent);
                        num3 = 18;
                        continue;
                      case 23:
                        GridViewItem.WylZsbonxYrShKgtlJYL((object) propertyCaptionViewItem1, GridViewItem.HgcyHHondV7h0qgFmI39((object) propertyColumnViewItem1));
                        num3 = 17;
                        continue;
                      case 25:
                        if (GridViewItem.oQ58u2on7ApWiGVI0luC(v, Guid.Empty))
                          goto case 21;
                        else
                          goto label_4;
                      case 26:
                        propertyColumnViewItem1.PropertyParents.Add(GridViewItem.SQZcdJonwuYaooiTkjT8((object) this));
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 12 : 20;
                        continue;
                      case 27:
                        if (GridViewItem.oQ58u2on7ApWiGVI0luC(this.EntityUid, Guid.Empty))
                        {
                          num3 = 26;
                          continue;
                        }
                        goto case 7;
                      default:
                        if (!propertyUid.HasValue)
                        {
                          num3 = 24;
                          continue;
                        }
                        goto case 3;
                    }
                  }
label_4:
                  num2 = 2;
                  continue;
label_9:
                  GridPropertyColumnViewItem propertyColumnViewItem2 = new GridPropertyColumnViewItem();
                  GridViewItem.WylZsbonxYrShKgtlJYL((object) propertyColumnViewItem2, v);
                  propertyColumnViewItem1 = propertyColumnViewItem2;
                  num2 = 12;
                  continue;
label_16:
                  ((EventedList<ViewItem>) GridViewItem.eYJ7bdonMTjPdT9se6IR((object) propertyColumnViewItem1)).Add((ViewItem) parent);
                  num2 = 16;
                }
label_11:
                return propertyColumnViewItem1;
              })).ForEach<GridPropertyColumnViewItem>(new Action<GridPropertyColumnViewItem>(((EventedList<ViewItem>) this.Items).Add));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
              continue;
            case 2:
              GridViewItem.cgKGp2ontqFrVpLlV5ki((object) this.Items);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }
    }

    /// <summary>Сортировка по умолчанию</summary>
    public List<TableViewSortDescriptor> SortDescriptors { get; set; }

    /// <inheritdoc />
    public bool EnableSelection
    {
      get => this.\u003CEnableSelection\u003Ek__BackingField;
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
              this.\u003CEnableSelection\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
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
    public Guid SelectablePropertyUid
    {
      get => this.\u003CSelectablePropertyUid\u003Ek__BackingField;
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
              this.\u003CSelectablePropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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
    public List<Guid> SelectablePropertyParents { get; set; }

    public string GetFilterQuery(IEntity entity)
    {
      int num1 = 2;
      string str;
      string query;
      while (true)
      {
        switch (num1)
        {
          case 1:
            IEnumerable<PropertyMetadata> source = ((ClassMetadata) MetadataLoader.LoadMetadata(GridViewItem.SQZcdJonwuYaooiTkjT8((object) this))).Properties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
            {
              int num2 = 1;
              Guid guid;
              Guid? propertyUid;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    guid = GridViewItem.P30RXbonrS1rHHuPD93b((object) p);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    if (propertyUid.HasValue)
                    {
                      num2 = 3;
                      continue;
                    }
                    goto label_2;
                  case 3:
                    goto label_3;
                  case 4:
                    goto label_2;
                  default:
                    propertyUid = this.PropertyUid;
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 2;
                    continue;
                }
              }
label_2:
              return false;
label_3:
              return GridViewItem.FosY8iongtF2E8EJMZuH(guid, propertyUid.GetValueOrDefault());
            }));
            // ISSUE: reference to a compiler-generated field
            Func<PropertyMetadata, string> func = GridViewItem.\u003C\u003Ec.\u003C\u003E9__44_1;
            Func<PropertyMetadata, string> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              GridViewItem.\u003C\u003Ec.\u003C\u003E9__44_1 = selector = (Func<PropertyMetadata, string>) (p => (string) GridViewItem.\u003C\u003Ec.RBSehVCfoi3FOBbIvakv(GridViewItem.\u003C\u003Ec.M4nK6ICfBWBvGjkFl7lR((object) p), GridViewItem.\u003C\u003Ec.JXUHayCfW5XN6NtDRoxc(1917998801 >> 2 ^ 479268634)));
            }
            else
              goto label_11;
label_7:
            str = source.Select<PropertyMetadata, string>(selector).FirstOrDefault<string>();
            if (str == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
label_11:
            selector = func;
            goto label_7;
          case 2:
            query = this.Query;
            if (query == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
              continue;
            }
            goto label_12;
          default:
            goto label_9;
        }
      }
label_9:
      object template = GridViewItem.SadoXhon4bZIFAcaef8G(-2099751081 ^ -2099639939);
label_10:
      return (string) GridViewItem.Q8XKq2on6ZfavHl7sRUk((object) new TextTemplateGenerator((string) template), (object) entity);
label_12:
      template = (object) query;
      goto label_10;
label_2:
      template = (object) str;
      goto label_10;
    }

    public IEntityFilter GetFilter(IEntity entity)
    {
      Filter filter = new Filter();
      GridViewItem.lInO7AonHdcVEq6o4tLt((object) filter, (object) this.GetFilterQuery(entity));
      return (IEntityFilter) filter;
    }

    public override bool IsHideEmpty(RootViewItem parent = null)
    {
      int num = 2;
      RootViewItem rootViewItem1;
      while (true)
      {
        RootViewItem rootViewItem2;
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (this.HideEmptySettings != HideEmptyEnum.Inherit)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
              continue;
            }
            rootViewItem2 = parent;
            if (rootViewItem2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 3 : 1;
              continue;
            }
            break;
          case 3:
            rootViewItem2 = this.Parent;
            break;
          case 4:
            goto label_12;
          case 5:
label_2:
            rootViewItem1 = parent;
            if (rootViewItem1 == null)
            {
              num = 4;
              continue;
            }
            goto label_13;
          default:
            goto label_14;
        }
        if (rootViewItem2 == null)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
        else
          goto label_2;
      }
label_6:
      return this.HideEmptySettings == HideEmptyEnum.HideEmpty;
label_12:
      rootViewItem1 = this.Parent;
label_13:
      return rootViewItem1.IsHideEmpty((RootViewItem) null);
label_14:
      return false;
    }

    /// <inheritdoc />
    protected override IEnumerable<PropertyInfo> GetPropertiesForCopy() => base.GetPropertiesForCopy().Where<PropertyInfo>((Func<PropertyInfo, bool>) (p => GridViewItem.\u003C\u003Ec.GAFScACfhTBW43LbV09H(GridViewItem.\u003C\u003Ec.mMJ4IUCfbGKbkC0hfV7a((object) p), GridViewItem.\u003C\u003Ec.JXUHayCfW5XN6NtDRoxc(2045296739 + 1688595713 ^ -561301594))));

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.GridViewItem.SelectedColumns" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeSelectedColumns() => false;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.GridViewItem.SelectablePropertyParents" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeSelectablePropertyParents()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.SelectablePropertyParents == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return GridViewItem.q2BqsFonAd8rFq2CoaIL((object) this.SelectablePropertyParents) > 0;
label_5:
      return false;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Views.GridViewItem.SelectablePropertyUid" />
    /// </summary>
    /// <returns><c>true</c>, если нужно сериализовать</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeSelectablePropertyUid() => GridViewItem.oQ58u2on7ApWiGVI0luC(this.SelectablePropertyUid, Guid.Empty);

    internal static void U9dLl1on1DBk1XA1d6nh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void Sap100onNjWrYN7rIgHO([In] object obj0, bool value) => ((GridViewItem) obj0).ShowCount = value;

    internal static Guid lbVUsoon3alf2Lh605VY() => Guid.NewGuid();

    internal static void nnIojwonphe3NpLitAWw([In] object obj0, Guid value) => ((TableView) obj0).Uid = value;

    internal static void asS1qOona9isRUmwjEVP([In] object obj0, ViewType value) => ((TableView) obj0).ViewType = value;

    internal static bool qs6pQ4oneL5PJSPxLwHy() => GridViewItem.Ix5hPEon2Pu4dvyjsMf8 == null;

    internal static GridViewItem VqE2hEonPW3qQaW2nh4v() => GridViewItem.Ix5hPEon2Pu4dvyjsMf8;

    internal static bool mBYXcRonD18kXfum4eRJ([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static void cgKGp2ontqFrVpLlV5ki([In] object obj0) => ((EventedList<ViewItem>) obj0).Clear();

    internal static Guid SQZcdJonwuYaooiTkjT8([In] object obj0) => ((GridViewItem) obj0).EntityUid;

    internal static object SadoXhon4bZIFAcaef8G(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Q8XKq2on6ZfavHl7sRUk([In] object obj0, [In] object obj1) => (object) ((TextGenerator) obj0).Generate(obj1);

    internal static void lInO7AonHdcVEq6o4tLt([In] object obj0, [In] object obj1) => ((Filter) obj0).Query = (string) obj1;

    internal static int q2BqsFonAd8rFq2CoaIL([In] object obj0) => ((List<Guid>) obj0).Count;

    internal static bool oQ58u2on7ApWiGVI0luC([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static void WylZsbonxYrShKgtlJYL([In] object obj0, Guid value) => ((PropertyViewItem) obj0).PropertyUid = value;

    internal static void SsCH7Bon0ddb1dhT3E8W([In] object obj0, [In] object obj1) => ((ViewItem) obj0).InitNew((ViewItem) obj1);

    internal static void Y37qc9onmVsk5eyPONIG([In] object obj0, Guid value) => ((SlotViewItem) obj0).PlaceholderUid = value;

    internal static void plPFm5onyQs9Fa4pyBXI([In] object obj0, [In] object obj1) => ((PropertyViewItem) obj0).Attributes = (ViewAttributes) obj1;

    internal static object eYJ7bdonMTjPdT9se6IR([In] object obj0) => (object) ((RootViewItem) obj0).Items;

    internal static object JVxqIconJmT1AnDlKIQF([In] object obj0) => (object) ((PropertyViewItem) obj0).Attributes;

    internal static void Od5Pl9on9XfkU21PYnP7([In] object obj0, bool value) => ((ViewAttributes) obj0).ValidationMessage = value;

    internal static Guid HgcyHHondV7h0qgFmI39([In] object obj0) => ((PropertyViewItem) obj0).PropertyUid;

    internal static void BVuIgBonlH4cWgB0nYq5([In] object obj0, bool value) => ((ViewAttributes) obj0).Required = value;

    internal static Guid P30RXbonrS1rHHuPD93b([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool FosY8iongtF2E8EJMZuH([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    public new class DebugView
    {
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private readonly GridViewItem viewItem;
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private ClassMetadata entity;
      [DebuggerBrowsable(DebuggerBrowsableState.Never)]
      private IPropertyMetadata property;
      [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
      private readonly ViewItem.DebugView _viewItemDebugView;
      internal static GridViewItem.DebugView gTl6uLCEAJMkZRGkGvmf;

      public DebugView(GridViewItem viewItem)
      {
        GridViewItem.DebugView.oxIrf9CE0A0MOCuF4PbL();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this._viewItemDebugView = new ViewItem.DebugView((ViewItem) viewItem);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            default:
              this.viewItem = viewItem;
              num = 2;
              continue;
          }
        }
label_3:;
      }

      public bool ShowCount
      {
        get => GridViewItem.DebugView.gu4gIPCEmtHBtn1hDjHg((object) this.viewItem);
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
                GridViewItem.DebugView.nX06KGCEyCsG8gOh6bCV((object) this.viewItem, value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
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

      public string Query
      {
        get => (string) GridViewItem.DebugView.xgpVQJCEM2ZKyS8axjxX((object) this.viewItem);
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
                GridViewItem.DebugView.P4ucADCEJWxgopaJgoiO((object) this.viewItem, (object) value);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
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

      public Guid[] SelectedColumns => this.viewItem.SelectedColumns;

      public ClassMetadata Entity
      {
        get
        {
          int num = 1;
          ClassMetadata entity1;
          ClassMetadata entity2;
          while (true)
          {
            switch (num)
            {
              case 1:
                entity2 = this.entity;
                if (entity2 == null)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                  continue;
                }
                goto label_2;
              case 2:
                goto label_6;
              default:
                this.entity = entity1 = (ClassMetadata) MetadataLoader.LoadMetadata(GridViewItem.DebugView.Ry8eOhCE9R2Cvu0J9xUc((object) this.viewItem));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 2;
                continue;
            }
          }
label_2:
          return entity2;
label_6:
          return entity1;
        }
      }

      public IPropertyMetadata Property
      {
        get
        {
          int num1 = 4;
          while (true)
          {
            IEntityMetadata entity;
            Guid? propertyUid1;
            Guid guid1;
            int num2;
            Guid guid2;
            switch (num1)
            {
              case 1:
                if (this.property == null)
                {
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
                  continue;
                }
                goto label_6;
              case 2:
              case 10:
                goto label_6;
              case 3:
                goto label_13;
              case 4:
                if (this.Entity == null)
                {
                  num1 = 3;
                  continue;
                }
                if (this.property != null)
                {
                  num1 = 11;
                  continue;
                }
                goto case 14;
              case 5:
                if (entity != null)
                {
                  num1 = 9;
                  continue;
                }
                goto label_6;
              case 6:
                num2 = 1;
                goto label_25;
              case 7:
                if (!propertyUid1.HasValue)
                {
                  num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 6;
                  continue;
                }
                num2 = GridViewItem.DebugView.JjXujyCElC8hWongeKwu(guid1, propertyUid1.GetValueOrDefault()) ? 1 : 0;
                goto label_25;
              case 8:
                guid2 = GridViewItem.DebugView.Iq3X0NCEdSepPlqeHApQ((object) this.property);
                break;
              case 9:
                this.property = (IPropertyMetadata) entity.GetPropertiesAndTableParts().OfType<ITablePartMetadata>().FirstOrDefault<ITablePartMetadata>((Func<ITablePartMetadata, bool>) (tp =>
                {
                  int num3 = 2;
                  Guid? propertyUid2;
                  Guid tablePartPropertyUid;
                  while (true)
                  {
                    int num4 = num3;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          goto label_3;
                        case 2:
                          tablePartPropertyUid = tp.TablePartPropertyUid;
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 1;
                          continue;
                        case 3:
                          if (!propertyUid2.HasValue)
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                            continue;
                          }
                          goto label_6;
                        default:
                          goto label_5;
                      }
                    }
label_3:
                    propertyUid2 = this.viewItem.PropertyUid;
                    num3 = 3;
                  }
label_5:
                  return false;
label_6:
                  return GridViewItem.DebugView.x4VpTSCErcRS3TZatHqL(tablePartPropertyUid, propertyUid2.GetValueOrDefault());
                }));
                num1 = 2;
                continue;
              case 11:
                if (this.property is ITablePartMetadata)
                {
                  num1 = 13;
                  continue;
                }
                goto case 8;
              case 12:
                propertyUid1 = this.viewItem.PropertyUid;
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 7 : 2;
                continue;
              case 13:
                guid2 = ((ITablePartMetadata) this.property).TablePartPropertyUid;
                break;
              case 14:
label_20:
                this.property = (IPropertyMetadata) this.Entity.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
                {
                  int num5 = 3;
                  Guid uid;
                  Guid? propertyUid3;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        goto label_4;
                      case 2:
                        propertyUid3 = this.viewItem.PropertyUid;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
                        continue;
                      case 3:
                        uid = p.Uid;
                        num5 = 2;
                        continue;
                      default:
                        if (!propertyUid3.HasValue)
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
                          continue;
                        }
                        goto label_5;
                    }
                  }
label_4:
                  return false;
label_5:
                  return GridViewItem.DebugView.x4VpTSCErcRS3TZatHqL(uid, propertyUid3.GetValueOrDefault());
                }));
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
                continue;
              default:
                entity = this.Entity as IEntityMetadata;
                num1 = 5;
                continue;
            }
            guid1 = guid2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 12 : 11;
            continue;
label_25:
            if (num2 == 0)
              num1 = 10;
            else
              goto label_20;
          }
label_6:
          return this.property;
label_13:
          return (IPropertyMetadata) null;
        }
      }

      internal static void oxIrf9CE0A0MOCuF4PbL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool pJnfptCE7ZpLiac0nx8A() => GridViewItem.DebugView.gTl6uLCEAJMkZRGkGvmf == null;

      internal static GridViewItem.DebugView jN3IgxCExVYOtd0yl15A() => GridViewItem.DebugView.gTl6uLCEAJMkZRGkGvmf;

      internal static bool gu4gIPCEmtHBtn1hDjHg([In] object obj0) => ((GridViewItem) obj0).ShowCount;

      internal static void nX06KGCEyCsG8gOh6bCV([In] object obj0, bool value) => ((GridViewItem) obj0).ShowCount = value;

      internal static object xgpVQJCEM2ZKyS8axjxX([In] object obj0) => (object) ((GridViewItem) obj0).Query;

      internal static void P4ucADCEJWxgopaJgoiO([In] object obj0, [In] object obj1) => ((GridViewItem) obj0).Query = (string) obj1;

      internal static Guid Ry8eOhCE9R2Cvu0J9xUc([In] object obj0) => ((GridViewItem) obj0).EntityUid;

      internal static Guid Iq3X0NCEdSepPlqeHApQ([In] object obj0) => ((IMetadata) obj0).Uid;

      internal static bool JjXujyCElC8hWongeKwu([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

      internal static bool x4VpTSCErcRS3TZatHqL([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
    }

    [Component(Order = 500)]
    private class ToolboxItem : CommonViewItemToolboxItem<GridViewItem>
    {
      internal static object gkJdJaCEguXvD0Niw7fI;

      public override string Name => EleWise.ELMA.SR.T((string) GridViewItem.ToolboxItem.voRtlQCEYE7BftmfJcQL(-680446928 - -370807692 ^ -309782036));

      public ToolboxItem()
      {
        GridViewItem.ToolboxItem.dYDLsnCEL8lNbw6ulsF8();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object voRtlQCEYE7BftmfJcQL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool QvjjsnCE5KTA2RAfxxGU() => GridViewItem.ToolboxItem.gkJdJaCEguXvD0Niw7fI == null;

      internal static GridViewItem.ToolboxItem PmAZOfCEjt8KstcVh7o2() => (GridViewItem.ToolboxItem) GridViewItem.ToolboxItem.gkJdJaCEguXvD0Niw7fI;

      internal static void dYDLsnCEL8lNbw6ulsF8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
