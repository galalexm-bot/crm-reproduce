// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.EQL.EQLHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.NemerleParser;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using Iesi.Collections;
using j3AmrhgkCleVTGdEwA;
using Nemerle.Core;
using Nemerle.Peg;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.Hql.Util;
using NHibernate.Impl;
using NHibernate.Loader.Criteria;
using NHibernate.Persister.Collection;
using NHibernate.Persister.Entity;
using NHibernate.SqlCommand;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Managers.EQL
{
  public static class EQLHelper
  {
    private static readonly ISessionProvider SessionProvider;
    private static EQLHelper hsP6oGhv4uMbCOqpfc2q;

    /// <summary>
    /// Сформированть условие выборки на языке EQL в критерий отбора
    /// </summary>
    /// <param name="criteria">Критерий выбора</param>
    /// <param name="query">Условие выборки на языке EQL</param>
    /// <param name="metadata">Метаданные объекта, к которому применяется фильтр</param>
    /// <param name="queryParameters">Коллекция параметров EQL-запроса</param>
    /// <param name="alias">alias критерии</param>
    /// <param name="propertyCriterionFunc">Функция получения <see cref="T:NHibernate.Criterion.ICriterion" /> для определенного свойства.<br />
    /// На входе:<br />
    /// propMetadta: Метаданные свойства.<br />
    /// criterionFunc: Функция получения фильтрации свойства. На входе: entityMetadata: метаданные сущности, по которой создается фильтр; alias: alias для сущности в запросе.<br />
    /// newAliasFunc: фукнция получения нового alias для <see cref="T:NHibernate.ICriteria" />.<br />
    /// На выходе: Если свойство специально обрабатываться не должно, вернуть null, иначе вернуть <see cref="T:NHibernate.Criterion.ICriterion" /></param>
    /// <returns></returns>
    internal static ICriteria AddEQLQuery(
      this ICriteria criteria,
      string query,
      EntityMetadata metadata,
      EleWise.ELMA.Model.Common.QueryParameters queryParameters = null,
      string alias = null,
      Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc = null)
    {
      option<EleWise.ELMA.NemerleParser.Expression> option = new EQLParser().Parse(new SourceSnapshot(query).WithText(query.ToLowerInvariant()));
      if (option.HasValue)
      {
        EQLHelper.Aliases aliases = new EQLHelper.Aliases(criteria, metadata, alias, queryParameters);
        ICriterion forQueryTreeItem = EQLHelper.GetCriterionNodeForQueryTreeItem((object) option.Value, (object) aliases, propertyCriterionFunc, 0);
        if (forQueryTreeItem != null)
          criteria.Add(forQueryTreeItem);
        return criteria;
      }
      throw new EQLException(query, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272422539), (object) query));
    }

    /// <summary>Распарсить параметры для EQL запроса</summary>
    /// <param name="query">EQL запрос</param>
    /// <param name="metadata">Метаданные объекта, к которому применяется фильтр</param>
    public static ParsedQueryParameters ParseEqlParameters(string query, EntityMetadata metadata)
    {
      int num1 = 9;
      ParsedQueryParameters parameters;
      while (true)
      {
        int num2 = num1;
        System.Type typeByUid;
        EQLHelper.Aliases aliases;
        option<EleWise.ELMA.NemerleParser.Expression> option;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 3:
              if (!EQLHelper.JB1hichvxuoo3YexxUYc((object) option))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 2;
                continue;
              }
              goto case 7;
            case 4:
              goto label_5;
            case 5:
              aliases = new EQLHelper.Aliases((ICriteria) EQLHelper.YQB8Y8hvycLh4s0OMR7c(EQLHelper.wlTs9ShvmvCJyQ615Bo3((object) Locator.GetServiceNotNull<ISessionProvider>(), (object) ""), typeByUid), metadata, parameters);
              num2 = 6;
              continue;
            case 6:
              EQLHelper.GetCriterionNodeForQueryTreeItem((object) option.Value, (object) aliases, (Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion>) null, 0);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 4 : 3;
              continue;
            case 7:
              typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(EQLHelper.z4WvcBhv0fbrBlF8b3U2((object) metadata));
              num2 = 5;
              continue;
            case 8:
              if (!EQLHelper.wnxFmBhvAxNBwAS04THS((object) query))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 1;
                continue;
              }
              goto label_5;
            case 9:
              parameters = new ParsedQueryParameters();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 2 : 8;
              continue;
            default:
              goto label_4;
          }
        }
label_6:
        option = new EQLParser().Parse(new SourceSnapshot(query).WithText((string) EQLHelper.Uc9dPWhv7GTmJTJrHvwL((object) query)));
        num1 = 3;
      }
label_4:
      throw new EQLException(query, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210523075), (object) query));
