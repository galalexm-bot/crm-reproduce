// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.TemplateGenerator.NotificationFunctions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Formats;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Web.Mvc;

namespace EleWise.ELMA.Notifications.Impl.TemplateGenerator
{
  /// <summary>Функции для генерации оповещений</summary>
  public static class NotificationFunctions
  {
    private static readonly NotificationFunctions.PropertyRowParamIndices RowIndices;
    private static readonly NotificationFunctions.PropertyRowParamIndices RowChangesIndices;
    private static NotificationFunctions hiRDaTHCJT43IoTHCbc;

    /// <summary>Ссылка. Первый параметр текст ссылки, второй - URL</summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    public static FormatedValue Link(FunctionEvaluationContext context)
    {
      int num1 = 6;
      string str1;
      string str2;
      while (true)
      {
        int num2 = num1;
        FormatedValue parameter;
        TemplateRenderMode templateRenderMode;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
            case 14:
              goto label_25;
            case 3:
              if (parameter == null)
              {
                num2 = 8;
                continue;
              }
              goto case 16;
            case 4:
            case 8:
              parameter = context.Parameters[1];
              num2 = 18;
              continue;
            case 5:
              if (context.Parameters.Count >= 2)
              {
                num2 = 11;
                continue;
              }
              goto label_23;
            case 6:
              templateRenderMode = NotificationFunctions.YOC3ENHuIEcWULVreyp(NotificationFunctions.Vpt0dGHZO0T75E7EkVs((object) context));
              num2 = 5;
              continue;
            case 7:
              if (NotificationFunctions.INCTrIHIxFLySih6GaB((object) parameter) != null)
              {
                num2 = 17;
                continue;
              }
              goto label_25;
            case 9:
              str2 = "";
              num2 = 15;
              continue;
            case 10:
              goto label_23;
            case 11:
              str1 = "";
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 9 : 9;
              continue;
            case 12:
              str1 = parameter.Value.ToString().HtmlEncode();
              num2 = 4;
              continue;
            case 13:
              goto label_24;
            case 15:
              parameter = context.Parameters[0];
              num2 = 3;
              continue;
            case 16:
              if (NotificationFunctions.INCTrIHIxFLySih6GaB((object) parameter) != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 12 : 12;
                continue;
              }
              goto case 4;
            case 17:
              if (!(NotificationFunctions.INCTrIHIxFLySih6GaB((object) parameter) is string))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
                continue;
              }
              goto label_24;
            case 18:
              if (parameter == null)
              {
                num2 = 14;
                continue;
              }
              goto case 7;
            case 19:
              if (templateRenderMode == TemplateRenderMode.HTML)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
                continue;
              }
              goto label_22;
            case 20:
              if (NotificationFunctions.x2IOjnHV5xUe7ttNQhs((object) str2))
              {
                num2 = 10;
                continue;
              }
              goto case 19;
            default:
              goto label_21;
          }
        }
label_24:
        str2 = (string) parameter.Value;
        num1 = 2;
        continue;
label_25:
        if (!NotificationFunctions.x2IOjnHV5xUe7ttNQhs((object) str1))
          num1 = 20;
        else
          goto label_23;
      }
label_21:
      return new FormatedValue(NotificationFunctions.LROWAlHR7M37tmoOqEs(NotificationFunctions.c8ROQcHiDGXgunXqRhZ(NotificationFunctions.nmrQgaHS7d4iyPgqr9e(1514961705 ^ 1514989883), (object) str2, (object) str1)));
label_22:
      return new FormatedValue(NotificationFunctions.c8ROQcHiDGXgunXqRhZ(NotificationFunctions.nmrQgaHS7d4iyPgqr9e(979449278 ^ 979478526), (object) str2, (object) str1));
label_23:
      return new FormatedValue();
    }

    /// <summary>Жирный текст</summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    public static FormatedValue BoldText(FunctionEvaluationContext context)
    {
      int num = 2;
      FormatedValue parameter;
      string str;
      TemplateRenderMode renderMode;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (context.Parameters.Count < 1)
            {
              num = 5;
              continue;
            }
            goto case 12;
          case 2:
            renderMode = ((GenerationContext) NotificationFunctions.Vpt0dGHZO0T75E7EkVs((object) context)).GetRenderMode();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
            continue;
          case 3:
            if (parameter == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
              continue;
            }
            goto case 14;
          case 5:
          case 9:
            goto label_19;
          case 6:
            goto label_17;
          case 8:
            if (!(NotificationFunctions.INCTrIHIxFLySih6GaB((object) parameter) is string))
            {
              num = 13;
              continue;
            }
            goto case 15;
          case 10:
            parameter = context.Parameters[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 3 : 3;
            continue;
          case 11:
            if (renderMode == TemplateRenderMode.HTML)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 6 : 2;
              continue;
            }
            goto label_18;
          case 12:
            str = "";
            num = 10;
            continue;
          case 14:
            if (NotificationFunctions.INCTrIHIxFLySih6GaB((object) parameter) == null)
            {
              num = 4;
              continue;
            }
            goto case 8;
          case 15:
            str = (string) NotificationFunctions.INCTrIHIxFLySih6GaB((object) parameter);
            num = 7;
            continue;
          default:
            if (NotificationFunctions.x2IOjnHV5xUe7ttNQhs((object) str))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 9 : 5;
              continue;
            }
            goto case 11;
        }
      }
