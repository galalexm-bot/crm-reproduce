// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.TimeSpanTemplateGeneratorFunctions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Функции для работы с интервалами времени</summary>
  [Component]
  public class TimeSpanTemplateGeneratorFunctions : ITemplateGeneratorFunctionsContainer
  {
    private static TimeSpanTemplateGeneratorFunctions tZen7aGwa7G25lJSYvPm;

    /// <summary>Представить интервал времени в виде строки</summary>
    /// <see cref="M:EleWise.ELMA.Extensions.TimeSpanTemplateGeneratorFunctions.TimeSpanToString(EleWise.TemplateGenerator.Functions.FunctionEvaluationContext)" />
    public static FormatedValue ИнтервалВремениВСтроку(FunctionEvaluationContext context) => (FormatedValue) TimeSpanTemplateGeneratorFunctions.gMNdQXGwwDbe5Cv9HhYE((object) context);

    /// <summary>Представить интервал времени в виде строки</summary>
    /// <remarks>
    /// * - Обязательные параметры
    /// Параметры:
    /// [0]*: Интервал времени (TimeSpan)
    /// 
    /// Результат:
    ///     Возвращает строковое представление интервала времени в формате «д. ч. мин. сек»
    /// 
    /// Пример:
    ///     Пусть TimeSpan - переменна типа "Интервал времени". Установим ей значение ‘128.17:30:33.3444555’. Тогда:
    ///     TimeSpanToString({$TimeSpan})
    ///     (результат: ‘128 д. 17 ч. 30 мин. 33 сек. ‘)
    /// </remarks>
    /// <param name="context"></param>
    /// <returns></returns>
    public static FormatedValue TimeSpanToString(FunctionEvaluationContext context)
    {
      int num = 1;
      StringBuilder stringBuilder;
      TimeSpan timeSpan;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (TimeSpanTemplateGeneratorFunctions.hWpiosGw4P3hFggVVZ4h((object) context.Parameters) < 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
              continue;
            }
            stringBuilder = new StringBuilder();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 7;
            continue;
          case 2:
          case 12:
            goto label_13;
          case 3:
            if (timeSpan.Hours > 0)
            {
              num = 6;
              continue;
            }
            goto case 11;
          case 4:
            stringBuilder.Append(timeSpan.Days).Append((string) TimeSpanTemplateGeneratorFunctions.x8ffhiGw6YK3axDfkQ2f(-1872275253 >> 6 ^ -29203687));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 3 : 1;
            continue;
          case 5:
          case 8:
            if (timeSpan.Seconds <= 0)
            {
              num = 12;
              continue;
            }
            goto case 13;
          case 6:
            TimeSpanTemplateGeneratorFunctions.m2KUxCGwAZZYnZYpjh2v(TimeSpanTemplateGeneratorFunctions.Q9yUovGwHoFZ5rRoR2Ze((object) stringBuilder, timeSpan.Hours), TimeSpanTemplateGeneratorFunctions.x8ffhiGw6YK3axDfkQ2f(-1426456882 ^ 2009939514 ^ -583582094));
            num = 11;
            continue;
          case 7:
            timeSpan = TimeSpan.Parse(context.Parameters[0].ToString());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 10 : 9;
            continue;
          case 9:
            stringBuilder.Append(timeSpan.Minutes).Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957661998));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 8;
            continue;
          case 10:
            if (timeSpan.Days > 0)
            {
              num = 4;
              continue;
            }
            goto case 3;
          case 11:
            if (timeSpan.Minutes <= 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 5;
              continue;
            }
            goto case 9;
          case 13:
            TimeSpanTemplateGeneratorFunctions.m2KUxCGwAZZYnZYpjh2v(TimeSpanTemplateGeneratorFunctions.Q9yUovGwHoFZ5rRoR2Ze((object) stringBuilder, timeSpan.Seconds), TimeSpanTemplateGeneratorFunctions.x8ffhiGw6YK3axDfkQ2f(-1921202237 ^ -1921042079));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 2;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return (FormatedValue) null;