label_5:
      return parameters;
    }

    private static ICriterion GetCriterionNodeForQueryTreeItem(
      object item,
      object aliases,
      Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc,
      int level)
    {
      if (level >= 1000)
        throw new StackOverflowException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306666640)));
      switch (item)
      {
        case BinaryExpression expression:
          switch (expression.Operator)
          {
            case BinaryOperator.Equal:
            case BinaryOperator.NEqual:
            case BinaryOperator.GE:
            case BinaryOperator.GT:
            case BinaryOperator.LE:
            case BinaryOperator.LT:
            case BinaryOperator.IS:
            case BinaryOperator.IN:
            case BinaryOperator.LIKE:
              return EQLHelper.GetBinaryExpressionCriterion((object) expression, aliases, propertyCriterionFunc, level + 1);
            case BinaryOperator.And:
            case BinaryOperator.Or:
              ICriterion forQueryTreeItem1 = EQLHelper.GetCriterionNodeForQueryTreeItem((object) expression.Operand1, aliases, propertyCriterionFunc, level + 1);
              ICriterion forQueryTreeItem2 = EQLHelper.GetCriterionNodeForQueryTreeItem((object) expression.Operand2, aliases, propertyCriterionFunc, level + 1);
              return forQueryTreeItem1 == null || forQueryTreeItem2 == null ? forQueryTreeItem1 ?? forQueryTreeItem2 : (expression.Operator == BinaryOperator.And ? (ICriterion) Restrictions.And(forQueryTreeItem1, forQueryTreeItem2) : (ICriterion) Restrictions.Or(forQueryTreeItem1, forQueryTreeItem2));
            default:
              return (ICriterion) null;
          }
        case EleWise.ELMA.NemerleParser.NotExpression notExpression:
          return (ICriterion) Restrictions.Not(EQLHelper.GetCriterionNodeForQueryTreeItem((object) notExpression.Expression, aliases, propertyCriterionFunc, level + 1));
        default:
          return (ICriterion) null;
      }
    }

    private static DetachedCriteria DetachedCriteriaFor(System.Type entityType, object alias)
    {
      int num = 1;
      string guessEntityName;
      while (true)
      {
        switch (num)
        {
          case 1:
            guessEntityName = ((ISessionImplementor) EQLHelper.njpOifhvMBHbZRRQ8V4u((object) EQLHelper.SessionProvider.GetSession(string.Empty))).Factory.TryGetGuessEntityName(entityType);
            if (guessEntityName == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          default:
            goto label_4;
        }
      }
label_4:
      string str = entityType.FullName;
label_5:
      object obj = alias;
      return (DetachedCriteria) EQLHelper.YBlUuohvJEo45pgAFiKx((object) str, obj);
label_6:
      str = guessEntityName;
      goto label_5;
    }

    private static ICriterion GetBinaryExpressionCriterion(
      object expression,
      object aliases,
      Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc,
      int level)
    {
      EQLHelper.Aliases aliases1 = (EQLHelper.Aliases) aliases;
      Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc1 = propertyCriterionFunc;
      int level1 = level;
      AggregateSubqueryExpression operand1 = ((BinaryExpression) expression).Operand1 as AggregateSubqueryExpression;
      AggregateSubqueryExpression operand2_1 = ((BinaryExpression) expression).Operand2 as AggregateSubqueryExpression;
      if (operand1 != null || operand2_1 != null)
        return EQLHelper.GetCountExpression(expression, (object) aliases1, propertyCriterionFunc1, level1);
      EleWise.ELMA.NemerleParser.Property propExp = ((BinaryExpression) expression).Operand1 as EleWise.ELMA.NemerleParser.Property;
      EntityMetadata entityMetadata = propExp != null ? aliases1.GetMetadata4Property(propExp) : throw new PositionalEQLException((string) null, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 88075311), (object) expression.ToString()), ((TreeItem) expression).Start);
      System.Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityMetadata.Uid);
      PropertyInfo reflectionProperty = typeByUid.GetReflectionProperty(propExp.Name);
      if (reflectionProperty == (PropertyInfo) null)
        throw new PropertyNotFoundEQLException(propExp.Start, propExp.Name);
      if (typeof (ISet).IsAssignableFrom(reflectionProperty.PropertyType) || reflectionProperty.PropertyType.IsGenericType && reflectionProperty.PropertyType.GetGenericTypeDefinition() == typeof (Iesi.Collections.Generic.ISet<>))
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        IEntityPropertyMetadata propMetadta = (IEntityPropertyMetadata) entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => (string) EQLHelper.\u003C\u003Ec__DisplayClass6_0.wUSx6mCL6MWBBMjTy8hc((object) p) == (string) EQLHelper.\u003C\u003Ec__DisplayClass6_0.fiJtKeCLHxMWSSKYUkeE((object) propExp))) ?? (IEntityPropertyMetadata) entityMetadata.TableParts.FirstOrDefault<TablePartMetadata>((Func<TablePartMetadata, bool>) (tp => (string) EQLHelper.\u003C\u003Ec__DisplayClass6_0.T1XTcBCLASgkJiF1qRFU((object) tp) == (string) EQLHelper.\u003C\u003Ec__DisplayClass6_0.fiJtKeCLHxMWSSKYUkeE((object) propExp)));
        if (propMetadta == null || propMetadta.TypeUid != TablePartMetadata.UID && !(propMetadta.Settings is EntitySettings))
          throw new PropertyNotFoundEQLException(propExp.Start, propExp.Name);
        EQLHelper.Aliases alias = aliases1.CreateAlias(propMetadta.TypeUid == TablePartMetadata.UID ? (EntityMetadata) propMetadta : (EntityMetadata) MetadataLoader.LoadMetadata(propMetadta.SubTypeUid));
        DetachedCriteria dc;
        string propertyName;
        if (propMetadta.TypeUid == TablePartMetadata.UID)
        {
          dc = EQLHelper.DetachedCriteriaFor(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(propMetadta.Uid), (object) alias.CurrentAlias);
          propertyName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234336474);
        }
        else if (propMetadta.Settings is EntitySettings && ((EntitySettings) propMetadta.Settings).RelationType == RelationType.OneToMany)
        {
          dc = EQLHelper.DetachedCriteriaFor(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(propMetadta.SubTypeUid), (object) alias.CurrentAlias);
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          propertyName = ((ClassMetadata) MetadataLoader.LoadMetadata(propMetadta.SubTypeUid)).Properties.First<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EQLHelper.\u003C\u003Ec__DisplayClass6_1.dqxGUeCLJYbUiqXFOCDx(EQLHelper.\u003C\u003Ec__DisplayClass6_1.VvkqM5CLyTl14HWLTiAc((object) p), ((EntitySettings) EQLHelper.\u003C\u003Ec__DisplayClass6_1.nLcDUcCLMeRt0bFuYWbU((object) propMetadta)).KeyColumnUid))).Name;
        }
        else
        {
          dc = EQLHelper.DetachedCriteriaFor(typeByUid, (object) alias.NewAlias()).CreateAlias(propExp.Name, alias.CurrentAlias, JoinType.InnerJoin);
          propertyName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217490841);
        }
        dc.SetProjection((IProjection) Projections.Property(propertyName));
        switch (((BinaryExpression) expression).Operator)
        {
          case BinaryOperator.Equal:
            dc.Add(EQLHelper.GetRestriction(new Func<string, string, ICriterion>(Restrictions.EqProperty), new Func<string, object, ICriterion>(Restrictions.Eq), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536770868), (object) alias, (object) propExp, (object) ((BinaryExpression) expression).Operand2, (object) aliases1));
            break;
          case BinaryOperator.NEqual:
            dc.Add((ICriterion) Restrictions.Not(EQLHelper.GetRestriction(new Func<string, string, ICriterion>(Restrictions.EqProperty), new Func<string, object, ICriterion>(Restrictions.Eq), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372721015), (object) alias, (object) propExp, (object) ((BinaryExpression) expression).Operand2, (object) aliases1)));
            break;
          case BinaryOperator.IS:
            dc.Add((ICriterion) Restrictions.EqProperty(propertyName, aliases1.GetProperty(propExp, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304571923))));
            return (ICriterion) Subqueries.NotExists(dc);
          case BinaryOperator.IN:
            if (((BinaryExpression) expression).Operand2 is EleWise.ELMA.NemerleParser.SubqueryExpression operand2_2)
            {
              IQueryCastExtension queryCastExtension = EQLHelper.GetQueryCastExtension((object) entityMetadata, (object) propExp.Name, (object) operand2_2);
              dc.Add((ICriterion) new EQLHelper.EQLPropertyInSubqueryExpression(alias.GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638434993)), EQLHelper.GetCriteria4SubqueryExpression((object) operand2_2, (object) queryCastExtension, (object) aliases1, propertyCriterionFunc1, level1 + 1), queryCastExtension));
              break;
            }
            InFunction inFunc = ((BinaryExpression) expression).Operand2 as InFunction;
            if (inFunc != null)
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              IQueryInFunction queryInFunction = ComponentManager.Current.GetExtensionPoints<IQueryInFunction>().FirstOrDefault<IQueryInFunction>((Func<IQueryInFunction, bool>) (q => EQLHelper.\u003C\u003Ec__DisplayClass6_2.XZp2M3CLjSCti5QFbVE8(EQLHelper.\u003C\u003Ec__DisplayClass6_2.YLf8cUCLgXlneyrrb1hg((object) q), EQLHelper.\u003C\u003Ec__DisplayClass6_2.aj6YwBCL5jrLWdkuU2gO((object) inFunc))));
              if (queryInFunction == null)
                throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487208298), (object) inFunc.Name));
              object[] array = inFunc.Parameters.GetChildItems().Cast<Constant>().Select<Constant, object>((Func<Constant, object>) (c => EQLHelper.GetConstantValue((object) propExp, (object) aliases1, (object) c))).ToArray<object>();
              dc.Add(queryInFunction.GetCriterion(alias.CurrentAlias, entityMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672160694), array));
              break;
            }
            if (((BinaryExpression) expression).Operand2 is EleWise.ELMA.NemerleParser.InExpression operand2_3)
            {
              dc.Add(EQLHelper.GetCriterionNodeForQueryTreeItem((object) operand2_3.Expression, (object) alias, propertyCriterionFunc1, level1 + 1));
              break;
            }
            object[] values = ((BinaryExpression) expression).Operand2 is EleWise.ELMA.NemerleParser.Parameter ? (EQLHelper.GetParameterOperand((object) propExp, (object) aliases1, (object) ((BinaryExpression) expression).Operand2, true) as IEnumerable).CastToArrayOrNull<object>() : EQLHelper.GetParametersOperand((object) propExp, (object) aliases1, ((BinaryExpression) expression).Operand2.GetChildItems());
            dc.Add((ICriterion) Restrictions.In(alias.GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852869798)), values));
            break;
          default:
            throw new PositionalEQLException((string) null, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669584079), (object) expression.ToString()), ((TreeItem) expression).Start);
        }
        return (ICriterion) new EQLHelper.EQLPropertyInSubqueryExpression(aliases1.GetProperty(propExp, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413595457)), dc);
      }
      switch (((BinaryExpression) expression).Operator)
      {
        case BinaryOperator.Equal:
          return (ICriterion) EQLHelper.GetEqExpression((object) propExp, (object) ((BinaryExpression) expression).Operand2, (object) aliases);
        case BinaryOperator.NEqual:
          return (ICriterion) Restrictions.Not((ICriterion) EQLHelper.GetEqExpression((object) propExp, (object) ((BinaryExpression) expression).Operand2, (object) aliases));
        case BinaryOperator.GE:
          return EQLHelper.GetRestriction(new Func<string, string, ICriterion>(Restrictions.GeProperty), new Func<string, object, ICriterion>(Restrictions.Ge), (object) propExp, (object) ((BinaryExpression) expression).Operand2, (object) aliases);
        case BinaryOperator.GT:
          return EQLHelper.GetRestriction(new Func<string, string, ICriterion>(Restrictions.GtProperty), new Func<string, object, ICriterion>(Restrictions.Gt), (object) propExp, (object) ((BinaryExpression) expression).Operand2, (object) aliases);
        case BinaryOperator.LE:
          return EQLHelper.GetRestriction(new Func<string, string, ICriterion>(Restrictions.LeProperty), new Func<string, object, ICriterion>(Restrictions.Le), (object) propExp, (object) ((BinaryExpression) expression).Operand2, (object) aliases);
        case BinaryOperator.LT:
          return EQLHelper.GetRestriction(new Func<string, string, ICriterion>(Restrictions.LtProperty), new Func<string, object, ICriterion>(Restrictions.Lt), (object) propExp, (object) ((BinaryExpression) expression).Operand2, (object) aliases);
        case BinaryOperator.IS:
          return (ICriterion) Restrictions.IsNull(aliases.GetProperty(propExp));
        case BinaryOperator.IN:
          if (((BinaryExpression) expression).Operand2 is EleWise.ELMA.NemerleParser.SubqueryExpression operand2_4)
          {
            IQueryCastExtension queryCastExtension = EQLHelper.GetQueryCastExtension((object) entityMetadata, (object) propExp.Name, (object) operand2_4);
            return (ICriterion) new EQLHelper.EQLPropertyInSubqueryExpression(aliases.GetProperty(propExp), EQLHelper.GetCriteria4SubqueryExpression((object) operand2_4, (object) queryCastExtension, (object) aliases, propertyCriterionFunc, level + 1), queryCastExtension);
          }
          InFunction inFunc1 = ((BinaryExpression) expression).Operand2 as InFunction;
          if (inFunc1 != null)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            IQueryInFunction queryInFunction = ComponentManager.Current.GetExtensionPoints<IQueryInFunction>().FirstOrDefault<IQueryInFunction>((Func<IQueryInFunction, bool>) (q => EQLHelper.\u003C\u003Ec__DisplayClass6_3.gZrKLNCLzGjibtPIK9tF(EQLHelper.\u003C\u003Ec__DisplayClass6_3.py1Ao6CLsAEltcA4N7Ex((object) q), EQLHelper.\u003C\u003Ec__DisplayClass6_3.FsyI62CLc4Z2mIy71TyF((object) inFunc1))));
            if (queryInFunction == null)
              throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633563483), (object) inFunc1.Name));
            object[] array = inFunc1.Parameters.GetChildItems().Cast<Constant>().Select<Constant, object>((Func<Constant, object>) (c => EQLHelper.GetConstantValue((object) propExp, (object) aliases1, (object) c, false))).ToArray<object>();
            return queryInFunction.GetCriterion(aliases.GetAlias4Property(propExp), aliases.GetMetadata4Property(propExp), propExp.Name, array);
          }
          EleWise.ELMA.NemerleParser.InExpression inExpr = ((BinaryExpression) expression).Operand2 as EleWise.ELMA.NemerleParser.InExpression;
          if (inExpr != null)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            EntityPropertyMetadata propertyMetadata = (EntityPropertyMetadata) entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EQLHelper.\u003C\u003Ec__DisplayClass6_0.GrpvXuCL7e21pVRq5pmw((object) p.Name, EQLHelper.\u003C\u003Ec__DisplayClass6_0.fiJtKeCLHxMWSSKYUkeE((object) propExp))));
            if (propertyCriterionFunc != null)
            {
              // ISSUE: reference to a compiler-generated method
              ICriterion expressionCriterion = propertyCriterionFunc(propertyMetadata, (Func<EntityMetadata, string, ICriterion>) ((em, alias) => EQLHelper.GetCriterionNodeForQueryTreeItem(EQLHelper.\u003C\u003Ec__DisplayClass6_3.osAZ9nCUF9i48i48g4jo((object) inExpr), (object) aliases.CreateAlias(em, alias), propertyCriterionFunc, level + 1)), new Func<string>(aliases.NewAlias));
              if (expressionCriterion != null)
                return expressionCriterion;
            }
            DetachedCriteria dc = aliases.CreateDetachedCriteria((EntityMetadata) MetadataLoader.LoadMetadata(propertyMetadata.SubTypeUid), (TreeItem) inExpr.Expression, propertyCriterionFunc, level + 1).SetProjection((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372721015)));
            return (ICriterion) new EQLHelper.EQLPropertyInSubqueryExpression(aliases.GetProperty(propExp), dc);
          }
          object[] values1 = ((BinaryExpression) expression).Operand2 is EleWise.ELMA.NemerleParser.Parameter ? (EQLHelper.GetParameterOperand((object) propExp, (object) aliases, (object) ((BinaryExpression) expression).Operand2, true) as IEnumerable).CastToArrayOrNull<object>() : EQLHelper.GetParametersOperand((object) propExp, (object) aliases, ((BinaryExpression) expression).Operand2.GetChildItems());
          return (ICriterion) Restrictions.In(aliases.GetProperty(propExp), values1);
        case BinaryOperator.LIKE:
          object parameter;
          if (((BinaryExpression) expression).Operand2 is EleWise.ELMA.NemerleParser.Parameter)
          {
            parameter = aliases.GetParameter(((EleWise.ELMA.NemerleParser.Parameter) ((BinaryExpression) expression).Operand2).Name, propExp);
          }
          else
          {
            if (!(((BinaryExpression) expression).Operand2 is Constant))
              throw new FormatException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1200029067));
            parameter = ((Constant) ((BinaryExpression) expression).Operand2).Value;
          }
          return (ICriterion) ElmaRestrictions.InsensitiveLike(aliases.GetProperty(propExp), parameter);
        default:
          throw new PositionalEQLException((string) null, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921022441), (object) expression.ToString()), ((TreeItem) expression).Start);
      }
    }

    private static IQueryCastExtension GetQueryCastExtension(
      object entityMetadataLeftOperand,
      object propertyNameLeftOperand,
      object subquery)
    {
      int num1 = 9;
      IQueryCastExtension queryCastExtension;
      EleWise.ELMA.NemerleParser.SubqueryExpression subquery1;
      while (true)
      {
        int num2 = num1;
        EntityMetadata entityMetadata;
        System.Type typeByUid1;
        System.Type typeByUid2;
        PropertyInfo propertyInfoLeftOperand;
        PropertyInfo propertyInfoRightOperand;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (EQLHelper.Eaywuwhv5lwL9PXcC8qf((object) propertyInfoRightOperand, (object) null))
              {
                num2 = 13;
                continue;
              }
              goto label_11;
            case 2:
              if (queryCastExtension == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 7 : 7;
                continue;
              }
              goto label_3;
            case 3:
              typeByUid1 = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(EQLHelper.z4WvcBhv0fbrBlF8b3U2((object) entityMetadata));
              num2 = 11;
              continue;
            case 4:
              goto label_3;
            case 5:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              entityMetadata = ((ComponentManager) EQLHelper.fhL8gahvducpY25IM2XS()).GetExtensionPoints<IEntityMetadataSearcher>().Select<IEntityMetadataSearcher, EntityMetadata>((Func<IEntityMetadataSearcher, EntityMetadata>) (p => (EntityMetadata) EQLHelper.\u003C\u003Ec__DisplayClass7_0.hraf5SCUGW6LVodoLfTl((object) p, EQLHelper.\u003C\u003Ec__DisplayClass7_0.zL2QlICUh7HOHAjwtRqF((object) subquery1)))).FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (m => m != null));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 12 : 8;
              continue;
            case 6:
              typeByUid2 = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(EQLHelper.z4WvcBhv0fbrBlF8b3U2(entityMetadataLeftOperand));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
              continue;
            case 7:
              IEnumerable<IQueryCastExtension> extensionPoints = ((ComponentManager) EQLHelper.fhL8gahvducpY25IM2XS()).GetExtensionPoints<IQueryCastExtension>();
              // ISSUE: reference to a compiler-generated field
              Func<IQueryCastExtension, bool> func = EQLHelper.\u003C\u003Ec.\u003C\u003E9__7_3;
              Func<IQueryCastExtension, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                EQLHelper.\u003C\u003Ec.\u003C\u003E9__7_3 = predicate = (Func<IQueryCastExtension, bool>) (cast =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (EQLHelper.\u003C\u003Ec.tSt9T6CUuCeD2Kq1GDvo(EQLHelper.\u003C\u003Ec.o7H8rWCUZ61tdic9HsCd((object) cast), (System.Type) null))
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
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
                  return EQLHelper.\u003C\u003Ec.tSt9T6CUuCeD2Kq1GDvo(EQLHelper.\u003C\u003Ec.LDdVO5CUIqfyC6InRtUT((object) cast), (System.Type) null);
label_3:
                  return false;
                });
              }
              else
                goto label_23;
label_22:
              queryCastExtension = extensionPoints.FirstOrDefault<IQueryCastExtension>(predicate);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 4 : 4;
              continue;
label_23:
              predicate = func;
              goto label_22;
            case 8:
              subquery1 = (EleWise.ELMA.NemerleParser.SubqueryExpression) subquery;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 5 : 6;
              continue;
            case 9:
              num2 = 8;
              continue;
            case 10:
              goto label_4;
            case 11:
              propertyInfoRightOperand = (PropertyInfo) EQLHelper.a1EkeQhv980IXhmjalqu(typeByUid1, EQLHelper.loSPmBhvggYpqR0k3JQC((object) subquery1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
              continue;
            case 12:
              if (entityMetadata != null)
              {
                num2 = 3;
                continue;
              }
              goto label_4;
            case 13:
              goto label_10;
            default:
              propertyInfoLeftOperand = (PropertyInfo) EQLHelper.a1EkeQhv980IXhmjalqu(typeByUid2, propertyNameLeftOperand);
              num2 = 5;
              continue;
          }
        }
