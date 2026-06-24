// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.Components.AbstractMetadataEditorComponent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac.Builder;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ComponentModel.Components
{
  /// <summary>Абстрактный компонент управления метаданными</summary>
  public abstract class AbstractMetadataEditorComponent : 
    IInitHandler,
    IMetadataEditorService,
    IMetadataService
  {
    private Dictionary<Type, IMetadataTypeInfo> metadataTypeInfos;
    protected DateTime lastMetadataUpdate;
    private string currentProjectName;
    private ISet<string> processedAssemblyNames;
    private IDictionary<string, ISet<string>> projectReferences;
    private IDictionary<string, IDictionary<Guid, IMetadata>> metadataByProjects;
    private Dictionary<KeyValuePair<Guid, Guid>, ITypeDescriptor> _typeDescriptorsByUid;
    private readonly Dictionary<Type, ITypeDescriptor> _typeDescriptorsByType;
    internal static AbstractMetadataEditorComponent GGmLhxfIXZPxMDyk1G02;

    void IInitHandler.Init() => AbstractMetadataEditorComponent.cBSlISfIn169p0eSnQLa((object) this);

    void IInitHandler.InitComplete() => AbstractMetadataEditorComponent.TBjAHJfIOLMfaywRR7cl((object) this);

    /// <summary>Получить имя редактируемого проекта</summary>
    public abstract string ProjectName { get; }

    /// <summary>Получить объект метаданных по Uid-у</summary>
    /// <param name="metadataUid">Uid объекта метаданных</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns></returns>
    public IMetadata GetMetadata(Guid metadataUid, bool loadImplementation = true)
    {
      int num1 = 6;
      IMetadata metadata;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string currentProject;
          switch (num2)
          {
            case 1:
              if (metadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 3;
                continue;
              }
              break;
            case 2:
            case 3:
            case 7:
              goto label_10;
            case 4:
              metadata = (IMetadata) AbstractMetadataEditorComponent.gkSw6ffI2CTeP9V02INX((object) this, AbstractMetadataEditorComponent.J8l8YHfIesBlDmt2hcCJ(-643786247 ^ -643787875), metadataUid);
              num2 = 2;
              continue;
            case 5:
              metadata = (IMetadata) AbstractMetadataEditorComponent.gkSw6ffI2CTeP9V02INX((object) this, (object) currentProject, metadataUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
              continue;
            case 6:
              currentProject = this.GetCurrentProject();
              num2 = 5;
              continue;
            case 8:
              goto label_3;
          }
          if (!AbstractMetadataEditorComponent.iwGRixfIPO6XxlVQeRpd((object) currentProject, AbstractMetadataEditorComponent.J8l8YHfIesBlDmt2hcCJ(-97972138 ^ -97969614)))
            num2 = 7;
          else
            break;
        }
label_3:
        if (this.metadataByProjects.ContainsKey((string) AbstractMetadataEditorComponent.J8l8YHfIesBlDmt2hcCJ(2045296739 + 1688595713 ^ -561076480)))
          num1 = 4;
        else
          break;
      }
label_10:
      return metadata;
    }

    /// <summary>Получить объект метаданных по Uid-у</summary>
    /// <param name="projectName">Имя проекта</param>
    /// <param name="metadataUid">Uid объекта метаданных</param>
    /// <returns>Метаданные</returns>
    public virtual IMetadata GetMetadata(string projectName, Guid metadataUid) => this.GetMetadata(projectName, metadataUid, true);

    /// <summary>Получить описание доступных типов данных</summary>
    /// <returns>Список типов данных</returns>
    public IEnumerable<ITypeDescriptor> GetTypeDescriptors() => (IEnumerable<ITypeDescriptor>) this._typeDescriptorsByUid.Values;

    /// <summary>
    /// Получить описание типа данных по его уникальному идентификатору. Если не нашли - null
    /// </summary>
    /// <param name="typeUid">Уникальный идентификатор типа данных</param>
    /// <param name="subTypeUid">Уникальный идентификатор подтипа</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid)
    {
      int num = 1;
      ITypeDescriptor typeDescriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this._typeDescriptorsByUid.TryGetValue(new KeyValuePair<Guid, Guid>(typeUid, subTypeUid), out typeDescriptor))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 3:
            this._typeDescriptorsByUid.TryGetValue(new KeyValuePair<Guid, Guid>(typeUid, Guid.Empty), out typeDescriptor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 2;
            continue;
          case 4:
            if (!AbstractMetadataEditorComponent.KKbUJXfI16c7q0SJChIl(subTypeUid, Guid.Empty))
            {
              num = 5;
              continue;
            }
            goto case 3;
          default:
            goto label_3;
        }
      }
