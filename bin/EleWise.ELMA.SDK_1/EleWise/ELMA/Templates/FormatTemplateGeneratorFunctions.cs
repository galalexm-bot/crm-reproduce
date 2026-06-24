// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.FormatTemplateGeneratorFunctions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates
{
  /// <summary>Функции форматирования</summary>
  [Component]
  public class FormatTemplateGeneratorFunctions : ITemplateGeneratorFunctionsContainer
  {
    internal static FormatTemplateGeneratorFunctions KaUVQQBPkUiWNBLe32tm;

    /// <summary>
    /// Отобразить дату и время в заданном формате. Полный аналог DateTime.ToString("тут ваш формат")
    /// </summary>
    /// <remarks>
    /// * - обязательный параметр
    /// Параметры:
    /// [0]*: Дата\время (DateTime)
    /// [1]: Формат отображения (string)
    /// 
    /// Результат:
    ///     Преобразованное значение текущего объекта DateTime в эквивалентное строковое представление с использованием указанного формата
    /// 
    /// Пример:
    ///     {DateTimeFormat({$DataTime}; ‘yy-MM-dd’)}  (Результат: 17-05-18)
    ///     {DateTimeFormat({$DataTime}; ‘G’)}  (Результат: 18.05.2017 1:30:00)
    /// </remarks>
    /// <param name="context"></param>
    /// <returns></returns>
    public static FormatedValue DateTimeFormat(FunctionEvaluationContext context)
    {
      int num1 = 7;
      DateTime dateTime;
      string format;
      while (true)
      {
        int num2 = num1;
        DateTime? nullable;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!nullable.HasValue)
              {
                num2 = 3;
                continue;
              }
              if (context.Parameters.Count != 1)
              {
                format = FormatTemplateGeneratorFunctions.hsQbamBP2qrtkgu3w3FO((object) context.Parameters[1]) as string;
                num2 = 2;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 9 : 0;
              continue;
            case 2:
              if (!FormatTemplateGeneratorFunctions.VcaZMFBPP2ZkGitgX9F3((object) format))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 4 : 8;
                continue;
              }
              dateTime = nullable.Value;
              num2 = 5;
              continue;
            case 3:
              goto label_18;
            case 4:
              goto label_5;
            case 5:
              goto label_3;
            case 6:
              goto label_13;
            case 7:
              if (!context.Parameters.Any<FormatedValue>())
              {
                num2 = 6;
                continue;
              }
              nullable = FormatTemplateGeneratorFunctions.hsQbamBP2qrtkgu3w3FO((object) context.Parameters[0]) as DateTime?;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 1;
              continue;
            case 8:
              dateTime = nullable.Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            case 9:
              goto label_17;
            default:
              goto label_9;
          }
        }
label_17:
        dateTime = nullable.Value;
        num1 = 4;
      }
label_3:
      return new FormatedValue((object) dateTime.ToString((IFormatProvider) FormatTemplateGeneratorFunctions.aZssRlBPextV6my0S0oi()));
label_5:
      return new FormatedValue((object) dateTime.ToString((IFormatProvider) FormatTemplateGeneratorFunctions.aZssRlBPextV6my0S0oi()));
label_9:
      return new FormatedValue((object) dateTime.ToString(format));
label_13:
      return new FormatedValue((object) string.Empty);