label_11:
        queryCastExtension = ComponentManager.Current.GetExtensionPoints<IQueryCastExtension>().FirstOrDefault<IQueryCastExtension>((Func<IQueryCastExtension, bool>) (cast =>
        {
          int num4 = 2;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_5;
              case 2:
                // ISSUE: reference to a compiler-generated method
                if (!(EQLHelper.\u003C\u003Ec__DisplayClass7_0.pl9NMKCUEGMfnWPgly8s((object) cast) == propertyInfoLeftOperand.PropertyType))
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
                  continue;
                }
                goto label_4;
              default:
                goto label_4;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          return EQLHelper.\u003C\u003Ec__DisplayClass7_0.wSF6RkCUfbLUgQK79EVS(cast.RightOperandType, propertyInfoRightOperand.PropertyType);
label_5:
          return false;
        }));
        num1 = 2;
      }
label_3:
      return queryCastExtension;
label_4:
      throw new ClassNotFoundEQLException(EQLHelper.aobMsVhvlGv6oo8R9Fdv((object) subquery1), (string) EQLHelper.gT2penhvr0mpNiGPktCB((object) subquery1));
label_10:
      throw new PropertyNotFoundEQLException(EQLHelper.Sepr90hvjIJt3Vx56wj4((object) subquery1), subquery1.SelectProperty);
    }

    private static object GetParameterOperand(
      object propExp,
      object aliases,
      object item,
      bool needCollection = false)
    {
      int num = 2;
      EleWise.ELMA.NemerleParser.Parameter parameter;
      TreeItem constExp;
      while (true)
      {
        switch (num)
        {
          case 1:
            parameter = item as EleWise.ELMA.NemerleParser.Parameter;
            num = 3;
            continue;
          case 2:
            constExp = (TreeItem) item;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 1;
            continue;
          case 3:
            if (parameter != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 4:
            goto label_5;
          default:
            Constant constant = new Constant();
            EQLHelper.dkFhf5hvLrkCCV9ucW3T((object) constant, EQLHelper.Os3pqphvYl8SqDg9itqJ((object) parameter));
            constant.Stop = EQLHelper.gjfKyAhvUZiuD1SXHv1J((object) parameter);
            EQLHelper.dRZ4LIhvco9FjEf5jScA((object) constant, ((EQLHelper.Aliases) aliases).GetParameter((string) EQLHelper.CO7yw9hvs69d2sFU5ApE((object) parameter), (EleWise.ELMA.NemerleParser.Property) propExp, needCollection));
            constExp = (TreeItem) constant;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 4 : 4;
            continue;
        }
      }
label_5:
      return EQLHelper.GetConstantValue(propExp, aliases, (object) (constExp as Constant));
    }

    private static object[] GetParametersOperand(
      object propExp,
      object aliases,
      IEnumerable<TreeItem> obj)
    {
      List<object> objectList = new List<object>();
      foreach (TreeItem treeItem in obj)
        objectList.Add(EQLHelper.GetParameterOperand(propExp, aliases, (object) treeItem));
      return objectList.ToArray();
    }

    private static ICriterion GetCountExpression(
      object expression,
      object aliases,
      Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc,
      int level)
    {
      AggregateSubqueryExpression operand1 = ((BinaryExpression) expression).Operand1 as AggregateSubqueryExpression;
      AggregateSubqueryExpression operand2 = ((BinaryExpression) expression).Operand2 as AggregateSubqueryExpression;
      object aggregationOperand1 = EQLHelper.GetAggregationOperand((object) ((BinaryExpression) expression).Operand1, aliases, propertyCriterionFunc, level);
      object aggregationOperand2 = EQLHelper.GetAggregationOperand((object) ((BinaryExpression) expression).Operand2, aliases, propertyCriterionFunc, level);
      if (operand1 != null && operand2 != null)
      {
        DetachedCriteria detachedCriteria1 = aggregationOperand1 as DetachedCriteria;
        DetachedCriteria detachedCriteria2 = aggregationOperand2 as DetachedCriteria;
        switch (((BinaryExpression) expression).Operator)
        {
          case BinaryOperator.Equal:
            return (ICriterion) Restrictions.EqProperty(Projections.SubQuery(detachedCriteria1), Projections.SubQuery(detachedCriteria2));
          case BinaryOperator.NEqual:
            return (ICriterion) Restrictions.Not((ICriterion) Restrictions.EqProperty(Projections.SubQuery(detachedCriteria1), Projections.SubQuery(detachedCriteria2)));
          case BinaryOperator.GE:
            return (ICriterion) Restrictions.GeProperty(Projections.SubQuery(detachedCriteria1), Projections.SubQuery(detachedCriteria2));
          case BinaryOperator.GT:
            return (ICriterion) Restrictions.GtProperty(Projections.SubQuery(detachedCriteria1), Projections.SubQuery(detachedCriteria2));
          case BinaryOperator.LE:
            return (ICriterion) Restrictions.LeProperty(Projections.SubQuery(detachedCriteria1), Projections.SubQuery(detachedCriteria2));
          case BinaryOperator.LT:
            return (ICriterion) Restrictions.LtProperty(Projections.SubQuery(detachedCriteria1), Projections.SubQuery(detachedCriteria2));
          default:
            throw new PositionalEQLException((string) null, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309852568), (object) expression.ToString()), ((TreeItem) expression).Start);
        }
      }
      else
      {
        object obj;
        DetachedCriteria detach;
        if (operand1 != null)
        {
          obj = aggregationOperand2;
          detach = aggregationOperand1 as DetachedCriteria;
          switch (((BinaryExpression) expression).Operator)
          {
            case BinaryOperator.GE:
              ((BinaryExpression) expression).Operator = BinaryOperator.LE;
              break;
            case BinaryOperator.GT:
              ((BinaryExpression) expression).Operator = BinaryOperator.LT;
              break;
            case BinaryOperator.LE:
              ((BinaryExpression) expression).Operator = BinaryOperator.GE;
              break;
            case BinaryOperator.LT:
              ((BinaryExpression) expression).Operator = BinaryOperator.GT;
              break;
          }
        }
        else
        {
          obj = aggregationOperand1;
          detach = aggregationOperand2 as DetachedCriteria;
        }
        if (!(obj is TreeItem property))
          throw new PositionalEQLException((string) null, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515141885), (object) expression.ToString()), ((TreeItem) expression).Start);
        switch (((BinaryExpression) expression).Operator)
        {
          case BinaryOperator.Equal:
            return EQLHelper.GetRestrictionSubqueries(new Func<string, DetachedCriteria, ICriterion>(Subqueries.PropertyEq), new Func<object, DetachedCriteria, ICriterion>(Subqueries.Eq), (object) property, aliases, (object) detach);
          case BinaryOperator.NEqual:
            return (ICriterion) Restrictions.Not(EQLHelper.GetRestrictionSubqueries(new Func<string, DetachedCriteria, ICriterion>(Subqueries.PropertyEq), new Func<object, DetachedCriteria, ICriterion>(Subqueries.Eq), (object) property, aliases, (object) detach));
          case BinaryOperator.GE:
            return EQLHelper.GetRestrictionSubqueries(new Func<string, DetachedCriteria, ICriterion>(Subqueries.PropertyGe), new Func<object, DetachedCriteria, ICriterion>(Subqueries.Ge), (object) property, aliases, (object) detach);
          case BinaryOperator.GT:
            return EQLHelper.GetRestrictionSubqueries(new Func<string, DetachedCriteria, ICriterion>(Subqueries.PropertyGt), new Func<object, DetachedCriteria, ICriterion>(Subqueries.Gt), (object) property, aliases, (object) detach);
          case BinaryOperator.LE:
            return EQLHelper.GetRestrictionSubqueries(new Func<string, DetachedCriteria, ICriterion>(Subqueries.PropertyLe), new Func<object, DetachedCriteria, ICriterion>(Subqueries.Le), (object) property, aliases, (object) detach);
          case BinaryOperator.LT:
            return EQLHelper.GetRestrictionSubqueries(new Func<string, DetachedCriteria, ICriterion>(Subqueries.PropertyLt), new Func<object, DetachedCriteria, ICriterion>(Subqueries.Lt), (object) property, aliases, (object) detach);
          default:
            throw new PositionalEQLException((string) null, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304555673), (object) expression.ToString()), ((TreeItem) expression).Start);
        }
      }
    }

    private static object GetAggregationOperand(
      object expression,
      object aliases,
      Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc,
      int level)
    {
      AggregateSubqueryExpression property = expression as AggregateSubqueryExpression;
      if (property == null)
        return expression;
      ConstantFunction func = property.Expression as ConstantFunction;
      if (func != null)
      {
        // ISSUE: reference to a compiler-generated method
        IQueryInFunction queryInFunction = ComponentManager.Current.GetExtensionPoints<IQueryInFunction>().FirstOrDefault<IQueryInFunction>((Func<IQueryInFunction, bool>) (q => (string) EQLHelper.\u003C\u003Ec__DisplayClass11_1.GaTpKrCUexHIrMMODCMD((object) q) == func.Name));
        IEQLFunction eqlFunction1 = queryInFunction as IEQLFunction;
        if (queryInFunction == null || eqlFunction1 == null)
          throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867875652), (object) func.Name));
        Guid uid = new Guid();
        foreach (EQLFunction eqlFunction2 in eqlFunction1.GetEqlFunctions())
          uid = ((IEnumerable<Guid>) eqlFunction2.Types).First<Guid>();
        System.Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid);
        EQLHelper.Aliases alias = ((EQLHelper.Aliases) aliases).CreateAlias((EntityMetadata) MetadataLoader.LoadMetadata(typeByUid));
        Constant[] array = func.Parameters.GetChildItems().Cast<Constant>().Select<Constant, Constant>((Func<Constant, Constant>) (c => c)).ToArray<Constant>();
        DetachedCriteria aggregationOperand = EQLHelper.DetachedCriteriaFor(typeByUid, (object) alias.CurrentAlias);
        aggregationOperand.Add(queryInFunction.GetCriterion(alias.CurrentAlias, (EntityMetadata) MetadataLoader.LoadMetadata(typeByUid), z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293721530), (object[]) array));
        aggregationOperand.SetProjection((IProjection) Projections.Count((IProjection) Projections.Id()));
        return (object) aggregationOperand;
      }
      if (property.Short)
      {
        EntityMetadata metadata4Property = ((EQLHelper.Aliases) aliases).GetMetadata4Property(property.Expression as EleWise.ELMA.NemerleParser.Property);
        System.Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(metadata4Property.Uid);
        PropertyInfo reflectionProperty = typeByUid.GetReflectionProperty(property.Name);
        if (reflectionProperty == (PropertyInfo) null)
          throw new PropertyNotFoundEQLException(property.Start, property.Name);
        if (!typeof (ISet).IsAssignableFrom(reflectionProperty.PropertyType) && (!reflectionProperty.PropertyType.IsGenericType || !(reflectionProperty.PropertyType.GetGenericTypeDefinition() == typeof (Iesi.Collections.Generic.ISet<>))))
          throw new PropertyNotFoundEQLException(property.Start, property.Name);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        IEntityPropertyMetadata propMetadta = (IEntityPropertyMetadata) metadata4Property.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EQLHelper.\u003C\u003Ec__DisplayClass11_0.JtlVBLCUKEfOuki8KaY8(EQLHelper.\u003C\u003Ec__DisplayClass11_0.nik9iOCURISPceA8VQiI((object) p), EQLHelper.\u003C\u003Ec__DisplayClass11_0.TjAAohCUqr0kCFU2EiUc((object) property)))) ?? (IEntityPropertyMetadata) metadata4Property.TableParts.FirstOrDefault<TablePartMetadata>((Func<TablePartMetadata, bool>) (tp => EQLHelper.\u003C\u003Ec__DisplayClass11_0.JtlVBLCUKEfOuki8KaY8(EQLHelper.\u003C\u003Ec__DisplayClass11_0.zjVVpDCUXWN0JXpfeMgc((object) tp), (object) property.Name)));
        if (propMetadta == null || propMetadta.TypeUid != TablePartMetadata.UID && !(propMetadta.Settings is EntitySettings))
          throw new PropertyNotFoundEQLException(property.Start, property.Name);
        EQLHelper.Aliases alias = ((EQLHelper.Aliases) aliases).CreateAlias(propMetadta.TypeUid == TablePartMetadata.UID ? (EntityMetadata) propMetadta : (EntityMetadata) MetadataLoader.LoadMetadata(propMetadta.SubTypeUid));
        DetachedCriteria aggregationOperand;
        string propertyName;
        if (propMetadta.TypeUid == TablePartMetadata.UID)
        {
          aggregationOperand = EQLHelper.DetachedCriteriaFor(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(propMetadta.Uid), (object) alias.CurrentAlias);
          propertyName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811997064);
        }
        else if (propMetadta.Settings is EntitySettings && ((EntitySettings) propMetadta.Settings).RelationType == RelationType.OneToMany)
        {
          aggregationOperand = EQLHelper.DetachedCriteriaFor(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(propMetadta.SubTypeUid), (object) alias.CurrentAlias);
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          propertyName = ((ClassMetadata) MetadataLoader.LoadMetadata(propMetadta.SubTypeUid)).Properties.First<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EQLHelper.\u003C\u003Ec__DisplayClass11_2.LXXwxFCUtS8oWPckxvdV(EQLHelper.\u003C\u003Ec__DisplayClass11_2.Fl52DjCUpJY3PIqv4Ycl((object) p), EQLHelper.\u003C\u003Ec__DisplayClass11_2.astrVLCUDJ3Qhj7RDYhy((object) (EntitySettings) EQLHelper.\u003C\u003Ec__DisplayClass11_2.onUKPNCUaxSLdqAxVPN6((object) propMetadta))))).Name;
        }
        else
        {
          aggregationOperand = EQLHelper.DetachedCriteriaFor(typeByUid, (object) alias.NewAlias()).CreateAlias(property.Name, alias.CurrentAlias, JoinType.InnerJoin);
          propertyName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426456882 ^ 2009939514 ^ -583777878);
        }
        aggregationOperand.SetProjection((IProjection) Projections.Count((IProjection) Projections.Id()));
        aggregationOperand.Add((ICriterion) Restrictions.EqProperty(propertyName, ((EQLHelper.Aliases) aliases).GetProperty((EleWise.ELMA.NemerleParser.Property) property, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306486778))));
        return (object) aggregationOperand;
      }
      if (property.Function == null || !property.Function.Name.Equals(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306452298), StringComparison.OrdinalIgnoreCase))
        return (object) null;
      // ISSUE: reference to a compiler-generated method
      DetachedCriteria detachedCriteria = ((EQLHelper.Aliases) aliases).CreateDetachedCriteria(ComponentManager.Current.GetExtensionPoints<IEntityMetadataSearcher>().Select<IEntityMetadataSearcher, EntityMetadata>((Func<IEntityMetadataSearcher, EntityMetadata>) (p => p.FindEntityMetadata((string) EQLHelper.\u003C\u003Ec__DisplayClass11_0.M3veANCUT2vZiWdkGEsM((object) property)))).FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (m => m != null)) ?? throw new ClassNotFoundEQLException(property.FromEntityStart, property.FromEntity), (TreeItem) property.Expression, propertyCriterionFunc, level + 1);
      detachedCriteria.SetProjection((IProjection) Projections.Count((IProjection) Projections.Id()));
      return (object) detachedCriteria;
    }

    private static DetachedCriteria GetCriteria4SubqueryExpression(
      object subquery,
      object queryCast,
      object aliases,
      Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc,
      int level)
    {
      EleWise.ELMA.NemerleParser.SubqueryExpression subquery1 = (EleWise.ELMA.NemerleParser.SubqueryExpression) subquery;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      EntityMetadata entityMetadata1 = ComponentManager.Current.GetExtensionPoints<IEntityMetadataSearcher>().Select<IEntityMetadataSearcher, EntityMetadata>((Func<IEntityMetadataSearcher, EntityMetadata>) (p => (EntityMetadata) EQLHelper.\u003C\u003Ec__DisplayClass12_0.zZKW4dCU7qJXwH6vnkFW((object) p, EQLHelper.\u003C\u003Ec__DisplayClass12_0.t85v3KCUAXu4YXcvXabn((object) subquery1)))).FirstOrDefault<EntityMetadata>((Func<EntityMetadata, bool>) (m => m != null));
      if (!(InterfaceActivator.LoadMetadata(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityMetadata1.Uid)) is EntityMetadata entityMetadata2))
        entityMetadata2 = entityMetadata1;
      EntityMetadata metadata = entityMetadata2;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      IEntityPropertyMetadata propertyMetadata = (IEntityPropertyMetadata) metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EQLHelper.\u003C\u003Ec__DisplayClass12_0.UERvX4CUm5iuXf4WGgww(EQLHelper.\u003C\u003Ec__DisplayClass12_0.PWuBVoCUxPcCLAj5ESHu((object) p), EQLHelper.\u003C\u003Ec__DisplayClass12_0.iDiePoCU0hG0P3RKgn5y((object) subquery1)))) ?? (IEntityPropertyMetadata) metadata.TableParts.FirstOrDefault<TablePartMetadata>((Func<TablePartMetadata, bool>) (tp => EQLHelper.\u003C\u003Ec__DisplayClass12_0.UERvX4CUm5iuXf4WGgww(EQLHelper.\u003C\u003Ec__DisplayClass12_0.Y11tSYCUyWdq0JroHteX((object) tp), EQLHelper.\u003C\u003Ec__DisplayClass12_0.iDiePoCU0hG0P3RKgn5y((object) subquery1))));
      DetachedCriteria detachedCriteria = ((EQLHelper.Aliases) aliases).CreateDetachedCriteria(metadata, (TreeItem) subquery1.Expression, propertyCriterionFunc, level + 1);
      if ((propertyMetadata == null || propertyMetadata.TypeUid != TablePartMetadata.UID && !(propertyMetadata.Settings is EntitySettings) ? 0 : (propertyMetadata.TypeUid == TablePartMetadata.UID ? 1 : (int) ((EntitySettings) propertyMetadata.Settings).RelationType)) == 0)
      {
        detachedCriteria.SetProjection(((IQueryCastExtension) queryCast).CastRightOperand(subquery1.SelectProperty));
      }
      else
      {
        string alias = ((EQLHelper.Aliases) aliases).NewAlias();
        detachedCriteria.CreateAlias(subquery1.SelectProperty, alias).SetProjection(((IQueryCastExtension) queryCast).CastRightOperand(alias + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420910718)));
      }
      return detachedCriteria;
    }

    private static EqExpression GetEqExpression(object prop1Exp, object item, object aliases)
    {
      int num = 3;
      EQLHelper.Aliases aliases1;
      EleWise.ELMA.NemerleParser.Property prop1Exp1;
      while (true)
      {
        switch (num)
        {
          case 1:
            prop1Exp1 = (EleWise.ELMA.NemerleParser.Property) prop1Exp;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
            aliases1 = (EQLHelper.Aliases) aliases;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
            continue;
          case 3:
            num = 2;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return EQLHelper.GetRestriction<EqExpression>((Func<EleWise.ELMA.NemerleParser.Property, EqExpression>) (rhsPropName => new EqExpression(aliases1.GetProperty(prop1Exp1), (EntityMetadata) EQLHelper.\u003C\u003Ec__DisplayClass13_0.IRqkY5CUdRne69F8NrIq((object) aliases1, (object) prop1Exp1), (string) EQLHelper.\u003C\u003Ec__DisplayClass13_0.SqDcXTCUlVIfxHBkx28U((object) aliases1, (object) rhsPropName), (EntityMetadata) EQLHelper.\u003C\u003Ec__DisplayClass13_0.IRqkY5CUdRne69F8NrIq((object) aliases1, (object) rhsPropName))), (Func<Constant, EqExpression>) (constExp => new EqExpression((string) EQLHelper.\u003C\u003Ec__DisplayClass13_0.SqDcXTCUlVIfxHBkx28U((object) aliases1, (object) prop1Exp1), aliases1.GetMetadata4Property(prop1Exp1), EQLHelper.GetConstantValue((object) prop1Exp1, (object) aliases1, (object) constExp))), item, (object) aliases1, (object) prop1Exp1);
    }

    private static ICriterion GetRestriction(
      Func<string, string, ICriterion> projFunc,
      Func<string, object, ICriterion> valFunc,
      object propName,
      object lAliases,
      object propExp,
      object item,
      object rAliases)
    {
      EQLHelper.Aliases lAliases1 = (EQLHelper.Aliases) lAliases;
      string propName1 = (string) propName;
      EQLHelper.Aliases rAliases1 = (EQLHelper.Aliases) rAliases;
      Func<string, object, ICriterion> valFunc1 = valFunc;
      EleWise.ELMA.NemerleParser.Property propExp1 = (EleWise.ELMA.NemerleParser.Property) propExp;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return EQLHelper.GetRestriction<ICriterion>((Func<EleWise.ELMA.NemerleParser.Property, ICriterion>) (rhsPropName => projFunc(lAliases1.GetProperty(propName1), (string) EQLHelper.\u003C\u003Ec__DisplayClass14_0.esU999CUYx1SOurJXPWm((object) rAliases1, (object) rhsPropName))), (Func<Constant, ICriterion>) (constExp => valFunc1((string) EQLHelper.\u003C\u003Ec__DisplayClass14_0.YWjdhCCUL12h5hqB07Gl((object) lAliases1, (object) propName1), EQLHelper.GetConstantValue((object) propExp1, (object) rAliases1, (object) constExp))), item, (object) rAliases1, (object) propExp1);
    }

    private static ICriterion GetRestriction(
      Func<string, string, ICriterion> projFunc,
      Func<string, object, ICriterion> valFunc,
      object propExp,
      object item,
      object aliases)
    {
      EQLHelper.Aliases aliases1 = (EQLHelper.Aliases) aliases;
      EleWise.ELMA.NemerleParser.Property propExp1 = (EleWise.ELMA.NemerleParser.Property) propExp;
      Func<string, object, ICriterion> valFunc1 = valFunc;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return EQLHelper.GetRestriction<ICriterion>((Func<EleWise.ELMA.NemerleParser.Property, ICriterion>) (rhsPropName => projFunc((string) EQLHelper.\u003C\u003Ec__DisplayClass15_0.wXiTNHCsFLYNiFOrnDKx((object) aliases1, (object) propExp1), (string) EQLHelper.\u003C\u003Ec__DisplayClass15_0.wXiTNHCsFLYNiFOrnDKx((object) aliases1, (object) rhsPropName))), (Func<Constant, ICriterion>) (constExp => valFunc1(aliases1.GetProperty(propExp1), EQLHelper.GetConstantValue((object) propExp1, (object) aliases1, (object) constExp))), item, (object) aliases1, (object) propExp1);
    }

    private static ICriterion GetRestrictionSubqueries(
      Func<string, DetachedCriteria, ICriterion> projFunc,
      Func<object, DetachedCriteria, ICriterion> valFunc,
      object property,
      object aliases,
      object detach)
    {
      EQLHelper.Aliases aliases1 = (EQLHelper.Aliases) aliases;
      DetachedCriteria detach1 = (DetachedCriteria) detach;
      Func<object, DetachedCriteria, ICriterion> valFunc1 = valFunc;
      // ISSUE: reference to a compiler-generated method
      return EQLHelper.GetRestriction<ICriterion>((Func<EleWise.ELMA.NemerleParser.Property, ICriterion>) (rhsPropName => projFunc((string) EQLHelper.\u003C\u003Ec__DisplayClass16_0.sqFMPNCsh1BVZFqCtGe0((object) aliases1, (object) rhsPropName), detach1)), (Func<Constant, ICriterion>) (constExp => valFunc1(constExp.Value, detach1)), property, (object) aliases1, (object) null);
    }

    private static TCriterion GetRestriction<TCriterion>(
      Func<EleWise.ELMA.NemerleParser.Property, TCriterion> projFunc,
      Func<Constant, TCriterion> valFunc,
      object item,
      object aliases,
      object leftProperty)
      where TCriterion : class, ICriterion
    {
      switch (item)
      {
        case EleWise.ELMA.NemerleParser.Property propExp:
          if (Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(((EQLHelper.Aliases) aliases).GetMetadata4Property(propExp).Uid).GetReflectionProperty(propExp.Name) != (PropertyInfo) null)
            return projFunc(propExp);
          throw new PropertyNotFoundEQLException(propExp.Start, propExp.Name);
        case EleWise.ELMA.NemerleParser.Parameter parameter:
          Constant constant1 = new Constant();
          constant1.Start = parameter.Start;
          constant1.Stop = parameter.Stop;
          constant1.Value = ((EQLHelper.Aliases) aliases).GetParameter(parameter.Name, (EleWise.ELMA.NemerleParser.Property) leftProperty);
          Constant constant2 = constant1;
          return valFunc(constant2);
        case Constant constant3:
          return valFunc(constant3);
        default:
          return default (TCriterion);
      }
    }

    private static object GetConstantValue(
      object propExp,
      object aliases,
      object constExp,
      bool availableConvertion = true)
    {
      int num1 = 29;
      IQueryFunctionResult queryFunctionResult;
      // ISSUE: variable of a compiler-generated type
      EQLHelper.\u003C\u003Ec__DisplayClass18_0 cDisplayClass180;
      object[] array;
      object source;
      while (true)
      {
        int num2 = num1;
        // ISSUE: variable of a compiler-generated type
        EQLHelper.\u003C\u003Ec__DisplayClass18_2 cDisplayClass182;
        // ISSUE: variable of a compiler-generated type
        EQLHelper.\u003C\u003Ec__DisplayClass18_1 cDisplayClass181;
        IQueryTypeConvertion queryTypeConvertion;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass181.valueType = source.GetType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 21 : 26;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              array = cDisplayClass180.constFuncExp.Parameters.GetChildItems().Cast<Constant>().Select<Constant, object>(new Func<Constant, object>(cDisplayClass180.\u003CGetConstantValue\u003Eb__1)).ToArray<object>();
              num2 = 20;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass182.CS\u0024\u003C\u003E8__locals2 = cDisplayClass181;
              num2 = 6;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              source = EQLHelper.utHDOvh8oL0yWxxvIfpP((object) queryTypeConvertion, EQLHelper.hhEZSgh8BTQpWO0VKTsJ((object) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.aliases, (object) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.propExp), EQLHelper.lPSghwh8WhkwviDBOEHm((object) cDisplayClass181.CS\u0024\u003C\u003E8__locals1.propExp), source);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            case 5:
            case 27:
              // ISSUE: reference to a compiler-generated method
              queryTypeConvertion = ((ComponentManager) EQLHelper.fhL8gahvducpY25IM2XS()).GetExtensionPoints<IQueryTypeConvertion>().FirstOrDefault<IQueryTypeConvertion>(new Func<IQueryTypeConvertion, bool>(cDisplayClass181.\u003CGetConstantValue\u003Eb__4));
              num2 = 13;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass182.CS\u0024\u003C\u003E8__locals2.valueType = cDisplayClass182.CS\u0024\u003C\u003E8__locals2.valueType.GetInterface((string) EQLHelper.k6UCYRh8FBUIE99VboA8((object) TypeOf.IEnumerable)).GetGenericArguments()[0];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 5 : 15;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass181.CS\u0024\u003C\u003E8__locals1 = cDisplayClass180;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass180.propExp = (EleWise.ELMA.NemerleParser.Property) propExp;
              num2 = 25;
              continue;
            case 9:
              if (queryFunctionResult != null)
              {
                num2 = 2;
                continue;
              }
              goto label_36;
            case 10:
              source = EQLHelper.aJFxnLhvzol61JYipW2Z(constExp);
              num2 = 12;
              continue;
            case 11:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass180.constFuncExp != null)
              {
                // ISSUE: reference to a compiler-generated method
                queryFunctionResult = ComponentManager.Current.GetExtensionPoints<IQueryFunctionResult>().FirstOrDefault<IQueryFunctionResult>(new Func<IQueryFunctionResult, bool>(cDisplayClass180.\u003CGetConstantValue\u003Eb__0));
                num2 = 9;
                continue;
              }
              num2 = 10;
              continue;
            case 12:
              if (availableConvertion)
              {
                num2 = 22;
                continue;
              }
              goto label_21;
            case 13:
              if (queryTypeConvertion != null)
              {
                num2 = 4;
                continue;
              }
              goto label_21;
            case 15:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              cDisplayClass182.queryTypeConvertion = ((ComponentManager) EQLHelper.fhL8gahvducpY25IM2XS()).GetExtensionPoints<IQueryTypeConvertion>().FirstOrDefault<IQueryTypeConvertion>(new Func<IQueryTypeConvertion, bool>(cDisplayClass182.CS\u0024\u003C\u003E8__locals2.\u003CGetConstantValue\u003Eb__2));
              num2 = 16;
              continue;
            case 16:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass182.queryTypeConvertion != null)
                goto case 19;
              else
                goto label_28;
            case 17:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass182 = new EQLHelper.\u003C\u003Ec__DisplayClass18_2();
              num2 = 3;
              continue;
            case 19:
              // ISSUE: reference to a compiler-generated method
              source = (object) ((IEnumerable) source).Cast<object>().Select<object, object>(new Func<object, object>(cDisplayClass182.\u003CGetConstantValue\u003Eb__3)).ToArray<object>();
              num2 = 18;
              continue;
            case 20:
              goto label_7;
            case 21:
              goto label_36;
            case 22:
              if (EQLHelper.aJFxnLhvzol61JYipW2Z(constExp) != null)
              {
                num2 = 23;
                continue;
              }
              goto label_21;
            case 23:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass181 = new EQLHelper.\u003C\u003Ec__DisplayClass18_1();
              num2 = 7;
              continue;
            case 24:
              // ISSUE: reference to a compiler-generated field
              if (!cDisplayClass181.valueType.IsEnumerable())
              {
                num2 = 5;
                continue;
              }
              goto case 17;
            case 25:
              goto label_19;
            case 26:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass181.valueType != TypeOf<string>.Raw)
              {
                num2 = 24;
                continue;
              }
              goto case 5;
            case 28:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass180.aliases = (EQLHelper.Aliases) aliases;
              num2 = 8;
              continue;
            case 29:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass180 = new EQLHelper.\u003C\u003Ec__DisplayClass18_0();
              num2 = 28;
              continue;
            default:
              goto label_21;
          }
        }
