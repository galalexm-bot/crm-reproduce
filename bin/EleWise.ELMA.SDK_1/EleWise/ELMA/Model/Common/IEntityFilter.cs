// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.IEntityFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using System;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>Интерфейс базового фильтра</summary>
  public interface IEntityFilter
  {
    /// <summary>Строка поиска</summary>
    [View(Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IEntityFilter), "P_SearchString_DisplayName")]
    string SearchString { get; set; }

    /// <summary>Фильтрация по подтипу</summary>
    [View(Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IEntityFilter), "P_Subtype_DisplayName")]
    [PublicApiMethodForBuilder(false)]
    [PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
    Type Subtype { get; set; }

    /// <summary>Привилегия для фильтрации</summary>
    [View(Visibility.Hidden)]
    [PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
    [PublicApiMethodForBuilder(false)]
    [DisplayName(typeof (__Resources_IEntityFilter), "P_PermissionId_DisplayName")]
    Guid? PermissionId { get; set; }

    /// <summary>Пользователь для которого проверяется привилегия</summary>
    [View(Visibility.Hidden)]
    [PublicApiMethodForBuilder(false)]
    [PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
    [DisplayName(typeof (__Resources_IEntityFilter), "P_PermissionUser_DisplayName")]
    IUser PermissionUser { get; set; }

    /// <summary>Не проверять права доступа к объектам</summary>
    [DisplayName(typeof (__Resources_IEntityFilter), "P_DisableSecurity_DisplayName")]
    [PublicApiMethodForBuilder(false)]
    [View(Visibility.Hidden)]
    [PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
    bool DisableSecurity { get; set; }

    /// <summary>
    /// Показать все, даже удаленные (работает в  случае если сущность ISoftDeletable)
    /// </summary>
    [PublicApiMethodForBuilder(false)]
    [View(Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IEntityFilter), "P_DisableSoftDeletable_DisplayName")]
    [PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
    bool DisableSoftDeletable { get; set; }

    /// <summary>
    /// Пропустить проверку на админовскую привилегию IInstanceSettingsPermission.AdminPermission
    /// </summary>
    [PublicApiMethodForBuilder(false)]
    [PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
    [View(Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IEntityFilter), "P_SkipAdminPermission_DisplayName")]
    bool SkipAdminPermission { get; set; }

    /// <summary>Идентификатор объекта</summary>
    [DisplayName(typeof (__Resources_IEntityFilter), "P_Id_DisplayName")]
    [View(Visibility.Hidden)]
    object Id { get; set; }

    /// <summary>Родительский объект для иерархических справочников</summary>
    [PublicApiMethodForBuilder(false)]
    [View(Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IEntityFilter), "P_HierarchyParent_DisplayName")]
    [PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
    object HierarchyParent { get; set; }

    /// <summary>
    /// Нужно ли фильтровать по родительскому объекту для иерархических справочников
    /// </summary>
    [PublicApiMethodForBuilder(false)]
    [View(Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IEntityFilter), "P_FilterByHierarchyParent_DisplayName")]
    [PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
    bool FilterByHierarchyParent { get; set; }

    /// <summary>Отключает вызов SetupAutoFilter()</summary>
    [PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
    [DisplayName(typeof (__Resources_IEntityFilter), "P_DisableAutoFilter_DisplayName")]
    [PublicApiMethodForBuilder(false)]
    [View(Visibility.Hidden)]
    bool DisableAutoFilter { get; set; }

    /// <summary>Показывать при выборе только группы</summary>
    [DisplayName(typeof (__Resources_IEntityFilter), "P_ShowOnlyGroups_DisplayName")]
    [PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
    [View(Visibility.Hidden)]
    [PublicApiMethodForBuilder(false)]
    bool ShowOnlyGroups { get; set; }

    /// <summary>
    /// Искать во вложениях при полнотекстовом поиске в индексе
    /// </summary>
    [DisplayName(typeof (__Resources_IEntityFilter), "P_FullTextInAttachments_DisplayName")]
    [View(Visibility.Hidden)]
    [PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
    bool FullTextInAttachments { get; set; }

    /// <summary>Условие выборки на языке EQL</summary>
    [View(Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IEntityFilter), "P_Query_DisplayName")]
    string Query { get; set; }

    /// <summary>Фильтр пуст или нет</summary>
    /// <returns></returns>
    bool IsEmpty();

    /// <summary>Параметры в EQL фильтре</summary>
    [PublicApiMethodForBuilder(false)]
    [View(Visibility.Hidden)]
    [DisplayName(typeof (__Resources_IEntityFilter), "P_QueryParameters_DisplayName")]
    [PropertyMetadataAdditionalAttributes("<ArrayOfPropertyMetadataAdditionalAttribute xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <PropertyMetadataAdditionalAttribute AddtibuteName=\"PublicApiMethodForBuilder\">\r\n    <Parameter>\r\n      <Value xsi:type=\"xsd:boolean\">false</Value>\r\n    </Parameter>\r\n  </PropertyMetadataAdditionalAttribute>\r\n</ArrayOfPropertyMetadataAdditionalAttribute>")]
    QueryParameters QueryParameters { get; }
  }
}
