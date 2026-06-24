// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.PasswordDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Db;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Actions;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Кастомный мапинг для Password</summary>
  /// <summary>Описание типа "Пароль"</summary>
  [Component(Order = 1500)]
  public class PasswordDescriptor : 
    CLRTypeDescriptor<PasswordInfo, PasswordSettings>,
    IMappingTypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{D31DFDF6-102D-4B74-8B3E-5EE97AA9FA7D}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private static PasswordDescriptor bCVWWmo4iKJgk30ZBDm5;

    /// <inheritdoc />
    protected override void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            PasswordSettings passwordSettings = (PasswordSettings) PasswordDescriptor.D0DWTBo4XFU6bgLp1wyl((object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          case 3:
            PasswordDescriptor.zoB7sRo4K2pP9YCbKTlW((object) this, (object) mapper, (object) propertyMetadata);
            num = 2;
            continue;
          default:
            mapper.Type<PasswordNHType>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Uid типа</summary>
    public override Guid Uid => PasswordDescriptor.UID;

    /// <summary>Имя "Пароль"</summary>
    public override string Name => (string) PasswordDescriptor.h3mC74o4kyTUKG5bT6aQ(PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(-1217523399 ^ -1217515017));

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>Нельзя использовать в фильтре</summary>
    /// <param name="classMetadata">Метаданные сущности</param>
    /// <returns></returns>
    public override bool IsVisibleForMetadata(ClassMetadata classMetadata) => !(classMetadata is EntityFilterMetadata);

    /// <summary>Доступна ли для редактирования в таблице</summary>
    public override bool IsAvailibleEditPropertyInTable => true;

    /// <summary>Когда является пустым</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="val">Объект</param>
    /// <returns></returns>
    public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
    {
      int num = 2;
      PasswordInfo passwordInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            passwordInfo = val as PasswordInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          case 2:
            if (val != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          case 3:
            goto label_4;
          case 4:
            goto label_9;
          case 5:
            goto label_8;
          default:
            if (passwordInfo != null)
            {
              num = 4;
              continue;
            }
            goto label_8;
        }
      }
label_4:
      return true;
label_8:
      return true;
label_9:
      return passwordInfo.IsEmpty();
    }

    /// <summary>Сериализовать данные в объект</summary>
    /// <param name="value">Данные</param>
    /// <param name="valueType">Тип данных</param>
    /// <param name="settings">Настройки</param>
    /// <returns>Сериализованное представление данных</returns>
    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(value is PasswordInfo passwordInfo))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      SerializableDictionary<string, object> serializableDictionary1 = new SerializableDictionary<string, object>();
      serializableDictionary1.Add((string) PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(-630932142 - 1120244082 ^ -1751300566), (object) string.Empty);
      serializableDictionary1.Add((string) PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(1052221104 - 768835541 ^ 283530757), (object) string.Empty);
      return (object) serializableDictionary1;
label_5:
      SerializableDictionary<string, object> serializableDictionary2 = new SerializableDictionary<string, object>();
      serializableDictionary2.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672071458), PasswordDescriptor.ujcdrNo4nWaSE1aKCDG0((object) passwordInfo));
      serializableDictionary2.Add((string) PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(-281842504 ^ -281992090), PasswordDescriptor.Nej4Smo4O9R5dmQRJ64h((object) passwordInfo));
      return (object) serializableDictionary2;
    }

    /// <summary>Десериализовать данные</summary>
    /// <param name="value">Сериализованное представление данных</param>
    /// <param name="deserializeToType">Тип данных</param>
    /// <returns>Десериализованный объект</returns>
    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num1 = 1;
      string hash;
      string salt;
      while (true)
      {
        int num2 = num1;
        IDictionary<string, object> dictionary;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!PasswordDescriptor.SWqqZDo42lW0HrCTTQMS(deserializeToType, (Type) null))
              {
                if (typeof (PasswordInfo).IsAssignableFrom(deserializeToType))
                {
                  num2 = 4;
                  continue;
                }
                goto label_6;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                continue;
              }
            case 2:
              salt = dictionary[(string) PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(1642859704 ^ 1643005030)].ToString();
              num2 = 9;
              continue;
            case 3:
              goto label_14;
            case 4:
              goto label_17;
            case 5:
              goto label_7;
            case 6:
              if (dictionary != null)
              {
                num2 = 8;
                continue;
              }
              goto label_7;
            case 7:
              goto label_15;
            case 8:
              hash = dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29101911)].ToString();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 2;
              continue;
            case 9:
              goto label_5;
            default:
              goto label_9;
          }
        }
