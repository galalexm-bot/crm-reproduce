// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.DbModelHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Db
{
  /// <summary>
  /// Класс-помощник, предоставляющий методы для работы со структурами БД для хранения моделей
  /// </summary>
  public static class DbModelHelper
  {
    internal static DbModelHelper NNWd6noo1nnqZUUGOseg;

    /// <summary>
    /// Получить колонку БД для первичного ключа сущности. Без указания свойств колонки
    /// </summary>
    /// <param name="metadata">Метаданные сущности</param>
    /// <returns>Колонка БД для первичного ключа</returns>
    public static Column GetColumnForIdentifier(EntityMetadata metadata) => DbModelHelper.GetColumnForIdentifier(metadata, out bool _);

    /// <summary>
    /// Получить колонку БД по умолчанию для первичного ключа сущности
    /// </summary>
    /// <returns>Колонка БД для первичного ключа</returns>
    public static Column GetDefaultColumnForIdentifier()
    {
      int num = 1;
      ITypeDescriptor idType;
      while (true)
      {
        switch (num)
        {
          case 1:
            idType = (ITypeDescriptor) DbModelHelper.tEOwy5ooa51VulDNCxZg(DbModelHelper.YuQ1NVoop0x4gZ77SWoJ(), Int64Descriptor.UID);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return DbModelHelper.GetColumnForIdentifier((object) null, (object) string.Empty, (object) idType, out bool _);
    }

    /// <summary>
    /// Получить колонку БД для первичного ключа сущности. Без указания свойств колонки
    /// </summary>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="autoIncrement">Поддерживается ли автоинкремент</param>
    /// <returns>Колонка БД для первичного ключа</returns>
    public static Column GetColumnForIdentifier(EntityMetadata metadata, out bool autoIncrement)
    {
      int num = 2;
      ITypeDescriptor idTypeDescriptor;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (idTypeDescriptor != null)
            {
              num = 3;
              continue;
            }
            goto label_3;
          case 2:
            idTypeDescriptor = MetadataServiceContext.Service.GetIdTypeDescriptor(metadata.IdTypeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_4;
          default:
            goto label_3;
        }
      }
label_3:
      throw new DbModelException((string) DbModelHelper.VD3XCvoo4Ppa3TcqxWRg(DbModelHelper.io85huooDIcprnrEf3KY((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979365353)), DbModelHelper.iYYZCDootY10D2PcCuQq((object) metadata), (object) DbModelHelper.CnnDxRoow56VjoosdRlN((object) metadata)));
label_4:
      return DbModelHelper.GetColumnForIdentifier((object) metadata, DbModelHelper.iYYZCDootY10D2PcCuQq((object) metadata), (object) idTypeDescriptor, out autoIncrement);
    }

    /// <summary>Получить структуры БД для свойства сущности</summary>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Структуры БД</returns>
    public static TypeDbStructures GetPropertyDbStructures(
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 1;
      IDbTypeInfo dbTypeInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            dbTypeInfo = (IDbTypeInfo) DbModelHelper.IdbODvoo6hsFTacy8LLT((object) metadata, (object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_2;
          default:
            if (dbTypeInfo != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 2;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return new TypeDbStructures();
label_3:
      return (TypeDbStructures) DbModelHelper.OXkbD6ooHcJ1wjVqUdZq((object) dbTypeInfo, (object) metadata, (object) propertyMetadata);
    }

    /// <summary>Получить структуры БД для свойства сущности</summary>
    /// <param name="updater">Провайдер обновления БД</param>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="oldPropertyMetadata">Старые метаданные свойства</param>
    /// <returns>True, если есть изменения</returns>
    public static bool ApplyPropertyDbChanges(
      IDbModelUpdater updater,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      EntityPropertyMetadata oldPropertyMetadata)
    {
      int num = 2;
      IDbTypeInfo dbTypeInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (dbTypeInfo == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            dbTypeInfo = (IDbTypeInfo) DbModelHelper.IdbODvoo6hsFTacy8LLT((object) metadata, (object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return false;
label_6:
      return dbTypeInfo.ApplyDbChanges(updater, metadata, propertyMetadata, oldPropertyMetadata);
    }

    private static IDbTypeInfo GetDbTypeInfo(object metadata, object propertyMetadata)
    {
      int num = 1;
      ITypeDescriptor typeDescriptor;
      IDbTypeInfo dbTypeInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            typeDescriptor = ((IMetadataService) DbModelHelper.YuQ1NVoop0x4gZ77SWoJ()).GetTypeDescriptor(((PropertyMetadata) propertyMetadata).TypeUid, ((PropertyMetadata) propertyMetadata).SubTypeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_5;
          case 4:
            if (dbTypeInfo != null)
            {
              num = 3;
              continue;
            }
            goto case 5;
          case 5:
            DbModelHelper.vh443Xoo7oZoWZddVE6n(DbModelHelper.lDwQTUooxqbx6H0jRLNU(), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333624746), DbModelHelper.iYYZCDootY10D2PcCuQq(metadata), (object) ((EleWise.ELMA.Model.Metadata.NamedMetadata) propertyMetadata).Name, (object) typeDescriptor.GetType().FullName));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 1;
            continue;
          case 6:
            goto label_6;
          case 7:
            DbModelHelper.vh443Xoo7oZoWZddVE6n((object) Logger.Log, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218608320), DbModelHelper.iYYZCDootY10D2PcCuQq(metadata), DbModelHelper.qrm7s9ooA3VXCt1hnk04(propertyMetadata), (object) ((PropertyMetadata) propertyMetadata).TypeUid));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 6 : 3;
            continue;
          default:
            if (typeDescriptor != null)
            {
              dbTypeInfo = typeDescriptor as IDbTypeInfo;
              num = 4;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 3 : 7;
            continue;
        }
      }
label_4:
      return (IDbTypeInfo) null;
label_5:
      return dbTypeInfo;
label_6:
      return (IDbTypeInfo) null;
    }

    private static Column GetColumnForIdentifier(
      object metadata,
      object metadataFullTypeName,
      object idType,
      out bool autoIncrement)
    {
      int num = 5;
      IDbTypeInfo dbTypeInfo1;
      TypeDbStructures typeDbStructures;
      Column column;
      SimpleTypeSettings simpleTypeSettings;
      while (true)
      {
        switch (num)
        {
          case 1:
            typeDbStructures.PrimaryKeys.Add(new PrimaryKey()
            {
              TableName = ((EntityMetadata) metadata).TableName,
              Columns = new List<string>()
              {
                (string) DbModelHelper.hg569PoolGbvMkZ3cmMY((object) column)
              }
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 7 : 4;
            continue;
          case 2:
            goto label_15;
          case 3:
            simpleTypeSettings = (SimpleTypeSettings) DbModelHelper.QyYecZooMr2MfUvb4QdD(DbModelHelper.HH1DLPooyItm0RxcdgFH(idType));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 4 : 10;
            continue;
          case 4:
            if (dbTypeInfo1 != null)
            {
              num = 9;
              continue;
            }
            goto label_4;
          case 5:
            dbTypeInfo1 = idType as IDbTypeInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 4;
            continue;
          case 6:
            if (typeDbStructures == null)
            {
              num = 2;
              continue;
            }
            if (DbModelHelper.aAGqWwoodEGrLfcpBp2t((object) typeDbStructures.Columns) == 1)
            {
              column = typeDbStructures.Columns[0];
              num = 12;
              continue;
            }
            num = 11;
            continue;
          case 7:
            goto label_8;
          case 8:
            goto label_4;
          case 9:
            autoIncrement = DbModelHelper.MLqsKXoom1KnsLRW5UYi((object) dbTypeInfo1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 3 : 2;
            continue;
          case 10:
            DbModelHelper.IKbVhUooJc18ueiif8Vt((object) simpleTypeSettings, DbModelHelper.tCXrUPoo03l05VBcM3WB(~289714581 ^ -289681612));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          case 11:
            goto label_6;
          case 12:
            if (metadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 1;
              continue;
            }
            goto label_8;
          default:
            IDbTypeInfo dbTypeInfo2 = dbTypeInfo1;
            object obj = metadata;
            EntityPropertyMetadata propertyMetadata = new EntityPropertyMetadata();
            DbModelHelper.jvmyGtoo9biOjW53aXWT((object) propertyMetadata, (object) simpleTypeSettings);
            typeDbStructures = (TypeDbStructures) DbModelHelper.OXkbD6ooHcJ1wjVqUdZq((object) dbTypeInfo2, obj, (object) propertyMetadata);
            num = 6;
            continue;
        }
      }
label_4:
      throw new DbModelException((string) DbModelHelper.VD3XCvoo4Ppa3TcqxWRg((object) EleWise.ELMA.SR.T((string) DbModelHelper.tCXrUPoo03l05VBcM3WB(-345420348 ^ -345308248)), metadataFullTypeName, (object) idType.GetType().FullName));
label_6:
      throw new DbModelException((string) DbModelHelper.VD3XCvoo4Ppa3TcqxWRg(DbModelHelper.io85huooDIcprnrEf3KY(DbModelHelper.tCXrUPoo03l05VBcM3WB(-1867198571 ^ -1867087795)), metadataFullTypeName, (object) idType.GetType().FullName));
label_8:
      return column;
label_15:
      throw new DbModelException(string.Format((string) DbModelHelper.io85huooDIcprnrEf3KY((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647762132)), metadataFullTypeName, (object) idType.GetType().FullName));
    }

    internal static bool LDcKBLooNEo4dGLaW0Cq() => DbModelHelper.NNWd6noo1nnqZUUGOseg == null;

    internal static DbModelHelper d97y9Xoo3FgImwDh3lKE() => DbModelHelper.NNWd6noo1nnqZUUGOseg;

    internal static object YuQ1NVoop0x4gZ77SWoJ() => (object) MetadataServiceContext.Service;

    internal static object tEOwy5ooa51VulDNCxZg([In] object obj0, Guid typeUid) => (object) ((IMetadataService) obj0).GetIdTypeDescriptor(typeUid);

    internal static object io85huooDIcprnrEf3KY([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object iYYZCDootY10D2PcCuQq([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static Guid CnnDxRoow56VjoosdRlN([In] object obj0) => ((EntityMetadata) obj0).IdTypeUid;

    internal static object VD3XCvoo4Ppa3TcqxWRg([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object IdbODvoo6hsFTacy8LLT([In] object obj0, [In] object obj1) => (object) DbModelHelper.GetDbTypeInfo(obj0, obj1);

    internal static object OXkbD6ooHcJ1wjVqUdZq([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IDbTypeInfo) obj0).GetDbStructures((EntityMetadata) obj1, (EntityPropertyMetadata) obj2);

    internal static object qrm7s9ooA3VXCt1hnk04([In] object obj0) => (object) ((EleWise.ELMA.Model.Metadata.NamedMetadata) obj0).Name;

    internal static void vh443Xoo7oZoWZddVE6n([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static object lDwQTUooxqbx6H0jRLNU() => (object) Logger.Log;

    internal static object tCXrUPoo03l05VBcM3WB(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool MLqsKXoom1KnsLRW5UYi([In] object obj0) => ((IDbTypeInfo) obj0).AutoIncrementSupported;

    internal static Type HH1DLPooyItm0RxcdgFH([In] object obj0) => ((ITypeDescriptor) obj0).SettingsType;

    internal static object QyYecZooMr2MfUvb4QdD([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static void IKbVhUooJc18ueiif8Vt([In] object obj0, [In] object obj1) => ((SimpleTypeSettings) obj0).FieldName = (string) obj1;

    internal static void jvmyGtoo9biOjW53aXWT([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).Settings = (TypeSettings) obj1;

    internal static int aAGqWwoodEGrLfcpBp2t([In] object obj0) => ((List<Column>) obj0).Count;

    internal static object hg569PoolGbvMkZ3cmMY([In] object obj0) => (object) ((Column) obj0).Name;
  }
}
