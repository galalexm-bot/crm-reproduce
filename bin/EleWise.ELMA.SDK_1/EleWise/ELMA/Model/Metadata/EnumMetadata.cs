// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.EnumMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.PublicationBehaviours;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Метаданные перечисления</summary>
  [XmlRoot("Enum")]
  [Serializable]
  public class EnumMetadata : 
    NamedDocumentedMetadata,
    IRootMetadata,
    IMetadata,
    IXsiType,
    ICodeItemMetadata,
    IGroupedMetadata,
    IValidatableMetadata,
    IDeltaRootMetadata
  {
    private string namespaceName;
    private string fullTypeName;
    private EleWise.ELMA.SR.LocalizableString namespaceForDisplay;
    internal static EnumMetadata GKryuCbMexq6EOAMDi5q;

    public EnumMetadata()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.namespaceForDisplay = (EleWise.ELMA.SR.LocalizableString) EnumMetadata.cX7IvvbMNb3kcwwCn40y();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.Values = new List<EnumValueMetadata>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          case 3:
            EnumMetadata.KwtpuZbMp4K9MTveEu4E((object) this, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
            continue;
          default:
            EnumMetadata.xHlT7rbM3VVAhhtDtUM6((object) this, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 3 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Пространство имен</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlElement("Namespace")]
    public virtual string Namespace
    {
      get => this.namespaceName;
      set
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EnumMetadata.E1Q51xbMabb81sCAx5TB((object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            case 2:
              this.namespaceName = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }
    }

    /// <summary>Отображаемое пространство имен</summary>
    [DefaultValue("")]
    [XmlElement("NamespaceForDisplay")]
    [EleWise.ELMA.Globalization.Localizable]
    public virtual string NamespaceForDisplay
    {
      get => (string) EnumMetadata.uWlAj9bMDGGU094Q9bg8((object) this.namespaceForDisplay);
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
              this.namespaceForDisplay = (EleWise.ELMA.SR.LocalizableString) EnumMetadata.PAMl6ubMtW4rUEBFRBZ4((object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
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

    /// <summary>Тип метаданных перечисления</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [DefaultValue(EnumMetadataType.Enum)]
    [XmlElement("Type")]
    public virtual EnumMetadataType Type
    {
      get => this.\u003CType\u003Ek__BackingField;
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
              this.\u003CType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
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

    /// <summary>Uid расширяемого перечисления</summary>
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlElement("BaseTypeUid")]
    public virtual Guid BaseTypeUid
    {
      get => this.\u003CBaseTypeUid\u003Ek__BackingField;
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
              this.\u003CBaseTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeBaseTypeUid() => EnumMetadata.JBSo9lbM4YCaC7dKRil3(EnumMetadata.CGe5wqbMwA4vr5n5NhE3((object) this), Guid.Empty);

    /// <summary>Идентификатор группы метаданных (или 0)</summary>
    [DefaultValue(0)]
    [XmlElement("GroupId")]
    public virtual long GroupId
    {
      get => this.\u003CGroupId\u003Ek__BackingField;
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
              this.\u003CGroupId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
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

    /// <summary>Показывать в дереве типов</summary>
    [XmlElement("ShowInTypeTree")]
    [DefaultValue(true)]
    public virtual bool ShowInTypeTree
    {
      get => this.\u003CShowInTypeTree\u003Ek__BackingField;
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
              this.\u003CShowInTypeTree\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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

    /// <summary>Показывать в дизайнере ELMA</summary>
    [DefaultValue(true)]
    [XmlElement("ShowInDesigner")]
    public virtual bool ShowInDesigner
    {
      get => this.\u003CShowInDesigner\u003Ek__BackingField;
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
              this.\u003CShowInDesigner\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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

    /// <summary>Полное имя типа</summary>
    public string FullTypeName
    {
      get
      {
        int num = 1;
        string fullTypeName1;
        string fullTypeName2;
        while (true)
        {
          switch (num)
          {
            case 1:
              fullTypeName2 = this.fullTypeName;
              if (fullTypeName2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              goto label_6;
            default:
              string str = !EnumMetadata.PFJod3bMHtwvxdUniUF2(EnumMetadata.KhTDuPbM6qvomKxyFnSl((object) this)) ? this.Namespace + (string) EnumMetadata.IXIn2HbMAabObAjJBl5G(~-397266137 ^ 397268508) : string.Empty;
              object obj = EnumMetadata.llYagHbM7OJBW6gkGQo7((object) this);
              this.fullTypeName = fullTypeName1 = (string) EnumMetadata.Xq7EQBbMxPTrsjC0ONgo((object) str, obj);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 2;
              continue;
          }
        }
label_3:
        return fullTypeName2;
label_6:
        return fullTypeName1;
      }
    }

    /// <summary>Создать значение (без добавления в список)</summary>
    /// <returns>Значение с новым Uid-ом</returns>
    public virtual EnumValueMetadata CreateValue()
    {
      EnumValueMetadata enumValueMetadata = new EnumValueMetadata();
      enumValueMetadata.Uid = Guid.NewGuid();
      return enumValueMetadata;
    }

    /// <summary>Значения перечисления</summary>
    [XmlArray("Values")]
    [PublicationBehaviour(typeof (NotRestartIfCollectionItemAddBehaviour))]
    public List<EnumValueMetadata> Values { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeValues()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (this.Values == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return EnumMetadata.uuLwZobM0Dh7cQZSdn9v((object) this.Values) > 0;
label_3:
      return false;
    }

    /// <summary>
    /// Уникальный идентификатор значения перечисления по умолчанию
    /// </summary>
    [XmlIgnore]
    [PublicationBehaviour(PublicationType.Restart)]
    public Guid? DefaultValueUid { get; set; }

    /// <summary>
    /// Уникальный идентификатор значения перечисления по умолчанию (для сериализации)
    /// </summary>
    [XmlElement("DefaultValueUid")]
    [DefaultValue("")]
    public string DefaultValueUidStr
    {
      get
      {
        int num = 5;
        Guid guid;
        Guid? defaultValueUid;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (defaultValueUid.Value != Guid.Empty)
              {
                defaultValueUid = this.DefaultValueUid;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 2 : 2;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 3 : 1;
              continue;
            case 2:
              guid = defaultValueUid.Value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_8;
            case 4:
              if (defaultValueUid.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 6 : 5;
                continue;
              }
              goto label_8;
            case 5:
              defaultValueUid = this.DefaultValueUid;
              num = 4;
              continue;
            case 6:
              defaultValueUid = this.DefaultValueUid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 1;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return guid.ToString();
label_8:
        return "";
      }
      set
      {
        int num1 = 2;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_4;
              case 2:
                if (!string.IsNullOrEmpty(value))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
                  continue;
                }
                goto label_17;
              case 3:
                goto label_14;
              default:
                goto label_17;
            }
          }
label_17:
          this.DefaultValueUid = new Guid?();
          num1 = 3;
        }
label_14:
        return;
label_4:
        try
        {
          this.DefaultValueUid = new Guid?(new Guid(value));
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
            num3 = 0;
          switch (num3)
          {
          }
        }
        catch (Exception ex)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 0:
                goto label_7;
              case 1:
                EnumMetadata.mykeHTbMMDH9a1Sc2F3t(EnumMetadata.Qg9QAybMmHdS6lZD06xx(), EnumMetadata.qicSO6bMynJPhTYHnmgL(EnumMetadata.IXIn2HbMAabObAjJBl5G(-1921202237 ^ -1921107355), (object) value), (object) ex);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                continue;
              default:
                goto label_3;
            }
          }
label_7:
          return;
label_3:;
        }
      }
    }

    /// <summary>Загрузить метаданные из типа</summary>
    /// <param name="type">Тип перечисления</param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    public virtual void LoadFromType(System.Type type, bool inherit = true)
    {
      int num1 = 17;
      while (true)
      {
        int num2 = num1;
        ShowInDesignerAttribute attribute1;
        BaseClassAttribute attribute2;
        NamespaceForDisplayAttribute attribute3;
        EleWise.ELMA.Model.Attributes.DisplayNameAttribute attribute4;
        AssemblyModuleAttribute attribute5;
        DefaultValueUidAttribute attribute6;
        EleWise.ELMA.Model.Attributes.DescriptionAttribute attribute7;
        EnumMetadataTypeAttribute attribute8;
        GroupIdAttribute attribute9;
        ShowInTypeTreeAttribute attribute10;
        while (true)
        {
          switch (num2)
          {
            case 1:
              EnumMetadata.lfCwNrbMliEHCOgcgS8w((object) this, attribute5 == null ? Guid.Empty : attribute5.Uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 17 : 26;
              continue;
            case 2:
              EnumMetadata.YfR3qYbJB7nggWf2Z2GO((object) this, attribute7 != null ? (object) attribute7.LocalizedString : EnumMetadata.cX7IvvbMNb3kcwwCn40y());
              num2 = 13;
              continue;
            case 3:
              EnumMetadata.byqZswbJFyyuraQKgTFB((object) this, attribute4 == null ? EnumMetadata.PAMl6ubMtW4rUEBFRBZ4((object) this.Name) : EnumMetadata.EwuSc6bMzrCw3jB1TjEw((object) attribute4));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 16 : 23;
              continue;
            case 4:
              attribute6 = AttributeHelper<DefaultValueUidAttribute>.GetAttribute(type, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            case 5:
              attribute8 = AttributeHelper<EnumMetadataTypeAttribute>.GetAttribute(type, false);
              num2 = 25;
              continue;
            case 6:
              EnumMetadata.xHlT7rbM3VVAhhtDtUM6((object) this, attribute10 == null || EnumMetadata.IwHKHmbJW4X7G8KxpZZv((object) attribute10));
              num2 = 7;
              continue;
            case 7:
              attribute1 = AttributeHelper<ShowInDesignerAttribute>.GetAttribute(type, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 19 : 22;
              continue;
            case 8:
              attribute3 = AttributeHelper<NamespaceForDisplayAttribute>.GetAttribute(type, false);
              num2 = 18;
              continue;
            case 9:
              this.LoadValuesFromType(type, inherit);
              num2 = 10;
              continue;
            case 10:
              goto label_32;
            case 11:
            case 14:
              EnumMetadata.WypKf8bMde1xPTrMkd1Y((object) this, EnumDescriptor.GetSubtypeUid(type));
              num2 = 30;
              continue;
            case 12:
              this.Values = new List<EnumValueMetadata>();
              num2 = 9;
              continue;
            case 13:
              attribute10 = AttributeHelper<ShowInTypeTreeAttribute>.GetAttribute(type, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 5 : 6;
              continue;
            case 15:
              attribute9 = AttributeHelper<GroupIdAttribute>.GetAttribute(type, false);
              num2 = 28;
              continue;
            case 16:
              if (!EnumMetadata.UPFx3gbM9MQhhNMtrIk6(type))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 3 : 11;
                continue;
              }
              goto case 29;
            case 17:
              EnumMetadata.zknEKGbMJGtjWkDo7nQ3((object) type, EnumMetadata.IXIn2HbMAabObAjJBl5G(132912447 ^ 132913437));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 16 : 3;
              continue;
            case 18:
              this.namespaceForDisplay = attribute3 != null ? (EleWise.ELMA.SR.LocalizableString) EnumMetadata.EwuSc6bMzrCw3jB1TjEw((object) attribute3) : (EleWise.ELMA.SR.LocalizableString) EnumMetadata.cX7IvvbMNb3kcwwCn40y();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 5 : 12;
              continue;
            case 19:
              attribute2 = AttributeHelper<BaseClassAttribute>.GetAttribute(type, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 3 : 24;
              continue;
            case 20:
              this.Name = (string) EnumMetadata.haVBDbbMghZf1BmL5FxX((object) type);
              num2 = 21;
              continue;
            case 21:
              EnumMetadata.qyKiR2bM5wgUAOQyH3Vw((object) this, (object) type.Namespace);
              num2 = 19;
              continue;
            case 22:
              EnumMetadata.KwtpuZbMp4K9MTveEu4E((object) this, attribute1 == null || EnumMetadata.QK2ygabJoKxIXRvH5T5n((object) attribute1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 4;
              continue;
            case 23:
              goto label_15;
            case 24:
              EnumMetadata.IeDVTKbMYXC24QsVKYA0((object) this, attribute2 != null ? EnumMetadata.XsyGx0bMj6aM5ncyiqjD((object) attribute2) : Guid.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 4 : 5;
              continue;
            case 25:
              EnumMetadata.VKU7WdbMUJDT0gJGqqZu((object) this, attribute8 != null ? EnumMetadata.nYak2DbMLHu3vlgUCJ6A((object) attribute8) : EnumMetadataType.Enum);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 15 : 0;
              continue;
            case 26:
              goto label_23;
            case 27:
              attribute4 = AttributeHelper<EleWise.ELMA.Model.Attributes.DisplayNameAttribute>.GetAttribute(type, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 1 : 3;
              continue;
            case 28:
              EnumMetadata.yNG86UbMcq5alaOORHkY((object) this, attribute9 == null ? 0L : EnumMetadata.ktrNAEbMsY6PCDXb9h2H((object) attribute9));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 27 : 13;
              continue;
            case 29:
              type = type.GetNonNullableType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 4 : 14;
              continue;
            case 30:
              attribute5 = AttributeHelper<AssemblyModuleAttribute>.GetAttribute(type.Assembly);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 0;
              continue;
            default:
              this.DefaultValueUid = attribute6 == null ? new Guid?() : new Guid?(attribute6.Uid);
              num2 = 8;
              continue;
          }
        }
label_15:
        attribute7 = AttributeHelper<EleWise.ELMA.Model.Attributes.DescriptionAttribute>.GetAttribute(type, true);
        num1 = 2;
        continue;
label_23:
        EnumMetadata.yASeEjbMrcvBS7cvCdTZ((object) this, !type.IsPublic && !type.IsNestedPublic);
        num1 = 20;
      }
label_32:;
    }

    /// <summary>Загрузить метаданные из типа</summary>
    /// <param name="enumType">Тип перечисления</param>
    public static EnumMetadata Load(System.Type enumType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            EnumMetadata.zknEKGbMJGtjWkDo7nQ3((object) enumType, EnumMetadata.IXIn2HbMAabObAjJBl5G(1917998801 >> 2 ^ 479619166));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      EnumMetadata enumMetadata = new EnumMetadata();
      enumMetadata.LoadFromType(enumType, true);
      return enumMetadata;
    }

    /// <summary>Требуют ли изменения в метаданных перезапуска сервера</summary>
    /// <param name="metadata">Измененные метаданные</param>
    /// <returns>True, если требуют</returns>
    public virtual bool IsRestartNeeded(IRootMetadata metadata) => EnumMetadata.GgTQgTbJb1ZtJmptqL8G((object) this, (object) metadata) == PublicationType.Restart;

    /// <summary>Применить изменения, не требующие перезапуска сервера</summary>
    public virtual void ApplyRestartUnrequiredChanges(bool inherit)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        EnumMetadata enumMetadata;
        while (true)
        {
          MetadataItemManager metadataItemManager1;
          MetadataItemManager metadataItemManager2;
          switch (num2)
          {
            case 1:
              if (enumMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              if (metadataItemManager1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 3 : 3;
                continue;
              }
              goto label_4;
            case 3:
              enumMetadata = EnumMetadata.DECMK5bJEJvMy93tukC9((object) metadataItemManager1, EnumMetadata.IUth26bJGQQ3nbiG72eK((object) this)) as EnumMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
              continue;
            case 4:
              goto label_7;
            case 5:
              metadataItemManager2 = (MetadataItemManager) null;
              break;
            case 6:
              metadataItemManager2 = Locator.GetService<MetadataItemManager>();
              break;
            case 7:
              if (EnumMetadata.IaZ3gobJhgmVK1myC9AL())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 6 : 4;
                continue;
              }
              goto case 5;
            case 8:
              goto label_9;
            case 9:
              goto label_5;
            default:
              goto label_8;
          }
          metadataItemManager1 = metadataItemManager2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 2;
        }
label_8:
        EnumMetadata.B3rl44bJfA8E0Q6tpEIW((object) this, (object) enumMetadata);
        num1 = 4;
      }
label_7:
      return;
label_9:
      return;
label_5:
      return;
label_4:
      return;
label_3:;
    }

    public virtual MetadataItemValidationError[] Validate()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.Values.Count != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
          case 3:
            goto label_2;
          case 4:
            if (this.Values == null)
            {
              num = 3;
              continue;
            }
            goto case 1;
          default:
            goto label_3;
        }
      }
label_2:
      MetadataItemValidationError[] itemValidationErrorArray = new MetadataItemValidationError[1];
      MetadataItemValidationError itemValidationError = new MetadataItemValidationError();
      itemValidationError.MetadataUid = EnumMetadata.IUth26bJGQQ3nbiG72eK((object) this);
      EnumMetadata.HxsajubJQIZtH35jG8bh((object) itemValidationError, (object) EleWise.ELMA.SR.T((string) EnumMetadata.IXIn2HbMAabObAjJBl5G(-1088304168 ^ -1088211418)));
      itemValidationErrorArray[0] = itemValidationError;
      return itemValidationErrorArray;
label_3:
      return (MetadataItemValidationError[]) null;
    }

    /// <summary>Загрузить значения перечисления из типа</summary>
    /// <param name="type">Тип</param>
    /// <param name="inherit"></param>
    /// <returns></returns>
    protected virtual void LoadValuesFromType(System.Type type, bool inherit)
    {
      int num1 = 9;
      EnumValueMetadata enumValueMetadata1;
      int index;
      FieldInfo[] reflectionFields;
      IEnumerator<PropertyInfo> enumerator;
      BindingFlags bindingAttr;
      FieldInfo member;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (inherit)
            {
              num1 = 12;
              continue;
            }
            goto case 11;
          case 2:
            goto label_7;
          case 3:
            bindingAttr = BindingFlags.Static | BindingFlags.Public;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 1;
            continue;
          case 4:
            ++index;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
            continue;
          case 5:
            goto label_27;
          case 6:
          case 12:
            enumerator = ((IEnumerable<PropertyInfo>) EnumMetadata.Gx7yn8bJvyPbkrEPRdlt(type, bindingAttr)).Where<PropertyInfo>((Func<PropertyInfo, bool>) (fi => fi.IsDefined(typeof (UidAttribute), false))).GetEnumerator();
            num1 = 15;
            continue;
          case 7:
            this.LoadExtensionValues(this);
            num1 = 5;
            continue;
          case 8:
            reflectionFields = type.GetReflectionFields(BindingFlags.Static | BindingFlags.Public);
            num1 = 20;
            continue;
          case 9:
            if (!type.IsEnum)
            {
              if (!type.IsClass)
              {
                num1 = 2;
                continue;
              }
              goto case 3;
            }
            else
            {
              num1 = 8;
              continue;
            }
          case 10:
            enumValueMetadata1.LoadFromMember((MemberInfo) member, EnumMetadata.g9V5hcbJC2buVlciki2X((object) member, (object) null));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 7 : 17;
            continue;
          case 11:
            bindingAttr |= BindingFlags.DeclaredOnly;
            num1 = 6;
            continue;
          case 14:
            enumValueMetadata1 = new EnumValueMetadata();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 7 : 10;
            continue;
          case 15:
            try
            {
label_14:
              if (enumerator.MoveNext())
                goto label_16;
              else
                goto label_15;
label_12:
              EnumValueMetadata enumValueMetadata2;
              PropertyInfo current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_14;
                  case 2:
                    this.Values.Add(enumValueMetadata2);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
                    continue;
                  case 3:
                    enumValueMetadata2.LoadFromMember((MemberInfo) current);
                    num2 = 2;
                    continue;
                  case 4:
                    enumValueMetadata2 = new EnumValueMetadata();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 3;
                    continue;
                  case 5:
                    goto label_2;
                  default:
                    goto label_16;
                }
              }
label_15:
              num2 = 5;
              goto label_12;
label_16:
              current = enumerator.Current;
              num2 = 4;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
              {
                num2 = 0;
                goto label_12;
              }
              else
                goto label_12;
            }
            finally
            {
              if (enumerator != null)
              {
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_25;
                    default:
                      EnumMetadata.xoklbVbJ8p5R2vN8b0QY((object) enumerator);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_25:;
            }
          case 16:
            goto label_36;
          case 17:
            this.Values.Add(enumValueMetadata1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 4 : 1;
            continue;
          case 18:
label_2:
            if (inherit)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 3 : 7;
              continue;
            }
            goto label_30;
          case 19:
            member = reflectionFields[index];
            num1 = 14;
            continue;
          case 20:
            index = 0;
            num1 = 13;
            continue;
          default:
            if (index >= reflectionFields.Length)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 8 : 16;
              continue;
            }
            goto case 19;
        }
      }
label_7:
      return;
label_27:
      return;
label_36:
      return;
label_30:;
    }

    /// <inheritdoc />
    protected override void OnNameChanged()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.fullTypeName = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 2:
            base.OnNameChanged();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>При изменении пространства имен</summary>
    protected virtual void OnNamespaceChanged()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.fullTypeName = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private void LoadExtensionValues(EnumMetadata metadata)
    {
      int num1 = 5;
      IEnumerator<Guid> enumerator1;
      while (true)
      {
        int num2 = num1;
        IMetadataRuntimeService metadataRuntimeService1;
        while (true)
        {
          IMetadataRuntimeService metadataRuntimeService2;
          EnumMetadata metadata1;
          switch (num2)
          {
            case 1:
              goto label_44;
            case 2:
              if (EnumMetadata.IaZ3gobJhgmVK1myC9AL())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 8 : 5;
                continue;
              }
              goto default;
            case 3:
              goto label_4;
            case 4:
              metadata1 = metadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 2 : 2;
              continue;
            case 5:
              num2 = 4;
              continue;
            case 6:
              IEnumerable<EnumMetadata> source = metadataRuntimeService1.GetMetadataList().OfType<EnumMetadata>().Where<EnumMetadata>((Func<EnumMetadata, bool>) (m =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      if (EnumMetadata.\u003C\u003Ec__DisplayClass55_0.rI0NUvCAWSVWDPoRjlHg((object) m) == EnumMetadataType.EnumExtension)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_3;
                    default:
                      goto label_2;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return EnumMetadata.\u003C\u003Ec__DisplayClass55_0.cqkLxACAbsL235dFfNwn(EnumMetadata.\u003C\u003Ec__DisplayClass55_0.YghjfNCAoTPyqoYDTQ0V((object) m), metadata1.Uid);
label_3:
                return false;
              }));
              // ISSUE: reference to a compiler-generated field
              Func<EnumMetadata, Guid> func = EnumMetadata.\u003C\u003Ec.\u003C\u003E9__55_1;
              Func<EnumMetadata, Guid> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                EnumMetadata.\u003C\u003Ec.\u003C\u003E9__55_1 = selector = (Func<EnumMetadata, Guid>) (m => EnumMetadata.\u003C\u003Ec.nJKFZICHsrypAxO1VpWW((object) m));
              }
              else
                goto label_47;
label_46:
              enumerator1 = source.Select<EnumMetadata, Guid>(selector).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 5 : 7;
              continue;
label_47:
              selector = func;
              goto label_46;
            case 7:
              goto label_6;
            case 8:
              metadataRuntimeService2 = Locator.GetService<IMetadataRuntimeService>();
              break;
            default:
              metadataRuntimeService2 = (IMetadataRuntimeService) null;
              break;
          }
          metadataRuntimeService1 = metadataRuntimeService2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 2 : 3;
        }
label_4:
        if (metadataRuntimeService1 != null)
          num1 = 6;
        else
          goto label_33;
      }
label_44:
      return;
label_33:
      return;
label_6:
      try
      {
label_27:
        if (EnumMetadata.UjyJJObJue5ZxXIXUTHu((object) enumerator1))
          goto label_8;
        else
          goto label_28;
label_7:
        List<EnumValueMetadata>.Enumerator enumerator2;
        int num4;
        switch (num4)
        {
          case 1:
            break;
          case 2:
            goto label_27;
          case 3:
            return;
          default:
            try
            {
label_17:
              if (enumerator2.MoveNext())
                goto label_13;
              else
                goto label_18;
label_12:
              int num5;
              EnumValueMetadata extValueMetadata;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    this.Values.Add(extValueMetadata);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    extValueMetadata = enumerator2.Current;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 4 : 4;
                    continue;
                  case 3:
                    if (!this.Values.Any<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v =>
                    {
                      int num6 = 1;
                      while (true)
                      {
                        switch (num6)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            if (EnumMetadata.\u003C\u003Ec__DisplayClass55_1.jRqqGECAQwKst7ZLDdHv((object) v) == null)
                            {
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                              continue;
                            }
                            goto label_4;
                          case 2:
                            goto label_4;
                          default:
                            goto label_5;
                        }
                      }
label_4:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      return EnumMetadata.\u003C\u003Ec__DisplayClass55_1.jRqqGECAQwKst7ZLDdHv((object) v).Equals(EnumMetadata.\u003C\u003Ec__DisplayClass55_1.jRqqGECAQwKst7ZLDdHv((object) extValueMetadata));
label_5:
                      return false;
                    })))
                    {
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
                      continue;
                    }
                    goto label_17;
                  case 4:
                    if (EnumMetadata.j6GiE7bJZPCTSTmso0vt((object) extValueMetadata) != null)
                    {
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 3;
                      continue;
                    }
                    goto label_17;
                  case 5:
                    goto label_13;
                  case 6:
                    goto label_27;
                  default:
                    goto label_17;
                }
              }
label_13:
              num5 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
              {
                num5 = 2;
                goto label_12;
              }
              else
                goto label_12;
label_18:
              num5 = 6;
              goto label_12;
            }
            finally
            {
              enumerator2.Dispose();
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
                num7 = 0;
              switch (num7)
              {
                default:
              }
            }
        }
