// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.EntityTypeSerializationSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Serialization
{
  /// <summary>
  /// Модель, хранящая список свойств, участвующих в сериализации по типу
  /// </summary>
  [DataContract]
  public sealed class EntityTypeSerializationSettings
  {
    internal static EntityTypeSerializationSettings w5ihAxB9IWyeycl3kXnm;

    /// <summary>Ctor</summary>
    public EntityTypeSerializationSettings()
    {
      EntityTypeSerializationSettings.LX9QemB9ii3mJthe3MMe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Properties = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Тип сущности</summary>
    [DataMember]
    public Guid TypeUid
    {
      get => this.\u003CTypeUid\u003Ek__BackingField;
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
              this.\u003CTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
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

    /// <summary>Список свойств</summary>
    [DataMember]
    public List<string> Properties { get; set; }

    internal static void LX9QemB9ii3mJthe3MMe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool k90IdIB9VENPOVjQQyYt() => EntityTypeSerializationSettings.w5ihAxB9IWyeycl3kXnm == null;

    internal static EntityTypeSerializationSettings XOZfvnB9SkmIDxefllGk() => EntityTypeSerializationSettings.w5ihAxB9IWyeycl3kXnm;
  }
}
