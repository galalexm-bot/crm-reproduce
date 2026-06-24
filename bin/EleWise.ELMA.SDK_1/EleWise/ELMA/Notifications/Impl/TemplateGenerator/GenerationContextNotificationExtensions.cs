// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.TemplateGenerator.GenerationContextNotificationExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.TemplateGenerator;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl.TemplateGenerator
{
  /// <summary>Методы-расширения для контекст генерации оповещений</summary>
  public static class GenerationContextNotificationExtensions
  {
    private static GenerationContextNotificationExtensions RA07Sd6xaLQL9uuNeP1;

    /// <summary>Получить длину самого длинного заголовка в таблице</summary>
    /// <param name="context">Контекст генерации</param>
    public static int GetTextCaptionMaxLength(this GenerationContext context)
    {
      int num = 1;
      object captionMaxLength;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!context.ExtendedProperties.TryGetValue((string) GenerationContextNotificationExtensions.QG0pee6y5XmhXQI8Gt5(-1876063057 ^ -1876091425), out captionMaxLength))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return 0;
label_5:
      return (int) captionMaxLength;
    }

    /// <summary>Установить длину самого длинного заголовка в таблице</summary>
    /// <param name="context">Контекст генерации</param>
    /// <param name="length">Длина</param>
    public static void SetTextCaptionMaxLength(this GenerationContext context, int length)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            context.ExtendedProperties[(string) GenerationContextNotificationExtensions.QG0pee6y5XmhXQI8Gt5(-710283084 ^ -537863435 ^ 173652785)] = (object) length;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static object QG0pee6y5XmhXQI8Gt5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool hTG6P660aNEPt7U4Qle() => GenerationContextNotificationExtensions.RA07Sd6xaLQL9uuNeP1 == null;

    internal static GenerationContextNotificationExtensions Ff2o3k6mAoubIL9pZ3s() => GenerationContextNotificationExtensions.RA07Sd6xaLQL9uuNeP1;
  }
}
