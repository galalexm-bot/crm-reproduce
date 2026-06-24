// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.MetadataImage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Класс для хранения данных об изображении для какого-либо объекта метаданных
  /// </summary>
  [Serializable]
  public class MetadataImage : ISerializable
  {
    [NonSerialized]
    private ImageAttribute imageAttribute;
    [NonSerialized]
    private string rawData;
    private byte[] data;
    private static MetadataImage GGjmopbHetwFCN82Prvg;

    /// <summary>Ctor</summary>
    public MetadataImage()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="fileName"></param>
    public MetadataImage(string fileName)
    {
      MetadataImage.EPmCZBbHNSXM5NdgAHhG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 4;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            this.Format = ImageFormatType.Svg;
            num1 = 2;
            continue;
          case 2:
            goto label_6;
          case 3:
            goto label_3;
          case 4:
            this.ResourceName = fileName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          case 5:
            if (!this.HasSvgExtension(fileName))
            {
              num2 = 3;
              break;
            }
            goto case 1;
          default:
            this.Data = File.ReadAllBytes(fileName);
            num2 = 5;
            break;
        }
        num1 = num2;
      }
label_6:
      return;
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="imageAttribute">Атрибут, содержащий картинку</param>
    public MetadataImage(ImageAttribute imageAttribute)
    {
      MetadataImage.EPmCZBbHNSXM5NdgAHhG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 7;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            this.IsDefault = MetadataImage.hvAIvJbHpJASr5XCu5wD((object) imageAttribute);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            this.IncludeSvgFields(imageAttribute);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
            continue;
          case 5:
            if (!this.IsSvg())
            {
              num = 3;
              continue;
            }
            goto case 4;
          case 6:
            this.Size = MetadataImage.J6KQ7pbH3S0OVDlEkjbB((object) imageAttribute);
            num = 8;
            continue;
          case 7:
            this.imageAttribute = imageAttribute;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 6 : 6;
            continue;
          case 8:
            this.Format = imageAttribute.Format;
            num = 2;
            continue;
          default:
            this.ResourceName = (string) MetadataImage.Wf6HspbHawaM7ACEcy09((object) imageAttribute);
            num = 5;
            continue;
        }
      }
label_7:
      return;
label_2:;
    }

    /// <summary>Размер изображения</summary>
    public int Size
    {
      get => this.\u003CSize\u003Ek__BackingField;
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
              this.\u003CSize\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    /// <summary>Является ли изображением по умолчанию</summary>
    public bool IsDefault
    {
      get => this.\u003CIsDefault\u003Ek__BackingField;
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
              this.\u003CIsDefault\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
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

    /// <summary>Формат изображения</summary>
    public ImageFormatType Format
    {
      get => this.\u003CFormat\u003Ek__BackingField;
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
              this.\u003CFormat\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
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

    /// <summary>Бинарные данные изображения</summary>
    public byte[] Data
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.data != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 3:
              this.data = (byte[]) MetadataImage.UQU2NAbHDcpM6OeEacy1((object) this.imageAttribute);
              num = 4;
              continue;
            case 5:
              if (this.imageAttribute == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 1;
                continue;
              }
              goto case 3;
            default:
              goto label_2;
          }
        }
label_2:
        return this.data;
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
              this.data = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

    /// <summary>Текстовые данные изображения(SVG)</summary>
    public string RawData
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.Format == ImageFormatType.Svg)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              if (this.Data == null)
              {
                num = 4;
                continue;
              }
              goto label_4;
            case 3:
            case 4:
              goto label_5;
            case 5:
              goto label_4;
            default:
              if (!string.IsNullOrWhiteSpace(this.rawData))
              {
                num = 3;
                continue;
              }
              goto case 2;
          }
        }
label_4:
        return this.GetRawData(this.Data);
label_5:
        return this.rawData;
      }
    }

    /// <summary>Наименование ресурса изображения</summary>
    public string ResourceName
    {
      get => this.\u003CResourceName\u003Ek__BackingField;
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
              this.\u003CResourceName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
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
    /// Создать изображение. После использования необходимо уничтожить.
    /// </summary>
    public Image CreateImage()
    {
      int num1 = 6;
      MemoryStream memoryStream;
      while (true)
      {
        byte[] numArray1;
        byte[] numArray2;
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            goto label_8;
          case 3:
            if (numArray1 != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 4:
            goto label_10;
          case 5:
            numArray2 = this.Data;
            break;
          case 6:
            if (this.Format != ImageFormatType.IconPack)
            {
              num1 = 5;
              continue;
            }
            numArray2 = this.GetIconPackContent();
            break;
          default:
            memoryStream = (MemoryStream) MetadataImage.cB0iQUbHtCp85GDtrIFL((object) numArray1, false);
            num1 = 4;
            continue;
        }
        numArray1 = numArray2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 3;
      }
label_4:
      Image image;
      return image;
label_8:
      return (Image) null;
label_10:
      try
      {
        int num2;
        if (this.IsSvg())
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
        else
          goto label_14;
label_12:
        while (true)
        {
          switch (num2)
          {
            case 1:
              image = (Image) MetadataImage.AWUj2hbHwMvRGZot5QYs((object) memoryStream, ImageFormatType.Png, 16);
              num2 = 2;
              continue;
            case 2:
            case 3:
              goto label_4;
            default:
              goto label_14;
          }
        }
label_14:
        image = (Image) new Bitmap((Stream) memoryStream);
        num2 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
        {
          num2 = 1;
          goto label_12;
        }
        else
          goto label_12;
      }
      finally
      {
        if (memoryStream != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_21;
              default:
                MetadataImage.yhRSVVbH4a0nHFyZB5Bc((object) memoryStream);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 0;
                continue;
            }
          }
        }
label_21:;
      }
    }

    /// <summary>Изображение в Svg-формате</summary>
    /// <returns></returns>
    public bool IsSvg()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.Format != ImageFormatType.IconPack)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return this.Format == ImageFormatType.Svg;
