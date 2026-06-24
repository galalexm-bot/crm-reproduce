// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.TemplateGenerator.ElmaGeneratorFormatProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Formats;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace EleWise.ELMA.Templates.TemplateGenerator
{
  /// <summary>
  /// Провайдер форматирования значений по умолчанию с поддержкой специфики ELMA SDK
  /// </summary>
  public class ElmaGeneratorFormatProvider : GeneratorFormatProvider
  {
    private IEnumerable<ITemplateGeneratorFormatter> formatProviders;
    internal static ElmaGeneratorFormatProvider FQ8Ve9B3x6WG9d0jGIQX;

    /// <summary>Ctor</summary>
    /// <param name="context">Контекст процесса генерации</param>
    public ElmaGeneratorFormatProvider(GenerationContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(context);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_4;
          case 1:
            if (!ElmaGeneratorFormatProvider.dVEXH7B3yK03k6tJphqK())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_3;
          case 3:
            this.formatProviders = ((ComponentManager) ElmaGeneratorFormatProvider.EikosQB3MMbW85cj3Vim()).GetExtensionPoints<ITemplateGeneratorFormatter>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_4:
      return;
label_3:
      return;
label_8:;
    }

    /// <summary>Форматировать значение в строку</summary>
    /// <param name="value">Значение</param>
    /// <returns>Форматированное значение</returns>
    public override string FormatValue(FormatedValue value)
    {
      int num1 = 23;
      string str1;
      IEnumerator enumerator1;
      StringBuilder stringBuilder;
      string str2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          TemplateRenderMode renderMode;
          IEnumerator<ITemplateGeneratorFormatter> enumerator2;
          MetadataBasedFormat metadataBasedFormat1;
          IFormatTypeDescriptor formatTypeDescriptor;
          bool flag;
          int num3;
          MetadataBasedFormat metadataBasedFormat2;
          string str3;
          switch (num2)
          {
            case 1:
              if (!ElmaGeneratorFormatProvider.ygMHUUBpbP8gNTd51AZW((object) str1))
              {
                num2 = 13;
                continue;
              }
              goto label_11;
            case 2:
              goto label_70;
            case 3:
              if (str1.Contains<char>('\r'))
              {
                num3 = 1;
                goto label_109;
              }
              else
              {
                num2 = 45;
                continue;
              }
            case 4:
              if (ElmaGeneratorFormatProvider.oPk1X4B3d1CH3xNRwR6c((object) value).GetType().IsEnum)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 3 : 55;
                continue;
              }
              goto case 21;
            case 5:
              goto label_11;
            case 6:
            case 25:
            case 43:
              if (str1 == null)
                goto case 27;
              else
                goto label_76;
            case 7:
              if (ElmaGeneratorFormatProvider.oPk1X4B3d1CH3xNRwR6c((object) value) is string)
                goto case 19;
              else
                goto label_82;
            case 8:
              goto label_61;
            case 9:
label_10:
              str1 = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 12 : 34;
              continue;
            case 10:
              str1 = base.FormatValue(value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 1;
              continue;
            case 11:
              if (metadataBasedFormat1 != null)
              {
                num2 = 40;
                continue;
              }
              goto case 6;
            case 12:
              goto label_23;
            case 13:
              if (renderMode == TemplateRenderMode.HTML)
              {
                num2 = 48;
                continue;
              }
              goto label_54;
            case 14:
              if (ElmaGeneratorFormatProvider.oPk1X4B3d1CH3xNRwR6c((object) value) is HtmlString)
              {
                num2 = 2;
                continue;
              }
              break;
            case 15:
              if (value == null)
              {
                num2 = 33;
                continue;
              }
              goto case 7;
            case 16:
              num3 = 0;
              goto label_109;
            case 17:
              if (formatTypeDescriptor == null)
              {
                num2 = 43;
                continue;
              }
              goto case 29;
            case 18:
              if (!(ElmaGeneratorFormatProvider.oPk1X4B3d1CH3xNRwR6c((object) value) is IEnumerable))
              {
                num2 = 26;
                continue;
              }
              goto case 53;
            case 19:
              str1 = ElmaGeneratorFormatProvider.FormatTextToLink(str1);
              num2 = 50;
              continue;
            case 20:
              if (value != null)
              {
                num2 = 14;
                continue;
              }
              break;
            case 21:
            case 44:
            case 52:
              if (str1 != null)
              {
                num2 = 38;
                continue;
              }
              goto case 47;
            case 22:
              ElmaGeneratorFormatProvider.IwYpOkB39gEMptQjHYBc((object) this, (object) value);
              num2 = 31;
              continue;
            case 23:
              renderMode = ElmaGeneratorFormatProvider.lLy54VB3JvJQqZIq7Wtu((object) this.Context);
              num2 = 22;
              continue;
            case 24:
              metadataBasedFormat2 = (MetadataBasedFormat) null;
              goto label_106;
            case 26:
            case 28:
            case 38:
              if (str1 != null)
                goto case 1;
              else
                goto label_63;
            case 27:
              if (value == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 44 : 35;
                continue;
              }
              goto case 39;
            case 29:
              str1 = (string) ElmaGeneratorFormatProvider.ePsQTWB3UBUA1OLRFOyn((object) formatTypeDescriptor, value == null ? (object) null : ElmaGeneratorFormatProvider.oPk1X4B3d1CH3xNRwR6c((object) value), ElmaGeneratorFormatProvider.jCFp63B3gs6DV0ENBoLV((object) metadataBasedFormat1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 25 : 17;
              continue;
            case 30:
              stringBuilder = new StringBuilder();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 7 : 42;
              continue;
            case 31:
              if (renderMode == TemplateRenderMode.HTML)
              {
                num2 = 20;
                continue;
              }
              break;
            case 32:
              if (str1 == null)
                goto case 54;
              else
                goto label_69;
            case 33:
            case 36:
            case 50:
              goto label_53;
            case 34:
              if (value != null)
              {
                metadataBasedFormat2 = value.Format as MetadataBasedFormat;
                goto label_106;
              }
              else
                goto label_15;
            case 35:
              if (!ElmaGeneratorFormatProvider.MqxTo8B3527DXkxfpYQ0(((PropertyMetadata) ElmaGeneratorFormatProvider.jCFp63B3gs6DV0ENBoLV((object) metadataBasedFormat1)).TypeUid, Guid.Empty))
              {
                num2 = 6;
                continue;
              }
              goto case 49;
            case 37:
              enumerator2 = this.formatProviders.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            case 39:
              if (value.Value != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 4 : 4;
                continue;
              }
              goto case 21;
            case 40:
              if (metadataBasedFormat1.PropertyMetadata != null)
              {
                num2 = 35;
                continue;
              }
              goto case 6;
            case 41:
              if (flag)
              {
                num2 = 51;
                continue;
              }
              goto case 46;
            case 42:
              enumerator1 = (IEnumerator) ElmaGeneratorFormatProvider.sqTeECB3zPd8qu0S4KRV((object) (IEnumerable) value.Value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 12 : 10;
              continue;
            case 45:
              num3 = str1.Contains<char>('\n') ? 1 : 0;
              goto label_109;
            case 46:
              str3 = HttpUtility.HtmlEncode(str1);
              goto label_111;
            case 47:
              if (value != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 18 : 2;
                continue;
              }
              goto case 26;
            case 48:
              if (str1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 14 : 16;
                continue;
              }
              goto case 3;
            case 49:
              formatTypeDescriptor = ElmaGeneratorFormatProvider.TZdvgCB3LF6o05lxG074(ElmaGeneratorFormatProvider.UA2oPZB3jDQcuH6CwL22(), ElmaGeneratorFormatProvider.iA39ICB3YPMmNjy7KbA0(ElmaGeneratorFormatProvider.jCFp63B3gs6DV0ENBoLV((object) metadataBasedFormat1)), ((PropertyMetadata) ElmaGeneratorFormatProvider.jCFp63B3gs6DV0ENBoLV((object) metadataBasedFormat1)).SubTypeUid) as IFormatTypeDescriptor;
              num2 = 17;
              continue;
            case 51:
              str3 = this.WrapByPre(HttpUtility.HtmlEncode(str1));
              goto label_111;
            case 53:
              if (!ElmaGeneratorFormatProvider.jGbKRfB3ccAB20NDUNbV(ElmaGeneratorFormatProvider.oPk1X4B3d1CH3xNRwR6c((object) value).GetType(), typeof (string)))
              {
                num2 = 28;
                continue;
              }
              goto case 30;
            case 54:
              str3 = string.Empty;
              goto label_111;
            case 55:
              str1 = (string) ElmaGeneratorFormatProvider.BxGE0CB3sD9APXjPRCny(ElmaGeneratorFormatProvider.oPk1X4B3d1CH3xNRwR6c((object) value));
              num2 = 21;
              continue;
            default:
              try
              {
label_97:
                if (ElmaGeneratorFormatProvider.f1BN7tB3rtS9CbIxYmyi((object) enumerator2))
                  goto label_93;
                else
                  goto label_98;
label_91:
                string s;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_97;
                    case 2:
                      str2 = this.AdaptNewLines(s);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 3 : 3;
                      continue;
                    case 3:
                      goto label_55;
                    case 4:
                      goto label_10;
                    case 5:
                      goto label_93;
                    default:
                      if (s != null)
                      {
                        num4 = 2;
                        continue;
                      }
                      goto label_97;
                  }
                }
label_93:
                s = (string) ElmaGeneratorFormatProvider.as99aSB3lJOkothebKFa((object) enumerator2.Current, (object) this.Context, (object) value, renderMode);
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
                {
                  num4 = 0;
                  goto label_91;
                }
                else
                  goto label_91;
label_98:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 4 : 0;
                goto label_91;
              }
              finally
              {
                int num5;
                if (enumerator2 == null)
                  num5 = 2;
                else
                  goto label_102;
label_101:
                switch (num5)
                {
                  case 1:
                  case 2:
                }
label_102:
                enumerator2.Dispose();
                num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
                {
                  num5 = 0;
                  goto label_101;
                }
                else
                  goto label_101;
              }
          }
          if (this.formatProviders != null)
          {
            num2 = 37;
            continue;
          }
          goto label_10;
label_106:
          metadataBasedFormat1 = metadataBasedFormat2;
          num2 = 11;
          continue;
label_109:
          flag = num3 != 0;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 14 : 32;
          continue;
label_111:
          str1 = str3;
          num2 = 15;
        }
label_15:
        num1 = 24;
        continue;
label_63:
        num1 = 10;
        continue;
label_69:
        num1 = 41;
        continue;
label_76:
        num1 = 52;
        continue;
label_82:
        num1 = 36;
      }
label_11:
      return (string) ElmaGeneratorFormatProvider.goLhx1Bpo9mc5D2yDraQ((object) this, (object) str1);
label_23:
      try
      {
label_25:
        if (enumerator1.MoveNext())
          goto label_27;
        else
          goto label_26;
label_24:
        object obj;
        int num6;
        while (true)
        {
          switch (num6)
          {
            case 1:
              goto label_25;
            case 2:
              goto label_61;
            case 3:
              stringBuilder.Append((string) ElmaGeneratorFormatProvider.bxM1UNBpB1CC4BuBs24V((object) this, (object) new FormatedValue(obj)));
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
              continue;
            default:
              goto label_27;
          }
        }
label_26:
        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 2;
        goto label_24;
label_27:
        obj = ElmaGeneratorFormatProvider.m9OGOEBpF4p0wOf7qvyw((object) enumerator1);
        num6 = 3;
        goto label_24;
      }
      finally
      {
        IDisposable disposable = enumerator1 as IDisposable;
        int num7 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
          num7 = 0;
        while (true)
        {
          switch (num7)
          {
            case 1:
            case 2:
              goto label_35;
            case 3:
              ElmaGeneratorFormatProvider.V4L6J6BpWDWQ44kjP4S5((object) disposable);
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
              continue;
            default:
              if (disposable == null)
              {
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 2;
                continue;
              }
              goto case 3;
          }
        }
label_35:;
      }
label_53:
      return (string) ElmaGeneratorFormatProvider.goLhx1Bpo9mc5D2yDraQ((object) this, (object) str1);
label_54:
      return (string) ElmaGeneratorFormatProvider.goLhx1Bpo9mc5D2yDraQ((object) this, (object) str1);
label_55:
      return str2;
label_61:
      return (string) ElmaGeneratorFormatProvider.goLhx1Bpo9mc5D2yDraQ((object) this, (object) stringBuilder.ToString());
label_70:
      return ElmaGeneratorFormatProvider.oPk1X4B3d1CH3xNRwR6c((object) value).ToString();
    }

    /// <summary>Форматирует текст для html, выделяя ссылки</summary>
    /// <param name="text"></param>
    /// <param name="wrap"></param>
    /// <returns></returns>
    public static string FormatTextToLink(string text, bool wrap = true) => (string) ElmaGeneratorFormatProvider.aj1XNHBph3yO48dXEIug((object) text, wrap, false);

    /// <summary>Форматирует текст для html, выделяя ссылки</summary>
    /// <param name="text"></param>
    /// <param name="wrap"></param>
    /// <returns></returns>
    public static string FormatTextToLink(string text, bool wrap, bool contextVarEnabled)
    {
      int num = 4;
      while (true)
      {
        string str;
        object obj;
        switch (num)
        {
          case 1:
            obj = (object) string.Format((string) ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(-2106517564 ^ -2106567324), ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(1052221104 - 768835541 ^ 283466857), ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(-542721635 ^ -542639239));
            break;
          case 2:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            text = (string) ElmaGeneratorFormatProvider.no9dwnBpC0R4Jvtd49VL((object) text, ElmaGeneratorFormatProvider.yZlFDeBpQ6sE3IEQ8Ei0(ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(2045296739 + 1688595713 ^ -560992728), (object) str), (object) (MatchEvaluator) (match => (string) ElmaGeneratorFormatProvider.\u003C\u003Ec.VdbC0eQKKEUb9g7cUd6w(ElmaGeneratorFormatProvider.\u003C\u003Ec.dbenkWQKR11kTtwd5vNR(694673736 ^ -23604109 ^ -671792937), ElmaGeneratorFormatProvider.\u003C\u003Ec.HOyKW1QKqpfj9dn8hsnl((object) match))), RegexOptions.IgnoreCase);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 5;
            continue;
          case 3:
            goto label_4;
          case 4:
            if (!ElmaGeneratorFormatProvider.rgrAfcBpGC0eLvfnimJr((object) text))
            {
              if (contextVarEnabled)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 3 : 1;
              continue;
            }
          case 5:
            goto label_3;
          default:
            obj = ElmaGeneratorFormatProvider.wThxBKBpf6mI0hEj4GkU((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672041409), ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(1917998801 >> 2 ^ 479581958), ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(1033719030 - 2012070891 ^ -978400273), ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(1461825605 - 1531863589 ^ -70120178));
            break;
        }
        str = (string) obj;
        num = 2;
      }
label_3:
      return text;
label_4:
      return text;
    }

    public static string FormatTextTagBracket(string text) => (string) ElmaGeneratorFormatProvider.h2daPiBpv88mcrQX3tIZ(ElmaGeneratorFormatProvider.h2daPiBpv88mcrQX3tIZ((object) text, ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(--1360331293 ^ 1360350683), ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(277947046 - -1479185048 ^ 1757083202)), ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(964881585 - -1459193222 ^ -1870905865), ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(-2138160520 ^ -2138111504));

    /// <summary>Получить изображение</summary>
    /// <param name="value">Значение</param>
    /// <returns>Изображение</returns>
    public override Image GetImage(FormatedValue value)
    {
      int num1 = 2;
      Stream content;
      while (true)
      {
        BinaryFile binaryFile;
        string ext;
        string str;
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            if (value != null)
            {
              binaryFile = ElmaGeneratorFormatProvider.oPk1X4B3d1CH3xNRwR6c((object) value) as BinaryFile;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 3 : 2;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
            continue;
          case 3:
            if (binaryFile != null)
            {
              num1 = 5;
              continue;
            }
            goto case 4;
          case 4:
            str = string.Empty;
            break;
          case 5:
            str = binaryFile.Extension;
            break;
          case 6:
            goto label_6;
          case 7:
            goto label_32;
          case 8:
            if (binaryFile != null)
            {
              num1 = 9;
              continue;
            }
            goto label_32;
          case 9:
            if (this.IsSupportedImageExtension(ext))
            {
              content = binaryFile.GetContent();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            }
            num1 = 7;
            continue;
          default:
            goto label_7;
        }
        ext = str;
        num1 = 8;
      }
label_2:
      return (Image) null;
label_6:
      Image image;
      return image;
label_7:
      try
      {
        MemoryStream memoryStream = ((MemoryStream) ElmaGeneratorFormatProvider.iVpfUyBpuaV2XYquMDny((int) ElmaGeneratorFormatProvider.YneDZvBpZjYThqd8JZUh((object) content))).AsNoClose();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              ElmaGeneratorFormatProvider.XmZSpjBpIS2aPZcLL3hK((object) content, (object) memoryStream);
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    image = (Image) ElmaGeneratorFormatProvider.npY7H8BpVsWXZPPcf3UH((object) memoryStream);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_6;
                }
              }
            }
            finally
            {
              int num4;
              if (memoryStream == null)
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
              else
                goto label_19;
label_18:
              switch (num4)
              {
                case 1:
                  break;
                default:
              }
label_19:
              ElmaGeneratorFormatProvider.V4L6J6BpWDWQ44kjP4S5((object) memoryStream);
              num4 = 2;
              goto label_18;
            }
        }
      }
      finally
      {
        if (content != null)
        {
          int num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
            num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                ElmaGeneratorFormatProvider.V4L6J6BpWDWQ44kjP4S5((object) content);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              default:
                goto label_26;
            }
          }
        }