label_3:
      return typeDescriptor;
    }

    /// <summary>
    /// Получить описание типов данных, которые можно использовать для первичного ключа
    /// </summary>
    /// <returns>Список типов данных</returns>
    public IEnumerable<ITypeDescriptor> GetIdTypeDescriptors() => this._typeDescriptorsByUid.Values.Where<ITypeDescriptor>((Func<ITypeDescriptor, bool>) (t => AbstractMetadataEditorComponent.\u003C\u003Ec.ptoFSu85HDAUwZJVPFjI((object) t)));

    /// <summary>
    /// Получить описание типа данных, который можно использовать для первичного ключа, по его уникальному идентфикатору. Если не нашли - null
    /// </summary>
    /// <param name="typeUid">Уникальный идентификатор типа данных</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetIdTypeDescriptor(Guid typeUid)
    {
      int num1 = 2;
      ITypeDescriptor typeDescriptor;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (typeDescriptor == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              typeDescriptor = this.GetTypeDescriptor(typeUid, Guid.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 1;
              continue;
            case 4:
              goto label_5;
            default:
              goto label_3;
          }
        }
label_5:
        if (!AbstractMetadataEditorComponent.NJaUx7fIN20UqbclyXD9((object) typeDescriptor))
          num1 = 3;
        else
          goto label_4;
      }
label_3:
      return (ITypeDescriptor) null;
