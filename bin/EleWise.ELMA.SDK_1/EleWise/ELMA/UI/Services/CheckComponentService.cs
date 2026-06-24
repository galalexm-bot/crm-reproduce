// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.CheckComponentService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Helpers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Services
{
  /// <inheritdoc />
  [Service]
  internal sealed class CheckComponentService : ICheckComponentService
  {
    private readonly IScriptLoader scriptLoader;
    internal static CheckComponentService u1sdRozSaG6C0awhByg;

    /// <summary>Ctor</summary>
    /// <param name="scriptLoader">Загрузчик скриптов</param>
    public CheckComponentService(IScriptLoader scriptLoader)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.scriptLoader = scriptLoader;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public ValidationResult Validate(ComponentMetadata componentMetadata)
    {
      int num = 1;
      List<ValidationError> list;
      while (true)
      {
        switch (num)
        {
          case 1:
            IEnumerable<ValidationError> first = CheckComponentService.CheckComponentContext((object) componentMetadata);
            IEnumerable<ValidationError> validationErrors = CheckComponentService.CheckObjectFormViewItems((object) componentMetadata);
            IEnumerable<ValidationError> second1 = CheckComponentHelper.CheckComponentViewItems((FormViewItem) CheckComponentService.Vh95OxzqQFQHXmUkHG8((object) componentMetadata.Content), CheckComponentService.sNYFrMzKfT0QRTvu742((object) componentMetadata));
            IEnumerable<ValidationError> second2 = this.CheckExistenceOfMethods(componentMetadata);
            IEnumerable<ValidationError> second3 = validationErrors;
            list = first.Concat<ValidationError>(second3).Concat<ValidationError>(second1).Concat<ValidationError>(second2).ToList<ValidationError>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return new ValidationResult(list.Count == 0, (IEnumerable<ValidationError>) list);
    }

    /// <summary>
    /// Проверить методы компонентов на существование в сценариях
    /// </summary>
    /// <param name="componentMetadata"></param>
    /// <returns>Список ошибок</returns>
    private IEnumerable<ValidationError> CheckExistenceOfMethods(ComponentMetadata componentMetadata)
    {
      List<ValidationError> errors = new List<ValidationError>();
      Dictionary<CodeType, IEnumerable<ScriptMethodDeclaration>> scriptMethodDeclarations = new Dictionary<CodeType, IEnumerable<ScriptMethodDeclaration>>();
      this.ExtendScriptMethodDeclarations((IDictionary<CodeType, IEnumerable<ScriptMethodDeclaration>>) scriptMethodDeclarations, CodeType.Client, componentMetadata.ClientScriptUid);
      this.ExtendScriptMethodDeclarations((IDictionary<CodeType, IEnumerable<ScriptMethodDeclaration>>) scriptMethodDeclarations, CodeType.Server, componentMetadata.ScriptUid);
      if (scriptMethodDeclarations.Count == 0)
        return (IEnumerable<ValidationError>) errors;
      foreach (PropertyMetadata property in componentMetadata.Content.Context.Properties)
      {
        if (property is ViewModelPropertyMetadata propertyMetadata)
        {
          if (propertyMetadata.ComputedValue != null && propertyMetadata.ComputedValue.ComputedValueType == ComputedValueType.Function)
            this.AddErrorIfMethodNotExist(errors, (IDictionary<CodeType, IEnumerable<ScriptMethodDeclaration>>) scriptMethodDeclarations, propertyMetadata.ComputedValue.MethodName, componentMetadata, propertyMetadata.Uid, propertyMetadata.DisplayName, ValidationElementType.Property);
          if (propertyMetadata.ComputedValues != null)
          {
            foreach (ComputedValue computedValue in propertyMetadata.ComputedValues)
            {
              if (computedValue.ComputedValueType == ComputedValueType.Function)
                this.AddErrorIfMethodNotExist(errors, (IDictionary<CodeType, IEnumerable<ScriptMethodDeclaration>>) scriptMethodDeclarations, computedValue.MethodName, componentMetadata, propertyMetadata.Uid, propertyMetadata.DisplayName, ValidationElementType.Property);
            }
          }
        }
      }
      foreach (ViewItem allItem in componentMetadata.Content.View.GetAllItems())
      {
        foreach (ComputedValue dynamicProperty in allItem.DynamicProperties)
        {
          if (dynamicProperty.ComputedValueType == ComputedValueType.Function)
            this.AddErrorIfMethodNotExist(errors, (IDictionary<CodeType, IEnumerable<ScriptMethodDeclaration>>) scriptMethodDeclarations, dynamicProperty.MethodName, componentMetadata, allItem.Uid, allItem.Name, ValidationElementType.ViewItem);
        }
        if (allItem is PropertyViewItem propertyViewItem && propertyViewItem.Attributes != null)
          this.AddErrorIfMethodNotExist(errors, (IDictionary<CodeType, IEnumerable<ScriptMethodDeclaration>>) scriptMethodDeclarations, propertyViewItem.Attributes.OnChangeScriptName, componentMetadata, allItem.Uid, allItem.Name, ValidationElementType.ViewItem);
        if (allItem is ButtonViewItem buttonViewItem)
          this.AddErrorIfMethodNotExist(errors, (IDictionary<CodeType, IEnumerable<ScriptMethodDeclaration>>) scriptMethodDeclarations, buttonViewItem.ScriptName, componentMetadata, allItem.Uid, allItem.Name, ValidationElementType.ViewItem);
      }
      return (IEnumerable<ValidationError>) errors;
    }

    private void ExtendScriptMethodDeclarations(
      IDictionary<CodeType, IEnumerable<ScriptMethodDeclaration>> scriptMethodDeclarations,
      CodeType codeType,
      Guid? scriptUid)
    {
      try
      {
        ScriptModule script = this.scriptLoader.GetScript(scriptUid);
        if (script == null)
          return;
        scriptMethodDeclarations.Add(codeType, (IEnumerable<ScriptMethodDeclaration>) script.ScriptMethods);
      }
      catch (ObjectNotFoundException ex)
      {
      }
    }

    private void AddErrorIfMethodNotExist(
      List<ValidationError> errors,
      IDictionary<CodeType, IEnumerable<ScriptMethodDeclaration>> scriptMethodDeclarations,
      string scriptName,
      ComponentMetadata componentMetadata,
      Guid elementUid,
      string elementName,
      Guid validationElementType)
    {
      ScriptMethodInfo method = ScriptMethodInfoHelper.Deserialize(scriptName);
      IEnumerable<ScriptMethodDeclaration> source;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (method.Name.IsNullOrEmpty() || method.MetadataUid == Guid.Empty || scriptMethodDeclarations.TryGetValue(method.CodeType, out source) && source.Any<ScriptMethodDeclaration>((Func<ScriptMethodDeclaration, bool>) (script => CheckComponentService.\u003C\u003Ec__DisplayClass6_0.oobee4fsaGCgPAdcrtTb(CheckComponentService.\u003C\u003Ec__DisplayClass6_0.yLlfQ4fs3mCwXvqFNZh6((object) script), CheckComponentService.\u003C\u003Ec__DisplayClass6_0.skYubrfspNU4qbL77gJl((object) method)))))
        return;
      errors.Add(new ValidationError()
      {
        OwnerUid = componentMetadata.Uid,
        ElementUid = elementUid,
        ElementTypeUid = validationElementType,
        Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317747076), (object) scriptName, (object) elementName, (object) elementUid, (object) componentMetadata.DisplayName)
      });
    }

    private static IEnumerable<ValidationError> CheckObjectFormViewItems(object componentMetadata)
    {
      ComponentMetadata componentMetadata1 = (ComponentMetadata) componentMetadata;
      // ISSUE: reference to a compiler-generated method
      return CheckComponentHelper.FindAllObjectFormViewItems(componentMetadata1.Content.View).Where<ObjectFormViewItem>((Func<ObjectFormViewItem, bool>) (objectForm => CheckComponentService.\u003C\u003Ec.lLtHYvfsJIhxCX6wxExa((object) objectForm) == ViewItemLoadingType.SyncLoading)).Select<ObjectFormViewItem, ValidationError>((Func<ObjectFormViewItem, ValidationError>) (objectForm =>
      {
        int num = 2;
        ValidationError validationError;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              CheckComponentService.\u003C\u003Ec__DisplayClass7_0.tonHC1fsHHcwGSSbMFWG((object) validationError, CheckComponentService.\u003C\u003Ec__DisplayClass7_0.XbDHhdfs6LnUYAKZgXEF((object) componentMetadata1));
              num = 4;
              continue;
            case 2:
              validationError = new ValidationError();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated method
              CheckComponentService.\u003C\u003Ec__DisplayClass7_0.Advob9fsA49eyPXROTC3((object) validationError, ValidationElementType.ObjectFormViewItem);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            case 4:
              validationError.ElementUid = objectForm.Uid;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 3 : 3;
              continue;
            case 5:
              goto label_2;
            default:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              CheckComponentService.\u003C\u003Ec__DisplayClass7_0.G7gHBkfsxFhrLqyQYr8d((object) validationError, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97748592), CheckComponentService.\u003C\u003Ec__DisplayClass7_0.D7FKMffs7u47nhv2qbJk((object) componentMetadata1)));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 5 : 2;
              continue;
          }
        }
label_2:
        return validationError;
      }));
    }

    private static IEnumerable<ValidationError> CheckComponentContext(object componentMetadata)
    {
      List<ValidationError> validationErrorList = new List<ValidationError>();
      foreach (PropertyMetadata property in ((ComponentMetadata) componentMetadata).Content.Context.Properties)
      {
        if (string.IsNullOrWhiteSpace(property.Name))
          validationErrorList.Add(new ValidationError()
          {
            OwnerUid = ((AbstractMetadata) componentMetadata).Uid,
            ElementUid = property.Uid,
            ElementTypeUid = ValidationElementType.Property,
            Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195562891), (object) ((NamedMetadata) componentMetadata).DisplayName, (object) property.Uid)
          });
        if (string.IsNullOrWhiteSpace(property.DisplayName))
          validationErrorList.Add(new ValidationError()
          {
            OwnerUid = ((AbstractMetadata) componentMetadata).Uid,
            ElementUid = property.Uid,
            ElementTypeUid = ValidationElementType.Property,
            Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218440270), (object) ((NamedMetadata) componentMetadata).DisplayName, (object) property.Uid)
          });
        if (property.TypeUid == Guid.Empty)
          validationErrorList.Add(new ValidationError()
          {
            OwnerUid = ((AbstractMetadata) componentMetadata).Uid,
            ElementUid = property.Uid,
            ElementTypeUid = ValidationElementType.Property,
            Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372709595), (object) ((NamedMetadata) componentMetadata).DisplayName, (object) property.Uid)
          });
      }
      return (IEnumerable<ValidationError>) validationErrorList;
    }

    private static IEnumerable<ValidationError> CheckImplementationForms(object componentMetadata)
    {
      List<ValidationError> validationErrorList = new List<ValidationError>();
      if (((ComponentMetadata) componentMetadata).ImplementationForms.Count == 0)
        return (IEnumerable<ValidationError>) validationErrorList;
      foreach (ImplementationForm implementationForm in ((ComponentMetadata) componentMetadata).ImplementationForms)
      {
        ImplementationForm impl = implementationForm;
        if (!((ComponentMetadata) componentMetadata).Content.Context.Properties.Any<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                if (p is ViewModelPropertyMetadata propertyMetadata2)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                  continue;
                }
                goto label_3;
              case 2:
                goto label_2;
              default:
                // ISSUE: reference to a compiler-generated method
                if (CheckComponentService.\u003C\u003Ec__DisplayClass9_0.pMFJk8fsgGmPpcaCN97g((object) propertyMetadata2))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 2;
                  continue;
                }
                goto label_3;
            }
          }
