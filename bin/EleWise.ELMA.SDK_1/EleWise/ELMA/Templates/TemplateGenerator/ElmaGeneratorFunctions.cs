// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.TemplateGenerator.ElmaGeneratorFunctions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Functions;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates.TemplateGenerator
{
  /// <summary>Функции для генерации с учетом специфики ELMA</summary>
  public static class ElmaGeneratorFunctions
  {
    private static ElmaGeneratorFunctions KZ5ObCBp2lGoqtgSyNrt;

    /// <summary>Начало таблицы из 2-х колонок для оповещения</summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    public static FormatedValue SR(FunctionEvaluationContext context)
    {
      int num1 = 5;
      FormatedValue formatedValue1;
      object[] array;
      string template;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          int count;
          FormatedValue formatedValue2;
          switch (num2)
          {
            case 1:
              formatedValue2 = (FormatedValue) null;
              break;
            case 2:
            case 11:
              goto label_23;
            case 3:
              if (!(ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) formatedValue1) is string))
              {
                num2 = 11;
                continue;
              }
              if (count <= 1)
              {
                num2 = 10;
                continue;
              }
              goto case 7;
            case 4:
              if (count <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
                continue;
              }
              formatedValue2 = context.Parameters[0];
              break;
            case 5:
              count = context.Parameters.Count;
              num2 = 4;
              continue;
            case 6:
              if (formatedValue1.Value != null)
              {
                num2 = 3;
                continue;
              }
              goto label_23;
            case 7:
              array = context.Parameters.GetRange(1, count - 1).Select<FormatedValue, object>((Func<FormatedValue, object>) (p =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (p == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_3;
                    default:
                      goto label_2;
                  }
                }
label_2:
                return (object) null;
label_3:
                // ISSUE: reference to a compiler-generated method
                return ElmaGeneratorFunctions.\u003C\u003Ec.FoC3hxQKOZvyVQyvs8HO((object) p);
              })).ToArray<object>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 2 : 9;
              continue;
            case 8:
              goto label_8;
            case 9:
              goto label_3;
            case 10:
              template = (string) formatedValue1.Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
              continue;
            case 12:
              if (formatedValue1 != null)
                goto case 6;
              else
                goto label_19;
            default:
              goto label_11;
          }
          formatedValue1 = formatedValue2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 12 : 3;
        }
label_19:
        num1 = 2;
      }
label_3:
      return new FormatedValue((object) EleWise.ELMA.SR.T((string) ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) formatedValue1), array));
label_8:
      return new FormatedValue(ElmaGeneratorFunctions.okFppHBpp7AeS2Itep5L((object) template));
label_11:
      try
      {
        template = (string) ElmaGeneratorFunctions.TTH9i4Bp3Npudo2d9fo4((object) new TextTemplateGenerator(template), ElmaGeneratorFunctions.xslOBABpNhsQmRav1DTD((object) context));
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
          num4 = 0;
        switch (num4)
        {
          default:
            goto label_8;
        }
      }
      catch
      {
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
          num5 = 0;
        switch (num5)
        {
          default:
            goto label_8;
        }
      }
