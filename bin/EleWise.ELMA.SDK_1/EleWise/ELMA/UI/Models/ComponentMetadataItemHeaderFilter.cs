// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.ComponentMetadataItemHeaderFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Фильтр для объекта "Заголовок метаданных компонента"</summary>
  [FilterFor(typeof (ComponentMetadataItemHeader))]
  public class ComponentMetadataItemHeaderFilter : Filter
  {
    private string _name;
    private string _displayName;
    private DateTimeRange _creationDate;
    private Guid? _metadataTypeUid;
    private bool? _isPublished;
    private static ComponentMetadataItemHeaderFilter MaUDTnBWwIVH2w14cXK3;

    public ComponentMetadataItemHeaderFilter()
    {
      ComponentMetadataItemHeaderFilter.AuJX7XBWHep45pNL7IV3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Фильтр для свойства "Наименование"</summary>
    public virtual string Name
    {
      get => this._name;
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
              this._name = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
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

    /// <summary>Фильтр для свойства "Отображаемое имя"</summary>
    public virtual string DisplayName
    {
      get => this._displayName;
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
              this._displayName = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
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

    /// <summary>Фильтр для свойства "Дата создания"</summary>
    public virtual DateTimeRange CreationDate
    {
      get => this._creationDate;
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
              this._creationDate = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
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

    /// <summary>Фильтр для свойства "Тип Компонента"</summary>
    public virtual Guid? MetadataTypeUid
    {
      get => this._metadataTypeUid;
      set => this._metadataTypeUid = value;
    }

    /// <summary>Опубликовано</summary>
    [View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
    [View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
    [View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
    [CanBeNull]
    [Uid("7a10d073-4547-4ed9-be4f-353e011edfe5")]
    [CustomFilterProperty]
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Опубликовано')")]
    [BoolSettings(FieldName = "IsPublished")]
    [Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
    public virtual bool? IsPublished
    {
      get => this._isPublished;
      set => this._isPublished = value;
    }

    internal static void AuJX7XBWHep45pNL7IV3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool cBSo95BW4ItKhDhAJrod() => ComponentMetadataItemHeaderFilter.MaUDTnBWwIVH2w14cXK3 == null;

    internal static ComponentMetadataItemHeaderFilter PuKPypBW6QGab8U2rQrF() => ComponentMetadataItemHeaderFilter.MaUDTnBWwIVH2w14cXK3;
  }
}
