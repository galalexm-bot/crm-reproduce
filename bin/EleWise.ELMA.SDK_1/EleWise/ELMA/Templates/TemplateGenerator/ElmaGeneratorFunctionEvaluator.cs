// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Templates.TemplateGenerator.ElmaGeneratorFunctionEvaluator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.TemplateGenerator;
using EleWise.TemplateGenerator.Functions;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Templates.TemplateGenerator
{
  /// <summary>Вычислитель функций с поддержкой специфики ELMA SDK</summary>
  public class ElmaGeneratorFunctionEvaluator : GeneratorFunctionEvaluator
  {
    internal static ElmaGeneratorFunctionEvaluator rs2XaCBpRP4BubmSDZv8;

    /// <summary>Ctor</summary>
    /// <param name="context">Контекст процесса генерации</param>
    public ElmaGeneratorFunctionEvaluator(GenerationContext context)
    {
      ElmaGeneratorFunctionEvaluator.wqw0MyBpXyf2i5Z6CThN();
      // ISSUE: explicit constructor call
      base.\u002Ector(context);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            ElmaGeneratorFunctionEvaluator.AWlOMRBpkKIr825OVsD5((object) this, ElmaGeneratorFunctionEvaluator.RUXvqRBpTmfpmPDPxn3A(__typeref (ElmaGeneratorFunctions)));
            num = 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            if (ElmaGeneratorFunctionEvaluator.Qi96geBpngB45EFZbeOy())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          default:
            ((ComponentManager) ElmaGeneratorFunctionEvaluator.wMC6RsBpO1EDD30MCvVV()).GetExtensionPointTypes<ITemplateGeneratorFunctionsContainer>().ForEach<Type>(new Action<Type>(((GeneratorFunctionEvaluator) this).RegisterFunctionsContainerType));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 2 : 2;
            continue;
        }
      }
label_3:
      return;
label_8:;
    }

    internal static void wqw0MyBpXyf2i5Z6CThN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type RUXvqRBpTmfpmPDPxn3A([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void AWlOMRBpkKIr825OVsD5([In] object obj0, [In] Type obj1) => ((GeneratorFunctionEvaluator) obj0).RegisterFunctionsContainerType(obj1);

    internal static bool Qi96geBpngB45EFZbeOy() => ComponentManager.Initialized;

    internal static object wMC6RsBpO1EDD30MCvVV() => (object) ComponentManager.Current;

    internal static bool MIa62nBpqe3DRFo1Ty2U() => ElmaGeneratorFunctionEvaluator.rs2XaCBpRP4BubmSDZv8 == null;

    internal static ElmaGeneratorFunctionEvaluator V1uKsqBpK54ei790SCDc() => ElmaGeneratorFunctionEvaluator.rs2XaCBpRP4BubmSDZv8;
  }
}
