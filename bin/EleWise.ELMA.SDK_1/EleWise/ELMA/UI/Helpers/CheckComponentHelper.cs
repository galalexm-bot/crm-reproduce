// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Helpers.CheckComponentHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.UI.Helpers
{
  /// <summary>Помощник проверки компонентов</summary>
  public static class CheckComponentHelper
  {
    internal static CheckComponentHelper E47vkdBZBmxUeTvFlEYS;

    /// <summary>
    /// Найти все элементы представления "Пользовательский компонент" на форме
    /// </summary>
    /// <param name="form">Форма</param>
    /// <returns>Список элементов представления "Пользовательский компонент" на форме</returns>
    public static IEnumerable<ComponentViewItem> FindAllComponentViewItems(FormViewItem form)
    {
      Contract.ArgumentNotNull((object) form, z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132968153));
      return form.FindItems(false, (Func<ViewItem, bool>) (i => i is ComponentViewItem)).Cast<ComponentViewItem>().Concat<ComponentViewItem>(CheckComponentHelper.ComponentsFromToolbar((object) form));
    }

    /// <summary>
    /// Найти все элементы представления "Форма объекта" на форме
    /// </summary>
    /// <param name="form">Форма</param>
    /// <returns>Список элементов представления "Форма объекта" на форме</returns>
    public static IEnumerable<ObjectFormViewItem> FindAllObjectFormViewItems(FormViewItem form)
    {
      Contract.ArgumentNotNull((object) form, z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521214042));
      return form.FindItems(false, (Func<ViewItem, bool>) (i => i is ObjectFormViewItem)).Cast<ObjectFormViewItem>();
    }

    /// <summary>Анализ компонентов, добавленных на форму</summary>
    /// <param name="form">Форма компонента</param>
    /// <param name="ownerUid">Уникальный идентификатор объекта-владельца</param>
    /// <returns>Анализ зависимостей</returns>
    public static IEnumerable<ValidationError> CheckComponentViewItems(
      FormViewItem form,
      Guid ownerUid)
    {
      return CheckComponentHelper.CheckComponentViewItems(form, ownerUid, (EntityMetadata) null, (Func<Guid, bool>) null);
    }

    /// <summary>Анализ компонентов, добавленных на форму</summary>
    /// <param name="form">Форма компонента</param>
    /// <param name="ownerUid">Уникальный идентификатор объекта-владельца</param>
    /// <param name="componentFilter">Фильтр по связанным компонентам для проверки</param>
    /// <returns>Анализ зависимостей</returns>
    public static IEnumerable<ValidationError> CheckComponentViewItems(
      FormViewItem form,
      Guid ownerUid,
      Func<Guid, bool> componentFilter)
    {
      return CheckComponentHelper.CheckComponentViewItems(form, ownerUid, (EntityMetadata) null, componentFilter);
    }

    /// <summary>Анализ компонентов, добавленных на форму</summary>
    /// <param name="form">Форма компонента</param>
    /// <param name="ownerUid">Уникальный идентификатор объекта-владельца</param>
    /// <param name="ownerEntity">Метаданные, в которых размещен компонент</param>
    /// <returns>Анализ зависимостей</returns>
    public static IEnumerable<ValidationError> CheckComponentViewItems(
      FormViewItem form,
      Guid ownerUid,
      EntityMetadata ownerEntity)
    {
      return CheckComponentHelper.CheckComponentViewItems(form, ownerUid, ownerEntity, (Func<Guid, bool>) null);
    }

    /// <summary>Анализ компонентов, добавленных на форму</summary>
    /// <param name="form">Форма компонента</param>
    /// <param name="ownerUid">Уникальный идентификатор объекта-владельца</param>
    /// <param name="ownerEntity">Метаданные, в которых размещен компонент</param>
    /// <param name="componentFilter">Фильтр по связанным компонентам для проверки</param>
    /// <returns>Анализ зависимостей</returns>
    public static IEnumerable<ValidationError> CheckComponentViewItems(
      FormViewItem form,
      Guid ownerUid,
      EntityMetadata ownerEntity,
      Func<Guid, bool> componentFilter)
    {
      componentFilter = componentFilter ?? new Func<Guid, bool>(CheckComponentHelper.EmptyFilter);
      List<ValidationError> validationErrorList = new List<ValidationError>();
      foreach (ComponentViewItem componentViewItem in CheckComponentHelper.FindAllComponentViewItems(form).Where<ComponentViewItem>((Func<ComponentViewItem, bool>) (c => componentFilter(c.HeaderUid))))
      {
        ComponentMetadata candidateMetadata = (ComponentMetadata) null;
        try
        {
          candidateMetadata = MetadataServiceContext.Service.GetMetadata(componentViewItem.HeaderUid) as ComponentMetadata;
        }
        catch (TypeNotFoundException ex)
        {
          if (Locator.GetService<IActorContextService>().TryGet(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61156893), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36031995), (object) componentViewItem.HeaderUid), out object _))
            continue;
        }
        if (candidateMetadata == null)
        {
          if (ownerEntity == null)
            throw new MetadataLoadException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319484456), (object) componentViewItem.HeaderUid));
          throw new MetadataLoadException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998566574), (object) componentViewItem.HeaderUid, (object) ownerEntity.Name, (object) ownerEntity.Uid));
        }
        ValidationResult validationResult = CheckComponentHelper.CheckSignature(CheckComponentHelper.GetCurrentInputs(componentViewItem, InterfaceBuilderViewMode.Runtime), candidateMetadata);
        if (!validationResult.IsValid)
        {
          ValidationError validationError = new ValidationError()
          {
            OwnerUid = ownerUid,
            ElementTypeUid = ValidationElementType.ComponentViewItem,
            ElementUid = componentViewItem.Uid,
            Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088342234), (object) candidateMetadata.DisplayName),
            InnerErrors = validationResult.Errors
          };
          validationErrorList.Add(validationError);
        }
      }
      return (IEnumerable<ValidationError>) validationErrorList;
    }

    /// <summary>
    /// Проверить зависимость от компонента по публичной сигнатуре компонента
    /// </summary>
    /// <param name="componentDependency">Зависимость от компонента</param>
    /// <param name="componentSignature">Публичная сигнатура компонента</param>
    /// <returns>Результат проверки зависимости</returns>
    public static ValidationResult CheckSignature(
      ComponentDependency componentDependency,
      ComponentSignature componentSignature)
    {
      return CheckComponentHelper.CheckSignature((ICollection<InputComputedValue>) componentDependency.Inputs, componentSignature);
    }

    /// <summary>Проверить инпуты по публичной сигнатуре компонента</summary>
    /// <param name="inputs">Инпуты компонента</param>
    /// <param name="componentSignature">Публичная сигнатура компонента</param>
    /// <returns>Результат проверки зависимости</returns>
    public static ValidationResult CheckSignature(
      ICollection<InputComputedValue> inputs,
      ComponentSignature componentSignature)
    {
      List<ValidationError> errors = new List<ValidationError>();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (InputComputedValue inputComputedValue1 in componentSignature.Inputs.Where<InputComputedValue>((Func<InputComputedValue, bool>) (a => CheckComponentHelper.\u003C\u003Ec.o3BCjRQGAReZytFEVYnX(CheckComponentHelper.\u003C\u003Ec.BcGa1fQGHID3qZFj7V3H((object) a), SlotViewItem.TypeUid))))
      {
        InputComputedValue candidateInput = inputComputedValue1;
        bool flag = candidateInput.Name.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475922071));
        string str = candidateInput.Name.Replace(flag ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317740224) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87316015), string.Empty);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        InputComputedValue inputComputedValue2 = inputs.FirstOrDefault<InputComputedValue>((Func<InputComputedValue, bool>) (q => CheckComponentHelper.\u003C\u003Ec__DisplayClass7_0.O5qNkbQGrFyxLrjsplip(CheckComponentHelper.\u003C\u003Ec__DisplayClass7_0.a9uJiCQGlYOwhymkNbif((object) q), CheckComponentHelper.\u003C\u003Ec__DisplayClass7_0.a9uJiCQGlYOwhymkNbif((object) candidateInput))));
        if (inputComputedValue2 == null)
        {
          if (candidateInput.Required)
          {
            if (flag)
              errors.Add(new ValidationError()
              {
                Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217467261), (object) componentSignature.DisplayName, (object) str)
              });
            else
              errors.Add(new ValidationError()
              {
                Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841412558), (object) componentSignature.DisplayName, (object) str)
              });
          }
        }
        else
        {
          if (candidateInput.Nullable != inputComputedValue2.Nullable && !candidateInput.Nullable && inputComputedValue2.Nullable)
            errors.Add(new ValidationError()
            {
              Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787443163), (object) componentSignature.DisplayName, (object) str)
            });
          if (!flag && candidateInput.RelationType != inputComputedValue2.RelationType)
            errors.Add(new ValidationError()
            {
              Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195679999), (object) componentSignature.DisplayName, (object) str)
            });
          if (!flag && candidateInput.TypeUid != inputComputedValue2.TypeUid)
            errors.Add(new ValidationError()
            {
              Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138893488), (object) componentSignature.DisplayName, (object) str)
            });
          if (flag && inputComputedValue2 is ActionInputComputedValue inputComputedValue3 && candidateInput.TypeUid != inputComputedValue3.ParameterType.TypeUid)
            errors.Add(new ValidationError()
            {
              Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993503801), (object) componentSignature.DisplayName, (object) str)
            });
          if (!flag && candidateInput.SubTypeUid != inputComputedValue2.SubTypeUid)
            errors.Add(new ValidationError()
            {
              Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979383574), (object) componentSignature.DisplayName, (object) str)
            });
          if (inputComputedValue2 is ActionInputComputedValue inputComputedValue4 && candidateInput is ActionInputComputedValue inputComputedValue5)
          {
            CompatibilityResult compatibilityResult1 = inputComputedValue4.ReturnType.Compatible(inputComputedValue5.ReturnType);
            if (!compatibilityResult1.IsValid)
            {
              errors.Add(new ValidationError()
              {
                Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477205408), (object) componentSignature.DisplayName, (object) str)
              });
              errors.AddRange(((IEnumerable<string>) compatibilityResult1.Errors).Select<string, ValidationError>((Func<string, ValidationError>) (error =>
              {
                ValidationError validationError = new ValidationError();
                // ISSUE: reference to a compiler-generated method
                CheckComponentHelper.\u003C\u003Ec.YWvl4ZQG7HILrx4VYZyc((object) validationError, (object) error);
                return validationError;
              })));
            }
            CompatibilityResult compatibilityResult2 = inputComputedValue4.ParameterType.Compatible(inputComputedValue5.ParameterType);
            if (!compatibilityResult2.IsValid)
            {
              errors.Add(new ValidationError()
              {
                Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283450551), (object) componentSignature.DisplayName, (object) str)
              });
              errors.AddRange(((IEnumerable<string>) compatibilityResult2.Errors).Select<string, ValidationError>((Func<string, ValidationError>) (error =>
              {
                ValidationError validationError = new ValidationError();
                // ISSUE: reference to a compiler-generated method
                CheckComponentHelper.\u003C\u003Ec.YWvl4ZQG7HILrx4VYZyc((object) validationError, (object) error);
                return validationError;
              })));
            }
          }
        }
      }
      // ISSUE: reference to a compiler-generated method
      foreach (InputComputedValue inputComputedValue in inputs.Where<InputComputedValue>((Func<InputComputedValue, bool>) (a => CheckComponentHelper.\u003C\u003Ec.BcGa1fQGHID3qZFj7V3H((object) a) == SlotViewItem.TypeUid)))
      {
        InputComputedValue slot = inputComputedValue;
        if (componentSignature.Inputs.FirstOrDefault<InputComputedValue>((Func<InputComputedValue, bool>) (s =>
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                if (!(CheckComponentHelper.\u003C\u003Ec__DisplayClass7_1.v4EOGbQGLfGqJSjy7vHN((object) s) == SlotViewItem.TypeUid))
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                  continue;
                }
                goto label_4;
              case 2:
                goto label_4;
              default:
                goto label_5;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          return CheckComponentHelper.\u003C\u003Ec__DisplayClass7_1.r7wc7BQGstYZqOaWecYP(s.SubTypeUid, CheckComponentHelper.\u003C\u003Ec__DisplayClass7_1.ajVXGvQGUN0eX510132q((object) slot));
label_5:
          return false;
        })) == null)
          errors.Add(new ValidationError()
          {
            Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488816427), (object) componentSignature.DisplayName, (object) slot.Name)
          });
      }
      return new ValidationResult(errors.Count == 0, (IEnumerable<ValidationError>) errors);
    }

    /// <summary>Проверить сигнатуру</summary>
    /// <param name="inputs">Текущие инпуты</param>
    /// <param name="candidateMetadata">Метаданные компонента-кандидата</param>
    /// <returns>Результат проверки сигнатуры</returns>
    public static ValidationResult CheckSignature(
      ICollection<InputComputedValue> inputs,
      ComponentMetadata candidateMetadata)
    {
      if (candidateMetadata == null)
        return new ValidationResult(false, new ValidationError[1]
        {
          new ValidationError()
          {
            Message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867134075))
          }
        });
      ComponentSignature signature = candidateMetadata.GetSignature();
      return CheckComponentHelper.CheckSignature(inputs, signature);
    }

    /// <summary>
    /// Получить текущие инпуты элемента представления "Компонент"
    /// </summary>
    /// <remarks>Достаются только заполненные инпуты</remarks>
    /// <param name="componentViewItem">Элемент представления "Компонент"</param>
    /// <param name="viewMode">Режим отображения</param>
    /// <returns>Текущие инпуты</returns>
    public static ICollection<InputComputedValue> GetCurrentInputs(
      ComponentViewItem componentViewItem,
      InterfaceBuilderViewMode viewMode)
    {
      List<InputComputedValue> currentInputs = new List<InputComputedValue>();
      foreach (ComputedValue dynamicProperty in componentViewItem.DynamicProperties)
      {
        if (dynamicProperty is InputComputedValue inputComputedValue)
        {
          if (viewMode == InterfaceBuilderViewMode.Design)
          {
            currentInputs.Add(inputComputedValue);
          }
          else
          {
            switch (inputComputedValue.ComputedValueType)
            {
              case ComputedValueType.Input:
                if (inputComputedValue.Value == null || inputComputedValue.Value is string str && string.IsNullOrWhiteSpace(str))
                  continue;
                break;
              case ComputedValueType.Function:
                if (string.IsNullOrWhiteSpace(inputComputedValue.MethodName))
                  continue;
                break;
              case ComputedValueType.CalculateScript:
                if (string.IsNullOrWhiteSpace(inputComputedValue.CalculateScript))
                  continue;
                break;
            }
            currentInputs.Add(inputComputedValue);
          }
        }
      }
      return (ICollection<InputComputedValue>) currentInputs;
    }

    private static IEnumerable<ComponentViewItem> ComponentsFromToolbar(object view) => ((FormViewItem) view)?.Toolbar == null ? Enumerable.Empty<ComponentViewItem>() : ((FormViewItem) view).Toolbar.GetAllItems(false).OfType<Button>().SelectMany<Button, ComponentViewItem>((Func<Button, IEnumerable<ComponentViewItem>>) (button =>
    {
      RootViewItem rootViewItem = button.RootViewItem;
      return (rootViewItem != null ? rootViewItem.GetAllItems(false).OfType<ComponentViewItem>() : (IEnumerable<ComponentViewItem>) null) ?? Enumerable.Empty<ComponentViewItem>();
    }));

    private static bool EmptyFilter(Guid _) => true;

    internal static bool sc06u9BZWV469fO79xrv() => CheckComponentHelper.E47vkdBZBmxUeTvFlEYS == null;

    internal static CheckComponentHelper fKKiq1BZogsA1lgLSFne() => CheckComponentHelper.E47vkdBZBmxUeTvFlEYS;
  }
}