label_4:
      return typeDescriptor;
    }

    /// <summary>Получить список метаданных для текущего проекта</summary>
    /// <returns>Список метаданных</returns>
    public IEnumerable<IMetadata> GetMetadataList() => this.GetMetadataList(true);

    /// <summary>Получить список метаданных</summary>
    /// <param name="inherited">True, если в список также нужно включать метаданные из проектов, на которые есть ссылка в текущем проекте</param>
    /// <returns>Список метаданных</returns>
    public IEnumerable<IMetadata> GetMetadataList(bool inherited) => this.GetMetadataList(this.GetCurrentProject(), inherited);

    /// <summary>Получить список метаданных для указанного проекта</summary>
    /// <param name="projectName">Имя проекта</param>
    /// <param name="inherited">True, если в список также нужно включать метаданные из проектов, на которые есть ссылка в текущем проекте</param>
    /// <returns>Список метаданных</returns>
    public virtual IEnumerable<IMetadata> GetMetadataList(string projectName, bool inherited)
    {
      if (inherited)
        return (IEnumerable<IMetadata>) AllReferences(projectName, (ISet<string>) new HashSet<string>()).SelectMany<string, IMetadata>((Func<string, IEnumerable<IMetadata>>) (p => this.GetMetadataList(p, false))).ToArray<IMetadata>();
      IDictionary<Guid, IMetadata> dictionary;
      if (!this.metadataByProjects.TryGetValue(projectName, out dictionary))
        throw this.ProjectNotFound(projectName);
      return (IEnumerable<IMetadata>) dictionary.Values;

      IEnumerable<string> AllReferences(string prjName, ISet<string> processedProjects)
      {
        ISet<string> source;
        return processedProjects.Add(prjName) && this.projectReferences.TryGetValue(prjName, out source) ? source.SelectMany<string, string>((Func<string, IEnumerable<string>>) (r => AllReferences(r, processedProjects))).Prepend<string>(prjName) : Enumerable.Empty<string>();
      }
    }

    /// <summary>
    /// Имя текущего проекта. В зависимости от него работают остальные функции сервиса
    /// </summary>
    public virtual string CurrentProjectName
    {
      get => this.currentProjectName;
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
              this.currentProjectName = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
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

    /// <summary>Получить метаданные сборки для указанного проекта</summary>
    /// <param name="projectName">Имя проекта</param>
    /// <returns>Метаданные сборки (или null, если не найдены)</returns>
    public AssemblyInfoMetadata GetAssemblyInfoMetadata(string projectName) => this.GetMetadataList(projectName, false).OfType<AssemblyInfoMetadata>().FirstOrDefault<AssemblyInfoMetadata>();

    /// <summary>Сохранить объект метаданных</summary>
    /// <param name="metadata">Объект метаданных</param>
    public void SaveMetadata(IMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.SaveMetadata((IEnumerable<IMetadata>) new IMetadata[1]
            {
              metadata
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.lastMetadataUpdate = AbstractMetadataEditorComponent.jDaBuXfI3juKoxn0jicw();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Сохранить объекты метаданных</summary>
    /// <param name="metadataList">Объекты метаданных</param>
    public abstract void SaveMetadata(IEnumerable<IMetadata> metadataList);

    /// <summary>Публиковать объект метаданных (текущий черновик)</summary>
    /// <param name="metadata">Объект метаданных</param>
    /// <param name="comment">Комментарий</param>
    public void PublishMetadata(IMetadata metadata, string comment)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.PublishMetadata((IEnumerable<IMetadata>) new IMetadata[1]
            {
              metadata
            }, comment);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Публиковать объекты метаданных (текущие черновики)</summary>
    /// <param name="metadataList">Объект метаданных</param>
    /// <param name="comment">Комментарий</param>
    public abstract void PublishMetadata(IEnumerable<IMetadata> metadataList, string comment);

    /// <summary>Удалить объект метаданных</summary>
    /// <param name="metadata">Объект метаданных</param>
    public abstract void RemoveMetadata(IMetadata metadata);

    /// <summary>Создать генератор кода</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Генератор</returns>
    public virtual ICodeGenerator CreateCodeGenerator(IMetadata metadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            AbstractMetadataEditorComponent.zlQdvVfIp7ibX2GwtyJ4((object) metadata, AbstractMetadataEditorComponent.J8l8YHfIesBlDmt2hcCJ(~289714581 ^ -289732780));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      ICodeGenerator codeGenerator = (ICodeGenerator) AbstractMetadataEditorComponent.r1nf9MfIaRj0o0ChTNVX((this.GetMetadataTypeInfo(metadata.GetType()) ?? throw new CodeGeneratorCreateException()).GeneratorType);
      AbstractMetadataEditorComponent.jshARyfIDrblKtm4Z11d((object) codeGenerator, (object) metadata);
      return codeGenerator;
    }

    /// <summary>
    /// Получить описание типа данных по его типу CLR. Если не нашли - null
    /// </summary>
    /// <param name="runtimeType">Тип CLR</param>
    /// <returns>Описание типа данных</returns>
    public ITypeDescriptor GetTypeDescriptor(Type runtimeType)
    {
      int num = 2;
      Type genericArgument;
      ITypeDescriptor typeDescriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (typeDescriptor != null)
            {
              num = 8;
              continue;
            }
            goto case 7;
          case 2:
            this._typeDescriptorsByType.TryGetValue(runtimeType, out typeDescriptor);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
            continue;
          case 4:
            // ISSUE: type reference
            if (!AbstractMetadataEditorComponent.IwHVTxfIw7PjXaFKuwNj(runtimeType.GetGenericTypeDefinition(), AbstractMetadataEditorComponent.cGUtZUfIt1cNiinZpVZY(__typeref (Nullable<>))))
            {
              num = 3;
              continue;
            }
            goto case 6;
          case 6:
            genericArgument = runtimeType.GetGenericArguments()[0];
            num = 9;
            continue;
          case 7:
            if (!runtimeType.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 9:
            this._typeDescriptorsByType.TryGetValue(genericArgument, out typeDescriptor);
            num = 5;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      return typeDescriptor;
    }

    /// <summary>Построить документацию</summary>
    public abstract void BuildDocumentation();

    /// <summary>Получить информацию об элементе метаданных</summary>
    /// <param name="metadata">Метаданные</param>
    /// <returns>Информация об элементе метаданных</returns>
    public abstract MetadataItemDTO GetMetadataItemDTO(IMetadata metadata);

    /// <summary>Получить все текущие элементы метаданных</summary>
    /// <returns>Список элементов метаданных</returns>
    public abstract IEnumerable<MetadataItemDTO> GetMetadataItemDTOList();

    /// <inheritdoc />
    public virtual bool IsSystem(Guid typeUid)
    {
      int num = 2;
      Guid typeUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            typeUid1 = typeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return this.metadataByProjects.Where<KeyValuePair<string, IDictionary<Guid, IMetadata>>>((Func<KeyValuePair<string, IDictionary<Guid, IMetadata>>, bool>) (p => p.Key != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138015845) && p.Key != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822888906))).Any<KeyValuePair<string, IDictionary<Guid, IMetadata>>>((Func<KeyValuePair<string, IDictionary<Guid, IMetadata>>, bool>) (p => p.Value.ContainsKey(typeUid1)));
    }

    /// <inheritdoc />
    public virtual bool IsConfig(Guid typeUid)
    {
      int num = 2;
      Guid typeUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            typeUid1 = typeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.GetMetadataList(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867824088), false).Any<IMetadata>((Func<IMetadata, bool>) (m => AbstractMetadataEditorComponent.\u003C\u003Ec__DisplayClass28_0.zJMvFS85gNZwoKZxsvC2(AbstractMetadataEditorComponent.\u003C\u003Ec__DisplayClass28_0.wxfZtO85rg3s1utgdp6c((object) m), typeUid1)));
    }

    /// <summary>Имена проектов</summary>
    public IEnumerable<string> ProjectNames => (IEnumerable<string>) this.projectReferences.Keys;

    /// <summary>Действия при инициализации</summary>
    protected virtual void OnInit()
    {
      int num1 = 1;
      IEnumerator<IMetadataTypeInfo> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = ((ComponentManager) AbstractMetadataEditorComponent.lYULLCfI4qH4aZu2Gko4()).GetExtensionPoints<IMetadataTypeInfo>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
          case 2:
label_17:
            this.RegisterComponent(ComponentManager.Builder.RegisterInstance<AbstractMetadataEditorComponent>(this).SingleInstance());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 3;
            continue;
          case 3:
            goto label_14;
          default:
            try
            {
label_6:
              if (enumerator.MoveNext())
                goto label_8;
              else
                goto label_7;
label_5:
              IMetadataTypeInfo current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_6;
                  case 2:
                    this.ProcessMetadataType(current);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 1;
                    continue;
                  case 3:
                    goto label_8;
                  default:
                    goto label_17;
                }
              }
label_7:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
              goto label_5;
label_8:
              current = enumerator.Current;
              num2 = 2;
              goto label_5;
            }
            finally
            {
              if (enumerator != null)
              {
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      enumerator.Dispose();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_16;
                  }
                }
              }
