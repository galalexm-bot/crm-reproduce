// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.TypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API.Models;
using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Абстрактный класс описания типа данных</summary>
  [Component]
  public abstract class TypeDescriptor : 
    IMappingTypeDescriptor,
    ITypeDescriptor,
    IXsiType,
    ITypeGenerationInfo,
    IPropertyTypeInfo,
    IDbTypeInfo,
    IFilterableType,
    IFullTextTypeDescriptor,
    ISerializableTypeDescriptor,
    IPropertyCompareTypeDescriptor,
    IFormatTypeDescriptor,
    ICopyableTypeDescriptor,
    ILoggerEnabledComponent,
    IPublicApplicationTypeDescriptor,
    ISortedProperty,
    IEditPropertyTableAvailibility,
    IUseEntityFilterOnly
  {
    [NonSerialized]
    private ILogger _logger;
    private IFullTextPropertyDescriptor propertyDescriptor;
    internal static TypeDescriptor pYoQYTo0ARPoTKxsLhtM;

    /// <summary>Создать мэппинг свойства</summary>
    /// <param name="mappingBuilder">Мэппинг</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    void IMappingTypeDescriptor.CreatePropertyMapping(
      INHibernatePropertiesMapper mappingBuilder,
      ClassMetadata metadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            TypeDescriptor.f3XiH2o00aROaNrmeih4((object) this, (object) mappingBuilder, (object) metadata, (object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Создать мэппинг свойства</summary>
    /// <param name="mappingBuilder">Мэппинг</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    protected virtual void CreatePropertyMapping(
      INHibernatePropertiesMapper mappingBuilder,
      ClassMetadata metadata,
      EntityPropertyMetadata propertyMetadata)
    {
    }

    /// <summary>Логгер</summary>
    [XmlIgnore]
    public ILogger Logger
    {
      get => this._logger;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this._logger = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    protected TypeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Logger = (ILogger) TypeDescriptor.jDKDveo0m9ReQT681Zgi();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Указыват поведение при копировании объекта</summary>
    public virtual CopyAction CopyAction => CopyAction.Default;

    /// <summary>Среда исполнения приложения</summary>
    [XmlIgnore]
    public IRuntimeApplication RuntimeApplication
    {
      get => this.\u003CRuntimeApplication\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CRuntimeApplication\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Uid типа данных или группы типов</summary>
    public abstract Guid Uid { get; }

    /// <summary>Имя типа данных (или группы)</summary>
    public abstract string Name { get; }

    /// <summary>Показывать ли данный элемент в списке типов</summary>
    public virtual bool Visible => true;

    /// <summary>Uid родительской группы типов данных</summary>
    public abstract Guid ParentUid { get; }

    /// <summary>Является ли тип группой</summary>
    public virtual bool IsGroup => false;

    /// <summary>Получить список подтипов</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <returns>Список подтипов</returns>
    public abstract IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata);

    /// <summary>Может ли быть использован в указанном типе метаданных</summary>
    /// <param name="classMetadata"></param>
    /// <returns></returns>
    public virtual bool IsVisibleForMetadata(ClassMetadata classMetadata) => true;

    /// <summary>Uid подтипа данных</summary>
    public virtual Guid SubTypeUid => Guid.Empty;

    /// <summary>
    /// Можно ли использовать тип для идентификаторов сущностей
    /// </summary>
    public virtual bool UseForId => false;

    /// <summary>Можно ли использовать тип для сущностей</summary>
    public abstract bool UseForEntity { get; }

    /// <summary>Может ли тип быть Nullable</summary>
    public abstract bool CanBeNullable { get; }

    /// <summary>
    /// Значение признака Nullable по умолчанию (используется, если CanBeNullable=true)
    /// </summary>
    /// <remarks>
    /// Если возвращает null - то по умолчанию имеет значение !Required
    /// </remarks>
    public abstract bool? DefaultNullableValue { get; }

    /// <summary>Тип класса настроек типа данных</summary>
    public virtual Type SettingsType => (Type) null;

    /// <summary>
    /// Uid типа, определяющего фильтр для данного свойства (по умолчанию - этот же тип)
    /// </summary>
    public virtual Guid GetFilterType(PropertyMetadata propertyMetadata, IMetadata entityMetadata) => TypeDescriptor.cFTaZ5o0yyuIsvWryPXH((object) this);

    /// <summary>
    /// Создать настройки для свойства фильтра, построенного по свойству сущности (должен быть определен у дескриптора типа свойства фильтра)
    /// </summary>
    /// <param name="propertyMetadata">Свойство сущности</param>
    /// <returns></returns>
    public virtual TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propertyMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            if (propertyMetadata.Settings == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 2 : 0;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return (TypeSettings) null;
label_5:
      return ClassSerializationHelper.CloneObjectByXml<TypeSettings>((TypeSettings) TypeDescriptor.DsNT07o0Mwxg5R8uVWNa((object) propertyMetadata));
    }

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public virtual bool IsEmpty(PropertyMetadata propertyMetadata, object val) => val == null;

    /// <summary>
    /// Является ли значение пустым или значением по умолчанию
    /// </summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public virtual bool IsEmptyOrDefault(PropertyMetadata propertyMetadata, object val) => TypeDescriptor.jfbuR8o0JaVVl0kQZpbH((object) this, (object) propertyMetadata, val);

    /// <summary>Есть ли реальная колонка в БД</summary>
    /// <param name="entityMetadata"></param>
    /// <param name="propertyMetadata"></param>
    /// <returns></returns>
    public virtual bool HasRealColumn(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return true;
    }

    /// <summary>Получить ссылку на тип данных для свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">True, если свойство генерируется для фильтра</param>
    /// <returns>Ссылка на тип данных</returns>
    public abstract ISyntaxNode GetPropertyTypeReference(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter);

    /// <summary>Получить выражение инициализации свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Выражение</returns>
    public abstract ISyntaxNode GetPropertyInitExpression(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false);

    /// <summary>
    /// Получить контейнер свойства сущности с данными по умолчанию
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Контейнер</returns>
    public abstract IPropertyDefaultValueContainer GetDefaultContainer(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false);

    /// <summary>Есть ли Getter у свойства</summary>
    public virtual bool HasPropertyGetter => true;

    /// <summary>Есть ли Setter у свойства</summary>
    public virtual bool HasPropertySetter => true;

    /// <summary>Получить список выражений для Getter-а свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="fieldName">Имя поля в классе, соответствующее данному свойству</param>
    /// <returns>Список выражений. Если возвращается null, используются стандартные выражения.</returns>
    public virtual IEnumerable<ISyntaxNode> GetPropertyGetterExpressions(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      string fieldName)
    {
      return (IEnumerable<ISyntaxNode>) null;
    }

    /// <summary>Получить список выражений для Setter-а свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="fieldName">Имя поля в классе, соответствующее данному свойству</param>
    /// <returns>Список выражений. Если возвращается null, используются стандартные выражения.</returns>
    public virtual IEnumerable<ISyntaxNode> GetPropertySetterExpressions(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      string fieldName)
    {
      return (IEnumerable<ISyntaxNode>) null;
    }

    /// <summary>Записать в генерируемый тип дополнительные члены</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Список выражений</returns>
    public virtual IEnumerable<ISyntaxNode> GetAdditionalTypeMembers(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new TypeDescriptor.\u003CGetAdditionalTypeMembers\u003Ed__51(-2);
    }

    /// <summary>Получить отображаемое имя типа у свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Отображаемое имя типа у свойства</returns>
    public abstract string GetPropertyTypeDisplayName(PropertyMetadata propertyMetadata);

    /// <summary>Получить отображаемое имя типа</summary>
    /// <param name="subTypeUid">Уникальные идентификатор подтипа</param>
    /// <returns></returns>
    public virtual string GetTypeDisplayName(Guid subTypeUid) => (string) TypeDescriptor.w4bq2qo09WYgadBlMUqC((object) this);

    /// <summary>Поддерживается ли автоинкремент</summary>
    public virtual bool AutoIncrementSupported => false;

    /// <summary>Получить информацию о требуемых структурах БД</summary>
    /// <param name="entityMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Структуры БД</returns>
    public abstract TypeDbStructures GetDbStructures(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata);

    /// <summary>Применить изменения в структуре БД в updater</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="entityMetadata">Метаданные сущности (не может быть NULL)</param>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <param name="oldPropertyMetadata">Предыдущие метаданные свойства (не может быть NULL)</param>
    /// <returns>True, если есть изменения</returns>
    public abstract bool ApplyDbChanges(
      IDbModelUpdater updater,
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata,
      EntityPropertyMetadata oldPropertyMetadata);

    /// <summary>Применить в критерий NHibernate условия</summary>
    /// <param name="criteria">Критерий</param>
    /// <param name="metadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="value">Значение фильтра</param>
    /// <param name="alias">Алиас для запроса</param>
    public virtual void ApplyFilterValue(
      ICriteria criteria,
      [NotNull] EntityMetadata metadata,
      [NotNull] EntityPropertyMetadata propertyMetadata,
      object value,
      string alias)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (metadata != null)
            {
              if (propertyMetadata != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 2;
                continue;
              }
              goto label_9;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
              continue;
            }
          case 2:
            if (criteria == null)
            {
              num = 4;
              continue;
            }
            goto case 3;
          case 3:
            if (value == null)
            {
              num = 5;
              continue;
            }
            TypeDescriptor.sIAyVwo0jGJEaiTMjIFH((object) criteria, TypeDescriptor.MLC5qZo05lxFcp8O3kKm(!TypeDescriptor.W4mpj0o0ll4ldKd0Qwa6((object) alias) ? TypeDescriptor.MQoBBSo0gpI51K74ZviE(TypeDescriptor.VQ79B9o0duiDSjPyCec8(222162814 ^ 222145916), (object) alias, TypeDescriptor.E7pZfPo0rrUxiTXTu5x1((object) propertyMetadata)) : TypeDescriptor.E7pZfPo0rrUxiTXTu5x1((object) propertyMetadata), value));
            num = 6;
            continue;
          case 4:
            goto label_2;
          case 5:
            goto label_8;
          case 6:
            goto label_15;
          case 7:
            goto label_9;
          default:
            goto label_3;
        }
      }
label_2:
      return;
label_8:
      return;
label_15:
      return;
label_3:
      throw new ArgumentNullException((string) TypeDescriptor.VQ79B9o0duiDSjPyCec8(1819636893 << 3 ^ 1672211926));
label_9:
      throw new ArgumentNullException((string) TypeDescriptor.VQ79B9o0duiDSjPyCec8(1033719030 - 2012070891 ^ -978337703));
    }

    public virtual IFullTextPropertyDescriptor FullTextPropertyDescriptor
    {
      get
      {
        int num = 1;
        IFullTextPropertyDescriptor propertyDescriptor1;
        IFullTextPropertyDescriptor propertyDescriptor2;
        while (true)
        {
          switch (num)
          {
            case 1:
              propertyDescriptor2 = this.propertyDescriptor;
              if (propertyDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_6;
            default:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new NoFullTextPropertyDescriptor();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 0;
              continue;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    /// <summary>Получить описание структуры сериализуемых значений</summary>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Объект с описанием структуры сериализуемых значений</returns>
    public virtual TypeSerializationDescriptor GetSerializeDescriptor(
      [NotNull] ClassMetadata metadata,
      [NotNull] PropertyMetadata propertyMetadata)
    {
      int num1 = 3;
      string description;
      PropertyMetadata propertyMetadata1;
      string descr;
      while (true)
      {
        string str;
        switch (num1)
        {
          case 1:
            str = "";
            break;
          case 2:
            propertyMetadata1 = propertyMetadata;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 4 : 4;
            continue;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 2;
            continue;
          case 4:
            if (metadata == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
              continue;
            }
            if (propertyMetadata1 != null)
            {
              num1 = 7;
              continue;
            }
            goto label_9;
          case 5:
            goto label_5;
          case 6:
            object obj;
            if (TypeDescriptor.W4mpj0o0ll4ldKd0Qwa6(TypeDescriptor.OZhg1Jo0YlBanaSh8178((object) propertyMetadata1)))
              obj = TypeDescriptor.olKqBMo0sy3IorTaF7as(TypeDescriptor.VQ79B9o0duiDSjPyCec8(322893104 - -1992822529 ^ -1979233289), TypeDescriptor.frdaDLo0U7OjXUFdVHO8((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875906965)), TypeDescriptor.VQ79B9o0duiDSjPyCec8(381945751 ^ 1158627804 ^ 1405815179));
            else
              obj = TypeDescriptor.IJAfHco0zwF4LdPUkqrw((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289814558), TypeDescriptor.OZhg1Jo0YlBanaSh8178((object) propertyMetadata1), TypeDescriptor.RqkmY9o0cuIQZknlNuVZ((object) propertyMetadata1), (object) EleWise.ELMA.SR.T((string) TypeDescriptor.VQ79B9o0duiDSjPyCec8(-1120607109 - 305487170 ^ -1426256239), TypeDescriptor.StvIxto0L9vOiS2rvh2f((object) this, (object) propertyMetadata1)));
            descr = (string) obj;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 5;
            continue;
          case 7:
            if (!string.IsNullOrEmpty((string) TypeDescriptor.OZhg1Jo0YlBanaSh8178((object) propertyMetadata1)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 8 : 3;
              continue;
            }
            goto case 1;
          case 8:
            str = EleWise.ELMA.SR.T((string) TypeDescriptor.VQ79B9o0duiDSjPyCec8(-1255365154 ^ 596875508 ^ -1765952442), TypeDescriptor.OZhg1Jo0YlBanaSh8178((object) propertyMetadata1), TypeDescriptor.StvIxto0L9vOiS2rvh2f((object) this, (object) propertyMetadata1));
            break;
          case 9:
            goto label_9;
          default:
            goto label_6;
        }
        description = str;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 6;
      }
label_5:
      return (TypeSerializationDescriptor) TypeDescriptor.R1wwvtomFFNi8ETIG9TV((object) new TypeSerializationDescriptorBuilder().Description(description).Item((Action<TypeSerializationItemDescriptorBuilder>) (i =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              TypeDescriptor.\u003C\u003Ec__DisplayClass62_0.weRfupCVVK2OVjJlPYT8((object) i.Name((string) TypeDescriptor.\u003C\u003Ec__DisplayClass62_0.b5mCR0CVIKMYbmTJiN94((object) propertyMetadata1)), (object) descr);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      })));
label_6:
      throw new ArgumentNullException((string) TypeDescriptor.VQ79B9o0duiDSjPyCec8(~210725948 ^ -210707715));
label_9:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786900710));
    }

    /// <summary>
    /// Получить общее описание структуры значений для сериализации\десериализации произвольного свойства объекта
    /// </summary>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>Объект с описанием структуры значений</returns>
    public virtual TypeSerializationDescriptor GetSerializeDescriptor(Guid subTypeUid)
    {
      int num = 1;
      EntityMetadata metadata;
      PropertyMetadata propertyMetadata1;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadata = new EntityMetadata();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          case 2:
            metadata.Properties.Add(propertyMetadata1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 3 : 0;
            continue;
          case 3:
            goto label_5;
          default:
            PropertyMetadata propertyMetadata2 = new PropertyMetadata();
            propertyMetadata2.Name = (string) TypeDescriptor.olKqBMo0sy3IorTaF7as(TypeDescriptor.VQ79B9o0duiDSjPyCec8(-87337865 ^ -87352399), TypeDescriptor.frdaDLo0U7OjXUFdVHO8(TypeDescriptor.VQ79B9o0duiDSjPyCec8(322893104 - -1992822529 ^ -1979345779)), TypeDescriptor.VQ79B9o0duiDSjPyCec8(322893104 - -1992822529 ^ -1979233295));
            TypeDescriptor.W5cZwGomBwe9EsDlOjmG((object) propertyMetadata2, TypeDescriptor.cFTaZ5o0yyuIsvWryPXH((object) this));
            propertyMetadata2.SubTypeUid = subTypeUid;
            propertyMetadata1 = propertyMetadata2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 0;
            continue;
        }
      }
label_5:
      return this.GetSerializeDescriptor((ClassMetadata) metadata, propertyMetadata1);
    }

    /// <summary>
    /// Получить описание структуры настроек свойств данного типа для сериализации\десериализации
    /// </summary>
    /// <returns>Объект с описанием структуры настроек</returns>
    public virtual TypeSerializationDescriptor GetSettingsSerializeDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!TypeDescriptor.ueWwfqomoWnrlniJZtqY(TypeDescriptor.TymIhMomWF1IXH0NR4XT((object) this), (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (TypeSerializationDescriptor) null;
label_5:
      return (TypeSerializationDescriptor) TypeDescriptor.mdQRm7omhmOJKZvFEp10((object) (TypeSettings) TypeDescriptor.Uotg6aombL28AxO8Zedv(TypeDescriptor.TymIhMomWF1IXH0NR4XT((object) this)));
    }

    /// <summary>
    /// Получить сериализуемые значения для значения свойства данного типа
    /// </summary>
    /// <param name="obj">Объект, содержащий свойство данного типа</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Словарь сериализуемых значений</returns>
    public IDictionary<string, object> Serialize(
      object obj,
      [NotNull] ClassMetadata metadata,
      [NotNull] PropertyMetadata propertyMetadata)
    {
      return this.Serialize(obj, metadata, propertyMetadata, (EntitySerializationSettings) null);
    }

    /// <summary>
    /// Получить сериализуемые значения для значения свойства данного типа
    /// </summary>
    /// <param name="obj">Объект, содержащий свойство данного типа</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Словарь сериализуемых значений</returns>
    public virtual IDictionary<string, object> Serialize(
      object obj,
      [NotNull] ClassMetadata metadata,
      [NotNull] PropertyMetadata propertyMetadata,
      EntitySerializationSettings settings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 873994091));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1642874346));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (PropertyInfo) null || !property.CanRead)
        return (IDictionary<string, object>) null;
      object obj1 = property.GetValue(obj, (object[]) null);
      SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
      Type propertyType = property.PropertyType;
      serializableDictionary[propertyMetadata.Name] = this.SerializeSimple(obj1, propertyType, settings);
      return (IDictionary<string, object>) serializableDictionary;
    }

    public object SerializeSimple(object value, Type valueType) => TypeDescriptor.dgnskRomGsL0qfui1xDT((object) this, value, valueType, (object) null);

    public virtual object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num = 1;
      TypeConverter typeConverter;
      while (true)
      {
        switch (num)
        {
          case 1:
            TypeDescriptor.zcLiaromEpyZdHx3Joni((object) valueType, TypeDescriptor.VQ79B9o0duiDSjPyCec8(277947046 - -1479185048 ^ 1756970114));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          case 2:
            if (!TypeDescriptor.G6Tyl5omQMRBP1R4ZD7r((object) typeConverter, typeof (string)))
            {
              num = 3;
              continue;
            }
            goto label_3;
          case 3:
            goto label_2;
          default:
            typeConverter = (TypeConverter) TypeDescriptor.bA65TAomfCfCfd8UFPQP(valueType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      return (object) null;
label_3:
      return TypeDescriptor.Rtji51omCXXrDmdrO9MH((object) typeConverter, value);
    }

    /// <summary>
    /// Восстановить значение свойства из сериализуемых значений
    /// </summary>
    /// <param name="obj">Объект, содержащий свойство данного типа</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="values">Словарь сериализуемых значений</param>
    public virtual void Deserialize(
      object obj,
      [NotNull] ClassMetadata metadata,
      [NotNull] PropertyMetadata propertyMetadata,
      IDictionary<string, object> values)
    {
      if (obj == null || values == null)
        return;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909163103));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951500620));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (PropertyInfo) null || !property.CanWrite)
        return;
      Type propertyType = property.PropertyType;
      object obj1;
      if (!values.TryGetValue(propertyMetadata.Name, out obj1))
        return;
      try
      {
        object obj2 = this.DeserializeSimple(obj1, propertyType);
        property.SetValue(obj, obj2, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, (object[]) null, (CultureInfo) null);
      }
      catch (Exception ex)
      {
        this.Logger.Debug((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542887057), (object) this.Name, (object) this.GetType(), (object) propertyMetadata.Name, (object) metadata.FullTypeName), ex);
      }
    }

    public virtual object DeserializeSimple(object value, Type deserializeToType)
    {
      int num1 = 3;
      object obj1;
      TypeConverter typeConverter;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          object obj2;
          switch (num2)
          {
            case 1:
              if (obj1 != null)
              {
                num2 = 12;
                continue;
              }
              goto case 14;
            case 2:
              goto label_25;
            case 3:
              if (deserializeToType == (Type) null)
              {
                num2 = 2;
                continue;
              }
              obj1 = value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 1;
              continue;
            case 4:
              goto label_29;
            case 5:
              if (typeConverter.CanConvertFrom(obj1.GetType()))
              {
                num2 = 4;
                continue;
              }
              if (!TypeDescriptor.ueWwfqomoWnrlniJZtqY(deserializeToType, TypeOf<object>.Raw))
              {
                num2 = 7;
                continue;
              }
              goto label_13;
            case 6:
              if (!(obj1 is IFormattable formattable))
              {
                num2 = 8;
                continue;
              }
              obj2 = TypeDescriptor.TalX6momIYh73VV8hUBR((object) formattable, (object) null, (object) CultureInfo.InvariantCulture);
              goto label_33;
            case 7:
              goto label_14;
            case 8:
              obj2 = (object) obj1.ToString();
              goto label_33;
            case 9:
              goto label_27;
            case 10:
              if (TypeDescriptor.GnwWQ3omvjPZhNk39UEi((object) (IDictionary<string, object>) obj1) == 0)
              {
                num2 = 14;
                continue;
              }
              break;
            case 11:
              goto label_13;
            case 12:
              if (obj1 is IDictionary<string, object>)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 5 : 10;
                continue;
              }
              break;
            case 13:
              if (!TypeDescriptor.BSAmfyomuEoxPxTiUAVt((object) typeConverter, obj1.GetType()))
              {
                num2 = 6;
                continue;
              }
              goto case 5;
            case 14:
              if (TypeDescriptor.Jcm0hcom8eYlG1BJ7bP6(deserializeToType))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                continue;
              }
              break;
            default:
              goto label_10;
          }
          if (obj1 != null)
          {
            typeConverter = (TypeConverter) TypeDescriptor.vcSwSXomZEE27OkcqPwq(deserializeToType);
            num2 = 13;
            continue;
          }
          break;