label_18:
      return new FormatedValue((object) string.Empty);
    }

    /// <summary>Отобразить число в заданном формате.</summary>
    /// <remarks>
    /// * - обязательный параметр
    /// Параметры:
    /// [0]*: Число (все числовые типы, кроме byte)
    /// [1]: Один из стандартных или кастомых форматов отображения (string)
    /// [1]: Число количества знаков после запятой (все числовые типы, кроме byte)
    /// 
    /// Примечание:
    ///     Если в качестве второго параметра будет передано число с плавающей запятой,
    ///     то количество знаков будет равно целой части этого числа с учётом округления
    /// 
    /// Результат:
    ///     Преобразованное числовое значение данного экземпляра в эквивалентное строковое представление с использованием указанного формата
    /// 
    /// Пример:
    ///     {NumberFormat(2345.6789;3)}  (Результат: 2345,679)
    ///     {NumberFormat(0.6789;’G’)}	(Результат: 0,6789)
    ///     {NumberFormat(0.6789;’P’)}	Результат: 67,89%)
    /// </remarks>
    /// <param name="context"></param>
    /// <returns></returns>
    public static FormatedValue NumberFormat(FunctionEvaluationContext context)
    {
      int num1 = 7;
      double num2;
      string format;
      while (true)
      {
        int num3 = num1;
        double num4;
        while (true)
        {
          switch (num3)
          {
            case 1:
              num4 = FormatTemplateGeneratorFunctions.xifRGaBPNFPlaMVI6DmY((object) context, 1);
              num3 = 2;
              continue;
            case 2:
              goto label_10;
            case 3:
              if (FormatTemplateGeneratorFunctions.Gx6DOoBP1KcCF7vrUDfw((object) context.Parameters) == 1)
              {
                num3 = 8;
                continue;
              }
              format = FormatTemplateGeneratorFunctions.hsQbamBP2qrtkgu3w3FO((object) context.Parameters[1]) as string;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
              continue;
            case 4:
            case 5:
              goto label_7;
            case 6:
              goto label_3;
            case 7:
              if (context.Parameters.Any<FormatedValue>())
              {
                num2 = FormatTemplateGeneratorFunctions.ConvertToDouble((object) context, 0);
                num3 = 3;
                continue;
              }
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 6 : 6;
              continue;
            case 8:
              goto label_11;
            default:
              if (!string.IsNullOrEmpty(format))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 4 : 5;
                continue;
              }
              goto case 1;
          }
        }
label_10:
        format = (string) FormatTemplateGeneratorFunctions.UDIxi9BPpDZxZRoAmyaD(FormatTemplateGeneratorFunctions.bhS6VtBP3xYCDyPXOXSs(-1867198571 ^ -1867124505), (object) num4.ToString((string) FormatTemplateGeneratorFunctions.bhS6VtBP3xYCDyPXOXSs(-867826612 ^ -867747022)));
        num1 = 4;
      }
label_3:
      return new FormatedValue((object) string.Empty);
label_7:
      return new FormatedValue((object) num2.ToString(format));