label_15:
        dictionary = value as IDictionary<string, object>;
        num1 = 6;
        continue;
label_17:
        if (!(value is PasswordInfo passwordInfo))
          num1 = 7;
        else
          goto label_14;
      }
label_5:
      return (object) new PasswordInfo(hash, salt, Guid.Empty);
label_6:
      return base.DeserializeSimple(value, deserializeToType);
label_7:
      return (object) null;
label_9:
      throw new ArgumentNullException((string) PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(-53329496 >> 4 ^ -3314274));
label_14:
      return (object) passwordInfo;
    }

    /// <summary>Есть ли реальная колонка БД</summary>
    /// <param name="entityMetadata">Метаданные сущности</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns></returns>
    public override bool HasRealColumn(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return true;
    }

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="entityMetadata">Метаданные сущности</param>
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
      int num1 = 6;
      TypeDbStructures dbStructures;
      while (true)
      {
        int num2 = num1;
        PasswordSettings passwordSettings;
        Column column1;
        Column column2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              dbStructures.Columns.Add(column1);
              num2 = 10;
              continue;
            case 3:
              goto label_7;
            case 4:
              dbStructures = new TypeDbStructures();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            case 5:
              PasswordDescriptor.oajRTRo4eluc7yeg8V1n(PasswordDescriptor.D0DWTBo4XFU6bgLp1wyl((object) propertyMetadata), PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(1199946765 ^ 1200083419));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
              continue;
            case 6:
              goto label_8;
            case 7:
              column2 = new Column((string) PasswordDescriptor.Jyu1Txo43SXfZmk7DivE(PasswordDescriptor.i7v12Lo4N07fa5EVZTQR((object) passwordSettings)), new ColumnType(DbType.String, 2000));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 9 : 2;
              continue;
            case 8:
              passwordSettings = (PasswordSettings) PasswordDescriptor.D0DWTBo4XFU6bgLp1wyl((object) propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 4;
              continue;
            case 9:
              goto label_14;
            case 10:
              goto label_3;
            default:
              if (PasswordDescriptor.UP2oF7o41SqvT54E2Qsf((object) propertyMetadata) != PropertyCalculateType.SQLFormula)
              {
                num2 = 7;
                continue;
              }
              goto label_3;
          }
        }
label_6:
        PasswordDescriptor.gobaAso4P0vhyNLt7dyl(PasswordDescriptor.D0DWTBo4XFU6bgLp1wyl((object) propertyMetadata) is PasswordSettings, PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(132912447 ^ 133069619));
        num1 = 8;
        continue;
label_7:
        column1 = new Column((string) PasswordDescriptor.WmydVGo4p540Xw3jZ8Fs(PasswordDescriptor.i7v12Lo4N07fa5EVZTQR((object) passwordSettings)), new ColumnType(DbType.String, 64));
        num1 = 2;
        continue;
label_8:
        PasswordDescriptor.oajRTRo4eluc7yeg8V1n((object) propertyMetadata, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870906523));
        num1 = 5;
        continue;
label_14:
        dbStructures.Columns.Add(column2);
        num1 = 3;
      }