label_17:
      return new FormatedValue(NotificationFunctions.LROWAlHR7M37tmoOqEs(NotificationFunctions.vq4opWHqq1Wlou3OwR2((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654268729), (object) str)));
label_18:
      return new FormatedValue((object) str);
label_19:
      return new FormatedValue();
    }

    /// <summary>Получить отображаемое имя сущности.</summary>
    /// <returns></returns>
    public static FormatedValue EntityDisplayName(FunctionEvaluationContext context)
    {
      int num = 13;
      FormatedValue parameter;
      ClassMetadata classMetadata;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            parameter = context.Parameters[0];
            num = 8;
            continue;
          case 2:
            if (classMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 3 : 2;
              continue;
            }
            goto case 10;
          case 4:
            if (parameter.Value is IEntity)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 11 : 7;
              continue;
            }
            goto label_14;
          case 5:
            if (NotificationFunctions.XWXL7gHKFBhlpVyu1b6((object) context.Parameters) <= 0)
            {
              num = 9;
              continue;
            }
            goto case 1;
          case 8:
            if (parameter != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 14 : 14;
              continue;
            }
            goto label_14;
          case 10:
            str = (string) NotificationFunctions.nWfBImHXN5pWUg2sfcv((object) classMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 6 : 3;
            continue;
          case 11:
            classMetadata = MetadataLoader.LoadMetadata(NotificationFunctions.INCTrIHIxFLySih6GaB((object) parameter).GetType()) as ClassMetadata;
            num = 2;
            continue;
          case 12:
            if (context != null)
            {
              num = 15;
              continue;
            }
            goto label_14;
          case 13:
            str = "";
            num = 12;
            continue;
          case 14:
            if (NotificationFunctions.INCTrIHIxFLySih6GaB((object) parameter) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 15:
            if (context.Parameters == null)
            {
              num = 7;
              continue;
            }
            goto case 5;
          default:
            goto label_14;
        }
      }
label_14:
      return new FormatedValue((object) str);
    }

    /// <summary>Начало таблицы из 2-х колонок для оповещения</summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    public static FormatedValue TableStart(FunctionEvaluationContext context)
    {
      int num = 2;
      TemplateRenderMode templateRenderMode;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (templateRenderMode == TemplateRenderMode.HTML)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            templateRenderMode = NotificationFunctions.YOC3ENHuIEcWULVreyp(NotificationFunctions.Vpt0dGHZO0T75E7EkVs((object) context));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return new FormatedValue((object) MvcHtmlString.Create((string) NotificationFunctions.nmrQgaHS7d4iyPgqr9e(1142330761 ^ 1541959139 ^ 536766994)));
label_3:
      return (FormatedValue) NotificationFunctions.rEYDjQHTkQYWJ4J8JeI((object) context);
    }

    /// <summary>Конец таблицы из 2-х колонок для оповещения</summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    public static FormatedValue TableEnd(FunctionEvaluationContext context)
    {
      int num = 1;
      TemplateRenderMode templateRenderMode;
      while (true)
      {
        switch (num)
        {
          case 1:
            templateRenderMode = NotificationFunctions.YOC3ENHuIEcWULVreyp(NotificationFunctions.Vpt0dGHZO0T75E7EkVs((object) context));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (templateRenderMode == TemplateRenderMode.HTML)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 0;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return new FormatedValue(NotificationFunctions.LROWAlHR7M37tmoOqEs(NotificationFunctions.nmrQgaHS7d4iyPgqr9e(1149433385 + 173655049 ^ 1323051248)));
label_6:
      return NotificationFunctions.GenerateEmptyRow((object) context);
    }

    /// <summary>Пустое пространство между строками с данными</summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    public static FormatedValue EmptyRow(FunctionEvaluationContext context)
    {
      int num = 2;
      TemplateRenderMode renderMode;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (renderMode == TemplateRenderMode.HTML)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            renderMode = ((GenerationContext) NotificationFunctions.Vpt0dGHZO0T75E7EkVs((object) context)).GetRenderMode();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return new FormatedValue((object) MvcHtmlString.Create((string) NotificationFunctions.nmrQgaHS7d4iyPgqr9e(87862435 ^ 87834229)));
label_3:
      return new FormatedValue((object) string.Empty);
    }

    /// <summary>
    /// Генерирует 2 столбца - имя свойства и значение свойства.
    /// Параметр 1 - Значение.
    /// Параметр 2 - Заголовок (необязательный).
    /// Параметр 3 - Видимость (необязательный).
    /// </summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    public static FormatedValue PropertyRow(FunctionEvaluationContext context)
    {
      int num = 2;
      string formatedValue;
      string caption;
      bool visibility;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (visibility)
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 2:
            NotificationFunctions.ExtractPropertyRowValues(NotificationFunctions.RowIndices, (object) context, out formatedValue, out caption, out visibility);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (FormatedValue) NotificationFunctions.rEYDjQHTkQYWJ4J8JeI((object) context);
label_3:
      return (FormatedValue) NotificationFunctions.xgqfw7HkwKZCLnWlQMY((object) context, (object) formatedValue, (object) caption);
    }

    /// <summary>
    /// Генерирует 2 строки из слитых 2-х столбцов - имя свойства и значение свойства.
    /// Параметр 1 - Значение.
    /// Параметр 2 - Заголовок (необязательный).
    /// Параметр 3 - Видимость (необязательный).
    /// </summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    public static FormatedValue PropertyFullRow(FunctionEvaluationContext context)
    {
      int num = 2;
      string formatedValue;
      string caption;
      bool visibility;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!visibility)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            NotificationFunctions.ExtractPropertyRowValues(NotificationFunctions.RowIndices, (object) context, out formatedValue, out caption, out visibility);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return NotificationFunctions.GenerateEmptyRow((object) context);
label_3:
      return (FormatedValue) NotificationFunctions.VRHx62Hn0NtotfIJTkQ((object) context, (object) formatedValue, (object) caption);
    }

    /// <summary>
    /// Генерирует 2 столбца - имя свойства и значение свойства с информацией об изменении (если оно было).
    /// Параметр 1 - Старое значение.
    /// Параметр 2 - Новое значение.
    /// Параметр 3 - Заголовок (необязательный).
    /// Параметр 4 - Видимость (необязательный).
    /// </summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    public static FormatedValue PropertyRowWithChanges(FunctionEvaluationContext context)
    {
      int num = 2;
      bool visibility;
      string oldFormatedValue;
      string formatedValue;
      string caption;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!visibility)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            NotificationFunctions.ExtractPropertyRowValues(NotificationFunctions.RowChangesIndices, (object) context, out oldFormatedValue, out formatedValue, out caption, out visibility);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return (FormatedValue) NotificationFunctions.rEYDjQHTkQYWJ4J8JeI((object) context);
label_6:
      return (FormatedValue) NotificationFunctions.xgqfw7HkwKZCLnWlQMY((object) context, (object) NotificationFunctions.FormatValueChanges((object) context, (object) oldFormatedValue, (object) formatedValue), (object) caption);
    }

    /// <summary>
    /// Генерирует 2 строки из слитых 2-х столбцов - имя свойства и значение свойства с информацией об изменении (если оно было).
    /// Параметр 1 - Старое значение.
    /// Параметр 2 - Новое значение.
    /// Параметр 3 - Заголовок (необязательный).
    /// Параметр 4 - Видимость (необязательный).
    /// </summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    public static FormatedValue PropertyFullRowWithChanges(FunctionEvaluationContext context)
    {
      int num = 1;
      string oldFormatedValue;
      string formatedValue;
      string caption;
      bool visibility;
      while (true)
      {
        switch (num)
        {
          case 1:
            NotificationFunctions.ExtractPropertyRowValues(NotificationFunctions.RowChangesIndices, (object) context, out oldFormatedValue, out formatedValue, out caption, out visibility);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            goto label_6;
          default:
            if (visibility)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 3 : 3;
              continue;
            }
            goto label_5;
        }
      }
