// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.SimpleTypeDescriptor`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.UserTypes;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Абстрактный класс типа данных, имеющего простые настройки
  /// </summary>
  /// <typeparam name="T">Тип данных</typeparam>
  public abstract class SimpleTypeDescriptor<T> : TypeDescriptor<T>, IMappingTypeDescriptor
  {
    private Dictionary<Type, Type> conventionTypesMap;
    private static object yh4oCboxsafypbj7Z47y;

    private Type CreateUserTypeInstance(Type genericArgument)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!genericArgument.IsClass)
            {
              num = 3;
              continue;
            }
            goto case 2;
          case 2:
            if (!(Activator.CreateInstance(genericArgument) is IUserType instance))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          case 4:
            if (!genericArgument.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 1;
              continue;
            }
            goto label_11;
          case 5:
            if (genericArgument.GetInterface(typeof (IUserType).FullName, true) != (Type) null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 4 : 0;
              continue;
            }
            goto label_11;
          case 6:
            goto label_10;
          default:
            goto label_11;
        }
      }
label_10:
      return instance.ReturnedType;
label_11:
      return genericArgument;
    }

    private void ProcessConventionType(Type conventionType)
    {
      int num = 4;
      while (true)
      {
        Type baseType;
        Type genericTypeDefinition;
        Type userTypeInstance1;
        Type userTypeInstance2;
        Type genericArgument1;
        Type genericArgument2;
        switch (num)
        {
          case 1:
            if (userTypeInstance1 != (Type) null)
            {
              num = 11;
              continue;
            }
            goto case 13;
          case 2:
            userTypeInstance2 = this.CreateUserTypeInstance(genericArgument1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 4 : 9;
            continue;
          case 3:
            if (baseType != (Type) null)
            {
              num = 10;
              continue;
            }
            goto label_32;
          case 4:
            baseType = conventionType.BaseType;
            num = 3;
            continue;
          case 5:
          case 21:
            this.conventionTypesMap.Add(userTypeInstance1, typeof (XmlSerializableType<>).MakeGenericType(genericArgument2));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 16 : 16;
            continue;
          case 6:
            goto label_33;
          case 7:
            this.conventionTypesMap[userTypeInstance2] = (Type) null;
            num = 23;
            continue;
          case 8:
            if (genericTypeDefinition == typeof (XmlSerializableTypeConvention<>))
            {
              num = 24;
              continue;
            }
            goto case 13;
          case 9:
            if (!(userTypeInstance2 != (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 12 : 22;
              continue;
            }
            goto case 17;
          case 10:
            if (!baseType.IsGenericType)
            {
              num = 6;
              continue;
            }
            goto case 15;
          case 11:
            if (!this.conventionTypesMap.ContainsKey(userTypeInstance1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 5 : 4;
              continue;
            }
            goto case 19;
          case 12:
            this.conventionTypesMap.Add(userTypeInstance2, genericArgument1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 18 : 8;
            continue;
          case 13:
          case 16:
            if (!(genericTypeDefinition == typeof (AutoRegisterUserTypeConvention<>)))
            {
              num = 14;
              continue;
            }
            break;
          case 14:
            goto label_25;
          case 15:
            genericTypeDefinition = baseType.GetGenericTypeDefinition();
            num = 8;
            continue;
          case 17:
            if (!this.conventionTypesMap.ContainsKey(userTypeInstance2))
            {
              num = 12;
              continue;
            }
            goto case 7;
          case 18:
            goto label_20;
          case 19:
            this.conventionTypesMap[userTypeInstance1] = (Type) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 8 : 13;
            continue;
          case 20:
            userTypeInstance1 = this.CreateUserTypeInstance(genericArgument2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
            continue;
          case 22:
            goto label_10;
          case 23:
            goto label_23;
          case 24:
            genericArgument2 = baseType.GetGenericArguments()[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 20 : 3;
            continue;
        }
        genericArgument1 = baseType.GetGenericArguments()[0];
        num = 2;
      }
label_33:
      return;
label_25:
      return;
label_20:
      return;
label_10:
      return;
label_23:
      return;
label_32:;
    }

    /// <summary>
    /// Получить класс используемый NHivernate вместо класса свойства
    /// </summary>
    /// <param name="propertyType">Тип свойства</param>
    private Type GetAutoRegisterType(Type propertyType)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        IEnumerator<Type> enumerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.conventionTypesMap == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
label_21:
              if (this.conventionTypesMap.ContainsKey(propertyType))
              {
                num2 = 6;
                continue;
              }
              goto label_6;
            case 3:
              goto label_6;
            case 4:
              try
              {
label_13:
                if (enumerator.MoveNext())
                  goto label_11;
                else
                  goto label_14;
label_9:
                Type current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      this.ProcessConventionType(current);
                      num3 = 2;
                      continue;
                    case 2:
                      goto label_13;
                    case 3:
                      goto label_21;
                    default:
                      goto label_11;
                  }
                }
label_11:
                current = enumerator.Current;
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
                {
                  num3 = 0;
                  goto label_9;
                }
                else
                  goto label_9;
label_14:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 3 : 0;
                goto label_9;
              }
              finally
              {
                int num4;
                if (enumerator == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                else
                  goto label_18;
label_17:
                switch (num4)
                {
                  case 2:
                    break;
                  default:
                }
label_18:
                enumerator.Dispose();
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
                {
                  num4 = 1;
                  goto label_17;
                }
                else
                  goto label_17;
              }
            case 5:
              goto label_23;
            case 6:
              goto label_7;
            default:
              this.conventionTypesMap = new Dictionary<Type, Type>();
              num2 = 5;
              continue;
          }
        }
label_23:
        enumerator = ComponentManager.Current.GetExtensionPointTypes<IAutoRegisterConvention>().Where<Type>((Func<Type, bool>) (t =>
        {
          int num5 = 1;
          while (true)
          {
            switch (num5)
            {
              case 1:
                if (!t.IsClass)
                {
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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
          return !t.IsAbstract;
label_5:
          return false;
        })).GetEnumerator();
        num1 = 4;
      }
label_6:
      return (Type) null;
label_7:
      return this.conventionTypesMap[propertyType];
    }

    /// <summary>Создать мэппинг свойства</summary>
    /// <param name="mappingBuilder">Мэппинг</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    protected override void CreatePropertyMapping(
      INHibernatePropertiesMapper mappingBuilder,
      ClassMetadata metadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 1;
      while (true)
      {
        bool notNull;
        string formula;
        int num2;
        int num3;
        string str;
        SimpleTypeDescriptor<T> simpleTypeDescriptor;
        EntityPropertyMetadata propertyMetadata1;
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
            continue;
          case 2:
            if (propertyMetadata1 == null)
            {
              num1 = 6;
              continue;
            }
            goto case 4;
          case 3:
            Locator.GetService<IRuntimeApplication>();
            num1 = 11;
            continue;
          case 4:
            num2 = propertyMetadata1.Nullable ? 1 : 0;
            goto label_23;
          case 5:
          case 6:
            num2 = 0;
            goto label_23;
          case 7:
            str = string.Empty;
            break;
          case 8:
            mappingBuilder.Property(propertyMetadata1.Name, propertyMetadata1.SimpleTypeSettings.FieldName, (Action<INHibernatePropertyTypeMapper>) (mapper =>
            {
              int num4 = 6;
              while (true)
              {
                Type autoRegisterType;
                switch (num4)
                {
                  case 1:
                    if (!(autoRegisterType.Assembly != (Assembly) null))
                    {
                      num4 = 3;
                      continue;
                    }
                    break;
                  case 2:
                  case 3:
                    simpleTypeDescriptor.ExtendSimplePropertyMapping(mapper, propertyMetadata1);
                    num4 = 4;
                    continue;
                  case 4:
                    goto label_2;
                  case 5:
                    if (autoRegisterType != (Type) null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
                      continue;
                    }
                    goto case 2;
                  case 6:
                    autoRegisterType = simpleTypeDescriptor.GetAutoRegisterType(typeof (T));
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 5;
                    continue;
                }
                mapper.Type(autoRegisterType);
                num4 = 2;
              }
label_2:;
            }), notNull, formula);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 14 : 2;
            continue;
          case 9:
label_13:
            num3 = !typeof (T).IsEnum ? 1 : 0;
            goto label_26;
          case 10:
            if (propertyMetadata1.SimpleTypeSettings != null)
            {
              num1 = 3;
              continue;
            }
            goto label_6;
          case 11:
            if (propertyMetadata1.CalculateType != PropertyCalculateType.SQLFormula)
            {
              num1 = 7;
              continue;
            }
            str = propertyMetadata1.SQLFormula;
            break;
          case 12:
            if (!this.CanBeNullable)
            {
              num1 = 5;
              continue;
            }
            goto case 2;
          case 13:
            propertyMetadata1 = propertyMetadata;
            num1 = 10;
            continue;
          case 14:
            goto label_9;
          case 15:
            num3 = 1;
            goto label_26;
          default:
            simpleTypeDescriptor = this;
            num1 = 13;
            continue;
        }
        formula = str;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 4 : 12;
        continue;
label_23:
        if (num2 == 0)
        {
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 9 : 15;
          continue;
        }
        goto label_13;
label_26:
        notNull = num3 != 0;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 8 : 2;
      }
label_9:
      return;
label_6:;
    }

    /// <summary>Расширить мэппинг простого свойства</summary>
    /// <param name="mapper">Мэппинг</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    protected virtual void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        IMainDatabaseProvider databaseProvider;
        switch (num)
        {
          case 1:
            IRuntimeApplication runtimeApplication = this.RuntimeApplication;
            if (runtimeApplication == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            }
            databaseProvider = runtimeApplication.MainProvider;
            break;
          case 2:
            goto label_5;
          case 3:
            nhProvider.CustomMapping(mapper, (PropertyMetadata) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 2 : 2;
            continue;
          default:
            databaseProvider = (IMainDatabaseProvider) null;
            break;
        }
        if (databaseProvider is NHProvider nhProvider)
          num = 3;
        else
          goto label_2;
      }
label_5:
      return;
label_2:;
    }

    /// <summary>Группа простых типов</summary>
    public override Guid ParentUid => SimpleTypesDescriptor.UID;

    /// <summary>Можно ли использовать тип для сущностей</summary>
    public override bool UseForEntity => true;

    /// <summary>Может ли тип быть Nullable</summary>
    public override bool CanBeNullable => typeof (T).CanBeNullableType();

    /// <summary>
    /// Значение признака Nullable по умолчанию (используется, если CanBeNullable=true)
    /// </summary>
    public override bool? DefaultNullableValue => new bool?();

    /// <summary>Получить список подтипов</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <returns>Список подтипов</returns>
    public override IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata) => (IEnumerable<ITypeDescriptor>) null;

    /// <summary>Получить ссылку на тип данных для свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">True, если свойство генерируется для фильтра</param>
    /// <returns>Ссылка на тип данных</returns>
    public override ISyntaxNode GetPropertyTypeReference(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!propertyMetadata.Nullable)
            {
              num = 4;
              continue;
            }
            goto label_8;
          case 2:
            if (propertyMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
              continue;
            }
            goto label_9;
          case 3:
            if (this.CanBeNullable)
            {
              num = 2;
              continue;
            }
            goto label_9;
          case 4:
            goto label_9;
          default:
            goto label_8;
        }
      }
