// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CustomTypes.DateTimeWithoutOffsetNHType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Type;
using System;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.CustomTypes
{
  /// <summary>
  /// Тип NHibernate для DateTime.
  /// Не учитывается смещение между сервером и БД
  /// </summary>
  [Serializable]
  public class DateTimeWithoutOffsetNHType : DateTimeNHType
  {
    private static DateTimeWithoutOffsetNHType sUkdUFW0W6IPJXsahCYP;

    /// <summary>
    /// Retrieve an instance of the mapped class from a JDBC resultset.
    ///             Implementors should handle possibility of null values.
    /// </summary>
    /// <param name="rs">a IDataReader</param>
    /// <param name="names">column names</param>
    /// <param name="owner">the containing entity</param>
    /// <param name="session"></param>
    /// <returns />
    /// <exception cref="T:NHibernate.HibernateException">HibernateException</exception>
    public override object NullSafeGet(
      DbDataReader rs,
      string[] names,
      ISessionImplementor session,
      object owner)
    {
      return DateTimeWithoutOffsetNHType.tFJPjRW0h6YQqFbT70XT((object) NHibernateUtil.DateTime, (object) rs, (object) names[0], (object) session);
    }

    /// <summary>
    /// Write an instance of the mapped class to a prepared statement.
    ///             Implementors should handle possibility of null values.
    ///             A multi-column type should be written to parameters starting from index.
    /// </summary>
    /// <param name="cmd">a IDbCommand</param>
    /// <param name="value">the object to write</param>
    /// <param name="index">command parameter index</param>
    /// <param name="session"></param>
    /// <exception cref="T:NHibernate.HibernateException">HibernateException</exception>
    public override void NullSafeSet(
      DbCommand cmd,
      object value,
      int index,
      ISessionImplementor session)
    {
      int num = 1;
      DateTime dateTime;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            }
            dateTime = (DateTime) value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 3;
            continue;
          case 2:
            goto label_2;
          case 3:
            ((IDataParameter) DateTimeWithoutOffsetNHType.CUcwjHW0Ea0nwXUv3wTR(DateTimeWithoutOffsetNHType.X7mYagW0Gbl8TvDu2iyj((object) cmd), index)).Value = dateTime != new DateTime() ? (object) dateTime : (object) DBNull.Value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_6;
          default:
            ((IDataParameter) DateTimeWithoutOffsetNHType.CUcwjHW0Ea0nwXUv3wTR(DateTimeWithoutOffsetNHType.X7mYagW0Gbl8TvDu2iyj((object) cmd), index)).Value = (object) DBNull.Value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 3 : 4;
            continue;
        }
      }
label_2:
      return;
label_6:;
    }

    public DateTimeWithoutOffsetNHType()
    {
      DateTimeWithoutOffsetNHType.YxKMvqW0fI4xHxSL88HB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object tFJPjRW0h6YQqFbT70XT(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((NullableType) obj0).NullSafeGet((DbDataReader) obj1, (string) obj2, (ISessionImplementor) obj3);
    }

    internal static bool RwPAkmW0oDL6C37nK1Br() => DateTimeWithoutOffsetNHType.sUkdUFW0W6IPJXsahCYP == null;

    internal static DateTimeWithoutOffsetNHType H9XXhbW0bPvo369SwdOS() => DateTimeWithoutOffsetNHType.sUkdUFW0W6IPJXsahCYP;

    internal static object X7mYagW0Gbl8TvDu2iyj([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static object CUcwjHW0Ea0nwXUv3wTR([In] object obj0, [In] int obj1) => (object) ((DbParameterCollection) obj0)[obj1];

    internal static void YxKMvqW0fI4xHxSL88HB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
