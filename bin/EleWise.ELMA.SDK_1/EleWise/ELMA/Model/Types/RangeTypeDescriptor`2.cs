// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.RangeTypeDescriptor`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Базовый класс описания диапазонного типа</summary>
  /// <typeparam name="T">Тип CLR</typeparam>
  /// <typeparam name="SettingsT">Тип настроек</typeparam>
  public abstract class RangeTypeDescriptor<T, SettingsT> : CLRTypeDescriptor<T, SettingsT>
  {
    private static object jgYrJSo6u6n7lh0yXdsQ;

    /// <summary>Можно ли использовать тип для сущностей</summary>
    public override bool UseForEntity => false;

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => RangeTypesDescriptor.UID;

    /// <summary>Может ли тип быть Nullable</summary>
    public override bool CanBeNullable => false;

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public override bool IsEmpty(PropertyMetadata propertyMetadata, object value)
    {
      int num = 1;
      object toValue;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          case 3:
            goto label_7;
          case 4:
            object fromValue = this.GetFromValue((T) value);
            toValue = this.GetToValue((T) value);
            if (fromValue != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 5 : 4;
              continue;
            }
            goto label_7;
          case 5:
            goto label_8;
          default:
            if (!(value.GetType() != typeof (T)))
            {
              num = 4;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return true;
label_7:
      return toValue == null;
label_8:
      return false;
    }

    /// <summary>Применить в критерий NHibernate условия</summary>
    /// <param name="criteria">Критерий</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="value">Значение фильтра</param>
    public override void ApplyFilterValue(
      ICriteria criteria,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      object value,
      string alias)
    {
      int num = 8;
      object toValue;
      object fromValue;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (fromValue != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 6 : 6;
              continue;
            }
            goto case 2;
          case 2:
            toValue = this.GetToValue((T) value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_11;
          case 4:
            goto label_17;
          case 5:
            criteria.Add((ICriterion) Restrictions.Le(!string.IsNullOrEmpty(alias) ? string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470456156), (object) alias, (object) propertyMetadata.Name) : propertyMetadata.Name, toValue));
            num = 9;
            continue;
          case 6:
            criteria.Add((ICriterion) Restrictions.Ge(string.IsNullOrEmpty(alias) ? propertyMetadata.Name : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638419437), (object) alias, (object) propertyMetadata.Name), fromValue));
            num = 2;
            continue;
          case 7:
            if (!(value.GetType() != typeof (T)))
            {
              fromValue = this.GetFromValue((T) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
              continue;
            }
            num = 4;
            continue;
          case 8:
            if (value != null)
            {
              num = 7;
              continue;
            }
            goto label_8;
          case 9:
            goto label_2;
          default:
            if (toValue == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 3;
              continue;
            }
            goto case 5;
        }
      }
label_11:
      return;
label_17:
      return;
label_2:
      return;
label_8:;
    }

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398550394)));
    }

    protected abstract object GetFromValue(T value);

    protected abstract object GetToValue(T value);

    protected RangeTypeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ykRjOmo6ImCCNNHTUh1P() => RangeTypeDescriptor<T, SettingsT>.jgYrJSo6u6n7lh0yXdsQ == null;

    internal static object kloI0co6VporhElaS0Ei() => RangeTypeDescriptor<T, SettingsT>.jgYrJSo6u6n7lh0yXdsQ;
  }
}