label_13:
      return new FormatedValue((object) stringBuilder.ToString());
    }

    /// <summary>Представить интервал времени (дни) в виде строки</summary>
    /// <see cref="M:EleWise.ELMA.Extensions.TimeSpanTemplateGeneratorFunctions.GetTimeSpanDays(EleWise.TemplateGenerator.Functions.FunctionEvaluationContext)" />
    public static FormatedValue ПолучитьДниИнтервала(FunctionEvaluationContext context) => TimeSpanTemplateGeneratorFunctions.GetTimeSpanDays(context);

    /// <summary>Представить интервал времени (дни) в виде строки</summary>
    /// <remarks>
    /// * - Обязательные параметры
    /// Параметры:
    /// [0]*: Интервал времени (TimeSpan)
    /// 
    /// Результат:
    ///     Возвращает дни интервала времени в виде строки
    /// 
    /// Пример:
    ///     Пусть TimeSpan - переменна типа "Интервал времени". Установим ей значение ‘128.17:30:33.3444555’. Тогда:
    ///     GetTimeSpanDays({$TimeSpan})
    ///     (результат ‘128‘)
    /// </remarks>
    /// <param name="context"></param>
    /// <returns></returns>
    public static FormatedValue GetTimeSpanDays(FunctionEvaluationContext context)
    {
      int num = 3;
      int days;
      TimeSpan timeSpan;
      while (true)
      {
        switch (num)
        {
          case 1:
            timeSpan = TimeSpanTemplateGeneratorFunctions.xMHNUsGw74tk7WwGeW6b((object) context.Parameters[0].ToString());
            num = 4;
            continue;
          case 2:
            goto label_3;
          case 3:
            if (TimeSpanTemplateGeneratorFunctions.hWpiosGw4P3hFggVVZ4h((object) context.Parameters) < 1)
            {
              num = 2;
              continue;
            }
            goto case 1;
          case 4:
            days = timeSpan.Days;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return new FormatedValue((object) days.ToString());
label_3:
      return (FormatedValue) null;
    }

    /// <summary>Представить интервал времени (часы) в виде строки</summary>
    /// <see cref="M:EleWise.ELMA.Extensions.TimeSpanTemplateGeneratorFunctions.GetTimeSpanHours(EleWise.TemplateGenerator.Functions.FunctionEvaluationContext)" />
    public static FormatedValue ПолучитьЧасыИнтервала(FunctionEvaluationContext context) => (FormatedValue) TimeSpanTemplateGeneratorFunctions.uepJKPGwxU46u3ksfQZG((object) context);

    /// <summary>Представить интервал времени (часы) в виде строки</summary>
    /// <remarks>
    /// * - Обязательные параметры
    /// Параметры:
    /// [0]*: Интервал времени (TimeSpan)
    /// 
    /// Результат:
    ///     Возвращает часы интервала времени в виде строки
    /// 
    /// Пример:
    ///     Пусть TimeSpan - переменна типа "Интервал времени". Установим ей значение ‘128.17:30:33.3444555’. Тогда:
    ///     GetTimeSpanHours({$TimeSpan})
    ///     (результат ‘17‘)
    /// </remarks>
    /// <param name="context"></param>
    /// <returns></returns>
    public static FormatedValue GetTimeSpanHours(FunctionEvaluationContext context)
    {
      int num = 2;
      int hours;
      while (true)
      {
        TimeSpan timeSpan;
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (TimeSpanTemplateGeneratorFunctions.hWpiosGw4P3hFggVVZ4h((object) context.Parameters) < 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
              continue;
            }
            break;
          case 3:
            goto label_6;
          case 4:
            hours = timeSpan.Hours;
            num = 3;
            continue;
        }
        timeSpan = TimeSpanTemplateGeneratorFunctions.xMHNUsGw74tk7WwGeW6b((object) context.Parameters[0].ToString());
        num = 4;
      }
label_6:
      return new FormatedValue((object) hours.ToString());
label_7:
      return (FormatedValue) null;
    }

    /// <summary>Представить интервал времени (минуты) в виде строки</summary>
    /// <see cref="M:EleWise.ELMA.Extensions.TimeSpanTemplateGeneratorFunctions.GetTimeSpanMinutes(EleWise.TemplateGenerator.Functions.FunctionEvaluationContext)" />
    public static FormatedValue ПолучитьМинутыИнтервала(FunctionEvaluationContext context) => TimeSpanTemplateGeneratorFunctions.GetTimeSpanMinutes(context);

    /// <summary>Представить интервал времени (минуты) в виде строки</summary>
    /// <remarks>
    /// * - Обязательные параметры
    /// Параметры:
    /// [0]*: Интервал времени (TimeSpan)
    /// 
    /// Результат:
    ///     Возвращает минуты интервала времени в виде строки
    /// 
    /// Пример:
    ///     Пусть TimeSpan - переменна типа "Интервал времени". Установим ей значение ‘128.17:30:33.3444555’. Тогда:
    ///     GetTimeSpanMinutes({$TimeSpan})
    ///     (результат ‘30‘)
    /// </remarks>
    /// <param name="context"></param>
    /// <returns></returns>
    public static FormatedValue GetTimeSpanMinutes(FunctionEvaluationContext context)
    {
      int num = 1;
      TimeSpan timeSpan;
      int minutes;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (TimeSpanTemplateGeneratorFunctions.hWpiosGw4P3hFggVVZ4h((object) context.Parameters) < 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_6;
          case 3:
            timeSpan = TimeSpan.Parse(context.Parameters[0].ToString());
            num = 4;
            continue;
          case 4:
            minutes = timeSpan.Minutes;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 2;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return new FormatedValue((object) minutes.ToString());
label_7:
      return (FormatedValue) null;
    }

    /// <summary>Представить интервал времени (секунды) в виде строки</summary>
    /// <see cref="M:EleWise.ELMA.Extensions.TimeSpanTemplateGeneratorFunctions.GetTimeSpanSeconds(EleWise.TemplateGenerator.Functions.FunctionEvaluationContext)" />
    public static FormatedValue ПолучитьСекундыИнтервала(FunctionEvaluationContext context) => (FormatedValue) TimeSpanTemplateGeneratorFunctions.BlELDNGw0b08KMgkTjuF((object) context);

    /// <summary>Представить интервал времени (секунды) в виде строки</summary>
    /// <remarks>
    /// * - Обязательные параметры
    /// Параметры:
    /// [0]*: Интервал времени (TimeSpan)
    /// 
    /// Результат:
    ///     Возвращает секунды интервала времени в виде строки
    /// 
    /// Пример:
    ///     Пусть TimeSpan - переменна типа "Интервал времени". Установим ей значение ‘128.17:30:33.3444555’. Тогда:
    ///     GetTimeSpanSeconds({$TimeSpan})
    ///     (результат ‘33‘)
    /// </remarks>
    /// <param name="context"></param>
    /// <returns></returns>
    public static FormatedValue GetTimeSpanSeconds(FunctionEvaluationContext context)
    {
      int num = 4;
      TimeSpan timeSpan;
      int seconds;
      while (true)
      {
        switch (num)
        {
          case 1:
            timeSpan = TimeSpan.Parse(context.Parameters[0].ToString());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_6;
          case 3:
            goto label_7;
          case 4:
            if (TimeSpanTemplateGeneratorFunctions.hWpiosGw4P3hFggVVZ4h((object) context.Parameters) < 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 3 : 0;
              continue;
            }
            goto case 1;
          default:
            seconds = timeSpan.Seconds;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 2;
            continue;
        }
      }
label_6:
      return new FormatedValue((object) seconds.ToString());
label_7:
      return (FormatedValue) null;
    }

    /// <summary>Используйте TimeSpanToString</summary>
    /// <param name="context">Параметры вычисления функции</param>
    [Obsolete("Используйте TimeSpanToString")]
    public static FormatedValue ИНТЕРВАЛ(FunctionEvaluationContext context) => (FormatedValue) TimeSpanTemplateGeneratorFunctions.gMNdQXGwwDbe5Cv9HhYE((object) context);

    /// <summary>Используйте GetTimeSpanDays</summary>
    /// <param name="context">Параметры вычисления функции</param>
    [Obsolete("Используйте GetTimeSpanDays")]
    public static FormatedValue ИНТЕРВАЛ_ДНИ(FunctionEvaluationContext context) => (FormatedValue) TimeSpanTemplateGeneratorFunctions.UMnHBLGwmsLhw40MNehm((object) context);

    /// <summary>Используйте GetTimeSpanHours</summary>
    /// <param name="context">Параметры вычисления функции</param>
    [Obsolete("Используйте GetTimeSpanHours")]
    public static FormatedValue ИНТЕРВАЛ_ЧАСЫ(FunctionEvaluationContext context) => (FormatedValue) TimeSpanTemplateGeneratorFunctions.uepJKPGwxU46u3ksfQZG((object) context);

    /// <summary>Используйте GetTimeSpanMinutes</summary>
    /// <param name="context">Параметры вычисления функции</param>
    [Obsolete("Используйте GetTimeSpanMinutes")]
    public static FormatedValue ИНТЕРВАЛ_МИНУТЫ(FunctionEvaluationContext context) => (FormatedValue) TimeSpanTemplateGeneratorFunctions.AS7hRuGwyblE00EiHG5X((object) context);

    /// <summary>Используйте GetTimeSpanSeconds</summary>
    /// <param name="context">Параметры вычисления функции</param>
    [Obsolete("Используйте GetTimeSpanSeconds")]
    public static FormatedValue ИНТЕРВАЛ_СЕКУНДЫ(FunctionEvaluationContext context) => (FormatedValue) TimeSpanTemplateGeneratorFunctions.BlELDNGw0b08KMgkTjuF((object) context);

    public TimeSpanTemplateGeneratorFunctions()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object gMNdQXGwwDbe5Cv9HhYE([In] object obj0) => (object) TimeSpanTemplateGeneratorFunctions.TimeSpanToString((FunctionEvaluationContext) obj0);

    internal static int hWpiosGw4P3hFggVVZ4h([In] object obj0) => ((List<FormatedValue>) obj0).Count;

    internal static object x8ffhiGw6YK3axDfkQ2f(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Q9yUovGwHoFZ5rRoR2Ze([In] object obj0, [In] int obj1) => (object) ((StringBuilder) obj0).Append(obj1);

    internal static object m2KUxCGwAZZYnZYpjh2v([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static bool kK4YMqGwDTJ2lSjZsDQ8() => TimeSpanTemplateGeneratorFunctions.tZen7aGwa7G25lJSYvPm == null;

    internal static TimeSpanTemplateGeneratorFunctions MbvIm8Gwt4lMCDaEKSW8() => TimeSpanTemplateGeneratorFunctions.tZen7aGwa7G25lJSYvPm;

    internal static TimeSpan xMHNUsGw74tk7WwGeW6b([In] object obj0) => TimeSpan.Parse((string) obj0);

    internal static object uepJKPGwxU46u3ksfQZG([In] object obj0) => (object) TimeSpanTemplateGeneratorFunctions.GetTimeSpanHours((FunctionEvaluationContext) obj0);

    internal static object BlELDNGw0b08KMgkTjuF([In] object obj0) => (object) TimeSpanTemplateGeneratorFunctions.GetTimeSpanSeconds((FunctionEvaluationContext) obj0);

    internal static object UMnHBLGwmsLhw40MNehm([In] object obj0) => (object) TimeSpanTemplateGeneratorFunctions.GetTimeSpanDays((FunctionEvaluationContext) obj0);

    internal static object AS7hRuGwyblE00EiHG5X([In] object obj0) => (object) TimeSpanTemplateGeneratorFunctions.GetTimeSpanMinutes((FunctionEvaluationContext) obj0);
  }
}