label_5:
      return (FormatedValue) NotificationFunctions.rEYDjQHTkQYWJ4J8JeI((object) context);
label_6:
      return (FormatedValue) NotificationFunctions.VRHx62Hn0NtotfIJTkQ((object) context, NotificationFunctions.qOFKoZHOcMA4dkLIBS5((object) context, (object) oldFormatedValue, (object) formatedValue), (object) caption);
    }

    /// <summary>
    /// Генерирует 2 столбца - имя свойства и значение свойства с информацией об изменении. Если изменения не было - пустая строка.
    /// Параметр 1 - Старое значение.
    /// Параметр 2 - Новое значение.
    /// Параметр 3 - Заголовок (необязательный).
    /// Параметр 4 - Видимость (необязательный).
    /// </summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    public static FormatedValue PropertyRowIfChanged(FunctionEvaluationContext context)
    {
      int num = 3;
      string oldFormatedValue;
      string formatedValue;
      string caption;
      bool visibility;
      while (true)
      {
        switch (num)
        {
          case 2:
            if (!visibility)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 3:
            NotificationFunctions.ExtractPropertyRowValues(NotificationFunctions.RowChangesIndices, (object) context, out oldFormatedValue, out formatedValue, out caption, out visibility);
            num = 2;
            continue;
          case 4:
            if (oldFormatedValue == formatedValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 1;
              continue;
            }
            goto label_6;
          default:
            goto label_5;
        }
      }
label_5:
      return NotificationFunctions.GenerateEmptyRow((object) context);
label_6:
      return (FormatedValue) NotificationFunctions.xgqfw7HkwKZCLnWlQMY((object) context, (object) NotificationFunctions.FormatValueChanges((object) context, (object) oldFormatedValue, (object) formatedValue), (object) caption);
    }

    /// <summary>
    /// Генерирует 2 строки из слитых 2-х столбцов - имя свойства и значение свойства с информацией об изменении. Если изменения не было - пустая строка.
    /// Параметр 1 - Старое значение.
    /// Параметр 2 - Новое значение.
    /// Параметр 3 - Заголовок (необязательный).
    /// Параметр 4 - Видимость (необязательный).
    /// </summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    public static FormatedValue PropertyFullRowIfChanged(FunctionEvaluationContext context)
    {
      int num = 4;
      string oldFormatedValue;
      string formatedValue;
      string caption;
      bool visibility;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 5:
            goto label_7;
          case 2:
            if (!(oldFormatedValue == formatedValue))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 3:
            if (!visibility)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
              continue;
            }
            goto case 2;
          case 4:
            NotificationFunctions.ExtractPropertyRowValues(NotificationFunctions.RowChangesIndices, (object) context, out oldFormatedValue, out formatedValue, out caption, out visibility);
            num = 3;
            continue;
          default:
            goto label_8;
        }
      }