label_5:
      return true;
    }

    /// <summary>Проверка расширения файла на наличие .svg</summary>
    /// <param name="fileName">Наименование файла</param>
    /// <returns></returns>
    private bool HasSvgExtension(string fileName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (MetadataImage.BYOYBtbH69x4nDO0TUO1((object) fileName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return false;
label_3:
      return MetadataImage.S6tGQfbH7583ccvfXwlN(MetadataImage.UwP2mMbHHkG9GaBcV0Ue((object) Path.GetExtension(fileName)), MetadataImage.JUAr86bHAegHmrewDbXj(-1487388570 ^ -1487227040));
    }

    /// <summary>Заполнить поля SVG-элемента</summary>
    /// <param name="imageAttribute"></param>
    private void IncludeSvgFields(ImageAttribute imageAttribute)
    {
      int num = 2;
      byte[] binary;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ResourceName = (string) MetadataImage.Wf6HspbHawaM7ACEcy09((object) imageAttribute);
            num = 5;
            continue;
          case 2:
            if (MetadataImage.UHNbfhbHxBFffPpsTy6o((object) imageAttribute) == ImageFormatType.IconPack)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
              continue;
            }
            binary = (byte[]) MetadataImage.UQU2NAbHDcpM6OeEacy1((object) imageAttribute);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_5;
          case 4:
            this.rawData = this.GetRawData(binary);
            num = 6;
            continue;
          case 5:
            this.data = (byte[]) MetadataImage.KHIiygbHm4O0U8jOeJ9V(MetadataImage.rAf9ujbH0UNH3I3WITeN(), MetadataImage.Wf6HspbHawaM7ACEcy09((object) imageAttribute));
            num = 3;
            continue;
          case 6:
            goto label_2;
          default:
            if (binary != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 4 : 2;
              continue;
            }
            goto label_12;
        }
      }
label_5:
      return;
label_2:
      return;
label_12:;
    }

    /// <summary>Получить массив байт иконки IconPack</summary>
    /// <returns></returns>
    private byte[] GetIconPackContent()
    {
      int num1 = 1;
      IconModel iconModel;
      while (true)
      {
        int num2 = num1;
        IIconPackService service;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              service = Locator.GetService<IIconPackService>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_9;
            case 3:
              goto label_7;
            case 4:
              iconModel = (IconModel) MetadataImage.MQqeudbHM9xMFtHh5LJ4((object) service, (object) str);
              num2 = 6;
              continue;
            case 5:
              goto label_8;
            case 6:
              goto label_11;
            default:
              if (service == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 1;
                continue;
              }
              str = (string) MetadataImage.XjaV6pbHy3e5WDhPNPbt((object) Encoding.UTF8, (object) this.Data);
              num2 = 4;
              continue;
          }
        }
label_11:
        if (iconModel == null)
          num1 = 5;
        else
          break;
      }
label_7:
      return (byte[]) MetadataImage.KHIiygbHm4O0U8jOeJ9V(MetadataImage.rAf9ujbH0UNH3I3WITeN(), MetadataImage.DRlHPwbHJqZiciIYMxkb((object) iconModel));
label_8:
      return (byte[]) null;
