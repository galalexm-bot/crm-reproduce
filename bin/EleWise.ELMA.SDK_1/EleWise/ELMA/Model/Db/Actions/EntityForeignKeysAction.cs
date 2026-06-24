// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.Actions.EntityForeignKeysAction
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
  /// <summary>
  /// Действие по созданию внешних ключей для таблиц сущности
  /// </summary>
  public class EntityForeignKeysAction : EntityAction
  {
    private static EntityForeignKeysAction yxmoTuoGeKcvxv9iJUXB;

    /// <summary>Создать действие</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="metadata">Метаданные сущности</param>
    public EntityForeignKeysAction(IDbModelUpdater updater, EntityMetadata metadata)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(updater, metadata);
      int num1 = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num1 = 1;
      List<PropertyMetadata>.Enumerator enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_32;
          case 1:
            if (!EntityForeignKeysAction.RPM2KcoG38h1sHQDVXNC(EntityForeignKeysAction.E7wMNRoGNnyfTW6Y1pik((object) this.Metadata)))
            {
              enumerator1 = this.Metadata.Properties.GetEnumerator();
              num1 = 2;
              continue;
            }
            num1 = 3;
            continue;
          case 2:
            goto label_7;
          case 3:
            goto label_3;
          default:
            goto label_28;
        }
      }
label_32:
      return;
label_28:
      return;
label_3:
      throw new DbModelException((string) EntityForeignKeysAction.xforAJoGa3hvWyG6rypE(EntityForeignKeysAction.KHTLJwoGpDb77bFNQENk((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629733660)), (object) this.Metadata.FullTypeName));
label_7:
      try
      {
label_24:
        if (enumerator1.MoveNext())
          goto label_26;
        else
          goto label_25;
label_8:
        List<ForeignKey>.Enumerator enumerator2;
        EntityPropertyMetadata current1;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_21;
            case 1:
              goto label_24;
            case 2:
              goto label_9;
            case 3:
              enumerator2 = ((TypeDbStructures) EntityForeignKeysAction.dlh3HmoGDJFScU9LXe8X((object) this.Metadata, (object) current1)).ForeignKeys.GetEnumerator();
              num2 = 2;
              continue;
            case 4:
              goto label_26;
            default:
              goto label_17;
          }
        }
label_21:
        return;
label_17:
        return;
label_9:
        try
        {
label_14:
          if (enumerator2.MoveNext())
            goto label_11;
          else
            goto label_15;
label_10:
          ForeignKey current2;
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_14;
              case 2:
                goto label_11;
              case 3:
                this.Updater.ForeignKeysCreatedActions.Add((IDbAction) new DbCreateForeignKeyAction(this.Transform, current2));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
                continue;
              case 4:
                EntityForeignKeysAction.RAH64eoGw6gKoHThUgPQ((object) current2, EntityForeignKeysAction.tHTfQ5oGtTN9BDVNVKrt((object) this.Updater, (object) current2.TableName, (object) current2.Columns[0]));
                num3 = 3;
                continue;
              default:
                goto label_24;
            }
          }
label_11:
          current2 = enumerator2.Current;
          num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
          {
            num3 = 4;
            goto label_10;
          }
          else
            goto label_10;
label_15:
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
          goto label_10;
        }
        finally
        {
          enumerator2.Dispose();
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
            num4 = 0;
          switch (num4)
          {
            default:
          }
        }
label_25:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
        goto label_8;
label_26:
        current1 = (EntityPropertyMetadata) enumerator1.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
        {
          num2 = 3;
          goto label_8;
        }
        else
          goto label_8;
      }
      finally
      {
        enumerator1.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    internal static object E7wMNRoGNnyfTW6Y1pik([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static bool RPM2KcoG38h1sHQDVXNC([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object KHTLJwoGpDb77bFNQENk([In] object obj0) => (object) SR.T((string) obj0);

    internal static object xforAJoGa3hvWyG6rypE([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object dlh3HmoGDJFScU9LXe8X([In] object obj0, [In] object obj1) => (object) DbModelHelper.GetPropertyDbStructures((EntityMetadata) obj0, (EntityPropertyMetadata) obj1);

    internal static object tHTfQ5oGtTN9BDVNVKrt([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IDbModelUpdater) obj0).GenerateForeignKeyName((string) obj1, (string) obj2);

    internal static void RAH64eoGw6gKoHThUgPQ([In] object obj0, [In] object obj1) => ((ForeignKey) obj0).Name = (string) obj1;

    internal static bool gZKndDoGPMO8aph2P6Go() => EntityForeignKeysAction.yxmoTuoGeKcvxv9iJUXB == null;

    internal static EntityForeignKeysAction vZN4eUoG18UGCPTTq08f() => EntityForeignKeysAction.yxmoTuoGeKcvxv9iJUXB;
  }
}
