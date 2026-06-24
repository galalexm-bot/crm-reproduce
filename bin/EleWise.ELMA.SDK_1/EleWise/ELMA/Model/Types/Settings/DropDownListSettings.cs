// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.DropDownListSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа "Выпадающий список"</summary>
  [Serializable]
  public class DropDownListSettings : SimpleTypeSettings, IHasDefaultValue<DropDownItem>
  {
    internal static DropDownListSettings T052CXozGYdB0PghEj4F;

    /// <summary>Ctor</summary>
    public DropDownListSettings()
    {
      DropDownListSettings.JF0vpMozQCuvqXJ1SVMT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Items = new DropDownItemList();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected DropDownListSettings(SerializationInfo info, StreamingContext context)
    {
      DropDownListSettings.JF0vpMozQCuvqXJ1SVMT();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Items = new DropDownItemList();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 2 : 2;
            continue;
          case 2:
            goto label_3;
          default:
            if (this.Items == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 0;
              continue;
            }
            goto label_7;
        }
      }
label_3:
      return;
label_7:;
    }

    /// <summary>
    /// Значения выпадающего списка в виде строки, указанные через \r\n.
    /// Ключ (идентификатор) можно указывать в начале строки в фигурных скобках.
    /// </summary>
    [System.ComponentModel.DefaultValue("")]
    [CopyAction(CopyAction.Ignore)]
    [JsonSerializationIgnore]
    [XmlElement("Items")]
    public string ItemsString
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.Items == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return string.Empty;
label_3:
        return this.Items.ToString();
      }
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.Items = new DropDownItemList();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 3 : 3;
              continue;
            case 2:
              if (this.Items == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
                continue;
              }
              goto case 3;
            case 3:
              DropDownListSettings.arEGLKozCjn9DE4qBWvI((object) this.Items, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            default:
              goto label_7;
          }
        }
label_2:
        return;
