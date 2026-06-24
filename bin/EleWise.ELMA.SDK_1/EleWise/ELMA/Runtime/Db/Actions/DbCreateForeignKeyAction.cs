// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Actions.DbCreateForeignKeyAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Actions
{
  /// <summary>Действие создания внешнего ключа</summary>
  public class DbCreateForeignKeyAction : DbAction
  {
    private ForeignKey foreignKey;
    private static DbCreateForeignKeyAction YW98VeWKpXYYaXZNNI0R;

    /// <summary>Создание действия</summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    /// <param name="foreignKey">Внешний ключ</param>
    public DbCreateForeignKeyAction(ITransformationProvider transform, ForeignKey foreignKey)
    {
      DbCreateForeignKeyAction.WKkvkDWKtSt6VaNmx40S();
      // ISSUE: explicit constructor call
      base.\u002Ector(transform);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.foreignKey = foreignKey;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Создание внешнего ключа</summary>
    public override void Execute()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            DbCreateForeignKeyAction.vFT35xWKAfmV8tnL9wdV((object) this.Transform, (object) this.ForeignKey);
            num = 2;
            continue;
          case 2:
            goto label_10;
          case 3:
            if (DbCreateForeignKeyAction.X6abiuWKwElBYmgvnWpa((object) this.LogMessage))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 4:
            base.Execute();
            num = 3;
            continue;
          case 5:
            this.WriteLogMessage();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
            continue;
          default:
            object t = DbCreateForeignKeyAction.BdOGdhWK4J6qXL0VxWVN(-281842504 ^ -281896618);
            object[] objArray = new object[5]
            {
              DbCreateForeignKeyAction.GMFdbWWK6IVv8VvIGPfx((object) this.ForeignKey),
              DbCreateForeignKeyAction.AQ7y7VWKHmu3QIBQ4VSg((object) this.ForeignKey),
              null,
              null,
              null
            };
            string str;
            if (this.ForeignKey.Columns == null)
            {
              str = "";
            }
            else
            {
              object separator = DbCreateForeignKeyAction.BdOGdhWK4J6qXL0VxWVN(272623989 ^ 272612229);
              List<string> columns = this.ForeignKey.Columns;
              // ISSUE: reference to a compiler-generated field
              Func<string, string> func = DbCreateForeignKeyAction.\u003C\u003Ec.\u003C\u003E9__1_0;
              Func<string, string> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                DbCreateForeignKeyAction.\u003C\u003Ec.\u003C\u003E9__1_0 = selector = (Func<string, string>) (c => (string) DbCreateForeignKeyAction.\u003C\u003Ec.xfE0uDQw4DXdoVhSnnky(DbCreateForeignKeyAction.\u003C\u003Ec.URxg0SQwwQ6P65UsYwpw(322893104 - -1992822529 ^ -1979246231), (object) c, DbCreateForeignKeyAction.\u003C\u003Ec.URxg0SQwwQ6P65UsYwpw(-606654180 ^ -606655420)));
              }
              else
                goto label_14;
label_12:
              IEnumerable<string> values = columns.Select<string, string>(selector);
              str = string.Join((string) separator, values);
              goto label_13;
label_14:
              selector = func;
              goto label_12;
            }
label_13:
            objArray[2] = (object) str;
            objArray[3] = (object) this.ForeignKey.RefTableName;
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            objArray[4] = this.ForeignKey.RefColumns != null ? (object) string.Join((string) DbCreateForeignKeyAction.BdOGdhWK4J6qXL0VxWVN(-1598106783 - -968262081 ^ -629864494), this.ForeignKey.RefColumns.Select<string, string>((Func<string, string>) (c => (string) DbCreateForeignKeyAction.\u003C\u003Ec.xfE0uDQw4DXdoVhSnnky((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1405836051), (object) c, DbCreateForeignKeyAction.\u003C\u003Ec.URxg0SQwwQ6P65UsYwpw(1033719030 - 2012070891 ^ -978348973))))) : (object) "";
            this.LogMessage = EleWise.ELMA.SR.T((string) t, objArray);
            num = 5;
            continue;
        }
      }
label_10:;
    }

    /// <summary>Внешний ключ</summary>
    public ForeignKey ForeignKey => this.foreignKey;

    internal static void WKkvkDWKtSt6VaNmx40S() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Wlt7IUWKaHUnqw7hVPDB() => DbCreateForeignKeyAction.YW98VeWKpXYYaXZNNI0R == null;

    internal static DbCreateForeignKeyAction sYH5CeWKDw5oBUsZIaVQ() => DbCreateForeignKeyAction.YW98VeWKpXYYaXZNNI0R;

    internal static bool X6abiuWKwElBYmgvnWpa([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object BdOGdhWK4J6qXL0VxWVN(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object GMFdbWWK6IVv8VvIGPfx([In] object obj0) => (object) ((ForeignKey) obj0).Name;

    internal static object AQ7y7VWKHmu3QIBQ4VSg([In] object obj0) => (object) ((ForeignKey) obj0).TableName;

    internal static void vFT35xWKAfmV8tnL9wdV([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).AddForeignKey((ForeignKey) obj1);
  }
}
