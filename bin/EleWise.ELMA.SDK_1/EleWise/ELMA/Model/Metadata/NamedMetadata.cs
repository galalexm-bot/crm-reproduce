// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.NamedMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Базовый класс для метаданных объектов, имеющих имя, отображаемое имя и описание
  /// </summary>
  [DataContract]
  [DebuggerDisplay("Name: {Name}")]
  [Serializable]
  public abstract class NamedMetadata : AbstractMetadata, INamedMetadata
  {
    private string name;
    private EleWise.ELMA.SR.LocalizableString displayName;
    private EleWise.ELMA.SR.LocalizableString description;
    private static NamedMetadata IK5RpwbJJS0m3uDt11qr;

    /// <summary>Ctor</summary>
    public NamedMetadata()
    {
      NamedMetadata.KgfelEbJl7Ds3RKyHXW1();
      this.name = string.Empty;
      this.displayName = EleWise.ELMA.SR.LocalizableString.Empty;
      this.description = (EleWise.ELMA.SR.LocalizableString) NamedMetadata.IlmlDLbJrhxf03Tqo35Z();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>ToString</summary>
    /// <returns>ToString value</returns>
    public override string ToString()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!NamedMetadata.PRqntubJ5N5SmmXh21gI(NamedMetadata.zFy3wgbJgRQdTfcQ0Hf9((object) this)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) NamedMetadata.AovUbebJjowPfUZQIaYQ((object) this);
label_5:
      return this.DisplayName;
    }

    /// <summary>Имя объекта</summary>
    [EntityProperty]
    [DefaultValue("")]
    [PublicationBehaviour(PublicationType.Restart)]
    [XmlElement("Name")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [StringSettings(MaxValueString = "2000", FieldName = "Name")]
    [DataMember]
    [EleWise.ELMA.Model.Attributes.Uid("{906F9284-6F99-4215-A32C-BA9BA573DC34}")]
    public virtual string Name
    {
      get => this.name;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.name = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              NamedMetadata.eJMoOxbJYrIMVsGCKyud((object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 2;
              continue;
          }
        }
label_2:;
      }
    }

    /// <summary>Отображаемое имя</summary>
    [EntityProperty]
    [DefaultValue("")]
    [EleWise.ELMA.Globalization.Localizable]
    [DataMember]
    [XmlElement("DisplayName")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [StringSettings(FieldName = "DisplayName")]
    [EleWise.ELMA.Model.Attributes.Uid("{74202162-D32C-4869-AFA9-0DF2EDE0C0D7}")]
    public virtual string DisplayName
    {
      get => (string) this.displayName;
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
              this.displayName = (EleWise.ELMA.SR.LocalizableString) NamedMetadata.HfhGUObJLERckIMoTlZo((object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
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

    /// <summary>Описание</summary>
    [DataMember]
    [EleWise.ELMA.Globalization.Localizable]
    [EleWise.ELMA.Model.Attributes.Uid("{7F8E3A10-7112-478B-981F-B3F712610CCE}")]
    [DefaultValue("")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [StringSettings(FieldName = "Description", MaxValueString = "2147483647", MultiLine = true)]
    [XmlElement("Description")]
    [EntityProperty]
    public virtual string Description
    {
      get => (string) this.description;
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
              this.description = (EleWise.ELMA.SR.LocalizableString) NamedMetadata.HfhGUObJLERckIMoTlZo((object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
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

    /// <summary>Список изображений</summary>
    public virtual List<MetadataImage> Images { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeImages()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (this.Images == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return NamedMetadata.PcnV2KbJUtpgkRGwOFdj((object) this.Images) > 0;
label_3:
      return false;
    }

    /// <summary>Метаданные картинок</summary>
    public virtual List<NamedImageMetadata> NamedImages { get; set; }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public virtual bool ShouldSerializeNamedImages()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.NamedImages != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return this.NamedImages.Count > 0;
label_3:
      return false;
    }

    /// <summary>Получить изображение по умолчанию</summary>
    public virtual MetadataImage DefaultImage => this.GetDefaultImage((IEnumerable<MetadataImage>) this.Images);

    /// <summary>
    /// Получить иконку указанного размера. Если иконки такого размера нет и onlyToSize == false, то возвращается иконка с размером, наиболее близким к указанному, иначе null.
    /// </summary>
    /// <param name="size">Размер иконки</param>
    /// <param name="onlyToSize">Вернуть иконку только заданного размера</param>
    /// <returns>Иконка</returns>
    public virtual MetadataImage GetImage(int size, bool onlyToSize = false)
    {
      int num1 = 1;
      IEnumerable<MetadataImage> images;
      while (true)
      {
        int num2 = num1;
        int size1;
        int distanceToNearestSize;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              distanceToNearestSize = this.Images.Min<MetadataImage>((Func<MetadataImage, int>) (i => NamedMetadata.\u003C\u003Ec__DisplayClass23_0.FDSrMvCAIQFN7yrV6hOi(NamedMetadata.\u003C\u003Ec__DisplayClass23_0.gndsNRCAuQeTMUnZcHy2((object) i) - size1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 4;
              continue;
            case 3:
              goto label_4;
            case 4:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              images = this.Images.Where<MetadataImage>((Func<MetadataImage, bool>) (i => NamedMetadata.\u003C\u003Ec__DisplayClass23_0.FDSrMvCAIQFN7yrV6hOi(NamedMetadata.\u003C\u003Ec__DisplayClass23_0.gndsNRCAuQeTMUnZcHy2((object) i) - size1) == distanceToNearestSize));
              num2 = 7;
              continue;
            case 5:
              if (NamedMetadata.PcnV2KbJUtpgkRGwOFdj((object) this.Images) != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 2;
                continue;
              }
              goto label_4;
            case 6:
              if (this.Images != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 5;
                continue;
              }
              goto label_4;
            case 7:
              goto label_8;
            default:
              goto label_3;
          }
        }
label_3:
        size1 = size;
        num1 = 6;
      }
label_4:
      return (MetadataImage) null;
label_8:
      return this.GetDefaultImage(images);
    }

    public virtual MetadataImage GetNamedImage(string imageKey)
    {
      int num = 3;
      string imageKey1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            imageKey1 = imageKey;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          case 3:
            num = 2;
            continue;
          case 4:
            goto label_6;
          default:
            if (this.NamedImages == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
              continue;
            }
            goto label_6;
        }
      }
label_6:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.NamedImages.Where<NamedImageMetadata>((Func<NamedImageMetadata, bool>) (i => NamedMetadata.\u003C\u003Ec__DisplayClass24_0.EwKTuQCAqcJ8ATnsFKd9(NamedMetadata.\u003C\u003Ec__DisplayClass24_0.KSas9RCARgEGc3VlYSqt((object) i), (object) imageKey1))).Select<NamedImageMetadata, MetadataImage>((Func<NamedImageMetadata, MetadataImage>) (i => (MetadataImage) NamedMetadata.\u003C\u003Ec.XWAuv9CAnHUVUd4A3iRx((object) i))).FirstOrDefault<MetadataImage>();
label_7:
      return (MetadataImage) null;
    }

    public virtual void AddNamedImage(string imageKey, MetadataImage image)
    {
      int num = 3;
      string imageKey1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            this.RemoveNamedImage(imageKey1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            imageKey1 = imageKey;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 8 : 7;
            continue;
          case 3:
            num = 2;
            continue;
          case 4:
          case 10:
            // ISSUE: reference to a compiler-generated method
            this.NamedImages.RemoveAll((Predicate<NamedImageMetadata>) (i => NamedMetadata.\u003C\u003Ec__DisplayClass25_0.SJtOprCANkKmPOm3NnUB((object) i.ImageKey, (object) imageKey1)));
            num = 11;
            continue;
          case 5:
            goto label_6;
          case 6:
            this.NamedImages = new List<NamedImageMetadata>();
            num = 7;
            continue;
          case 7:
          case 11:
            List<NamedImageMetadata> namedImages = this.NamedImages;
            NamedImageMetadata namedImageMetadata = new NamedImageMetadata();
            namedImageMetadata.ImageKey = imageKey1;
            NamedMetadata.S6iHvkbJsWB4FHgbwwSC((object) namedImageMetadata, (object) image);
            namedImages.Add(namedImageMetadata);
            num = 5;
            continue;
          case 8:
            if (image != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 9 : 0;
              continue;
            }
            goto case 1;
          case 9:
            if (this.NamedImages != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 3 : 4;
              continue;
            }
            goto case 6;
          default:
            goto label_2;
        }
      }
label_7:
      return;
label_6:
      return;
label_2:;
    }

    public virtual void AddNamedImage(NamedImageMetadata image)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (image == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 1;
              continue;
            }
            break;
          case 3:
            goto label_2;
        }
        this.AddNamedImage((string) NamedMetadata.iRvfcKbJc3BxgdhCE74n((object) image), (MetadataImage) NamedMetadata.trsUPwbJzZe7sfL2Ntmt((object) image));
        num = 3;
      }
label_3:
      return;
label_2:;
    }

    public virtual void RemoveNamedImage(string imageKey)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        string imageKey1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_10;
            case 1:
              // ISSUE: reference to a compiler-generated method
              this.NamedImages.RemoveAll((Predicate<NamedImageMetadata>) (i => (string) NamedMetadata.\u003C\u003Ec__DisplayClass27_0.adfiOcCADev0P6E3TxXr((object) i) == imageKey1));
              num2 = 7;
              continue;
            case 2:
              imageKey1 = imageKey;
              num2 = 6;
              continue;
            case 3:
              goto label_4;
            case 4:
              goto label_6;
            case 5:
              goto label_5;
            case 6:
              if (this.NamedImages != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 1;
                continue;
              }
              goto label_15;
            case 7:
              if (this.NamedImages.Count != 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                continue;
              }
              goto case 8;
            case 8:
              this.NamedImages = (List<NamedImageMetadata>) null;
              num2 = 4;
              continue;
            default:
              goto label_3;
          }
        }
label_4:
        num1 = 2;
      }
label_10:
      return;
label_6:
      return;
label_5:
      return;
label_3:
      return;
label_15:;
    }

    /// <summary>Установить локализуемое отображаемое имя</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="displayName">Локализуемое отображаемое имя</param>
    internal static void SetDisplayName(NamedMetadata metadata, EleWise.ELMA.SR.LocalizableString displayName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            metadata.displayName = displayName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Установить локализуемое описание</summary>
    /// <param name="metadata">Метаданные</param>
    /// <param name="description">Локализуемое описание</param>
    internal static void SetDescription(NamedMetadata metadata, EleWise.ELMA.SR.LocalizableString description)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            metadata.description = description;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>При изменении имени объекта</summary>
    protected virtual void OnNameChanged()
    {
    }

    private MetadataImage GetDefaultImage(IEnumerable<MetadataImage> images) => images == null ? (MetadataImage) null : images.FirstOrDefault<MetadataImage>((Func<MetadataImage, bool>) (i => NamedMetadata.\u003C\u003Ec.BFNFohCAOkanKYXsStqS((object) i))) ?? images.FirstOrDefault<MetadataImage>();

    internal static void KgfelEbJl7Ds3RKyHXW1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object IlmlDLbJrhxf03Tqo35Z() => (object) EleWise.ELMA.SR.LocalizableString.Empty;

    internal static bool M0nTN4bJ9jF0P6K4vhkN() => NamedMetadata.IK5RpwbJJS0m3uDt11qr == null;

    internal static NamedMetadata jYqBgnbJdaZkpgTP2uul() => NamedMetadata.IK5RpwbJJS0m3uDt11qr;

    internal static object zFy3wgbJgRQdTfcQ0Hf9([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static bool PRqntubJ5N5SmmXh21gI([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object AovUbebJjowPfUZQIaYQ([In] object obj0) => (object) __nonvirtual (((Entity<long>) obj0).ToString());

    internal static void eJMoOxbJYrIMVsGCKyud([In] object obj0) => ((NamedMetadata) obj0).OnNameChanged();

    internal static object HfhGUObJLERckIMoTlZo([In] object obj0) => (object) (EleWise.ELMA.SR.LocalizableString) (string) obj0;

    internal static int PcnV2KbJUtpgkRGwOFdj([In] object obj0) => ((List<MetadataImage>) obj0).Count;

    internal static void S6iHvkbJsWB4FHgbwwSC([In] object obj0, [In] object obj1) => ((NamedImageMetadata) obj0).Image = (MetadataImage) obj1;

    internal static object iRvfcKbJc3BxgdhCE74n([In] object obj0) => (object) ((NamedImageMetadata) obj0).ImageKey;

    internal static object trsUPwbJzZe7sfL2Ntmt([In] object obj0) => (object) ((NamedImageMetadata) obj0).Image;
  }
}