label_7:
      return NotificationFunctions.GenerateEmptyRow((object) context);
label_8:
      return (FormatedValue) NotificationFunctions.VRHx62Hn0NtotfIJTkQ((object) context, NotificationFunctions.qOFKoZHOcMA4dkLIBS5((object) context, (object) oldFormatedValue, (object) formatedValue), (object) caption);
    }

    private static string FormatValueChanges(object context, object oldValue, object newValue)
    {
      int num = 6;
      string str;
      while (true)
      {
        object obj1;
        switch (num)
        {
          case 3:
            if (!NotificationFunctions.YhAmYRH2bMipLv0kNpn(oldValue, newValue))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            }
            goto case 7;
          case 4:
            str = (string) NotificationFunctions.IfXrL1HeF3CRYd0uGTI((object) str, (object) SR.T((string) NotificationFunctions.nmrQgaHS7d4iyPgqr9e(-1217523399 ^ -1217494413), oldValue));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
            continue;
          case 5:
            obj1 = (object) string.Empty;
            break;
          case 6:
            object obj2 = newValue;
            if (obj2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 4 : 5;
              continue;
            }
            obj1 = obj2;
            break;
          case 7:
            if (string.IsNullOrEmpty((string) oldValue))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 2 : 2;
              continue;
            }
            goto case 4;
          default:
            goto label_7;
        }
        str = (string) obj1;
        num = 3;
      }
