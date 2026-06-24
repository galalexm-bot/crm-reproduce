// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.LinkedFinderBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components
{
  /// <summary>
  /// Базовый класс для реализаций точек расширения поиска связанных объектов
  /// </summary>
  public abstract class LinkedFinderBase : ILinkedFinder
  {
    internal static LinkedFinderBase X2syZyfhd5ceA4UetVZ2;

    /// <summary>Расширения для работы с зависимостями</summary>
    public IEnumerable<IDependenciesExtension> DependenciesExtensions { get; set; }

    /// <inheritdoc />
    public abstract FindLinkedObjectsResult FindLinkedObjects(
      ICollection<ILinkedObject> metadataList,
      LinkedObjectsContext context);

    /// <inheritdoc />
    public virtual FindLinkedObjectsResult FindLinkedObjects(
      ICollection<ILinkedObject> metadataList,
      RuntimeObjectsContext emptyContext)
    {
      throw new NotImplementedException();
    }

    /// <summary>Получение метаданных по идентификатору</summary>
    /// <param name="metadataId">Идентификатор метаданных</param>
    /// <param name="context">Контекст проверки</param>
    /// <returns>Метаданные</returns>
    protected abstract IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context);

    /// <summary>Получить метаданные из контекста проверки</summary>
    /// <param name="metadataId">Ид метаданных</param>
    /// <param name="context">Контекст проверки</param>
    /// <param name="resultObj">Результат проверки</param>
    /// <returns>Метаданные</returns>
    protected IMetadata GetMetadata(
      Guid metadataId,
      LinkedObjectsContext context,
      FindLinkedObjectsResult resultObj)
    {
      int num1 = 7;
      IMetadata metadataWithUid;
      while (true)
      {
        int num2 = num1;
        Guid metadataId1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!context.LoadedMetadata.TryGetValue(metadataId1, out metadataWithUid))
              {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (context.AllObjects.FirstOrDefault<ILinkedObject>((Func<ILinkedObject, bool>) (m => LinkedFinderBase.\u003C\u003Ec__DisplayClass7_0.mUR2aT89xyH7MRLIsDIA(LinkedFinderBase.\u003C\u003Ec__DisplayClass7_0.Fak1Hs897YHNOeSKoiWk((object) m), metadataId1))) != null)
                {
                  num2 = 5;
                  continue;
                }
                goto label_9;
              }
              else
              {
                num2 = 4;
                continue;
              }
            case 2:
              goto label_4;
            case 3:
              goto label_8;
            case 4:
              goto label_5;
            case 5:
              metadataWithUid = this.GetMetadataWithUid(metadataId1, context);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 6:
              metadataId1 = metadataId;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
              continue;
            case 7:
              num2 = 6;
              continue;
            default:
              if (metadataWithUid != null)
              {
                num2 = 2;
                continue;
              }
              goto label_8;
          }
        }
label_4:
        context.LoadedMetadata[metadataId1] = metadataWithUid;
        num1 = 3;
      }
label_5:
      return metadataWithUid;
label_8:
      return metadataWithUid;