label_16:;
            }
        }
      }
label_14:;
    }

    /// <summary>Действия при завершении инициализации</summary>
    protected virtual void OnInitComplete() => this.InitTypeDescriptors();

    /// <summary>Регистрация данного компонента</summary>
    /// <param name="registrar">Регистратор</param>
    protected virtual void RegisterComponent(
      IRegistrationBuilder<AbstractMetadataEditorComponent, SimpleActivatorData, SingleRegistrationStyle> registrar)
    {
      registrar.As<IMetadataEditorService>();
    }

    /// <summary>Обнулить менеджер</summary>
    protected virtual void Reset()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            AbstractMetadataEditorComponent.qega7ifI6Yw7adLwqR8b((object) this.projectReferences);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          case 2:
            this.lastMetadataUpdate = DateTime.Now;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 3 : 3;
            continue;
          case 3:
            goto label_2;
          default:
            this.metadataByProjects.Clear();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Обработана ли сборка с указанным именем</summary>
    /// <param name="assemblyName">Имя сборки</param>
    /// <returns>True, если обработана</returns>
    protected virtual bool IsAssemblyProcessed(string assemblyName) => this.processedAssemblyNames.Contains(assemblyName);

    /// <summary>Обработать сборку</summary>
    /// <param name="assembly">Сборка</param>
    /// <param name="hasSources">True, если есть исходники сборки</param>
    protected virtual void ProcessAssembly(Assembly assembly, bool hasSources = false)
    {
      int num1 = 19;
      string assemblyShortName;
      IDictionary<Guid, IMetadata> dictionary;
      Type type;
      IMetadata metadata;
      Type[] typeArray;
      int index;
      Type[] types;
      while (true)
      {
        switch (num1)
        {
          case 1:
            typeArray = types;
            num1 = 7;
            continue;
          case 2:
            if (AttributeHelper<MetadataTypeAttribute>.GetAttribute(type, false) != null)
            {
              num1 = 14;
              continue;
            }
            goto case 10;
          case 3:
            try
            {
              types = assembly.GetTypes();
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_15;
              }
            }
            catch (Exception ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
                num3 = 0;
              string str;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                  case 2:
                    AbstractMetadataEditorComponent.h7TnDxfIyHjfFG2k1eGB(AbstractMetadataEditorComponent.TfNsSJfIxpah9yJXNSsu(), AbstractMetadataEditorComponent.RsDDUXfImBFwXlMoIEgj(AbstractMetadataEditorComponent.J8l8YHfIesBlDmt2hcCJ(-1487388570 ^ -1487044728), (object) assembly.FullName), (object) ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 3 : 2;
                    continue;
                  case 3:
                    goto label_47;
                  case 4:
                    ((ILogger) AbstractMetadataEditorComponent.TfNsSJfIxpah9yJXNSsu()).Error((object) string.Format((string) AbstractMetadataEditorComponent.J8l8YHfIesBlDmt2hcCJ(1251470110 >> 2 ^ 312526121), (object) ((string) AbstractMetadataEditorComponent.XhYmMWfI0jnRmHBuw1i5((object) assembly) + Environment.NewLine + str)), ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 6;
                    continue;
                  case 5:
                    str = (string) AbstractMetadataEditorComponent.SVEoIPfI7XxMxaYvHN1c(AbstractMetadataEditorComponent.J8l8YHfIesBlDmt2hcCJ(874012245 ^ 874212931), (object) ((IEnumerable<Exception>) AbstractMetadataEditorComponent.c1YO8UfIADAxFM4naM02((object) typeLoadException)).Select<Exception, string>((Func<Exception, string>) (e => e.ToString())).ToArray<string>());
                    num3 = 4;
                    continue;
                  case 6:
                    goto label_42;
                  default:
                    if (!(ex is ReflectionTypeLoadException typeLoadException))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
                      continue;
                    }
                    goto case 5;
                }
              }
label_47:
              return;
label_42:
              return;
            }
          case 4:
label_23:
            if (metadata == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 2 : 10;
              continue;
            }
            goto case 21;
          case 5:
            if (dictionary.ContainsKey(AbstractMetadataEditorComponent.Je6HHRfIJMfh59XuamB5((object) metadata)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 2 : 15;
              continue;
            }
            goto case 8;
          case 6:
            this.lastMetadataUpdate = DateTime.Now;
            num1 = 22;
            continue;
          case 7:
            index = 0;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
            continue;
          case 8:
            AbstractMetadataEditorComponent.fymFs5fI9wd3vlp1pjXp((object) this, (object) assemblyShortName, (object) metadata);
            num1 = 20;
            continue;
          case 9:
            AbstractMetadataEditorComponent.swe4MOfIM636DklPk2D7((object) this, (object) assemblyShortName);
            num1 = 13;
            continue;
          case 10:
          case 15:
          case 20:
label_35:
            ++index;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 14 : 16;
            continue;
          case 11:
          case 25:
            type = typeArray[index];
            num1 = 2;
            continue;
          case 12:
            goto label_2;
          case 13:
            dictionary = this.metadataByProjects[assemblyShortName];
            num1 = 5;
            continue;
          case 14:
            try
            {
              metadata = MetadataLoader.LoadMetadata(type, false);
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
                num4 = 0;
              switch (num4)
              {
                default:
                  goto label_23;
              }
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    goto label_35;
                  default:
                    AbstractMetadataEditorComponent.h7TnDxfIyHjfFG2k1eGB(AbstractMetadataEditorComponent.TfNsSJfIxpah9yJXNSsu(), AbstractMetadataEditorComponent.RsDDUXfImBFwXlMoIEgj(AbstractMetadataEditorComponent.J8l8YHfIesBlDmt2hcCJ(272623989 ^ 272279863), (object) type.FullName), (object) ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
                    continue;
                }
              }
            }
          case 17:
            num1 = 3;
            continue;
          case 18:
            goto label_50;
          case 19:
            if (this.processedAssemblyNames.Add((string) AbstractMetadataEditorComponent.pvbh22fIH7k3Gmw3VQ5w((object) assembly)))
            {
              if (AttributeHelper<ModelAssemblyAttribute>.GetAttribute(assembly) != null)
              {
                num1 = 17;
                continue;
              }
              goto label_48;
            }
            else
            {
              num1 = 18;
              continue;
            }
          case 21:
            if (dictionary == null)
            {
              num1 = 9;
              continue;
            }
            goto case 5;
          case 22:
            goto label_16;
          case 23:
label_15:
            assemblyShortName = ComponentManager.GetAssemblyShortName(assembly);
            num1 = 24;
            continue;
          case 24:
            dictionary = (IDictionary<Guid, IMetadata>) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
            continue;
          default:
            if (index < typeArray.Length)
            {
              num1 = 25;
              continue;
            }
            goto case 6;
        }
      }