label_33:
          obj1 = obj2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 5 : 0;
        }
        num1 = 9;
      }
label_10:
      return (object) null;
label_13:
      return obj1;
label_14:
      return (object) null;
label_25:
      throw new ArgumentNullException((string) TypeDescriptor.VQ79B9o0duiDSjPyCec8(~210725948 ^ -210707897));
label_27:
      throw new SerializationException(EleWise.ELMA.SR.T((string) TypeDescriptor.VQ79B9o0duiDSjPyCec8(-882126494 ^ -882294342), new object[2]
      {
        null,
        (object) deserializeToType
      }));
label_29:
      return TypeDescriptor.A0e8GuomSIijTIE7YG2I((object) typeConverter, (object) null, TypeDescriptor.jd5BvtomVnDnTeVbQ6n8(), obj1);
    }

    public virtual PropertyCompareData GetCompareData(
      object oldObject,
      object newObject,
      [NotNull] ClassMetadata metadata,
      [NotNull] PropertyMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (metadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            }
            if (propertyMetadata != null)
            {
              num = 3;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          case 3:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_4:
      throw new ArgumentNullException((string) TypeDescriptor.VQ79B9o0duiDSjPyCec8(1505778440 - 1981636111 ^ -475875925));
label_5:
      PropertyCompareData compareData = new PropertyCompareData(TypeDescriptor.ebOiAtomivuRTjy2IYWa((object) propertyMetadata), TypeDescriptor.ebOiAtomivuRTjy2IYWa((object) metadata));
      IDictionary<string, object> dictionary1 = this.Serialize(oldObject, metadata, propertyMetadata);
      IDictionary<string, object> dictionary2 = this.Serialize(newObject, metadata, propertyMetadata);
      TypeDescriptor.jdLmMEomq5AFRjVof8ld((object) compareData, TypeDescriptor.bRe5OVomRWWvCUarrZS6((object) dictionary1));
      TypeDescriptor.DRU9EDomKcEwN3WmeDvv((object) compareData, TypeDescriptor.bRe5OVomRWWvCUarrZS6((object) dictionary2));
      return compareData;
label_6:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461643943));
    }

    public virtual void SetCompareData(
      object oldObject,
      object newObject,
      [NotNull] ClassMetadata metadata,
      [NotNull] PropertyMetadata propertyMetadata,
      PropertyCompareData compareData)
    {
      int num = 9;
      IDictionary<string, object> values1;
      IDictionary<string, object> values2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
            if (!TypeDescriptor.UA1eo6omTJusAsd9YU5Z(TypeDescriptor.Q2qisFomXCG0fgvv0PkH((object) compareData), TypeDescriptor.ebOiAtomivuRTjy2IYWa((object) propertyMetadata)))
            {
              if (TypeDescriptor.c3Cxa8omkYAt5onwrkN3((object) compareData) == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 12 : 6;
                continue;
              }
              goto case 13;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
              continue;
            }
          case 2:
            goto label_9;
          case 3:
          case 12:
            if (TypeDescriptor.T1WdD4omO11HkeLO2NI3((object) compareData) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 2 : 2;
              continue;
            }
            goto case 14;
          case 4:
            goto label_14;
          case 5:
            this.Deserialize(newObject, metadata, propertyMetadata, values2);
            num = 10;
            continue;
          case 6:
            this.Deserialize(oldObject, metadata, propertyMetadata, values1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 3;
            continue;
          case 7:
            goto label_7;
          case 8:
            if (propertyMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 11 : 3;
              continue;
            }
            if (compareData == null)
            {
              num = 7;
              continue;
            }
            goto case 1;
          case 9:
            if (metadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 8;
              continue;
            }
            goto label_14;
          case 10:
            goto label_2;
          case 11:
            goto label_18;
          case 13:
            values1 = (IDictionary<string, object>) TypeDescriptor.vL88leomnG6TnPmuZarl((object) compareData.OldPropertyData);
            num = 6;
            continue;
          case 14:
            values2 = (IDictionary<string, object>) ClassSerializationHelper.DeserializeObject(compareData.NewPropertyData);
            num = 5;
            continue;
          default:
            goto label_6;
        }
      }