label_26:;
      }
label_32:
      return (Image) ElmaGeneratorFormatProvider.yN9EVbBp8rsKekGa3Mav((object) this, (object) value);
    }

    protected virtual bool IsSupportedImageExtension(string ext)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ext = ext.ToLower();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            if (!ElmaGeneratorFormatProvider.jFueYYBpSn8FYxogOSSh((object) ext, ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(1819636893 << 3 ^ 1672124682)))
            {
              num = 4;
              continue;
            }
            goto label_14;
          case 3:
            if (!ElmaGeneratorFormatProvider.jFueYYBpSn8FYxogOSSh((object) ext, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883421070)))
            {
              num = 6;
              continue;
            }
            goto label_14;
          case 4:
            if (!(ext == z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870843485)))
            {
              num = 3;
              continue;
            }
            goto label_14;
          case 5:
            goto label_13;
          case 6:
            if (!(ext == (string) ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(2045296739 + 1688595713 ^ -560992572)))
            {
              num = 5;
              continue;
            }
            goto label_14;
          default:
            if (!ElmaGeneratorFormatProvider.jFueYYBpSn8FYxogOSSh((object) ext, ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(-1852837372 ^ -1852911662)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 2;
              continue;
            }
            goto label_14;
        }
      }
label_13:
      return ElmaGeneratorFormatProvider.jFueYYBpSn8FYxogOSSh((object) ext, ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(-70007027 ^ -70089567));