label_23:
      return formatedValue1;
    }

    /// <summary>Получить элемент списка</summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public static FormatedValue GetListItem(FunctionEvaluationContext context)
    {
      int num1 = 18;
      int num2;
      int result;
      IEnumerator enumerator;
      while (true)
      {
        FormatedValue parameter1;
        FormatedValue parameter2;
        switch (num1)
        {
          case 1:
            goto label_11;
          case 2:
          case 4:
          case 5:
          case 7:
          case 15:
            goto label_4;
          case 3:
            enumerator = ((IEnumerable) ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) parameter2)).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 14 : 11;
            continue;
          case 6:
            goto label_13;
          case 8:
            parameter1 = context.Parameters[1];
            num1 = 13;
            continue;
          case 9:
            if (!(ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) parameter2) is ICollection))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 3 : 4;
              continue;
            }
            goto case 11;
          case 10:
            goto label_2;
          case 11:
            if (parameter1 == null)
            {
              num1 = 2;
              continue;
            }
            break;
          case 12:
            if (ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) parameter2) == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 7 : 1;
              continue;
            }
            goto case 9;
          case 13:
            if (parameter2 == null)
            {
              num1 = 15;
              continue;
            }
            goto case 12;
          case 14:
            goto label_28;
          case 16:
            goto label_16;
          case 17:
            parameter2 = context.Parameters[0];
            num1 = 8;
            continue;
          case 18:
            if (ElmaGeneratorFunctions.goby3jBpa6vMhTPKAbVQ((object) context.Parameters) >= 2)
            {
              num1 = 17;
              continue;
            }
            goto label_11;
        }
        if (ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) parameter1) != null)
        {
          if (!int.TryParse(ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) parameter1).ToString(), out result))
            num1 = 16;
          else if (ElmaGeneratorFunctions.hI1T2uBpDxmyYdXv6GtT((object) (ICollection) parameter2.Value) > result)
          {
            num2 = 0;
            num1 = 3;
          }
          else
            num1 = 10;
        }
        else
          num1 = 5;
      }
label_2:
      return (FormatedValue) null;
label_4:
      return (FormatedValue) null;
label_11:
      return (FormatedValue) null;
label_13:
      return (FormatedValue) null;
label_16:
      return (FormatedValue) null;
label_28:
      FormatedValue listItem;
      try
      {
label_35:
        if (ElmaGeneratorFunctions.gDJmtGBpw8xGL1nJtw95((object) enumerator))
          goto label_31;
        else
          goto label_36;
label_29:
        object obj;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_35;
            case 2:
              if (num2 == result)
              {
                num3 = 6;
                continue;
              }
              break;
            case 3:
              goto label_31;
            case 4:
              goto label_13;
            case 5:
              goto label_14;
            case 6:
              listItem = new FormatedValue(obj);
              num3 = 5;
              continue;
          }
          ++num2;
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 1;
        }
label_31:
        obj = ElmaGeneratorFunctions.qfEafeBptNbQK7MMaWoD((object) enumerator);
        num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        {
          num3 = 0;
          goto label_29;
        }
        else
          goto label_29;
label_36:
        num3 = 4;
        goto label_29;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num4 = 2;
        while (true)
        {
          switch (num4)
          {
            case 1:
              ElmaGeneratorFunctions.ATZIgoBp4kJFYmSmOIeV((object) disposable);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            case 2:
              if (disposable != null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 1;
                continue;
              }
              goto label_43;
            default:
              goto label_43;
          }
        }
label_43:;
      }
label_14:
      return listItem;
    }

    /// <summary>Извлекает подстроку из данного экземпляра</summary>
    /// <param name="context">String, StartIndex, Length</param>
    /// <returns></returns>
    public static FormatedValue SubString(FunctionEvaluationContext context)
    {
      int num1 = 17;
      FormatedValue parameter1;
      FormatedValue formatedValue1;
      FormatedValue parameter2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (parameter2 != null)
              {
                num2 = 6;
                continue;
              }
              goto label_15;
            case 2:
              if (context.Parameters.Count == 3)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                continue;
              }
              goto label_18;
            case 3:
              if (ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) parameter1) == null)
              {
                num2 = 14;
                continue;
              }
              goto case 11;
            case 4:
              if (formatedValue1 != null)
              {
                num2 = 10;
                continue;
              }
              goto label_17;
            case 5:
              goto label_27;
            case 6:
              if (parameter2.Value != null)
                goto case 13;
              else
                goto label_14;
            case 7:
              if (!(ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) formatedValue1) is int))
              {
                num2 = 12;
                continue;
              }
              goto label_18;
            case 8:
              formatedValue1 = (FormatedValue) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 2 : 2;
              continue;
            case 9:
              if (parameter1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 21 : 9;
                continue;
              }
              goto case 3;
            case 10:
              if (ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) formatedValue1) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 7 : 2;
                continue;
              }
              goto label_17;
            case 11:
              if (ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) parameter1) is int)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 8 : 3;
                continue;
              }
              goto label_15;
            case 12:
              goto label_17;
            case 13:
              if (!(parameter2.Value is string))
              {
                num2 = 19;
                continue;
              }
              goto case 9;
            case 14:
            case 15:
            case 18:
            case 19:
            case 21:
              goto label_15;
            case 16:
              parameter1 = context.Parameters[1];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 1 : 1;
              continue;
            case 17:
              parameter2 = context.Parameters[0];
              num2 = 16;
              continue;
            case 20:
              goto label_9;
            default:
              formatedValue1 = context.Parameters[2];
              num2 = 4;
              continue;
          }
        }