label_2:
      return;
label_50:
      return;
label_16:
      return;
label_48:;
    }

    /// <summary>Добавить или заменить загруженные метаданные</summary>
    /// <param name="projectName">Имя проекта</param>
    /// <param name="metadata">Метаданные</param>
    protected virtual void AddOrReplaceMetadata(string projectName, IMetadata metadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_6;
          case 2:
            IDictionary<Guid, IMetadata> dictionary;
            if (!this.metadataByProjects.TryGetValue(projectName, out dictionary))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
              continue;
            }
            dictionary[AbstractMetadataEditorComponent.Je6HHRfIJMfh59XuamB5((object) metadata)] = metadata;
            num = 3;
            continue;
          case 3:
            this.lastMetadataUpdate = DateTime.Now;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:
      return;
label_6:
      throw this.ProjectNotFound(projectName);
    }

    /// <summary>Удалить метаданные</summary>
    /// <param name="projectName">Имя проекта</param>
    /// <param name="metadata">Метаданные</param>
    protected virtual void RemoveMetadata(string projectName, IMetadata metadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_3;
          case 2:
            IDictionary<Guid, IMetadata> dictionary;
            if (this.metadataByProjects.TryGetValue(projectName, out dictionary))
            {
              dictionary.Remove(AbstractMetadataEditorComponent.Je6HHRfIJMfh59XuamB5((object) metadata));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 3 : 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 1;
            continue;
          case 3:
            this.lastMetadataUpdate = DateTime.Now;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:
      return;
label_3:
      throw this.ProjectNotFound(projectName);
    }

    /// <summary>Добавить проект</summary>
    /// <param name="projectName">Имя проекта</param>
    protected virtual void AddProject(string projectName)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (this.ProjectExists(projectName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
              continue;
            }
            this.projectReferences.Add(projectName, (ISet<string>) new HashSet<string>());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_6;
          default:
            this.metadataByProjects.Add(projectName, (IDictionary<Guid, IMetadata>) new Dictionary<Guid, IMetadata>());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 3 : 3;
            continue;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>Добавить ссылку на сборку</summary>
    /// <param name="projectName">Имя проекта</param>
    /// <param name="assemblyName">Имя сборки</param>
    protected virtual void AddProjectReference(string projectName, string assemblyName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ISet<string> stringSet;
            if (!this.projectReferences.TryGetValue(projectName, out stringSet))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            }
            stringSet.Add(assemblyName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 2 : 2;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw this.ProjectNotFound(projectName);
    }

    /// <summary>Удалить ссылку на сборку</summary>
    /// <param name="projectName">Имя проекта</param>
    /// <param name="assemblyName">Имя сборки</param>
    protected virtual void RemoveProjectReference(string projectName, string assemblyName)
    {
      int num = 2;
      ISet<string> stringSet;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            stringSet.Remove(assemblyName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
            continue;
          case 2:
            if (this.projectReferences.TryGetValue(projectName, out stringSet))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
              continue;
            }
            goto label_6;
          case 3:
            goto label_6;
          default:
            goto label_2;
        }
      }
label_5:
      return;
label_2:
      return;
label_6:
      throw this.ProjectNotFound(projectName);
    }

    /// <summary>Удалить проект</summary>
    /// <param name="projectName">Имя проекта</param>
    protected virtual void RemoveProject(string projectName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.projectReferences.Remove(projectName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_5;
          case 3:
            goto label_2;
          default:
            this.metadataByProjects.Remove(projectName);
            num = 3;
            continue;
        }
      }