label_3:
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
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        Column column1;
        PasswordSettings passwordSettings1;
        PasswordSettings passwordSettings2;
        string newName1;
        string oldName;
        string hashName;
        string newName2;
        Column column2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              newName2 = (string) PasswordDescriptor.Jyu1Txo43SXfZmk7DivE(PasswordDescriptor.i7v12Lo4N07fa5EVZTQR((object) passwordSettings2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 3;
              continue;
            case 2:
              updater.TablesCreatedActions.Add((IDbAction) new DbCreateColumnAction((ITransformationProvider) PasswordDescriptor.sF6dBgo4wi7FhmdpqqOf((object) updater), (string) PasswordDescriptor.WO5T7Wo44gC9NiRNwZtN((object) propertyMetadata, (object) entityMetadata), column2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 21 : 20;
              continue;
            case 3:
              updater.TablesCreatedActions.Add((IDbAction) new DbRenameColumnAction((ITransformationProvider) PasswordDescriptor.sF6dBgo4wi7FhmdpqqOf((object) updater), (string) PasswordDescriptor.WO5T7Wo44gC9NiRNwZtN((object) propertyMetadata, (object) entityMetadata), hashName, newName2));
              num2 = 8;
              continue;
            case 4:
              goto label_25;
            case 5:
              passwordSettings1 = (PasswordSettings) PasswordDescriptor.D0DWTBo4XFU6bgLp1wyl((object) oldPropertyMetadata);
              num2 = 10;
              continue;
            case 6:
              hashName = PasswordNHType.GenerateHashName((string) PasswordDescriptor.i7v12Lo4N07fa5EVZTQR((object) passwordSettings1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 1;
              continue;
            case 7:
              updater.TablesCreatedActions.Add((IDbAction) new DbRenameColumnAction(updater.Transform, (string) PasswordDescriptor.WO5T7Wo44gC9NiRNwZtN((object) propertyMetadata, (object) entityMetadata), oldName, newName1));
              num2 = 16;
              continue;
            case 8:
              goto label_14;
            case 9:
              newName1 = (string) PasswordDescriptor.WmydVGo4p540Xw3jZ8Fs(PasswordDescriptor.i7v12Lo4N07fa5EVZTQR((object) passwordSettings2));
              num2 = 7;
              continue;
            case 10:
              if (!PasswordDescriptor.SDW6xEo4a4QZVaLeNFeF(PasswordDescriptor.i7v12Lo4N07fa5EVZTQR((object) passwordSettings2)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 10 : 13;
                continue;
              }
              goto label_4;
            case 11:
              Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138174678));
              num2 = 19;
              continue;
            case 12:
              PasswordDescriptor.oajRTRo4eluc7yeg8V1n((object) updater, PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(1251470110 >> 2 ^ 312978695));
              num2 = 11;
              continue;
            case 13:
              if (PasswordDescriptor.SDW6xEo4a4QZVaLeNFeF(PasswordDescriptor.i7v12Lo4N07fa5EVZTQR((object) passwordSettings1)))
                goto case 14;
              else
                goto label_6;
            case 14:
              column2 = new Column((string) PasswordDescriptor.Jyu1Txo43SXfZmk7DivE((object) passwordSettings2.FieldName), new ColumnType(DbType.String, 2000));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 2;
              continue;
            case 15:
              PasswordDescriptor.gobaAso4P0vhyNLt7dyl(oldPropertyMetadata.Settings is PasswordSettings, PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(1925118608 << 2 ^ -889617264));
              num2 = 23;
              continue;
            case 16:
              goto label_20;
            case 17:
              PasswordDescriptor.oajRTRo4eluc7yeg8V1n(PasswordDescriptor.D0DWTBo4XFU6bgLp1wyl((object) oldPropertyMetadata), PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(1574260816 ^ 1574387396));
              num2 = 15;
              continue;
            case 18:
              goto label_4;
            case 19:
              PasswordDescriptor.oajRTRo4eluc7yeg8V1n(PasswordDescriptor.D0DWTBo4XFU6bgLp1wyl((object) propertyMetadata), PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(1253244298 - 1829393894 ^ -576009614));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            case 20:
              if ((string) PasswordDescriptor.i7v12Lo4N07fa5EVZTQR((object) passwordSettings1) != passwordSettings2.FieldName)
              {
                num2 = 6;
                continue;
              }
              goto label_21;
            case 21:
              column1 = new Column((string) PasswordDescriptor.WmydVGo4p540Xw3jZ8Fs(PasswordDescriptor.i7v12Lo4N07fa5EVZTQR((object) passwordSettings2)), new ColumnType(DbType.String, 64));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 22 : 24;
              continue;
            case 22:
              Contract.ArgumentNotNull((object) oldPropertyMetadata, (string) PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(372753449 ^ 372615747));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 11 : 17;
              continue;
            case 23:
              passwordSettings2 = (PasswordSettings) PasswordDescriptor.D0DWTBo4XFU6bgLp1wyl((object) propertyMetadata);
              num2 = 5;
              continue;
            case 24:
              updater.TablesCreatedActions.Add((IDbAction) new DbCreateColumnAction((ITransformationProvider) PasswordDescriptor.sF6dBgo4wi7FhmdpqqOf((object) updater), (string) PasswordDescriptor.WO5T7Wo44gC9NiRNwZtN((object) propertyMetadata, (object) entityMetadata), column1));
              num2 = 4;
              continue;
            default:
              PasswordDescriptor.gobaAso4P0vhyNLt7dyl(PasswordDescriptor.D0DWTBo4XFU6bgLp1wyl((object) propertyMetadata) is PasswordSettings, PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(~-306453669 ^ 306606760));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 22 : 13;
              continue;
          }
        }
label_6:
        num1 = 20;
        continue;
label_14:
        oldName = (string) PasswordDescriptor.WmydVGo4p540Xw3jZ8Fs(PasswordDescriptor.i7v12Lo4N07fa5EVZTQR((object) passwordSettings1));
        num1 = 9;
      }
label_4:
      throw new MetadataException(string.Format((string) PasswordDescriptor.h3mC74o4kyTUKG5bT6aQ((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957698700)), PasswordDescriptor.PrCIuQo4DkwZyHWpuZJH((object) entityMetadata), PasswordDescriptor.Kuxe93o4tqKFP8l1TTMf((object) propertyMetadata)));
label_20:
      return true;
label_21:
      return false;
label_25:
      return true;
    }

    public PasswordDescriptor()
    {
      PasswordDescriptor.CliNx3o46yY9kcwx0jll();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static PasswordDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            PasswordDescriptor.UID = new Guid((string) PasswordDescriptor.cYW7R3o4TTr4FYrHTvWG(1505778440 - 1981636111 ^ -476015783));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          case 2:
            PasswordDescriptor.CliNx3o46yY9kcwx0jll();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void zoB7sRo4K2pP9YCbKTlW([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SimpleTypeDescriptor<PasswordInfo>) obj0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper) obj1, (EntityPropertyMetadata) obj2));

    internal static object D0DWTBo4XFU6bgLp1wyl([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static bool exg6T4o4RMCeDhWe61Mn() => PasswordDescriptor.bCVWWmo4iKJgk30ZBDm5 == null;

    internal static PasswordDescriptor R3vDvno4qQqJFhN9OppK() => PasswordDescriptor.bCVWWmo4iKJgk30ZBDm5;

    internal static object cYW7R3o4TTr4FYrHTvWG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object h3mC74o4kyTUKG5bT6aQ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object ujcdrNo4nWaSE1aKCDG0([In] object obj0) => (object) ((PasswordInfo) obj0).Hash;

    internal static object Nej4Smo4O9R5dmQRJ64h([In] object obj0) => (object) ((PasswordInfo) obj0).Salt;

    internal static bool SWqqZDo42lW0HrCTTQMS([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static void oajRTRo4eluc7yeg8V1n([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void gobaAso4P0vhyNLt7dyl(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static PropertyCalculateType UP2oF7o41SqvT54E2Qsf([In] object obj0) => ((PropertyMetadata) obj0).CalculateType;

    internal static object i7v12Lo4N07fa5EVZTQR([In] object obj0) => (object) ((SimpleTypeSettings) obj0).FieldName;

    internal static object Jyu1Txo43SXfZmk7DivE([In] object obj0) => (object) PasswordNHType.GenerateHashName((string) obj0);

    internal static object WmydVGo4p540Xw3jZ8Fs([In] object obj0) => (object) PasswordNHType.GenerateSaltName((string) obj0);

    internal static bool SDW6xEo4a4QZVaLeNFeF([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object PrCIuQo4DkwZyHWpuZJH([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static object Kuxe93o4tqKFP8l1TTMf([In] object obj0) => (object) ((EleWise.ELMA.Model.Metadata.NamedMetadata) obj0).Name;

    internal static object sF6dBgo4wi7FhmdpqqOf([In] object obj0) => (object) ((IDbModelUpdater) obj0).Transform;

    internal static object WO5T7Wo44gC9NiRNwZtN([In] object obj0, [In] object obj1) => (object) ((EntityPropertyMetadata) obj0).GetTableName((EntityMetadata) obj1);

    internal static void CliNx3o46yY9kcwx0jll() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