label_14:
        num1 = 18;
        continue;
label_18:
        num1 = 5;
      }
label_9:
      FormatedValue formatedValue2;
      return formatedValue2;
label_15:
      return (FormatedValue) null;
label_17:
      return (FormatedValue) null;
label_27:
      try
      {
        int num3;
        if (formatedValue1 != null)
          num3 = 2;
        else
          goto label_30;
label_29:
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_30;
            case 2:
              formatedValue2 = new FormatedValue(ElmaGeneratorFunctions.R7qvcqBp6yBan1oM68Hq((object) (string) ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) parameter2), (int) ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) parameter1), (int) formatedValue1.Value));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            default:
              goto label_9;
          }
        }
label_30:
        formatedValue2 = new FormatedValue((object) ((string) parameter2.Value).Substring((int) ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) parameter1)));
        num3 = 3;
        goto label_29;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_9;
            default:
              formatedValue2 = (FormatedValue) null;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 0;
              continue;
          }
        }
      }
    }

    /// <summary>
    /// Узнать, является ли однин тип объекта базовым для другого по идентификаторам типа.
    /// Пример: IsBaseObjectType('BaseObjectTypeUid', 'CheckObjectTypeUid')
    /// </summary>
    /// <param name="context">'BaseObjectTypeUid'; 'CheckObjectTypeUid'</param>
    /// <returns></returns>
    public static FormatedValue IsBaseObjectType(FunctionEvaluationContext context)
    {
      int num1 = 1;
      bool flag;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (ElmaGeneratorFunctions.goby3jBpa6vMhTPKAbVQ((object) context.Parameters) != 2)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            }
            flag = false;
            num1 = 3;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_7;
          default:
            goto label_5;
        }
      }
label_4:
      return new FormatedValue((object) flag);
label_5:
      return (FormatedValue) null;
