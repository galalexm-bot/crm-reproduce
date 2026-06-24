// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.ReferenceOnEntityTypeSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа "Ссылка на тип объекта"</summary>
  [Serializable]
  public class ReferenceOnEntityTypeSettings : SimpleTypeSettings
  {
    [OptionalField]
    private Guid _baseClass;
    private static ReferenceOnEntityTypeSettings J2i7VQbFICpSsG79QI0l;

    /// <summary>Ctor</summary>
    public ReferenceOnEntityTypeSettings()
    {
      ReferenceOnEntityTypeSettings.ILMfpubFiGuWWvmcgpuL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected ReferenceOnEntityTypeSettings(SerializationInfo info, StreamingContext context)
    {
      ReferenceOnEntityTypeSettings.ILMfpubFiGuWWvmcgpuL();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Базовый класс для типа (вибирать можно либо его, либо наследников)
    /// </summary>
    [XmlIgnore]
    public Guid BaseClass
    {
      get => this._baseClass;
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
              this._baseClass = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
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

    [DefaultValue("")]
    [JsonSerializationIgnore]
    [XmlElement("BaseClass")]
    public string BaseClassStr
    {
      get
      {
        int num = 1;
        Guid baseClass;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.BaseClass != Guid.Empty)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              goto label_5;
            case 3:
              goto label_4;
            default:
              baseClass = this.BaseClass;
              num = 3;
              continue;
          }
        }
label_4:
        return baseClass.ToString();
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
              goto label_4;
            case 1:
              this.BaseClass = ReferenceOnEntityTypeSettings.uBX2r8bFRgOJp7dnhv15((object) value) ? Guid.Empty : new Guid(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
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

    internal static void ILMfpubFiGuWWvmcgpuL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool jK3l1fbFVbVNwi6FrK6u() => ReferenceOnEntityTypeSettings.J2i7VQbFICpSsG79QI0l == null;

    internal static ReferenceOnEntityTypeSettings hPW5u9bFSPkwrmL3M9m4() => ReferenceOnEntityTypeSettings.J2i7VQbFICpSsG79QI0l;

    internal static bool uBX2r8bFRgOJp7dnhv15([In] object obj0) => string.IsNullOrEmpty((string) obj0);
  }
}