label_8:
        enumerator2 = ((EnumMetadata) MetadataLoader.LoadMetadata(enumerator1.Current)).Values.GetEnumerator();
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
        {
          num4 = 0;
          goto label_7;
        }
        else
          goto label_7;
label_28:
        num4 = 3;
        goto label_7;
      }
      finally
      {
        int num8;
        if (enumerator1 == null)
          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
        else
          goto label_34;
label_31:
        switch (num8)
        {
          case 2:
            break;
          default:
        }
label_34:
        enumerator1.Dispose();
        num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        {
          num8 = 1;
          goto label_31;
        }
        else
          goto label_31;
      }
    }

    PublicationType IDeltaRootMetadata.GetPublicationTypeOnChange(IMetadata oldMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.Type == EnumMetadataType.Enum)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return PublicationType.Restart;
label_5:
      return EnumMetadata.GgTQgTbJb1ZtJmptqL8G((object) oldMetadata, (object) this);
    }

    internal static object cX7IvvbMNb3kcwwCn40y() => (object) EleWise.ELMA.SR.LocalizableString.Empty;

    internal static void xHlT7rbM3VVAhhtDtUM6([In] object obj0, bool value) => ((EnumMetadata) obj0).ShowInTypeTree = value;

    internal static void KwtpuZbMp4K9MTveEu4E([In] object obj0, bool value) => ((EnumMetadata) obj0).ShowInDesigner = value;

    internal static bool t42rfHbMPoyoQYR6f1lc() => EnumMetadata.GKryuCbMexq6EOAMDi5q == null;

    internal static EnumMetadata WYq0nrbM1N5cQApvHstJ() => EnumMetadata.GKryuCbMexq6EOAMDi5q;

    internal static void E1Q51xbMabb81sCAx5TB([In] object obj0) => ((EnumMetadata) obj0).OnNamespaceChanged();

    internal static object uWlAj9bMDGGU094Q9bg8([In] object obj0) => (object) (string) (EleWise.ELMA.SR.LocalizableString) obj0;

    internal static object PAMl6ubMtW4rUEBFRBZ4([In] object obj0) => (object) (EleWise.ELMA.SR.LocalizableString) (string) obj0;

    internal static Guid CGe5wqbMwA4vr5n5NhE3([In] object obj0) => ((EnumMetadata) obj0).BaseTypeUid;

    internal static bool JBSo9lbM4YCaC7dKRil3([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object KhTDuPbM6qvomKxyFnSl([In] object obj0) => (object) ((EnumMetadata) obj0).Namespace;

    internal static bool PFJod3bMHtwvxdUniUF2([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object IXIn2HbMAabObAjJBl5G(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object llYagHbM7OJBW6gkGQo7([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object Xq7EQBbMxPTrsjC0ONgo([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static int uuLwZobM0Dh7cQZSdn9v([In] object obj0) => ((List<EnumValueMetadata>) obj0).Count;

    internal static object Qg9QAybMmHdS6lZD06xx() => (object) Logger.Log;

    internal static object qicSO6bMynJPhTYHnmgL([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void mykeHTbMMDH9a1Sc2F3t([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void zknEKGbMJGtjWkDo7nQ3([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool UPFx3gbM9MQhhNMtrIk6(System.Type type) => type.IsNullableType();

    internal static void WypKf8bMde1xPTrMkd1Y([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static void lfCwNrbMliEHCOgcgS8w([In] object obj0, Guid value) => ((AbstractMetadata) obj0).ModuleUid = value;

    internal static void yASeEjbMrcvBS7cvCdTZ([In] object obj0, bool value) => ((AbstractMetadata) obj0).Internal = value;

    internal static object haVBDbbMghZf1BmL5FxX([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static void qyKiR2bM5wgUAOQyH3Vw([In] object obj0, [In] object obj1) => ((EnumMetadata) obj0).Namespace = (string) obj1;

    internal static Guid XsyGx0bMj6aM5ncyiqjD([In] object obj0) => ((BaseClassAttribute) obj0).BaseClassUid;

    internal static void IeDVTKbMYXC24QsVKYA0([In] object obj0, Guid value) => ((EnumMetadata) obj0).BaseTypeUid = value;

    internal static EnumMetadataType nYak2DbMLHu3vlgUCJ6A([In] object obj0) => ((EnumMetadataTypeAttribute) obj0).Type;

    internal static void VKU7WdbMUJDT0gJGqqZu([In] object obj0, EnumMetadataType value) => ((EnumMetadata) obj0).Type = value;

    internal static long ktrNAEbMsY6PCDXb9h2H([In] object obj0) => ((GroupIdAttribute) obj0).Id;

    internal static void yNG86UbMcq5alaOORHkY([In] object obj0, long value) => ((EnumMetadata) obj0).GroupId = value;

    internal static object EwuSc6bMzrCw3jB1TjEw([In] object obj0) => (object) ((LocalizedStringAttribute) obj0).LocalizedString;

    internal static void byqZswbJFyyuraQKgTFB([In] object obj0, [In] object obj1) => NamedMetadata.SetDisplayName((NamedMetadata) obj0, (EleWise.ELMA.SR.LocalizableString) obj1);

    internal static void YfR3qYbJB7nggWf2Z2GO([In] object obj0, [In] object obj1) => NamedMetadata.SetDescription((NamedMetadata) obj0, (EleWise.ELMA.SR.LocalizableString) obj1);

    internal static bool IwHKHmbJW4X7G8KxpZZv([In] object obj0) => ((ShowInTypeTreeAttribute) obj0).Visible;

    internal static bool QK2ygabJoKxIXRvH5T5n([In] object obj0) => ((ShowInDesignerAttribute) obj0).Visible;

    internal static PublicationType GgTQgTbJb1ZtJmptqL8G([In] object obj0, [In] object obj1) => MetadataSoftPublishHelper.IsEqualsObject(obj0, obj1);

    internal static bool IaZ3gobJhgmVK1myC9AL() => Locator.Initialized;

    internal static Guid IUth26bJGQQ3nbiG72eK([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object DECMK5bJEJvMy93tukC9([In] object obj0, Guid metadataUid) => (object) ((MetadataItemManager) obj0).GetSoftPublishedMetadata(metadataUid);

    internal static void B3rl44bJfA8E0Q6tpEIW([In] object obj0, [In] object obj1) => MetadataSoftPublishHelper.CopyChanges((IMetadata) obj0, (IMetadata) obj1);

    internal static void HxsajubJQIZtH35jG8bh([In] object obj0, [In] object obj1) => ((MetadataItemValidationError) obj0).Message = (string) obj1;

    internal static object g9V5hcbJC2buVlciki2X([In] object obj0, [In] object obj1) => ((FieldInfo) obj0).GetValue(obj1);

    internal static object Gx7yn8bJvyPbkrEPRdlt(System.Type type, BindingFlags bindingAttr) => (object) type.GetReflectionProperties(bindingAttr);

    internal static void xoklbVbJ8p5R2vN8b0QY([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object j6GiE7bJZPCTSTmso0vt([In] object obj0) => ((EnumValueMetadata) obj0).EnumValue;

    internal static bool UjyJJObJue5ZxXIXUTHu([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    /// <summary>Информация о типе метаданных</summary>
    [Component]
    public class Info : IMetadataTypeInfo
    {
      internal static EnumMetadata.Info S3cGR1CHJE6GUQkGHTfm;

      public string Name => EleWise.ELMA.SR.T((string) EnumMetadata.Info.mOrVU5CHle3CZT3G5YBb(1251470110 >> 2 ^ 312964469));

      public string Description => (string) EnumMetadata.Info.KxxFxcCHrREDPKpnsaty(EnumMetadata.Info.mOrVU5CHle3CZT3G5YBb(44884861 ^ 44649599));

      public System.Type MetadataType => EnumMetadata.Info.eksutiCHgCIRCReR0TAX(__typeref (EnumMetadata));

      public System.Type GeneratorType => EnumMetadata.Info.eksutiCHgCIRCReR0TAX(__typeref (EnumGenerator));

      public Info()
      {
        EnumMetadata.Info.gwu8VZCH5iHs0kduwnhr();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object mOrVU5CHle3CZT3G5YBb(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool rTmCQtCH9YOqgREk2BPI() => EnumMetadata.Info.S3cGR1CHJE6GUQkGHTfm == null;

      internal static EnumMetadata.Info Rd3ppACHdJ5auEZC4cnR() => EnumMetadata.Info.S3cGR1CHJE6GUQkGHTfm;

      internal static object KxxFxcCHrREDPKpnsaty([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static System.Type eksutiCHgCIRCReR0TAX([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

      internal static void gwu8VZCH5iHs0kduwnhr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
