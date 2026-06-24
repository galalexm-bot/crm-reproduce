// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.ReferenceOnEntityDecription
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Ссылка на объект"</summary>
  public class ReferenceOnEntityDecription : 
    CLRTypeDescriptor<ReferenceOnEntity, ReferenceOnEntitySettings>,
    IMappingTypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{1F289B26-0607-4BC7-ADC0-9ED814C80C90}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private IFullTextPropertyDescriptor propertyDescriptor;
    internal static ReferenceOnEntityDecription A1RNhEoASTHrP1Rhowa9;

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
          case 1:
            ReferenceOnEntitySettings onEntitySettings = (ReferenceOnEntitySettings) ReferenceOnEntityDecription.Pkh2TkoAK3LG9h9ba22R((object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          case 2:
            ReferenceOnEntityDecription.TvNevkoAqARvKH74MQ6G((object) this, (object) mapper, (object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            mapper.Type<ReferenceOnEntityNHType>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Uid типа</summary>
    public override Guid Uid => ReferenceOnEntityDecription.UID;

    /// <summary>Имя "Ссылка на объект"</summary>
    public override string Name => (string) ReferenceOnEntityDecription.e2IT5qoAXLWjbIRWFYBg((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3168376));

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <inheritdoc />
    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num1 = 3;
      ReferenceOnEntity referenceOnEntity;
      Guid guid;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          EntityPropertyMetadata propertyMetadata;
          IEntity entity;
          EntityMetadata entityMetadata;
          switch (num2)
          {
            case 2:
              if (referenceOnEntity == null)
              {
                num2 = 9;
                continue;
              }
              entity = (IEntity) ReferenceOnEntityDecription.ursDnqoAThdBkA3gCnHv((object) referenceOnEntity);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 6;
              continue;
            case 3:
              goto label_5;
            case 4:
              goto label_24;
            case 5:
              if (ReferenceOnEntityDecription.MAbNxxoAnRsPBjVu6C5u((object) settings) != EntitySerializationMode.Default)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
                continue;
              }
              goto case 15;
            case 6:
              if (entity != null)
              {
                guid = Guid.Empty;
                num2 = 12;
                continue;
              }
              goto label_19;
            case 8:
              if (entityMetadata != null)
              {
                num2 = 10;
                continue;
              }
              break;
            case 9:
              goto label_14;
            case 10:
              if (ReferenceOnEntityDecription.nUOyGooAkWdL78XCjWME((object) entity))
              {
                num2 = 18;
                continue;
              }
              goto case 13;
            case 11:
              goto label_23;
            case 12:
              entityMetadata = MetadataLoader.LoadMetadata(entity.GetType()) as EntityMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 6 : 8;
              continue;
            case 13:
              if (settings != null)
              {
                num2 = 5;
                continue;
              }
              goto case 15;
            case 14:
              goto label_27;
            case 15:
            case 18:
              propertyMetadata = (EntityPropertyMetadata) ReferenceOnEntityDecription.YRUoNcoAOsxp05cKVlTN((object) entityMetadata);
              num2 = 17;
              continue;
            case 16:
              guid = entity.GetPropertyValue<Guid>(propertyMetadata.Uid);
              num2 = 7;
              continue;
            case 17:
              if (propertyMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
                continue;
              }
              goto case 16;
          }
          if (!(guid == Guid.Empty))
            num2 = 4;
          else
            goto label_23;
        }
label_5:
        referenceOnEntity = value as ReferenceOnEntity;
        num1 = 2;
        continue;
label_19:
        num1 = 14;
      }
label_14:
      return base.SerializeSimple(value, valueType, settings);
label_23:
      return base.SerializeSimple(value, valueType, settings);
label_24:
      return ReferenceOnEntityDecription.otUdMCoAejgAyCD5YhoU(ReferenceOnEntityDecription.v0Ogd0oA2byJahVEBCI1(-787452571 ^ -787288365), (object) referenceOnEntity.ToString(), (object) ReferenceOnEntity.Delimiter, (object) guid);
label_27:
      return base.SerializeSimple(value, valueType, settings);
    }

    /// <inheritdoc />
    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num = 2;
      string[] strArray;
      Guid objectTypeUId1;
      Guid objectTypeUId2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (strArray.Length < 3)
            {
              if (strArray.Length >= 2)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
                continue;
              }
              goto label_11;
            }
            else
            {
              num = 5;
              continue;
            }
          case 2:
            strArray = (string[]) ReferenceOnEntityDecription.elutlyoA1j2PIFOn0yEl((object) (string) value, ReferenceOnEntityDecription.rTncaXoAPiPAgS6WAcdP((object) ReferenceOnEntity.Delimiter));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_10;
          case 4:
            goto label_3;
          case 5:
            objectTypeUId1 = ReferenceOnEntityDecription.y9lf37oANTDf5aV2jEt5((object) strArray[0]);
            num = 4;
            continue;
          default:
            objectTypeUId2 = ReferenceOnEntityDecription.y9lf37oANTDf5aV2jEt5((object) strArray[0]);
            num = 3;
            continue;
        }
      }