label_8:
      return typeof (T).NullableType().CreateTypeSyntax();
label_9:
      return typeof (T).CreateTypeSyntax();
    }

    /// <summary>Получить выражение инициализации свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Выражение</returns>
    public override ISyntaxNode GetPropertyInitExpression(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      return (ISyntaxNode) null;
    }

    /// <summary>
    /// Получить контейнер свойства сущности с данными по умолчанию
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Контейнер</returns>
    public override IPropertyDefaultValueContainer GetDefaultContainer(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      return (IPropertyDefaultValueContainer) new PropertyAnyTypeValueContainer((IPropertyMetadata) propertyMetadata);
    }

    /// <summary>Получить отображаемое имя типа у свойства</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Отображаемое имя типа у свойства</returns>
    public override string GetPropertyTypeDisplayName(PropertyMetadata propertyMetadata) => this.Name;

    /// <summary>Получить информацию о требуемых структурах БД</summary>
    /// <param name="entityMetadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Структуры БД</returns>
    public override TypeDbStructures GetDbStructures(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 3;
      TypeDbStructures dbStructures;
      while (true)
      {
        int num2 = num1;
        SimpleTypeSettings settings;
        ColumnType dbColumnType;
        object dbDefaultValue;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.CanBeNullable)
              {
                num2 = 5;
                continue;
              }
              goto label_16;
            case 2:
              Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112825024));
              num2 = 13;
              continue;
            case 3:
              goto label_7;
            case 4:
              dbStructures.Columns.Add(new Column(settings.FieldName, dbColumnType));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
              continue;
            case 5:
              if (propertyMetadata.Nullable)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 14 : 11;
                continue;
              }
              goto case 11;
            case 6:
              dbColumnType = this.GetDbColumnType(entityMetadata, propertyMetadata);
              num2 = 4;
              continue;
            case 8:
              settings = (SimpleTypeSettings) propertyMetadata.Settings;
              num2 = 12;
              continue;
            case 9:
              if (dbDefaultValue == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
                continue;
              }
              goto case 10;
            case 10:
              dbStructures.Updates.Add(Tuple.Create<string, object>(settings.FieldName, dbDefaultValue));
              num2 = 7;
              continue;
            case 11:
              dbDefaultValue = this.GetDbDefaultValue(propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 9 : 3;
              continue;
            case 12:
              dbStructures = new TypeDbStructures();
              num2 = 15;
              continue;
            case 13:
              Contract.CheckArgument(propertyMetadata.Settings is SimpleTypeSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -671958759));
              num2 = 8;
              continue;
            case 15:
              goto label_13;
            default:
              goto label_16;
          }
        }