label_9:
      return (IMetadata) null;
    }

    /// <summary>
    /// Заполнить контекст проверки и результат. Отмечает элемент как связанный
    /// </summary>
    /// <param name="resultObj">Результат проверки</param>
    /// <param name="context">Контекст проверки</param>
    /// <param name="mdId">Ид метаданных</param>
    protected void FillObj(
      FindLinkedObjectsResult resultObj,
      LinkedObjectsContext context,
      Guid mdId)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        ILinkedObject obj;
        Guid mdId1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_7;
            case 1:
              goto label_11;
            case 2:
              context.CheckedObjects.Add(obj);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 4 : 12;
              continue;
            case 3:
              goto label_5;
            case 4:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 1;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (resultObj.LinkedObjects.All<ILinkedObject>((Func<ILinkedObject, bool>) (item => LinkedFinderBase.\u003C\u003Ec__DisplayClass8_1.kutru389YoAE8976UVuM(LinkedFinderBase.\u003C\u003Ec__DisplayClass8_1.jFeiqg89jru1w4hbKjTN((object) item), LinkedFinderBase.\u003C\u003Ec__DisplayClass8_1.jFeiqg89jru1w4hbKjTN((object) obj)))))
              {
                num2 = 10;
                continue;
              }
              goto case 6;
            case 6:
              resultObj.AddedObjects.Add(obj);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 2 : 2;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!context.AllObjects.Any<ILinkedObject>((Func<ILinkedObject, bool>) (item => LinkedFinderBase.\u003C\u003Ec__DisplayClass8_0.Mx0Ppr899suLSMFjox7d(LinkedFinderBase.\u003C\u003Ec__DisplayClass8_0.lahNTM89JB7tPp8PcQcp((object) item), mdId1))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
                continue;
              }
              goto case 11;
            case 8:
              mdId1 = mdId;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 7;
              continue;
            case 9:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 7 : 8;
              continue;
            case 10:
              resultObj.LinkedObjects.Add(obj);
              num2 = 6;
              continue;
            case 11:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!context.CheckedObjects.All<ILinkedObject>((Func<ILinkedObject, bool>) (md => LinkedFinderBase.\u003C\u003Ec__DisplayClass8_0.YBoWQQ89dHuNv3hb1l9F(LinkedFinderBase.\u003C\u003Ec__DisplayClass8_0.lahNTM89JB7tPp8PcQcp((object) md), mdId1))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 3 : 0;
                continue;
              }
              goto case 4;
            case 12:
              goto label_3;
            default:
              goto label_19;
          }
        }
label_11:
        // ISSUE: reference to a compiler-generated method
        obj = context.AllObjects.First<ILinkedObject>((Func<ILinkedObject, bool>) (item => LinkedFinderBase.\u003C\u003Ec__DisplayClass8_0.lahNTM89JB7tPp8PcQcp((object) item) == mdId1));
        num1 = 5;
      }
label_7:
      return;
label_5:
      return;
label_3:
      return;
label_19:;
    }

    /// <summary>
    /// Получение объекта из контекста (если он был ранее туда загружен) или новая загрузка
    /// </summary>
    /// <typeparam name="T">Тип объекта</typeparam>
    /// <param name="uid">UID объекта</param>
    /// <param name="context">Контекст проверки</param>
    /// <param name="loadFn">Метод для загрузки данных об объекте по uid</param>
    /// <returns>Объект типа T</returns>
    protected T GetObjectFromContextLoadedDataOrLoad<T>(
      Guid uid,
      LinkedObjectsContext context,
      Func<Guid, T> loadFn)
      where T : class
    {
      object obj;
      if (context.LoadedData.TryGetValue(uid, out obj))
      {
        if (obj is T loadedDataOrLoad1)
          return loadedDataOrLoad1;
      }
      else
      {
        T loadedDataOrLoad2 = loadFn(uid);
        if ((object) loadedDataOrLoad2 != null)
        {
          context.LoadedData[uid] = (object) loadedDataOrLoad2;
          return loadedDataOrLoad2;
        }
      }
      return default (T);
    }

    /// <summary>Поиск зависимостей по свойствам</summary>
    /// <param name="md">Метаданные для поиска зависимостей</param>
    /// <param name="context">Контекст проверки</param>
    /// <param name="resultObj">Результат проверки</param>
    protected void FillProperties(
      ClassMetadata md,
      LinkedObjectsContext context,
      FindLinkedObjectsResult resultObj)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        ClassMetadata md1;
        LinkedFinderBase linkedFinderBase;
        FindLinkedObjectsResult resultObj1;
        LinkedObjectsContext context1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              linkedFinderBase = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_7;
            case 3:
              context1 = context;
              num2 = 2;
              continue;
            case 4:
              md1 = md;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 1;
              continue;
            case 5:
              num2 = 4;
              continue;
            case 6:
              goto label_3;
            default:
              resultObj1 = resultObj;
              num2 = 3;
              continue;
          }
        }
