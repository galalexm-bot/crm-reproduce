// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.BinaryFileContentInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files
{
  /// <summary>Сведения о контенте.</summary>
  public class BinaryFileContentInfo
  {
    internal static BinaryFileContentInfo DOURg0GKDAE85sVrrgTk;

    /// <summary>Размер контента.</summary>
    public long ContentLength
    {
      get => this.\u003CContentLength\u003Ek__BackingField;
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
              this.\u003CContentLength\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
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

    /// <summary>Местоположение контента.</summary>
    public Uri ContentLocation
    {
      get => this.\u003CContentLocation\u003Ek__BackingField;
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
              this.\u003CContentLocation\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
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

    /// <summary>Crc контента.</summary>
    public uint Crc
    {
      get => this.\u003CCrc\u003Ek__BackingField;
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
              this.\u003CCrc\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
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

    /// <summary>Строковое представление объекта.</summary>
    /// <returns>Строковое представление объекта.</returns>
    public override string ToString() => (string) BinaryFileContentInfo.zUvH7MGK6euooDJ2p2jY(BinaryFileContentInfo.moBRUiGK4U6EqReYGPBt(1218962250 ^ 1218723466), (object) this.ContentLength, (object) this.ContentLocation, (object) this.Crc);

    public BinaryFileContentInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool TbSmcCGKthc2ldjLl6oE() => BinaryFileContentInfo.DOURg0GKDAE85sVrrgTk == null;

    internal static BinaryFileContentInfo qXcb5QGKw1Yq9D1UP4By() => BinaryFileContentInfo.DOURg0GKDAE85sVrrgTk;

    internal static object moBRUiGK4U6EqReYGPBt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object zUvH7MGK6euooDJ2p2jY(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }
  }
}
