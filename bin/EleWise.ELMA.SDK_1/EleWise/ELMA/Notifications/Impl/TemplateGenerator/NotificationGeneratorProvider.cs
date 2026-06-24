// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Notifications.Impl.TemplateGenerator.NotificationGeneratorProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Templates.TemplateGenerator;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.DataSources;
using EleWise.TemplateGenerator.Formats;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Notifications.Impl.TemplateGenerator
{
  /// <summary>Провайдер генерации с поддержкой специфики оповещений</summary>
  public class NotificationGeneratorProvider : ElmaGeneratorProvider
  {
    private NotificationTemplateBase notificationTemplate;
    private static NotificationGeneratorProvider kvyaWDHAAmklJm1p5tY;

    /// <summary>Ctor</summary>
    /// <param name="notificationTemplate">Шаблон оповещения</param>
    public NotificationGeneratorProvider(NotificationTemplateBase notificationTemplate = null)
    {
      NotificationGeneratorProvider.qT0deJH0eyiN56lUfJr();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.notificationTemplate = notificationTemplate;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Преобразовать объект в источник данных</summary>
    /// <param name="dataSourceObject">ОБъект источника данных</param>
    public override IGeneratorDataSource ConvertObjectToDataSource(object dataSourceObject) => (IGeneratorDataSource) new ElmaObjectGeneratorDataSource(dataSourceObject);

    /// <summary>Создать провайдер форматирования значений</summary>
    /// <param name="context">Контекст процесса генерации</param>
    public override IGeneratorFormatProvider CreateFormatProvider(GenerationContext context) => (IGeneratorFormatProvider) new NotificationFormatProvider(context);

    /// <summary>Создать вычислитель функций</summary>
    /// <param name="context">Контекст процесса генерации</param>
    public override IGeneratorFunctionEvaluator CreateFunctionEvaluator(GenerationContext context) => (IGeneratorFunctionEvaluator) new NotificationFunctionEvaluator(context, this.notificationTemplate);

    internal static void qT0deJH0eyiN56lUfJr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool v8mwdiH7MJdTZjZ4On0() => NotificationGeneratorProvider.kvyaWDHAAmklJm1p5tY == null;

    internal static NotificationGeneratorProvider wLdgABHxeOKjAPCHB2L() => NotificationGeneratorProvider.kvyaWDHAAmklJm1p5tY;
  }
}
