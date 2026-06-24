// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.IEntityFormsService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>Сервис для работы с формами сущностей</summary>
  public interface IEntityFormsService
  {
    /// <summary>Получить все формы сущности</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Формы сущности</returns>
    IEnumerable<FormViewItem> GetAllForms(ClassMetadata metadata);

    /// <summary>Получить список базовых форм</summary>
    /// <param name="forms">Список форм</param>
    /// <param name="defaultForms">Формы по умолчанию</param>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="ignoreExtensionUid">Уникальный идентификатор расширения, которое нужно проигнорировать</param>
    void GetBaseForms(
      List<FormViewItem> forms,
      ClassDefaultForms defaultForms,
      EntityMetadata metadata,
      Guid ignoreExtensionUid);

    /// <summary>Добавить формы к списку форм</summary>
    /// <param name="forms">Список форм</param>
    /// <param name="defaultForms">Формы по умолчанию</param>
    /// <param name="metadata">Метаданные класса</param>
    void AddForms(List<FormViewItem> forms, ClassDefaultForms defaultForms, ClassMetadata metadata);

    /// <summary>Добавить дочерние формы к списку форм</summary>
    /// <param name="forms">Список форм</param>
    /// <param name="childFormTransformations">Трансформации дочерних форм</param>
    /// <param name="transform">Трансформация</param>
    /// <returns>Форма</returns>
    FormViewItem AddChildForm(
      List<FormViewItem> forms,
      IEnumerable<FormViewItemTransformation> childFormTransformations,
      FormViewItemTransformation transform);
  }
}