label_7:
      return str;
    }

    private static void ExtractPropertyRowValues(
      NotificationFunctions.PropertyRowParamIndices indices,
      object context,
      out string formatedValue,
      out string caption,
      out bool visibility)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            NotificationFunctions.ExtractPropertyRowValues(indices, context, out string _, out formatedValue, out caption, out visibility);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static void ExtractPropertyRowValues(
      NotificationFunctions.PropertyRowParamIndices indices,
      object context,
      out string oldFormatedValue,
      out string formatedValue,
      out string caption,
      out bool visibility)
    {
      int num1 = 36;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IEnumerable source;
          FormatedValue formatedValue1;
          FormatedValue formatedValue2;
          FormatedValue formatedValue3;
          FormatedValue formatedValue4;
          MetadataBasedFormat metadataBasedFormat1;
          FormatedValue formatedValue5;
          FormatedValue formatedValue6;
          FormatedValue formatedValue7;
          MetadataBasedFormat metadataBasedFormat2;
          FormatedValue formatedValue8;
          switch (num2)
          {
            case 1:
              formatedValue5 = (FormatedValue) null;
              goto label_71;
            case 2:
              if (source != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 12 : 39;
                continue;
              }
              break;
            case 3:
            case 21:
              if (NotificationFunctions.XWXL7gHKFBhlpVyu1b6((object) ((FunctionEvaluationContext) context).Parameters) <= indices.NewValue)
              {
                num2 = 28;
                continue;
              }
              formatedValue7 = ((FunctionEvaluationContext) context).Parameters[indices.NewValue];
              goto label_77;
            case 4:
              if (NotificationFunctions.INCTrIHIxFLySih6GaB((object) formatedValue4) == null)
                goto case 10;
              else
                goto label_39;
            case 5:
              goto label_21;
            case 6:
              metadataBasedFormat2 = formatedValue2.Format as MetadataBasedFormat;
              goto label_83;
            case 7:
              goto label_79;
            case 8:
              formatedValue6 = (FormatedValue) null;
              goto label_81;
            case 9:
              if (indices.Visibility >= 0)
              {
                if (NotificationFunctions.XWXL7gHKFBhlpVyu1b6((object) ((FunctionEvaluationContext) context).Parameters) <= indices.Visibility)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 1;
                  continue;
                }
                formatedValue5 = ((FunctionEvaluationContext) context).Parameters[indices.Visibility];
                goto label_71;
              }
              else
              {
                num2 = 23;
                continue;
              }
            case 10:
              if (formatedValue2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 6 : 4;
                continue;
              }
              goto case 38;
            case 11:
              visibility = true;
              num2 = 9;
              continue;
            case 12:
              formatedValue6 = ((FunctionEvaluationContext) context).Parameters[indices.Caption];
              goto label_81;
            case 13:
              goto label_64;
            case 14:
              caption = string.Empty;
              num2 = 11;
              continue;
            case 15:
              if (formatedValue4 == null)
              {
                num2 = 10;
                continue;
              }
              goto case 4;
            case 16:
              if (NotificationFunctions.INCTrIHIxFLySih6GaB((object) formatedValue2) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 18 : 11;
                continue;
              }
              source = NotificationFunctions.INCTrIHIxFLySih6GaB((object) formatedValue2) as IEnumerable;
              num2 = 2;
              continue;
            case 17:
label_65:
              if (NotificationFunctions.XWXL7gHKFBhlpVyu1b6((object) ((FunctionEvaluationContext) context).Parameters) > indices.Caption)
              {
                num2 = 12;
                continue;
              }
              goto case 8;
            case 18:
            case 27:
              visibility = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 2 : 5;
              continue;
            case 19:
              caption = (string) NotificationFunctions.INCTrIHIxFLySih6GaB((object) formatedValue4);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 47 : 12;
              continue;
            case 20:
              goto label_36;
            case 22:
              goto label_6;
            case 23:
              formatedValue5 = (FormatedValue) null;
              goto label_71;
            case 24:
              if (formatedValue3 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 11 : 17;
                continue;
              }
              goto case 42;
            case 25:
              formatedValue1 = (FormatedValue) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 7 : 33;
              continue;
            case 26:
              if (formatedValue3 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 15 : 43;
                continue;
              }
              goto case 25;
            case 28:
              formatedValue7 = (FormatedValue) null;
              goto label_77;
            case 29:
              if (!(bool) formatedValue3.Value)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
                continue;
              }
              goto case 25;
            case 30:
              if (NotificationFunctions.INCTrIHIxFLySih6GaB((object) formatedValue4) is string)
              {
                num2 = 19;
                continue;
              }
              goto case 10;
            case 31:
              caption = ((NamedMetadata) NotificationFunctions.Gk5L8wH1F98ykrwfNLO((object) metadataBasedFormat1)).DisplayName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 13;
              continue;
            case 32:
              if (metadataBasedFormat1 != null)
              {
                num2 = 46;
                continue;
              }
              goto label_75;
            case 33:
              if (indices.OldValue < 0)
              {
                num2 = 21;
                continue;
              }
              goto case 49;
            case 34:
              goto label_54;
            case 35:
              formatedValue = (string) null;
              num2 = 14;
              continue;
            case 36:
              oldFormatedValue = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 35 : 34;
              continue;
            case 37:
              formatedValue = formatedValue2 == null ? string.Empty : ((IGeneratorFormatProvider) NotificationFunctions.d2kr0YHPihgXAPZprJg(NotificationFunctions.Vpt0dGHZO0T75E7EkVs(context))).FormatValue(formatedValue2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 15 : 24;
              continue;
            case 38:
              metadataBasedFormat2 = (MetadataBasedFormat) null;
              goto label_83;
            case 39:
              if (source.Cast<object>().Count<object>() == 0)
              {
                num2 = 34;
                continue;
              }
              break;
            case 40:
              formatedValue8 = (FormatedValue) null;
              goto label_73;
            case 41:
              caption = string.Empty;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 10 : 15;
              continue;
            case 42:
              if (formatedValue2 == null)
              {
                num2 = 27;
                continue;
              }
              goto case 16;
            case 43:
              if (formatedValue3.Value is bool)
                goto case 29;
              else
                goto label_32;
            case 44:
              goto label_63;
            case 45:
              visibility = false;
              num2 = 20;
              continue;
            case 46:
              if (metadataBasedFormat1.PropertyMetadata == null)
              {
                num2 = 44;
                continue;
              }
              goto case 31;
            case 47:
              goto label_8;
            case 48:
              oldFormatedValue = formatedValue1 == null ? string.Empty : ((FunctionEvaluationContext) context).GenerationContext.FormatProvider.FormatValue(formatedValue1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 3 : 2;
              continue;
            case 49:
              if (NotificationFunctions.XWXL7gHKFBhlpVyu1b6((object) ((FunctionEvaluationContext) context).Parameters) <= indices.OldValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 40 : 20;
                continue;
              }
              formatedValue8 = ((FunctionEvaluationContext) context).Parameters[indices.OldValue];
              goto label_73;
            default:
              visibility = false;
              num2 = 7;
              continue;
          }
          if (!NotificationFunctions.x2IOjnHV5xUe7ttNQhs((object) formatedValue))
            goto label_65;
          else
            break;
label_71:
          formatedValue3 = formatedValue5;
          num2 = 26;
          continue;
label_73:
          formatedValue1 = formatedValue8;
          num2 = 48;
          continue;
label_77:
          formatedValue2 = formatedValue7;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 37 : 35;
          continue;
label_81:
          formatedValue4 = formatedValue6;
          num2 = 41;
          continue;
label_83:
          metadataBasedFormat1 = metadataBasedFormat2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 32;
        }
        num1 = 45;
        continue;
label_32:
        num1 = 25;
        continue;
label_39:
        num1 = 30;
        continue;
label_54:
        visibility = false;
        num1 = 22;
      }
label_21:
      return;
label_79:
      return;
label_64:
      return;
label_36:
      return;
label_6:
      return;
label_63:
      return;
label_8:
      return;
