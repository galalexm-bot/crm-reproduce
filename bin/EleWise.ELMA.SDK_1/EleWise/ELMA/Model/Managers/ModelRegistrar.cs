// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.ModelRegistrar
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Properties;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Регистратор моделей приложения</summary>
  /// <remarks>
  /// Осуществляет инициализацию среды работы с моделями.<br />
  /// А также реализует интерфейс службы управления метаданными в режиме Runtime.
  /// </remarks>
  [Component(Type = ComponentType.Server)]
  internal class ModelRegistrar : INHManagerRegistrar, IMetadataRuntimeService, IMetadataService
  {
    private ModelRegistrarImpl impl;
    internal static ModelRegistrar LswlGQhCZLjLEVRQD8Vy;

    private ModelRegistrarImpl Impl
    {
      get
      {
        int num = 2;
        ModelRegistrarImpl impl1;
        ModelRegistrarImpl impl2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.impl = impl1 = (ModelRegistrarImpl) ModelRegistrar.FciXhuhCiPfUUrLlDRVh((object) (ILicensedModuleAssembly) ModelRegistrar.bhwry9hCSZA5ILlMC5OR((object) ComponentManager.Current.ModuleManager, ModelRegistrar.RuEmnGhCVkC02qRRmA3I()));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            case 2:
              impl2 = this.impl;
              if (impl2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return impl2;
label_6:
        return impl1;
      }
    }

    /// <summary>Зарегистрировать</summary>
    /// <param name="parameters">Параметры для регистрации</param>
    public void Register(NHManagerRegisterParams parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Impl.Register(this, parameters);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Получить родительский объект метаданных</summary>
    /// <param name="metadataUid">Уникальный идентификатор подчиненного объекта метаданных</param>
    /// <returns>Родительский объект метаданных или Null</returns>
    public IMetadata GetParentMetadata(Guid metadataUid) => (IMetadata) ModelRegistrar.JIq9eahCRCmUdX3Rjp10((object) this.Impl, metadataUid);

    /// <summary>Получить тип по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор типа</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Тип</returns>
    public Type GetTypeByUid(Guid uid, bool loadImplementation = true) => this.Impl.GetTypeByUid(uid, loadImplementation);

    /// <summary>Получить тип по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор типа</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Тип. Если не найден, возвращается Null.</returns>
    public Type GetTypeByUidOrNull(Guid uid, bool loadImplementation = true) => this.Impl.GetTypeByUidOrNull(uid, loadImplementation);

    /// <summary>Получить метаданные по уникальному идентификатору</summary>
    /// <param name="uid">Уникальный идентификатор метаданных</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Метаданные</returns>
    public IMetadata GetMetadata(Guid uid, bool loadImplementation = true) => this.Impl.GetMetadata(uid, loadImplementation);

    /// <summary>Зарегистрировать тип</summary>
    /// <param name="type">Тип</param>
    public void RegisterType(Type type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.RegisterType(type, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Зарегистрировать тип</summary>
    /// <param name="type">Тип</param>
    /// <param name="asEntity">Регистрировать как сущность</param>
    public void RegisterType(Type type, bool asEntity)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.RegisterTypes((IEnumerable<Type>) new Type[1]
            {
              type
            }, asEntity, (Action<Type, Exception>) ((t, ex) =>
            {
              throw ex;
            }));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Зарегистрировать типы с моделями.</summary>
    /// <remarks>
    /// Используется в любой момент после инициализации приложения.
    /// </remarks>
    /// <param name="types">Типы</param>
    /// <param name="registrationException">Действие, которое нужно выполнять при ошибке регистрации</param>
    public void RegisterTypes(
      IEnumerable<Type> types,
      Action<Type, Exception> registrationException)
    {
      this.RegisterTypes(types, true, registrationException);
    }

    /// <inheritdoc />
    public void RegisterTypes(
      IEnumerable<Type> types,
      bool asEntity,
      Action<Type, Exception> registrationException = null)
    {
      this.Impl.RegisterTypes(types, (IDictionary<Type, string>) null, registrationException, asEntity);
    }

    /// <inheritdoc />
    public void RegisterTypes(
      IEnumerable<Type> types,
      IDictionary<Type, string> entityNames,
      Action<Type, Exception> registrationException = null)
    {
      this.Impl.RegisterTypes(types, entityNames, registrationException, true);
    }

    /// <summary>Зарегистрировать дельта-сборки и их метаданные</summary>
    /// <param name="result">Результат публикации</param>
    /// <param name="deltaMetadataList">Спиок дельта-матаданных</param>
    internal void LoadAndRegister(
      MetadataAssemblyPublishResult result,
      IEnumerable<IRootMetadata> deltaMetadataList)
    {
      this.Impl.LoadAndRegister(result, deltaMetadataList);
    }

    /// <summary>Получить список метаданных</summary>
    /// <returns>Список метаданных</returns>
    public IEnumerable<IMetadata> GetMetadataList() => this.Impl.GetMetadataList();

    /// <summary>Получить список метаданных моделей сборок</summary>
    /// <returns>Список метаданных моделей сборок</returns>
    public IEnumerable<AssemblyModelsMetadata> GetAssemblyModelsMetadataList() => this.Impl.GetAssemblyModelsMetadataList();

    /// <summary>
    /// Получить список метаданных моделей сборок в предыдущий запуск приложения
    /// </summary>
    /// <returns>Список метаданных моделей сборок</returns>
    public IEnumerable<AssemblyModelsMetadata> GetPreviousAssemblyModelsMetadataList() => this.Impl.GetPreviousAssemblyModelsMetadataList();

    /// <summary>Получить описание доступных типов данных</summary>
    /// <returns>Список типов данных</returns>
    public IEnumerable<ITypeDescriptor> GetTypeDescriptors() => this.Impl.GetTypeDescriptors();

    /// <summary>
    /// Получить описание типа данных по его уникальному идентификатору. Если не нашли - null
    /// </summary>
    /// <param name="typeUid">Уникальный идентификатор типа данных</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid) => (ITypeDescriptor) ModelRegistrar.abtrTqhCqYu1GqWQNFv2((object) this.Impl, typeUid, subTypeUid);

    /// <summary>
    /// Получить описание типа данных по его типу CLR. Если не нашли - null
    /// </summary>
    /// <param name="runtimeType">Тип CLR</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetTypeDescriptor(Type runtimeType) => this.Impl.GetTypeDescriptor(runtimeType);

    /// <summary>
    /// Получить описание типов данных, которые можно использовать для первичного ключа
    /// </summary>
    /// <returns>Список типов данных</returns>
    public IEnumerable<ITypeDescriptor> GetIdTypeDescriptors() => this.Impl.GetIdTypeDescriptors();

    /// <summary>
    /// Получить описание типа данных, который можно использовать для первичного ключа, по его уникальному идентфикатору. Если не нашли - null
    /// </summary>
    /// <param name="typeUid">Уникальный идентификатор типа данных</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetIdTypeDescriptor(Guid typeUid) => (ITypeDescriptor) ModelRegistrar.a5kNqIhCKuFmMcgCjf5c((object) this.Impl, typeUid);

    /// <summary>Выполнить действия при мягкой публикации метаданных</summary>
    /// <param name="metadata"></param>
    public void OnSoftPublished(ICollection<IRootMetadata> metadatas) => this.Impl.OnSoftPublished(metadatas);

    /// <summary>
    /// Признак, что требуется перекомпиляция сценариев модели дизайнера
    /// </summary>
    public bool ConfigurationScriptsRecompileRequired => ModelRegistrar.RxqhcVhCXrijiVE396HE((object) this.Impl);

    /// <summary>Ошибки при компиляции сценариев</summary>
    public string ConfigurationScriptsErrors => this.Impl.ConfigurationScriptsErrors;

    /// <inheritdoc />
    public bool IsSystem(Guid typeUid) => ModelRegistrar.oDR2q4hCTNFgkghdUDxw((object) this.Impl, typeUid);

    /// <inheritdoc />
    public bool IsConfig(Guid typeUid) => ModelRegistrar.SZMCjchCkQqSEfaYwOR7((object) this.Impl, typeUid);

    public ModelRegistrar()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid RuEmnGhCVkC02qRRmA3I() => __AssemblyInfo.UID;

    internal static object bhwry9hCSZA5ILlMC5OR([In] object obj0, Guid uid) => (object) ((IModuleManager) obj0).FindUnitByUid(uid);

    internal static object FciXhuhCiPfUUrLlDRVh([In] object obj0) => (object) ((ILicensedModuleAssembly) obj0).LicenseUnit;

    internal static bool tF9RnqhCuEdCv1aJ7Ev6() => ModelRegistrar.LswlGQhCZLjLEVRQD8Vy == null;

    internal static ModelRegistrar QjWhUVhCI8N0OcJHIFde() => ModelRegistrar.LswlGQhCZLjLEVRQD8Vy;

    internal static object JIq9eahCRCmUdX3Rjp10([In] object obj0, Guid metadataUid) => (object) ((ModelRegistrarImpl) obj0).GetParentMetadata(metadataUid);

    internal static object abtrTqhCqYu1GqWQNFv2([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((ModelRegistrarImpl) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static object a5kNqIhCKuFmMcgCjf5c([In] object obj0, Guid typeUid) => (object) ((ModelRegistrarImpl) obj0).GetIdTypeDescriptor(typeUid);

    internal static bool RxqhcVhCXrijiVE396HE([In] object obj0) => ((ModelRegistrarImpl) obj0).ConfigurationScriptsRecompileRequired;

    internal static bool oDR2q4hCTNFgkghdUDxw([In] object obj0, Guid typeUid) => ((ModelRegistrarImpl) obj0).IsSystem(typeUid);

    internal static bool SZMCjchCkQqSEfaYwOR7([In] object obj0, Guid typeUid) => ((ModelRegistrarImpl) obj0).IsConfig(typeUid);
  }
}
