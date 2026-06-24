// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.Int64RangeWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component]
  [XmlRoot("Int64RangeValue")]
  public class Int64RangeWrapper : IXsiType
  {
    private static Int64RangeWrapper NNqx9TbGeOH9yJwlycIa;

    public Int64RangeWrapper()
    {
      Int64RangeWrapper.o8t1SJbGNiis7F5D6GK5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public Int64RangeWrapper(Int64Range source)
    {
      Int64RangeWrapper.o8t1SJbGNiis7F5D6GK5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 2;
      long? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            nullable = source.From;
            this.HasFromValue = nullable.HasValue;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 4 : 4;
            continue;
          case 2:
            nullable = source.From;
            long num2;
            if (!nullable.HasValue)
            {
              num2 = 0L;
            }
            else
            {
              nullable = source.From;
              num2 = nullable.Value;
            }
            this.From = num2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_9;
          case 4:
            nullable = source.To;
            this.HasToValue = nullable.HasValue;
            num1 = 3;
            continue;
          default:
            nullable = source.To;
            long num3;
            if (!nullable.HasValue)
            {
              num3 = 0L;
            }
            else
            {
              nullable = source.To;
              num3 = nullable.Value;
            }
            this.To = num3;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
            continue;
        }
      }
label_9:;
    }

    [XmlElement("From")]
    public long From
    {
      get => this.\u003CFrom\u003Ek__BackingField;
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
              this.\u003CFrom\u003Ek__BackingField = value;
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

    [XmlElement("To")]
    public long To
    {
      get => this.\u003CTo\u003Ek__BackingField;
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
              this.\u003CTo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
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

    [XmlElement("HasFromValue")]
    public bool HasFromValue
    {
      get => this.\u003CHasFromValue\u003Ek__BackingField;
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
              this.\u003CHasFromValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
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

    [XmlElement("HasToValue")]
    public bool HasToValue
    {
      get => this.\u003CHasToValue\u003Ek__BackingField;
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
              this.\u003CHasToValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
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

    internal static void o8t1SJbGNiis7F5D6GK5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool u3yg0ubGPXteVvqC4yAD() => Int64RangeWrapper.NNqx9TbGeOH9yJwlycIa == null;

    internal static Int64RangeWrapper lCnBW5bG15h4LCSHEPSI() => Int64RangeWrapper.NNqx9TbGeOH9yJwlycIa;
  }
}
