// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Actions.DbUpdateIsGroupColumnAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.ExtensionPoints;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Db.Actions
{
  public class DbUpdateIsGroupColumnAction : DbAction
  {
    private string tableName;
    private string isGroupColumnName;
    private string parentColumnName;
    private static DbUpdateIsGroupColumnAction AcXmpFWqKYro2WwH9OgF;

    public DbUpdateIsGroupColumnAction(
      ITransformationProvider transform,
      string tableName,
      string isGroupColumnName,
      string parentColumnName)
    {
      DbUpdateIsGroupColumnAction.LC5yU8WqkaimTLsPJva3();
      // ISSUE: explicit constructor call
      base.\u002Ector(transform);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.isGroupColumnName = isGroupColumnName;
            num = 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.parentColumnName = parentColumnName;
            num = 2;
            continue;
          default:
            this.tableName = tableName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public override void Execute()
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        IEnumerable<IUpdateIsGroupColumnExtension> extensionPoints;
        IUpdateIsGroupColumnExtension groupColumnExtension;
        IRuntimeApplication service;
        IMainDatabaseProvider provider;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_20;
            case 3:
              if (service.MainProvider == null)
              {
                num2 = 2;
                continue;
              }
              goto case 1;
            case 4:
              if (extensionPoints != null)
              {
                num2 = 7;
                continue;
              }
              goto label_9;
            case 5:
              if (service != null)
              {
                num2 = 3;
                continue;
              }
              goto label_21;
            case 6:
              service = Locator.GetService<IRuntimeApplication>();
              num2 = 5;
              continue;
            case 7:
              goto label_4;
            case 8:
              extensionPoints = ((ComponentManager) DbUpdateIsGroupColumnAction.sB4FFKWqnvhAPrhjKerl()).GetExtensionPoints<IUpdateIsGroupColumnExtension>();
              num2 = 4;
              continue;
            case 9:
              goto label_22;
            case 10:
              DbUpdateIsGroupColumnAction.ivdcMYWqOdybBXt50N5i((object) groupColumnExtension, (object) this.tableName, (object) this.isGroupColumnName, (object) this.parentColumnName);
              num2 = 12;
              continue;
            case 11:
              goto label_11;
            case 12:
              goto label_8;
            default:
              provider = service.MainProvider;
              num2 = 8;
              continue;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        groupColumnExtension = extensionPoints.FirstOrDefault<IUpdateIsGroupColumnExtension>((Func<IUpdateIsGroupColumnExtension, bool>) (k => DbUpdateIsGroupColumnAction.\u003C\u003Ec__DisplayClass1_0.iJnGJ4Qw316bdpi755PQ(k.ProviderUid, DbUpdateIsGroupColumnAction.\u003C\u003Ec__DisplayClass1_0.BSRL1nQwNLMRutOcwx6u((object) provider))));
        num1 = 11;
        continue;
label_9:
        DbUpdateIsGroupColumnAction.AMcWSGWqeW900jDvB8vX((object) Logger.Log, (object) EleWise.ELMA.SR.T((string) DbUpdateIsGroupColumnAction.zKlLChWq23wY3hM4UIfV(87862435 ^ 87907797), DbUpdateIsGroupColumnAction.zKlLChWq23wY3hM4UIfV(44884861 ^ 44896925)));
        num1 = 9;
        continue;
label_11:
        if (groupColumnExtension != null)
          num1 = 10;
        else
          goto label_3;
      }
label_20:
      return;
label_22:
      return;
label_8:
      return;
label_3:
      return;
label_21:;
    }

    internal static void LC5yU8WqkaimTLsPJva3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JwUhVUWqX1fh53RK4AtV() => DbUpdateIsGroupColumnAction.AcXmpFWqKYro2WwH9OgF == null;

    internal static DbUpdateIsGroupColumnAction VTq8m0WqTmvQkeJC11Pr() => DbUpdateIsGroupColumnAction.AcXmpFWqKYro2WwH9OgF;

    internal static object sB4FFKWqnvhAPrhjKerl() => (object) ComponentManager.Current;

    internal static void ivdcMYWqOdybBXt50N5i([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((IUpdateIsGroupColumnExtension) obj0).Execute((string) obj1, (string) obj2, (string) obj3);

    internal static object zKlLChWq23wY3hM4UIfV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void AMcWSGWqeW900jDvB8vX([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);
  }
}
