// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.TableViewsTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Тип "Настройки табличных представлений"</summary>
  public class TableViewsTypeDescriptor : 
    CLRTypeDescriptor<List<TableView>, TableViewsTypeSettings>,
    IMappingTypeDescriptor
  {
    public const string UID_S = "{C039DA91-30DE-4681-84D0-842C17D54BD6}";
    public static readonly Guid UID;
    internal static TableViewsTypeDescriptor dQY01OoHghnXAVw9TerI;

    /// <inheritdoc />
    protected override void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TableViewsTypeDescriptor.oHJWCJoHYhrnuNYsHVJs((object) this, (object) mapper, (object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            mapper.Type<TableViewsNHType>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Uid типа</summary>
    public override Guid Uid => TableViewsTypeDescriptor.UID;

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    public override bool Visible => false;

    /// <summary>Имя "Настройки табличных представлений"</summary>
    public override string Name => EleWise.ELMA.SR.T((string) TableViewsTypeDescriptor.w9JQcqoHLZmeeBmgUiWt(874012245 ^ 874175737));

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Binary);
    }

    public TableViewsTypeDescriptor()
    {
      TableViewsTypeDescriptor.irOOEKoHUW5wA0c36yMU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static TableViewsTypeDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TableViewsTypeDescriptor.irOOEKoHUW5wA0c36yMU();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            TableViewsTypeDescriptor.UID = new Guid((string) TableViewsTypeDescriptor.w9JQcqoHLZmeeBmgUiWt(-1317790512 ^ -1317626334));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static void oHJWCJoHYhrnuNYsHVJs([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SimpleTypeDescriptor<List<TableView>>) obj0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper) obj1, (EntityPropertyMetadata) obj2));

    internal static bool i8fJdSoH5XJOSS7mr6No() => TableViewsTypeDescriptor.dQY01OoHghnXAVw9TerI == null;

    internal static TableViewsTypeDescriptor eoprJqoHjs6IrDFc2Pog() => TableViewsTypeDescriptor.dQY01OoHghnXAVw9TerI;

    internal static object w9JQcqoHLZmeeBmgUiWt(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void irOOEKoHUW5wA0c36yMU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
