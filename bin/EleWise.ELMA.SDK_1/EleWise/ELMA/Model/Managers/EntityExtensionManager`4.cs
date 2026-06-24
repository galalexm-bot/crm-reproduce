// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.EntityExtensionManager`4
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Менеджер сущности-расширения интерфейса</summary>
  /// <typeparam name="TBase">Тип основной сущности</typeparam>
  /// <typeparam name="T">Тип сущности-расширения</typeparam>
  /// <typeparam name="IdT">Тип идентификатора</typeparam>
  /// <typeparam name="TBaseManager">Тип менеджера основной сущности</typeparam>
  [Component]
  public class EntityExtensionManager<TBase, T, IdT, TBaseManager> : 
    NHManager,
    IEntityExtensionManager<TBase, T, IdT, TBaseManager>,
    IEntityExtensionManager<TBase, T, IdT>,
    IEntityManager<T, IdT>,
    IEntityManager<T>,
    IEntityManager,
    IEntityExtensionManager
    where TBase : class, IEntity<IdT>
    where T : class, TBase
    where TBaseManager : class, IEntityManager<TBase, IdT>
  {
    private TBaseManager manager;
    private static object m2M86thfYSMFKVr9uP7J;

    /// <summary>Менеджер основной сущности</summary>
    public TBaseManager Manager
    {
      get
      {
        if ((object) this.manager == null)
          this.manager = Locator.GetServiceNotNull<TBaseManager>();
        return this.manager;
      }
    }

    IEntityManager<TBase, IdT> IEntityExtensionManager<TBase, T, IdT>.Manager => (IEntityManager<TBase, IdT>) this.Manager;

    /// <summary>Предобработка действия в основном менеджере</summary>
    /// <param name="e">Параметры события</param>
    public virtual void Preprocess(AuditableCancelEventArgs e)
    {
      int num = 3;
      List<object> objectList;
      string name;
      Type[] array1;
      MethodInfo method;
      object[] array2;
      object obj;
      while (true)
      {
        switch (num)
        {
          case 1:
            array2 = objectList.ToArray();
            num = 4;
            continue;
          case 2:
            array1 = ((IEnumerable<ParameterInfo>) e.Method.GetParameters()).Select<ParameterInfo, Type>((Func<ParameterInfo, Type>) (pi => pi.ParameterType)).Concat<Type>((IEnumerable<Type>) new Type[1]
            {
              typeof (bool).MakeByRefType()
            }).ToArray<Type>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 3:
            name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875985911) + e.Method.Name;
            num = 2;
            continue;
          case 4:
            obj = method.Invoke((object) this, array2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 9 : 11;
            continue;
          case 5:
            objectList.AddRange((IEnumerable<object>) e.Params.Values);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 9 : 0;
            continue;
          case 6:
            goto label_3;
          case 7:
            e.Cancel = true;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 5 : 8;
            continue;
          case 8:
            goto label_2;
          case 9:
            objectList.Add((object) false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
            continue;
          case 10:
            if (e.Params != null)
            {
              num = 5;
              continue;
            }
            goto case 9;
          case 11:
            if (!(bool) array2[array2.Length - 1])
            {
              num = 6;
              continue;
            }
            goto case 14;
          case 12:
            if (!(method == (MethodInfo) null))
            {
              objectList = new List<object>();
              num = 10;
              continue;
            }
            num = 13;
            continue;
          case 13:
            goto label_8;
          case 14:
            e.Result = obj;
            num = 7;
            continue;
          default:
            method = this.GetType().GetMethod(name, BindingFlags.Instance | BindingFlags.NonPublic, (Binder) null, array1, (ParameterModifier[]) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 12;
            continue;
        }
      }
label_3:
      return;
label_2:
      return;
label_8:;
    }

    /// <summary>Постобработка действия в основном менеджере</summary>
    /// <param name="e">Параметры события</param>
    public virtual void Postprocess(AuditableEventArgs e)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        MethodInfo methodInfo;
        object obj;
        List<object> objectList;
        object[] array;
        string methodName;
        int pCount;
        AuditableEventArgs e1;
        EntityExtensionManager<TBase, T, IdT, TBaseManager> extensionManager;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (e1.Method.ReturnType != (Type) null)
              {
                num2 = 20;
                continue;
              }
              goto label_17;
            case 2:
              e1.Result = obj;
              num2 = 14;
              continue;
            case 3:
              e1 = e;
              num2 = 15;
              continue;
            case 4:
              num2 = 3;
              continue;
            case 5:
              if (e1.Params == null)
              {
                num2 = 8;
                continue;
              }
              goto case 19;
            case 6:
              if (!e1.Method.ReturnType.IsAssignableFrom(methodInfo.ReturnType))
              {
                num2 = 18;
                continue;
              }
              goto case 2;
            case 7:
              if (!(methodInfo.ReturnType != (Type) null))
              {
                num2 = 10;
                continue;
              }
              goto case 23;
            case 8:
            case 16:
              if (methodInfo.GetParameters().Length == pCount + 1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              }
              goto case 11;
            case 9:
              if (methodInfo == (MethodInfo) null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 12;
                continue;
              }
              objectList = new List<object>();
              num2 = 5;
              continue;
            case 10:
              goto label_25;
            case 11:
              array = objectList.ToArray();
              num2 = 13;
              continue;
            case 12:
              goto label_32;
            case 13:
              obj = methodInfo.Invoke((object) this, array);
              num2 = 7;
              continue;
            case 14:
              goto label_36;
            case 15:
              extensionManager = this;
              num2 = 21;
              continue;
            case 17:
              pCount = e1.Method.GetParameters().Length;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 22 : 3;
              continue;
            case 18:
              goto label_37;
            case 19:
              objectList.AddRange((IEnumerable<object>) e1.Params.Values);
              num2 = 16;
              continue;
            case 20:
              goto label_5;
            case 21:
              methodName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515146653) + e1.Method.Name;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 11 : 17;
              continue;
            case 22:
              methodInfo = ((IEnumerable<MethodInfo>) this.GetType().GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)).Where<MethodInfo>((Func<MethodInfo, bool>) (m =>
              {
                int num3 = 4;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      if (m.GetParameters().Length == pCount + 1)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 0;
                        continue;
                      }
                      goto label_9;
                    case 2:
                      if (!(e1.Method.ReturnType != (Type) null))
                      {
                        num3 = 8;
                        continue;
                      }
                      goto case 6;
                    case 3:
                    case 8:
                      goto label_9;
                    case 4:
                      if (!(m.Name == methodName))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 2 : 3;
                        continue;
                      }
                      goto case 5;
                    case 5:
                      if (m.GetParameters().Length != pCount)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
                        continue;
                      }
                      goto label_8;
                    case 6:
                      if (e1.Method.ReturnType != typeof (void))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_9;
                    case 7:
                      goto label_8;
                    default:
                      if (m.GetParameters()[pCount].ParameterType.IsAssignableFrom(e1.Method.ReturnType))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 7;
                        continue;
                      }
                      goto label_9;
                  }
                }