label_7:
        Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218478340));
        num1 = 2;
        continue;
label_13:
        if (propertyMetadata.CalculateType != PropertyCalculateType.SQLFormula)
          num1 = 6;
        else
          break;
      }
label_16:
      return dbStructures;
    }

    /// <summary>Применить изменения в структуре БД в updater</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="entityMetadata">Метаданные сущности (не может быть NULL)</param>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <param name="oldPropertyMetadata">Предыдущие метаданные свойства (не может быть NULL)</param>
    /// <returns>True, если есть изменения</returns>
    public override bool ApplyDbChanges(
      IDbModelUpdater updater,
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata,
      EntityPropertyMetadata oldPropertyMetadata)
    {
      int num1 = 11;
      while (true)
      {
        int num2 = num1;
        SimpleTypeSettings settings1;
        SimpleTypeSettings settings2;
        ColumnType dbColumnType;
        Column column;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              settings1 = (SimpleTypeSettings) oldPropertyMetadata.Settings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 6 : 3;
              continue;
            case 3:
              updater.TablesCreatedActions.Add((IDbAction) new DbCreateColumnAction(updater.Transform, propertyMetadata.GetTableName(entityMetadata), column));
              num2 = 13;
              continue;
            case 4:
              goto label_12;
            case 5:
              settings2 = (SimpleTypeSettings) propertyMetadata.Settings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 2;
              continue;
            case 6:
              if (!string.IsNullOrEmpty(settings2.FieldName))
              {
                num2 = 14;
                continue;
              }
              goto label_12;
            case 7:
              Contract.ArgumentNotNull((object) propertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712374881));
              num2 = 9;
              continue;
            case 8:
              dbColumnType = this.GetDbColumnType(entityMetadata, propertyMetadata);
              num2 = 19;
              continue;
            case 9:
              Contract.CheckArgument(propertyMetadata.Settings is SimpleTypeSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978639152));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 16 : 3;
              continue;
            case 10:
              goto label_17;
            case 11:
              Contract.ArgumentNotNull((object) updater, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575999900));
              num2 = 10;
              continue;
            case 12:
              goto label_6;
            case 13:
              goto label_9;
            case 14:
              if (!string.IsNullOrEmpty(settings1.FieldName))
              {
                num2 = 18;
                continue;
              }
              goto case 8;
            case 15:
              Contract.ArgumentNotNull((object) oldPropertyMetadata.Settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597117986));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
              continue;
            case 16:
              Contract.ArgumentNotNull((object) oldPropertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882262264));
              num2 = 15;
              continue;
            case 17:
              updater.TablesCreatedActions.Add((IDbAction) new DbRenameColumnAction(updater.Transform, propertyMetadata.GetTableName(entityMetadata), settings1.FieldName, settings2.FieldName));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
              continue;
            case 18:
              if (settings1.FieldName != settings2.FieldName)
                goto case 17;
              else
                goto label_11;
            case 19:
              column = new Column(settings2.FieldName, dbColumnType);
              num2 = 3;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        Contract.CheckArgument(oldPropertyMetadata.Settings is SimpleTypeSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439448242));
        num1 = 5;
        continue;