label_11:
      return new FormatedValue((object) num2);
    }

    /// <summary>
    /// Отобразить числа в виде денег. Отображается только в формате русской культуры.
    /// </summary>
    /// <remarks>
    /// * - обязательный параметр
    /// Параметры:
    /// [0]*: Число (все числовые типы, кроме byte)</remarks>
    /// 
    ///             [1]: Число количества знаков после запятой (все числовые типы, кроме byte)
    ///             
    ///             Примечание: 
    ///                 Если в качестве второго параметра будет передано число с плавающей запятой,
    ///                 то количество знаков будет равно целой части этого числа с учётом округления
    ///             
    ///             Результат:
    ///                 Преобразованное числовое значение данного экземпляра в эквивалентное строкове представление с использованием указанного формата. 
    ///                 Валюты выводятся в формате русской культуры
    ///             
    ///             Примеры:
    ///                 {MoneyFormat(23451234.6789;1)}  (Результат: 23 451 234,7)
    ///                 {MoneyFormat(23451234.6789;11)}  (Результат: 23 451 234,7)
    ///                 {MoneyFormat(23451234.6789)}  (Результат: 23 451 234,68)
    ///             <param name="context"></param>
    /// <returns></returns>
    public static FormatedValue MoneyFormat(FunctionEvaluationContext context)
    {
      int num1 = 1;
      double num2;
      double num3;
      string format;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (context.Parameters.Any<FormatedValue>())
            {
              num2 = FormatTemplateGeneratorFunctions.xifRGaBPNFPlaMVI6DmY((object) context, 0);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 3 : 3;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_10;
          case 3:
            if (context.Parameters.Count != 1)
            {
              num3 = FormatTemplateGeneratorFunctions.xifRGaBPNFPlaMVI6DmY((object) context, 1);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 5 : 3;
              continue;
            }
            num1 = 4;
            continue;
          case 4:
            goto label_2;
          case 5:
            format = (string) FormatTemplateGeneratorFunctions.UDIxi9BPpDZxZRoAmyaD(FormatTemplateGeneratorFunctions.bhS6VtBP3xYCDyPXOXSs(--1418440330 ^ 1418367262), (object) num3.ToString((string) FormatTemplateGeneratorFunctions.bhS6VtBP3xYCDyPXOXSs(901793403 ^ 901871877)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return new FormatedValue(FormatTemplateGeneratorFunctions.BO7XA6BPD0xIVuJYycQB(FormatTemplateGeneratorFunctions.nacfgxBPa5wTmXVjBEO4((object) num2.ToString((string) FormatTemplateGeneratorFunctions.bhS6VtBP3xYCDyPXOXSs(1470440286 ^ 1470373080), (IFormatProvider) new CultureInfo((string) FormatTemplateGeneratorFunctions.bhS6VtBP3xYCDyPXOXSs(-53329496 >> 4 ^ -3326370))), FormatTemplateGeneratorFunctions.bhS6VtBP3xYCDyPXOXSs(864270449 << 6 ^ -521198642), (object) ""), (object) new char[1]
      {
        ' '
      }));
label_4:
      return new FormatedValue((object) string.Empty);
label_10:
      return new FormatedValue(FormatTemplateGeneratorFunctions.BO7XA6BPD0xIVuJYycQB(FormatTemplateGeneratorFunctions.nacfgxBPa5wTmXVjBEO4((object) num2.ToString(format, (IFormatProvider) new CultureInfo(z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521271804))), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138079754), (object) ""), (object) new char[1]
      {
        ' '
      }));
    }

    private static double ConvertToDouble(object context, int paramIndex)
    {
      int num = 10;
      Decimal? nullable1;
      float? nullable2;
      long? nullable3;
      int? nullable4;
      ushort? nullable5;
      short? nullable6;
      ulong? nullable7;
      double? nullable8;
      uint? nullable9;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_12;
          case 2:
            if (!nullable2.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 20 : 17;
              continue;
            }
            goto label_18;
          case 3:
            nullable6 = FormatTemplateGeneratorFunctions.hsQbamBP2qrtkgu3w3FO((object) ((FunctionEvaluationContext) context).Parameters[paramIndex]) as short?;
            num = 21;
            continue;
          case 4:
            goto label_6;
          case 5:
            goto label_34;
          case 6:
            if (!nullable1.HasValue)
            {
              nullable2 = FormatTemplateGeneratorFunctions.hsQbamBP2qrtkgu3w3FO((object) ((FunctionEvaluationContext) context).Parameters[paramIndex]) as float?;
              num = 2;
              continue;
            }
            num = 8;
            continue;
          case 7:
            nullable3 = ((FunctionEvaluationContext) context).Parameters[paramIndex].Value as long?;
            num = 14;
            continue;
          case 8:
            goto label_2;
          case 9:
            if (!nullable8.HasValue)
            {
              nullable1 = FormatTemplateGeneratorFunctions.hsQbamBP2qrtkgu3w3FO((object) ((FunctionEvaluationContext) context).Parameters[paramIndex]) as Decimal?;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 6 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
            continue;
          case 10:
            nullable8 = FormatTemplateGeneratorFunctions.hsQbamBP2qrtkgu3w3FO((object) ((FunctionEvaluationContext) context).Parameters[paramIndex]) as double?;
            num = 9;
            continue;
          case 11:
            goto label_18;
          case 12:
            goto label_30;
          case 13:
            if (!nullable4.HasValue)
            {
              nullable5 = FormatTemplateGeneratorFunctions.hsQbamBP2qrtkgu3w3FO((object) ((FunctionEvaluationContext) context).Parameters[paramIndex]) as ushort?;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 19 : 0;
              continue;
            }
            num = 4;
            continue;
          case 14:
            if (nullable3.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 5 : 5;
              continue;
            }
            nullable9 = FormatTemplateGeneratorFunctions.hsQbamBP2qrtkgu3w3FO((object) ((FunctionEvaluationContext) context).Parameters[paramIndex]) as uint?;
            num = 18;
            continue;
          case 15:
            goto label_28;
          case 16:
            goto label_8;
          case 17:
            goto label_26;
          case 18:
            if (!nullable9.HasValue)
            {
              nullable4 = ((FunctionEvaluationContext) context).Parameters[paramIndex].Value as int?;
              num = 13;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 17 : 0;
            continue;
          case 19:
            if (!nullable5.HasValue)
            {
              num = 3;
              continue;
            }
            goto label_8;
          case 20:
            nullable7 = ((FunctionEvaluationContext) context).Parameters[paramIndex].Value as ulong?;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          case 21:
            if (nullable6.HasValue)
            {
              num = 12;
              continue;
            }
            goto label_31;
          default:
            if (!nullable7.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 7 : 4;
              continue;
            }
            goto label_28;
        }
      }
label_2:
      return FormatTemplateGeneratorFunctions.h6ah9DBPtk6ZxSCY4Mo7(nullable1.Value);
label_6:
      return FormatTemplateGeneratorFunctions.uKtxFdBP6xaLyFa0Ds0f(nullable4.Value);
label_8:
      return FormatTemplateGeneratorFunctions.lMp8ddBPHOY9GPqKThal(nullable5.Value);
label_12:
      return nullable8.Value;
label_18:
      return Convert.ToDouble(nullable2.Value);
label_26:
      return FormatTemplateGeneratorFunctions.hOaj2lBP4EhLU25ZqWPa(nullable9.Value);
label_28:
      return FormatTemplateGeneratorFunctions.E0UxiPBPwr9FWoHgfG6c((object) nullable7);
label_30:
      return FormatTemplateGeneratorFunctions.N2muF7BPA9GEsoEd91tA(nullable6.Value);
label_31:
      return 0.0;
label_34:
      return FormatTemplateGeneratorFunctions.E0UxiPBPwr9FWoHgfG6c((object) nullable3);
    }

    public FormatTemplateGeneratorFunctions()
    {
      FormatTemplateGeneratorFunctions.zUCmSeBP7Ayh3ZmfI3Zn();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object hsQbamBP2qrtkgu3w3FO([In] object obj0) => ((FormatedValue) obj0).Value;

    internal static object aZssRlBPextV6my0S0oi() => (object) CultureInfo.CurrentCulture;

    internal static bool VcaZMFBPP2ZkGitgX9F3([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool pyGQ6HBPnsSkCwec7Hma() => FormatTemplateGeneratorFunctions.KaUVQQBPkUiWNBLe32tm == null;

    internal static FormatTemplateGeneratorFunctions QZk8rdBPOoNjce6v0dVU() => FormatTemplateGeneratorFunctions.KaUVQQBPkUiWNBLe32tm;

    internal static int Gx6DOoBP1KcCF7vrUDfw([In] object obj0) => ((List<FormatedValue>) obj0).Count;

    internal static double xifRGaBPNFPlaMVI6DmY([In] object obj0, int paramIndex) => FormatTemplateGeneratorFunctions.ConvertToDouble(obj0, paramIndex);

    internal static object bhS6VtBP3xYCDyPXOXSs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object UDIxi9BPpDZxZRoAmyaD([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object nacfgxBPa5wTmXVjBEO4([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object BO7XA6BPD0xIVuJYycQB([In] object obj0, [In] object obj1) => (object) ((string) obj0).TrimEnd((char[]) obj1);

    internal static double h6ah9DBPtk6ZxSCY4Mo7([In] Decimal obj0) => Convert.ToDouble(obj0);

    internal static double E0UxiPBPwr9FWoHgfG6c([In] object obj0) => Convert.ToDouble(obj0);

    internal static double hOaj2lBP4EhLU25ZqWPa([In] uint obj0) => Convert.ToDouble(obj0);

    internal static double uKtxFdBP6xaLyFa0Ds0f([In] int obj0) => Convert.ToDouble(obj0);

    internal static double lMp8ddBPHOY9GPqKThal([In] ushort obj0) => Convert.ToDouble(obj0);

    internal static double N2muF7BPA9GEsoEd91tA([In] short obj0) => Convert.ToDouble(obj0);

    internal static void zUCmSeBP7Ayh3ZmfI3Zn() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
