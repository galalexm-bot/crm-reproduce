// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.Managers.MetadataItemHeaderDtoManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers
{
  public class MetadataItemHeaderDtoManager : 
    DTOManager,
    IMetadataItemHeaderDtoManager,
    IConfigurationService
  {
    internal static MetadataItemHeaderDtoManager rjQv0yb5QW003QdeA4Ga;

    /// <summary>Менеджер работы с заголовками метаданными</summary>
    public MetadataItemHeaderManager MetadataItemHeaderManager
    {
      get => this.\u003CMetadataItemHeaderManager\u003Ek__BackingField;
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
              this.\u003CMetadataItemHeaderManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
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

    /// <summary>
    /// Точки расширения работы с зависимостями для метаданных
    /// </summary>
    public IEnumerable<IDependenciesExtension> DependenciesExtensions { get; set; }

    public virtual IEnumerable<string> GetGlobalModuleNames(IEnumerable<EntityMetadata> mds)
    {
      List<string> collection = new List<string>();
      foreach (EntityMetadata md1 in mds)
      {
        EntityMetadata md = md1;
        if (md.IsConfig())
        {
          IMetadataItemHeader metadataItemHeader = AbstractNHEntityManager<IMetadataItemHeader, long>.Instance.LoadOrNull(md.Uid);
          if (metadataItemHeader != null && metadataItemHeader.Published != null && metadataItemHeader.Published.ScriptModule != null && metadataItemHeader.Published.ScriptModule.GlobalScriptModules != null)
          {
            foreach (AssemblyReference globalScriptModule in metadataItemHeader.Published.ScriptModule.GlobalScriptModules)
              collection.AddIfNotContains<string>(globalScriptModule.Name);
          }
        }
        else
        {
          foreach (AbstractMetadata abstractMetadata in MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().Where<EntityMetadata>((Func<EntityMetadata, bool>) (m =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  if (m.Type == EntityMetadataType.InterfaceExtension)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
                    continue;
                  }
                  goto label_3;
                default:
                  goto label_2;
              }
            }
label_2:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            return MetadataItemHeaderDtoManager.\u003C\u003Ec__DisplayClass8_0.klocTcCxDATUMAb3hIUS(MetadataItemHeaderDtoManager.\u003C\u003Ec__DisplayClass8_0.aKGxvsCxp0DVI9QetY7a((object) m), MetadataItemHeaderDtoManager.\u003C\u003Ec__DisplayClass8_0.i4sewZCxaCRvqZOWs5Dj((object) md));
label_3:
            return false;
          })))
          {
            IMetadataItemHeader metadataItemHeader = AbstractNHEntityManager<IMetadataItemHeader, long>.Instance.LoadOrNull(abstractMetadata.Uid);
            if (metadataItemHeader != null && metadataItemHeader.Published != null && metadataItemHeader.Published.ScriptModule != null && metadataItemHeader.Published.ScriptModule.GlobalScriptModules != null)
            {
              foreach (AssemblyReference globalScriptModule in metadataItemHeader.Published.ScriptModule.GlobalScriptModules)
                collection.AddIfNotContains<string>(globalScriptModule.Name);
            }
          }
        }
      }
      return (IEnumerable<string>) collection;
    }

    /// <inheritdoc />
    public virtual IDictionary<Guid, string> GetObjectsUidsFromDependencies(Guid uid)
    {
      Dictionary<Guid, string> result = new Dictionary<Guid, string>();
      IEnumerable<IDependencyContainer> source = this.DependenciesExtensions.SelectMany<IDependenciesExtension, IDependencyContainer>((Func<IDependenciesExtension, IEnumerable<IDependencyContainer>>) (point => point.GetDependencyContainers(uid)));
      foreach (MetadataDependencyContainer dependencies in source.OfType<MetadataDependencyContainer>())
        this.GetObjectsUidsFromDependencies(dependencies, (IDictionary<Guid, string>) result);
      foreach (ScriptModuleDependencyContainer dependencies in source.OfType<ScriptModuleDependencyContainer>())
        this.GetObjectsUidsFromDependencies(dependencies, (IDictionary<Guid, string>) result);
      return (IDictionary<Guid, string>) result;
    }

    /// <summary>
    /// Получить идентификаторы зависимых объектов из контейнера зависимостей метаданных
    /// </summary>
    private void GetObjectsUidsFromDependencies(
      MetadataDependencyContainer dependencies,
      IDictionary<Guid, string> result)
    {
      if (result == null)
        result = result ?? (IDictionary<Guid, string>) new Dictionary<Guid, string>();
      if (dependencies == null)
        return;
      this.GetObjectsUidsFromDependencies(dependencies.EntityDependencies, ref result);
      this.GetObjectsUidsFromDependencies(dependencies.DataClassDependencies, ref result);
      this.GetObjectsUidsFromDependencies(dependencies.FunctionDependencies, ref result);
      if (dependencies.FormDependencies == null)
        return;
      foreach (FormViewItemDependencyContainer formDependency in dependencies.FormDependencies)
      {
        this.GetObjectsUidsFromDependencies(formDependency.EntityDependencies, ref result);
        this.GetObjectsUidsFromDependencies(formDependency.DataClassDependencies, ref result);
        this.GetObjectsUidsFromDependencies(formDependency.ComponentDependencies, ref result);
      }
    }

    /// <summary>
    /// Получить идентификаторы зависимых объектов из контейнера зависимостей скрипта
    /// </summary>
    private void GetObjectsUidsFromDependencies(
      ScriptModuleDependencyContainer dependencies,
      IDictionary<Guid, string> result)
    {
      if (result == null)
        result = result ?? (IDictionary<Guid, string>) new Dictionary<Guid, string>();
      if (dependencies == null)
        return;
      this.GetObjectsUidsFromDependencies(dependencies.EntityDependencies, ref result);
      this.GetObjectsUidsFromDependencies(dependencies.DataClassDependencies, ref result);
    }

    /// <summary>
    /// Получить идентификаторы зависимых сущностей из зависимостей метаданных
    /// </summary>
    private void GetObjectsUidsFromDependencies(
      List<EntityDependency> entityDependencies,
      ref IDictionary<Guid, string> result)
    {
      if (result == null)
        result = result ?? (IDictionary<Guid, string>) new Dictionary<Guid, string>();
      if (entityDependencies == null)
        return;
      IMetadataService service = MetadataServiceContext.Service;
      foreach (EntityDependency entityDependency in entityDependencies)
      {
        if (entityDependency.Properties != null)
        {
          foreach (PropertySignature property in entityDependency.Properties)
          {
            IMetadataItemHeader metadataItemHeader;
            if (property?.Type != null && !result.ContainsKey(property.Type.SubTypeUid) && (metadataItemHeader = this.MetadataItemHeaderManager.LoadOrNull(property.Type.SubTypeUid)) != null)
              result.Add(property.Type.SubTypeUid, metadataItemHeader.DisplayName);
          }
        }
      }
    }

    /// <summary>
    /// Получить идентификаторы зависимых датаклассов из зависимостей метаданных
    /// </summary>
    private void GetObjectsUidsFromDependencies(
      List<DataClassDependency> dataClassDependencies,
      ref IDictionary<Guid, string> result)
    {
      if (result == null)
        result = result ?? (IDictionary<Guid, string>) new Dictionary<Guid, string>();
      if (dataClassDependencies == null)
        return;
      DataClassMetadataItemHeaderManager instance = DataClassMetadataItemHeaderManager.Instance;
      foreach (DataClassDependency dataClassDependency in dataClassDependencies)
      {
        if (dataClassDependency.Properties != null)
        {
          foreach (PropertySignature property in dataClassDependency.Properties)
          {
            DataClassMetadataItemHeader metadataItemHeader;
            if (property?.Type != null && !result.ContainsKey(property.Type.SubTypeUid) && (metadataItemHeader = instance.LoadOrNull(property.Type.SubTypeUid)) != null)
              result.Add(property.Type.SubTypeUid, metadataItemHeader.DisplayName);
          }
        }
      }
    }

    /// <summary>
    /// Получить идентификаторы зависимых компонентов из зависимостей метаданных
    /// </summary>
    private void GetObjectsUidsFromDependencies(
      List<ComponentDependency> componentDependencies,
      ref IDictionary<Guid, string> result)
    {
      if (result == null)
        result = result ?? (IDictionary<Guid, string>) new Dictionary<Guid, string>();
      if (componentDependencies == null)
        return;
      ComponentMetadataItemHeaderManager instance = ComponentMetadataItemHeaderManager.Instance;
      foreach (ComponentDependency componentDependency in componentDependencies)
      {
        if (componentDependency.Inputs != null)
        {
          foreach (InputComputedValue input in componentDependency.Inputs)
          {
            ComponentMetadataItemHeader metadataItemHeader;
            if (input != null && !result.ContainsKey(input.SubTypeUid) && (metadataItemHeader = instance.LoadOrNull(input.SubTypeUid)) != null)
              result.Add(input.SubTypeUid, metadataItemHeader.DisplayName);
          }
        }
      }
    }

    /// <summary>
    /// Получить идентификаторы зависимых функций из зависимостей метаданных
    /// </summary>
    private void GetObjectsUidsFromDependencies(
      List<FunctionDependency> functionDependencies,
      ref IDictionary<Guid, string> result)
    {
      if (result == null)
        result = result ?? (IDictionary<Guid, string>) new Dictionary<Guid, string>();
      if (functionDependencies == null)
        return;
      FunctionMetadataItemHeaderManager instance = FunctionMetadataItemHeaderManager.Instance;
      foreach (FunctionDependency functionDependency in functionDependencies)
      {
        FunctionMetadataItemHeader metadataItemHeader1;
        if (functionDependency != null && functionDependency.ParameterType?.SubTypeUid.HasValue && !result.ContainsKey(functionDependency.ParameterType.SubTypeUid) && (metadataItemHeader1 = instance.LoadOrNull(functionDependency.ParameterType.SubTypeUid)) != null)
          result.Add(functionDependency.ParameterType.SubTypeUid, metadataItemHeader1.DisplayName);
        FunctionMetadataItemHeader metadataItemHeader2;
        if (functionDependency != null && functionDependency.ReturnType?.SubTypeUid.HasValue && !result.ContainsKey(functionDependency.ReturnType.SubTypeUid) && (metadataItemHeader2 = instance.LoadOrNull(functionDependency.ReturnType.SubTypeUid)) != null)
          result.Add(functionDependency.ReturnType.SubTypeUid, metadataItemHeader2.DisplayName);
      }
    }

    public MetadataItemHeaderDtoManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool i5lfE7b5C9op2pCcD9nE() => MetadataItemHeaderDtoManager.rjQv0yb5QW003QdeA4Ga == null;

    internal static MetadataItemHeaderDtoManager VgWgj2b5vr1PXLYZvpTe() => MetadataItemHeaderDtoManager.rjQv0yb5QW003QdeA4Ga;
  }
}