label_19:
        // ISSUE: reference to a compiler-generated field
        cDisplayClass180.constFuncExp = constExp as ConstantFunction;
        num1 = 11;
        continue;
label_28:
        num1 = 14;
      }
label_7:
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return EQLHelper.j4CdhHh8hksGvG4P291X((object) queryFunctionResult, EQLHelper.hhEZSgh8BTQpWO0VKTsJ((object) cDisplayClass180.aliases, (object) cDisplayClass180.propExp), EQLHelper.lPSghwh8WhkwviDBOEHm((object) cDisplayClass180.propExp), (object) array);
label_21:
      return source;
label_36:
      // ISSUE: reference to a compiler-generated field
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979431743), EQLHelper.yVeqGPh8bu86ciTT0E4T((object) cDisplayClass180.constFuncExp)));
    }

    static EQLHelper()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EQLHelper.SessionProvider = Locator.GetServiceNotNull<ISessionProvider>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 2:
            EQLHelper.iGPRqkh8Go9GCB68tCAB();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool wnxFmBhvAxNBwAS04THS([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object Uc9dPWhv7GTmJTJrHvwL([In] object obj0) => (object) ((string) obj0).ToLowerInvariant();

    internal static bool JB1hichvxuoo3YexxUYc([In] object obj0) => ((option<EleWise.ELMA.NemerleParser.Expression>) obj0).HasValue;

    internal static Guid z4WvcBhv0fbrBlF8b3U2([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object wlTs9ShvmvCJyQ615Bo3([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static object YQB8Y8hvycLh4s0OMR7c([In] object obj0, [In] System.Type obj1) => (object) ((ISession) obj0).CreateCriteria(obj1);

    internal static bool bSm84ohv6Ydmv4RKM9h7() => EQLHelper.hsP6oGhv4uMbCOqpfc2q == null;

    internal static EQLHelper CT8JFMhvHyejBcCad4rl() => EQLHelper.hsP6oGhv4uMbCOqpfc2q;

    internal static object njpOifhvMBHbZRRQ8V4u([In] object obj0) => (object) ((ISession) obj0).GetSessionImplementation();

    internal static object YBlUuohvJEo45pgAFiKx([In] object obj0, [In] object obj1) => (object) DetachedCriteria.ForEntityName((string) obj0, (string) obj1);

    internal static object a1EkeQhv980IXhmjalqu(System.Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static object fhL8gahvducpY25IM2XS() => (object) ComponentManager.Current;

    internal static int aobMsVhvlGv6oo8R9Fdv([In] object obj0) => ((EleWise.ELMA.NemerleParser.SubqueryExpression) obj0).FromEntityStart;

    internal static object gT2penhvr0mpNiGPktCB([In] object obj0) => (object) ((EleWise.ELMA.NemerleParser.SubqueryExpression) obj0).FromEntity;

    internal static object loSPmBhvggYpqR0k3JQC([In] object obj0) => (object) ((EleWise.ELMA.NemerleParser.SubqueryExpression) obj0).SelectProperty;

    internal static bool Eaywuwhv5lwL9PXcC8qf([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static int Sepr90hvjIJt3Vx56wj4([In] object obj0) => ((EleWise.ELMA.NemerleParser.SubqueryExpression) obj0).SelectPropertyStart;

    internal static int Os3pqphvYl8SqDg9itqJ([In] object obj0) => ((TreeItem) obj0).Start;

    internal static void dkFhf5hvLrkCCV9ucW3T([In] object obj0, [In] int obj1) => ((TreeItem) obj0).Start = obj1;

    internal static int gjfKyAhvUZiuD1SXHv1J([In] object obj0) => ((TreeItem) obj0).Stop;

    internal static object CO7yw9hvs69d2sFU5ApE([In] object obj0) => (object) ((EleWise.ELMA.NemerleParser.Parameter) obj0).Name;

    internal static void dRZ4LIhvco9FjEf5jScA([In] object obj0, [In] object obj1) => ((Constant) obj0).Value = obj1;

    internal static object aJFxnLhvzol61JYipW2Z([In] object obj0) => ((Constant) obj0).Value;

    internal static object k6UCYRh8FBUIE99VboA8([In] object obj0) => (object) ((RipeType) obj0).FullName;

    internal static object hhEZSgh8BTQpWO0VKTsJ([In] object obj0, [In] object obj1) => (object) ((EQLHelper.Aliases) obj0).GetMetadata4Property((EleWise.ELMA.NemerleParser.Property) obj1);

    internal static object lPSghwh8WhkwviDBOEHm([In] object obj0) => (object) ((EleWise.ELMA.NemerleParser.Property) obj0).Name;

    internal static object utHDOvh8oL0yWxxvIfpP(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((IQueryTypeConvertion) obj0).ConvertValue((EntityMetadata) obj1, (string) obj2, obj3);
    }

    internal static object yVeqGPh8bu86ciTT0E4T([In] object obj0) => (object) ((ConstantFunction) obj0).Name;

    internal static object j4CdhHh8hksGvG4P291X(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((IQueryFunctionResult) obj0).GetValue((EntityMetadata) obj1, (string) obj2, (object[]) obj3);
    }

    internal static void iGPRqkh8Go9GCB68tCAB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class Aliases
    {
      private readonly List<string> aliases;
      private readonly List<EntityMetadata> metadatas;
      private int aliasIndex;
      private readonly object rootAlias;
      private object parameter;
      private bool onlyParse;
      private static object wKLZLYCLhQ1O9sKq7tPO;

      internal Aliases(
        ICriteria criteria,
        EntityMetadata metadata,
        ParsedQueryParameters parameters)
      {
        EQLHelper.Aliases.NHmVtiCLfwgV4t2FVCbu();
        // ISSUE: explicit constructor call
        this.\u002Ector(criteria, metadata, (string) null, (EleWise.ELMA.Model.Common.QueryParameters) parameters);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.onlyParse = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      public Aliases(
        ICriteria criteria,
        EntityMetadata metadata,
        string alias,
        EleWise.ELMA.Model.Common.QueryParameters parameters)
      {
        EQLHelper.Aliases.NHmVtiCLfwgV4t2FVCbu();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              EleWise.ELMA.Model.Common.QueryParameters queryParameters = parameters;
              this.parameter = queryParameters == null ? (object) new EleWise.ELMA.Model.Common.QueryParameters() : (object) queryParameters;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
              continue;
            case 3:
              this.aliases = new List<string>()
              {
                (string) ((object) alias ?? EQLHelper.Aliases.fjuEmZCLQDIjmNwSRTwl((object) criteria))
              };
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
              continue;
            default:
              this.metadatas = new List<EntityMetadata>()
              {
                metadata
              };
              num = 2;
              continue;
          }
        }
label_5:;
      }

      private Aliases(EQLHelper.Aliases currentAliases, EntityMetadata metadata, string alias)
      {
        EQLHelper.Aliases.NHmVtiCLfwgV4t2FVCbu();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num1 = 3;
        while (true)
        {
          int num2;
          switch (num1)
          {
            case 1:
              this.metadatas.Add(metadata);
              num2 = 4;
              break;
            case 2:
              goto label_3;
            case 3:
              this.onlyParse = currentAliases.onlyParse;
              num1 = 5;
              continue;
            case 4:
              this.parameter = currentAliases.parameter;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 1;
              continue;
            case 5:
              this.rootAlias = currentAliases.rootAlias ?? (object) currentAliases;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
              continue;
            case 6:
              this.aliases.Add(alias ?? this.NewAlias());
              num1 = 7;
              continue;
            case 7:
              this.metadatas = currentAliases.metadatas.ToList<EntityMetadata>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
              continue;
            default:
              this.aliases = currentAliases.aliases.ToList<string>();
              num2 = 6;
              break;
          }
          num1 = num2;
        }
label_3:;
      }

      public string NewAlias()
      {
        object obj1 = EQLHelper.Aliases.RF5xPdCLCvJSJDXqLfgM(-87337865 ^ -87101685);
        object rootAlias = this.rootAlias;
        object obj2 = rootAlias == null ? (object) this : rootAlias;
        int num = ((EQLHelper.Aliases) obj2).aliasIndex + 1;
        ((EQLHelper.Aliases) obj2).aliasIndex = num;
        // ISSUE: variable of a boxed type
        __Boxed<int> local = (System.ValueType) num;
        return obj1.ToString() + (object) local;
      }

      public string CurrentAlias => this.aliases[EQLHelper.Aliases.mAZN7ECLvAsi1qpBd40F((object) this.aliases) - 1];

      public EQLHelper.Aliases CreateAlias(EntityMetadata metadata, string alias = null) => new EQLHelper.Aliases(this, metadata, alias);

      public DetachedCriteria CreateDetachedCriteria(
        EntityMetadata metadata,
        TreeItem item,
        Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc,
        int level)
      {
        EQLHelper.Aliases alias = this.CreateAlias(metadata);
        return EQLHelper.DetachedCriteriaFor(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(metadata.Uid), (object) alias.CurrentAlias).Add(EQLHelper.GetCriterionNodeForQueryTreeItem((object) item, (object) alias, propertyCriterionFunc, level + 1));
      }

      public string GetProperty(string propName) => (string) EQLHelper.Aliases.IkR25QCL8wFfYbh7S5O7(EQLHelper.Aliases.RF5xPdCLCvJSJDXqLfgM(-477139494 ^ -477155368), (object) this.aliases[EQLHelper.Aliases.mAZN7ECLvAsi1qpBd40F((object) this.aliases) - 1], (object) propName);

      public string GetProperty(EleWise.ELMA.NemerleParser.Property propExp)
      {
        int num = 1;
        string propName;
        while (true)
        {
          switch (num)
          {
            case 1:
              propName = (string) EQLHelper.Aliases.FVNZJTCLZNstO7te1LFw((object) propExp);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            case 2:
            case 4:
              goto label_6;
            case 3:
              propName = (string) EQLHelper.Aliases.FDUHM0CLuvJi7hruXIZI((object) this.GetMetadata4Property(propExp));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 4 : 4;
              continue;
            default:
              if (!(propName == z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 1867363217)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 2 : 2;
                continue;
              }
              goto case 3;
          }
        }
label_6:
        return this.GetProperty(propExp, propName);
      }

      public string GetProperty(EleWise.ELMA.NemerleParser.Property propExp, string propName)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!EQLHelper.Aliases.yFN97pCLIF0MF66XbVl3((object) propExp))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_10;
            case 3:
              goto label_2;
            case 4:
            case 5:
              goto label_9;
            case 6:
              if (EQLHelper.Aliases.wNNr3sCLVWvw71MdTKt5((object) propExp) < EQLHelper.Aliases.mAZN7ECLvAsi1qpBd40F((object) this.aliases))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 2;
                continue;
              }
              goto label_9;
            default:
              if (propExp.ParentProperty < 0)
              {
                num = 4;
                continue;
              }
              goto case 6;
          }
        }
label_2:
        return (string) EQLHelper.Aliases.IkR25QCL8wFfYbh7S5O7(EQLHelper.Aliases.RF5xPdCLCvJSJDXqLfgM(1581325282 << 3 ^ -234316526), (object) this.aliases[0], (object) propName);
label_9:
        throw new PropertyNotFoundEQLException(EQLHelper.Aliases.y8mLjUCLSTMAuPBXYakH((object) propExp), propExp.ToString());
label_10:
        return (string) EQLHelper.Aliases.IkR25QCL8wFfYbh7S5O7(EQLHelper.Aliases.RF5xPdCLCvJSJDXqLfgM(~-397266137 ^ 397250266), (object) this.aliases[EQLHelper.Aliases.mAZN7ECLvAsi1qpBd40F((object) this.aliases) - EQLHelper.Aliases.wNNr3sCLVWvw71MdTKt5((object) propExp) - 1], (object) propName);
      }

      public string GetAlias4Property(EleWise.ELMA.NemerleParser.Property propExp)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (EQLHelper.Aliases.yFN97pCLIF0MF66XbVl3((object) propExp))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
                continue;
              }
              if (EQLHelper.Aliases.wNNr3sCLVWvw71MdTKt5((object) propExp) >= 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 2 : 1;
                continue;
              }
              goto label_2;
            case 2:
              if (EQLHelper.Aliases.wNNr3sCLVWvw71MdTKt5((object) propExp) >= EQLHelper.Aliases.mAZN7ECLvAsi1qpBd40F((object) this.aliases))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 3 : 2;
                continue;
              }
              goto label_3;
            case 3:
              goto label_2;
            default:
              goto label_8;
          }
        }