label_3:
      return (object) new ReferenceOnEntity(ReferenceOnEntityDecription.y9lf37oANTDf5aV2jEt5((object) strArray[2]), objectTypeUId1);
label_10:
      return (object) new ReferenceOnEntity(ReferenceOnEntityDecription.vwYAF1oA3gZSC49c0cSc((object) strArray[1]), objectTypeUId2);
label_11:
      return base.DeserializeSimple(value, deserializeToType);
    }

    public override bool HasRealColumn(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return true;
    }

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return (ColumnType) null;
    }

    /// <summary>Получить информацию о требуемых структурах БД</summary>
    /// <param name="entityMetadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Структуры БД</returns>
    public override TypeDbStructures GetDbStructures(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 4;
      TypeDbStructures dbStructures;
      while (true)
      {
        int num2 = num1;
        Column column1;
        ReferenceOnEntitySettings onEntitySettings;
        Column column2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              goto label_8;
            case 3:
              ReferenceOnEntityDecription.gRX95NoAp4SCHDC8vwuk(ReferenceOnEntityDecription.Pkh2TkoAK3LG9h9ba22R((object) propertyMetadata), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536647100));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            case 4:
              ReferenceOnEntityDecription.gRX95NoAp4SCHDC8vwuk((object) propertyMetadata, ReferenceOnEntityDecription.v0Ogd0oA2byJahVEBCI1(1994213607 >> 4 ^ 124624348));
              num2 = 3;
              continue;
            case 5:
              column1 = new Column((string) ReferenceOnEntityDecription.KhYvhQoAtkt5arcQoy2L(ReferenceOnEntityDecription.ontctGoADAnwxnK514bL((object) onEntitySettings)), new ColumnType(DbType.Int64));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 6 : 4;
              continue;
            case 6:
              dbStructures.Columns.Add(column1);
              num2 = 8;
              continue;
            case 7:
              onEntitySettings = (ReferenceOnEntitySettings) ReferenceOnEntityDecription.Pkh2TkoAK3LG9h9ba22R((object) propertyMetadata);
              num2 = 2;
              continue;
            case 8:
              column2 = new Column((string) ReferenceOnEntityDecription.dTRwRxoAw0COWfSj8M5B(ReferenceOnEntityDecription.ontctGoADAnwxnK514bL((object) onEntitySettings)), new ColumnType(DbType.Guid));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 9;
              continue;
            case 9:
              dbStructures.Columns.Add(column2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
              continue;
            case 10:
              if (propertyMetadata.CalculateType != PropertyCalculateType.SQLFormula)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 3 : 5;
                continue;
              }
              goto label_10;
            default:
              ReferenceOnEntityDecription.jHfWo3oAaupIFpgMAfKQ(ReferenceOnEntityDecription.Pkh2TkoAK3LG9h9ba22R((object) propertyMetadata) is ReferenceOnEntitySettings, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1643024244));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 7 : 7;
              continue;
          }
        }
