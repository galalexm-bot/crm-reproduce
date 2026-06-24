// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Public.PublicServiceMethodExecutor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services.Public
{
  /// <summary>
  /// Класс - исполнитель методов, заданных в <see cref="T:EleWise.ELMA.Services.Public.IPublicServiceMethod" />
  /// </summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-795.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public class PublicServiceMethodExecutor
  {
    private readonly WebData parameters;
    protected Func<WebData, WebData> methodBody;
    internal static PublicServiceMethodExecutor wfS5SFBmIehmPRe4wPUn;

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:System.Object" />.
    /// </summary>
    public PublicServiceMethodExecutor(WebData parameters, Func<WebData, WebData> methodBody)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.parameters = parameters;
      this.methodBody = methodBody;
    }

    protected PublicServiceMethodExecutor(WebData parameters)
    {
      PublicServiceMethodExecutor.OXINQ0Bmi6esOrZQusw5();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.parameters = parameters;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Выполнить действие метода</summary>
    /// <returns>Результат выполнения</returns>
    public virtual WebData Execute()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.MethodBody == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      throw new NotImplementedException((string) PublicServiceMethodExecutor.CyvihMBmqm0lj6kPWecM(PublicServiceMethodExecutor.WnWmDMBmRXOu73V1DPud(~-306453669 ^ 306544134)));
label_5:
      return this.MethodBody(this.Parameters);
    }

    /// <summary>Параметры</summary>
    public virtual WebData Parameters => this.parameters;

    /// <summary>
    /// Функция, выполняемая при вызове <see cref="M:EleWise.ELMA.Services.Public.PublicServiceMethodExecutor.Execute" />
    /// </summary>
    public virtual Func<WebData, WebData> MethodBody => this.methodBody;

    internal static void OXINQ0Bmi6esOrZQusw5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ty147oBmVRZDB1xFgJSr() => PublicServiceMethodExecutor.wfS5SFBmIehmPRe4wPUn == null;

    internal static PublicServiceMethodExecutor BV4r8QBmSiRwO2TsLU7m() => PublicServiceMethodExecutor.wfS5SFBmIehmPRe4wPUn;

    internal static object WnWmDMBmRXOu73V1DPud(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object CyvihMBmqm0lj6kPWecM([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}
