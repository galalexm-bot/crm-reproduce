// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.BinaryFileDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Файл"</summary>
  public class BinaryFileDescriptor : 
    CLRTypeDescriptor<BinaryFile, BinaryFileSettings>,
    IMappingTypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{289F266B-2805-457E-BCE0-B0BCD4D38143}";
    public const int DbColumnLength = 250;
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static BinaryFileDescriptor CYUZcuo7MTNNWbDZmEJo;

    /// <inheritdoc />
    protected override void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              BinaryFileDescriptor.POV1sCo7dLpqwRlJ8OtT((object) this, (object) mapper, (object) propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              BinaryFileDescriptor.NhZSwxo7llfQaxDNFhVt((object) mapper, 250);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 2 : 2;
              continue;
            default:
              goto label_6;
          }
        }
label_6:
        mapper.Type<BinaryFileType>();
        num1 = 3;
      }
label_3:;
    }

    private static SerializableDictionary<string, object> BinaryFileInDictionary(object valueEntity)
    {
      if (valueEntity == null)
      {
        SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
        serializableDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767713175), (object) string.Empty);
        serializableDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099764073), (object) string.Empty);
        serializableDictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 88007707), (object) string.Empty);
        return serializableDictionary;
      }
      string str;
      try
      {
        str = ((BinaryFile) valueEntity).Id.IsNullOrEmpty() ? string.Empty : DataAccessManager.FileManager.FileSize(((BinaryFile) valueEntity).Id).ToString();
      }
      catch (FileNotFoundException ex)
      {
        str = string.Empty;
      }
      SerializableDictionary<string, object> serializableDictionary1 = new SerializableDictionary<string, object>();
      serializableDictionary1.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675482067), (object) ((BinaryFile) valueEntity).Uid);
      serializableDictionary1.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852866108), (object) ((BinaryFile) valueEntity).Name);
      serializableDictionary1.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -70187368), (object) str);
      return serializableDictionary1;
    }

    /// <summary>
    /// Получить файл из хранилища <see cref="T:EleWise.ELMA.Runtime.Managers.IFileManager" /> или из временного хранилища <see cref="T:EleWise.ELMA.Services.ICacheFilesService" />
    /// </summary>
    /// <param name="uid">Уникальный идентификатор файла</param>
    /// <returns></returns>
    public static BinaryFile Download(Guid uid)
    {
      int num1 = 1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (uid != Guid.Empty)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
              continue;
            }
            goto label_12;
          case 2:
            goto label_12;
          default:
            goto label_2;
        }
      }
label_2:
      BinaryFile binaryFile;
      try
      {
        object obj = BinaryFileDescriptor.Yc55IJo7g7TnsFIGLMFF(BinaryFileDescriptor.Nyo6Ovo7rILmHkbZbdqD(), (object) uid.ToString());
        string name = ((BinaryFile) obj).Name;
        binaryFile = (BinaryFile) obj;
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      catch (FileNotFoundException ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_13;
            default:
              binaryFile = (BinaryFile) BinaryFileDescriptor.ri5KlUo75uUcN6UbD1Zx((object) Locator.GetServiceNotNull<ICacheFilesService>(), uid);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
              continue;
          }
        }
      }
label_13:
      return binaryFile;