label_75:;
    }

    private static FormatedValue GenerateRow(object context, object formatedValue, object caption)
    {
      int num1 = 10;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        int length;
        int num3;
        TemplateRenderMode renderMode;
        while (true)
        {
          switch (num2)
          {
            case 1:
              stringBuilder.Append((string) NotificationFunctions.nmrQgaHS7d4iyPgqr9e(1461825605 - 1531863589 ^ -70001164));
              num2 = 13;
              continue;
            case 2:
              if (length > num3)
              {
                num2 = 8;
                continue;
              }
              goto label_23;
            case 3:
              NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, (object) ((IGeneratorFormatProvider) NotificationFunctions.d2kr0YHPihgXAPZprJg(NotificationFunctions.Vpt0dGHZO0T75E7EkVs(context))).FormatValue(new FormatedValue(caption)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 20 : 9;
              continue;
            case 4:
              goto label_10;
            case 5:
              if (renderMode != TemplateRenderMode.HTML)
              {
                if (NotificationFunctions.x2IOjnHV5xUe7ttNQhs(caption))
                {
                  num2 = 14;
                  continue;
                }
                goto case 18;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 17 : 12;
                continue;
              }
            case 6:
              length = NotificationFunctions.mPTDmBHpg5eMPyfvoG2(caption);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 15 : 13;
              continue;
            case 7:
              NotificationFunctions.A0UT6sH3BhVImcpAaia((object) stringBuilder, NotificationFunctions.nmrQgaHS7d4iyPgqr9e(1917256330 ^ 1917292860));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
              continue;
            case 8:
              ((FunctionEvaluationContext) context).GenerationContext.SetTextCaptionMaxLength(length);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 12 : 8;
              continue;
            case 9:
              renderMode = ((GenerationContext) NotificationFunctions.Vpt0dGHZO0T75E7EkVs(context)).GetRenderMode();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 5 : 5;
              continue;
            case 10:
              stringBuilder = new StringBuilder();
              num2 = 9;
              continue;
            case 11:
              NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, formatedValue);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 6 : 7;
              continue;
            case 12:
            case 14:
              goto label_23;
            case 13:
              goto label_12;
            case 15:
              num3 = NotificationFunctions.J4Md9qHaGF2jXKsMBcE((object) ((FunctionEvaluationContext) context).GenerationContext);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 2;
              continue;
            case 16:
              NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, NotificationFunctions.nmrQgaHS7d4iyPgqr9e(1051802738 - -1831968059 ^ -1411233063));
              num2 = 3;
              continue;
            case 17:
              stringBuilder.AppendLine((string) NotificationFunctions.nmrQgaHS7d4iyPgqr9e(-1921202237 ^ -1921231701));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 16 : 15;
              continue;
            case 18:
              NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, caption);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            case 19:
              stringBuilder.Append((string) NotificationFunctions.nmrQgaHS7d4iyPgqr9e(-2138958856 ^ -2138931140));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 11 : 1;
              continue;
            case 20:
              NotificationFunctions.A0UT6sH3BhVImcpAaia((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137488260));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 19 : 3;
              continue;
            default:
              NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70036241));
              num2 = 6;
              continue;
          }
        }
label_23:
        NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, formatedValue);
        num1 = 4;
      }
label_10:
      return new FormatedValue((object) stringBuilder.ToString());
label_12:
      return new FormatedValue((object) MvcHtmlString.Create(stringBuilder.ToString()));
    }

    private static FormatedValue GenerateFullRow(
      object context,
      object formatedValue,
      object caption)
    {
      int num = 14;
      StringBuilder stringBuilder;
      while (true)
      {
        TemplateRenderMode templateRenderMode;
        switch (num)
        {
          case 1:
            stringBuilder.Append((string) NotificationFunctions.nmrQgaHS7d4iyPgqr9e(~210725948 ^ -210761873));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          case 2:
            NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012116723));
            num = 11;
            continue;
          case 3:
            if (string.IsNullOrEmpty((string) caption))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 0;
              continue;
            }
            break;
          case 4:
            NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, NotificationFunctions.nmrQgaHS7d4iyPgqr9e(-218496594 ^ -218458836));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 3;
            continue;
          case 5:
            NotificationFunctions.A0UT6sH3BhVImcpAaia((object) stringBuilder, NotificationFunctions.nmrQgaHS7d4iyPgqr9e(-1204263869 ^ -1341583247 ^ 137486424));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 4;
            continue;
          case 6:
            goto label_18;
          case 7:
            NotificationFunctions.A0UT6sH3BhVImcpAaia((object) stringBuilder, caption);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 11 : 15;
            continue;
          case 8:
            NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, NotificationFunctions.nmrQgaHS7d4iyPgqr9e(132912447 ^ 132940117));
            num = 6;
            continue;
          case 9:
            if (!NotificationFunctions.x2IOjnHV5xUe7ttNQhs(caption))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 2;
              continue;
            }
            goto case 4;
          case 10:
            goto label_17;
          case 11:
            NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, NotificationFunctions.GuHgdSHDkWMvWSaDm90(NotificationFunctions.d2kr0YHPihgXAPZprJg((object) ((FunctionEvaluationContext) context).GenerationContext), (object) new FormatedValue(caption)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 5 : 2;
            continue;
          case 12:
            if (templateRenderMode == TemplateRenderMode.HTML)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 9 : 8;
              continue;
            }
            if (!NotificationFunctions.x2IOjnHV5xUe7ttNQhs(caption))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 5 : 7;
              continue;
            }
            goto case 15;
          case 13:
            templateRenderMode = NotificationFunctions.YOC3ENHuIEcWULVreyp(NotificationFunctions.Vpt0dGHZO0T75E7EkVs(context));
            num = 12;
            continue;
          case 14:
            stringBuilder = new StringBuilder();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 13 : 2;
            continue;
          case 15:
            stringBuilder.Append((string) formatedValue);
            num = 10;
            continue;
          case 16:
            NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, formatedValue);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 7 : 8;
            continue;
        }
        NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, NotificationFunctions.nmrQgaHS7d4iyPgqr9e(~538519529 ^ -538535978));
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 5 : 16;
      }
label_17:
      return new FormatedValue((object) stringBuilder.ToString());
