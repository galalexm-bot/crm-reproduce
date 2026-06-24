// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Actions.DbCreateUniqueIndexAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Actions
{
  /// <summary>Действие создания уникального индекса ключа</summary>
  public class DbCreateUniqueIndexAction : DbAction
  {
    private Index index;
    internal static DbCreateUniqueIndexAction g0h92HWqukZ54eYkprGU;

    /// <summary>Создание действия</summary>
    /// <param name="transform">Провайдер преобразования БД</param>
    /// <param name="index">Уникальный индекс</param>
    public DbCreateUniqueIndexAction(ITransformationProvider transform, Index index)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(transform);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.index = index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override void Execute()
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Transform.AddUniqueIndex(this.Index);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 5 : 6;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            this.LogMessage = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957795500), DbCreateUniqueIndexAction.RbLWVDWqiLMyqtBIjUUo((object) this.Index), DbCreateUniqueIndexAction.BAK5tUWqRGikHbHiXgKe((object) this.Index), (object) string.Join((string) DbCreateUniqueIndexAction.XAhDdJWqqp3TWUFlseu3(1142330761 ^ 1541959139 ^ 536783514), this.Index.Columns.Select<string, string>((Func<string, string>) (c => (string) DbCreateUniqueIndexAction.\u003C\u003Ec.OptCX1Qw2UbiiD2GiCwN(DbCreateUniqueIndexAction.\u003C\u003Ec.EAE2hSQwOO0SEDG71uCq(1253244298 - 1829393894 ^ -576144644), (object) c, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951511874))))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 4:
            if (!DbCreateUniqueIndexAction.HqyWcdWqSbx7R65IjT1g((object) this.LogMessage))
            {
              num = 2;
              continue;
            }
            goto case 3;
          case 5:
            base.Execute();
            num = 4;
            continue;
          case 6:
            goto label_7;
          default:
            this.WriteLogMessage();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 0;
            continue;
        }
      }
label_7:;
    }

    /// <summary>Уникальный индекс</summary>
    public Index Index => this.index;

    internal static bool VvgRSFWqIHXw8cNhBvCh() => DbCreateUniqueIndexAction.g0h92HWqukZ54eYkprGU == null;

    internal static DbCreateUniqueIndexAction vN3OsdWqVC6A29YbxVWQ() => DbCreateUniqueIndexAction.g0h92HWqukZ54eYkprGU;

    internal static bool HqyWcdWqSbx7R65IjT1g([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object RbLWVDWqiLMyqtBIjUUo([In] object obj0) => (object) ((Index) obj0).Name;

    internal static object BAK5tUWqRGikHbHiXgKe([In] object obj0) => (object) ((Index) obj0).TableName;

    internal static object XAhDdJWqqp3TWUFlseu3(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