label_8:
                return extensionManager.IsAssignableParameters(e1.Method.GetParameters(), m.GetParameters());
label_9:
                return false;
              })).FirstOrDefault<MethodInfo>();
              num2 = 9;
              continue;
            case 23:
              if (methodInfo.ReturnType != typeof (void))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
                continue;
              }
              goto label_3;
            default:
              objectList.Add(e1.Result);
              num2 = 11;
              continue;
          }
        }
label_5:
        if (e1.Method.ReturnType != typeof (void))
          num1 = 6;
        else
          goto label_28;
      }
label_25:
      return;
label_32:
      return;
label_36:
      return;
label_37:
      return;
label_28:
      return;
label_17:
      return;
label_3:;
    }

    public virtual int OrderBy(AuditableEventArgs e) => 0;

    /// <summary>Создать новую сущность (без записи в БД)</summary>
    /// <returns>Сущность</returns>
    [PublicApiMember]
    public T Create() => (T) (object) this.Manager.Create();

    /// <summary>
    /// Проверить, является ли сущность новой (не сохраненной в БД)
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>True, если новая</returns>
    [PublicApiMember]
    public bool IsNew(T obj) => this.Manager.IsNew((TBase) obj);

    /// <summary>Проверить, есть ли несохраненные изменения в сущности</summary>
    /// <param name="obj">Сущность</param>
    /// <returns>True, если есть</returns>
    [PublicApiMember]
    public bool IsDirty(T obj) => this.Manager.IsDirty((TBase) obj);

    /// <summary>Проверить, есть ли несохраненные изменения в сущности</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns>True, если есть</returns>
    public bool IsDirty(T obj, object originalState) => this.Manager.IsDirty((TBase) obj, originalState);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Список идентификаторов свойств</returns>
    public Guid[] GetDirtyPropertyUids(T obj) => this.Manager.GetDirtyPropertyUids((TBase) obj);

    /// <summary>Получить идентификаторы измененных свойств</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="originalState">Оригинальное состояние сущности</param>
    /// <returns>Список идентификаторов свойств</returns>
    public Guid[] GetDirtyPropertyUids(T obj, object originalState) => this.Manager.GetDirtyPropertyUids((TBase) obj, originalState);

    /// <summary>
    /// Получить текущее состояние сущности (для применения в функции GetDirtyPropertyUids)
    /// </summary>
    /// <returns></returns>
    public object GetCurrentState(T obj) => this.Manager.GetCurrentState((TBase) obj);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - вызывается исключение
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="id">Идентификатор</param>
    /// <returns>Сущность</returns>
    [PublicApiMember]
    public T Load(IdT id) => (T) (object) this.Manager.Load(id);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Сущность или null</returns>
    [PublicApiMember]
    public T LoadOrNull(IdT id) => (T) (object) this.Manager.LoadOrNull(id);

    /// <summary>
    /// Загрузить по идентификатору. Если не найдена - возвращается новая сущность
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Сущность</returns>
    [PublicApiMember]
    public T LoadOrCreate(IdT id) => (T) (object) this.Manager.LoadOrCreate(id);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - возвращается новая сущность
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="uid">Уникальный идентификатор сущности</param>
    /// <returns>Сущность</returns>
    [PublicApiMember]
    public T LoadOrCreate(Guid uid) => (T) (object) this.Manager.LoadOrCreate(uid);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - вызывается исключение
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="uid">Уникальный идентификатор сущности</param>
    /// <returns>Сущность</returns>
    [PublicApiMember]
    public T Load(Guid uid) => (T) (object) this.Manager.Load(uid);

    /// <summary>
    /// Загрузить по уникальному идентификатору. Если не найдена - возвращается null
    /// </summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="uid">Уникальный идентификатор сущности</param>
    /// <returns>Сущность или null</returns>
    [PublicApiMember]
    public T LoadOrNull(Guid uid) => (T) (object) this.Manager.LoadOrNull(uid);

    /// <summary>Сохранить сущность в БД</summary>
    /// <param name="obj">Сущность</param>
    [PublicApiMember]
    public void Save(T obj) => this.Manager.Save((TBase) obj);

    /// <summary>Удалить сущность в БД</summary>
    /// <param name="obj">Сущность</param>
    [PublicApiMember]
    public void Delete(T obj) => this.Manager.Delete((TBase) obj);

    /// <summary>Удалить все сущности из БД</summary>
    public void DeleteAll()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.DeleteAll();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Обновить (перечитать) сущность из БД</summary>
    /// <param name="obj">Сущность</param>
    [PublicApiMember]
    public void Refresh(T obj) => this.Manager.Refresh((TBase) obj);

    /// <summary>Обновить (перечитать) сущность из БД с блокировкой</summary>
    /// <param name="obj">Сущность</param>
    public void Refresh(T obj, LockMode mode) => this.Manager.Refresh((TBase) obj, mode);

    /// <summary>Найти все сущности</summary>
    /// <returns>Список всех сущностей</returns>
    public ICollection<T> FindAll() => (ICollection<T>) this.Manager.FindAll().Cast<T>().ToList<T>();

    /// <summary>Найти все сущности по идентификаторам из массива</summary>
    /// <remarks>
    /// <see href="http://www.elma-bpm.ru/kb/article-645.html">Как узнать идентификаторы объектов</see>
    /// </remarks>
    /// <param name="idArray">Массив идентификаторов</param>
    /// <returns>Список сущностей</returns>
    [PublicApiMember]
    public ICollection<T> FindByIdArray(IdT[] idArray) => (ICollection<T>) this.Manager.FindByIdArray(idArray).Cast<T>().ToList<T>();

    /// <summary>Найти сущности в соответствии с параметрами выборки</summary>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Список найденных сущностей</returns>
    [PublicApiMember]
    public ICollection<T> Find(FetchOptions fetchOptions) => (ICollection<T>) this.Manager.Find(fetchOptions).Cast<T>().ToList<T>();

    /// <summary>
    /// Найти сущности в соответствии с фильтром и параметрами выборки
    /// </summary>
    /// <param name="filter">Фильтр</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Список найденных сущностей</returns>
    [PublicApiMember]
    public ICollection<T> Find(IEntityFilter filter, FetchOptions fetchOptions) => (ICollection<T>) this.Manager.Find(filter, fetchOptions).Cast<T>().ToList<T>();

    /// <summary>Поиск объектов, удовлетворяющих условию</summary>
    /// <param name="condition">Условие</param>
    /// <returns>Коллекция объектов</returns>
    public ICollection<T> Find(Expression<Func<T, bool>> condition) => this.Manager.Find<T>(condition);

    /// <summary>Поиск объектов, удовлетворяющих условию</summary>
    /// <param name="condition">Условие</param>
    /// <returns>Коллекция объектов</returns>
    public ICollection<TResult> Find<TResult>(Expression<Func<TResult, bool>> condition) => this.Manager.Find<TResult>(condition);

    /// <summary>Поиск объектов, удовлетворяющих условию</summary>
    /// <param name="condition">Условие</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Коллекция объектов</returns>
    public ICollection<T> Find(Expression<Func<T, bool>> condition, FetchOptions fetchOptions) => this.Manager.Find<T>(condition, fetchOptions);

    /// <summary>Поиск объектов, удовлетворяющих условию</summary>
    /// <param name="condition">Условие</param>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <returns>Коллекция объектов</returns>
    public ICollection<TResult> Find<TResult>(
      Expression<Func<TResult, bool>> condition,
      FetchOptions fetchOptions)
    {
      return this.Manager.Find<TResult>(condition, fetchOptions);
    }

    [PublicApiMember]
    public ICollection<T> Find(string eqlFilter) => (ICollection<T>) this.Manager.Find(eqlFilter).Cast<T>().ToList<T>();

    /// <summary>Возвращает количество всех сущностей</summary>
    /// <returns>Количество всех сущностей</returns>
    [PublicApiMember]
    public long Count() => this.Manager.Count();

    /// <summary>Возвращает количество сущностей по фильтру</summary>
    /// <param name="filter">Фильтр</param>
    /// <returns>Количество сущностей по фильтру</returns>
    [PublicApiMember]
    public long Count(IEntityFilter filter) => this.Manager.Count(filter);

    /// <summary>Узнать о наличии объектов</summary>
    /// <returns>Наличие объектов</returns>
    [PublicApiMember]
    public bool Exists() => this.Manager.Exists();

    /// <summary>Узнать о наличии подходящих объектов по фильтру</summary>
    /// <param name="filter">Фильтр объекта</param>
    /// <returns>Наличие объектов по фильтру</returns>
    [PublicApiMember]
    public bool Exists(IEntityFilter filter) => this.Manager.Exists(filter);

    /// <summary>
    /// Проверяет правильность фильтра (основная проверка для EQL), в противном случае исключение
    /// </summary>
    /// <param name="filter">Фильт</param>
    [PublicApiMember]
    public void CheckFilter(IEntityFilter filter)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.CheckFilter(filter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public virtual ExportRuleList ExportRules() => new ExportRuleList();

    public bool ExistPropertiesForFastSearch(IEntityMetadata metadata, IEntityFilter filter = null) => this.Manager.ExistPropertiesForFastSearch(metadata, filter);

    T IEntityManager<T>.Load(object id) => (T) (object) this.Manager.Load(id);

    T IEntityManager<T>.LoadOrNull(object id) => (T) (object) this.Manager.LoadOrNull(id);

    T IEntityManager<T>.LoadOrCreate(object id) => (T) (object) this.Manager.LoadOrCreate(id);

    ICollection<T> IEntityManager<T>.FindByIdArray(object[] idArray) => (ICollection<T>) this.Manager.FindByIdArray(idArray).Cast<T>().ToList<T>();

    /// <summary>
    /// Проверить возможно ли сохранить данную сущность в текущем контексте выполнения
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Результат проверки</returns>
    ActionCheckResult IEntityManager<T>.CanSave(T obj) => this.Manager.CanSave((TBase) obj);

    /// <summary>
    /// Проверить возможно ли удалить данную сущность в текущем контексте выполнения
    /// </summary>
    /// <param name="obj">Сущность</param>
    /// <returns>Результат проверки</returns>
    ActionCheckResult IEntityManager<T>.CanDelete(T obj) => this.Manager.CanDelete((TBase) obj);

    object IEntityManager.Create() => this.Manager.Create();

    bool IEntityManager.IsNew(object obj) => this.Manager.IsNew(obj);

    bool IEntityManager.IsDirty(object obj) => this.Manager.IsDirty(obj);

    bool IEntityManager.IsDirty(object obj, object originalStatej) => this.Manager.IsDirty(obj, originalStatej);

    Guid[] IEntityManager.GetDirtyPropertyUids(object obj) => this.Manager.GetDirtyPropertyUids(obj);

    Guid[] IEntityManager.GetDirtyPropertyUids(object obj, object originalState) => this.Manager.GetDirtyPropertyUids(obj, originalState);

    object IEntityManager.GetCurrentState(object obj) => this.Manager.GetCurrentState(obj);

    object IEntityManager.Load(object id) => this.Manager.Load(id);

    object IEntityManager.LoadOrNull(object id) => this.Manager.LoadOrNull(id);

    object IEntityManager.LoadOrCreate(object id) => this.Manager.LoadOrCreate(id);

    object IEntityManager.LoadOrCreate(Guid uid) => this.Manager.LoadOrCreate(uid);

    object IEntityManager.Load(Guid uid) => this.Manager.Load(uid);

    object IEntityManager.LoadOrNull(Guid uid) => this.Manager.LoadOrNull(uid);

    ActionCheckResult IEntityManager.CanSave(object obj) => this.Manager.CanSave(obj);

    public void Save(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.Save(obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    ActionCheckResult IEntityManager.CanDelete(object obj) => this.Manager.CanDelete(obj);

    public void Delete(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.Delete(obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void Delete(string query)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.Delete(query);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void Refresh(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.Refresh(obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void Refresh(object obj, LockMode mode)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.Refresh(obj, mode);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    IEnumerable IEntityManager.FindAll() => this.Manager.FindAll();

    IEnumerable IEntityManager.FindByIdArray(object[] idArray) => this.Manager.FindByIdArray(idArray);

    IEnumerable IEntityManager.Find(FetchOptions fetchOptions) => this.Manager.Find(fetchOptions);

    IEnumerable IEntityManager.Find(IEntityFilter filter, FetchOptions fetchOptions) => this.Manager.Find(filter, fetchOptions);

    public ICollection<PT> Projection<PT>(string propertyName) => this.Manager.Projection<PT>(propertyName);

    IEnumerable<T1> IEntityManager.Find<T1>(IEntityFilter filter, FetchOptions fetchOptions) => this.Manager.Find<T1>(filter, fetchOptions);

    public void SetupFilter(ICriteria criteria, IEntityFilter filter)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.SetupFilter(criteria, filter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public DetachedCriteria CreateDetachedCriteria(
      FetchOptions fetchOptions,
      Type type,
      string alias = null,
      IEntityFilter filter = null)
    {
      return this.Manager.CreateDetachedCriteria(fetchOptions, type, alias, filter);
    }

    public void FilterDetachedCriteria(
      DetachedCriteria detachedCriteria,
      FetchOptions fetchOptions,
      Type type,
      IEntityFilter filter = null)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Manager.FilterDetachedCriteria(detachedCriteria, fetchOptions, type, filter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public SecurityException CreateSecurityException(string text, object id) => this.Manager.CreateSecurityException(text, id);

    /// <summary>
    /// Тип реализации сущности. Если T - интерфейс, от вернется класс, реализующий его. Если T - класс, то вернется он же.
    /// </summary>
    protected Type ImplementationType => InterfaceActivator.TypeOf<T>();

    /// <summary>
    /// Создать критерий выборки NHibernate для типа сущности менеджера
    /// </summary>
    /// <returns>Критерий</returns>
    protected ICriteria CreateCriteria() => this.ManagerImpl.CreateCriteria();

    /// <summary>Создать критерий выборки NHibernate</summary>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="type">Тип, для которого производится выборка</param>
    /// <param name="alias">Псевдоним</param>
    /// <returns>Критерий</returns>
    protected ICriteria CreateCriteria(FetchOptions fetchOptions, Type type, string alias = null) => this.ManagerImpl.CreateCriteria(fetchOptions, type, alias);

    /// <summary>Создать detached-критерию</summary>
    /// <param name="fetchOptions">Параметры выборки</param>
    /// <param name="type">Тип, для которого производится выборка</param>
    /// <param name="alias">Псевдоним</param>
    /// <returns>Критерий</returns>
    protected DetachedCriteria CreateDetachedCriteria(
      FetchOptions fetchOptions,
      Type type,
      string alias = null)
    {
      return this.ManagerImpl.CreateDetachedCriteria(fetchOptions, type, alias, (IEntityFilter) null);
    }

    /// <summary>
    /// Действие перед созданием новой сущности (без записи в БД)
    /// </summary>
    /// <param name="cancel">Если установить в True, то дальнейшая обработка не производится</param>
    /// <returns>Сущность</returns>
    protected virtual T OnPreCreate(ref bool cancel) => default (T);

    /// <summary>
    /// Действие после создания новой сущности (без записи в БД)
    /// </summary>
    /// <param name="obj">Сущность</param>
    protected virtual T OnCreate(T obj) => obj;

    /// <summary>
    /// Действие перед загрузкой сущности. Если не найдена - вызывается исключение
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="cancel">Если установить в True, то дальнейшая обработка не производится</param>
    /// <returns>Сущность</returns>
    protected virtual T OnPreLoad(IdT id, ref bool cancel) => default (T);

    /// <summary>
    /// Действие после загрузки сущности. Если не найдена - вызывается исключение
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="obj">Сущность</param>
    /// <returns>Сущность</returns>
    protected virtual T OnLoad(IdT id, T obj) => obj;

    /// <summary>
    /// Действие перед загрузкой сущности. Если не найдена - возвращается null
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="cancel">Если установить в True, то дальнейшая обработка не производится</param>
    /// <returns>Сущность</returns>
    protected virtual T OnPreLoadOrNull(IdT id, ref bool cancel) => default (T);

    /// <summary>
    /// Действие после загрузки сущности. Если не найдена - возвращается null
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="obj">Сущность</param>
    /// <returns>Сущность</returns>
    protected virtual T OnLoadOrNull(IdT id, T obj) => obj;

    protected void OnPreSave(TBase obj, ref bool cancel) => this.OnPreSave((T) (object) obj, ref cancel);

    /// <summary>Действие перед сохранением сущности в БД</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="cancel">Если установить в True, то дальнейшая обработка не производится</param>
    protected virtual void OnPreSave(T obj, ref bool cancel)
    {
    }

    /// <summary>Действие после сохранения сущности в БД</summary>
    /// <param name="obj">Сущность</param>
    protected virtual void OnSave(T obj)
    {
    }

    /// <summary>Действие перед удалением сущности в БД</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="cancel">Если установить в True, то дальнейшая обработка не производится</param>
    protected virtual void OnPreDelete(T obj, ref bool cancel)
    {
    }

    /// <summary>Действие после удаления сущности в БД</summary>
    /// <param name="obj">Сущность</param>
    protected virtual void OnDelete(T obj)
    {
    }

    /// <summary>
    /// Действие перед удалением сущностей по результату запроса
    /// </summary>
    /// <param name="query">Запрос</param>
    /// <param name="cancel">Если установить в True, то дальнейшая обработка не производится</param>
    protected virtual void OnPreDelete(string query, ref bool cancel)
    {
    }

    /// <summary>
    /// Действие после удаления сущностей по результату запроса
    /// </summary>
    /// <param name="query">Запрос</param>
    protected virtual void OnDelete(string query)
    {
    }

    /// <summary>Действие перед обновлением сущности из БД</summary>
    /// <param name="obj">Сущность</param>
    /// <param name="cancel">Если установить в True, то дальнейшая обработка не производится</param>
    protected virtual void OnPreRefresh(T obj, ref bool cancel)
    {
    }

    /// <summary>Действие после обновления сущности из БД</summary>
    /// <param name="obj">Сущность</param>
    protected virtual void OnRefresh(T obj)
    {
    }

    /// <summary>Действие перед применением фильтра к критерию выбора</summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="filter">Фильтр</param>
    /// <param name="cancel">Если установить в True, то дальнейшая обработка не производится</param>
    protected virtual void OnPreSetupFilter(
      ICriteria criteria,
      IEntityFilter filter,
      ref bool cancel)
    {
    }

    /// <summary>Действие после применения фильтра к критерию выбора</summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="filter">Фильтр</param>
    protected virtual void OnSetupFilter(ICriteria criteria, IEntityFilter filter)
    {
    }

    /// <summary>Действие перед применением строки быстрого поиска</summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="filter">Фильтр</param>
    /// <param name="cancel">Если установить в True, то дальнейшая обработка не производится</param>
    protected virtual void OnPreSetupFastSearchFilter(
      ICriteria criteria,
      IEntityFilter filter,
      ref bool cancel)
    {
    }

    /// <summary>Действие после применения строки быстрого поиска</summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="filter">Фильтр</param>
    protected virtual void OnSetupFastSearchFilter(ICriteria criteria, IEntityFilter filter)
    {
    }

    private bool IsAssignableParameters(
      ParameterInfo[] sourceParameters,
      ParameterInfo[] targetParameters)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              goto label_5;
            case 3:
              goto label_16;
            case 4:
            case 7:
            case 10:
              goto label_9;
            case 5:
              if (sourceParameters == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 4 : 4;
                continue;
              }
              goto case 9;
            case 8:
              if (targetParameters[index].ParameterType.IsAssignableFrom(sourceParameters[index].ParameterType))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 11 : 0;
                continue;
              }
              goto label_5;
            case 9:
              if (targetParameters == null)
              {
                num2 = 7;
                continue;
              }
              goto label_16;
            case 11:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 6 : 6;
              continue;
            case 12:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
              continue;
            default:
              if (index >= sourceParameters.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
                continue;
              }
              goto case 8;
          }
        }
label_16:
        if (sourceParameters.Length <= targetParameters.Length)
          num1 = 12;
        else
          goto label_9;
      }
label_5:
      return false;
label_9:
      return false;
label_13:
      return true;
    }

    private EntityManager<TBase, IdT> ManagerImpl => (EntityManager<TBase, IdT>) (object) this.Manager;

    /// <summary>Обработчик действий с сущностью</summary>
    [NotNull]
    public IEntityActionHandler ActionHandler
    {
      get => this.\u003CActionHandler\u003Ek__BackingField;
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
              this.\u003CActionHandler\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
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

    public EntityExtensionManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool dVuBXMhfLwEAC9fqg7MA() => EntityExtensionManager<TBase, T, IdT, TBaseManager>.m2M86thfYSMFKVr9uP7J == null;

    internal static object e3uhAWhfUKs8W2xLEjB2() => EntityExtensionManager<TBase, T, IdT, TBaseManager>.m2M86thfYSMFKVr9uP7J;
  }
}
