// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.EnumValueMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Метаданные значения перечисления</summary>
  [Serializable]
  public class EnumValueMetadata : NamedDocumentedMetadata
  {
    internal static EnumValueMetadata QTt2EKbJIj4RwhfjUc8Y;

    public EnumValueMetadata()
    {
      EnumValueMetadata.sIYoAcbJiCmNHOi7lHw2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Visibility = Visibility.Visible;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Целочисленное значение</summary>
    [XmlElement("IntValue", IsNullable = true)]
    [PublicationBehaviour(PublicationType.Restart)]
    public int? IntValue { get; set; }

    /// <summary>Видимость элемента при выборе значения перечисления</summary>
    [DefaultValue(Visibility.Visible)]
    [XmlElement("Visibility")]
    public Visibility Visibility
    {
      get => this.\u003CVisibility\u003Ek__BackingField;
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
              this.\u003CVisibility\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
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
    /// Реальное значение перечисления (доступно только при загрузке через LoadFromType или Load)
    /// </summary>
    [XmlIgnore]
    public object EnumValue
    {
      get => this.\u003CEnumValue\u003Ek__BackingField;
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
              this.\u003CEnumValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
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
      while (true)
      {
        switch (num)
        {
          case 1:
            if (EnumValueMetadata.BoEsDkbJqDRNgBIq3U34(EnumValueMetadata.biMFgxbJRWWAeYMcBonp((object) this)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) EnumValueMetadata.e0pNi1bJKWD2JfSCtKB8((object) this);
label_5:
      return (string) EnumValueMetadata.biMFgxbJRWWAeYMcBonp((object) this);
    }

    /// <summary>
    /// Используется для установки дополнительных атрибутов на свойства сущностей через файл метаданных, для которых не реализовано визуальной установки
    /// </summary>
    public virtual EnumMetadataAdditionalAttribute[] AdditionalAttributes
    {
      get => this.\u003CAdditionalAttributes\u003Ek__BackingField;
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
              this.\u003CAdditionalAttributes\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
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

    /// <summary>Загрузить из реального значения перечисления</summary>
    /// <param name="enumType">Тип перечисления</param>
    /// <param name="enumValue">Значение перечисления</param>
    public virtual void LoadFromValue(Type enumType, object enumValue)
    {
      int num = 2;
      MemberInfo member;
      while (true)
      {
        switch (num)
        {
          case 1:
            EnumValueMetadata.Eu9T4hbJTwmJ3fCOQgsE(enumValue, EnumValueMetadata.vc3HLqbJXSB5wVi5MBlk(1051802738 - -1831968059 ^ -1411373115));
            num = 3;
            continue;
          case 2:
            EnumValueMetadata.Eu9T4hbJTwmJ3fCOQgsE((object) enumType, EnumValueMetadata.vc3HLqbJXSB5wVi5MBlk(874012245 ^ 874161087));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
            continue;
          case 3:
            member = (MemberInfo) EnumValueMetadata.nTKD6KbJkwacNXQgAYCj(enumType, (object) enumValue.ToString())[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
            continue;
          case 4:
            goto label_2;
          default:
            this.LoadFromMember(member, enumValue);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 4 : 4;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Загрузить из информации о члене</summary>
    /// <param name="member">Информация о члене</param>
    /// <param name="enumValue">Значение перечисления</param>
    public virtual void LoadFromMember(MemberInfo member, object enumValue = null)
    {
      int num1 = 27;
      IEnumerator<ImageAttribute> enumerator;
      while (true)
      {
        UidAttribute attribute1;
        XmlReader xmlReader;
        EnumMetadataAdditionalAttributesAttribute attribute2;
        object[] source;
        ViewAttribute attribute3;
        PropertyInfo propertyInfo;
        EnumBase enumBase;
        EleWise.ELMA.Model.Attributes.DisplayNameAttribute attribute4;
        EleWise.ELMA.Model.Attributes.DescriptionAttribute attribute5;
        switch (num1)
        {
          case 1:
            EnumValueMetadata.X4dQExbJtqBOPxrhMhwo((object) this, attribute5 == null ? EnumValueMetadata.vRfx9FbJDOTeRbL0pCDq() : EnumValueMetadata.t75dZCbJpTYBKicNVUJk((object) attribute5));
            num1 = 29;
            continue;
          case 2:
            if (source.Length != 0)
            {
              num1 = 13;
              continue;
            }
            goto label_54;
          case 3:
            xmlReader = (XmlReader) EnumValueMetadata.lvN7w6bJ4kIvIYsrZRRn((object) new StringReader(attribute2.EnumAdditionalAttributes));
            num1 = 6;
            continue;
          case 4:
            if (enumValue != null)
            {
              num1 = 21;
              continue;
            }
            goto case 25;
          case 5:
            if (typeof (EnumBase).IsAssignableFrom(EnumValueMetadata.lT5YA0bJ1sswCMv26VqU((object) propertyInfo)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 7 : 16;
              continue;
            }
            goto case 12;
          case 6:
            try
            {
              // ISSUE: type reference
              XmlSerializer xmlSerializer = new XmlSerializer(EnumValueMetadata.F7pU05bJ6f8Qye6wRvrB(__typeref (EnumMetadataAdditionalAttribute[])));
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
                num2 = 0;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_49;
                  default:
                    EnumValueMetadata.eY1wLJbJATaDMyEGnxnJ((object) this, (object) (EnumMetadataAdditionalAttribute[]) EnumValueMetadata.cda07SbJHf82qe6gNLWq((object) xmlSerializer, (object) xmlReader));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
                    continue;
                }
              }
            }
            finally
            {
              int num3;
              if (xmlReader == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
              else
                goto label_10;
label_9:
              switch (num3)
              {
                case 1:
                case 2:
              }
label_10:
              EnumValueMetadata.qsTeaUbJ7d8Mf8vGOdWa((object) xmlReader);
              num3 = 2;
              goto label_9;
            }
          case 7:
            enumerator = source.Cast<ImageAttribute>().GetEnumerator();
            num1 = 10;
            continue;
          case 8:
            EnumValueMetadata.u3QDOUbJaWvPEiaJ4geS((object) this, attribute4 != null ? EnumValueMetadata.t75dZCbJpTYBKicNVUJk((object) attribute4) : EnumValueMetadata.YGwmJMbJ3v8xRVIhdWB6(EnumValueMetadata.e0pNi1bJKWD2JfSCtKB8((object) this)));
            num1 = 23;
            continue;
          case 9:
            if (!EnumValueMetadata.x3wAvCbJPBlewxi0GDC0((object) propertyInfo, (object) null))
            {
              num1 = 20;
              continue;
            }
            goto case 5;
          case 10:
            goto label_22;
          case 12:
          case 20:
          case 28:
            attribute4 = AttributeHelper<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.GetAttribute(member, true);
            num1 = 8;
            continue;
          case 13:
            this.Images = new List<MetadataImage>();
            num1 = 7;
            continue;
          case 14:
            EnumValueMetadata.RUjRmebJOixDQl6sYRQD((object) this, attribute1 == null ? Guid.Empty : EnumValueMetadata.qSeV9nbJnC71q8lBJ1Kd((object) attribute1));
            num1 = 30;
            continue;
          case 15:
            goto label_56;
          case 16:
            enumBase = (EnumBase) EnumValueMetadata.lnHBZdbJNychJ3u6LtkX((object) propertyInfo, (object) null, (object) null);
            num1 = 22;
            continue;
          case 17:
            if (attribute2 == null)
            {
              num1 = 11;
              continue;
            }
            goto case 3;
          case 18:
            attribute2 = AttributeHelper<EnumMetadataAdditionalAttributesAttribute>.GetAttribute(member, true);
            num1 = 17;
            continue;
          case 19:
            this.Visibility = attribute3 == null ? Visibility.Visible : EnumValueMetadata.CL9drqbJwT8DhfCiMT3E((object) attribute3);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 6 : 18;
            continue;
          case 21:
            this.EnumValue = enumValue;
            num1 = 24;
            continue;
          case 22:
            this.EnumValue = (object) enumBase;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 28 : 5;
            continue;
          case 23:
            attribute5 = AttributeHelper<EleWise.ELMA.Model.Attributes.DescriptionAttribute>.GetAttribute(member, true);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
            continue;
          case 24:
            this.IntValue = new int?((int) enumValue);
            num1 = 12;
            continue;
          case 25:
            propertyInfo = member as PropertyInfo;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 3 : 9;
            continue;
          case 26:
            attribute1 = AttributeHelper<UidAttribute>.GetAttribute(member, false);
            num1 = 14;
            continue;
          case 27:
            Contract.ArgumentNotNull((object) member, (string) EnumValueMetadata.vc3HLqbJXSB5wVi5MBlk(2045296739 + 1688595713 ^ -561229030));
            num1 = 26;
            continue;
          case 29:
            attribute3 = AttributeHelper<ViewAttribute>.GetAttribute(member, true);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 19 : 2;
            continue;
          case 30:
            EnumValueMetadata.WFZ2MvbJe4u2tl3kAusA((object) this, EnumValueMetadata.Ko8qVsbJ2yheWWMxEMKu((object) member));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 4 : 2;
            continue;
        }
label_49:
        // ISSUE: type reference
        source = (object[]) EnumValueMetadata.S7n7ODbJxKc67iuvJemd((object) member, EnumValueMetadata.F7pU05bJ6f8Qye6wRvrB(__typeref (ImageAttribute)), false);
        num1 = 2;
      }
label_56:
      return;
label_54:
      return;
label_22:
      try
      {
label_24:
        if (EnumValueMetadata.qew2tobJ0SslHZ93WP7M((object) enumerator))
          goto label_27;
        else
          goto label_25;
label_23:
        ImageAttribute current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              this.Images.Add(new MetadataImage(current));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_27;
            case 3:
              goto label_51;
            default:
              goto label_24;
          }
        }
label_51:
        return;
label_25:
        num4 = 3;
        goto label_23;
label_27:
        current = enumerator.Current;
        num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        {
          num4 = 1;
          goto label_23;
        }
        else
          goto label_23;
      }
      finally
      {
        if (enumerator != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_34;
              default:
                EnumValueMetadata.qsTeaUbJ7d8Mf8vGOdWa((object) enumerator);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_34:;
      }
    }

    internal static void sIYoAcbJiCmNHOi7lHw2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Rb88EQbJVn86DjLvlM5i() => EnumValueMetadata.QTt2EKbJIj4RwhfjUc8Y == null;

    internal static EnumValueMetadata UQ84QkbJSsSQcsL4iBK9() => EnumValueMetadata.QTt2EKbJIj4RwhfjUc8Y;

    internal static object biMFgxbJRWWAeYMcBonp([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static bool BoEsDkbJqDRNgBIq3U34([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object e0pNi1bJKWD2JfSCtKB8([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object vc3HLqbJXSB5wVi5MBlk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Eu9T4hbJTwmJ3fCOQgsE([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object nTKD6KbJkwacNXQgAYCj(Type type, [In] object obj1) => (object) type.GetReflectionMember((string) obj1);

    internal static Guid qSeV9nbJnC71q8lBJ1Kd([In] object obj0) => ((UidAttribute) obj0).Uid;

    internal static void RUjRmebJOixDQl6sYRQD([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static object Ko8qVsbJ2yheWWMxEMKu([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static void WFZ2MvbJe4u2tl3kAusA([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static bool x3wAvCbJPBlewxi0GDC0([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static Type lT5YA0bJ1sswCMv26VqU([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static object lnHBZdbJNychJ3u6LtkX([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static object YGwmJMbJ3v8xRVIhdWB6([In] object obj0) => (object) (EleWise.ELMA.SR.LocalizableString) (string) obj0;

    internal static object t75dZCbJpTYBKicNVUJk([In] object obj0) => (object) ((LocalizedStringAttribute) obj0).LocalizedString;

    internal static void u3QDOUbJaWvPEiaJ4geS([In] object obj0, [In] object obj1) => NamedMetadata.SetDisplayName((NamedMetadata) obj0, (EleWise.ELMA.SR.LocalizableString) obj1);

    internal static object vRfx9FbJDOTeRbL0pCDq() => (object) EleWise.ELMA.SR.LocalizableString.Empty;

    internal static void X4dQExbJtqBOPxrhMhwo([In] object obj0, [In] object obj1) => NamedMetadata.SetDescription((NamedMetadata) obj0, (EleWise.ELMA.SR.LocalizableString) obj1);

    internal static Visibility CL9drqbJwT8DhfCiMT3E([In] object obj0) => ((ViewAttribute) obj0).Visibility;

    internal static object lvN7w6bJ4kIvIYsrZRRn([In] object obj0) => (object) XmlReader.Create((TextReader) obj0);

    internal static Type F7pU05bJ6f8Qye6wRvrB([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object cda07SbJHf82qe6gNLWq([In] object obj0, [In] object obj1) => ((XmlSerializer) obj0).Deserialize((XmlReader) obj1);

    internal static void eY1wLJbJATaDMyEGnxnJ([In] object obj0, [In] object obj1) => ((EnumValueMetadata) obj0).AdditionalAttributes = (EnumMetadataAdditionalAttribute[]) obj1;

    internal static void qsTeaUbJ7d8Mf8vGOdWa([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object S7n7ODbJxKc67iuvJemd([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1, obj2);

    internal static bool qew2tobJ0SslHZ93WP7M([In] object obj0) => ((IEnumerator) obj0).MoveNext();
  }
}
