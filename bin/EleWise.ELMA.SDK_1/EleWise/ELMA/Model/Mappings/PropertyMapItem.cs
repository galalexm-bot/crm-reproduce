// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.PropertyMapItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Mappings
{
  /// <summary>Элемент карты свойств</summary>
  [Serializable]
  public class PropertyMapItem : EntityDTO<long>
  {
    [OptionalField]
    private object _leftValue;
    [OptionalField]
    private object _rightValue;
    internal static PropertyMapItem is3M8hhb6T2BbimBPnmI;

    /// <summary>Левое свойство</summary>
    [XmlElement("LeftPropertyUid")]
    public virtual Guid LeftPropertyUid
    {
      get => this.\u003CLeftPropertyUid\u003Ek__BackingField;
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
              this.\u003CLeftPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
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

    /// <summary>Левое значение (константа)</summary>
    [XmlElement("LeftValue")]
    public virtual object LeftValue
    {
      get => this._leftValue;
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
              this._leftValue = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
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

    /// <summary>Правое свойство</summary>
    [XmlElement("RightPropertyUid")]
    public virtual Guid RightPropertyUid
    {
      get => this.\u003CRightPropertyUid\u003Ek__BackingField;
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
              this.\u003CRightPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
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

    /// <summary>Правое значение (константа)</summary>
    [XmlElement("RightValue")]
    public virtual object RightValue
    {
      get => this._rightValue;
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
              this._rightValue = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
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

    /// <summary>Список всех родителей данного свойства</summary>
    [XmlArray]
    public List<PropertyMetadata> ParentProperties { get; set; }

    /// <summary>
    /// Маркер, указывающий на то, что в свойство нужно сбиндить текущий объект
    /// </summary>
    [XmlElement("ThisMarker")]
    public virtual bool ThisMarker
    {
      get => this.\u003CThisMarker\u003Ek__BackingField;
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
              this.\u003CThisMarker\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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

    public PropertyMapItem()
    {
      PropertyMapItem.VmJjblhb7IXqRVxTYX8m();
      // ISSUE: reference to a compiler-generated field
      this.\u003CParentProperties\u003Ek__BackingField = new List<PropertyMetadata>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool upav7NhbHmXPBuIr8J1u() => PropertyMapItem.is3M8hhb6T2BbimBPnmI == null;

    internal static PropertyMapItem iEtyK0hbAD91lKkMkY6C() => PropertyMapItem.is3M8hhb6T2BbimBPnmI;

    internal static void VmJjblhb7IXqRVxTYX8m() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
