// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.RestrictionBuilderSelectType`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EleWise.ELMA.Helpers
{
  public class RestrictionBuilderSelectType<T> : RestrictionBuilderBase<T>
  {
    internal static object zu2ZsfhcrCCV8OhJxKiY;

    public RestrictionBuilderSelectType(
      Restriction restriction,
      RestrictionsBuilder<T> restrictionsBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(restriction, restrictionsBuilder);
    }

    /// <summary>Правило для типа</summary>
    /// <typeparam name="T1">Тип, для которого задается правило</typeparam>
    /// <returns></returns>
    public RestrictionBuilderSelectAction<T> ForType<T1>()
    {
      this.restriction.ObjectType = InterfaceActivator.TypeOf<T1>();
      return new RestrictionBuilderSelectAction<T>(this);
    }

    /// <summary>Правило для типа</summary>
    /// <param name="type">Тип, для которого задается правило</param>
    /// <returns></returns>
    public RestrictionBuilderSelectAction<T> ForType(Type type)
    {
      this.restriction.ObjectType = InterfaceActivator.TypeOf(type);
      return new RestrictionBuilderSelectAction<T>(this);
    }

    /// <summary>Правило для свойства</summary>
    /// <param name="type">Тип объекта, для которого задается правило</param>
    /// <param name="propertyName">Название свойства, для которого задается правило</param>
    /// <returns></returns>
    public RestrictionBuilderSelectAction<T> ForPropertyName(Type type, string propertyName)
    {
      this.restriction.ParentType = InterfaceActivator.TypeOf(type);
      this.restriction.PropertyName = propertyName;
      return new RestrictionBuilderSelectAction<T>(this);
    }

    /// <summary>Правило для свойства</summary>
    /// <typeparam name="T1">Тип объекта, для которого задается правило</typeparam>
    /// <param name="propertyName">Название свойства, для которого задается правило</param>
    /// <returns></returns>
    public RestrictionBuilderSelectAction<T> ForPropertyName<T1>(string propertyName)
    {
      this.restriction.ParentType = InterfaceActivator.TypeOf<T1>();
      this.restriction.PropertyName = propertyName;
      return new RestrictionBuilderSelectAction<T>(this);
    }

    /// <summary>Правило для свойства</summary>
    /// <typeparam name="T1">Тип объекта, для которого задается правило</typeparam>
    /// <param name="f">Выражение, для которого задается правило</param>
    /// <returns></returns>
    public RestrictionBuilderSelectAction<T> ForPropertyName<T1>(Expression<Func<T1, object>> f)
    {
      this.restriction.ParentType = InterfaceActivator.TypeOf<T1>();
      this.restriction.PropertyName = LinqUtils.NameOf<T1>(f);
      return new RestrictionBuilderSelectAction<T>(this);
    }

    /// <summary>Правило для свойства</summary>
    /// <param name="propertyName">Название свойства текущего объекта, для которого задается правило</param>
    /// <returns></returns>
    public RestrictionBuilderSelectAction<T> ForPropertyName(string propertyName)
    {
      this.restriction.ParentType = InterfaceActivator.TypeOf<T>();
      this.restriction.PropertyName = propertyName;
      return new RestrictionBuilderSelectAction<T>(this);
    }

    /// <summary>Правило для свойства</summary>
    /// <param name="f">Выражение для текущего объекта, для которого задается правило</param>
    /// <returns></returns>
    public RestrictionBuilderSelectAction<T> ForPropertyName(Expression<Func<T, object>> f)
    {
      this.restriction.ParentType = InterfaceActivator.TypeOf<T>();
      this.restriction.PropertyName = LinqUtils.NameOf<T>(f);
      return new RestrictionBuilderSelectAction<T>(this);
    }

    public RestrictionBuilderSelectAction<T> ForAllProperties<T1>()
    {
      this.restriction.ParentType = InterfaceActivator.TypeOf<T1>();
      return new RestrictionBuilderSelectAction<T>(this);
    }

    /// <summary>
    /// Правило для свойств-коллекций элементов определенного типа
    /// </summary>
    /// <typeparam name="T1">Тип элемента, для коллекций которого задается правило</typeparam>
    /// <returns></returns>
    public RestrictionBuilderSelectCollectionAction<T, T1> ForCollectionsOfType<T1>() where T1 : class
    {
      this.restriction.ObjectType = InterfaceActivator.TypeOf<T1>();
      this.restriction.RuleType = RuleType.Collection;
      return new RestrictionBuilderSelectCollectionAction<T, T1>(this);
    }

    /// <summary>Правило для свойства-коллекции</summary>
    /// <typeparam name="T1">Тип элемента коллекции</typeparam>
    /// <param name="propertyName">Название свойства</param>
    /// <returns></returns>
    public RestrictionBuilderSelectCollectionAction<T, T1> ForCollection<T1>(string propertyName) where T1 : class
    {
      this.restriction.ObjectType = InterfaceActivator.TypeOf<T1>();
      this.restriction.PropertyName = propertyName;
      this.restriction.RuleType = RuleType.Collection;
      return new RestrictionBuilderSelectCollectionAction<T, T1>(this);
    }

    /// <summary>Правило для свойства-коллекции</summary>
    /// <typeparam name="T1">Тип элемента коллекции</typeparam>
    /// <param name="f">Выражение, задающее свойство</param>
    /// <returns></returns>
    public RestrictionBuilderSelectCollectionAction<T, T1> ForCollection<T1>(
      Expression<Func<T, ICollection<T1>>> f)
      where T1 : class
    {
      this.restriction.ObjectType = InterfaceActivator.TypeOf<T1>();
      this.restriction.PropertyName = LinqUtils.NameOf<T, ICollection<T1>>(f);
      this.restriction.RuleType = RuleType.Collection;
      return new RestrictionBuilderSelectCollectionAction<T, T1>(this);
    }

    /// <summary>Правило для всех свойств-коллекций</summary>
    /// <returns></returns>
    public RestrictionBuilderSelectCollectionAction<T, object> ForAllCollections()
    {
      this.restriction.RuleType = RuleType.Collection;
      return new RestrictionBuilderSelectCollectionAction<T, object>(this);
    }

    /// <summary>Установить правило nHibernate</summary>
    /// <param name="nHibernate">Использовать правило nHibernate</param>
    public void NHibernate(bool nHibernate = true)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.restrictionsBuilder.restrictions.nHibernate = nHibernate;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.restrictionsBuilder.restrictions.Remove(this.restriction);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Установить правило рекурсивного клонирования</summary>
    /// <param name="cloneRecursive">Использовать рекурсивное клонирование</param>
    public void CloneRecursive(bool cloneRecursive = true)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.restrictionsBuilder.restrictions.CloneRecursive = cloneRecursive;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.restrictionsBuilder.restrictions.Remove(this.restriction);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static bool F50fj5hcgZEUvIvIQEg0() => RestrictionBuilderSelectType<T>.zu2ZsfhcrCCV8OhJxKiY == null;

    internal static object mNVdrShc51Ab15fINKFM() => RestrictionBuilderSelectType<T>.zu2ZsfhcrCCV8OhJxKiY;
  }
}
