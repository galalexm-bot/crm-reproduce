// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.PropertyDescription
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Описание свойства</summary>
  [DataContract]
  [Serializable]
  public class PropertyDescription
  {
    private static PropertyDescription rYQKwJb7DPqxRR7iwoFw;

    /// <summary>Идентификатор свойства</summary>
    [DataMember]
    [XmlElement("PropertyUid")]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
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

    /// <summary>Идентификатор класса, в котором находится свойство</summary>
    [DataMember]
    [XmlElement("ClassUid")]
    public Guid ClassUid
    {
      get => this.\u003CClassUid\u003Ek__BackingField;
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
              this.\u003CClassUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
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

    public override string ToString()
    {
      int num = 1;
      ClassMetadata classMetadata;
      PropertyMetadata propertyMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (Locator.GetService<IMetadataRuntimeService>() != null)
            {
              classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(this.ClassUid);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 4;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            if (propertyMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 5 : 5;
              continue;
            }
            goto label_9;
          case 4:
            if (classMetadata != null)
            {
              propertyMetadata = classMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => PropertyDescription.H7yrcfb7HrBym3aUnESB(PropertyDescription.usayJwb76H3ZZUyUbMyN((object) p), this.PropertyUid)));
              num = 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 2;
            continue;
          case 5:
            goto label_8;
          default:
            goto label_2;
        }
      }
label_2:
      return (string) PropertyDescription.kE9OHVb74xtww5hDuJKc((object) this);
label_4:
      return (string) PropertyDescription.kE9OHVb74xtww5hDuJKc((object) this);
label_8:
      return base.ToString();
label_9:
      return propertyMetadata.ToString();
    }

    public PropertyDescription()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool w9yYl8b7tE1tDaJBWuhL() => PropertyDescription.rYQKwJb7DPqxRR7iwoFw == null;

    internal static PropertyDescription t2eBv2b7wXR7XBQZHmdE() => PropertyDescription.rYQKwJb7DPqxRR7iwoFw;

    internal static object kE9OHVb74xtww5hDuJKc([In] object obj0) => (object) __nonvirtual (obj0.ToString());

    internal static Guid usayJwb76H3ZZUyUbMyN([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool H7yrcfb7HrBym3aUnESB([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
  }
}
