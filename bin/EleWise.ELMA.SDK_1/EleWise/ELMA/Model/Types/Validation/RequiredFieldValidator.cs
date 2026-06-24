// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Validation.RequiredFieldValidator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EleWise.ELMA.Model.Types.Validation
{
  public class RequiredFieldValidator : DataAnnotationsModelValidator<RequiredFieldAttribute>
  {
    internal static RequiredFieldValidator UKfZF6o5ZY85DFA3kKVS;

    public RequiredFieldValidator(
      ModelMetadata metadata,
      ControllerContext context,
      RequiredFieldAttribute attribute)
    {
      RequiredFieldValidator.E9lFKno5VgfoPBv10ego();
      // ISSUE: explicit constructor call
      base.\u002Ector(metadata, context, attribute);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override IEnumerable<ModelClientValidationRule> GetClientValidationRules()
    {
      List<ModelClientValidationRule> rules = new List<ModelClientValidationRule>();
      ModelClientValidationRule rule = new ModelClientValidationRule()
      {
        ErrorMessage = EleWise.ELMA.SR.T(this.ErrorMessage),
        ValidationType = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837769247)
      };
      rules.Add(rule);
      rule.ValidationParameters.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333618154), this.Metadata.ModelType.GetInterface(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883332812)) != (Type) null ? (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654136829) : (object) (string) null);
      Type type = !this.Metadata.ModelType.IsInterface || !this.Metadata.ModelType.IsGenericType || !(this.Metadata.ModelType.GetGenericTypeDefinition() == typeof (Iesi.Collections.Generic.ISet<>)) ? this.Metadata.ModelType.GetInterface(typeof (Iesi.Collections.Generic.ISet<>).FullName) : this.Metadata.ModelType;
      if (type != (Type) null && MetadataLoader.LoadMetadata(type.GetGenericArguments()[0]) is TablePartMetadata)
      {
        rule.ValidationParameters.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112874696), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978633420));
        rule.ValidationParameters.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283557141), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153989437));
      }
      if (ComponentManager.Initialized && Locator.Initialized)
        (ContextVars.HasImpl ? ContextVars.GetOrAdd<IEnumerable<IRequiredFieldValidatorHandler>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323179564), (Func<IEnumerable<IRequiredFieldValidatorHandler>>) (() => ComponentManager.Current.GetExtensionPoints<IRequiredFieldValidatorHandler>())) : ComponentManager.Current.GetExtensionPoints<IRequiredFieldValidatorHandler>()).ForEach<IRequiredFieldValidatorHandler>((Action<IRequiredFieldValidatorHandler>) (h =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                // ISSUE: reference to a compiler-generated method
                h.GetClientValidationRules((ModelValidator) this, (ModelMetadata) RequiredFieldValidator.\u003C\u003Ec__DisplayClass1_0.N5MZtkCRdrieOK42ggNo((object) this), this.ControllerContext, rules, rule);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
      return (IEnumerable<ModelClientValidationRule>) rules;
    }

    internal static void E9lFKno5VgfoPBv10ego() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ryc4rko5ucLJmw5KsD7I() => RequiredFieldValidator.UKfZF6o5ZY85DFA3kKVS == null;

    internal static RequiredFieldValidator U8yDr4o5IplkeN4dOYwk() => RequiredFieldValidator.UKfZF6o5ZY85DFA3kKVS;
  }
}