label_2:
      return;
label_5:
      throw this.ProjectNotFound(projectName);
    }

    /// <summary>Существует ли проект</summary>
    /// <param name="projectName">Имя проекта</param>
    /// <returns>True, если проект существует</returns>
    protected virtual bool ProjectExists(string projectName) => this.projectReferences.ContainsKey(projectName);

    /// <summary>Переименовать проект</summary>
    /// <param name="oldName">Старое имя</param>
    /// <param name="newName">Новое имя</param>
    protected virtual void RenameProject(string oldName, string newName)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            goto label_7;
          case 3:
            this.projectReferences[newName] = this.projectReferences[oldName];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 4:
            this.metadataByProjects[newName] = this.metadataByProjects[oldName];
            num = 3;
            continue;
          case 5:
            if (AbstractMetadataEditorComponent.JXG5fBfIdoBl6OAo31Ak((object) this, (object) oldName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 4;
              continue;
            }
            goto label_4;
          default:
            AbstractMetadataEditorComponent.d2FDqufIlXIqwB0ylg62((object) this, (object) oldName);
            num = 2;
            continue;
        }
      }
label_7:
      return;
label_4:
      throw this.ProjectNotFound(oldName);
    }

    private void InitTypeDescriptors()
    {
      int num1 = 1;
      IEnumerator<ITypeDescriptor> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = ComponentManager.Current.GetExtensionPoints<ITypeDescriptor>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_20;
          default:
            goto label_2;
        }
      }
label_20:
      return;
label_2:
      try
      {
label_12:
        if (AbstractMetadataEditorComponent.TtGXCtfIjnyl7X6GOPGT((object) enumerator))
          goto label_14;
        else
          goto label_13;
label_4:
        IRuntimeTypeDescriptor runtimeTypeDescriptor;
        ITypeDescriptor current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this._typeDescriptorsByUid[new KeyValuePair<Guid, Guid>(current.Uid, AbstractMetadataEditorComponent.V1eTRcfIrjB2cEg6tX3T((object) current))] = current;
              num2 = 5;
              continue;
            case 2:
              if (!AbstractMetadataEditorComponent.HWyRNCfIgGPf7wiRfSQQ((object) runtimeTypeDescriptor))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 4 : 0;
                continue;
              }
              goto case 3;
            case 3:
              this._typeDescriptorsByType[AbstractMetadataEditorComponent.Pf8Sh1fI5BP0p1jcSQ36((object) runtimeTypeDescriptor)] = current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 4 : 6;
              continue;
            case 4:
            case 6:
              goto label_12;
            case 5:
              runtimeTypeDescriptor = current as IRuntimeTypeDescriptor;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 7;
              continue;
            case 7:
              if (runtimeTypeDescriptor != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 2 : 2;
                continue;
              }
              goto label_12;
            case 8:
              goto label_19;
            default:
              goto label_14;
          }
        }
label_19:
        return;
label_13:
        num2 = 8;
        goto label_4;
label_14:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
        {
          num2 = 1;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = 2;
        else
          goto label_21;
label_18:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_21:
        AbstractMetadataEditorComponent.jiT7HPfIYnjd6EPZFtlO((object) enumerator);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
        {
          num3 = 1;
          goto label_18;
        }
        else
          goto label_18;
      }
    }

    private void ProcessMetadataType(IMetadataTypeInfo metadataTypeInfo)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!this.metadataTypeInfos.ContainsKey(AbstractMetadataEditorComponent.IEArn5fILsDqHjI7jKyd((object) metadataTypeInfo)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              AbstractMetadataEditorComponent.zlQdvVfIp7ibX2GwtyJ4((object) metadataTypeInfo, AbstractMetadataEditorComponent.J8l8YHfIesBlDmt2hcCJ(-138018305 ^ -138198667));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_6;
            case 4:
              goto label_8;
            default:
              goto label_7;
          }
        }