label_12:
      return (BinaryFile) null;
    }

    /// <summary>Uid типа данных или группы типов</summary>
    public override Guid Uid => BinaryFileDescriptor.UID;

    /// <summary>Имя "Файл"</summary>
    public override string Name => (string) BinaryFileDescriptor.aQIeOco7Yo2E5XjFOmeB(BinaryFileDescriptor.gvd4Wxo7jSDjyfUOqlB2(1574260816 ^ 1574426948));

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>Указыват поведение при копировании объекта</summary>
    public override CopyAction CopyAction => CopyAction.ByRef;

    public override bool IsPublicApplicationDisplayEnabled(Guid subTypeUid) => true;

    public override bool IsPublicApplicationEditorEnabled(Guid subTypeUid) => true;

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.String, 250);
    }

    public override void ApplyFilterValue(
      ICriteria criteria,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      object value,
      string alias)
    {
      int num = 1;
      BinaryFile binaryFile;
      ITransformationProvider serviceNotNull;
      SimpleTypeSettings simpleTypeSettings;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (metadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            }
            if (propertyMetadata != null)
            {
              num = 3;
              continue;
            }
            goto label_24;
          case 2:
            goto label_24;
          case 3:
            if (criteria == null)
            {
              num = 9;
              continue;
            }
            goto case 10;
          case 4:
            goto label_21;
          case 5:
            goto label_7;
          case 6:
            if (string.IsNullOrEmpty(binaryFile.SecondId))
            {
              num = 7;
              continue;
            }
            goto case 11;
          case 7:
            BinaryFileDescriptor.OAVvLCoxGxAj1rqVdDc5((object) criteria, BinaryFileDescriptor.oJNhqsoxhA9fnVuUx3da(BinaryFileDescriptor.mkNnRboxWuoX2O6FL34R((object) alias) ? (object) propertyMetadata.Name : BinaryFileDescriptor.alY2Iqoxb8KWuNJNwxfQ(BinaryFileDescriptor.gvd4Wxo7jSDjyfUOqlB2(-244066886 - -48452443 ^ -195597545), (object) alias, BinaryFileDescriptor.rUIVRioxoffAgKTmGbJ8((object) propertyMetadata)), value));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 4 : 3;
            continue;
          case 8:
            goto label_2;
          case 9:
            goto label_10;
          case 10:
            if (value is BinaryFile)
            {
              binaryFile = (BinaryFile) value;
              num = 6;
              continue;
            }
            num = 8;
            continue;
          case 11:
            simpleTypeSettings = BinaryFileDescriptor.LwRXfCo7LmTA3LmImNCw((object) propertyMetadata) as SimpleTypeSettings;
            num = 16;
            continue;
          case 12:
            goto label_5;
          case 13:
            serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 10 : 15;
            continue;
          case 14:
            criteria.Add((ICriterion) BinaryFileDescriptor.PkT1dWoxBg7RsLeHIA87((object) str, (object) new object[2]
            {
              BinaryFileDescriptor.HB3Ymao7zTpKrkWp0FIR((object) binaryFile),
              BinaryFileDescriptor.Nq45rloxFj8unxfITlvS((object) binaryFile)
            }, (object) new IType[2]
            {
              (IType) NHibernateUtil.String,
              (IType) NHibernateUtil.String
            }));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 5 : 1;
            continue;
          case 15:
            str = (string) BinaryFileDescriptor.iR71Ygo7c2n49ElOhHji(BinaryFileDescriptor.gvd4Wxo7jSDjyfUOqlB2(-2099751081 ^ -2099585417), BinaryFileDescriptor.TDIs12o7sWvTSaDy57d1((object) serviceNotNull.Dialect, BinaryFileDescriptor.yTd33ao7UUv8WW8mv4po((object) simpleTypeSettings)));
            num = 14;
            continue;
          case 16:
            if (simpleTypeSettings != null)
            {
              num = 13;
              continue;
            }
            goto label_9;
          default:
            goto label_12;
        }
      }
label_21:
      return;
label_7:
      return;
label_2:
      return;
label_10:
      return;
label_5:
      return;
label_12:
      throw new ArgumentNullException((string) BinaryFileDescriptor.gvd4Wxo7jSDjyfUOqlB2(1669371371 ^ 1669389525));
label_9:
      return;
label_24:
      throw new ArgumentNullException((string) BinaryFileDescriptor.gvd4Wxo7jSDjyfUOqlB2(-1146510045 ^ -1146491791));
    }

    /// <summary>Получить описание структуры сериализуемых значений</summary>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Объект с описанием структуры сериализуемых значений</returns>
    public override TypeSerializationDescriptor GetSerializeDescriptor(
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata)
    {
      int num1 = 3;
      string description;
      PropertyMetadata propertyMetadata1;
      string descr;
      while (true)
      {
        string str;
        switch (num1)
        {
          case 1:
            str = "";
            break;
          case 2:
            propertyMetadata1 = propertyMetadata;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            object obj;
            if (BinaryFileDescriptor.mkNnRboxWuoX2O6FL34R(BinaryFileDescriptor.XlynWfoxEMy43m1fFGIX((object) propertyMetadata1)))
              obj = (object) "";
            else
              obj = BinaryFileDescriptor.c7sYShoxCaBDpp2XchFs(BinaryFileDescriptor.gvd4Wxo7jSDjyfUOqlB2(1051276242 - 990076387 ^ 61299815), BinaryFileDescriptor.XlynWfoxEMy43m1fFGIX((object) propertyMetadata1), BinaryFileDescriptor.wIWcJkoxQL8801H4xG8m((object) propertyMetadata1), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239478818), (object) this.GetPropertyTypeDisplayName(propertyMetadata1)));
            descr = (string) obj;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 5 : 1;
            continue;
          case 5:
            goto label_7;
          default:
            if (BinaryFileDescriptor.mkNnRboxWuoX2O6FL34R(BinaryFileDescriptor.XlynWfoxEMy43m1fFGIX((object) propertyMetadata1)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
              continue;
            }
            str = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16590965), (object) propertyMetadata1.DisplayName, BinaryFileDescriptor.i1oeGtoxfFcUcCNukoQf((object) this, (object) propertyMetadata1));
            break;
        }
        description = str;
        num1 = 4;
      }
