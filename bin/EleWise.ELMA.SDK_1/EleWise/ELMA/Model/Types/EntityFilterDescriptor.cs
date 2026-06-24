// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.EntityFilterDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Фильтр сущности</summary>
  public class EntityFilterDescriptor : CLRTypeDescriptor<IEntityFilter, EntityFilterSettings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{DCF11C25-895C-49BC-BF57-47C581AB7B54}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static EntityFilterDescriptor etYOb8oyjqnr5C1Fg4Be;

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>Идентификатор типа</summary>
    public override Guid Uid => EntityFilterDescriptor.UID;

    /// <summary>Название типа</summary>
    public override string Name => (string) EntityFilterDescriptor.vmx1KxoyUyljMrwomaHS((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146408171));

    public override bool Visible => false;

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
    {
      int num = 1;
      IEntityFilter entityFilter;
      while (true)
      {
        switch (num)
        {
          case 1:
            entityFilter = val as IEntityFilter;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (entityFilter == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 2 : 1;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return true;
label_6:
      return EntityFilterDescriptor.OjnDIOoysoAYhaPOsb5n((object) entityFilter);
    }

    /// <summary>Применить в критерий NHibernate условия</summary>
    /// <param name="criteria">Критерий</param>
    /// <param name="metadata"></param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="value">Значение фильтра</param>
    /// <param name="alias">Псевдоним</param>
    public override void ApplyFilterValue(
      ICriteria criteria,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      object value,
      string alias)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        FilterForAttribute filterForAttribute;
        IEntityManager entityManager;
        DetachedCriteria dc;
        IEntityFilter filter;
        string alias1;
        PropertyMetadata propertyMetadata1;
        EntitySettings entitySettings;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_35;
            case 1:
              EntityFilterDescriptor.zqF4E8oME4De09xlQGBl((object) dc, EntityFilterDescriptor.aQOGBeoMGpWwJdPbk1FK(EntityFilterDescriptor.O3rJgGoMh7wNQOXtWVtD((object) propertyMetadata1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 7 : 17;
              continue;
            case 2:
              if (!EntityFilterDescriptor.OjnDIOoysoAYhaPOsb5n((object) filter))
              {
                num2 = 5;
                continue;
              }
              goto label_13;
            case 3:
              alias1 = string.Format((string) EntityFilterDescriptor.gv4C5ioMBnLYWJOgEous(44884861 ^ 44987685), (object) propertyMetadata.Name);
              num2 = 12;
              continue;
            case 4:
              goto label_38;
            case 5:
              // ISSUE: type reference
              filterForAttribute = (FilterForAttribute) ((IEnumerable<object>) EntityFilterDescriptor.CcC42aoyzMfBpxHIOu8Q((object) filter.GetType(), EntityFilterDescriptor.UHUsDXoycscAkrW4cIsU(__typeref (FilterForAttribute)), true)).FirstOrDefault<object>();
              num2 = 23;
              continue;
            case 6:
              goto label_19;
            case 7:
              if (value != null)
              {
                filter = value as IEntityFilter;
                num2 = 18;
                continue;
              }
              num2 = 6;
              continue;
            case 8:
              if (propertyMetadata1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 3 : 19;
                continue;
              }
              goto label_43;
            case 9:
              goto label_14;
            case 10:
              goto label_9;
            case 11:
              if (entitySettings == null)
              {
                num2 = 9;
                continue;
              }
              if (entitySettings.RelationType != RelationType.OneToMany)
              {
                dc = DetachedCriteria.For(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(EntityFilterDescriptor.PbgRJyoMQBCONX8YkAJN((object) metadata)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 14 : 11;
                continue;
              }
              num2 = 20;
              continue;
            case 12:
              entitySettings = EntityFilterDescriptor.dRZcRZoMW3LFPJydCDvJ((object) propertyMetadata) as EntitySettings;
              num2 = 11;
              continue;
            case 13:
              criteria.Add((ICriterion) Subqueries.PropertyIn((string) EntityFilterDescriptor.gv4C5ioMBnLYWJOgEous(-1426456882 ^ 2009939514 ^ -583777878), dc));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 21 : 18;
              continue;
            case 14:
              entityManager.FilterDetachedCriteria((DetachedCriteria) EntityFilterDescriptor.AgiQKUoMChnoduHSXG8W((object) dc, (object) propertyMetadata.Name, (object) alias1, JoinType.InnerJoin), FetchOptions.All, EntityFilterDescriptor.SPh9XioMosjkPOaMp5mD((object) filterForAttribute), filter);
              num2 = 16;
              continue;
            case 15:
              if (entityManager != null)
              {
                num2 = 4;
                continue;
              }
              goto label_3;
            case 16:
              EntityFilterDescriptor.zqF4E8oME4De09xlQGBl((object) dc, EntityFilterDescriptor.j0XOQJoMviobM7OQp2VX());
              num2 = 13;
              continue;
            case 17:
              EntityFilterDescriptor.Gv5dDZoMfWLWKUJ2sX2B((object) criteria, (object) Subqueries.PropertyIn((string) EntityFilterDescriptor.gv4C5ioMBnLYWJOgEous(-1426456882 ^ 2009939514 ^ -583777878), dc));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 5 : 10;
              continue;
            case 18:
              if (filter == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 19:
              dc = entityManager.CreateDetachedCriteria((FetchOptions) EntityFilterDescriptor.d7c2TqoMbpr5JwdjPME5(), EntityFilterDescriptor.SPh9XioMosjkPOaMp5mD((object) filterForAttribute), alias1, filter);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 0;
              continue;
            case 20:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              propertyMetadata1 = ((ClassMetadata) MetadataLoader.LoadMetadata(EntityFilterDescriptor.SPh9XioMosjkPOaMp5mD((object) filterForAttribute))).Properties.FirstOrDefault<PropertyMetadata>((System.Func<PropertyMetadata, bool>) (p => EntityFilterDescriptor.\u003C\u003Ec__DisplayClass11_0.BId3muCVMt9bQFIsk3Wm(EntityFilterDescriptor.\u003C\u003Ec__DisplayClass11_0.mZrySOCVmYTaMJRKS8Nm((object) p), EntityFilterDescriptor.\u003C\u003Ec__DisplayClass11_0.iinxDgCVyQ0O15fZRMqg((object) entitySettings))));
              num2 = 8;
              continue;
            case 21:
              goto label_41;
            case 22:
              entityManager = (IEntityManager) EntityFilterDescriptor.FW1T7NoMF3tctuDZbUZ2(filterForAttribute.EntityType);
              num2 = 15;
              continue;
            case 23:
              if (filterForAttribute != null)
              {
                num2 = 22;
                continue;
              }
              goto label_40;
            case 24:
              goto label_6;
            default:
              goto label_42;
          }
        }
label_38:
        num1 = 3;
      }
label_35:
      return;
label_19:
      return;
label_14:
      return;
label_9:
      return;
label_41:
      return;
label_6:
      return;
label_42:
      return;
label_13:
      return;
label_3:
      return;
label_40:
      return;
label_43:;
    }

    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (propertyMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            if (EntityFilterDescriptor.dRZcRZoMW3LFPJydCDvJ((object) propertyMetadata) == null)
            {
              num = 3;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (TypeSettings) null;
label_3:
      EntityFilterSettings forFilterProperty = new EntityFilterSettings();
      EntityFilterDescriptor.yUamiGoMZA2IE0xtx550((object) forFilterProperty, EntityFilterDescriptor.HPQsyNoM8cGZbHM2ROFI((object) (SimpleTypeSettings) EntityFilterDescriptor.dRZcRZoMW3LFPJydCDvJ((object) propertyMetadata)));
      return (TypeSettings) forFilterProperty;
    }

    public override ISyntaxNode GetPropertyTypeReference(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter)
    {
      int num1 = 10;
      EntityMetadata metadata1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          EntityMetadata entityMetadata;
          EntityMetadata metadata2;
          switch (num2)
          {
            case 1:
              metadata2 = this.GetMetadata(EntityFilterDescriptor.UegQX2oMikBN8Fd8Ioav((object) metadata1));
              num2 = 4;
              continue;
            case 2:
              metadata1 = this.GetMetadata(metadata2.ImplementationUid);
              num2 = 8;
              continue;
            case 3:
              metadata1 = this.GetMetadata(EntityFilterDescriptor.LpNhGvoMSI3YB9CiMnte((object) metadata1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 7;
              continue;
            case 4:
              if (metadata2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 12 : 12;
                continue;
              }
              goto case 2;
            case 5:
            case 7:
            case 8:
            case 12:
              goto label_14;
            case 6:
              if (!EntityFilterDescriptor.fbDDuboMIPpMu2BHMP7x((object) entityMetadata))
              {
                num2 = 11;
                continue;
              }
              goto label_14;
            case 9:
              entityMetadata = classMetadata as EntityMetadata;
              num2 = 13;
              continue;
            case 10:
              goto label_6;
            case 11:
              if (EntityFilterDescriptor.P6parooMVQf2x1cQVDS0((object) metadata1) == EntityMetadataType.Interface)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 3 : 2;
                continue;
              }
              break;
            case 13:
              goto label_7;
            case 14:
              if (entityMetadata == null)
              {
                num2 = 5;
                continue;
              }
              goto case 6;
          }
          if (EntityFilterDescriptor.P6parooMVQf2x1cQVDS0((object) metadata1) == EntityMetadataType.InterfaceExtension)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 1;
          else
            goto label_14;
        }
label_6:
        metadata1 = this.GetMetadata(EntityFilterDescriptor.eDPt3XoMuuLcr5GMEqw8((object) propertyMetadata));
        num1 = 9;
        continue;
label_7:
        if (!forFilter)
          num1 = 14;
        else
          break;
      }
label_14:
      return (ISyntaxNode) EntityFilterDescriptor.ijXbqOoMK47YBPnefmrO(EntityFilterDescriptor.m2Tb56oMqrKU74SiCJU2(EntityFilterDescriptor.m3YEufoMRx44cG8IMfZV((object) metadata1), EntityFilterDescriptor.gv4C5ioMBnLYWJOgEous(1218962250 ^ 1218945142)));
    }

    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Binary);
    }

    /// <summary>
    /// Получить метаданные сущности по уникальному идентификатору (из сервиса IMetadataService или IMetadataRuntimeService)
    /// </summary>
    /// <param name="subTypeUid">Uid сущности (подтипа)</param>
    /// <returns>Метаданные сущности</returns>
    protected EntityMetadata GetMetadata(Guid subTypeUid) => (EntityMetadata) MetadataServiceContext.Service.GetMetadata(subTypeUid, false) ?? throw new Exception((string) EntityFilterDescriptor.twBsgWoMXqEbg9vqLshH(EntityFilterDescriptor.gv4C5ioMBnLYWJOgEous(1253244298 - 1829393894 ^ -576048676), (object) subTypeUid));

    public EntityFilterDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityFilterDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            EntityFilterDescriptor.tlbkVIoMTJc57o6gTnWp();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            EntityFilterDescriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210631303));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object vmx1KxoyUyljMrwomaHS([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool yOgtfloyYHBmmgY1iroi() => EntityFilterDescriptor.etYOb8oyjqnr5C1Fg4Be == null;

    internal static EntityFilterDescriptor KldewooyLROIOdgC9tUD() => EntityFilterDescriptor.etYOb8oyjqnr5C1Fg4Be;

    internal static bool OjnDIOoysoAYhaPOsb5n([In] object obj0) => ((IEntityFilter) obj0).IsEmpty();

    internal static Type UHUsDXoycscAkrW4cIsU([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object CcC42aoyzMfBpxHIOu8Q([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1, obj2);

    internal static object FW1T7NoMF3tctuDZbUZ2(Type entityType) => (object) ModelHelper.GetEntityManager(entityType);

    internal static object gv4C5ioMBnLYWJOgEous(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object dRZcRZoMW3LFPJydCDvJ([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static Type SPh9XioMosjkPOaMp5mD([In] object obj0) => ((FilterForAttribute) obj0).EntityType;

    internal static object d7c2TqoMbpr5JwdjPME5() => (object) FetchOptions.All;

    internal static object O3rJgGoMh7wNQOXtWVtD([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object aQOGBeoMGpWwJdPbk1FK([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static object zqF4E8oME4De09xlQGBl([In] object obj0, [In] object obj1) => (object) ((DetachedCriteria) obj0).SetProjection((IProjection) obj1);

    internal static object Gv5dDZoMfWLWKUJ2sX2B([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static Guid PbgRJyoMQBCONX8YkAJN([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object AgiQKUoMChnoduHSXG8W(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] JoinType obj3)
    {
      return (object) ((DetachedCriteria) obj0).CreateCriteria((string) obj1, (string) obj2, obj3);
    }

    internal static object j0XOQJoMviobM7OQp2VX() => (object) Projections.Id();

    internal static object HPQsyNoM8cGZbHM2ROFI([In] object obj0) => (object) ((SimpleTypeSettings) obj0).FieldName;

    internal static void yUamiGoMZA2IE0xtx550([In] object obj0, [In] object obj1) => ((SimpleTypeSettings) obj0).FieldName = (string) obj1;

    internal static Guid eDPt3XoMuuLcr5GMEqw8([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static bool fbDDuboMIPpMu2BHMP7x([In] object obj0) => ((ClassMetadata) obj0).IsInterfaceType;

    internal static EntityMetadataType P6parooMVQf2x1cQVDS0([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid LpNhGvoMSI3YB9CiMnte([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static Guid UegQX2oMikBN8Fd8Ioav([In] object obj0) => ((ClassMetadata) obj0).BaseClassUid;

    internal static object m3YEufoMRx44cG8IMfZV([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static object m2Tb56oMqrKU74SiCJU2([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object ijXbqOoMK47YBPnefmrO([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

    internal static object twBsgWoMXqEbg9vqLshH([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void tlbkVIoMTJc57o6gTnWp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