label_11:
        num1 = 12;
        continue;
label_17:
        Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541746469));
        num1 = 7;
      }
label_5:
      return true;
label_6:
      return false;
label_9:
      return true;
label_12:
      throw new EleWise.ELMA.Model.Metadata.MetadataException(string.Format(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867931272)), (object) entityMetadata.FullTypeName, (object) propertyMetadata.Name));
    }

    /// <summary>Записать в генерируемый тип дополнительные члены</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Список выражений</returns>
    public override IEnumerable<ISyntaxNode> GetAdditionalTypeMembers(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new SimpleTypeDescriptor<T>.\u003CGetAdditionalTypeMembers\u003Ed__21(-2)
      {
        \u003C\u003E4__this = this,
        \u003C\u003E3__classMetadata = classMetadata,
        \u003C\u003E3__propertyMetadata = propertyMetadata
      };
    }

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected abstract ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata);

    /// <summary>
    /// Получить значение для установки а БД новой созданной колонки
    /// </summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Значение для колонки или <see langword="null" /></returns>
    protected virtual object GetDbDefaultValue(EntityPropertyMetadata propertyMetadata) => (object) null;

    public override bool HasRealColumn(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      bool flag;
      switch (1)
      {
        case 1:
          try
          {
            flag = this.GetDbColumnType(entityMetadata, propertyMetadata) != null;
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
              num = 0;
            switch (num)
            {
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_8;
                default:
                  flag = false;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
                  continue;
              }
            }
          }
          break;
      }
