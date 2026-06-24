// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ExportHelper.ExportRuleBuilderSelectType`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Deploy.ExportHelper
{
  public class ExportRuleBuilderSelectType<T> : ExportRuleBuilderBase<T>
  {
    public ExportRuleBuilderSelectType(
      ExportRule exportRule,
      ExportRuleBuilder<T> exportRuleBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(exportRule, exportRuleBuilder);
    }

    /// <summary>Правило для типа</summary>
    /// <typeparam name="T1">Тип, для которого задается правило</typeparam>
    /// <returns></returns>
    public ExportRuleBuilderSelectAction<T> ForType<T1>()
    {
      this.rules.ObjectType = InterfaceActivator.TypeOf<T1>();
      return new ExportRuleBuilderSelectAction<T>(this);
    }

    /// <summary>Правило для типа</summary>
    /// <param name="type">Тип, для которого задается правило</param>
    /// <returns></returns>
    public ExportRuleBuilderSelectAction<T> ForType(Type type)
    {
      this.rules.ObjectType = InterfaceActivator.TypeOf(type);
      return new ExportRuleBuilderSelectAction<T>(this);
    }

    /// <summary>Правило для свойства</summary>
    /// <param name="type">Тип объекта, для которого задается правило</param>
    /// <param name="propertyName">Название свойства, для которого задается правило</param>
    /// <returns></returns>
    public ExportRuleBuilderSelectAction<T> ForPropertyName(Type type, string propertyName)
    {
      this.rules.ParentType = InterfaceActivator.TypeOf(type);
      this.rules.PropertyName = propertyName;
      return new ExportRuleBuilderSelectAction<T>(this);
    }

    /// <summary>Правило для свойства</summary>
    /// <typeparam name="T1">Тип объекта, для которого задается правило</typeparam>
    /// <param name="propertyName">Название свойства, для которого задается правило</param>
    /// <returns></returns>
    public ExportRuleBuilderSelectAction<T> ForPropertyName<T1>(string propertyName)
    {
      this.rules.ParentType = InterfaceActivator.TypeOf<T1>();
      this.rules.PropertyName = propertyName;
      return new ExportRuleBuilderSelectAction<T>(this);
    }

    /// <summary>Правило для свойства</summary>
    /// <typeparam name="T1">Тип объекта, для которого задается правило</typeparam>
    /// <param name="f">Выражение, для которого задается правило</param>
    /// <returns></returns>
    public ExportRuleBuilderSelectAction<T> ForPropertyName<T1>(Expression<Func<T1, object>> f)
    {
      this.rules.ParentType = InterfaceActivator.TypeOf<T1>();
      this.rules.PropertyName = LinqUtils.NameOf<T1>(f);
      return new ExportRuleBuilderSelectAction<T>(this);
    }

    /// <summary>Правило для свойства</summary>
    /// <param name="propertyName">Название свойства текущего объекта, для которого задается правило</param>
    /// <returns></returns>
    public ExportRuleBuilderSelectAction<T> ForPropertyName(string propertyName)
    {
      this.rules.ParentType = InterfaceActivator.TypeOf(typeof (T));
      this.rules.PropertyName = propertyName;
      return new ExportRuleBuilderSelectAction<T>(this);
    }

    /// <summary>Правило для свойства</summary>
    /// <param name="f">Выражение для текущего объекта, для которого задается правило</param>
    /// <returns></returns>
    public ExportRuleBuilderSelectAction<T> ForPropertyName(Expression<Func<T, object>> f)
    {
      this.rules.ParentType = InterfaceActivator.TypeOf<T>();
      this.rules.PropertyName = LinqUtils.NameOf<T>(f);
      return new ExportRuleBuilderSelectAction<T>(this);
    }
  }
}
