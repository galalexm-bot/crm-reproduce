// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.NamedDocumentedMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Базовый класс для метаданных объектов, имеющих имя, отображаемое имя, описание, а также документацию
  /// </summary>
  [DataContract]
  [Serializable]
  public class NamedDocumentedMetadata : NamedMetadata
  {
    internal static NamedDocumentedMetadata M7CgZybAmLtc9M02TUMx;

    /// <summary>Ctor</summary>
    public NamedDocumentedMetadata()
    {
      NamedDocumentedMetadata.BmQWsAbAJeXlnn9nTePZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            NamedDocumentedMetadata.l8wX4LbA9kF7BtSMyNyW((object) this, (object) "");
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>XML-комментарии для документации</summary>
    [EleWise.ELMA.Model.Attributes.Uid("{4B8DA303-082A-4CBE-8862-91266AC51F11}")]
    [XmlElement("XmlComments")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [DefaultValue("")]
    [EntityProperty]
    [StringSettings(FieldName = "XmlComments")]
    public virtual string XmlComments
    {
      get => this.\u003CXmlComments\u003Ek__BackingField;
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
              this.\u003CXmlComments\u003Ek__BackingField = value;
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

    internal static void BmQWsAbAJeXlnn9nTePZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void l8wX4LbA9kF7BtSMyNyW([In] object obj0, [In] object obj1) => ((NamedDocumentedMetadata) obj0).XmlComments = (string) obj1;

    internal static bool jQhHOfbAyhgbq6X18Ata() => NamedDocumentedMetadata.M7CgZybAmLtc9M02TUMx == null;

    internal static NamedDocumentedMetadata NaSRPJbAMHNLXWnX63ZA() => NamedDocumentedMetadata.M7CgZybAmLtc9M02TUMx;
  }
}