label_8:
      return flag;
    }

    /// <summary>
    /// Записать в генерируемый тип дополнительные члены из реализуемого интерфейса
    /// </summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="interfaceType">Тип интерфейса</param>
    /// <param name="interfacePropInfo">Информация о свойстве интерфейса</param>
    /// <param name="castPropertyTypeRef">Ссылка на тип свойства класса</param>
    /// <returns>Список выражений</returns>
    protected virtual IEnumerable<ISyntaxNode> WriteImplementedInterfaceMembers(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      Type interfaceType,
      PropertyInfo interfacePropInfo,
      ISyntaxNode castPropertyTypeRef)
    {
      // ISSUE: object of a compiler-generated type is created
      return (IEnumerable<ISyntaxNode>) new SimpleTypeDescriptor<T>.\u003CWriteImplementedInterfaceMembers\u003Ed__25(-2)
      {
        \u003C\u003E3__propertyMetadata = propertyMetadata,
        \u003C\u003E3__interfaceType = interfaceType,
        \u003C\u003E3__interfacePropInfo = interfacePropInfo,
        \u003C\u003E3__castPropertyTypeRef = castPropertyTypeRef
      };
    }

    protected SimpleTypeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool fa7ZCsoxctJb5GApyOsK() => SimpleTypeDescriptor<T>.yh4oCboxsafypbj7Z47y == null;

    internal static object u13dZ1oxzHZyH44W8Nhj() => SimpleTypeDescriptor<T>.yh4oCboxsafypbj7Z47y;
  }
}