label_18:
      return new FormatedValue(NotificationFunctions.LROWAlHR7M37tmoOqEs((object) stringBuilder.ToString()));
    }

    private static FormatedValue GenerateEmptyRow(object context)
    {
      int num = 1;
      TemplateRenderMode renderMode;
      while (true)
      {
        switch (num)
        {
          case 1:
            renderMode = ((GenerationContext) NotificationFunctions.Vpt0dGHZO0T75E7EkVs(context)).GetRenderMode();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            if (renderMode == TemplateRenderMode.HTML)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 2;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return new FormatedValue((object) string.Empty);
label_3:
      return new FormatedValue(NotificationFunctions.nmrQgaHS7d4iyPgqr9e(1514961705 ^ 1514991563));
    }

    /// <summary>
    /// Генерирует 2 строки из слитых 2-х столбцов - имя свойства и значение свойства.
    /// Параметр 1 - Значение.
    /// Параметр 2 - Заголовок (необязательный).
    /// Параметр 3 - Видимость (необязательный).
    /// </summary>
    /// <param name="context">Контекст вычисления значения функции</param>
    /// <returns></returns>
    public static FormatedValue PropertyLiteRow(FunctionEvaluationContext context)
    {
      int num = 1;
      bool visibility;
      string formatedValue;
      string caption;
      while (true)
      {
        switch (num)
        {
          case 1:
            NotificationFunctions.ExtractPropertyRowValues(NotificationFunctions.RowIndices, (object) context, out formatedValue, out caption, out visibility);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (!visibility)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 2;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return NotificationFunctions.GenerateEmptyRow((object) context);
label_6:
      return (FormatedValue) NotificationFunctions.OOmjnpHtVfvs2A3bUeZ((object) context, (object) formatedValue, (object) caption);
    }

    private static FormatedValue GenerateLiteRow(
      object context,
      object formatedValue,
      object caption)
    {
      int num1 = 5;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        TemplateRenderMode renderMode;
        while (true)
        {
          switch (num2)
          {
            case 1:
              NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, NotificationFunctions.nmrQgaHS7d4iyPgqr9e(1917998801 >> 2 ^ 479463132));
              num2 = 14;
              continue;
            case 2:
              NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, NotificationFunctions.GuHgdSHDkWMvWSaDm90(NotificationFunctions.d2kr0YHPihgXAPZprJg(NotificationFunctions.Vpt0dGHZO0T75E7EkVs(context)), (object) new FormatedValue(caption)));
              num2 = 10;
              continue;
            case 3:
              stringBuilder.Append((string) NotificationFunctions.nmrQgaHS7d4iyPgqr9e(-420743386 ^ -420781722));
              num2 = 11;
              continue;
            case 4:
              renderMode = ((GenerationContext) NotificationFunctions.Vpt0dGHZO0T75E7EkVs(context)).GetRenderMode();
              num2 = 8;
              continue;
            case 5:
              stringBuilder = new StringBuilder();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 4;
              continue;
            case 6:
              goto label_8;
            case 7:
              goto label_15;
            case 8:
              if (renderMode == TemplateRenderMode.HTML)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
                continue;
              }
              if (NotificationFunctions.x2IOjnHV5xUe7ttNQhs(caption))
                goto case 15;
              else
                goto label_17;
            case 9:
              NotificationFunctions.A0UT6sH3BhVImcpAaia((object) stringBuilder, caption);
              num2 = 15;
              continue;
            case 10:
              NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, NotificationFunctions.nmrQgaHS7d4iyPgqr9e(-2138958856 ^ -2138931122));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 12 : 2;
              continue;
            case 11:
              NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, formatedValue);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 16 : 9;
              continue;
            case 12:
              NotificationFunctions.A0UT6sH3BhVImcpAaia((object) stringBuilder, NotificationFunctions.nmrQgaHS7d4iyPgqr9e(-1426456882 ^ 2009939514 ^ -583772424));
              num2 = 3;
              continue;
            case 13:
              NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, NotificationFunctions.nmrQgaHS7d4iyPgqr9e(1021410165 ^ 1021438113));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 7 : 0;
              continue;
            case 14:
              if (!NotificationFunctions.x2IOjnHV5xUe7ttNQhs(caption))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                continue;
              }
              goto case 12;
            case 15:
              NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, formatedValue);
              num2 = 6;
              continue;
            case 16:
              NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411233253));
              num2 = 13;
              continue;
            default:
              NotificationFunctions.KDe8yoHNPkRGsApKnrZ((object) stringBuilder, NotificationFunctions.nmrQgaHS7d4iyPgqr9e(864270449 << 6 ^ -521238184));
              num2 = 2;
              continue;
          }
        }
label_17:
        num1 = 9;
      }
label_8:
      return new FormatedValue((object) stringBuilder.ToString());
