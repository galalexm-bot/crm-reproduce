// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.SqlQueryInfoExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics
{
  public static class SqlQueryInfoExtension
  {
    private static SqlQueryInfoExtension n4pW2ZEohgwN8YlRLuLs;

    /// <summary>Получить список параметров SQL-команды</summary>
    /// <param name="parameters">Коллекция параметров</param>
    /// <returns></returns>
    public static IList<SqlQueryInfo.CommandParamater> AsQueryInfoCommandParamaters(
      this IDataParameterCollection parameters)
    {
      return parameters == null || parameters.Count == 0 ? (IList<SqlQueryInfo.CommandParamater>) new List<SqlQueryInfo.CommandParamater>(0) : (IList<SqlQueryInfo.CommandParamater>) parameters.Cast<DbParameter>().Select<DbParameter, SqlQueryInfo.CommandParamater>((System.Func<DbParameter, SqlQueryInfo.CommandParamater>) (p =>
      {
        SqlQueryInfo.CommandParamater commandParamater = new SqlQueryInfo.CommandParamater();
        // ISSUE: reference to a compiler-generated method
        commandParamater.Name = (string) SqlQueryInfoExtension.\u003C\u003Ec.LCuf0x8SiAkg6PLI3n8x((object) p);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        SqlQueryInfoExtension.\u003C\u003Ec.iECGZS8Sq2u078eu814c((object) commandParamater, SqlQueryInfoExtension.\u003C\u003Ec.vjqH6X8SRm8XsnvYwwRW((object) p));
        // ISSUE: reference to a compiler-generated method
        SqlQueryInfoExtension.\u003C\u003Ec.VlVFAe8SKYnyMnG1EtZV((object) commandParamater, (object) p.DbType.ToString());
        // ISSUE: reference to a compiler-generated method
        commandParamater.Value = SqlQueryInfoExtension.\u003C\u003Ec.iisjRq8SXHfSXLVKQjWN((object) p);
        return commandParamater;
      })).ToList<SqlQueryInfo.CommandParamater>();
    }

    /// <summary>Получить значение параметра</summary>
    /// <param name="parameter">Параметр</param>
    /// <returns></returns>
    public static object GetParameterLogValue(this IDataParameter parameter)
    {
      int num = 3;
      byte[] numArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (parameter.Value != DBNull.Value)
            {
              if (SqlQueryInfoExtension.wcuQSYEoQNbRCagvIYNo((object) parameter) is byte[])
              {
                num = 4;
                continue;
              }
              goto label_12;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
              continue;
            }
          case 3:
            if (parameter != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 2 : 2;
              continue;
            }
            goto label_8;
          case 4:
            numArray = (byte[]) SqlQueryInfoExtension.wcuQSYEoQNbRCagvIYNo((object) parameter);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 4 : 5;
            continue;
          case 5:
            goto label_11;
          default:
            goto label_8;
        }
      }
label_5:
      return SqlQueryInfoExtension.VognHlEofn2okxtWmDXp(--1333735954 ^ 1333605394);
label_8:
      return (object) string.Empty;
label_11:
      return SqlQueryInfoExtension.OMDeI5EoCOGv19gqW0ps((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319201670), numArray != null ? SqlQueryInfoExtension.OMDeI5EoCOGv19gqW0ps(SqlQueryInfoExtension.VognHlEofn2okxtWmDXp(-1638402543 ^ -1638670899), (object) numArray.Length) : (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239830598));
label_12:
      return SqlQueryInfoExtension.wcuQSYEoQNbRCagvIYNo((object) parameter);
    }

    internal static object VognHlEofn2okxtWmDXp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object wcuQSYEoQNbRCagvIYNo([In] object obj0) => ((IDataParameter) obj0).Value;

    internal static object OMDeI5EoCOGv19gqW0ps([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static bool dcngnDEoGvHMyX59BCbS() => SqlQueryInfoExtension.n4pW2ZEohgwN8YlRLuLs == null;

    internal static SqlQueryInfoExtension dDsvRLEoEYv0tBSfmXyg() => SqlQueryInfoExtension.n4pW2ZEohgwN8YlRLuLs;
  }
}