label_14:
      return true;
    }

    private string WrapByPre(string s) => (string) ElmaGeneratorFormatProvider.lnZxATBpiY1LO4J6V3Nl(ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(-1255365154 ^ 596875508 ^ -1765900656), (object) s.Nl2Br(), ElmaGeneratorFormatProvider.LllrseBpECcJRVWLeECk(-1998538950 ^ -1998458050));

    internal static bool dVEXH7B3yK03k6tJphqK() => ComponentManager.Initialized;

    internal static object EikosQB3MMbW85cj3Vim() => (object) ComponentManager.Current;

    internal static bool mIUUb5B30pjTDmoaXDij() => ElmaGeneratorFormatProvider.FQ8Ve9B3x6WG9d0jGIQX == null;

    internal static ElmaGeneratorFormatProvider ebgfnJB3mayiiCna6Rq8() => ElmaGeneratorFormatProvider.FQ8Ve9B3x6WG9d0jGIQX;

    internal static TemplateRenderMode lLy54VB3JvJQqZIq7Wtu([In] object obj0) => ((GenerationContext) obj0).GetRenderMode();

    internal static void IwYpOkB39gEMptQjHYBc([In] object obj0, [In] object obj1) => ((GeneratorFormatProvider) obj0).TransformDateTime((FormatedValue) obj1);

    internal static object oPk1X4B3d1CH3xNRwR6c([In] object obj0) => ((FormatedValue) obj0).Value;

    internal static object as99aSB3lJOkothebKFa(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      TemplateRenderMode renderMode)
    {
      return (object) ((ITemplateGeneratorFormatter) obj0).FormatValue((GenerationContext) obj1, (FormatedValue) obj2, renderMode);
    }

    internal static bool f1BN7tB3rtS9CbIxYmyi([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static object jCFp63B3gs6DV0ENBoLV([In] object obj0) => (object) ((MetadataBasedFormat) obj0).PropertyMetadata;

    internal static bool MqxTo8B3527DXkxfpYQ0([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object UA2oPZB3jDQcuH6CwL22() => (object) MetadataServiceContext.Service;

    internal static Guid iA39ICB3YPMmNjy7KbA0([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static object TZdvgCB3LF6o05lxG074([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static object ePsQTWB3UBUA1OLRFOyn([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IFormatTypeDescriptor) obj0).FormatValue(obj1, (PropertyMetadata) obj2);

    internal static object BxGE0CB3sD9APXjPRCny([In] object obj0) => (object) ModelHelper.GetEnumDisplayName(obj0);

    internal static bool jGbKRfB3ccAB20NDUNbV([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object sqTeECB3zPd8qu0S4KRV([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object m9OGOEBpF4p0wOf7qvyw([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static object bxM1UNBpB1CC4BuBs24V([In] object obj0, [In] object obj1) => (object) ((GeneratorFormatProvider) obj0).FormatValue((FormatedValue) obj1);

    internal static void V4L6J6BpWDWQ44kjP4S5([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object goLhx1Bpo9mc5D2yDraQ([In] object obj0, [In] object obj1) => (object) ((GeneratorFormatProvider) obj0).AdaptNewLines((string) obj1);

    internal static bool ygMHUUBpbP8gNTd51AZW([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object aj1XNHBph3yO48dXEIug([In] object obj0, bool wrap, bool contextVarEnabled) => (object) ElmaGeneratorFormatProvider.FormatTextToLink((string) obj0, wrap, contextVarEnabled);

    internal static bool rgrAfcBpGC0eLvfnimJr([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object LllrseBpECcJRVWLeECk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object wThxBKBpf6mI0hEj4GkU(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static object yZlFDeBpQ6sE3IEQ8Ei0([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object no9dwnBpC0R4Jvtd49VL(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] RegexOptions obj3)
    {
      return (object) Regex.Replace((string) obj0, (string) obj1, (MatchEvaluator) obj2, obj3);
    }

    internal static object h2daPiBpv88mcrQX3tIZ([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object yN9EVbBp8rsKekGa3Mav([In] object obj0, [In] object obj1) => (object) __nonvirtual (((GeneratorFormatProvider) obj0).GetImage((FormatedValue) obj1));

    internal static long YneDZvBpZjYThqd8JZUh([In] object obj0) => ((Stream) obj0).Length;

    internal static object iVpfUyBpuaV2XYquMDny(int requiredSize) => (object) MemoryHelper.GetMemoryStream(requiredSize);

    internal static void XmZSpjBpIS2aPZcLL3hK([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static object npY7H8BpVsWXZPPcf3UH([In] object obj0) => (object) Image.FromStream((Stream) obj0);

    internal static bool jFueYYBpSn8FYxogOSSh([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object lnZxATBpiY1LO4J6V3Nl([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);
  }
}
