// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EnumInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Web.Script.Serialization;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>Информация о значении перечисления</summary>
  [Serializable]
  public sealed class EnumInfo
  {
    internal static EnumInfo h8hFfeh8ZxFalfweoSX8;

    /// <summary>Уникальный идентификатор</summary>
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
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

    /// <summary>Имя</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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

    /// <summary>Отображаемое имя</summary>
    public string DisplayName
    {
      get => this.\u003CDisplayName\u003Ek__BackingField;
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
              this.\u003CDisplayName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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

    /// <summary>Целочисленное значение</summary>
    public int? IntValue { get; set; }

    /// <summary>Сериализовать в строку</summary>
    /// <returns></returns>
    public string Serialize() => (string) EnumInfo.t9VPTDh8Vjed5JDlEXb8((object) new JsonSerializer(), (object) this);

    /// <summary>Десериализовать из строки</summary>
    /// <param name="serialized">Сериализованная строка</param>
    /// <returns></returns>
    public static EnumInfo Deserialize(string serialized) => new JsonSerializer().Deserialize<EnumInfo>(serialized);

    public EnumInfo()
    {
      EnumInfo.i5SERZh8SW1Gu67DcKRs();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool afj1afh8u7nHKmeTJZs5() => EnumInfo.h8hFfeh8ZxFalfweoSX8 == null;

    internal static EnumInfo aom4Iwh8IliPOSFnHpaW() => EnumInfo.h8hFfeh8ZxFalfweoSX8;

    internal static object t9VPTDh8Vjed5JDlEXb8([In] object obj0, [In] object obj1) => (object) ((JavaScriptSerializer) obj0).Serialize(obj1);

    internal static void i5SERZh8SW1Gu67DcKRs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