label_8:
        dbStructures = new TypeDbStructures();
        num1 = 10;
      }
label_10:
      return dbStructures;
    }

    /// <summary>Применить изменения в структуре БД в updater</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="entityMetadata">Метаданные сущности (не может быть NULL)</param>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <param name="oldPropertyMetadata">Предыдущие метаданные свойства (не может быть NULL)</param>
    /// <returns>True, если есть изменения</returns>
    public override bool ApplyDbChanges(
      IDbModelUpdater updater,
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata,
      EntityPropertyMetadata oldPropertyMetadata)
    {
      int num1 = 13;
      while (true)
      {
        int num2 = num1;
        ReferenceOnEntitySettings onEntitySettings1;
        string oldName1;
        string newName1;
        string oldName2;
        string newName2;
        ReferenceOnEntitySettings onEntitySettings2;
        Column column1;
        Column column2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              updater.TablesCreatedActions.Add((IDbAction) new DbRenameColumnAction((ITransformationProvider) ReferenceOnEntityDecription.sAwhh5oA7L6YyCgAJQ89((object) updater), (string) ReferenceOnEntityDecription.RjgYg1oAxleoxaunLeg4((object) propertyMetadata, (object) entityMetadata), oldName1, newName1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 17 : 2;
              continue;
            case 2:
              onEntitySettings1 = (ReferenceOnEntitySettings) ReferenceOnEntityDecription.Pkh2TkoAK3LG9h9ba22R((object) oldPropertyMetadata);
              num2 = 3;
              continue;
            case 3:
              if (ReferenceOnEntityDecription.M8luAroA40Y3RjSHTASj(ReferenceOnEntityDecription.ontctGoADAnwxnK514bL((object) onEntitySettings2)))
              {
                num2 = 14;
                continue;
              }
              if (!ReferenceOnEntityDecription.M8luAroA40Y3RjSHTASj(ReferenceOnEntityDecription.ontctGoADAnwxnK514bL((object) onEntitySettings1)))
              {
                if (ReferenceOnEntityDecription.rYONHKoA0hLwfAsVVyFL(ReferenceOnEntityDecription.ontctGoADAnwxnK514bL((object) onEntitySettings1), (object) onEntitySettings2.FieldName))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 6 : 0;
                  continue;
                }
                goto label_11;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 2 : 10;
                continue;
              }
            case 4:
              oldName1 = (string) ReferenceOnEntityDecription.dTRwRxoAw0COWfSj8M5B((object) onEntitySettings1.FieldName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
              continue;
            case 5:
              onEntitySettings2 = (ReferenceOnEntitySettings) ReferenceOnEntityDecription.Pkh2TkoAK3LG9h9ba22R((object) propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 2;
              continue;
            case 6:
              oldName2 = (string) ReferenceOnEntityDecription.KhYvhQoAtkt5arcQoy2L(ReferenceOnEntityDecription.ontctGoADAnwxnK514bL((object) onEntitySettings1));
              num2 = 8;
              continue;
            case 7:
              updater.TablesCreatedActions.Add((IDbAction) new DbRenameColumnAction((ITransformationProvider) ReferenceOnEntityDecription.sAwhh5oA7L6YyCgAJQ89((object) updater), (string) ReferenceOnEntityDecription.RjgYg1oAxleoxaunLeg4((object) propertyMetadata, (object) entityMetadata), oldName2, newName2));
              num2 = 4;
              continue;
            case 8:
              newName2 = (string) ReferenceOnEntityDecription.KhYvhQoAtkt5arcQoy2L((object) onEntitySettings2.FieldName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 7 : 2;
              continue;
            case 9:
              updater.TablesCreatedActions.Add((IDbAction) new DbCreateColumnAction(updater.Transform, (string) ReferenceOnEntityDecription.RjgYg1oAxleoxaunLeg4((object) propertyMetadata, (object) entityMetadata), column2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 20 : 19;
              continue;
            case 10:
              column1 = new Column((string) ReferenceOnEntityDecription.KhYvhQoAtkt5arcQoy2L(ReferenceOnEntityDecription.ontctGoADAnwxnK514bL((object) onEntitySettings2)), new ColumnType(DbType.Int64));
              num2 = 18;
              continue;
            case 11:
              ReferenceOnEntityDecription.gRX95NoAp4SCHDC8vwuk(ReferenceOnEntityDecription.Pkh2TkoAK3LG9h9ba22R((object) oldPropertyMetadata), ReferenceOnEntityDecription.v0Ogd0oA2byJahVEBCI1(-398663332 ^ -398553144));
              num2 = 22;
              continue;
            case 12:
              ReferenceOnEntityDecription.gRX95NoAp4SCHDC8vwuk((object) propertyMetadata, ReferenceOnEntityDecription.v0Ogd0oA2byJahVEBCI1(-951514650 ^ -951500620));
              num2 = 16;
              continue;
            case 13:
              ReferenceOnEntityDecription.gRX95NoAp4SCHDC8vwuk((object) updater, ReferenceOnEntityDecription.v0Ogd0oA2byJahVEBCI1(-281842504 ^ -281986184));
              num2 = 12;
              continue;
            case 14:
              goto label_29;
            case 15:
              goto label_9;
            case 16:
              ReferenceOnEntityDecription.gRX95NoAp4SCHDC8vwuk(ReferenceOnEntityDecription.Pkh2TkoAK3LG9h9ba22R((object) propertyMetadata), ReferenceOnEntityDecription.v0Ogd0oA2byJahVEBCI1(-1710575414 ^ -1710695140));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 13 : 15;
              continue;
            case 17:
              goto label_10;
            case 18:
              updater.TablesCreatedActions.Add((IDbAction) new DbCreateColumnAction((ITransformationProvider) ReferenceOnEntityDecription.sAwhh5oA7L6YyCgAJQ89((object) updater), (string) ReferenceOnEntityDecription.RjgYg1oAxleoxaunLeg4((object) propertyMetadata, (object) entityMetadata), column1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 12 : 21;
              continue;
            case 19:
              ReferenceOnEntityDecription.gRX95NoAp4SCHDC8vwuk((object) oldPropertyMetadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874131519));
              num2 = 11;
              continue;
            case 20:
              goto label_23;
            case 21:
              column2 = new Column(ReferenceOnEntityNHType.GenerateObjectTypeName(onEntitySettings2.FieldName), new ColumnType(DbType.Guid));
              num2 = 9;
              continue;
            case 22:
              ReferenceOnEntityDecription.jHfWo3oAaupIFpgMAfKQ(oldPropertyMetadata.Settings is ReferenceOnEntitySettings, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87959711));
              num2 = 5;
              continue;
            default:
              newName1 = (string) ReferenceOnEntityDecription.dTRwRxoAw0COWfSj8M5B(ReferenceOnEntityDecription.ontctGoADAnwxnK514bL((object) onEntitySettings2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
              continue;
          }
        }
label_9:
        ReferenceOnEntityDecription.jHfWo3oAaupIFpgMAfKQ(ReferenceOnEntityDecription.Pkh2TkoAK3LG9h9ba22R((object) propertyMetadata) is ReferenceOnEntitySettings, ReferenceOnEntityDecription.v0Ogd0oA2byJahVEBCI1(-345420348 ^ -345256440));
        num1 = 19;
      }
label_10:
      return true;
label_11:
      return false;
label_23:
      return true;
label_29:
      throw new MetadataException((string) ReferenceOnEntityDecription.G3uuWJoAAQMVoaTCunj8(ReferenceOnEntityDecription.e2IT5qoAXLWjbIRWFYBg(ReferenceOnEntityDecription.v0Ogd0oA2byJahVEBCI1(272623989 ^ 272467521)), ReferenceOnEntityDecription.CtGaaGoA6rGr1tgYynrg((object) entityMetadata), ReferenceOnEntityDecription.qOumWjoAH7WM5RaEhq1g((object) propertyMetadata)));
    }

    public override IFullTextPropertyDescriptor FullTextPropertyDescriptor
    {
      get
      {
        int num = 2;
        IFullTextPropertyDescriptor propertyDescriptor1;
        IFullTextPropertyDescriptor propertyDescriptor2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.propertyDescriptor = propertyDescriptor1 = (IFullTextPropertyDescriptor) new ReferenceOnEntityPropertyDescriptor((ISerializableTypeDescriptor) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
              continue;
            case 2:
              propertyDescriptor2 = this.propertyDescriptor;
              if (propertyDescriptor2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return propertyDescriptor2;
label_6:
        return propertyDescriptor1;
      }
    }

    public ReferenceOnEntityDecription()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ReferenceOnEntityDecription()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ReferenceOnEntityDecription.UID = new Guid((string) ReferenceOnEntityDecription.v0Ogd0oA2byJahVEBCI1(-342626196 - 1290888215 ^ -1633679129));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void TvNevkoAqARvKH74MQ6G([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SimpleTypeDescriptor<ReferenceOnEntity>) obj0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper) obj1, (EntityPropertyMetadata) obj2));

    internal static object Pkh2TkoAK3LG9h9ba22R([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static bool Ss7nYAoAi0Y199x63BEi() => ReferenceOnEntityDecription.A1RNhEoASTHrP1Rhowa9 == null;

    internal static ReferenceOnEntityDecription XcBNTLoAROwBakQ0UWkJ() => ReferenceOnEntityDecription.A1RNhEoASTHrP1Rhowa9;

    internal static object e2IT5qoAXLWjbIRWFYBg([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object ursDnqoAThdBkA3gCnHv([In] object obj0) => (object) ((ReferenceOnEntity) obj0).Object;

    internal static bool nUOyGooAkWdL78XCjWME([In] object obj0) => ((IEntity) obj0).IsNew();

    internal static EntitySerializationMode MAbNxxoAnRsPBjVu6C5u([In] object obj0) => ((EntitySerializationSettings) obj0).Mode;

    internal static object YRUoNcoAOsxp05cKVlTN([In] object obj0) => (object) ((EntityMetadata) obj0).GetUidProperty();

    internal static object v0Ogd0oA2byJahVEBCI1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object otUdMCoAejgAyCD5YhoU(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static object rTncaXoAPiPAgS6WAcdP([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object elutlyoA1j2PIFOn0yEl([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static Guid y9lf37oANTDf5aV2jEt5([In] object obj0) => Guid.Parse((string) obj0);

    internal static long vwYAF1oA3gZSC49c0cSc([In] object obj0) => long.Parse((string) obj0);

    internal static void gRX95NoAp4SCHDC8vwuk([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void jHfWo3oAaupIFpgMAfKQ(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object ontctGoADAnwxnK514bL([In] object obj0) => (object) ((SimpleTypeSettings) obj0).FieldName;

    internal static object KhYvhQoAtkt5arcQoy2L([In] object obj0) => (object) ReferenceOnEntityNHType.GenerateObjectIdName((string) obj0);

    internal static object dTRwRxoAw0COWfSj8M5B([In] object obj0) => (object) ReferenceOnEntityNHType.GenerateObjectTypeName((string) obj0);

    internal static bool M8luAroA40Y3RjSHTASj([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object CtGaaGoA6rGr1tgYynrg([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static object qOumWjoAH7WM5RaEhq1g([In] object obj0) => (object) ((EleWise.ELMA.Model.Metadata.NamedMetadata) obj0).Name;

    internal static object G3uuWJoAAQMVoaTCunj8([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object sAwhh5oA7L6YyCgAJQ89([In] object obj0) => (object) ((IDbModelUpdater) obj0).Transform;

    internal static object RjgYg1oAxleoxaunLeg4([In] object obj0, [In] object obj1) => (object) ((EntityPropertyMetadata) obj0).GetTableName((EntityMetadata) obj1);

    internal static bool rYONHKoA0hLwfAsVVyFL([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;
  }
}