label_2:
        throw new PropertyNotFoundEQLException(EQLHelper.Aliases.y8mLjUCLSTMAuPBXYakH((object) propExp), propExp.ToString());
label_3:
        return this.aliases[this.aliases.Count - EQLHelper.Aliases.wNNr3sCLVWvw71MdTKt5((object) propExp) - 1];
label_8:
        return this.aliases[0];
      }

      public EntityMetadata GetMetadata4Property(EleWise.ELMA.NemerleParser.Property propExp)
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 2:
              goto label_7;
            case 3:
              goto label_8;
            case 4:
              if (EQLHelper.Aliases.yFN97pCLIF0MF66XbVl3((object) propExp))
              {
                num = 3;
                continue;
              }
              if (EQLHelper.Aliases.wNNr3sCLVWvw71MdTKt5((object) propExp) < 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 5:
              if (propExp.ParentProperty < EQLHelper.Aliases.mAZN7ECLvAsi1qpBd40F((object) this.aliases))
              {
                num = 2;
                continue;
              }
              goto label_6;
            default:
              goto label_6;
          }
        }
label_6:
        throw new PropertyNotFoundEQLException(EQLHelper.Aliases.y8mLjUCLSTMAuPBXYakH((object) propExp), propExp.ToString());
label_7:
        return this.metadatas[EQLHelper.Aliases.mAZN7ECLvAsi1qpBd40F((object) this.aliases) - EQLHelper.Aliases.wNNr3sCLVWvw71MdTKt5((object) propExp) - 1];
