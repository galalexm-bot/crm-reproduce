// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.Actions.NewPropertyAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Db.Actions
{
  /// <summary>Действие при добавлении нового свойства сущности</summary>
  public class NewPropertyAction : EntityPropertyAction
  {
    private static NewPropertyAction s9vW6GoESLyvL5suY54f;

    /// <summary>Создать действие</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства сущности</param>
    public NewPropertyAction(
      IDbModelUpdater updater,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata)
    {
      NewPropertyAction.gi5CSvoEqWCaFCpFYeas();
      // ISSUE: explicit constructor call
      base.\u002Ector(updater, metadata, propertyMetadata);
      int num1 = 6;
      List<Table>.Enumerator enumerator1;
      List<ForeignKey>.Enumerator enumerator2;
      TypeDbStructures propertyDbStructures;
      List<Column>.Enumerator enumerator3;
      List<Tuple<string, object>>.Enumerator enumerator4;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_64;
          case 2:
label_38:
            enumerator2 = propertyDbStructures.ForeignKeys.GetEnumerator();
            num1 = 9;
            continue;
          case 3:
            goto label_53;
          case 4:
            try
            {
label_17:
              if (enumerator1.MoveNext())
                goto label_15;
              else
                goto label_18;
label_3:
              IEnumerator<IDbCreateTableActionExtender> enumerator5;
              Table current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    this.Updater.TablesCreatedActions.Add((IDbAction) new DbCreateTableAction(this.Transform, current));
                    num2 = 3;
                    continue;
                  case 2:
                    goto label_15;
                  case 3:
                    enumerator5 = ((ComponentManager) NewPropertyAction.OID8mNoEnls6OwaO6qbB()).GetExtensionPoints<IDbCreateTableActionExtender>().GetEnumerator();
                    num2 = 5;
                    continue;
                  case 4:
                    goto label_17;
                  case 5:
                    goto label_4;
                  default:
                    goto label_38;
                }
              }
label_4:
              try
              {
label_6:
                if (NewPropertyAction.S4mE2ToE24YlP0XgHmOQ((object) enumerator5))
                  goto label_8;
                else
                  goto label_7;
label_5:
                int num3;
                switch (num3)
                {
                  case 1:
                    goto label_17;
                  case 2:
                    goto label_6;
                  default:
                    goto label_8;
                }
label_7:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 1;
                goto label_5;
label_8:
                NewPropertyAction.V686sloEOwJVx9FLJcdt((object) enumerator5.Current, (object) this.Updater, (object) this.Transform, (object) current);
                num3 = 2;
                goto label_5;
              }
              finally
              {
                int num4;
                if (enumerator5 == null)
                  num4 = 2;
                else
                  goto label_12;
label_11:
                switch (num4)
                {
                  case 1:
                    break;
                  default:
                }
label_12:
                NewPropertyAction.yXukcfoEek1ptMb45ZrK((object) enumerator5);
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
                {
                  num4 = 0;
                  goto label_11;
                }
                else
                  goto label_11;
              }
label_15:
              current = enumerator1.Current;
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
              {
                num2 = 1;
                goto label_3;
              }
              else
                goto label_3;
label_18:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
              goto label_3;
            }
            finally
            {
              enumerator1.Dispose();
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
          case 5:
label_41:
            enumerator4 = propertyDbStructures.Updates.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 3 : 2;
            continue;
          case 6:
            if (string.IsNullOrEmpty((string) NewPropertyAction.vxgIZqoEKeUksKqKxxyn((object) this.Metadata)))
            {
              num1 = 7;
              continue;
            }
            propertyDbStructures = DbModelHelper.GetPropertyDbStructures(this.Metadata, propertyMetadata);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
            continue;
          case 7:
            goto label_66;
          case 8:
            try
            {
label_44:
              if (enumerator3.MoveNext())
                goto label_46;
              else
                goto label_45;
label_43:
              Column current;
              int num6;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    goto label_46;
                  case 2:
                    goto label_68;
                  case 3:
                    goto label_44;
                  default:
                    this.Updater.TablesCreatedActions.Add((IDbAction) new DbCreateColumnAction(this.Transform, this.Metadata.TableName, current));
                    num6 = 3;
                    continue;
                }
              }
label_45:
              num6 = 2;
              goto label_43;
label_46:
              current = enumerator3.Current;
              num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
              {
                num6 = 0;
                goto label_43;
              }
              else
                goto label_43;
            }
            finally
            {
              enumerator3.Dispose();
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
                num7 = 0;
              switch (num7)
              {
                default:
              }
            }
          case 9:
            try
            {
label_27:
              if (enumerator2.MoveNext())
                goto label_31;
              else
                goto label_28;
label_26:
              ForeignKey current;
              int num8;
              while (true)
              {
                switch (num8)
                {
                  case 1:
                    this.Updater.ForeignKeysCreatedActions.Add((IDbAction) new DbCreateForeignKeyAction(this.Transform, current));
                    num8 = 3;
                    continue;
                  case 2:
                    goto label_31;
                  case 3:
                    goto label_27;
                  case 4:
                    goto label_41;
                  default:
                    NewPropertyAction.hCA68EoENwZK19EJbBDW((object) current, NewPropertyAction.txYhcToE1Z17njxrLXX6((object) this.Updater, NewPropertyAction.e0570IoEPcdki26L1Yir((object) current), (object) current.Columns[0]));
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
                    continue;
                }
              }
label_28:
              num8 = 4;
              goto label_26;
label_31:
              current = enumerator2.Current;
              num8 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
              {
                num8 = 0;
                goto label_26;
              }
              else
                goto label_26;
            }
            finally
            {
              enumerator2.Dispose();
              int num9 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
                num9 = 0;
              switch (num9)
              {
                default:
              }
            }
          case 10:
label_68:
            enumerator1 = propertyDbStructures.Tables.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 4 : 3;
            continue;
          default:
            enumerator3 = propertyDbStructures.Columns.GetEnumerator();
            num1 = 8;
            continue;
        }
      }
label_64:
      return;
label_53:
      try
      {
label_55:
        if (enumerator4.MoveNext())
          goto label_58;
        else
          goto label_56;
label_54:
        Tuple<string, object> current;
        int num10;
        while (true)
        {
          switch (num10)
          {
            case 1:
              this.Updater.TablesDeletedActions.Add((IDbAction) new DbUpdateAction(this.Transform, (string) NewPropertyAction.vxgIZqoEKeUksKqKxxyn((object) this.Metadata), new string[1]
              {
                current.Item1
              }, new object[1]{ current.Item2 }));
              num10 = 3;
              continue;
            case 2:
              goto label_60;
            case 3:
              goto label_55;
            default:
              goto label_58;
          }
        }
label_60:
        return;
label_56:
        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 2;
        goto label_54;
label_58:
        current = enumerator4.Current;
        num10 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
        {
          num10 = 0;
          goto label_54;
        }
        else
          goto label_54;
      }
      finally
      {
        enumerator4.Dispose();
        int num11 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
          num11 = 0;
        switch (num11)
        {
          default:
        }
      }
label_66:
      throw new DbModelException((string) NewPropertyAction.reamweoEkpYDsA6m9Pb9(NewPropertyAction.oy2xeCoETYlQ0vHrChxG(NewPropertyAction.yRtoosoEXfmrQo9KS3ji(864270449 << 6 ^ -521384058)), (object) this.Metadata.FullTypeName));
    }

    internal static void gi5CSvoEqWCaFCpFYeas() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object vxgIZqoEKeUksKqKxxyn([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static object yRtoosoEXfmrQo9KS3ji(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object oy2xeCoETYlQ0vHrChxG([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object reamweoEkpYDsA6m9Pb9([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object OID8mNoEnls6OwaO6qbB() => (object) ComponentManager.Current;

    internal static void V686sloEOwJVx9FLJcdt([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((IDbCreateTableActionExtender) obj0).Extend((IDbModelUpdater) obj1, (ITransformationProvider) obj2, (Table) obj3);

    internal static bool S4mE2ToE24YlP0XgHmOQ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void yXukcfoEek1ptMb45ZrK([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object e0570IoEPcdki26L1Yir([In] object obj0) => (object) ((ForeignKey) obj0).TableName;

    internal static object txYhcToE1Z17njxrLXX6([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IDbModelUpdater) obj0).GenerateForeignKeyName((string) obj1, (string) obj2);

    internal static void hCA68EoENwZK19EJbBDW([In] object obj0, [In] object obj1) => ((ForeignKey) obj0).Name = (string) obj1;

    internal static bool itPw6goEiDtjwyFQAweA() => NewPropertyAction.s9vW6GoESLyvL5suY54f == null;

    internal static NewPropertyAction mqNxWSoERCKwC9i8GbvQ() => NewPropertyAction.s9vW6GoESLyvL5suY54f;
  }
}
