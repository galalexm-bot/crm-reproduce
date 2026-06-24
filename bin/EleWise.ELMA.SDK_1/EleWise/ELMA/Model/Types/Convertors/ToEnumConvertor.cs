// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Convertors.ToEnumConvertor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types.Convertors
{
  /// <summary>
  /// Базовый класс преобразования из какого-либо типа в тип "Строка"
  /// </summary>
  public class ToEnumConvertor : TypeConvertor
  {
    private static ToEnumConvertor cXoPL8o55BLrF4UYmSVD;

    /// <summary>Тип "Строка"</summary>
    public override List<Guid> SourceTypeUids => new List<Guid>()
    {
      EnumDescriptor.UID
    };

    /// <summary>Тип "Строка"</summary>
    public override List<Guid> TargetTypeUids => new List<Guid>()
    {
      EnumDescriptor.UID
    };

    public override object DoConvert(object obj)
    {
      int num1 = 3;
      int? nullable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            if (obj != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            nullable = new int?();
            num1 = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return (object) nullable;
label_6:
      try
      {
        nullable = new int?((int) obj);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_2;
        }
      }
    }

    public ToEnumConvertor()
    {
      ToEnumConvertor.qx8fTJo5L0LtrcxVPNqL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool HhNXWFo5jG1pINHXLNLs() => ToEnumConvertor.cXoPL8o55BLrF4UYmSVD == null;

    internal static ToEnumConvertor OtEEPso5YVmys60UTsWN() => ToEnumConvertor.cXoPL8o55BLrF4UYmSVD;

    internal static void qx8fTJo5L0LtrcxVPNqL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