label_8:
        return this.metadatas[0];
      }

      public object GetParameter(string name, EleWise.ELMA.NemerleParser.Property propExp, bool needCollection = false)
      {
        int num1 = 7;
        object parameter1;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            object obj;
            switch (num2)
            {
              case 1:
                goto label_24;
              case 2:
              case 16:
                goto label_10;
              case 3:
                if (parameter1 is IEnumerable source)
                {
                  num2 = 12;
                  continue;
                }
                goto case 15;
              case 4:
                if (!needCollection)
                {
                  num2 = 5;
                  continue;
                }
                goto label_15;
              case 5:
                goto label_16;
              case 6:
                object parameter2 = this.parameter;
                if (parameter2 == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                  continue;
                }
                obj = ((EleWise.ELMA.Model.Common.QueryParameters) parameter2).Get(name);
                break;
              case 7:
                if (!this.onlyParse)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 6;
                  continue;
                }
                goto case 17;
              case 8:
                goto label_19;
              case 9:
                goto label_25;
              case 10:
                goto label_7;
              case 11:
                goto label_15;
              case 12:
                if (parameter1 is string)
                {
                  num2 = 15;
                  continue;
                }
                goto case 13;
              case 13:
                if (needCollection)
                {
                  if (source.Cast<object>().Any<object>())
                    goto case 14;
                  else
                    goto label_21;
                }
                else
                {
                  num2 = 8;
                  continue;
                }
              case 14:
                if (source.Cast<object>().Any<object>((Func<object, bool>) (o => o == null)))
                {
                  num2 = 2;
                  continue;
                }
                goto label_16;
              case 15:
                if (parameter1 != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 4 : 0;
                  continue;
                }
                goto label_7;
              case 17:
                if (((ParsedQueryParameters) this.parameter).TryCheckAndGet(name, this.GetMetadata4Property(propExp), (string) EQLHelper.Aliases.FVNZJTCLZNstO7te1LFw((object) propExp), needCollection, out parameter1))
                {
                  num2 = 9;
                  continue;
                }
                goto label_24;
              default:
                obj = (object) null;
                break;
            }
            parameter1 = obj;
            num2 = 3;
          }
label_21:
          num1 = 16;
        }
label_7:
        throw new VariableNotFoundException(name);
label_10:
        throw new VariableNotFoundException(name);
label_15:
        throw new IncorrectVariableTypeException(name);
label_16:
        return parameter1;
label_19:
        throw new IncorrectVariableTypeException(name);
label_24:
        throw new IncorrectVariableTypeException(name);
label_25:
        return parameter1;
      }

      internal static void NHmVtiCLfwgV4t2FVCbu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool NC3Cu9CLG20RK0QdWBmK() => EQLHelper.Aliases.wKLZLYCLhQ1O9sKq7tPO == null;

      internal static EQLHelper.Aliases sV9GOgCLEpZNjZtMYVGs() => (EQLHelper.Aliases) EQLHelper.Aliases.wKLZLYCLhQ1O9sKq7tPO;

      internal static object fjuEmZCLQDIjmNwSRTwl([In] object obj0) => (object) ((ICriteria) obj0).Alias;

      internal static object RF5xPdCLCvJSJDXqLfgM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static int mAZN7ECLvAsi1qpBd40F([In] object obj0) => ((List<string>) obj0).Count;

      internal static object IkR25QCL8wFfYbh7S5O7([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

      internal static object FVNZJTCLZNstO7te1LFw([In] object obj0) => (object) ((EleWise.ELMA.NemerleParser.Property) obj0).Name;

      internal static object FDUHM0CLuvJi7hruXIZI([In] object obj0) => (object) NHibernateHelper.GetCriteriaTypeUidPropertyName((EntityMetadata) obj0);

      internal static bool yFN97pCLIF0MF66XbVl3([In] object obj0) => ((EleWise.ELMA.NemerleParser.Property) obj0).RootProperty;

      internal static int wNNr3sCLVWvw71MdTKt5([In] object obj0) => ((EleWise.ELMA.NemerleParser.Property) obj0).ParentProperty;

      internal static int y8mLjUCLSTMAuPBXYakH([In] object obj0) => ((TreeItem) obj0).Start;
    }

    private class EQLPropertyInSubqueryExpression : NHibernate.Criterion.SubqueryExpression
    {
      private object propertyName;
      private object queryCast;
      private static object bJVwPXCLiYhkGBX1SQ9F;

      public EQLPropertyInSubqueryExpression(string propertyName, DetachedCriteria dc)
      {
        EQLHelper.EQLPropertyInSubqueryExpression.hdgcbICLK0A8GvZ8Vval();
        // ISSUE: explicit constructor call
        base.\u002Ector((string) EQLHelper.EQLPropertyInSubqueryExpression.eFA10MCLX6H4StoKXEuP(-441065788 ^ -2092910478 ^ 1727061286), (string) null, dc);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.propertyName = (object) propertyName;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 1;
              continue;
          }
        }
label_3:;
      }

      public EQLPropertyInSubqueryExpression(
        string propertyName,
        DetachedCriteria dc,
        IQueryCastExtension queryCast)
      {
        EQLHelper.EQLPropertyInSubqueryExpression.hdgcbICLK0A8GvZ8Vval();
        // ISSUE: explicit constructor call
        this.\u002Ector(propertyName, dc);
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.queryCast = (object) queryCast;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }

      protected override SqlString ToLeftSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery) => new SqlString(criteriaQuery.GetColumn(criteria, (string) this.propertyName));

      public override SqlString ToSqlString(ICriteria criteria, ICriteriaQuery criteriaQuery)
      {
        int num1 = 2;
        SqlString queryString;
        SqlStringBuilder sqlStringBuilder;
        while (true)
        {
          int num2 = num1;
          ISessionFactoryImplementor factory1;
          CriteriaImpl criteria1;
          while (true)
          {
            EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator criteriaQueryTranslator;
            switch (num2)
            {
              case 1:
                goto label_3;
              case 2:
                criteria1 = (CriteriaImpl) this.Criteria;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
                continue;
              case 3:
              case 8:
                goto label_5;
              case 4:
                this.parameters = criteriaQueryTranslator.GetQueryParameters();
                num2 = 12;
                continue;
              case 5:
              case 6:
                if (!EQLHelper.EQLPropertyInSubqueryExpression.tfaqVkCLkBvvkDWVTmBL((object) criteriaQueryTranslator))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 3 : 9;
                  continue;
                }
                IOuterJoinLoadable persister = (IOuterJoinLoadable) EQLHelper.EQLPropertyInSubqueryExpression.p0dydDCLn7Dm0qxWisPA((object) factory1, (object) criteria1.EntityOrClassName);
                sqlStringBuilder = new SqlStringBuilder();
                if (this.queryCast != null)
                  EQLHelper.EQLPropertyInSubqueryExpression.zAykIwCLeqmZ0wxv5fO6((object) sqlStringBuilder, EQLHelper.EQLPropertyInSubqueryExpression.N2MqUBCL2dgIfHokINCE(this.queryCast, EQLHelper.EQLPropertyInSubqueryExpression.x4GuNrCLO8fYZ9i2baIc((object) this, (object) criteria, (object) criteriaQuery)));
                else
                  EQLHelper.EQLPropertyInSubqueryExpression.zAykIwCLeqmZ0wxv5fO6((object) sqlStringBuilder, (object) this.ToLeftSqlString(criteria, criteriaQuery));
                criteria1.Session = (ISessionImplementor) EQLHelper.EQLPropertyInSubqueryExpression.U3rbMBCLPVPNO9I0H8Hc((object) criteria);
                EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator translator = criteriaQueryTranslator;
                ISessionFactoryImplementor factory2 = factory1;
                CriteriaImpl criteriaImpl = criteria1;
                string entityOrClassName = criteria1.EntityOrClassName;
                ISessionImplementor session = criteria1.Session;
                IDictionary<string, IFilter> enabledFilters = (session == null ? (IDictionary<string, IFilter>) null : session.EnabledFilters) ?? (IDictionary<string, IFilter>) new Dictionary<string, IFilter>();
                queryString = new CriteriaJoinWalker(persister, (CriteriaQueryTranslator) translator, factory2, (ICriteria) criteriaImpl, entityOrClassName, enabledFilters).SqlString;
                num2 = 11;
                continue;
              case 7:
                goto label_6;
              case 9:
                goto label_19;
              case 10:
                if (EQLHelper.EQLPropertyInSubqueryExpression.tfaqVkCLkBvvkDWVTmBL((object) criteriaQueryTranslator))
                {
                  num2 = 4;
                  continue;
                }
                goto case 13;
              case 11:
                if (criteria1.FirstResult != 0)
                {
                  num2 = 3;
                  continue;
                }
                break;
              case 12:
                this.types = criteriaQueryTranslator.ProjectedTypes;
                num2 = 6;
                continue;
              case 13:
                this.types = (IType[]) null;
                num2 = 5;
                continue;
              case 14:
                criteriaQueryTranslator = new EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator(factory1, criteria1, criteria, criteriaQuery);
                num2 = 10;
                continue;
            }
            if (EQLHelper.EQLPropertyInSubqueryExpression.Gef3lnCL1PAhQK2tepUC((object) criteria1) != RowSelection.NoValue)
              num2 = 8;
            else
              goto label_6;
          }
label_3:
          factory1 = (ISessionFactoryImplementor) EQLHelper.EQLPropertyInSubqueryExpression.hr7eA8CLTCvlw2qvQVqR((object) criteriaQuery);
          num1 = 14;
          continue;
label_5:
          queryString = factory1.Dialect.GetLimitString(queryString, new int?(EQLHelper.EQLPropertyInSubqueryExpression.k8YKEfCLNb5mWyJeywKw((object) criteria1)), new int?(EQLHelper.EQLPropertyInSubqueryExpression.Gef3lnCL1PAhQK2tepUC((object) criteria1)), (NHibernate.SqlCommand.Parameter) null, (NHibernate.SqlCommand.Parameter) null);
          num1 = 7;
        }