label_7:
        PropertyDependencyHelper.PropertiesProcessing(md1, context1.AllObjects).ForEach<ILinkedObject>((Action<ILinkedObject>) (item =>
        {
          int num3 = 3;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_3;
              case 2:
                goto label_2;
              case 3:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!LinkedFinderBase.\u003C\u003Ec__DisplayClass10_0.qwRC8489zR70qE6pTi8A(item.Uid, LinkedFinderBase.\u003C\u003Ec__DisplayClass10_0.pBAKaN89c3Nc7Tw9GZHr((object) md1)))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 2 : 2;
                  continue;
                }
                break;
            }
            linkedFinderBase.FillObj(resultObj1, context1, item.Uid);
            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 0;
          }
label_3:
          return;
label_2:;
        }));
        num1 = 6;
      }
label_3:;
    }

    /// <summary>Поиск зависимостей по посчитанным зависимостям</summary>
    /// <param name="mdUid">Идентификатор метаданных для поиска зависимостей</param>
    /// <param name="context">Контекст проверки</param>
    /// <param name="resultObj">Результат проверки</param>
    protected void FillDependencies(
      Guid mdUid,
      LinkedObjectsContext context,
      FindLinkedObjectsResult resultObj)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        Guid mdUid1;
        LinkedFinderBase linkedFinderBase;
        FindLinkedObjectsResult resultObj1;
        LinkedObjectsContext context1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_3;
            case 1:
              goto label_6;
            case 2:
              resultObj1 = resultObj;
              num2 = 6;
              continue;
            case 3:
              mdUid1 = mdUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
              continue;
            case 4:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 2 : 3;
              continue;
            case 5:
              this.GetObjectsUidsFromDependencies(mdUid1).ForEach<Guid>((Action<Guid>) (dependencyId =>
              {
                int num3 = 3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_3;
                    case 2:
                      goto label_2;
                    case 3:
                      if (!(dependencyId != mdUid1))
                      {
                        num3 = 2;
                        continue;
                      }
                      break;
                  }
                  linkedFinderBase.FillObj(resultObj1, context1, dependencyId);
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 1;
                }
label_3:
                return;
label_2:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
              continue;
            case 6:
              context1 = context;
              num2 = 5;
              continue;
            default:
              goto label_10;
          }
        }
label_6:
        linkedFinderBase = this;
        num1 = 2;
      }
label_3:
      return;
