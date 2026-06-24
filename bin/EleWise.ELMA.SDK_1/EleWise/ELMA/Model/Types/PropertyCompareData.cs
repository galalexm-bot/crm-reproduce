// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.PropertyCompareData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Класс, содержащий данные сравнения свойств объектов в сериализованном виде
  /// </summary>
  [Serializable]
  public sealed class PropertyCompareData
  {
    private static PropertyCompareData amsU9AoJvcBKJIBPDK3J;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    public PropertyCompareData(Guid propertyGuid, Guid classGuid)
    {
      PropertyCompareData.B5C9XWoJuHf81r4JMrpD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.PropertyGuid = propertyGuid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.ClassGuid = classGuid;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    public PropertyCompareData()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Идентификатор сравниваемого свойства</summary>
    public Guid PropertyGuid
    {
      get => this.\u003CPropertyGuid\u003Ek__BackingField;
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
              this.\u003CPropertyGuid\u003Ek__BackingField = value;
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

    /// <summary>Идентификатор класса объекта</summary>
    public Guid ClassGuid
    {
      get => this.\u003CClassGuid\u003Ek__BackingField;
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
              this.\u003CClassGuid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
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

    /// <summary>Сериализованное значение до изменения</summary>
    public byte[] OldPropertyData
    {
      get => this.\u003COldPropertyData\u003Ek__BackingField;
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
              this.\u003COldPropertyData\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
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

    /// <summary>Сериализованное значение после изменения</summary>
    public byte[] NewPropertyData
    {
      get => this.\u003CNewPropertyData\u003Ek__BackingField;
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
              this.\u003CNewPropertyData\u003Ek__BackingField = value;
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

    internal static void B5C9XWoJuHf81r4JMrpD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool xRq5ekoJ83nJsOsGymx0() => PropertyCompareData.amsU9AoJvcBKJIBPDK3J == null;

    internal static PropertyCompareData lb2lgaoJZqugRCsTAra1() => PropertyCompareData.amsU9AoJvcBKJIBPDK3J;
  }
}
