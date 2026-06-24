// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.EntitySerializationSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Serialization
{
  /// <summary>Настройки сериализации</summary>
  public class EntitySerializationSettings
  {
    private static EntitySerializationSettings XJorwhBlltqVqK0eHU9D;

    /// <summary>Ctor</summary>
    public EntitySerializationSettings()
    {
      EntitySerializationSettings.nKgiVRBl5ncTG5W4Q40J();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.TypePropertySelector = new Dictionary<Guid, EntitySerializationSelector>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Проверять ли настройки прав доступа к свойству</summary>
    public bool CheckPropertyPermissions
    {
      get => this.\u003CCheckPropertyPermissions\u003Ek__BackingField;
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
              this.\u003CCheckPropertyPermissions\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
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

    /// <summary>Режим</summary>
    public EntitySerializationMode Mode
    {
      get => this.\u003CMode\u003Ek__BackingField;
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
              this.\u003CMode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
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
    /// Сериализовать св-ва в соотвествии с указанным селектором
    /// </summary>
    public EntitySerializationSelector PropertySelector
    {
      get => this.\u003CPropertySelector\u003Ek__BackingField;
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
              this.\u003CPropertySelector\u003Ek__BackingField = value;
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

    /// <summary>
    /// Функции, которые можно использовать для переопределения поведения сериализации
    /// </summary>
    public EntitySerializationFunctions Functions
    {
      get => this.\u003CFunctions\u003Ek__BackingField;
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
              this.\u003CFunctions\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
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

    /// <summary>Оригинальное состояние сущности</summary>
    public object OriginalState
    {
      get => this.\u003COriginalState\u003Ek__BackingField;
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
              this.\u003COriginalState\u003Ek__BackingField = value;
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

    /// <summary>Сериализовать типы сущностей с указанным селектором</summary>
    /// <remarks>
    /// В качестве Uid использован подтип сущности (SubTypeUid)
    /// </remarks>
    public Dictionary<Guid, EntitySerializationSelector> TypePropertySelector { get; set; }

    /// <summary>Записывать ссылки на объекты при сериализации</summary>
    /// <remarks>
    /// Пример сериализации:
    /// {
    ///     "$id": "1",
    ///     "MyDto1": {
    ///         "$id": "2",
    ///         "TypeUid": "2c969d34-d9bf-4a81-ba4c-e566e837be4d",
    ///         "Stroka": "123"
    ///     },
    ///     "MyDto2": {
    ///         "$ref": "2"
    ///     },
    ///     "Spisok": [
    ///         {
    ///             "$ref": "2"
    ///         },
    ///         {
    ///             "$id": "4",
    ///             "TypeUid": "2c969d34-d9bf-4a81-ba4c-e566e837be4d",
    ///             "Stroka": "1234",
    ///         }
    ///     ]
    /// }
    /// </remarks>
    public bool WriteReferences
    {
      get => this.\u003CWriteReferences\u003Ek__BackingField;
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
              this.\u003CWriteReferences\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
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

    internal static void nKgiVRBl5ncTG5W4Q40J() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool HEGKecBlr9KL2bFTlqh8() => EntitySerializationSettings.XJorwhBlltqVqK0eHU9D == null;

    internal static EntitySerializationSettings dwClBmBlgC8JahWsJkQt() => EntitySerializationSettings.XJorwhBlltqVqK0eHU9D;
  }
}