label_8:
      return;
label_9:
      return;
label_7:
      return;
label_2:
      return;
label_6:
      return;
label_14:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439596808));
label_18:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70021537));
    }

    /// <summary>Форматировать значение</summary>
    /// <param name="value">Значение</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Сформатированное значение</returns>
    public virtual string FormatValue(object value, PropertyMetadata propertyMetadata) => this.FormatValue(value, propertyMetadata == null ? (TypeSettings) null : propertyMetadata.Settings);

    /// <summary>Форматировать значение</summary>
    /// <param name="value">Значение</param>
    /// <param name="settings">Настройки свойства</param>
    /// <returns>Сформатированное значение</returns>
    public virtual string FormatValue(object value, TypeSettings settings)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return string.Empty;
label_5:
      return value.ToString();
    }

    /// <summary>Скопировать значения свойства</summary>
    /// <param name="obj">Объект из которого нужно копировать</param>
    /// <param name="target">Объект, в который идет копирование</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    public virtual void Copy(
      object obj,
      object target,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata)
    {
      int num = 8;
      PropertyInfo propertyCached;
      object obj1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
            if (target != null)
            {
              if (metadata != null)
              {
                if (propertyMetadata == null)
                {
                  num = 11;
                  continue;
                }
                propertyCached = obj.GetType().GetPropertyCached((string) TypeDescriptor.E7pZfPo0rrUxiTXTu5x1((object) propertyMetadata));
                num = 5;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          case 2:
            obj1 = TypeDescriptor.jEBu6womPRWCsjOAOBXR((object) propertyCached, obj, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 11 : 14;
            continue;
          case 3:
            goto label_3;
          case 4:
            goto label_20;
          case 5:
            if (TypeDescriptor.nvMj1yom22OUERfkYoWo((object) propertyCached, (object) null))
            {
              num = 12;
              continue;
            }
            goto case 9;
          case 6:
            if (!TypeDescriptor.yUPOqaom1KuGfj57ZDAJ((object) propertyCached))
            {
              num = 4;
              continue;
            }
            TypeDescriptor.S2ETo3omNN10ZO3rB1x3((object) propertyCached, target, obj1, (object) null);
            num = 16;
            continue;
          case 7:
            goto label_24;
          case 8:
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 7;
              continue;
            }
            goto case 1;
          case 9:
            if (TypeDescriptor.cIC9jpomevFgFYhEdMEY((object) propertyCached))
            {
              num = 2;
              continue;
            }
            goto label_9;
          case 10:
            goto label_32;
          case 11:
            goto label_6;
          case 12:
            goto label_10;
          case 13:
            if (TypeDescriptor.nvMj1yom22OUERfkYoWo((object) propertyCached, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 10 : 6;
              continue;
            }
            goto case 6;
          case 14:
            propertyCached = target.GetType().GetPropertyCached((string) TypeDescriptor.E7pZfPo0rrUxiTXTu5x1((object) propertyMetadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 11 : 13;
            continue;
          case 15:
            goto label_2;
          case 16:
            goto label_27;
          default:
            goto label_19;
        }
      }
label_8:
      return;
label_20:
      return;
label_24:
      return;
label_32:
      return;
label_10:
      return;
label_2:
      return;
label_27:
      return;
label_19:
      return;
label_3:
      throw new ArgumentNullException((string) TypeDescriptor.VQ79B9o0duiDSjPyCec8(-1380439818 << 3 ^ 1841368718));
label_6:
      throw new ArgumentNullException((string) TypeDescriptor.VQ79B9o0duiDSjPyCec8(-643786247 ^ -643772245));
label_9:;
    }

    /// <inheritdoc />
    public virtual bool UseEntityFilterOnly => false;

    public virtual IComparer GetComparer(
      Type sourceType,
      LambdaExpression propertyFunc,
      ListSortDirection order)
    {
      return (IComparer) null;
    }

    /// <summary>Компаратор для свойства</summary>
    /// <typeparam name="TSource"></typeparam>
    /// <param name="propertyFunc"></param>
    /// <param name="order"></param>
    /// <returns></returns>
    public virtual IComparer<TSource> GetComparer<TSource, TKey>(
      Func<TSource, TKey> propertyFunc,
      ListSortDirection order)
    {
      if (propertyFunc == null)
        return (IComparer<TSource>) null;
      return (IComparer<TSource>) this.GetComparer(typeof (TSource), (LambdaExpression) (source => propertyFunc(source)), order);
    }

    /// <summary>Поддерживает сортировку</summary>
    /// <returns></returns>
    public virtual bool IsSupportSort() => false;

    /// <summary>Доступен ли в режиме "Только для чтения"</summary>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>True, если доступен</returns>
    public virtual bool IsPublicApplicationDisplayEnabled(Guid subTypeUid)
    {
      int num1 = 2;
      TypeDescriptor typeDescriptor;
      Guid subTypeUid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            typeDescriptor = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 3 : 3;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
            continue;
          case 3:
            subTypeUid1 = subTypeUid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return this.GetTypePublicApplicationProviders().Any<ITypePublicApplicationProvider>((Func<ITypePublicApplicationProvider, bool>) (p =>
      {
        int num2 = 1;
        bool? nullable;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              nullable = p.IsPublicApplicationDisplayEnabled(TypeDescriptor.\u003C\u003Ec__DisplayClass81_0.LTFlOfCVk0k9Og1xWTKE((object) typeDescriptor), subTypeUid1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            case 3:
              goto label_3;
            default:
              if (!nullable.HasValue)
              {
                num2 = 3;
                continue;
              }
              goto label_2;
          }
        }
label_2:
        return nullable.Value;
label_3:
        return false;
      }));
    }

    /// <summary>Доступен ли в режиме редактирования</summary>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>True, если доступен</returns>
    public virtual bool IsPublicApplicationEditorEnabled(Guid subTypeUid)
    {
      int num1 = 1;
      TypeDescriptor typeDescriptor;
      Guid subTypeUid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            subTypeUid1 = subTypeUid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 2;
            continue;
          default:
            typeDescriptor = this;
            num1 = 3;
            continue;
        }
      }
label_4:
      return this.GetTypePublicApplicationProviders().Any<ITypePublicApplicationProvider>((Func<ITypePublicApplicationProvider, bool>) (p =>
      {
        int num2 = 1;
        bool? nullable;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              nullable = p.IsPublicApplicationEditorEnabled(TypeDescriptor.\u003C\u003Ec__DisplayClass82_0.HBEoDMCVPyXw3Ixp5TUE((object) typeDescriptor), subTypeUid1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              if (nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 2;
                continue;
              }
              goto label_3;
          }
        }
label_2:
        return nullable.Value;
label_3:
        return false;
      }));
    }

    /// <summary>
    /// Определить доступность отображения свойства во внешних приложениях
    /// </summary>
    /// <param name="classMetadata">Метаданные класса, в котором содержится свойство</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="viewItem">Параметры отображения свойства</param>
    /// <param name="parentPropertyName">Имя родительского свойства</param>
    /// <param name="errors">Текущий спсиок ошибок</param>
    public virtual void CheckPublicApplicationCompatibility(
      [NotNull] ClassMetadata classMetadata,
      [NotNull] PropertyMetadata propertyMetadata,
      PropertyViewItem viewItem,
      string parentPropertyName,
      [NotNull] List<IPublicApplicationCompatibilityError> errors)
    {
      if (classMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420873790));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889478382));
      if (errors == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408788404));
      System.Action action = (System.Action) (() =>
      {
        int num1 = 1;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_2;
            case 1:
              this.GetTypePublicApplicationProviders().ForEach<ITypePublicApplicationProvider>((Action<ITypePublicApplicationProvider>) (p =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      p.CheckPublicApplicationCompatibility(classMetadata, propertyMetadata, viewItem, parentPropertyName, errors);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      });
      bool flag1 = viewItem.IsReadOnly();
      bool flag2 = this.IsPublicApplicationDisplayEnabled(propertyMetadata.SubTypeUid);
      bool flag3 = this.IsPublicApplicationDisplayEnabled(propertyMetadata.SubTypeUid);
      if (flag1 & flag2 || !flag1 & flag3)
      {
        action();
      }
      else
      {
        bool? isReadOnly = flag2 & flag3 ? new bool?() : new bool?(flag2);
        string typeCode = this.Uid.ToString() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138157566) + (object) this.SubTypeUid + (!isReadOnly.HasValue ? (object) "" : (isReadOnly.Value ? (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44986939) : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333633824)));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        PublicAppTypeCompatibilityError compatibilityError1 = errors.OfType<PublicAppTypeCompatibilityError>().FirstOrDefault<PublicAppTypeCompatibilityError>((Func<PublicAppTypeCompatibilityError, bool>) (e => TypeDescriptor.\u003C\u003Ec__DisplayClass83_0.gMQyWTCVDZ2Ir7WPZD9x(TypeDescriptor.\u003C\u003Ec__DisplayClass83_0.btVYrqCVaMRGrtCZu4nn((object) e), (object) typeCode)));
        string str = (!string.IsNullOrEmpty(parentPropertyName) ? parentPropertyName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178211832) : "") + propertyMetadata.DisplayName;
        if (compatibilityError1 != null)
        {
          compatibilityError1.PropertyNames.Add(str);
        }
        else
        {
          PublicAppTypeCompatibilityError compatibilityError2 = new PublicAppTypeCompatibilityError(typeCode, this.GetPropertyTypeDisplayName(propertyMetadata), isReadOnly, new string[1]
          {
            str
          });
          errors.Add((IPublicApplicationCompatibilityError) compatibilityError2);
        }
        action();
      }
    }

    private IEnumerable<ITypePublicApplicationProvider> GetTypePublicApplicationProviders() => ComponentManager.Current.GetExtensionPoints<ITypePublicApplicationProvider>(true);

    /// <summary>
    /// Разрешено ли использовать данный тип в блоке на редактирование как таблица
    /// </summary>
    public virtual bool IsAvailibleEditPropertyInTable => false;

    /// <summary>ToString</summary>
    /// <returns>Возвращает имя типа</returns>
    public override string ToString() => (string) TypeDescriptor.w4bq2qo09WYgadBlMUqC((object) this);

    internal static void f3XiH2o00aROaNrmeih4([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((TypeDescriptor) obj0).CreatePropertyMapping((INHibernatePropertiesMapper) obj1, (ClassMetadata) obj2, (EntityPropertyMetadata) obj3);

    internal static bool vHvybbo07OBZpgpPXYaX() => TypeDescriptor.pYoQYTo0ARPoTKxsLhtM == null;

    internal static TypeDescriptor Vx0nioo0xLa5r96EnUOp() => TypeDescriptor.pYoQYTo0ARPoTKxsLhtM;

    internal static object jDKDveo0m9ReQT681Zgi() => (object) NullLogger.Instance;

    internal static Guid cFTaZ5o0yyuIsvWryPXH([In] object obj0) => ((TypeDescriptor) obj0).Uid;

    internal static object DsNT07o0Mwxg5R8uVWNa([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static bool jfbuR8o0JaVVl0kQZpbH([In] object obj0, [In] object obj1, [In] object obj2) => ((TypeDescriptor) obj0).IsEmpty((PropertyMetadata) obj1, obj2);

    internal static object w4bq2qo09WYgadBlMUqC([In] object obj0) => (object) ((TypeDescriptor) obj0).Name;

    internal static object VQ79B9o0duiDSjPyCec8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool W4mpj0o0ll4ldKd0Qwa6([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object E7pZfPo0rrUxiTXTu5x1([In] object obj0) => (object) ((EleWise.ELMA.Model.Metadata.NamedMetadata) obj0).Name;

    internal static object MQoBBSo0gpI51K74ZviE([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object MLC5qZo05lxFcp8O3kKm([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object sIAyVwo0jGJEaiTMjIFH([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object OZhg1Jo0YlBanaSh8178([In] object obj0) => (object) ((EleWise.ELMA.Model.Metadata.NamedMetadata) obj0).DisplayName;

    internal static object StvIxto0L9vOiS2rvh2f([In] object obj0, [In] object obj1) => (object) ((TypeDescriptor) obj0).GetPropertyTypeDisplayName((PropertyMetadata) obj1);

    internal static object frdaDLo0U7OjXUFdVHO8([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object olKqBMo0sy3IorTaF7as([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object RqkmY9o0cuIQZknlNuVZ([In] object obj0) => (object) ((EleWise.ELMA.Model.Metadata.NamedMetadata) obj0).Description;

    internal static object IJAfHco0zwF4LdPUkqrw(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static object R1wwvtomFFNi8ETIG9TV([In] object obj0) => (object) ((TypeSerializationDescriptorBuilder) obj0).Descriptor;

    internal static void W5cZwGomBwe9EsDlOjmG([In] object obj0, Guid value) => ((PropertyMetadata) obj0).TypeUid = value;

    internal static Type TymIhMomWF1IXH0NR4XT([In] object obj0) => ((TypeDescriptor) obj0).SettingsType;

    internal static bool ueWwfqomoWnrlniJZtqY([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object Uotg6aombL28AxO8Zedv([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object mdQRm7omhmOJKZvFEp10([In] object obj0) => (object) ((TypeSettings) obj0).GetSerializationDescriptor();

    internal static object dgnskRomGsL0qfui1xDT(
      [In] object obj0,
      [In] object obj1,
      Type valueType,
      [In] object obj3)
    {
      return ((TypeDescriptor) obj0).SerializeSimple(obj1, valueType, (EntitySerializationSettings) obj3);
    }

    internal static void zcLiaromEpyZdHx3Joni([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object bA65TAomfCfCfd8UFPQP(Type type) => (object) ElmaTypeDescriptorHelper.GetConverter(type);

    internal static bool G6Tyl5omQMRBP1R4ZD7r([In] object obj0, [In] Type obj1) => ((TypeConverter) obj0).CanConvertTo(obj1);

    internal static object Rtji51omCXXrDmdrO9MH([In] object obj0, [In] object obj1) => (object) ((TypeConverter) obj0).ConvertToInvariantString(obj1);

    internal static int GnwWQ3omvjPZhNk39UEi([In] object obj0) => ((ICollection<KeyValuePair<string, object>>) obj0).Count;

    internal static bool Jcm0hcom8eYlG1BJ7bP6(Type type) => type.IsAssignableFromNull();

    internal static object vcSwSXomZEE27OkcqPwq([In] Type obj0) => (object) System.ComponentModel.TypeDescriptor.GetConverter(obj0);

    internal static bool BSAmfyomuEoxPxTiUAVt([In] object obj0, [In] Type obj1) => ((TypeConverter) obj0).CanConvertFrom(obj1);

    internal static object TalX6momIYh73VV8hUBR([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IFormattable) obj0).ToString((string) obj1, (IFormatProvider) obj2);

    internal static object jd5BvtomVnDnTeVbQ6n8() => (object) CultureInfo.InvariantCulture;

    internal static object A0e8GuomSIijTIE7YG2I(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((TypeConverter) obj0).ConvertFrom((ITypeDescriptorContext) obj1, (CultureInfo) obj2, obj3);
    }

    internal static Guid ebOiAtomivuRTjy2IYWa([In] object obj0) => ((EleWise.ELMA.Model.Metadata.AbstractMetadata) obj0).Uid;

    internal static object bRe5OVomRWWvCUarrZS6([In] object obj0) => (object) ClassSerializationHelper.SerializeObject(obj0);

    internal static void jdLmMEomq5AFRjVof8ld([In] object obj0, [In] object obj1) => ((PropertyCompareData) obj0).OldPropertyData = (byte[]) obj1;

    internal static void DRU9EDomKcEwN3WmeDvv([In] object obj0, [In] object obj1) => ((PropertyCompareData) obj0).NewPropertyData = (byte[]) obj1;

    internal static Guid Q2qisFomXCG0fgvv0PkH([In] object obj0) => ((PropertyCompareData) obj0).PropertyGuid;

    internal static bool UA1eo6omTJusAsd9YU5Z([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object c3Cxa8omkYAt5onwrkN3([In] object obj0) => (object) ((PropertyCompareData) obj0).OldPropertyData;

    internal static object vL88leomnG6TnPmuZarl([In] object obj0) => ClassSerializationHelper.DeserializeObject((byte[]) obj0);

    internal static object T1WdD4omO11HkeLO2NI3([In] object obj0) => (object) ((PropertyCompareData) obj0).NewPropertyData;

    internal static bool nvMj1yom22OUERfkYoWo([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static bool cIC9jpomevFgFYhEdMEY([In] object obj0) => ((PropertyInfo) obj0).CanRead;

    internal static object jEBu6womPRWCsjOAOBXR([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static bool yUPOqaom1KuGfj57ZDAJ([In] object obj0) => ((PropertyInfo) obj0).CanWrite;

    internal static void S2ETo3omNN10ZO3rB1x3([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);
  }
}