label_9:
      return (byte[]) null;
    }

    private string GetRawData(byte[] binary) => (string) MetadataImage.LWxEw1bH9AuKC1i6er7j((object) ((Encoding) MetadataImage.rAf9ujbH0UNH3I3WITeN()).GetString(binary), MetadataImage.JUAr86bHAegHmrewDbXj(1505778440 - 1981636111 ^ -476050453), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304623215));

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Serialization context</param>
    protected MetadataImage(SerializationInfo info, StreamingContext context)
    {
      MetadataImage.EPmCZBbHNSXM5NdgAHhG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            this.Format = (ImageFormatType) info.GetValue((string) MetadataImage.JUAr86bHAegHmrewDbXj(-1317790512 ^ -1317606418), MetadataImage.dXAYRMbHlTBBEkpCcrlN(__typeref (ImageFormatType)));
            num = 4;
            continue;
          case 2:
            this.IsDefault = info.GetBoolean((string) MetadataImage.JUAr86bHAegHmrewDbXj(-1858887263 ^ -1859037559));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.Data = (byte[]) MetadataImage.Ce2fPkbHrqOlMqV8cu72((object) info, MetadataImage.JUAr86bHAegHmrewDbXj(1917256330 ^ 1917300226), typeof (byte[]));
            num = 3;
            continue;
          default:
            this.Size = MetadataImage.bt3pr2bHdFjEHlkcDvv8((object) info, MetadataImage.JUAr86bHAegHmrewDbXj(1994213607 >> 4 ^ 124724114));
            num = 2;
            continue;
        }
      }
label_3:;
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            MetadataImage.rkGKebbH5Z6a9PmZp7WD((object) info, MetadataImage.JUAr86bHAegHmrewDbXj(813604817 ^ 813459695), (object) this.Format);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 4 : 4;
            continue;
          case 2:
            MetadataImage.ckNmEIbHg1vUN4fVtTDO((object) info, MetadataImage.JUAr86bHAegHmrewDbXj(381945751 ^ 1158627804 ^ 1405727075), this.IsDefault);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 1;
            continue;
          case 3:
            info.AddValue((string) MetadataImage.JUAr86bHAegHmrewDbXj(1304605005 ^ 1304446545), this.Size);
            num = 2;
            continue;
          case 4:
            MetadataImage.rkGKebbH5Z6a9PmZp7WD((object) info, MetadataImage.JUAr86bHAegHmrewDbXj(1149433385 + 173655049 ^ 1323046586), (object) this.Data);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    /// <summary>
    /// Нужно ли сериализовать наименование ресурса изображения
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeResourceName() => !MetadataImage.BYOYBtbH69x4nDO0TUO1((object) this.ResourceName);

    internal static bool nDqxBQbHPwl4xGXUmeDH() => MetadataImage.GGjmopbHetwFCN82Prvg == null;

    internal static MetadataImage BU22gZbH1PDx4RXXiWt8() => MetadataImage.GGjmopbHetwFCN82Prvg;

    internal static void EPmCZBbHNSXM5NdgAHhG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static int J6KQ7pbH3S0OVDlEkjbB([In] object obj0) => ((ImageAttribute) obj0).Size;

    internal static bool hvAIvJbHpJASr5XCu5wD([In] object obj0) => ((ImageAttribute) obj0).IsDefault;

    internal static object Wf6HspbHawaM7ACEcy09([In] object obj0) => (object) ((ImageAttribute) obj0).ResouseName;

    internal static object UQU2NAbHDcpM6OeEacy1([In] object obj0) => (object) ((ImageAttribute) obj0).GetImageData();

    internal static object cB0iQUbHtCp85GDtrIFL([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);

    internal static object AWUj2hbHwMvRGZot5QYs([In] object obj0, ImageFormatType type, int size) => (object) SvgHelper.Convert((MemoryStream) obj0, type, size);

    internal static void yhRSVVbH4a0nHFyZB5Bc([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool BYOYBtbH69x4nDO0TUO1([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object UwP2mMbHHkG9GaBcV0Ue([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object JUAr86bHAegHmrewDbXj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool S6tGQfbH7583ccvfXwlN([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

    internal static ImageFormatType UHNbfhbHxBFffPpsTy6o([In] object obj0) => ((ImageAttribute) obj0).Format;

    internal static object rAf9ujbH0UNH3I3WITeN() => (object) Encoding.UTF8;

    internal static object KHIiygbHm4O0U8jOeJ9V([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetBytes((string) obj1);

    internal static object XjaV6pbHy3e5WDhPNPbt([In] object obj0, [In] object obj1) => (object) ((Encoding) obj0).GetString((byte[]) obj1);

    internal static object MQqeudbHM9xMFtHh5LJ4([In] object obj0, [In] object obj1) => (object) ((IIconPackService) obj0).GetIcon((string) obj1);

    internal static object DRlHPwbHJqZiciIYMxkb([In] object obj0) => (object) ((IconModel) obj0).Data;

    internal static object LWxEw1bH9AuKC1i6er7j([In] object obj0, [In] object obj1, [In] object obj2) => (object) Regex.Replace((string) obj0, (string) obj1, (string) obj2);

    internal static int bt3pr2bHdFjEHlkcDvv8([In] object obj0, [In] object obj1) => ((SerializationInfo) obj0).GetInt32((string) obj1);

    internal static Type dXAYRMbHlTBBEkpCcrlN([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Ce2fPkbHrqOlMqV8cu72([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static void ckNmEIbHg1vUN4fVtTDO([In] object obj0, [In] object obj1, [In] bool obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static void rkGKebbH5Z6a9PmZp7WD([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);
  }
}