label_7:;
      }
    }

    /// <summary>Значения выпадающего списка</summary>
    [XmlIgnore]
    public DropDownItemList Items
    {
      get => this.\u003CItems\u003Ek__BackingField;
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
              this.\u003CItems\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    /// <summary>Выбор только из списка указанных элементов</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Если True, то разрешен только выбор из списка. Иначе можно вводить любое текстовое значение')")]
    [System.ComponentModel.DefaultValue(false)]
    [XmlElement("SelectOnly")]
    public bool SelectOnly
    {
      get => this.\u003CSelectOnly\u003Ek__BackingField;
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
              this.\u003CSelectOnly\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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

    /// <summary>Отображать в виде дерева</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Отображать в виде дерева')")]
    [System.ComponentModel.DefaultValue(false)]
    [XmlElement("ShowTree")]
    public bool ShowTree
    {
      get => this.\u003CShowTree\u003Ek__BackingField;
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
              this.\u003CShowTree\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    /// <summary>Можно ли выбирать узел дерева</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Можно ли выбирать родительские узлы')")]
    [XmlElement("SelectableParentNode")]
    [System.ComponentModel.DefaultValue(false)]
    public bool SelectableParentNode
    {
      get => this.\u003CSelectableParentNode\u003Ek__BackingField;
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
              this.\u003CSelectableParentNode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    /// <summary>Значение по умолчанию</summary>
    [XmlIgnore]
    public DropDownItem DefaultValue
    {
      get => this.\u003CDefaultValue\u003Ek__BackingField;
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
              this.\u003CDefaultValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
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

    /// <summary>Значение по умолчанию (для сериализации)</summary>
    [System.ComponentModel.DefaultValue("")]
    [JsonSerializationIgnore]
    [XmlElement("DefaultValueStr")]
    [PublicationBehaviour(PublicationType.Delta)]
    public string DefaultValueStr
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (this.DefaultValue != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return "";
label_3:
        return this.DefaultValue.ToString();
      }
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
              this.DefaultValue = !string.IsNullOrEmpty(value) ? new DropDownItem(value) : (DropDownItem) null;
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
    }

    protected override void GetSerializationDescriptor(TypeSerializationDescriptor descriptor)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            base.GetSerializationDescriptor(descriptor);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            new TypeSerializationDescriptorBuilder(descriptor).ItemWithDescriptor((string) DropDownListSettings.A2DV79ozvyFJPX203h4e(-1839087379 - 334718690 ^ 2121070569), (Action<TypeSerializationDescriptorBuilder>) (i =>
            {
              int num7 = 1;
              while (true)
              {
                switch (num7)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    ((TypeSerializationDescriptorBuilder) DropDownListSettings.\u003C\u003Ec.selwysCK2W4P5Us6b97t((object) i, DropDownListSettings.\u003C\u003Ec.da5yrJCKOIC1ykkHfVOO((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -69807890)))).Optional().IsArray((Action<TypeSerializationDescriptorBuilder>) (a =>
                    {
                      int num8 = 1;
                      while (true)
                      {
                        switch (num8)
                        {
                          case 0:
                            goto label_6;
                          case 1:
                            TypeSerializationDescriptorBuilder descriptorBuilder3 = a;
                            // ISSUE: reference to a compiler-generated method
                            object itemName3 = DropDownListSettings.\u003C\u003Ec.j8m8HACKes95dYeQATFM(-1350312861 << 3 ^ 2082358610);
                            // ISSUE: reference to a compiler-generated field
                            Action<TypeSerializationDescriptorBuilder> action3 = DropDownListSettings.\u003C\u003Ec.\u003C\u003E9__28_2;
                            Action<TypeSerializationDescriptorBuilder> builder3;
                            if (action3 == null)
                            {
                              // ISSUE: reference to a compiler-generated field
                              DropDownListSettings.\u003C\u003Ec.\u003C\u003E9__28_2 = builder3 = (Action<TypeSerializationDescriptorBuilder>) (ai =>
                              {
                                int num5 = 1;
                                while (true)
                                {
                                  switch (num5)
                                  {
                                    case 0:
                                      goto label_2;
                                    case 1:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: type reference
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      ((TypeSerializationDescriptorBuilder) DropDownListSettings.\u003C\u003Ec.CvrL5jCK1eoqdtlgfRx6(DropDownListSettings.\u003C\u003Ec.selwysCK2W4P5Us6b97t((object) ai, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787090835))), DropDownListSettings.\u003C\u003Ec.kNnvyXCKPReqSxSuPj1U(__typeref (string)))).Optional();
                                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
                                      continue;
                                    default:
                                      goto label_4;
                                  }
                                }
label_2:
                                return;
label_4:;
                              });
                            }
                            else
                              goto label_10;
label_5:
                            TypeSerializationDescriptorBuilder descriptorBuilder4 = descriptorBuilder3.ItemWithDescriptor((string) itemName3, builder3);
                            // ISSUE: reference to a compiler-generated method
                            object itemName4 = DropDownListSettings.\u003C\u003Ec.j8m8HACKes95dYeQATFM(1994213607 >> 4 ^ 124613338);
                            // ISSUE: reference to a compiler-generated field
                            Action<TypeSerializationDescriptorBuilder> action4 = DropDownListSettings.\u003C\u003Ec.\u003C\u003E9__28_3;
                            Action<TypeSerializationDescriptorBuilder> builder4;
                            if (action4 == null)
                            {
                              // ISSUE: reference to a compiler-generated field
                              DropDownListSettings.\u003C\u003Ec.\u003C\u003E9__28_3 = builder4 = (Action<TypeSerializationDescriptorBuilder>) (ai =>
                              {
                                int num6 = 1;
                                while (true)
                                {
                                  switch (num6)
                                  {
                                    case 0:
                                      goto label_2;
                                    case 1:
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: reference to a compiler-generated method
                                      // ISSUE: type reference
                                      // ISSUE: reference to a compiler-generated method
                                      ((TypeSerializationDescriptorBuilder) DropDownListSettings.\u003C\u003Ec.selwysCK2W4P5Us6b97t((object) ai, DropDownListSettings.\u003C\u003Ec.da5yrJCKOIC1ykkHfVOO(DropDownListSettings.\u003C\u003Ec.j8m8HACKes95dYeQATFM(-1088304168 ^ -1088138106)))).Type(DropDownListSettings.\u003C\u003Ec.kNnvyXCKPReqSxSuPj1U(__typeref (string))).Optional();
                                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                                      continue;
                                    default:
                                      goto label_4;
                                  }
                                }
label_2:
                                return;
label_4:;
                              });
                            }
                            else
                              goto label_9;
label_8:
                            descriptorBuilder4.ItemWithDescriptor((string) itemName4, builder4);
                            num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
                            continue;
label_9:
                            builder4 = action4;
                            goto label_8;
label_10:
                            builder3 = action3;
                            goto label_5;
                          default:
                            goto label_3;
                        }
                      }
label_6:
                      return;
label_3:;
                    }));
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    public override void SerializeToJsonObject(SerializableDictionary<string, object> jsonObject)
    {
      base.SerializeToJsonObject(jsonObject);
      if (this.Items == null)
        return;
      SerializableList<object> serializableList = new SerializableList<object>();
      foreach (DropDownItem dropDownItem in (List<DropDownItem>) this.Items)
      {
        SerializableDictionary<string, object> serializableDictionary1 = new SerializableDictionary<string, object>();
        serializableDictionary1.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16713549), (object) dropDownItem.Value);
        SerializableDictionary<string, object> serializableDictionary2 = serializableDictionary1;
        if (!string.IsNullOrEmpty(dropDownItem.Key))
          serializableDictionary2[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583768386)] = (object) dropDownItem.Key;
        serializableList.Add((object) serializableDictionary2);
      }
      jsonObject[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765961528)] = (object) serializableList;
    }

    /// <inheritdoc />
    public override void DeserializeFromJsonObject(IDictionary<string, object> jsonObject)
    {
      base.DeserializeFromJsonObject(jsonObject);
      object obj1;
      if (jsonObject == null || !jsonObject.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360506879), out obj1))
        return;
      if (this.Items == null)
        this.Items = new DropDownItemList();
      else
        this.Items.Clear();
      if (!(obj1 is IEnumerable enumerable))
        return;
      foreach (object obj2 in enumerable)
      {
        object obj3;
        if (obj2 is IDictionary<string, object> dictionary && dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669238735), out obj3))
        {
          object obj4;
          dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420785812), out obj4);
          this.Items.Add(new DropDownItem(obj4?.ToString(), obj3 != null ? obj3.ToString() : ""));
        }
      }
    }

    /// <summary>Тип отображения</summary>
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Тип отображения')")]
    [XmlElement("DisplayType")]
    [System.ComponentModel.DefaultValue(DropDownListDisplayType.Standard)]
    public DropDownListDisplayType DisplayType
    {
      get => this.\u003CDisplayType\u003Ek__BackingField;
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
              this.\u003CDisplayType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
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

    /// <summary>
    /// Максимальное количество элементов для отображения в нестандартных режимах
    /// </summary>
    [EleWise.ELMA.Model.Attributes.DisplayName("SR.M('Максимальное количество элементов')")]
    [System.ComponentModel.DefaultValue(100)]
    [XmlElement("MaxCount")]
    public int MaxCount
    {
      get => this.\u003CMaxCount\u003Ek__BackingField;
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
              this.\u003CMaxCount\u003Ek__BackingField = value;
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

    public override bool Equals(SimpleTypeSettings other)
    {
      int num1 = 4;
      DropDownListSettings downListSettings;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              goto label_9;
            case 3:
              if (downListSettings != null)
              {
                num2 = 11;
                continue;
              }
              goto label_6;
            case 4:
              downListSettings = other as DropDownListSettings;
              num2 = 3;
              continue;
            case 5:
              if (DropDownListSettings.glgBwpozu5DQmBTmdYqN((object) downListSettings) == this.MaxCount)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            case 6:
              goto label_13;
            case 7:
              goto label_22;
            case 8:
              goto label_6;
            case 9:
              if (!((string) DropDownListSettings.LSUoojoz8Vo9QsPCZ9Qh((object) downListSettings) == this.ItemsString))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
                continue;
              }
              goto case 10;
            case 10:
              if (DropDownListSettings.LvM9LRozZVr3LbdlyZ5p((object) downListSettings) == this.SelectOnly)
              {
                num2 = 5;
                continue;
              }
              goto label_10;
            case 11:
              if (downListSettings == null)
              {
                num2 = 6;
                continue;
              }
              if (this == downListSettings)
              {
                num2 = 7;
                continue;
              }
              goto label_23;
            default:
              if (DropDownListSettings.zCuihJozI8oRVq1pv4TH((object) downListSettings) == this.DisplayType)
              {
                num2 = 2;
                continue;
              }
              goto label_10;
          }
        }
