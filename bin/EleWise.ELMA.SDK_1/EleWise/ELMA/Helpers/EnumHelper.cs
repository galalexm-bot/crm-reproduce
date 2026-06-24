// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.EnumHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Помощник для работы с перечислениями</summary>
  public static class EnumHelper
  {
    internal static EnumHelper Md2i9ThzTZx3CL1al1Ho;

    /// <summary>Получить Uid элемента перечисления</summary>
    /// <param name="value">Элемент перечисления</param>
    /// <returns>Uid</returns>
    public static Guid GetUid(object value)
    {
      int num = 1;
      EnumValueMetadata metadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadata = EnumHelper.GetMetadata(value);
            if (metadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return Guid.Empty;
label_5:
      return EnumHelper.L948MRhzOL6r4CL6KkHD((object) metadata);
    }

    /// <summary>Получить отображаемое имя для элемента перечисления</summary>
    /// <param name="value">Элемент перечисления</param>
    /// <returns>Отображаемое имя</returns>
    public static string GetDisplayName(object value)
    {
      int num = 1;
      object displayName;
      while (true)
      {
        switch (num)
        {
          case 1:
            EnumValueMetadata metadata = EnumHelper.GetMetadata(value);
            if (metadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
              continue;
            }
            displayName = EnumHelper.fyP3jShz2CHU0nnpLykw((object) metadata);
            break;
          case 2:
            goto label_9;
          default:
            displayName = (object) null;
            break;
        }
        if (displayName == null)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 2;
        else
          break;
      }
      return (string) displayName;
label_9:
      return value.ToString();
    }

    /// <summary>Получить отображаемое имя для элемента перечисления</summary>
    /// <param name="enumValue">Элемент перечисления</param>
    /// <returns>Отображаемое имя</returns>
    public static string GetDisplayName(this Enum enumValue) => (string) EnumHelper.ku1WQFhzeE9irAsN92GB((object) enumValue);

    /// <summary>
    /// Получить отображаемое имя для элемента расширяемого перечисления
    /// </summary>
    /// <param name="enumValue">Элемент перечисления</param>
    /// <returns>Отображаемое имя</returns>
    public static string GetDisplayName(this EnumBase enumValue) => (string) EnumHelper.ku1WQFhzeE9irAsN92GB((object) enumValue);

    /// <summary>Получить изображение для элемента перечисления</summary>
    /// <param name="value">Элемент перечисления</param>
    /// <param name="size">Требуемый размер изображения</param>
    /// <returns>Изображение</returns>
    public static Image GetImage(object value, int size)
    {
      int num1 = 13;
      MetadataImage metadataImage;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          List<MetadataImage> source1;
          List<MetadataImage> metadataImageList;
          int size1;
          switch (num2)
          {
            case 1:
            case 6:
              if (metadataImage != null)
              {
                num2 = 7;
                continue;
              }
              goto label_3;
            case 2:
              List<MetadataImage> source2 = source1;
              // ISSUE: reference to a compiler-generated field
              Func<MetadataImage, bool> func = EnumHelper.\u003C\u003Ec.\u003C\u003E9__4_1;
              Func<MetadataImage, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                EnumHelper.\u003C\u003Ec.\u003C\u003E9__4_1 = predicate = (Func<MetadataImage, bool>) (a => EnumHelper.\u003C\u003Ec.hJvjdZvJL2kJWpvCwO2d((object) a));
              }
              else
                goto label_16;
label_26:
              metadataImage = source2.FirstOrDefault<MetadataImage>(predicate);
              num2 = 8;
              continue;
label_16:
              predicate = func;
              goto label_26;
            case 3:
              if (source1 != null)
              {
                // ISSUE: reference to a compiler-generated method
                metadataImage = source1.FirstOrDefault<MetadataImage>((Func<MetadataImage, bool>) (a => EnumHelper.\u003C\u003Ec__DisplayClass4_0.c2eGWnvJrsAlfSJNt6Ix((object) a) == size1));
                num2 = 9;
                continue;
              }
              goto label_18;
            case 4:
              object obj = EnumHelper.iSP22ohzPKWFw8PPbJmt(value);
              if (obj == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 4 : 5;
                continue;
              }
              metadataImageList = ((NamedMetadata) obj).Images;
              break;
            case 5:
              metadataImageList = (List<MetadataImage>) null;
              break;
            case 7:
              goto label_4;
            case 8:
              if (metadataImage != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
                continue;
              }
              goto default;
            case 9:
              if (metadataImage == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 2 : 2;
                continue;
              }
              goto case 8;
            case 10:
              goto label_11;
            case 11:
              goto label_3;
            case 12:
              size1 = size;
              num2 = 4;
              continue;
            case 13:
              num2 = 12;
              continue;
            default:
              metadataImage = source1.FirstOrDefault<MetadataImage>();
              num2 = 6;
              continue;
          }
          source1 = metadataImageList;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 3 : 3;
        }
label_18:
        num1 = 10;
      }
label_3:
      return (Image) null;
label_4:
      return (Image) EnumHelper.hBT6X2hz1iu1yGICQ34r((object) metadataImage);
label_11:
      return (Image) null;
    }

    private static EnumValueMetadata GetMetadata(object value)
    {
      int num1 = 4;
      EnumMetadata enumMetadata;
      string name;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_3;
            case 3:
              goto label_5;
            case 4:
              num2 = 3;
              continue;
            case 5:
              name = !(value is EnumBase enumBase) ? value.ToString() : enumBase.Name;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        if (enumMetadata != null)
        {
          num1 = 5;
          continue;
        }
        goto label_8;
label_5:
        enumMetadata = MetadataLoader.LoadMetadata(value.GetType()) as EnumMetadata;
        num1 = 2;
      }
label_6:
      // ISSUE: reference to a compiler-generated method
      return enumMetadata.Values.FirstOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v => EnumHelper.\u003C\u003Ec__DisplayClass5_0.yjGgZmv9FSop8Ajaw8Qr((object) v.Name, (object) name)));
label_8:
      return (EnumValueMetadata) null;
    }

    internal static Guid L948MRhzOL6r4CL6KkHD([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool mFbb9ohzkJuyyHAZmUC7() => EnumHelper.Md2i9ThzTZx3CL1al1Ho == null;

    internal static EnumHelper mceF02hzntctbuNmQDMB() => EnumHelper.Md2i9ThzTZx3CL1al1Ho;

    internal static object fyP3jShz2CHU0nnpLykw([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object ku1WQFhzeE9irAsN92GB([In] object obj0) => (object) EnumHelper.GetDisplayName(obj0);

    internal static object iSP22ohzPKWFw8PPbJmt([In] object obj0) => (object) EnumHelper.GetMetadata(obj0);

    internal static object hBT6X2hz1iu1yGICQ34r([In] object obj0) => (object) ((MetadataImage) obj0).CreateImage();
  }
}