label_2:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return CheckComponentService.\u003C\u003Ec__DisplayClass9_0.sODMSRfsYi18nXkSHdw9(CheckComponentService.\u003C\u003Ec__DisplayClass9_0.YTryfMfs5PF02LyfQdjB((object) propertyMetadata2), CheckComponentService.\u003C\u003Ec__DisplayClass9_0.xIyx9Vfsj0oIr5KRBgk2((object) impl));
label_3:
          return false;
        })))
          validationErrorList.Add(new ValidationError()
          {
            OwnerUid = ((AbstractMetadata) componentMetadata).Uid,
            ElementTypeUid = ValidationElementType.Property,
            Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239590436), (object) ((NamedMetadata) componentMetadata).DisplayName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426105995))
          });
      }
      return (IEnumerable<ValidationError>) validationErrorList;
    }

    internal static bool xwYeCDzi7xik2BCTcXD() => CheckComponentService.u1sdRozSaG6C0awhByg == null;

    internal static CheckComponentService Nejo3FzRBwkK8XtyDPv() => CheckComponentService.u1sdRozSaG6C0awhByg;

    internal static object Vh95OxzqQFQHXmUkHG8([In] object obj0) => (object) ((ComponentContentMetadata) obj0).View;

    internal static Guid sNYFrMzKfT0QRTvu742([In] object obj0) => ((AbstractMetadata) obj0).Uid;
  }
}
