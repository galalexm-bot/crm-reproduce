// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.ReferenceOnEntityTypeDecription
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Ссылка на тип объекта"</summary>
  public class ReferenceOnEntityTypeDecription : 
    CLRTypeDescriptor<ReferenceOnEntityType, ReferenceOnEntityTypeSettings>,
    IMappingTypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{2DF8E9CA-3AC4-4BA5-832F-18F6374397E7}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    /// <summary>Uid типа объектов (для использования в FilterModel)</summary>
    public const string TypeUid_UID_S = "{D030EE61-94FB-401E-81FF-7171C34BBBEE}";
    /// <summary>Uid типа объектов (для использования в FilterModel)</summary>
    public static readonly Guid TypeUid_UID;
    private static ReferenceOnEntityTypeDecription ojMhafoHowAfGRQCLxhH;

    /// <inheritdoc />
    protected override void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            mapper.Type<ReferenceOnEntityTypeNHType>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          case 2:
            ReferenceOnEntityTypeDecription.xKcfeToHGIFWMWXDM3Qx((object) this, (object) mapper, (object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Uid типа</summary>
    public override Guid Uid => ReferenceOnEntityTypeDecription.UID;

    /// <summary>Имя "Ссылка на тип объекта"</summary>
    public override string Name => (string) ReferenceOnEntityTypeDecription.kN9vxtoHfOmo1Wx9b4ob(ReferenceOnEntityTypeDecription.iZ1WJXoHEqRs0NRmHh68(-542721635 ^ -542885493));

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Guid);
    }

    public ReferenceOnEntityTypeDecription()
    {
      ReferenceOnEntityTypeDecription.oUHI25oHQqHgZHJMohIv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ReferenceOnEntityTypeDecription()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            ReferenceOnEntityTypeDecription.UID = new Guid((string) ReferenceOnEntityTypeDecription.iZ1WJXoHEqRs0NRmHh68(-218496594 ^ -218594838));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 3:
            ReferenceOnEntityTypeDecription.oUHI25oHQqHgZHJMohIv();
            num = 2;
            continue;
          default:
            ReferenceOnEntityTypeDecription.TypeUid_UID = new Guid((string) ReferenceOnEntityTypeDecription.iZ1WJXoHEqRs0NRmHh68(-710283084 ^ -537863435 ^ 173779669));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static void xKcfeToHGIFWMWXDM3Qx([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SimpleTypeDescriptor<ReferenceOnEntityType>) obj0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper) obj1, (EntityPropertyMetadata) obj2));

    internal static bool tSXd5woHbIHKyeXeUYGy() => ReferenceOnEntityTypeDecription.ojMhafoHowAfGRQCLxhH == null;

    internal static ReferenceOnEntityTypeDecription TAasB9oHh8UwsJ4CfyTL() => ReferenceOnEntityTypeDecription.ojMhafoHowAfGRQCLxhH;

    internal static object iZ1WJXoHEqRs0NRmHh68(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object kN9vxtoHfOmo1Wx9b4ob([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void oUHI25oHQqHgZHJMohIv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
