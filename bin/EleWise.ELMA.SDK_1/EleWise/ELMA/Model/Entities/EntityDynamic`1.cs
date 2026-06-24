// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityDynamic`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH.Proxy;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Properties;
using NHibernate.Proxy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Entities
{
  /// <summary>
  /// Сущность с идентификатором, поддерживающая работу с внутренним контейнером
  /// </summary>
  /// <typeparam name="IdT">Тип идентификатора (первичного ключа)</typeparam>
  [DebuggerTypeProxy(typeof (DynamicDebugView))]
  [DefaultManager(typeof (EntityManagerMaker))]
  [DataContract]
  [Component(InjectProerties = false)]
  [Serializable]
  public abstract class EntityDynamic<IdT> : 
    Entity<IdT>,
    IValueContainerObjectInternal,
    IDynamicMetaObjectProvider,
    IEntityProxy,
    INHibernateProxy,
    IEntityDynamic
  {
    private ILazyInitializer lazyInitializer;
    private static IDictionary<Guid, IGetter> titlePropertyGetters;
    internal static object g5bMWUh8x1AYkcmpahTm;

    /// <summary>Получить экземпляр класса</summary>
    /// <param name="creator">Метод создания</param>
    /// <returns>Экземпляр класса</returns>
    protected internal static ICreator<T, TData> ResolveCreator<T, TData, TClassData>(
      Func<T, TData> creator)
      where TData : class
      where TClassData : TData
    {
      return Creator<T>.ResolveCreator<TData, TClassData>(creator);
    }

    /// <inheritdoc />
    DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) => (DynamicMetaObject) new MetaDynamic(parameter, (IValueContainerObjectInternal) this, (GetPropertyAccessorDelegate) (name => this.GetType().GetAccessor(name, false)));

    IEnumerable<object> IValueContainerObjectInternal.GetData() => this.GetData͏();

    /// <summary>Получить контейнеры с данными</summary>
    protected internal virtual IEnumerable<object> GetData͏() => Enumerable.Empty<object>();

    /// <summary>Получить список ассоров</summary>
    /// <remarks><see cref="!:ValueContainerObjectInternalExtensions.GetAccessors͏" /></remarks>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IEnumerable<object> GetAccessors͏() => Enumerable.Empty<object>();

    /// <summary>
    /// LazyInitializer для сущности поддерживающей работу с контейнером
    /// </summary>
    ILazyInitializer INHibernateProxy.HibernateLazyInitializer => this.lazyInitializer;

    /// <summary>
    /// Создание LazyInitializer для сущности поддерживающей работу с контейнером
    /// </summary>
    INHibernateProxy IEntityProxy.InitLazyInitializer(ILazyInitializer lazyInitializer)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Id = (IdT) lazyInitializer.Identifier;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          case 2:
            this.lazyInitializer = lazyInitializer;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return (INHibernateProxy) this;
    }

    /// <summary>
    /// Получение уникального идентификатора типа с учетом наследования
    /// </summary>
    /// <param name="entity">Экземпляр сущности</param>
    /// <param name="uid">Уникальный идентификатор типа</param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    protected internal static Guid GetTypeUid(EntityDynamic<IdT> entity, Guid uid) => !(entity.lazyInitializer?.GetImplementation() is IInheritable implementation) ? uid : implementation.TypeUid;

    Guid IEntityDynamic.TypeUid => this.TypeUid͏;

    protected internal abstract Guid TypeUid͏ { get; }

    /// <inheritdoc />
    public override string ToString()
    {
      int num1 = 3;
      IGetter orAdd;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            if (orAdd != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            orAdd = EntityDynamic<IdT>.titlePropertyGetters.GetOrAdd<Guid, IGetter>(this.TypeUid͏, (Func<Guid, IGetter>) (metadataUid =>
            {
              int num2 = 3;
              PropertyMetadata titleProperty;
              while (true)
              {
                int num3 = num2;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_4;
                    case 2:
                      if (titleProperty == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
                        continue;
                      }
                      goto label_3;
                    case 3:
                      goto label_5;
                    default:
                      goto label_3;
                  }
                }
label_5:
                titleProperty = ((ClassMetadata) MetadataLoader.LoadMetadata(metadataUid)).GetTitleProperty();
                num2 = 2;
              }
label_3:
              return this.GetType().GetGetter(titleProperty.Name, false);
label_4:
              return (IGetter) null;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 2;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return base.ToString();
label_3:
      return (string) orAdd.Get((object) this);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool TypeAssignable([NotNull] object obj)
    {
      int num = 3;
      Type type1;
      Type type2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            type1 = obj.GetType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          case 3:
            type2 = this.GetType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_7;
          case 5:
            if (!type1.IsAssignableFrom(type2))
            {
              num = 4;
              continue;
            }
            goto label_8;
          default:
            if (type2 == type1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
              continue;
            }
            goto case 5;
        }
      }
label_7:
      return type2.IsAssignableFrom(type1);
label_8:
      return true;
    }

    protected EntityDynamic()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityDynamic()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            EntityDynamic<IdT>.titlePropertyGetters = PublishCacheContext.CreateCache<Guid, IGetter>((Action<IDictionary<Guid, IGetter>, Type, Guid>) ((c, t, u) => c.Clear()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static bool In1cK1h80B180GwyTMIt() => EntityDynamic<IdT>.g5bMWUh8x1AYkcmpahTm == null;

    internal static object wp8Iufh8mX7tjsUhXNDr() => EntityDynamic<IdT>.g5bMWUh8x1AYkcmpahTm;
  }
}
