// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.MapMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Элемент мэпинга</summary>
  [Serializable]
  public class MapMetadata : NamedMetadata
  {
    private static MapMetadata OCJ7sjb7scR4UeBxtdbd;

    /// <summary>Свойство для мапинга</summary>
    [XmlElement("PropertyLeftUid")]
    public Guid PropertyLeftUid
    {
      get => this.\u003CPropertyLeftUid\u003Ek__BackingField;
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
              this.\u003CPropertyLeftUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
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

    /// <summary>Свойство для мапинга</summary>
    [XmlElement("PropertyRightUid")]
    public Guid PropertyRightUid
    {
      get => this.\u003CPropertyRightUid\u003Ek__BackingField;
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
              this.\u003CPropertyRightUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
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

    /// <summary>Сущность правого свойства для мапинга</summary>
    [XmlElement("ClassPropertyRightUid")]
    public Guid ClassPropertyRightUid
    {
      get => this.\u003CClassPropertyRightUid\u003Ek__BackingField;
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
              this.\u003CClassPropertyRightUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
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

    public virtual void LoadFromPropertyInfo(PropertyInfo propertyInfo)
    {
      int num = 4;
      while (true)
      {
        MapAttribute attribute1;
        UidAttribute attribute2;
        switch (num)
        {
          case 1:
            goto label_13;
          case 2:
            if (attribute1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 1;
              continue;
            }
            break;
          case 3:
            attribute1 = AttributeHelper<MapAttribute>.GetAttribute((MemberInfo) propertyInfo, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 5;
            continue;
          case 4:
            MapMetadata.DYhouQbxFlpi2QurpZyt((object) propertyInfo, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36161063));
            num = 3;
            continue;
          case 5:
            attribute2 = AttributeHelper<UidAttribute>.GetAttribute((MemberInfo) propertyInfo, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 2;
            continue;
          case 6:
            goto label_14;
          case 7:
            this.PropertyRightUid = MapMetadata.wY12ZObxWsbndRcERQwi((object) attribute1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 4 : 8;
            continue;
          case 8:
            this.ClassPropertyRightUid = MapMetadata.S1UcKpbxosqeidFr3mwp((object) attribute1);
            num = 6;
            continue;
          case 9:
            this.PropertyLeftUid = MapMetadata.QMWTnpbxBdO0bMTDsD65((object) attribute2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 7 : 4;
            continue;
        }
        if (attribute2 != null)
          num = 9;
        else
          goto label_2;
      }
label_13:
      return;
label_14:
      return;
label_2:;
    }

    public MapMetadata()
    {
      MapMetadata.kXkgvGbxb124oZb5Sivc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool EyAAUpb7cAGt35rjtsIY() => MapMetadata.OCJ7sjb7scR4UeBxtdbd == null;

    internal static MapMetadata P2Edpkb7zXM1459E7VeK() => MapMetadata.OCJ7sjb7scR4UeBxtdbd;

    internal static void DYhouQbxFlpi2QurpZyt([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Guid QMWTnpbxBdO0bMTDsD65([In] object obj0) => ((UidAttribute) obj0).Uid;

    internal static Guid wY12ZObxWsbndRcERQwi([In] object obj0) => ((MapAttribute) obj0).PropertyUid;

    internal static Guid S1UcKpbxosqeidFr3mwp([In] object obj0) => ((MapAttribute) obj0).ClassTypeUid;

    internal static void kXkgvGbxb124oZb5Sivc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