label_10:;
    }

    /// <summary>Дополнить свойства метаданных</summary>
    /// <typeparam name="T">Наследник EntityMetadata</typeparam>
    /// <param name="metadata">Метаданные для наполнения</param>
    /// <returns></returns>
    protected T FillMetadataProperties<T>(T metadata) where T : EntityMetadata
    {
      if ((object) metadata == null)
        return default (T);
      metadata.Properties.AddRange((IEnumerable<PropertyMetadata>) metadata.EntityProperties);
      metadata.TableParts.AddRange((IEnumerable<TablePartMetadata>) metadata.EntityTableParts);
      return metadata;
    }

    private ICollection<Guid> GetObjectsUidsFromDependencies(Guid uid)
    {
      HashSet<Guid> result = new HashSet<Guid>();
      foreach (IDependencyContainer dependencyContainer in this.DependenciesExtensions.SelectMany<IDependenciesExtension, IDependencyContainer>((Func<IDependenciesExtension, IEnumerable<IDependencyContainer>>) (point => point.GetDependencyContainers(uid))))
      {
        if (dependencyContainer is MetadataDependencyContainer dependencies1)
          this.GetObjectsUidsFromDependencies(dependencies1, (ISet<Guid>) result);
        if (dependencyContainer is ScriptModuleDependencyContainer dependencies2)
          this.GetObjectsUidsFromDependencies(dependencies2, (ISet<Guid>) result);
        if (dependencyContainer is ComponentDependencyContainer dependencies3)
          this.GetObjectsUidsFromDependencies(dependencies3, (ISet<Guid>) result);
      }
      result.Remove(Guid.Empty);
      return (ICollection<Guid>) result;
    }

    /// <summary>
    /// Получить идентификаторы зависимых объектов из контейнера зависимостей метаданных
    /// </summary>
    private void GetObjectsUidsFromDependencies(
      MetadataDependencyContainer dependencies,
      ISet<Guid> result)
    {
      if (dependencies == null)
        return;
      this.GetObjectsUidsFromDependencies((ICollection<EntityDependency>) dependencies.EntityDependencies, result);
      this.GetObjectsUidsFromDependencies((ICollection<EnumDependency>) dependencies.EnumDependencies, result);
      this.GetObjectsUidsFromDependencies((ICollection<DataClassDependency>) dependencies.DataClassDependencies, result);
      this.GetObjectsUidsFromDependencies((ICollection<FunctionDependency>) dependencies.FunctionDependencies, result);
      if (dependencies.FormDependencies == null)
        return;
      foreach (FormViewItemDependencyContainer formDependency in dependencies.FormDependencies)
      {
        this.GetObjectsUidsFromDependencies((ICollection<EntityDependency>) formDependency.EntityDependencies, result);
        this.GetObjectsUidsFromDependencies((ICollection<DataClassDependency>) formDependency.DataClassDependencies, result);
        this.GetObjectsUidsFromDependencies((ICollection<ComponentDependency>) formDependency.ComponentDependencies, result);
      }
    }

    /// <summary>
    /// Получить идентификаторы зависимых объектов из контейнера зависимостей скрипта
    /// </summary>
    private void GetObjectsUidsFromDependencies(
      ScriptModuleDependencyContainer dependencies,
      ISet<Guid> result)
    {
      if (dependencies == null)
        return;
      this.GetObjectsUidsFromDependencies((ICollection<EntityDependency>) dependencies.EntityDependencies, result);
      this.GetObjectsUidsFromDependencies((ICollection<DataClassDependency>) dependencies.DataClassDependencies, result);
    }

    /// <summary>
    /// Получить идентификаторы зависимых объектов из контейнера зависимостей скрипта
    /// </summary>
    private void GetObjectsUidsFromDependencies(
      ComponentDependencyContainer dependencies,
      ISet<Guid> result)
    {
      if (dependencies == null)
        return;
      this.GetObjectsUidsFromDependencies((ICollection<EntityDependency>) dependencies.EntityDependencies, result);
      this.GetObjectsUidsFromDependencies((ICollection<EnumDependency>) dependencies.EnumDependencies, result);
      this.GetObjectsUidsFromDependencies((ICollection<DataClassDependency>) dependencies.DataClassDependencies, result);
      this.GetObjectsUidsFromDependencies((ICollection<FunctionDependency>) dependencies.FunctionDependencies, result);
      this.GetHeadersUidsFromDependencies((ICollection<ComponentDependency>) dependencies.ComponentDependencies, result);
    }

    /// <summary>
    /// Получить идентификаторы зависимых сущностей из зависимостей метаданных
    /// </summary>
    private void GetObjectsUidsFromDependencies(
      ICollection<EntityDependency> entityDependencies,
      ISet<Guid> result)
    {
      if (entityDependencies == null)
        return;
      foreach (EntityDependency entityDependency in (IEnumerable<EntityDependency>) entityDependencies)
      {
        if (entityDependency.HeaderUid != Guid.Empty)
        {
          Guid interfaceUid = this.GetInterfaceUid(entityDependency);
          result.Add(interfaceUid);
        }
        if (entityDependency.Properties != null)
          entityDependency.Properties.ForEach((Action<PropertySignature>) (property =>
          {
            int num1 = 4;
            while (true)
            {
              int num2 = num1;
              while (true)
              {
                TypeSignature typeSignature;
                switch (num2)
                {
                  case 1:
                    goto label_5;
                  case 2:
label_4:
                    result.Add(property.Type.SubTypeUid);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 0;
                    continue;
                  case 3:
                    typeSignature = property.Type;
                    break;
                  case 4:
                    if (property == null)
                      goto default;
                    else
                      goto label_8;
                  case 5:
                    goto label_3;
                  default:
                    typeSignature = (TypeSignature) null;
                    break;
                }
                if (typeSignature == null)
                  num2 = 5;
                else
                  goto label_4;
              }
label_8:
              num1 = 3;
            }
label_5:
            return;
label_3:;
          }));
      }
    }

    /// <summary>
    /// Получить Uid интерфейса сущности, который будет экспортирован
    /// </summary>
    /// <param name="dependency">Зависимость от сущности</param>
    /// <returns>Uid интерфейса сущности</returns>
    private Guid GetInterfaceUid(EntityDependency dependency)
    {
      int num1 = 2;
      EntityMetadataType entityMetadataType;
      IMetadata metadata;
      Guid empty;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_17:
            if (metadata is EntityMetadata entityMetadata)
            {
              num1 = 3;
              continue;
            }
            goto label_19;
          case 2:
            try
            {
              metadata = ((IMetadataService) LinkedFinderBase.wdseOIfhgJorlXpuFjke()).GetMetadata(LinkedFinderBase.Fdm4Fafh5ihLvZf5um0b((object) dependency), false);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_17;
              }
            }
            catch (Exception ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    empty = Guid.Empty;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_16;
                }
              }
            }
          case 3:
            entityMetadataType = LinkedFinderBase.kFaKksfhjyt1Xwqs7YUs((object) entityMetadata);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 7 : 1;
            continue;
          case 4:
            goto label_19;
          case 5:
            goto label_4;
          case 6:
            LinkedFinderBase.sruJdXfhcbGVwjoi6hVE(LinkedFinderBase.F372YYfhs7K4uptrmxyy(), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -868014334), (object) LinkedFinderBase.kFaKksfhjyt1Xwqs7YUs((object) entityMetadata)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
            continue;
          case 7:
            switch (entityMetadataType)
            {
              case EntityMetadataType.Entity:
              case EntityMetadataType.Interface:
                goto label_5;
              case EntityMetadataType.InterfaceExtension:
                goto label_6;
              case EntityMetadataType.InterfaceImplementation:
                goto label_4;
              default:
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 6 : 0;
                continue;
            }
          default:
            goto label_15;
        }
      }
