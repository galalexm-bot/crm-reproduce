// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.TemplateGenerator.NotificationTemplateGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Templates;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Notifications.Impl.TemplateGenerator
{
  /// <summary>Генератор текста сообщений по шаблонам оповещений</summary>
  public class NotificationTemplateGenerator : TextTemplateGenerator
  {
    private NotificationTemplateBase notificationTemplate;
    internal static NotificationTemplateGenerator zxXft2Hmwyqx4GvCr2V;

    /// <summary>Ctor</summary>
    /// <param name="template">Шаблон</param>
    /// <param name="notificationTemplate">Шаблон оповещения</param>
    /// <param name="renderMode">Режим генерации</param>
    public NotificationTemplateGenerator(
      string template,
      NotificationTemplateBase notificationTemplate = null,
      TemplateRenderMode renderMode = TemplateRenderMode.Default)
    {
      NotificationTemplateGenerator.t15LbPHJA096UZ04vhO();
      // ISSUE: explicit constructor call
      base.\u002Ector(template, (IGeneratorProvider) new NotificationGeneratorProvider(notificationTemplate), renderMode);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.notificationTemplate = notificationTemplate;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Постобработка результата</summary>
    /// <param name="context">Контекст генерации</param>
    /// <param name="result">Результат</param>
    /// <returns>Обработанный результат</returns>
    protected override StringBuilder PostProcessResult(
      GenerationContext context,
      StringBuilder result)
    {
      int num1 = 3;
      StringBuilder stringBuilder;
      while (true)
      {
        int num2 = num1;
        int length;
        string str1;
        string str2;
        while (true)
        {
          string str3;
          int startIndex;
          string[] strArray;
          int index;
          int num3;
          int num4;
          switch (num2)
          {
            case 1:
            case 11:
            case 13:
            case 26:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 19 : 2;
              continue;
            case 2:
            case 36:
              goto label_3;
            case 3:
              if (result == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 1;
                continue;
              }
              goto case 30;
            case 4:
              NotificationTemplateGenerator.sKS8KaHLHnr7TCwvcZt((object) stringBuilder, ' ');
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 23;
              continue;
            case 5:
              NotificationTemplateGenerator.vqOXmiH5LV7fN5pK9Wq((object) stringBuilder, (object) str1.Substring(startIndex));
              num2 = 13;
              continue;
            case 6:
            case 34:
              NotificationTemplateGenerator.ci8O9LHshEqGyqmCJik((object) stringBuilder);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
              continue;
            case 7:
            case 18:
              if (num3 < num4 - NotificationTemplateGenerator.OGv6KKHYRqPQgVjJHuv((object) str2) + 2)
                goto case 4;
              else
                goto label_19;
            case 8:
            case 25:
              goto label_7;
            case 9:
              if (NotificationTemplateGenerator.OGv6KKHYRqPQgVjJHuv((object) str2) > num4)
              {
                num2 = 28;
                continue;
              }
              goto case 29;
            case 10:
            case 15:
              num4 = NotificationTemplateGenerator.qfEA48Hl7TPFZlmCthh((object) context);
              num2 = 32;
              continue;
            case 12:
              NotificationTemplateGenerator.r65GGGHjYgwTZYfyC5J((object) stringBuilder, (object) str2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 9 : 9;
              continue;
            case 14:
              if (length >= 0)
              {
                num2 = 25;
                continue;
              }
              break;
            case 16:
              if (!NotificationTemplateGenerator.caYPrMHdhfG5gx057Nm((object) str3, NotificationTemplateGenerator.me0VhHH9CnCV21GBlTE(-218496594 ^ -218459572)))
                goto case 24;
              else
                goto label_13;
            case 17:
              length = NotificationTemplateGenerator.kJ3am1HgVIXPIf3dfBI((object) str1, NotificationTemplateGenerator.me0VhHH9CnCV21GBlTE(44884861 ^ 44855455));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 13 : 14;
              continue;
            case 19:
            case 31:
              if (index < strArray.Length)
                goto case 22;
              else
                goto label_30;
            case 20:
              goto label_31;
            case 21:
              if (NotificationTemplateGenerator.caYPrMHdhfG5gx057Nm((object) str1, NotificationTemplateGenerator.me0VhHH9CnCV21GBlTE(-35995181 ^ -36022991)))
              {
                num2 = 26;
                continue;
              }
              goto case 17;
            case 22:
              str1 = strArray[index];
              num2 = 21;
              continue;
            case 23:
              ++num3;
              num2 = 18;
              continue;
            case 24:
              if (NotificationTemplateGenerator.caYPrMHdhfG5gx057Nm((object) str3, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088331974)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 15 : 10;
                continue;
              }
              goto label_38;
            case 27:
            case 28:
              startIndex = length + NotificationTemplateGenerator.B4YRFjHUW7DcVqFNZKX(NotificationTemplateGenerator.me0VhHH9CnCV21GBlTE(-542721635 ^ -542758273));
              num2 = 37;
              continue;
            case 29:
              num3 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 6 : 7;
              continue;
            case 30:
              if (this.RenderMode != TemplateRenderMode.HTML)
              {
                str3 = result.ToString();
                num2 = 16;
                continue;
              }
              num2 = 36;
              continue;
            case 32:
              object obj = NotificationTemplateGenerator.WYWNYeHr7uu4o80h0oY((object) str3, (object) new string[1]
              {
                (string) NotificationTemplateGenerator.me0VhHH9CnCV21GBlTE(1051802738 - -1831968059 ^ -1411204461)
              }, StringSplitOptions.None);
              stringBuilder = new StringBuilder();
              strArray = (string[]) obj;
              num2 = 33;
              continue;
            case 33:
              index = 0;
              num2 = 31;
              continue;
            case 35:
              goto label_38;
            case 37:
              if (startIndex >= str1.Length - 1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 34 : 5;
                continue;
              }
              goto case 5;
          }
          NotificationTemplateGenerator.vqOXmiH5LV7fN5pK9Wq((object) stringBuilder, (object) str1);
          num2 = 11;
        }
label_7:
        str2 = str1.Substring(0, length);
        num1 = 12;
        continue;
label_13:
        num1 = 10;
        continue;
label_19:
        num1 = 27;
        continue;
label_30:
        num1 = 20;
      }
label_3:
      return result;
label_31:
      return stringBuilder;
label_38:
      return result;
    }

    internal static void t15LbPHJA096UZ04vhO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Q8Nf22HyoT3Be0PgZfU() => NotificationTemplateGenerator.zxXft2Hmwyqx4GvCr2V == null;

    internal static NotificationTemplateGenerator GqyHPAHMMcAt3ITJh0G() => NotificationTemplateGenerator.zxXft2Hmwyqx4GvCr2V;

    internal static object me0VhHH9CnCV21GBlTE(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool caYPrMHdhfG5gx057Nm([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static int qfEA48Hl7TPFZlmCthh([In] object obj0) => ((GenerationContext) obj0).GetTextCaptionMaxLength();

    internal static object WYWNYeHr7uu4o80h0oY([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static int kJ3am1HgVIXPIf3dfBI([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

    internal static object vqOXmiH5LV7fN5pK9Wq([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).AppendLine((string) obj1);

    internal static object r65GGGHjYgwTZYfyC5J([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static int OGv6KKHYRqPQgVjJHuv([In] object obj0) => ((string) obj0).Length;

    internal static object sKS8KaHLHnr7TCwvcZt([In] object obj0, [In] char obj1) => (object) ((StringBuilder) obj0).Append(obj1);

    internal static int B4YRFjHUW7DcVqFNZKX([In] object obj0) => ((string) obj0).Length;

    internal static object ci8O9LHshEqGyqmCJik([In] object obj0) => (object) ((StringBuilder) obj0).AppendLine();
  }
}
