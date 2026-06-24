// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.PropertySettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Базовый класс для типов ссылки на атрибут</summary>
  [Serializable]
  public class PropertySettings : TypeSettings
  {
    private static PropertySettings ITqbPDocKCaVM2jkKgge;

    protected PropertySettings(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public PropertySettings()
    {
      PropertySettings.uWht8xockdZxSRA3BoL6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Идентификатор типа документа</summary>
    [XmlIgnore]
    [PublicationBehaviour(PublicationType.Restart)]
    public Guid EntityTypeUid
    {
      get => this.\u003CEntityTypeUid\u003Ek__BackingField;
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
              this.\u003CEntityTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
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

    /// <summary>Тип документа для сериализации</summary>
    [XmlElement("EntityTypeUid")]
    [PublicationBehaviour(PublicationType.Restart)]
    [DefaultValue("")]
    public string EntityTypeUidStr
    {
      get
      {
        int num = 1;
        Guid entityTypeUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (PropertySettings.xi1whsocnybSbsmoU6kL(this.EntityTypeUid, Guid.Empty))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            case 3:
              goto label_6;
            default:
              entityTypeUid = this.EntityTypeUid;
              num = 3;
              continue;
          }
        }
label_2:
        return "";
label_6:
        return entityTypeUid.ToString();
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.EntityTypeUid = PropertySettings.fTW7ekocOr3LLnRaOe2g((object) value) ? Guid.Empty : new Guid(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    /// <summary>Идетификатор свойства</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlIgnore]
    public Guid PropertyUid
    {
      get => this.\u003CPropertyUid\u003Ek__BackingField;
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
              this.\u003CPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
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

    /// <summary>Свойство для сериализации</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlElement("PropertyUid")]
    [DefaultValue("")]
    public string PropertyUidStr
    {
      get
      {
        int num = 1;
        Guid propertyUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!(this.PropertyUid != Guid.Empty))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                continue;
              }
              propertyUid = this.PropertyUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 2;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return propertyUid.ToString();
label_5:
        return "";
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
              this.PropertyUid = !PropertySettings.fTW7ekocOr3LLnRaOe2g((object) value) ? new Guid(value) : Guid.Empty;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
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

    /// <summary>Установка совойств в проекции</summary>
    [XmlIgnore]
    public Guid ProjectionPropertyUid
    {
      get => this.\u003CProjectionPropertyUid\u003Ek__BackingField;
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
              this.\u003CProjectionPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
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

    /// <summary>Свойство для сериализации</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlElement("ProjectionPropertyUid")]
    public string ProjectionPropertyStr
    {
      get
      {
        int num = 2;
        Guid projectionPropertyUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (PropertySettings.xi1whsocnybSbsmoU6kL(this.ProjectionPropertyUid, Guid.Empty))
              {
                projectionPropertyUid = this.ProjectionPropertyUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return "";
label_6:
        return projectionPropertyUid.ToString();
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              this.ProjectionPropertyUid = PropertySettings.fTW7ekocOr3LLnRaOe2g((object) value) ? Guid.Empty : new Guid(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }
    }

    internal static bool zSQbVUocXgKyGEqOVKZi() => PropertySettings.ITqbPDocKCaVM2jkKgge == null;

    internal static PropertySettings Hb36NqocTQiMIy5jhh6r() => PropertySettings.ITqbPDocKCaVM2jkKgge;

    internal static void uWht8xockdZxSRA3BoL6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xi1whsocnybSbsmoU6kL([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool fTW7ekocOr3LLnRaOe2g([In] object obj0) => string.IsNullOrEmpty((string) obj0);
  }
}
