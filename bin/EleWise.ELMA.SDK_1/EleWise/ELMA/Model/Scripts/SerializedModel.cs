// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.SerializedModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Сериализованная модель</summary>
  [DataContract]
  public sealed class SerializedModel
  {
    internal static SerializedModel tK8Si3buXd9nee2U6Mbn;

    /// <summary>Имя</summary>
    [DataMember]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
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

    /// <summary>Модель</summary>
    [DataMember]
    public string Model
    {
      get => this.\u003CModel\u003Ek__BackingField;
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
              this.\u003CModel\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
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

    public SerializedModel()
    {
      SerializedModel.hHTIqAbunF2KVcikI1KT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool JLfANRbuT0pRgDjjOyqh() => SerializedModel.tK8Si3buXd9nee2U6Mbn == null;

    internal static SerializedModel rPX7yHbuk4UgGFGSwEMg() => SerializedModel.tK8Si3buXd9nee2U6Mbn;

    internal static void hHTIqAbunF2KVcikI1KT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
