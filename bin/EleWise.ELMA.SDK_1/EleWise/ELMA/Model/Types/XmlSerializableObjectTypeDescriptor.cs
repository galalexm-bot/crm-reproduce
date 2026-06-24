// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.XmlSerializableObjectTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "XML-сериализуемый объект"</summary>
  public class XmlSerializableObjectTypeDescriptor : 
    CLRTypeDescriptor<object, XmlSerializableObjectSettings>,
    IMappingTypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{66C7898B-E56B-49E0-BFB8-9F9C4A7A0C52}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static XmlSerializableObjectTypeDescriptor I16KrYoHC7LEnposYXuf;

    /// <inheritdoc />
    protected override void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            XmlSerializableObjectTypeDescriptor.RfL6uaoHZv7u33vl7Cnp((object) this, (object) mapper, (object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            mapper.Type<XmlObjectSerializableType>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Uid типа</summary>
    public override Guid Uid => XmlSerializableObjectTypeDescriptor.UID;

    /// <summary>Имя "XML-сериализуемый объект"</summary>
    public override string Name => (string) XmlSerializableObjectTypeDescriptor.KiPPFUoHukbZjA2tY8QT((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334895381));

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num = 7;
      string assemblyQualifiedName;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = (string) XmlSerializableObjectTypeDescriptor.qp2p2uoHV9BrYZsnQmVJ((object) str, 0, XmlSerializableObjectTypeDescriptor.JFvE7UoHIQAJtK556K7K((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138174024)) + 1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 4 : 4;
            continue;
          case 2:
            str = (string) XmlSerializableObjectTypeDescriptor.cjLtt6oHSsqqV66Ddk9X((object) assemblyQualifiedName, (object) str);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          case 3:
            if (assemblyQualifiedName == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 5 : 8;
              continue;
            }
            goto case 2;
          case 4:
            assemblyQualifiedName = value.GetType().AssemblyQualifiedName;
            num = 3;
            continue;
          case 5:
            goto label_8;
          case 6:
            str = ClassSerializationHelper.SerializeObjectByXml(value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 1;
            continue;
          case 7:
            if (value != null)
            {
              num = 6;
              continue;
            }
            goto label_8;
          default:
            goto label_5;
        }
      }
label_5:
      return (object) str;
label_8:
      return (object) null;
    }

    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num = 1;
      string str1;
      while (true)
      {
        switch (num)
        {
          case 1:
            str1 = value as string;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      Type tp = XmlSerializableObjectTypeDescriptor.O87gaboHqZUfAvhWo4oi(XmlSerializableObjectTypeDescriptor.dxukJ1oHRO0l2PIULuQr((object) str1, 0, XmlSerializableObjectTypeDescriptor.JFvE7UoHIQAJtK556K7K((object) str1, XmlSerializableObjectTypeDescriptor.EcUZRmoHiC5sLVKy3Lsl(44884861 ^ 44870843))));
      string str2 = (string) XmlSerializableObjectTypeDescriptor.qp2p2uoHV9BrYZsnQmVJ((object) str1, 0, str1.IndexOf((string) XmlSerializableObjectTypeDescriptor.EcUZRmoHiC5sLVKy3Lsl(1654249598 >> 2 ^ 413546969)));
      StringBuilder stringBuilder = new StringBuilder((string) XmlSerializableObjectTypeDescriptor.EcUZRmoHiC5sLVKy3Lsl(~538519529 ^ -538683122));
      XmlSerializableObjectTypeDescriptor.Tg0ERIoHKi6c9E5kMMUT((object) stringBuilder, (object) str2);
      string xml = stringBuilder.ToString();
      return ClassSerializationHelper.DeserializeObjectByXml(tp, xml);
    }

    /// <inheritdoc />
    public override bool Visible
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (base.Visible)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_2;
            default:
              if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 1;
                continue;
              }
              goto label_3;
          }
        }
label_2:
        return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
label_3:
        return true;
label_4:
        return false;
      }
    }

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Binary);
    }

    public XmlSerializableObjectTypeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static XmlSerializableObjectTypeDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            XmlSerializableObjectTypeDescriptor.cfjRPboHXJe5RIbCxwky();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            XmlSerializableObjectTypeDescriptor.UID = new Guid((string) XmlSerializableObjectTypeDescriptor.EcUZRmoHiC5sLVKy3Lsl(-1255365154 ^ 596875508 ^ -1765950398));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void RfL6uaoHZv7u33vl7Cnp([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SimpleTypeDescriptor<object>) obj0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper) obj1, (EntityPropertyMetadata) obj2));

    internal static bool MsIoEioHv4jTCg88S31B() => XmlSerializableObjectTypeDescriptor.I16KrYoHC7LEnposYXuf == null;

    internal static XmlSerializableObjectTypeDescriptor lCmSsPoH84ycEnV4lLEw() => XmlSerializableObjectTypeDescriptor.I16KrYoHC7LEnposYXuf;

    internal static object KiPPFUoHukbZjA2tY8QT([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static int JFvE7UoHIQAJtK556K7K([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

    internal static object qp2p2uoHV9BrYZsnQmVJ([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Remove(obj1, obj2);

    internal static object cjLtt6oHSsqqV66Ddk9X([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object EcUZRmoHiC5sLVKy3Lsl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object dxukJ1oHRO0l2PIULuQr([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static Type O87gaboHqZUfAvhWo4oi([In] object obj0) => Type.GetType((string) obj0);

    internal static object Tg0ERIoHKi6c9E5kMMUT([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).AppendLine((string) obj1);

    internal static void cfjRPboHXJe5RIbCxwky() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
