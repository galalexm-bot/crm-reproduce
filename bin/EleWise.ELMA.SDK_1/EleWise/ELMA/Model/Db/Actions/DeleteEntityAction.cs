// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.Actions.DeleteEntityAction
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
  /// <summary>Действие при удалении сущности</summary>
  public class DeleteEntityAction : EntityAction
  {
    internal static DeleteEntityAction wfcN5YohStMGvb7O1W62;

    /// <summary>Создать действие</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="metadata">Метаданные сущности</param>
    public DeleteEntityAction(IDbModelUpdater updater, EntityMetadata metadata)
    {
      DeleteEntityAction.vFAQsjohqQLvcHvgf1eU();
      // ISSUE: explicit constructor call
      base.\u002Ector(updater, metadata);
      int num1 = 3;
      List<PropertyMetadata>.Enumerator enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_2:
            updater.TablesDeletedActions.Add((IDbAction) new DbDeleteTableAction(this.Transform, (string) DeleteEntityAction.OMD0BAohORwGtvlXvUlC((object) this.Metadata)));
            num1 = 4;
            continue;
          case 2:
            try
            {
label_18:
              if (enumerator1.MoveNext())
                goto label_16;
              else
                goto label_19;
label_4:
              List<Table>.Enumerator enumerator2;
              EntityPropertyMetadata current1;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_16;
                  case 2:
                    goto label_18;
                  case 3:
                    goto label_2;
                  case 4:
                    goto label_5;
                  default:
                    enumerator2 = ((TypeDbStructures) DeleteEntityAction.INv8ZwohkaSOKvThDOBW((object) this.Metadata, (object) current1)).Tables.GetEnumerator();
                    num2 = 4;
                    continue;
                }
              }
label_5:
              try
              {
label_10:
                if (enumerator2.MoveNext())
                  goto label_7;
                else
                  goto label_11;
label_6:
                Table current2;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      updater.TablesDeletedActions.Add((IDbAction) new DbDeleteTableAction(this.Transform, (string) DeleteEntityAction.imTuBXohn1dUSDFlhwTY((object) current2)));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_7;
                    case 3:
                      goto label_18;
                    default:
                      goto label_10;
                  }
                }
label_7:
                current2 = enumerator2.Current;
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
                {
                  num3 = 1;
                  goto label_6;
                }
                else
                  goto label_6;
label_11:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 3 : 2;
                goto label_6;
              }
              finally
              {
                enumerator2.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
label_16:
              current1 = (EntityPropertyMetadata) enumerator1.Current;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
              {
                num2 = 0;
                goto label_4;
              }
              else
                goto label_4;
label_19:
              num2 = 3;
              goto label_4;
            }
            finally
            {
              enumerator1.Dispose();
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
          case 3:
            if (!DeleteEntityAction.UTr1RvohKolOJLWFfciH((object) this.Metadata.TableName))
            {
              enumerator1 = metadata.Properties.GetEnumerator();
              num1 = 2;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_24;
          default:
            goto label_26;
        }
      }
label_24:
      return;
label_26:
      throw new DbModelException((string) DeleteEntityAction.KxB786ohTNSUpOyXAC7B(DeleteEntityAction.uk1HuIohXODubiWS18cW((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993327311)), (object) this.Metadata.FullTypeName));
    }

    /// <summary>Выполнить дейсвтие</summary>
    public override void Execute() => base.Execute();

    internal static void vFAQsjohqQLvcHvgf1eU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool UTr1RvohKolOJLWFfciH([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object uk1HuIohXODubiWS18cW([In] object obj0) => (object) SR.T((string) obj0);

    internal static object KxB786ohTNSUpOyXAC7B([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object INv8ZwohkaSOKvThDOBW([In] object obj0, [In] object obj1) => (object) DbModelHelper.GetPropertyDbStructures((EntityMetadata) obj0, (EntityPropertyMetadata) obj1);

    internal static object imTuBXohn1dUSDFlhwTY([In] object obj0) => (object) ((Table) obj0).Name;

    internal static object OMD0BAohORwGtvlXvUlC([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static bool rjPh2TohiMHxThXNHPKf() => DeleteEntityAction.wfcN5YohStMGvb7O1W62 == null;

    internal static DeleteEntityAction auLiYuohRQLaqjadxkU7() => DeleteEntityAction.wfcN5YohStMGvb7O1W62;
  }
}