label_7:
        this.metadataTypeInfos.Add(AbstractMetadataEditorComponent.IEArn5fILsDqHjI7jKyd((object) metadataTypeInfo), metadataTypeInfo);
        num1 = 4;
      }
label_6:
      return;
label_8:
      return;
label_3:;
    }

    private IMetadataTypeInfo GetMetadataTypeInfo(Type metadataType)
    {
      int num = 2;
      IMetadataTypeInfo metadataTypeInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.metadataTypeInfos.TryGetValue(metadataType, out metadataTypeInfo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 2:
            AbstractMetadataEditorComponent.zlQdvVfIp7ibX2GwtyJ4((object) metadataType, AbstractMetadataEditorComponent.J8l8YHfIesBlDmt2hcCJ(1917256330 ^ 1916944932));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return metadataTypeInfo;
    }

    private Exception ProjectNotFound(string projectName) => new Exception(EleWise.ELMA.SR.T((string) AbstractMetadataEditorComponent.J8l8YHfIesBlDmt2hcCJ(--1360331293 ^ 1360020183), (object) projectName));

    private IMetadata GetMetadata(string projectName, Guid metadataUid, bool failIfNotExists)
    {
      int num1 = 1;
      IMetadata metadata1;
      IEnumerator<string> enumerator;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              IDictionary<Guid, IMetadata> dictionary;
              if (!this.metadataByProjects.TryGetValue(projectName, out dictionary))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                continue;
              }
              if (!dictionary.TryGetValue(metadataUid, out metadata1))
              {
                num2 = 4;
                continue;
              }
              goto label_5;
            case 2:
              goto label_9;
            case 3:
              goto label_13;
            case 4:
              goto label_6;
            case 5:
              goto label_28;
            case 6:
              goto label_5;
            default:
              if (failIfNotExists)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 2 : 2;
                continue;
              }
              goto label_10;
          }
        }
label_6:
        enumerator = this.projectReferences[projectName].GetEnumerator();
        num1 = 3;
      }
label_5:
      return metadata1;
label_9:
      throw this.ProjectNotFound(projectName);
label_10:
      return (IMetadata) null;
label_13:
      IMetadata metadata2;
      try
      {
label_16:
        if (enumerator.MoveNext())
          goto label_15;
        else
          goto label_17;
label_14:
        string current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
            case 5:
              goto label_16;
            case 2:
              goto label_28;
            case 3:
              goto label_15;
            case 4:
              if (metadata1 == null)
              {
                num3 = 5;
                continue;
              }
              break;
            case 6:
              metadata1 = this.GetMetadata(current, metadataUid, false);
              num3 = 4;
              continue;
            case 7:
              goto label_29;
          }
          metadata2 = metadata1;
          num3 = 7;
        }
label_15:
        current = enumerator.Current;
        num3 = 6;
        goto label_14;
label_17:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 0;
        goto label_14;
      }
      finally
      {
        int num4;
        if (enumerator == null)
          num4 = 2;
        else
          goto label_25;
label_24:
        switch (num4)
        {
          case 1:
            break;
          default:
        }
label_25:
        AbstractMetadataEditorComponent.jiT7HPfIYnjd6EPZFtlO((object) enumerator);
        num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
        {
          num4 = 0;
          goto label_24;
        }
        else
          goto label_24;
      }
label_29:
      return metadata2;
