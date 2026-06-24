// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.DataClassSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа объекта конструктора интерфейсов</summary>
  [Serializable]
  public class DataClassSettings : SimpleTypeSettings, IRelationTypeSettings
  {
    internal static DataClassSettings Sqa6TVoU9I33lMBLgHSE;

    /// <summary>Ctor</summary>
    public DataClassSettings()
    {
      DataClassSettings.mde1PRoUrSTmiHtK9GIi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected DataClassSettings(SerializationInfo info, StreamingContext context)
    {
      DataClassSettings.mde1PRoUrSTmiHtK9GIi();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Тип связи</summary>
    [DefaultValue(RelationType.OneToOne)]
    [XmlElement("RelationType")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (_Resources_DataClassSettingsResources), "RelationType")]
    [PublicationBehaviour(PublicationType.Restart)]
    public RelationType RelationType
    {
      get => this.\u003CRelationType\u003Ek__BackingField;
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
              this.\u003CRelationType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
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

    /// <summary>Вид отображения</summary>
    [XmlElement("DisplayType")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (_Resources_DataClassSettingsResources), "DisplayType")]
    [DefaultValue(DataClassDisplayType.Standard)]
    public DataClassDisplayType DisplayType
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

    internal static void mde1PRoUrSTmiHtK9GIi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool VdJwOEoUdWc6hMf8r4hr() => DataClassSettings.Sqa6TVoU9I33lMBLgHSE == null;

    internal static DataClassSettings a00FD5oUlYoPND65hcG3() => DataClassSettings.Sqa6TVoU9I33lMBLgHSE;
  }
}
