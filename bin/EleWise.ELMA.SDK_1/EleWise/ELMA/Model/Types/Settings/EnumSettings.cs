// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.EnumSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа "Перечисление"</summary>
  [Serializable]
  public class EnumSettings : SimpleTypeSettings, IHasDefaultValue<Guid?>
  {
    private static EnumSettings kWovcLbB2v9g2cExBDc2;

    /// <summary>Ctor</summary>
    public EnumSettings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected EnumSettings(SerializationInfo info, StreamingContext context)
    {
      EnumSettings.zLgUewbB1YEwn4U2YQgg();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Значение по умолчанию (уникальный идентификатор значения перечисления)
    /// </summary>
    [PublicationBehaviour(PublicationType.Delta)]
    [XmlIgnore]
    public Guid? DefaultValue { get; set; }

    /// <summary>Значение по умолчанию (для сериализации)</summary>
    [PublicationBehaviour(PublicationType.Delta)]
    [System.ComponentModel.DefaultValue("")]
    [XmlElement("DefaultValue")]
    [JsonSerializationIgnore]
    public string DefaultValueStr
    {
      get
      {
        int num = 6;
        Guid? defaultValue;
        Guid guid;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (defaultValue.Value != Guid.Empty)
              {
                num = 4;
                continue;
              }
              goto label_8;
            case 2:
              guid = defaultValue.Value;
              num = 7;
              continue;
            case 3:
              goto label_8;
            case 4:
              defaultValue = this.DefaultValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 2;
              continue;
            case 5:
              if (defaultValue.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            case 6:
              defaultValue = this.DefaultValue;
              num = 5;
              continue;
            case 7:
              goto label_11;
            default:
              defaultValue = this.DefaultValue;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
              continue;
          }
        }
label_8:
        return "";
label_11:
        return guid.ToString();
      }
      set
      {
        int num1 = 2;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_16;
            case 1:
              goto label_6;
            case 2:
              if (!EnumSettings.K6tqMVbBNv0Mv1HLIr8y((object) value))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
                continue;
              }
              goto case 3;
            case 3:
              this.DefaultValue = new Guid?();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              continue;
            default:
              goto label_14;
          }
        }
label_16:
        return;
label_14:
        return;
label_6:
        try
        {
          this.DefaultValue = new Guid?(new Guid(value));
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
            num2 = 0;
          switch (num2)
          {
          }
        }
        catch (Exception ex)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 0:
                goto label_2;
              case 1:
                EnumSettings.aEOyMLbBp1o1ODRD9VBl((object) Logger.Log, (object) EleWise.ELMA.SR.T((string) EnumSettings.qwZSfbbB3s8INIHHe866(-2112703338 ^ -2112873586), (object) value), (object) ex);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
                continue;
              default:
                goto label_17;
            }
          }
label_2:
          return;
label_17:;
        }
      }
    }

    /// <summary>Тип связи в фильтре для перечисления</summary>
    [System.ComponentModel.DefaultValue(EnumRelationType.One)]
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlElement("RelationType")]
    [JsonSerializationIgnore]
    public EnumRelationType RelationType
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
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

    /// <summary>Тип отображения</summary>
    [XmlElement("DisplayType")]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EnumSettings.__Resources), "DisplayType")]
    [System.ComponentModel.DefaultValue(EnumDisplayType.Standard)]
    public EnumDisplayType DisplayType
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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
    [System.ComponentModel.DefaultValue(100)]
    [EleWise.ELMA.Model.Attributes.DisplayName(typeof (EnumSettings.__Resources), "MaxCount")]
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

    /// <summary>Отображать иконку</summary>
    [XmlIgnore]
    [PublicationBehaviour(PublicationType.Restart)]
    public bool ShowIcon
    {
      get => this.\u003CShowIcon\u003Ek__BackingField;
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
              this.\u003CShowIcon\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
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

    internal static bool rRZWBXbBeOP2fNsbRIws() => EnumSettings.kWovcLbB2v9g2cExBDc2 == null;

    internal static EnumSettings wKeTCabBPthe0ovsxBPX() => EnumSettings.kWovcLbB2v9g2cExBDc2;

    internal static void zLgUewbB1YEwn4U2YQgg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool K6tqMVbBNv0Mv1HLIr8y([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object qwZSfbbB3s8INIHHe866(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void aEOyMLbBp1o1ODRD9VBl([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    private static class __Resources
    {
      internal static object d4JayMCXTMNr0QbxF4Ve;

      public static string DisplayType => (string) EnumSettings.__Resources.nqcPwLCX2H2e8HhwAarR(EnumSettings.__Resources.ymPAy0CXO6KSj9kgsxSA(-675505729 ^ -675725867));

      public static string MaxCount => (string) EnumSettings.__Resources.nqcPwLCX2H2e8HhwAarR(EnumSettings.__Resources.ymPAy0CXO6KSj9kgsxSA(-675505729 ^ -675725971));

      internal static object ymPAy0CXO6KSj9kgsxSA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object nqcPwLCX2H2e8HhwAarR([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool RJ67INCXkNXX3iKMYp0M() => EnumSettings.__Resources.d4JayMCXTMNr0QbxF4Ve == null;

      internal static EnumSettings.__Resources QkMI6WCXnXKVE1yjyFUQ() => (EnumSettings.__Resources) EnumSettings.__Resources.d4JayMCXTMNr0QbxF4Ve;
    }
  }
}