label_28:
      return (IMetadata) null;
    }

    private string GetCurrentProject()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (string.IsNullOrEmpty(this.CurrentProjectName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (string) AbstractMetadataEditorComponent.hCovyYfIU237VY8sOQDN((object) this);
label_5:
      throw new Exception((string) AbstractMetadataEditorComponent.GhngnRfIs7MM2nkBLkod(AbstractMetadataEditorComponent.J8l8YHfIesBlDmt2hcCJ(1033719030 - 2012070891 ^ -978662927)));
    }

    protected AbstractMetadataEditorComponent()
    {
      AbstractMetadataEditorComponent.FFZOBafIcLXR7LWYvlPf();
      this.metadataTypeInfos = new Dictionary<Type, IMetadataTypeInfo>();
      this.lastMetadataUpdate = AbstractMetadataEditorComponent.jDaBuXfI3juKoxn0jicw();
      this.processedAssemblyNames = (ISet<string>) new HashSet<string>();
      this.projectReferences = (IDictionary<string, ISet<string>>) new Dictionary<string, ISet<string>>();
      this.metadataByProjects = (IDictionary<string, IDictionary<Guid, IMetadata>>) new Dictionary<string, IDictionary<Guid, IMetadata>>();
      this._typeDescriptorsByUid = new Dictionary<KeyValuePair<Guid, Guid>, ITypeDescriptor>();
      this._typeDescriptorsByType = new Dictionary<Type, ITypeDescriptor>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void cBSlISfIn169p0eSnQLa([In] object obj0) => ((AbstractMetadataEditorComponent) obj0).OnInit();

    internal static void TBjAHJfIOLMfaywRR7cl([In] object obj0) => ((AbstractMetadataEditorComponent) obj0).OnInitComplete();

    internal static object gkSw6ffI2CTeP9V02INX([In] object obj0, [In] object obj1, Guid metadataUid) => (object) ((AbstractMetadataEditorComponent) obj0).GetMetadata((string) obj1, metadataUid);

    internal static object J8l8YHfIesBlDmt2hcCJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool iwGRixfIPO6XxlVQeRpd([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static bool v400lUfITMkYH4fHgtWX() => AbstractMetadataEditorComponent.GGmLhxfIXZPxMDyk1G02 == null;

    internal static AbstractMetadataEditorComponent aQyTjufIkvd8T2eAgq2T() => AbstractMetadataEditorComponent.GGmLhxfIXZPxMDyk1G02;

    internal static bool KKbUJXfI16c7q0SJChIl([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool NJaUx7fIN20UqbclyXD9([In] object obj0) => ((ITypeDescriptor) obj0).UseForId;

    internal static DateTime jDaBuXfI3juKoxn0jicw() => DateTime.Now;

    internal static void zlQdvVfIp7ibX2GwtyJ4([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object r1nf9MfIaRj0o0ChTNVX([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static void jshARyfIDrblKtm4Z11d([In] object obj0, [In] object obj1) => ((ICodeGenerator) obj0).Metadata = (IMetadata) obj1;

    internal static Type cGUtZUfIt1cNiinZpVZY([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool IwHVTxfIw7PjXaFKuwNj([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object lYULLCfI4qH4aZu2Gko4() => (object) ComponentManager.Current;

    internal static void qega7ifI6Yw7adLwqR8b([In] object obj0) => ((ICollection<KeyValuePair<string, ISet<string>>>) obj0).Clear();

    internal static object pvbh22fIH7k3Gmw3VQ5w([In] object obj0) => (object) ComponentManager.GetAssemblyShortName((Assembly) obj0);

    internal static object c1YO8UfIADAxFM4naM02([In] object obj0) => (object) ((ReflectionTypeLoadException) obj0).LoaderExceptions;

    internal static object SVEoIPfI7XxMxaYvHN1c([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (string[]) obj1);

    internal static object TfNsSJfIxpah9yJXNSsu() => (object) Logger.Log;

    internal static object XhYmMWfI0jnRmHBuw1i5([In] object obj0) => (object) ((Assembly) obj0).FullName;

    internal static object RsDDUXfImBFwXlMoIEgj([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void h7TnDxfIyHjfFG2k1eGB([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void swe4MOfIM636DklPk2D7([In] object obj0, [In] object obj1) => ((AbstractMetadataEditorComponent) obj0).AddProject((string) obj1);

    internal static Guid Je6HHRfIJMfh59XuamB5([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static void fymFs5fI9wd3vlp1pjXp([In] object obj0, [In] object obj1, [In] object obj2) => ((AbstractMetadataEditorComponent) obj0).AddOrReplaceMetadata((string) obj1, (IMetadata) obj2);

    internal static bool JXG5fBfIdoBl6OAo31Ak([In] object obj0, [In] object obj1) => ((AbstractMetadataEditorComponent) obj0).ProjectExists((string) obj1);

    internal static void d2FDqufIlXIqwB0ylg62([In] object obj0, [In] object obj1) => ((AbstractMetadataEditorComponent) obj0).RemoveProject((string) obj1);

    internal static Guid V1eTRcfIrjB2cEg6tX3T([In] object obj0) => ((ITypeDescriptor) obj0).SubTypeUid;

    internal static bool HWyRNCfIgGPf7wiRfSQQ([In] object obj0) => ((IRuntimeTypeDescriptor) obj0).IsRuntimeType;

    internal static Type Pf8Sh1fI5BP0p1jcSQ36([In] object obj0) => ((IRuntimeTypeDescriptor) obj0).RuntimeType;

    internal static bool TtGXCtfIjnyl7X6GOPGT([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void jiT7HPfIYnjd6EPZFtlO([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static Type IEArn5fILsDqHjI7jKyd([In] object obj0) => ((IMetadataTypeInfo) obj0).MetadataType;

    internal static object hCovyYfIU237VY8sOQDN([In] object obj0) => (object) ((AbstractMetadataEditorComponent) obj0).CurrentProjectName;

    internal static object GhngnRfIs7MM2nkBLkod([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void FFZOBafIcLXR7LWYvlPf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
