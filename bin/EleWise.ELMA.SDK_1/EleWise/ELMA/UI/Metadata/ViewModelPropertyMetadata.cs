// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.ViewModelPropertyMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Метаданные свойства модели отображения</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Свойство модели отображения')")]
  [DataContract]
  [EleWise.ELMA.Model.Attributes.Uid("{10A685EE-CCA1-4379-9A3C-A8294ADA90AB}")]
  [Serializable]
  public class ViewModelPropertyMetadata : 
    PropertyMetadata,
    IViewModelPropertyMetadata,
    IPropertyMetadata,
    INamedMetadata,
    IOrderedMetadata,
    IMetadata,
    IXsiType
  {
    /// <summary>Уникальный идентификатор</summary>
    public const string UidS = "{10A685EE-CCA1-4379-9A3C-A8294ADA90AB}";
    /// <summary>Префикс инпута</summary>
    public const string InputPrefix = "Input___";
    /// <summary>Префикс инпута</summary>
    public const string OutputPrefix = "Output___";
    internal static ViewModelPropertyMetadata pfr0C7BGFgwPK7HR6dpr;

    /// <summary>Ctor</summary>
    public ViewModelPropertyMetadata()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ComputedValues = new List<ComputedValue>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    [BoolSettings(FieldName = "ClientOnly")]
    [DefaultValue(false)]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [XmlElement("ClientOnly")]
    [EleWise.ELMA.Model.Attributes.Uid("{4289CACE-6470-4D03-B0E7-89CD59F02CC8}")]
    public virtual bool ClientOnly
    {
      get => this.\u003CClientOnly\u003Ek__BackingField;
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
              this.\u003CClientOnly\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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
    [DefaultValue(false)]
    [XmlElement("Input")]
    [BoolSettings(FieldName = "Input")]
    [EleWise.ELMA.Model.Attributes.Uid("{91E42246-1BA5-4233-9154-A953239BCD87}")]
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    public virtual bool Input
    {
      get => this.\u003CInput\u003Ek__BackingField;
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
              this.\u003CInput\u003Ek__BackingField = value;
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

    /// <inheritdoc />
    [Property("{9CD56A40-6192-4D8A-840C-C4BD4DFB88EB}")]
    [BoolSettings(FieldName = "Output")]
    [DefaultValue(false)]
    [EleWise.ELMA.Model.Attributes.Uid("{393AC91D-BF6A-419F-9D66-0CB7CE9626E3}")]
    [XmlElement("Output")]
    public virtual bool Output
    {
      get => this.\u003COutput\u003Ek__BackingField;
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
              this.\u003COutput\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
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
    [SimpleTypeSettings(FieldName = "ComputedValue")]
    [Property("{66C7898B-E56B-49E0-BFB8-9F9C4A7A0C52}")]
    [EleWise.ELMA.Model.Attributes.Uid("{7AC07C69-6EAD-4228-88D5-4E6BFD25B377}")]
    [XmlElement("ComputedValue")]
    public virtual ComputedValue ComputedValue
    {
      get => this.\u003CComputedValue\u003Ek__BackingField;
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
              this.\u003CComputedValue\u003Ek__BackingField = value;
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
    [EleWise.ELMA.Model.Attributes.Uid("{1BFBBF0B-E024-499E-80A1-CFB500250C4D}")]
    [Property("{5C281E64-DDC8-4BC9-991A-84D9DC4E7649}")]
    [ListOfSimpleTypeSettings(FieldName = "ComputedValues")]
    [XmlElement("ComputedValues")]
    public virtual List<ComputedValue> ComputedValues { get; set; }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.ViewModelPropertyMetadata.ComputedValue" />
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeComputedValue() => ViewModelPropertyMetadata.s08LrXBGor2GhM7eQydU((object) this);

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.ViewModelPropertyMetadata.ComputedValues" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Browsable(false)]
    public virtual bool ShouldSerializeComputedValues() => ViewModelPropertyMetadata.EgNe0gBGbayTd8k4vYfv((object) this.ComputedValues) > 0;

    internal static bool EZM7tVBGBvujHQYawfoo() => ViewModelPropertyMetadata.pfr0C7BGFgwPK7HR6dpr == null;

    internal static ViewModelPropertyMetadata kywsHKBGWZRDxjmjmdKR() => ViewModelPropertyMetadata.pfr0C7BGFgwPK7HR6dpr;

    internal static bool s08LrXBGor2GhM7eQydU([In] object obj0) => ((ViewModelPropertyMetadata) obj0).ClientOnly;

    internal static int EgNe0gBGbayTd8k4vYfv([In] object obj0) => ((List<ComputedValue>) obj0).Count;
  }
}