label_7:
      Action<TypeSerializationDescriptorBuilder> action;
      return new TypeSerializationDescriptorBuilder().Description(description).Item((Action<TypeSerializationItemDescriptorBuilder>) (i =>
      {
        int num7 = 1;
        while (true)
        {
          switch (num7)
          {
            case 0:
              goto label_4;
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              object obj = BinaryFileDescriptor.\u003C\u003Ec__DisplayClass21_0.yTGwCKCuzbJIUEcQRUfW((object) i, BinaryFileDescriptor.\u003C\u003Ec__DisplayClass21_0.q7fGDcCucF1HiuQhd2P9((object) propertyMetadata1));
              Action<TypeSerializationDescriptorBuilder> action1 = action;
              Action<TypeSerializationDescriptorBuilder> descriptorBuilder = action1 == null ? (action = (Action<TypeSerializationDescriptorBuilder>) (d =>
              {
                int num8 = 1;
                while (true)
                {
                  switch (num8)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      d.Description(descr).Item((Action<TypeSerializationItemDescriptorBuilder>) (di =>
                      {
                        int num5 = 1;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              BinaryFileDescriptor.\u003C\u003Ec.pNj4ZMCIE8tsbrka2vQZ(BinaryFileDescriptor.\u003C\u003Ec.IGhphlCIhr11Hiaj0Dww((object) di, BinaryFileDescriptor.\u003C\u003Ec.MrcoNrCIbWouL8mQ4oIZ(1218962250 ^ 1218940120)), BinaryFileDescriptor.\u003C\u003Ec.zD83bkCIG0VqmGbUdrME(BinaryFileDescriptor.\u003C\u003Ec.MrcoNrCIbWouL8mQ4oIZ(1470440286 ^ 1470152448)));
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        return;
label_4:;
                      })).Item((Action<TypeSerializationItemDescriptorBuilder>) (di =>
                      {
                        int num6 = 1;
                        while (true)
                        {
                          switch (num6)
                          {
                            case 0:
                              goto label_2;
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              // ISSUE: reference to a compiler-generated method
                              BinaryFileDescriptor.\u003C\u003Ec.pNj4ZMCIE8tsbrka2vQZ((object) di.Name((string) BinaryFileDescriptor.\u003C\u003Ec.MrcoNrCIbWouL8mQ4oIZ(1199946765 ^ 1199951821)), BinaryFileDescriptor.\u003C\u003Ec.zD83bkCIG0VqmGbUdrME((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 221803452)));
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_4;
                          }
                        }
label_2:
                        return;
label_4:;
                      }));
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              })) : action1;
              ((TypeSerializationItemDescriptorBuilder) obj).Descriptor(descriptorBuilder);
              num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      })).Descriptor;
    }

    public override IDictionary<string, object> Serialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      EntitySerializationSettings settings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538537688));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825370708));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (PropertyInfo) null || !property.CanRead)
        return (IDictionary<string, object>) null;
      object obj1 = property.GetValue(obj, (object[]) null);
      SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
      serializableDictionary[propertyMetadata.Name] = this.SerializeSimple(obj1, property.PropertyType, settings);
      return (IDictionary<string, object>) serializableDictionary;
    }

    public override object SerializeSimple(
      object value,
      System.Type valueType,
      EntitySerializationSettings settings)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!BinaryFileDescriptor.OeDeOUoxvsE369qUm70F(valueType, (System.Type) null))
            {
              // ISSUE: type reference
              if (BinaryFileDescriptor.dBqNWRox8VKbJqiHm58o(__typeref (BinaryFile)).IsAssignableFrom(valueType))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 0;
                continue;
              }
              goto label_3;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            }
          case 2:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      return (object) BinaryFileDescriptor.BinaryFileInDictionary((object) (value as BinaryFile));
label_3:
      return base.SerializeSimple(value, valueType, settings);
label_4:
      throw new ArgumentNullException((string) BinaryFileDescriptor.gvd4Wxo7jSDjyfUOqlB2(1925118608 << 2 ^ -889625604));
    }

    public override void Deserialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      IDictionary<string, object> values)
    {
      if (obj == null || values == null)
        return;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234318290));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672105367));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      object obj1;
      if (property == (PropertyInfo) null || !property.CanWrite || !values.TryGetValue(propertyMetadata.Name, out obj1))
        return;
      property.SetValue(obj, this.DeserializeSimple(obj1, TypeOf<BinaryFile>.Raw), (object[]) null);
    }

    public override object DeserializeSimple(object value, System.Type deserializeToType)
    {
      int num1 = 10;
      Guid result;
      while (true)
      {
        int num2 = num1;
        IDictionary<string, object> dictionary;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_16;
            case 2:
              goto label_6;
            case 3:
              goto label_5;
            case 4:
              goto label_9;
            case 5:
              if (!(value is BinaryFile binaryFile))
              {
                num2 = 2;
                continue;
              }
              goto label_5;
            case 6:
              goto label_17;
            case 7:
              if (dictionary != null)
              {
                num2 = 8;
                continue;
              }
              goto label_7;
            case 8:
              Guid.TryParse(dictionary[(string) BinaryFileDescriptor.gvd4Wxo7jSDjyfUOqlB2(381945751 ^ 1158627804 ^ 1405823449)].ToString(), out result);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
              continue;
            case 9:
              // ISSUE: type reference
              if (!BinaryFileDescriptor.dBqNWRox8VKbJqiHm58o(__typeref (BinaryFile)).IsAssignableFrom(deserializeToType))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 5 : 6;
                continue;
              }
              goto case 5;
            case 10:
              if (!(deserializeToType == (System.Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 9 : 9;
                continue;
              }
              goto label_9;
            default:
              goto label_7;
          }
        }
label_6:
        dictionary = value as IDictionary<string, object>;
        num1 = 7;
      }
