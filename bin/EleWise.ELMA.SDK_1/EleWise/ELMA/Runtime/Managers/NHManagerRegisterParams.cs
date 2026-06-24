// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.NHManagerRegisterParams
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Параметры для регистрации менеджера NHibernate</summary>
  public class NHManagerRegisterParams
  {
    private readonly ISet<Type> typeMappings;
    private readonly IDictionary<Type, (string entityName, int? tableNumber, bool? dynamicInsert, bool? dynamicUpdate)> mappings;
    internal static NHManagerRegisterParams HvO7TCW9oNm4OyPU5uat;

    /// <summary>Контейнер для конфигурации IoC</summary>
    public ContainerBuilder Builder
    {
      get => this.\u003CBuilder\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CBuilder\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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

    /// <summary>Маппинги Fluent NHibernate</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("Use NHibernate Mapping instead Fluent NHibernate and method NHManagerRegisterParams.Add", true)]
    public CustomFluentMappingsContainer FluentMappings => throw new NotImplementedException((string) NHManagerRegisterParams.pV4x1SW9Geg8HtuH1fZO(1505778440 - 1981636111 ^ -475995359));

    /// <summary>Провайдер преобразования БД</summary>
    public ITransformationProvider TransformationProvider
    {
      get => this.\u003CTransformationProvider\u003Ek__BackingField;
      internal set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CTransformationProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
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

    /// <summary>Добавить тип класса маппинга NHibernate</summary>
    /// <typeparam name="T">Тип класса маппинга NHibernate</typeparam>
    public void Add<T>() where T : class, IConformistHoldersProvider => this.Add(typeof (T));

    /// <summary>Добавить тип класса маппинга NHibernate</summary>
    /// <param name="type">Тип класса маппинга NHibernate</param>
    public void Add(Type type)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.typeMappings.Add(type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
            continue;
          case 2:
            NHManagerRegisterParams.d6p0dAW9EO5fAb5TLQqG(TypeOf<IConformistHoldersProvider>.Raw.IsAssignableFrom(type), (object) EleWise.ELMA.SR.T((string) NHManagerRegisterParams.pV4x1SW9Geg8HtuH1fZO(-420743386 ^ -420887006)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Добавить типы классов маппинга NHibernate</summary>
    /// <param name="types">Типы классов маппинга NHibernate</param>
    public void AddRange(IEnumerable<Type> types) => this.typeMappings.AddRange<Type>(types);

    /// <summary>
    /// Добавить тип для формирования внутренного маппинга NHibernate сущности
    /// </summary>
    /// <param name="type">Тип сущности</param>
    /// <param name="tableNumber">Номер таблицы</param>
    /// <param name="entityName">Имя сущности</param>
    /// <param name="dynamicInsert">Использовать динамическое формирование запроса на вставку</param>
    /// <param name="dynamicUpdate">Использовать динамическое формирование запроса на обновление</param>
    internal void AddNHibernateClassMapping(
      Type type,
      string entityName,
      int? tableNumber,
      bool? dynamicInsert,
      bool? dynamicUpdate)
    {
      this.mappings[type] = (entityName, tableNumber, dynamicInsert, dynamicUpdate);
    }

    /// <summary>
    /// Добавить типы для формирования внутренних маппингов NHibernate сущностей
    /// </summary>
    /// <param name="types">Типы сущностей</param>
    internal void AddNHibernateClassMappingRange(IEnumerable<Type> types) => types.ForEach<Type>((Action<Type>) (t =>
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.mappings[t] = ((string) null, new int?(), new bool?(), new bool?());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }));

    /// <summary>Сборки типов классов маппинга NHibernate</summary>
    internal IEnumerable<Assembly> MappingAssemblies => this.typeMappings.Select<Type, Assembly>((Func<Type, Assembly>) (t => t.Assembly)).Distinct<Assembly>();

    /// <summary>Создать и заполнить модель маппингов</summary>
    /// <returns>Модель маппингов</returns>
    internal ModelMapper CreateModelMapper()
    {
      int num = 2;
      ModelMapper modelMapper;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.typeMappings.ForEach<Type>(new Action<Type>(modelMapper.AddMapping));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
            continue;
          case 2:
            modelMapper = NHibernateClassMapping.CreateModelMapper(this.mappings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return modelMapper;
    }

    /// <summary>
    /// Добавить маппинги из <paramref name="params" />
    /// </summary>
    /// <param name="params">Параметры для регистрации менеджера NHibernate</param>
    internal void Add(NHManagerRegisterParams @params)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            @params.mappings.ForEach<KeyValuePair<Type, (string, int?, bool?, bool?)>>((Action<KeyValuePair<Type, (string, int?, bool?, bool?)>>) (p => this.mappings[p.Key] = p.Value));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.typeMappings.UnionWith((IEnumerable<Type>) @params.typeMappings);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Наличие маппингов для регистрации</summary>
    internal bool HasItems
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.mappings.Count > 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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
        return NHManagerRegisterParams.TpThD9W9fkTRpoP0txXw((object) this.typeMappings) > 0;
label_5:
        return true;
      }
    }

    public NHManagerRegisterParams()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.typeMappings = (ISet<Type>) new HashSet<Type>();
      this.mappings = (IDictionary<Type, (string, int?, bool?, bool?)>) new Dictionary<Type, (string, int?, bool?, bool?)>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool jtWtMbW9bKGfIhov968p() => NHManagerRegisterParams.HvO7TCW9oNm4OyPU5uat == null;

    internal static NHManagerRegisterParams kJHT36W9hoURowP4m7Do() => NHManagerRegisterParams.HvO7TCW9oNm4OyPU5uat;

    internal static object pV4x1SW9Geg8HtuH1fZO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void d6p0dAW9EO5fAb5TLQqG(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static int TpThD9W9fkTRpoP0txXw([In] object obj0) => ((ICollection<Type>) obj0).Count;
  }
}
