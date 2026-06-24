// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPM.Notifications.BPMGeneratorFunctionContainer
// Assembly: EleWise.ELMA.BPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EE1B80B5-F464-4FFF-85CF-6A69B66F676D
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Services;
using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.BPM.Notifications
{
  /// <summary>Функции для генерации BPM</summary>
  [Component]
  public class BPMGeneratorFunctionContainer : ITemplateGeneratorFunctionsContainer
  {
    internal static BPMGeneratorFunctionContainer ikG8ycOhDR0OVsFv2n;

    /// <summary>
    /// Получить дату истечения лицензии переданного компонента
    /// </summary>
    /// <remarks>
    /// * - Обязательные параметры
    /// Параметры:
    /// [0]*: Установленный компонент (IStoreComponentInfo)
    /// Пример:
    ///     Пусть Info - Переменная типа "Информация о компоненте ELMA Store".
    ///     Чтобы определить дату истечения лицензии этого компонента:
    ///     {ExpirationDate({$Info})}
    /// </remarks>
    /// <param name="context">Контекстная переменная</param>
    /// <returns>Форматированное значение даты</returns>
    public static FormatedValue ExpirationDate(FunctionEvaluationContext context)
    {
      int num = 11;
      FormatedValue parameter;
      DateTime? nullable;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(BPMGeneratorFunctionContainer.rIuL7Hpqn8kFNynrSc((object) parameter) is IStoreComponentInfo))
            {
              num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_505866aff0204b659e1cc72dbf89c08c != 0 ? 5 : 1;
              continue;
            }
            goto case 8;
          case 2:
            parameter = context.Parameters[0];
            num = 6;
            continue;
          case 4:
            if (parameter.Value != null)
            {
              num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_687508cbf3c6435893cc34fc10b7ba5c != 0 ? 1 : 0;
              continue;
            }
            goto label_13;
          case 6:
            if (parameter != null)
            {
              num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_aefe3a0b23ba485b84a708e5b83dd041 != 0 ? 4 : 0;
              continue;
            }
            goto label_13;
          case 7:
            if (BPMGeneratorFunctionContainer.YC7fN5ILiu8omluueT((object) context.Parameters) > 0)
            {
              num = 2;
              continue;
            }
            goto label_13;
          case 8:
            nullable = BPMGeneratorFunctionContainer.GetDate(BPMGeneratorFunctionContainer.rIuL7Hpqn8kFNynrSc((object) parameter));
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_73cb0c86bb5c46a6a01aa9cfc0b4f45b == 0 ? 0 : 0;
            continue;
          case 9:
            if (context.Parameters != null)
            {
              num = 7;
              continue;
            }
            goto label_13;
          case 10:
            if (context == null)
            {
              num = 3;
              continue;
            }
            goto case 9;
          case 11:
            nullable = new DateTime?();
            num = 10;
            continue;
          default:
            goto label_13;
        }
      }
label_13:
      return new FormatedValue((object) nullable);
    }

    /// <summary>
    /// Получить количество дней до истечения лицензии переданного компонента
    /// </summary>
    /// <remarks>
    /// * - Обязательные параметры
    /// Параметры:
    /// [0]*: Установленный компонент (IStoreComponentInfo)
    /// Пример:
    ///     Пусть Info - Переменная типа "Информация о компоненте ELMA Store".
    ///     Чтобы определить количество дней до истечения лицензии этого компонента:
    ///     {DaysBeforeExpiration({$Info})}
    /// </remarks>
    /// <param name="context">Контекстная переменная</param>
    /// <returns>Форматированное значение количества дней</returns>
    public static FormatedValue DaysBeforeExpiration(FunctionEvaluationContext context)
    {
      int num1 = 8;
      int num2;
      FormatedValue parameter;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 4:
          case 5:
          case 11:
          case 12:
            goto label_17;
          case 2:
            parameter = context.Parameters[0];
            num1 = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_506d1ddb63bc485196e8152411b402a4 != 0 ? 3 : 1;
            continue;
          case 3:
            if (parameter == null)
            {
              num1 = 4;
              continue;
            }
            goto case 13;
          case 6:
            if (!(BPMGeneratorFunctionContainer.rIuL7Hpqn8kFNynrSc((object) parameter) is IStoreComponentInfo))
            {
              num1 = 5;
              continue;
            }
            goto case 9;
          case 7:
            if (context != null)
            {
              num1 = 10;
              continue;
            }
            goto label_17;
          case 8:
            num2 = 0;
            num1 = 7;
            continue;
          case 9:
            num2 = BPMGeneratorFunctionContainer.GetDays(BPMGeneratorFunctionContainer.GetDate(parameter.Value));
            num1 = 11;
            continue;
          case 10:
            if (context.Parameters == null)
            {
              num1 = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a7ee3a8a9e0d490f840373af5760d48d != 0 ? 12 : 6;
              continue;
            }
            goto default;
          case 13:
            if (BPMGeneratorFunctionContainer.rIuL7Hpqn8kFNynrSc((object) parameter) != null)
            {
              num1 = 6;
              continue;
            }
            goto label_17;
          default:
            if (BPMGeneratorFunctionContainer.YC7fN5ILiu8omluueT((object) context.Parameters) <= 0)
            {
              num1 = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_c1cf4a7dd0874037bf022e5737b29d28 != 0 ? 1 : 1;
              continue;
            }
            goto case 2;
        }
      }