label_5:
      return (object) binaryFile;
label_7:
      return (object) null;
label_9:
      throw new ArgumentNullException((string) BinaryFileDescriptor.gvd4Wxo7jSDjyfUOqlB2(--1360331293 ^ 1360350105));
label_16:
      return BinaryFileDescriptor.EdTNFsoxZgNLos1Mbemy(result);
label_17:
      return base.DeserializeSimple(value, deserializeToType);
    }

    public BinaryFileDescriptor()
    {
      BinaryFileDescriptor.KEWIHXoxuHyChdPfULqq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static BinaryFileDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            BinaryFileDescriptor.KEWIHXoxuHyChdPfULqq();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            BinaryFileDescriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306615670));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void POV1sCo7dLpqwRlJ8OtT([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SimpleTypeDescriptor<BinaryFile>) obj0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper) obj1, (EntityPropertyMetadata) obj2));

    internal static void NhZSwxo7llfQaxDNFhVt([In] object obj0, int length) => ((INHibernatePropertyTypeMapper) obj0).Length(length);

    internal static bool SYhvXFo7Jp9uNgkQU05t() => BinaryFileDescriptor.CYUZcuo7MTNNWbDZmEJo == null;

    internal static BinaryFileDescriptor BxtUcto79Bo7LDwrTHW4() => BinaryFileDescriptor.CYUZcuo7MTNNWbDZmEJo;

    internal static object Nyo6Ovo7rILmHkbZbdqD() => (object) DataAccessManager.FileManager;

    internal static object Yc55IJo7g7TnsFIGLMFF([In] object obj0, [In] object obj1) => (object) ((IFileManager) obj0).LoadFile((string) obj1);

    internal static object ri5KlUo75uUcN6UbD1Zx([In] object obj0, Guid uid) => (object) ((ICacheFilesService) obj0).GetBinaryFile(uid);

    internal static object gvd4Wxo7jSDjyfUOqlB2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object aQIeOco7Yo2E5XjFOmeB([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object LwRXfCo7LmTA3LmImNCw([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static object yTd33ao7UUv8WW8mv4po([In] object obj0) => (object) ((SimpleTypeSettings) obj0).FieldName;

    internal static object TDIs12o7sWvTSaDy57d1([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object iR71Ygo7c2n49ElOhHji([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object HB3Ymao7zTpKrkWp0FIR([In] object obj0) => (object) ((BinaryFile) obj0).Id;

    internal static object Nq45rloxFj8unxfITlvS([In] object obj0) => (object) ((BinaryFile) obj0).SecondId;

    internal static object PkT1dWoxBg7RsLeHIA87([In] object obj0, [In] object obj1, [In] object obj2) => (object) Expression.Sql((string) obj0, (object[]) obj1, (IType[]) obj2);

    internal static bool mkNnRboxWuoX2O6FL34R([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object rUIVRioxoffAgKTmGbJ8([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object alY2Iqoxb8KWuNJNwxfQ([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object oJNhqsoxhA9fnVuUx3da([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object OAVvLCoxGxAj1rqVdDc5([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object XlynWfoxEMy43m1fFGIX([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object i1oeGtoxfFcUcCNukoQf([In] object obj0, [In] object obj1) => (object) ((TypeDescriptor) obj0).GetPropertyTypeDisplayName((PropertyMetadata) obj1);

    internal static object wIWcJkoxQL8801H4xG8m([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static object c7sYShoxCaBDpp2XchFs(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static bool OeDeOUoxvsE369qUm70F([In] System.Type obj0, [In] System.Type obj1) => obj0 == obj1;

    internal static System.Type dBqNWRox8VKbJqiHm58o([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object EdTNFsoxZgNLos1Mbemy(Guid uid) => (object) BinaryFileDescriptor.Download(uid);

    internal static void KEWIHXoxuHyChdPfULqq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
