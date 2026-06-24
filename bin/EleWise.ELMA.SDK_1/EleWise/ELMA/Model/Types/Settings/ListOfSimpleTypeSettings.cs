// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.ListOfSimpleTypeSettings
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
  [Serializable]
  public class ListOfSimpleTypeSettings : SimpleTypeSettings
  {
    private static ListOfSimpleTypeSettings RZWmqUozwOvjKK9jEy8s;

    /// <summary>Ctor</summary>
    public ListOfSimpleTypeSettings()
    {
      ListOfSimpleTypeSettings.BOLrqgozHMvx0mYwd7Yq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected ListOfSimpleTypeSettings(SerializationInfo info, StreamingContext context)
    {
      ListOfSimpleTypeSettings.BOLrqgozHMvx0mYwd7Yq();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    [XmlIgnore]
    [PublicationBehaviour(PublicationType.Restart)]
    public Guid SimpleTypeUid
    {
      get => this.\u003CSimpleTypeUid\u003Ek__BackingField;
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
              this.\u003CSimpleTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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

    [PublicationBehaviour(PublicationType.Restart)]
    [DefaultValue("")]
    [XmlElement("SimpleTypeUid")]
    public string SimpleTypeUidStr
    {
      get
      {
        int num = 2;
        Guid simpleTypeUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (ListOfSimpleTypeSettings.w1PnZcozAISN8vm1KGCO(this.SimpleTypeUid, Guid.Empty))
              {
                simpleTypeUid = this.SimpleTypeUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
              continue;
            default:
              goto label_6;
          }
        }
label_2:
        return "";
label_6:
        return simpleTypeUid.ToString();
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
              this.SimpleTypeUid = string.IsNullOrEmpty(value) ? Guid.Empty : new Guid(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
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

    /// <summary>Равенство настроек</summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public override bool Equals(SimpleTypeSettings other)
    {
      int num = 1;
      ListOfSimpleTypeSettings simpleTypeSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            simpleTypeSettings = other as ListOfSimpleTypeSettings;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_9;
          case 3:
            goto label_6;
          case 4:
            goto label_2;
          case 5:
            goto label_14;
          default:
            if (simpleTypeSettings != null)
            {
              if (simpleTypeSettings != null)
              {
                if (this == simpleTypeSettings)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 2 : 2;
                  continue;
                }
                if (base.Equals(other))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 3 : 5;
                  continue;
                }
                goto label_15;
              }
              else
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 4 : 2;
                continue;
              }
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 3 : 1;
              continue;
            }
        }
      }
label_2:
      return false;
label_6:
      return base.Equals(other);
label_9:
      return true;
label_14:
      return ListOfSimpleTypeSettings.zUJvGSoz7GpVErSU42Nt(simpleTypeSettings.SimpleTypeUid, this.SimpleTypeUid);
label_15:
      return false;
    }

    /// <summary>Равенство настроек</summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object obj)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            goto label_5;
          case 3:
            goto label_2;
          case 4:
            if (obj != null)
            {
              if (this == obj)
              {
                num = 2;
                continue;
              }
              if (!(obj.GetType() != this.GetType()))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 3;
              continue;
            }
          default:
            goto label_9;
        }
      }
label_2:
      return false;
label_5:
      return true;
label_8:
      return false;
label_9:
      return this.Equals((SimpleTypeSettings) obj);
    }

    /// <summary>Хэшкод</summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
      int hashCode = base.GetHashCode();
      Guid simpleTypeUid = this.SimpleTypeUid;
      int num = this.SimpleTypeUid.GetHashCode() * 67;
      return hashCode ^ num;
    }

    internal static void BOLrqgozHMvx0mYwd7Yq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool dgvn7roz4ZKHWQi2Q7Li() => ListOfSimpleTypeSettings.RZWmqUozwOvjKK9jEy8s == null;

    internal static ListOfSimpleTypeSettings xXL3pUoz6v1Q3tOtiEU0() => ListOfSimpleTypeSettings.RZWmqUozwOvjKK9jEy8s;

    internal static bool w1PnZcozAISN8vm1KGCO([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool zUJvGSoz7GpVErSU42Nt([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
  }
}