label_6:
        return (SqlString) EQLHelper.EQLPropertyInSubqueryExpression.pCZ0rACL3woR9pF3H0Kg((object) ((SqlStringBuilder) EQLHelper.EQLPropertyInSubqueryExpression.zAykIwCLeqmZ0wxv5fO6((object) sqlStringBuilder.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317665770)), (object) queryString)).Add((string) EQLHelper.EQLPropertyInSubqueryExpression.eFA10MCLX6H4StoKXEuP(-1217523399 ^ -1217524091)));
label_19:
        throw new QueryException((string) EQLHelper.EQLPropertyInSubqueryExpression.eFA10MCLX6H4StoKXEuP(1242972401 >> 4 ^ 77914007));
      }

      private static ISessionImplementor DeriveRootSession(object criteria)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 2:
              if (criteria is CriteriaImpl.Subcriteria subcriteria)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 3:
              goto label_2;
            case 4:
              if (!(criteria is CriteriaImpl criteriaImpl))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 4 : 5;
                continue;
              }
              goto label_2;
            case 5:
              goto label_3;
            default:
              criteria = EQLHelper.EQLPropertyInSubqueryExpression.wiSqCmCLpDlWjRxa0rr4((object) subcriteria);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 2 : 1;
              continue;
          }
        }
label_2:
        return (ISessionImplementor) EQLHelper.EQLPropertyInSubqueryExpression.e3pPJwCLatI6N5qTmGtV((object) criteriaImpl);
label_3:
        return (ISessionImplementor) null;
      }

      internal static void hdgcbICLK0A8GvZ8Vval() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object eFA10MCLX6H4StoKXEuP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool fpp7rECLRJemuphF495t() => EQLHelper.EQLPropertyInSubqueryExpression.bJVwPXCLiYhkGBX1SQ9F == null;

      internal static EQLHelper.EQLPropertyInSubqueryExpression OsQBgPCLqMkwrE0PH1D8() => (EQLHelper.EQLPropertyInSubqueryExpression) EQLHelper.EQLPropertyInSubqueryExpression.bJVwPXCLiYhkGBX1SQ9F;

      internal static object hr7eA8CLTCvlw2qvQVqR([In] object obj0) => (object) ((ICriteriaQuery) obj0).Factory;

      internal static bool tfaqVkCLkBvvkDWVTmBL([In] object obj0) => ((CriteriaQueryTranslator) obj0).HasProjection;

      internal static object p0dydDCLn7Dm0qxWisPA([In] object obj0, [In] object obj1) => (object) ((ISessionFactoryImplementor) obj0).GetEntityPersister((string) obj1);

      internal static object x4GuNrCLO8fYZ9i2baIc([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((NHibernate.Criterion.SubqueryExpression) obj0).ToLeftSqlString((ICriteria) obj1, (ICriteriaQuery) obj2);

      internal static object N2MqUBCL2dgIfHokINCE([In] object obj0, [In] object obj1) => (object) ((IQueryCastExtension) obj0).CastLeftOperand((SqlString) obj1);

      internal static object zAykIwCLeqmZ0wxv5fO6([In] object obj0, [In] object obj1) => (object) ((SqlStringBuilder) obj0).Add((SqlString) obj1);

      internal static object U3rbMBCLPVPNO9I0H8Hc([In] object obj0) => (object) EQLHelper.EQLPropertyInSubqueryExpression.DeriveRootSession(obj0);

      internal static int Gef3lnCL1PAhQK2tepUC([In] object obj0) => ((CriteriaImpl) obj0).MaxResults;

      internal static int k8YKEfCLNb5mWyJeywKw([In] object obj0) => ((CriteriaImpl) obj0).FirstResult;

      internal static object pCZ0rACL3woR9pF3H0Kg([In] object obj0) => (object) ((SqlStringBuilder) obj0).ToSqlString();

      internal static object wiSqCmCLpDlWjRxa0rr4([In] object obj0) => (object) ((CriteriaImpl.Subcriteria) obj0).Parent;

      internal static object e3pPJwCLatI6N5qTmGtV([In] object obj0) => (object) ((CriteriaImpl) obj0).Session;

      private class EQLCriteriaQueryTranslator : CriteriaQueryTranslator
      {
        private new readonly IDictionary<ICriteria, ICriteriaInfoProvider> criteriaInfoMap;
        private new readonly IDictionary<string, ICriteriaInfoProvider> nameCriteriaInfoMap;
        private new readonly IDictionary<ICriteria, string> criteriaSQLAliasMap;
        private new readonly IDictionary<string, ICriteria> aliasCriteriaMap;
        private static object lHetiPZSlTWCc5ehN98O;

        public EQLCriteriaQueryTranslator(
          ISessionFactoryImplementor factory,
          CriteriaImpl criteria,
          ICriteria rootCriteria,
          ICriteriaQuery outerQuery)
        {
          EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.TYI4ZYZS5s4CIdSAurbx();
          this.criteriaInfoMap = (IDictionary<ICriteria, ICriteriaInfoProvider>) new Dictionary<ICriteria, ICriteriaInfoProvider>();
          this.nameCriteriaInfoMap = (IDictionary<string, ICriteriaInfoProvider>) new Dictionary<string, ICriteriaInfoProvider>();
          this.criteriaSQLAliasMap = (IDictionary<ICriteria, string>) new Dictionary<ICriteria, string>();
          this.aliasCriteriaMap = (IDictionary<string, ICriteria>) new Dictionary<string, ICriteria>();
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.\u003C\u003Ec__DisplayClass4_0 cDisplayClass40 = new EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.\u003C\u003Ec__DisplayClass4_0();
          // ISSUE: reference to a compiler-generated field
          cDisplayClass40.factory = factory;
          // ISSUE: reference to a compiler-generated field
          cDisplayClass40.rootCriteria = rootCriteria;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: explicit constructor call
          base.\u002Ector(cDisplayClass40.factory, criteria, criteria.EntityOrClassName, outerQuery.GenerateSQLAlias(), outerQuery);
          int num1 = 24;
          while (true)
          {
            int num2;
            EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator criteriaQueryTranslator;
            ICriteriaInfoProvider criteriaInfoProvider1;
            CriteriaImpl.Subcriteria rootCriteria1;
            // ISSUE: variable of a compiler-generated type
            EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.\u003C\u003Ec__DisplayClass4_1 cDisplayClass41;
            ICriteriaInfoProvider criteriaInfoProvider2;
            switch (num1)
            {
              case 1:
                criteriaQueryTranslator.criteriaSQLAliasMap.Each<KeyValuePair<ICriteria, string>>(new Action<KeyValuePair<ICriteria, string>>(((ICollection<KeyValuePair<ICriteria, string>>) this.criteriaSQLAliasMap).Add));
                num1 = 7;
                continue;
              case 2:
                // ISSUE: reference to a compiler-generated field
                IEnumerable<CriteriaImpl.Subcriteria> source = cDisplayClass41.root.IterateSubcriteria();
                // ISSUE: reference to a compiler-generated field
                Func<CriteriaImpl.Subcriteria, bool> func = EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.\u003C\u003Ec.\u003C\u003E9__4_1;
                Func<CriteriaImpl.Subcriteria, bool> predicate;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.\u003C\u003Ec.\u003C\u003E9__4_1 = predicate = (Func<CriteriaImpl.Subcriteria, bool>) (sub => EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.\u003C\u003Ec.OUrcwmZaGucXbIDZ6E9Q((object) sub) != null);
                }
                else
                  goto label_33;
label_30:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                source.Where<CriteriaImpl.Subcriteria>(predicate).ForEach<CriteriaImpl.Subcriteria>(new Action<CriteriaImpl.Subcriteria>(cDisplayClass41.CS\u0024\u003C\u003E8__locals1.\u003C\u002Ector\u003Eb__2));
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 7 : 12;
                continue;
label_33:
                predicate = func;
                goto label_30;
              case 3:
                if (rootCriteria1 == null)
                {
                  num1 = 4;
                  continue;
                }
                goto case 16;
              case 4:
              case 21:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                criteriaInfoProvider1 = this.criteriaInfoMap.AddIfNotContainsKey<ICriteria, ICriteriaInfoProvider>(cDisplayClass40.rootCriteria, new Func<ICriteria, ICriteriaInfoProvider>(cDisplayClass40.\u003C\u002Ector\u003Eb__0));
                num1 = 22;
                continue;
              case 5:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.aliasCriteriaMap.AddIfNotContainsKey<string, ICriteria>((string) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.FaruMvZSLAjL70nRGdlT((object) cDisplayClass40.rootCriteria), cDisplayClass40.rootCriteria);
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 26;
                continue;
              case 6:
              case 25:
                // ISSUE: reference to a compiler-generated field
                rootCriteria1 = cDisplayClass40.rootCriteria as CriteriaImpl.Subcriteria;
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 3;
                continue;
              case 7:
                criteriaQueryTranslator.aliasCriteriaMap.Each<KeyValuePair<string, ICriteria>>(new Action<KeyValuePair<string, ICriteria>>(((ICollection<KeyValuePair<string, ICriteria>>) this.aliasCriteriaMap).Add));
                num1 = 6;
                continue;
              case 8:
                this.nameCriteriaInfoMap.AddIfNotContainsKey<string, ICriteriaInfoProvider>((string) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.NqumJmZSYI9leEFXJYhQ((object) criteriaInfoProvider2), criteriaInfoProvider2);
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 10 : 3;
                continue;
              case 9:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass41.root = this.GetRootCriteria(rootCriteria1);
                num1 = 17;
                continue;
              case 10:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                cDisplayClass41.root.IterateSubcriteria().ForEach<CriteriaImpl.Subcriteria>(new Action<CriteriaImpl.Subcriteria>(cDisplayClass41.\u003C\u002Ector\u003Eb__4));
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 12 : 21;
                continue;
              case 11:
                criteriaQueryTranslator.nameCriteriaInfoMap.Each<KeyValuePair<string, ICriteriaInfoProvider>>(new Action<KeyValuePair<string, ICriteriaInfoProvider>>(((ICollection<KeyValuePair<string, ICriteriaInfoProvider>>) this.nameCriteriaInfoMap).Add));
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
                continue;
              case 12:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                criteriaInfoProvider2 = this.criteriaInfoMap.AddIfNotContainsKey<ICriteria, ICriteriaInfoProvider>((ICriteria) cDisplayClass41.root, new Func<ICriteria, ICriteriaInfoProvider>(cDisplayClass41.\u003C\u002Ector\u003Eb__3));
                num1 = 8;
                continue;
              case 13:
                this.criteriaInfoMap.Each<KeyValuePair<ICriteria, ICriteriaInfoProvider>>(new Action<KeyValuePair<ICriteria, ICriteriaInfoProvider>>(((EleWise.ELMA.Extensions.CollectionExtensions) base.criteriaInfoMap).AddIfNotContainsKey<ICriteria, ICriteriaInfoProvider>));
                num1 = 23;
                continue;
              case 14:
                if (criteriaQueryTranslator == null)
                {
                  num1 = 25;
                  continue;
                }
                goto case 20;
              case 15:
                this.aliasCriteriaMap.Each<KeyValuePair<string, ICriteria>>(new Action<KeyValuePair<string, ICriteria>>(((EleWise.ELMA.Extensions.CollectionExtensions) base.aliasCriteriaMap).AddIfNotContainsKey<string, ICriteria>));
                num2 = 19;
                break;
              case 16:
                // ISSUE: object of a compiler-generated type is created
                cDisplayClass41 = new EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.\u003C\u003Ec__DisplayClass4_1();
                num2 = 18;
                break;
              case 17:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.aliasCriteriaMap.AddIfNotContainsKey<string, ICriteria>((string) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.NQwRUGZSjQH3lgkPXCJm((object) cDisplayClass41.root), (ICriteria) cDisplayClass41.root);
                num1 = 2;
                continue;
              case 18:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass41.CS\u0024\u003C\u003E8__locals1 = cDisplayClass40;
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 3 : 9;
                continue;
              case 19:
                goto label_32;
              case 20:
                criteriaQueryTranslator.criteriaInfoMap.Each<KeyValuePair<ICriteria, ICriteriaInfoProvider>>(new Action<KeyValuePair<ICriteria, ICriteriaInfoProvider>>(((ICollection<KeyValuePair<ICriteria, ICriteriaInfoProvider>>) this.criteriaInfoMap).Add));
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 11 : 4;
                continue;
              case 22:
                this.nameCriteriaInfoMap.AddIfNotContainsKey<string, ICriteriaInfoProvider>((string) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.NqumJmZSYI9leEFXJYhQ((object) criteriaInfoProvider1), criteriaInfoProvider1);
                num1 = 5;
                continue;
              case 23:
                this.nameCriteriaInfoMap.Each<KeyValuePair<string, ICriteriaInfoProvider>>(new Action<KeyValuePair<string, ICriteriaInfoProvider>>(((EleWise.ELMA.Extensions.CollectionExtensions) base.nameCriteriaInfoMap).AddIfNotContainsKey<string, ICriteriaInfoProvider>));
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
                continue;
              case 24:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass40.\u003C\u003E4__this = this;
                num1 = 27;
                continue;
              case 26:
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                this.criteriaSQLAliasMap.AddIfNotContainsKey<ICriteria, string>(cDisplayClass40.rootCriteria, !(outerQuery is CriteriaQueryTranslator) ? cDisplayClass40.rootCriteria.Alias : (string) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.IxUwoqZSUECQlvLP3U2M((object) (CriteriaQueryTranslator) outerQuery));
                num1 = 13;
                continue;
              case 27:
                criteriaQueryTranslator = outerQuery as EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator;
                num1 = 14;
                continue;
              default:
                this.criteriaSQLAliasMap.Each<KeyValuePair<ICriteria, string>>(new Action<KeyValuePair<ICriteria, string>>(((EleWise.ELMA.Extensions.CollectionExtensions) base.criteriaSQLAliasMap).AddIfNotContainsKey<ICriteria, string>));
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 15 : 2;
                continue;
            }
            num1 = num2;
          }
label_32:;
        }

        private CriteriaImpl GetRootCriteria(CriteriaImpl.Subcriteria criteria)
        {
          int num = 2;
          while (true)
          {
            switch (num)
            {
              case 1:
                goto label_3;
              case 2:
                if (EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.dgvJWoZSsrCWTnvVlL68((object) criteria) is CriteriaImpl.Subcriteria)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
                  continue;
                }
                goto label_2;
              default:
                goto label_2;
            }
          }
label_2:
          return (CriteriaImpl) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.dgvJWoZSsrCWTnvVlL68((object) criteria);
label_3:
          return this.GetRootCriteria((CriteriaImpl.Subcriteria) criteria.Parent);
        }

        private string GetWholeAssociationPath(
          CriteriaImpl rootCriteria,
          CriteriaImpl.Subcriteria subcriteria)
        {
          int num1 = 1;
          ICriteria criteria;
          string qualifiedName;
          while (true)
          {
            int num2 = num1;
            string key;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  qualifiedName = subcriteria.Path;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
                  continue;
                case 2:
                  goto label_16;
                case 3:
                case 11:
                case 14:
                  if (criteria == null)
                  {
                    num2 = 7;
                    continue;
                  }
                  goto case 5;
                case 4:
                  goto label_15;
                case 5:
                  qualifiedName = (string) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.zPDGswZiF7pX9Ol7vocn((object) qualifiedName);
                  num2 = 9;
                  continue;
                case 6:
                  goto label_6;
                case 7:
                  criteria = (ICriteria) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.dgvJWoZSsrCWTnvVlL68((object) subcriteria);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 10;
                  continue;
                case 8:
                  if (EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.X1lNM6ZSc2d7AoNUbHVs((object) qualifiedName, '.') <= 0)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 3 : 3;
                    continue;
                  }
                  goto label_6;
                case 9:
                case 10:
                  if (criteria.Equals((object) rootCriteria))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 1;
                    continue;
                  }
                  goto label_15;
                case 12:
                  goto label_14;
                case 13:
                  if (EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.QVTHZmZSzpTMo3bLmwml((object) key, (object) subcriteria.Alias))
                  {
                    num2 = 14;
                    continue;
                  }
                  goto label_14;
                default:
                  goto label_3;
              }
            }