label_7:
      try
      {
        flag = MetadataLoader.IsBaseClass(ElmaGeneratorFunctions.YnUlVxBpHLGF3wQCokC7((object) ElmaGeneratorFunctions.KVVGXYBp1csg86lbFVe8((object) context.Parameters[0]).ToString()), (ClassMetadata) MetadataLoader.LoadMetadata(ElmaGeneratorFunctions.YnUlVxBpHLGF3wQCokC7((object) context.Parameters[1].Value.ToString())));
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_4;
        }
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              ElmaGeneratorFunctions.wbGMllBpxJF5KmmAEQJX(ElmaGeneratorFunctions.rhcB2KBpAfpfkE1mBEwQ(), (object) EleWise.ELMA.SR.T((string) ElmaGeneratorFunctions.XXoytnBp7Bh8QdHksNFg(-87337865 ^ -87420831)), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
      }
    }

    /// <summary>Форматирует дату</summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public static FormatedValue FormatDateTime(FunctionEvaluationContext context)
    {
      int num = 5;
      DateTime result;
      while (true)
      {
        object obj;
        switch (num)
        {
          case 1:
          case 7:
            goto label_2;
          case 2:
label_7:
            result = DateTime.MinValue;
            num = 7;
            continue;
          case 3:
            goto label_10;
          case 4:
            if (context.Parameters[0] != null)
            {
              num = 6;
              continue;
            }
            goto label_10;
          case 5:
            if (ElmaGeneratorFunctions.goby3jBpa6vMhTPKAbVQ((object) context.Parameters) >= 2)
            {
              num = 4;
              continue;
            }
            goto label_10;
          case 6:
            if (context.Parameters[1] != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          case 8:
            obj = (object) "";
            break;
          default:
            obj = context.Parameters[0].Value;
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 8 : 8;
              continue;
            }
            break;
        }
        if (DateTime.TryParse(obj.ToString(), out result))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 1;
        else
          goto label_7;
      }
label_2:
      return new FormatedValue((object) result.ToString((string) context.Parameters[1].Value));
label_10:
      return (FormatedValue) null;
    }

    /// <summary>Вывод заголовка свойства</summary>
    /// <param name="context"></param>
    /// <returns></returns>
    public static FormatedValue Caption(FunctionEvaluationContext context)
    {
      int num = 1;
      MetadataBasedFormat format;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (context.Parameters.Count < 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            if (context.Parameters[0] != null)
            {
              num = 4;
              continue;
            }
            goto label_2;
          case 3:
            goto label_13;
          case 4:
            format = context.Parameters[0].Format as MetadataBasedFormat;
            num = 8;
            continue;
          case 6:
            goto label_12;
          case 7:
            if (format.PropertyMetadata != null)
            {
              num = 3;
              continue;
            }
            goto label_12;
          case 8:
            if (format != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 7 : 1;
              continue;
            }
            goto label_12;
          default:
            goto label_2;
        }
      }
label_2:
      return (FormatedValue) null;
label_12:
      return (FormatedValue) null;
label_13:
      return new FormatedValue(ElmaGeneratorFunctions.NoHx1eBpm8j0cNtvcEBU(ElmaGeneratorFunctions.xA7eYCBp0utyoObtOd8k((object) format)));
    }

    internal static object KVVGXYBp1csg86lbFVe8([In] object obj0) => ((FormatedValue) obj0).Value;

    internal static object xslOBABpNhsQmRav1DTD([In] object obj0) => (object) ((FunctionEvaluationContext) obj0).DataSource;

    internal static object TTH9i4Bp3Npudo2d9fo4([In] object obj0, [In] object obj1) => (object) ((TextGenerator) obj0).Generate((IGeneratorDataSource) obj1);

    internal static object okFppHBpp7AeS2Itep5L([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool Vtp866BpeKQaIalfFLr3() => ElmaGeneratorFunctions.KZ5ObCBp2lGoqtgSyNrt == null;

    internal static ElmaGeneratorFunctions Xoil0sBpPNbuppknU02p() => ElmaGeneratorFunctions.KZ5ObCBp2lGoqtgSyNrt;

    internal static int goby3jBpa6vMhTPKAbVQ([In] object obj0) => ((List<FormatedValue>) obj0).Count;

    internal static int hI1T2uBpDxmyYdXv6GtT([In] object obj0) => ((ICollection) obj0).Count;

    internal static object qfEafeBptNbQK7MMaWoD([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static bool gDJmtGBpw8xGL1nJtw95([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void ATZIgoBp4kJFYmSmOIeV([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object R7qvcqBp6yBan1oM68Hq([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static Guid YnUlVxBpHLGF3wQCokC7([In] object obj0) => Guid.Parse((string) obj0);

    internal static object rhcB2KBpAfpfkE1mBEwQ() => (object) Logger.Log;

    internal static object XXoytnBp7Bh8QdHksNFg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void wbGMllBpxJF5KmmAEQJX([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static object xA7eYCBp0utyoObtOd8k([In] object obj0) => (object) ((MetadataBasedFormat) obj0).PropertyMetadata;

    internal static object NoHx1eBpm8j0cNtvcEBU([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;
  }
}
