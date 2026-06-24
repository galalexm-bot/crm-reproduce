// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.Actions.ChangeEntityAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Db.Actions
{
  /// <summary>Действие при изменении сущности</summary>
  public class ChangeEntityAction : EntityAction
  {
    private EntityMetadata oldMetadata;
    internal static ChangeEntityAction ITeaxsohzkq1F3OposBs;

    /// <summary>Создать действие</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="oldMetadata">Старые метаданные сущности</param>
    public ChangeEntityAction(
      IDbModelUpdater updater,
      EntityMetadata metadata,
      EntityMetadata oldMetadata)
    {
      ChangeEntityAction.k6SGMnoGWJ0ktERjnmO4();
      // ISSUE: explicit constructor call
      base.\u002Ector(updater, metadata);
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!string.IsNullOrEmpty((string) ChangeEntityAction.lxpPjaoGh7rD5GQk0vEj((object) this.Metadata)))
            {
              num = 4;
              continue;
            }
            goto label_7;
          case 2:
            this.Updater.TablesCreatedActions.Add((IDbAction) new DbRenameTableAction((ITransformationProvider) ChangeEntityAction.UYjvbAoGQUXCrLedFwQY((object) updater), (string) ChangeEntityAction.lxpPjaoGh7rD5GQk0vEj((object) oldMetadata), (string) ChangeEntityAction.lxpPjaoGh7rD5GQk0vEj((object) metadata)));
            num = 6;
            continue;
          case 3:
            goto label_7;
          case 4:
            if (ChangeEntityAction.HrvsKRoGfX2S5Y4hY5Tm(ChangeEntityAction.lxpPjaoGh7rD5GQk0vEj((object) oldMetadata), ChangeEntityAction.lxpPjaoGh7rD5GQk0vEj((object) metadata)))
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 5:
            ChangeEntityAction.Wg0II1oGb2BkuXV50R6h((object) oldMetadata, ChangeEntityAction.NACpZLoGoP0dRK14up8o(1654249598 >> 2 ^ 413410247));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
            continue;
          case 6:
            goto label_10;
          default:
            this.oldMetadata = oldMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
            continue;
        }
      }
label_10:
      return;
label_7:
      throw new DbModelException((string) ChangeEntityAction.gmohSRoGEKuMlvFjoYTF(ChangeEntityAction.c5vcnHoGGHNdqegLAOkT(ChangeEntityAction.NACpZLoGoP0dRK14up8o(-787452571 ^ -787333469)), (object) this.Metadata.FullTypeName));
label_2:;
    }

    /// <summary>Выполнить дейсвтие</summary>
    public override void Execute() => base.Execute();

    internal static void k6SGMnoGWJ0ktERjnmO4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object NACpZLoGoP0dRK14up8o(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void Wg0II1oGb2BkuXV50R6h([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object lxpPjaoGh7rD5GQk0vEj([In] object obj0) => (object) ((EntityMetadata) obj0).TableName;

    internal static object c5vcnHoGGHNdqegLAOkT([In] object obj0) => (object) SR.T((string) obj0);

    internal static object gmohSRoGEKuMlvFjoYTF([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static bool HrvsKRoGfX2S5Y4hY5Tm([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object UYjvbAoGQUXCrLedFwQY([In] object obj0) => (object) ((IDbModelUpdater) obj0).Transform;

    internal static bool Rs5QN8oGFmWvifPQiPDG() => ChangeEntityAction.ITeaxsohzkq1F3OposBs == null;

    internal static ChangeEntityAction DZweZ4oGBnHVXdQhjDvm() => ChangeEntityAction.ITeaxsohzkq1F3OposBs;
  }
}