label_23:
        if (base.Equals(other))
          num1 = 9;
        else
          goto label_10;
      }
label_6:
      return base.Equals(other);
label_9:
      return DropDownListSettings.iOypLSozV3mvpXcwCg1A((object) downListSettings.DefaultValueStr, (object) this.DefaultValueStr);
label_10:
      return false;
label_13:
      return false;
label_22:
      return true;
    }

    public override bool Equals(object obj)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              goto label_3;
            case 3:
              if (obj != null)
              {
                if (this == obj)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 1;
                  continue;
                }
                // ISSUE: type reference
                if (!(obj.GetType() != DropDownListSettings.tTiCEYozS1J6UScgUWCq(__typeref (DropDownListSettings))))
                {
                  num2 = 4;
                  continue;
                }
                goto label_9;
              }
              else
                goto label_12;
            case 4:
              goto label_10;
            default:
              goto label_9;
          }
        }
label_12:
        num1 = 2;
      }
label_3:
      return false;
label_6:
      return true;
label_9:
      return false;
label_10:
      return DropDownListSettings.DELIywoziBpKTBNwfj66((object) this, (object) (DropDownListSettings) obj);
    }

    public override int GetHashCode() => base.GetHashCode() ^ (this.ItemsString != null ? this.ItemsString.GetHashCode() : typeof (string).GetHashCode()) * 397 ^ this.SelectOnly.GetHashCode() * 276 ^ this.MaxCount.GetHashCode() * 213 ^ this.DisplayType.GetHashCode() * 177 ^ (this.DefaultValueStr == null ? DropDownListSettings.tTiCEYozS1J6UScgUWCq(__typeref (string)).GetHashCode() : this.DefaultValueStr.GetHashCode()) * 13;

    internal static void JF0vpMozQCuvqXJ1SVMT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool UH0VV8ozEqYl85o40NrP() => DropDownListSettings.T052CXozGYdB0PghEj4F == null;

    internal static DropDownListSettings NKmXsHozfSpa7TN4wVZq() => DropDownListSettings.T052CXozGYdB0PghEj4F;

    internal static void arEGLKozCjn9DE4qBWvI([In] object obj0, [In] object obj1) => ((DropDownItemList) obj0).Parse((string) obj1);

    internal static object A2DV79ozvyFJPX203h4e(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object LSUoojoz8Vo9QsPCZ9Qh([In] object obj0) => (object) ((DropDownListSettings) obj0).ItemsString;

    internal static bool LvM9LRozZVr3LbdlyZ5p([In] object obj0) => ((DropDownListSettings) obj0).SelectOnly;

    internal static int glgBwpozu5DQmBTmdYqN([In] object obj0) => ((DropDownListSettings) obj0).MaxCount;

    internal static DropDownListDisplayType zCuihJozI8oRVq1pv4TH([In] object obj0) => ((DropDownListSettings) obj0).DisplayType;

    internal static bool iOypLSozV3mvpXcwCg1A([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static Type tTiCEYozS1J6UScgUWCq([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool DELIywoziBpKTBNwfj66([In] object obj0, [In] object obj1) => ((SimpleTypeSettings) obj0).Equals((SimpleTypeSettings) obj1);
  }
}
