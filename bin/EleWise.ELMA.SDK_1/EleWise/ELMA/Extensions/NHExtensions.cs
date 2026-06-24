// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.NHExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.Model.Entities;
using Iesi.Collections;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Persister.Entity;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Методы расширения для различных классов NHibernate.</summary>
  public static class NHExtensions
  {
    private static NHExtensions qD8wFpG4OWmFcVB7ti09;

    /// <summary>
    /// Получить persister сущности, либо выкинуть исключение, если persister найти не удалось.
    /// </summary>
    /// <param name="session">Сессия.</param>
    /// <param name="entity">Объект сущности.</param>
    /// <returns>Persister сущности.</returns>
    /// <exception cref="T:System.InvalidOperationException">Не удалось найти persister для сущности с типом 'Х'.</exception>
    public static IEntityPersister GetEntityPersister(this ISession session, object entity)
    {
      int num1 = 6;
      ISessionImplementor sessionImplementation;
      string str;
      while (true)
      {
        Type type1;
        Type type2;
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            goto label_4;
          case 3:
            type2 = (Type) null;
            break;
          case 4:
            type2 = NHExtensions.aBxlk4G41O7MGEUe7yBc(entity);
            goto label_19;
          case 5:
            if (!(entity is IEntityImplementorProvider implementorProvider))
            {
              num1 = 3;
              continue;
            }
            type2 = NHExtensions.oSvWdaG4PJGIXIXVQxy9((object) implementorProvider);
            break;
          case 6:
            sessionImplementation = session.GetSessionImplementation();
            num1 = 5;
            continue;
          default:
            str = (string) NHExtensions.r2kfgVG43K4tWHkGq4Ct(NHExtensions.kID9bJG4NFwugK8CmH7D((object) sessionImplementation), type1);
            num1 = 2;
            continue;
        }
        if ((object) type2 == null)
        {
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 2 : 4;
          continue;
        }
label_19:
        type1 = type2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
      }
label_3:
      IEntityPersister entityPersister;
      return entityPersister;
label_4:
      try
      {
        entityPersister = (IEntityPersister) NHExtensions.Dg8c1fG4phtyKbnHIZj7((object) sessionImplementation.Factory, (object) str);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_3;
        }
      }
      catch (MappingException ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            throw new InvalidOperationException(EleWise.ELMA.SR.T((string) NHExtensions.Mfd2bgG4aZOXIjAtk3Dm(381945751 ^ 1158627804 ^ 1405663695), (object) entity.GetType().AssemblyQualifiedName));
        }
      }
    }

    /// <summary>Инициализирована ли коллекция</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="collection"></param>
    /// <returns></returns>
    public static bool IsInitialized<T>(this ISet<T> collection) => NHExtensions.IsCollectionInitialized((object) collection);

    /// <summary>Инициализирована ли коллекция</summary>
    /// <param name="collection"></param>
    /// <returns></returns>
    public static bool IsInitialized(this ISet collection) => NHExtensions.UGoGtEG4D9T88nvPX2gN((object) collection);

    private static bool IsCollectionInitialized(object collection)
    {
      int num = 2;
      IInheritedSet inheritedSet;
      while (true)
      {
        switch (num)
        {
          case 1:
            inheritedSet = collection as IInheritedSet;
            num = 5;
            continue;
          case 2:
            if (collection != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          case 3:
            goto label_4;
          case 4:
            goto label_9;
          case 5:
            if (inheritedSet == null)
            {
              num = 4;
              continue;
            }
            goto label_8;
          default:
            goto label_8;
        }
      }
label_4:
      return true;
label_8:
      return NHExtensions.gDJhvgG4teL3l1SUcD16((object) inheritedSet);
label_9:
      return NHExtensions.Mmv8VOG4wRh2IRxBnJBh(collection);
    }

    internal static Type oSvWdaG4PJGIXIXVQxy9([In] object obj0) => ((IEntityImplementorProvider) obj0).EntityImplementorType;

    internal static Type aBxlk4G41O7MGEUe7yBc([In] object obj0) => NHibernateProxyHelper.GuessClass(obj0);

    internal static object kID9bJG4NFwugK8CmH7D([In] object obj0) => (object) ((ISessionImplementor) obj0).Factory;

    internal static object r2kfgVG43K4tWHkGq4Ct([In] object obj0, [In] Type obj1) => (object) ((ISessionFactoryImplementor) obj0).TryGetGuessEntityName(obj1);

    internal static object Dg8c1fG4phtyKbnHIZj7([In] object obj0, [In] object obj1) => (object) ((ISessionFactoryImplementor) obj0).GetEntityPersister((string) obj1);

    internal static object Mfd2bgG4aZOXIjAtk3Dm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool DFRsUPG42ODEbjURJBVO() => NHExtensions.qD8wFpG4OWmFcVB7ti09 == null;

    internal static NHExtensions j71EnDG4exVO9XpFgn0f() => NHExtensions.qD8wFpG4OWmFcVB7ti09;

    internal static bool UGoGtEG4D9T88nvPX2gN([In] object obj0) => NHExtensions.IsCollectionInitialized(obj0);

    internal static bool gDJhvgG4teL3l1SUcD16([In] object obj0) => ((IInheritedSet) obj0).WasInitialized;

    internal static bool Mmv8VOG4wRh2IRxBnJBh([In] object obj0) => NHibernateUtil.IsInitialized(obj0);
  }
}
