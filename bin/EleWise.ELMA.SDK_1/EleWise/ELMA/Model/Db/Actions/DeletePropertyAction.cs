// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.Actions.DeletePropertyAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Db.Actions
{
  /// <summary>Действие по удалению свойства сущности</summary>
  public class DeletePropertyAction : EntityPropertyAction
  {
    private static DeletePropertyAction Po4DGfoGI3nbBdAj9TOL;

    /// <summary>Создать действие</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства сущности</param>
    /// <param name="startTableActionsIndex">Индекс в списке TablesCreatedActions, в который нужно вставлять действие по переименованию колонки</param>
    public DeletePropertyAction(
      IDbModelUpdater updater,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      ref int startTableActionsIndex)
    {
      DeletePropertyAction.L4yxaXoGiUr1ECyNxDvb();
      // ISSUE: explicit constructor call
      base.\u002Ector(updater, metadata, propertyMetadata);
      int num1 = 5;
      List<Table>.Enumerator enumerator1;
      while (true)
      {
        TypeDbStructures typeDbStructures;
        List<Column>.Enumerator enumerator2;
        switch (num1)
        {
          case 1:
            goto label_29;
          case 2:
            goto label_2;
          case 3:
            goto label_19;
          case 4:
            try
            {
label_8:
              if (enumerator2.MoveNext())
                goto label_12;
              else
                goto label_9;
label_6:
              Column current;
              string str;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    str = (string) DeletePropertyAction.t9cVtSoGOpeYmH9kjAXp((object) this.Updater, DeletePropertyAction.BHiDWFoGRxIgjuIdqgGe((object) metadata), DeletePropertyAction.qcskU3oGn97Ot4Hg1GWO((object) current));
                    num2 = 2;
                    continue;
                  case 2:
                    this.Updater.TablesCreatedActions.Insert(startTableActionsIndex, (IDbAction) new DbRenameColumnAction(this.Transform, (string) DeletePropertyAction.BHiDWFoGRxIgjuIdqgGe((object) this.Metadata), (string) DeletePropertyAction.qcskU3oGn97Ot4Hg1GWO((object) current), str));
                    num2 = 3;
                    continue;
                  case 3:
                    ++startTableActionsIndex;
                    num2 = 4;
                    continue;
                  case 4:
                    this.Updater.TablesDeletedActions.Add((IDbAction) new DbDeleteColumnAction(this.Transform, (string) DeletePropertyAction.BHiDWFoGRxIgjuIdqgGe((object) this.Metadata), str));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 5 : 5;
                    continue;
                  case 5:
                    goto label_8;
                  case 6:
                    goto label_12;
                  default:
                    goto label_4;
                }
              }
label_9:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
              goto label_6;
label_12:
              current = enumerator2.Current;
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
              {
                num2 = 1;
                goto label_6;
              }
              else
                goto label_6;
            }
            finally
            {
              enumerator2.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 5:
            if (!DeletePropertyAction.CcpVZYoGqDqtkv1k7UJh(DeletePropertyAction.BHiDWFoGRxIgjuIdqgGe((object) this.Metadata)))
            {
              typeDbStructures = (TypeDbStructures) DeletePropertyAction.kUddWioGkDCH6gOsUiMv((object) this.Metadata, (object) propertyMetadata);
              num1 = 6;
              continue;
            }
            num1 = 2;
            continue;
          case 6:
            enumerator2 = typeDbStructures.Columns.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 4 : 3;
            continue;
        }
label_4:
        enumerator1 = typeDbStructures.Tables.GetEnumerator();
        num1 = 3;
      }
label_29:
      return;
label_2:
      throw new DbModelException(string.Format((string) DeletePropertyAction.lebCKKoGXJsmHXNOFDK8(DeletePropertyAction.FNq1ZhoGKHjYlSRQwjOj(1461625753 ^ 1461514335)), DeletePropertyAction.nyodAaoGTXlUPtZi8a0I((object) this.Metadata)));
label_19:
      try
      {
label_23:
        if (enumerator1.MoveNext())
          goto label_21;
        else
          goto label_24;
label_20:
        Table current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_23;
            case 2:
              this.Updater.TablesDeletedActions.Add((IDbAction) new DbDeleteTableAction(this.Transform, (string) DeletePropertyAction.evX7EYoG28o3t5AUk6EQ((object) current)));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_25;
            default:
              goto label_21;
          }
        }
label_25:
        return;
label_21:
        current = enumerator1.Current;
        num4 = 2;
        goto label_20;
label_24:
        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 3;
        goto label_20;
      }
      finally
      {
        enumerator1.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    internal static void L4yxaXoGiUr1ECyNxDvb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object BHiDWFoGRxIgjuIdqgGe([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static bool CcpVZYoGqDqtkv1k7UJh([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object FNq1ZhoGKHjYlSRQwjOj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object lebCKKoGXJsmHXNOFDK8([In] object obj0) => (object) SR.T((string) obj0);

    internal static object nyodAaoGTXlUPtZi8a0I([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static object kUddWioGkDCH6gOsUiMv([In] object obj0, [In] object obj1) => (object) DbModelHelper.GetPropertyDbStructures((EntityMetadata) obj0, (EntityPropertyMetadata) obj1);

    internal static object qcskU3oGn97Ot4Hg1GWO([In] object obj0) => (object) ((Column) obj0).Name;

    internal static object t9cVtSoGOpeYmH9kjAXp([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IDbModelUpdater) obj0).GenerateDeletingColumnTemporaryName((string) obj1, (string) obj2);

    internal static object evX7EYoG28o3t5AUk6EQ([In] object obj0) => (object) ((Table) obj0).Name;

    internal static bool vPTsfSoGVnuQcu5nM8TR() => DeletePropertyAction.Po4DGfoGI3nbBdAj9TOL == null;

    internal static DeletePropertyAction MPoSLxoGS2hxRM0UmwRK() => DeletePropertyAction.Po4DGfoGI3nbBdAj9TOL;
  }
}