label_15:
      return new FormatedValue((object) MvcHtmlString.Create(stringBuilder.ToString()));
    }

    static NotificationFunctions()
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        NotificationFunctions.PropertyRowParamIndices propertyRowParamIndices;
        while (true)
        {
          switch (num2)
          {
            case 1:
              propertyRowParamIndices.OldValue = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
              continue;
            case 2:
              NotificationFunctions.RowIndices = propertyRowParamIndices;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 9 : 4;
              continue;
            case 3:
              propertyRowParamIndices = new NotificationFunctions.PropertyRowParamIndices();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 1;
              continue;
            case 4:
              NotificationFunctions.olc2geHwVWhe9g2KnRQ();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 3 : 3;
              continue;
            case 5:
              propertyRowParamIndices.OldValue = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 8 : 0;
              continue;
            case 6:
              goto label_12;
            case 7:
              propertyRowParamIndices.Caption = 1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 9 : 11;
              continue;
            case 8:
              propertyRowParamIndices.NewValue = 1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 6 : 13;
              continue;
            case 9:
              propertyRowParamIndices = new NotificationFunctions.PropertyRowParamIndices();
              num2 = 5;
              continue;
            case 10:
              NotificationFunctions.RowChangesIndices = propertyRowParamIndices;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 12 : 8;
              continue;
            case 11:
              propertyRowParamIndices.Visibility = 2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 1;
              continue;
            case 12:
              goto label_3;
            case 13:
              propertyRowParamIndices.Caption = 2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 6;
              continue;
            default:
              propertyRowParamIndices.NewValue = 0;
              num2 = 7;
              continue;
          }
        }
label_12:
        propertyRowParamIndices.Visibility = 3;
        num1 = 10;
      }
label_3:;
    }

    internal static object Vpt0dGHZO0T75E7EkVs([In] object obj0) => (object) ((FunctionEvaluationContext) obj0).GenerationContext;

    internal static TemplateRenderMode YOC3ENHuIEcWULVreyp([In] object obj0) => ((GenerationContext) obj0).GetRenderMode();

    internal static object INCTrIHIxFLySih6GaB([In] object obj0) => ((FormatedValue) obj0).Value;

    internal static bool x2IOjnHV5xUe7ttNQhs([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object nmrQgaHS7d4iyPgqr9e(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object c8ROQcHiDGXgunXqRhZ([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object LROWAlHR7M37tmoOqEs([In] object obj0) => (object) MvcHtmlString.Create((string) obj0);

    internal static bool XTsqBmHvmqURCBXXMRV() => NotificationFunctions.hiRDaTHCJT43IoTHCbc == null;

    internal static NotificationFunctions Nb2WquH8BsrYaZTkXWj() => NotificationFunctions.hiRDaTHCJT43IoTHCbc;

    internal static object vq4opWHqq1Wlou3OwR2([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static int XWXL7gHKFBhlpVyu1b6([In] object obj0) => ((List<FormatedValue>) obj0).Count;

    internal static object nWfBImHXN5pWUg2sfcv([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object rEYDjQHTkQYWJ4J8JeI([In] object obj0) => (object) NotificationFunctions.GenerateEmptyRow(obj0);

    internal static object xgqfw7HkwKZCLnWlQMY([In] object obj0, [In] object obj1, [In] object obj2) => (object) NotificationFunctions.GenerateRow(obj0, obj1, obj2);

    internal static object VRHx62Hn0NtotfIJTkQ([In] object obj0, [In] object obj1, [In] object obj2) => (object) NotificationFunctions.GenerateFullRow(obj0, obj1, obj2);

    internal static object qOFKoZHOcMA4dkLIBS5([In] object obj0, [In] object obj1, [In] object obj2) => (object) NotificationFunctions.FormatValueChanges(obj0, obj1, obj2);

    internal static bool YhAmYRH2bMipLv0kNpn([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object IfXrL1HeF3CRYd0uGTI([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object d2kr0YHPihgXAPZprJg([In] object obj0) => (object) ((GenerationContext) obj0).FormatProvider;

    internal static object Gk5L8wH1F98ykrwfNLO([In] object obj0) => (object) ((MetadataBasedFormat) obj0).PropertyMetadata;

    internal static object KDe8yoHNPkRGsApKnrZ([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static object A0UT6sH3BhVImcpAaia([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).AppendLine((string) obj1);

    internal static int mPTDmBHpg5eMPyfvoG2([In] object obj0) => ((string) obj0).Length;

    internal static int J4Md9qHaGF2jXKsMBcE([In] object obj0) => ((GenerationContext) obj0).GetTextCaptionMaxLength();

    internal static object GuHgdSHDkWMvWSaDm90([In] object obj0, [In] object obj1) => (object) ((IGeneratorFormatProvider) obj0).FormatValue((FormatedValue) obj1);

    internal static object OOmjnpHtVfvs2A3bUeZ([In] object obj0, [In] object obj1, [In] object obj2) => (object) NotificationFunctions.GenerateLiteRow(obj0, obj1, obj2);

    internal static void olc2geHwVWhe9g2KnRQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private struct PropertyRowParamIndices
    {
      internal static object PAj265fr9XVEBo0nQZVu;

      public int OldValue
      {
        get => this.\u003COldValue\u003Ek__BackingField;
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
                this.\u003COldValue\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
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

      public int NewValue
      {
        get => this.\u003CNewValue\u003Ek__BackingField;
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
                this.\u003CNewValue\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
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

      public int Caption
      {
        get => this.\u003CCaption\u003Ek__BackingField;
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
                this.\u003CCaption\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
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

      public int Visibility
      {
        get => this.\u003CVisibility\u003Ek__BackingField;
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
                this.\u003CVisibility\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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

      internal static bool agsHkHfrd1mQU1d1TMZZ() => NotificationFunctions.PropertyRowParamIndices.PAj265fr9XVEBo0nQZVu == null;

      internal static object uKZtWufrlXI5hFg2vRko() => NotificationFunctions.PropertyRowParamIndices.PAj265fr9XVEBo0nQZVu;
    }
  }
}