label_4:
      return LinkedFinderBase.FiWwlIfhYJ4iOO0i5Fm4((object) entityMetadata);
label_5:
      return LinkedFinderBase.pkmBMafhLv1FFGPCaq8F((object) entityMetadata);
label_6:
      return LinkedFinderBase.ofWDEefhU97XNSRKFVUJ((object) entityMetadata);
label_15:
      return LinkedFinderBase.Fdm4Fafh5ihLvZf5um0b((object) dependency);
label_16:
      return empty;
label_19:
      return LinkedFinderBase.Fdm4Fafh5ihLvZf5um0b((object) dependency);
    }

    /// <summary>
    /// Получить идентификаторы зависимых перечислений из зависимостей метаданных
    /// </summary>
    private void GetObjectsUidsFromDependencies(
      ICollection<EnumDependency> enumDependencies,
      ISet<Guid> result)
    {
      if (enumDependencies == null)
        return;
      foreach (EnumDependency enumDependency in (IEnumerable<EnumDependency>) enumDependencies)
        result.Add(enumDependency.HeaderUid);
    }

    /// <summary>
    /// Получить идентификаторы зависимых датаклассов из зависимостей метаданных
    /// </summary>
    private void GetObjectsUidsFromDependencies(
      ICollection<DataClassDependency> dataClassDependencies,
      ISet<Guid> result)
    {
      if (dataClassDependencies == null)
        return;
      foreach (DataClassDependency dataClassDependency in (IEnumerable<DataClassDependency>) dataClassDependencies)
      {
        result.Add(dataClassDependency.HeaderUid);
        if (dataClassDependency.Properties != null)
          dataClassDependency.Properties.ForEach((Action<PropertySignature>) (property =>
          {
            int num = 1;
            while (true)
            {
              TypeSignature typeSignature;
              switch (num)
              {
                case 1:
                  if (property != null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
                    continue;
                  }
                  goto case 4;
                case 2:
                  goto label_3;
                case 3:
                  result.Add(property.Type.SubTypeUid);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 2;
                  continue;
                case 4:
                  typeSignature = (TypeSignature) null;
                  break;
                default:
                  typeSignature = property.Type;
                  break;
              }
              if (typeSignature != null)
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 3 : 0;
              else
                goto label_2;
            }
label_3:
            return;
label_2:;
          }));
      }
    }

    /// <summary>
    /// Получить идентификаторы зависимых компонентов из зависимостей метаданных
    /// </summary>
    private void GetObjectsUidsFromDependencies(
      ICollection<ComponentDependency> componentDependencies,
      ISet<Guid> result)
    {
      if (componentDependencies == null)
        return;
      foreach (ComponentDependency componentDependency in (IEnumerable<ComponentDependency>) componentDependencies)
      {
        result.Add(componentDependency.HeaderUid);
        if (componentDependency.Inputs != null)
          componentDependency.Inputs.ForEach((Action<InputComputedValue>) (input =>
          {
            int num = 3;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_3;
                case 2:
                  goto label_2;
                case 3:
                  if (input == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 2 : 2;
                    continue;
                  }
                  break;
              }
              // ISSUE: reference to a compiler-generated method
              result.Add(LinkedFinderBase.\u003C\u003Ec__DisplayClass21_0.jI1aPA8diOa0cE4fqarl((object) input));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 0;
            }
label_3:
            return;
label_2:;
          }));
      }
    }

    /// <summary>
    /// Получить идентификаторы заголовков зависимых компонентов из зависимостей
    /// </summary>
    private void GetHeadersUidsFromDependencies(
      ICollection<ComponentDependency> componentDependencies,
      ISet<Guid> result)
    {
      if (componentDependencies == null)
        return;
      foreach (ComponentDependency componentDependency in (IEnumerable<ComponentDependency>) componentDependencies)
        result.Add(componentDependency.HeaderUid);
    }

    /// <summary>
    /// Получить идентификаторы зависимых функций из зависимостей метаданных
    /// </summary>
    private void GetObjectsUidsFromDependencies(
      ICollection<FunctionDependency> functionDependencies,
      ISet<Guid> result)
    {
      if (functionDependencies == null)
        return;
      foreach (FunctionDependency functionDependency in (IEnumerable<FunctionDependency>) functionDependencies)
      {
        result.Add(functionDependency.HeaderUid);
        Guid? nullable1;
        if (functionDependency != null)
        {
          TypeSignature parameterType = functionDependency.ParameterType;
          Guid? nullable2;
          if (parameterType == null)
          {
            nullable1 = new Guid?();
            nullable2 = nullable1;
          }
          else
            nullable2 = new Guid?(parameterType.SubTypeUid);
          nullable1 = nullable2;
          if (nullable1.HasValue)
            result.Add(functionDependency.ParameterType.SubTypeUid);
        }
        if (functionDependency != null)
        {
          TypeSignature returnType = functionDependency.ReturnType;
          Guid? nullable3;
          if (returnType == null)
          {
            nullable1 = new Guid?();
            nullable3 = nullable1;
          }
          else
            nullable3 = new Guid?(returnType.SubTypeUid);
          nullable1 = nullable3;
          if (nullable1.HasValue)
            result.Add(functionDependency.ReturnType.SubTypeUid);
        }
      }
    }

    protected LinkedFinderBase()
    {
      LinkedFinderBase.p6DUv3fhzXCNhla6iw8W();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool kEDFFYfhlhXS9XwrHjff() => LinkedFinderBase.X2syZyfhd5ceA4UetVZ2 == null;

    internal static LinkedFinderBase C0UbQQfhrQu5trNcEmmc() => LinkedFinderBase.X2syZyfhd5ceA4UetVZ2;

    internal static object wdseOIfhgJorlXpuFjke() => (object) MetadataServiceContext.Service;

    internal static Guid Fdm4Fafh5ihLvZf5um0b([In] object obj0) => ((Dependency) obj0).HeaderUid;

    internal static EntityMetadataType kFaKksfhjyt1Xwqs7YUs([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid FiWwlIfhYJ4iOO0i5Fm4([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static Guid pkmBMafhLv1FFGPCaq8F([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static Guid ofWDEefhU97XNSRKFVUJ([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static object F372YYfhs7K4uptrmxyy() => (object) Logger.Log;

    internal static void sruJdXfhcbGVwjoi6hVE([In] object obj0, [In] object obj1) => ((ILogger) obj0).Warn(obj1);

    internal static void p6DUv3fhzXCNhla6iw8W() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