label_17:
      return new FormatedValue((object) num2);
    }

    /// <summary>Истекла ли лицензия переданного компонента</summary>
    /// <remarks>
    /// * - Обязательные параметры
    /// Параметры:
    /// [0]*: Установленный компонент (IStoreComponentInfo)
    /// Пример:
    ///     Пусть Info - Переменная типа "Информация о компоненте ELMA Store".
    ///     Чтобы определить дату истечения лицензии этого компонента:
    ///     {ComponentLicenseIsExpired({$Info})}
    /// </remarks>
    /// <param name="context">Контекстная переменная</param>
    public static FormatedValue ComponentLicenseIsExpired(FunctionEvaluationContext context)
    {
      int num1 = 1;
      bool flag;
      while (true)
      {
        int num2 = num1;
        FormatedValue parameter;
        while (true)
        {
          switch (num2)
          {
            case 1:
              flag = true;
              num2 = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_8bb670bf0c514ecb87c6e60e7438e06f != 0 ? 0 : 0;
              continue;
            case 2:
              if (parameter == null)
              {
                num2 = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_505866aff0204b659e1cc72dbf89c08c == 0 ? 0 : 7;
                continue;
              }
              goto case 5;
            case 3:
              flag = BPMGeneratorFunctionContainer.GetDays(BPMGeneratorFunctionContainer.GetDate(parameter.Value)) <= 0;
              num2 = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_f0d1bba4ac354526b5e9d10858e05d66 == 0 ? 8 : 1;
              continue;
            case 4:
            case 7:
            case 8:
              goto label_15;
            case 5:
              if (BPMGeneratorFunctionContainer.rIuL7Hpqn8kFNynrSc((object) parameter) != null)
              {
                num2 = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_2af84c7d16434d6bb9d7477c8de31530 == 0 ? 9 : 10;
                continue;
              }
              goto label_15;
            case 6:
              if (BPMGeneratorFunctionContainer.YC7fN5ILiu8omluueT((object) context.Parameters) > 0)
                goto case 11;
              else
                goto label_8;
            case 9:
              if (context.Parameters != null)
              {
                num2 = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_5dd9092c888d47e082e13b5fa5305e45 == 0 ? 5 : 6;
                continue;
              }
              goto label_15;
            case 10:
              if (BPMGeneratorFunctionContainer.rIuL7Hpqn8kFNynrSc((object) parameter) is IStoreComponentInfo)
              {
                num2 = 3;
                continue;
              }
              goto label_15;
            case 11:
              parameter = context.Parameters[0];
              num2 = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_11df0b0286bd46b6a8780d914c7488e8 != 0 ? 2 : 0;
              continue;
            default:
              if (context != null)
              {
                num2 = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a2d1cecc368149d18a15dc8b377c30d5 == 0 ? 2 : 9;
                continue;
              }
              goto label_15;
          }
        }
label_8:
        num1 = 4;
      }
label_15:
      return new FormatedValue((object) flag);
    }

    /// <summary>Получить дату истечения лицензии</summary>
    /// <param name="param">Параметр контекстной переменной</param>
    /// <remarks>param приводится к IStoreComponentInfo</remarks>
    /// <returns>Дата истечения лицензии</returns>
    private static DateTime? GetDate(object param) => ExpirationInfoService.Instance.GetExpirationDate((IStoreComponentInfo) param);

    /// <summary>Получить количество дней до истечения лицензии</summary>
    /// <param name="date">Дата истечения лицензии</param>
    /// <returns>Количество дней до истечения лицензии</returns>
    private static int GetDays(DateTime? date)
    {
      DateTime now = DateTime.Now;
      DateTime? nullable1 = date;
      DateTime dateTime1 = now;
      if ((nullable1.HasValue ? (nullable1.GetValueOrDefault() > dateTime1 ? 1 : 0) : 0) == 0)
        return 0;
      DateTime? nullable2 = date;
      DateTime dateTime2 = now;
      return (int) (nullable2.HasValue ? new TimeSpan?(nullable2.GetValueOrDefault() - dateTime2) : new TimeSpan?()).Value.TotalDays;
    }

    public BPMGeneratorFunctionContainer()
    {
      BPMGeneratorFunctionContainer.wSR11DGPg9k9qpYysC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (<Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_5fc6cb15dbd84be7b6f01c9d3d0dc6f3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static int YC7fN5ILiu8omluueT([In] object obj0) => ((List<FormatedValue>) obj0).Count;

    internal static object rIuL7Hpqn8kFNynrSc([In] object obj0) => ((FormatedValue) obj0).Value;

    internal static bool j6sXnojFUvjH1rpjEQ() => BPMGeneratorFunctionContainer.ikG8ycOhDR0OVsFv2n == null;

    internal static BPMGeneratorFunctionContainer g70YkKsIN8m7aYihPA() => BPMGeneratorFunctionContainer.ikG8ycOhDR0OVsFv2n;

    internal static void wSR11DGPg9k9qpYysC() => TKW1L3mlUyvXmg29jA.RWk58XigPN();
  }
}