label_3:
            criteria = (ICriteria) null;
            num1 = 8;
            continue;
label_6:
            key = StringHelper.Root(qualifiedName);
            num1 = 13;
            continue;
label_14:
            this.aliasCriteriaMap.TryGetValue(key, out criteria);
            num1 = 11;
          }
label_15:
          return (string) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.aG2QCAZiWSPgsRWAnXo8((object) this.GetWholeAssociationPath(rootCriteria, (CriteriaImpl.Subcriteria) criteria), EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.V4qey4ZiBtdCe5bvfhfe(1149433385 + 173655049 ^ 1323081974), (object) qualifiedName);
label_16:
          return qualifiedName;
        }

        private ICriteriaInfoProvider GetPathInfo(
          ISessionFactoryImplementor sessionFactory,
          CriteriaImpl rootCriteria,
          string path)
        {
          int num1 = 1;
          ICriteriaInfoProvider pathInfo;
          string relativePath;
          IEnumerator<string> enumerator;
          while (true)
          {
            switch (num1)
            {
              case 1:
                StringTokenizer stringTokenizer = new StringTokenizer(path, (string) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.V4qey4ZiBtdCe5bvfhfe(-1998538950 ^ -1998541314), false);
                relativePath = string.Empty;
                pathInfo = this.criteriaInfoMap[(ICriteria) rootCriteria];
                enumerator = stringTokenizer.GetEnumerator();
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_2;
              default:
                goto label_4;
            }
          }
label_2:
          return pathInfo;
label_4:
          try
          {
label_34:
            if (EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.KIVGgEZi8V600mrO4JqG((object) enumerator))
              goto label_19;
            else
              goto label_35;
label_7:
            string current;
            int num2;
            while (true)
            {
              int num3;
              IType type1;
              CollectionType collectionType1;
              IAssociationType associationType;
              IType type2;
              SessionFactoryHelper helper;
              object obj;
              CollectionType collectionType2;
              switch (num2)
              {
                case 1:
                  type1 = pathInfo.GetType(relativePath);
                  num2 = 24;
                  continue;
                case 2:
                  helper = new SessionFactoryHelper(sessionFactory);
                  num2 = 11;
                  continue;
                case 3:
                  associationType = (IAssociationType) type1;
                  num2 = 9;
                  continue;
                case 4:
                case 7:
                  pathInfo = (ICriteriaInfoProvider) new EntityCriteriaInfoProvider((NHibernate.Persister.Entity.IQueryable) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.TEW8BhZivRhKSAxCHNAh((object) sessionFactory, EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.wdrHF6ZiCFd27p1AyAEj((object) associationType, (object) sessionFactory)));
                  num2 = 17;
                  continue;
                case 5:
                  collectionType2 = (CollectionType) null;
                  goto label_40;
                case 6:
                  if (EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.AVaxXvZiQqu7dLZHvZ0e((object) type2))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 4 : 0;
                    continue;
                  }
                  goto case 18;
                case 8:
                case 28:
                  if (!EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.m98m5MZiGVyXK5LlojQn((object) type1))
                  {
                    num3 = 27;
                    break;
                  }
                  goto case 25;
                case 9:
                  if (!EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.iAieciZibSv01rGUaHpL((object) type1))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 5 : 5;
                    continue;
                  }
                  collectionType2 = (CollectionType) type1;
                  goto label_40;
                case 10:
                  goto label_2;
                case 11:
                  if (collectionType1 != null)
                  {
                    num2 = 13;
                    continue;
                  }
                  goto case 19;
                case 12:
                case 29:
                  goto label_34;
                case 13:
                  if (!EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.m98m5MZiGVyXK5LlojQn((object) type2))
                  {
                    num2 = 19;
                    continue;
                  }
                  goto case 30;
                case 14:
                  goto label_19;
                case 15:
                case 16:
                case 17:
                  relativePath = string.Empty;
                  num3 = 29;
                  break;
                case 18:
                  pathInfo = (ICriteriaInfoProvider) new ScalarCollectionCriteriaInfoProvider(helper, (string) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.idmc3nZiETpZhCem2Clq((object) collectionType1));
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 15 : 9;
                  continue;
                case 19:
                case 22:
                  if (collectionType1 != null)
                  {
                    num2 = 6;
                    continue;
                  }
                  goto case 4;
                case 20:
                  if (collectionType1 != null)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
                    continue;
                  }
                  goto case 21;
                case 21:
                  obj = (object) null;
                  goto label_42;
                case 23:
                  relativePath = (string) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.yYl8p9ZiorIqryU8jlmO((object) relativePath, (object) current);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
                  continue;
                case 24:
                  if (!type1.IsAssociationType)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 3 : 8;
                    continue;
                  }
                  goto case 3;
                case 25:
                  relativePath = (string) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.yYl8p9ZiorIqryU8jlmO((object) relativePath, EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.V4qey4ZiBtdCe5bvfhfe(-643786247 ^ -643792067));
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 12 : 7;
                  continue;
                case 26:
                case 27:
                  goto label_33;
                case 30:
                  pathInfo = (ICriteriaInfoProvider) new ComponentCollectionCriteriaInfoProvider((IQueryableCollection) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.pD3ey7ZifUmIfI9FoHB1((object) helper, EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.idmc3nZiETpZhCem2Clq((object) collectionType1)));
                  num2 = 16;
                  continue;
                default:
                  obj = EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.QHDOQmZih2AC49UqvAbn((object) collectionType1, (object) sessionFactory);
                  goto label_42;
              }
              num2 = num3;
              continue;
label_40:
              collectionType1 = collectionType2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 20 : 5;
              continue;
label_42:
              type2 = (IType) obj;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 2;
            }
label_33:
            throw new QueryException((string) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.V4qey4ZiBtdCe5bvfhfe(--1867379187 ^ 1867242559) + relativePath);
label_19:
            current = enumerator.Current;
            num2 = 23;
            goto label_7;
label_35:
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 5 : 10;
            goto label_7;
          }
          finally
          {
            if (enumerator != null)
            {
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
                num4 = 0;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_48;
                  default:
                    EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.X3fBIsZiZPW6CJb0g2JY((object) enumerator);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
                    continue;
                }
              }
            }
label_48:;
          }
        }

        internal static void TYI4ZYZS5s4CIdSAurbx() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static object NQwRUGZSjQH3lgkPXCJm([In] object obj0) => (object) ((CriteriaImpl) obj0).Alias;

        internal static object NqumJmZSYI9leEFXJYhQ([In] object obj0) => (object) ((ICriteriaInfoProvider) obj0).Name;

        internal static object FaruMvZSLAjL70nRGdlT([In] object obj0) => (object) ((ICriteria) obj0).Alias;

        internal static object IxUwoqZSUECQlvLP3U2M([In] object obj0) => (object) ((CriteriaQueryTranslator) obj0).RootSQLAlias;

        internal static bool RiKMGsZSrJsGBq0rmqoj() => EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.lHetiPZSlTWCc5ehN98O == null;

        internal static EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator j1ukMRZSg6hnCVenUbZ2() => (EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator) EQLHelper.EQLPropertyInSubqueryExpression.EQLCriteriaQueryTranslator.lHetiPZSlTWCc5ehN98O;

        internal static object dgvJWoZSsrCWTnvVlL68([In] object obj0) => (object) ((CriteriaImpl.Subcriteria) obj0).Parent;

        internal static int X1lNM6ZSc2d7AoNUbHVs([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

        internal static bool QVTHZmZSzpTMo3bLmwml([In] object obj0, [In] object obj1) => ((string) obj0).Equals((string) obj1);

        internal static object zPDGswZiF7pX9Ol7vocn([In] object obj0) => (object) StringHelper.Unroot((string) obj0);

        internal static object V4qey4ZiBtdCe5bvfhfe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static object aG2QCAZiWSPgsRWAnXo8([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

        internal static object yYl8p9ZiorIqryU8jlmO([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

        internal static bool iAieciZibSv01rGUaHpL([In] object obj0) => ((IType) obj0).IsCollectionType;

        internal static object QHDOQmZih2AC49UqvAbn([In] object obj0, [In] object obj1) => (object) ((CollectionType) obj0).GetElementType((ISessionFactoryImplementor) obj1);

        internal static bool m98m5MZiGVyXK5LlojQn([In] object obj0) => ((IType) obj0).IsComponentType;

        internal static object idmc3nZiETpZhCem2Clq([In] object obj0) => (object) ((CollectionType) obj0).Role;

        internal static object pD3ey7ZifUmIfI9FoHB1([In] object obj0, [In] object obj1) => (object) ((SessionFactoryHelper) obj0).GetCollectionPersister((string) obj1);

        internal static bool AVaxXvZiQqu7dLZHvZ0e([In] object obj0) => ((IType) obj0).IsEntityType;

        internal static object wdrHF6ZiCFd27p1AyAEj([In] object obj0, [In] object obj1) => (object) ((IAssociationType) obj0).GetAssociatedEntityName((ISessionFactoryImplementor) obj1);

        internal static object TEW8BhZivRhKSAxCHNAh([In] object obj0, [In] object obj1) => (object) ((ISessionFactoryImplementor) obj0).GetEntityPersister((string) obj1);

        internal static bool KIVGgEZi8V600mrO4JqG([In] object obj0) => ((IEnumerator) obj0).MoveNext();

        internal static void X3fBIsZiZPW6CJb0g2JY([In] object obj0) => ((IDisposable) obj0).Dispose();
      }
    }
  }
}
