// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.EntityMetadataTypeDescriptor`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>
  /// Дескриптор для сериализации метаданных (параметры процесса, отчета etc)
  /// </summary>
  public abstract class EntityMetadataTypeDescriptor<T> : EntitySubTypeDescriptor<EntityMetadata>
  {
    /// <summary>
    /// список Uid'ов метаданных, требующих обновления Uid'а (хак)
    /// </summary>
    private List<Guid> uidsForUpdate;
    /// <summary>метаданные блоков, требующих удаление (хак)</summary>
    private List<TablePartMetadata> tablepartsForDelete;
    private static object o37rN9oyRukr7uTsPVNP;

    /// <summary>
    /// Получить сериализуемые значения для значения свойства данного типа
    /// </summary>
    /// <param name="obj">Объект, содержащий свойство данного типа</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="serializationSettings">Настройки сериализации</param>
    /// <returns>Словарь сериализуемых значений</returns>
    public override IDictionary<string, object> Serialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      EntitySerializationSettings serializationSettings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137444620));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154098567));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (PropertyInfo) null || !property.CanRead)
        return (IDictionary<string, object>) null;
      object source = property.GetValue(obj, (object[]) null);
      SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
      if (source != null)
      {
        object serObject = source.CastAsRealType();
        this.PreSerializingActions(serObject as EntityMetadata);
        string str1 = ClassSerializationHelper.SerializeObjectByXml(serObject);
        string str2 = str1.Remove(0, str1.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470459038)) + 1);
        string assemblyQualifiedName = serObject.GetType().AssemblyQualifiedName;
        if (assemblyQualifiedName != null)
          str2 = assemblyQualifiedName + str2;
        serializableDictionary[propertyMetadata.Name] = (object) str2;
      }
      return (IDictionary<string, object>) serializableDictionary;
    }

    public override void Deserialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      IDictionary<string, object> values)
    {
      if (obj == null)
        return;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 873994091));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957838574));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      object obj1;
      if (property == (PropertyInfo) null || !property.CanRead || !values.TryGetValue(propertyMetadata.Name, out obj1))
        return;
      string str1 = obj1.ToString();
      Type type = Type.GetType(str1.Substring(0, str1.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998522116))));
      string str2 = str1.Remove(0, str1.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979233289)));
      StringBuilder stringBuilder = new StringBuilder(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669113987));
      stringBuilder.AppendLine(str2);
      string xml = stringBuilder.ToString();
      object deserializedObject = ClassSerializationHelper.DeserializeObjectByXml(type, xml);
      this.PostDeserializingActions(deserializedObject as EntityMetadata);
      property.SetValue(obj, deserializedObject, (object[]) null);
    }

    private void PreSerializingActions(EntityMetadata serObject)
    {
      int num1 = 6;
      IEnumerator<TablePartMetadata> enumerator;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              enumerator = serObject.EntityTableParts.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            case 2:
              serObject.TableParts.AddRange((IEnumerable<TablePartMetadata>) serObject.EntityTableParts.ToList<TablePartMetadata>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_4;
            case 4:
              serObject.TableParts.Clear();
              num2 = 2;
              continue;
            case 5:
              goto label_20;
            case 6:
              if (serObject != null)
              {
                serObject.Properties.Clear();
                num2 = 7;
                continue;
              }
              goto label_26;
            case 7:
              serObject.Properties.AddRange((IEnumerable<PropertyMetadata>) serObject.EntityProperties.Cast<PropertyMetadata>().ToList<PropertyMetadata>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 4 : 4;
              continue;
            default:
              goto label_7;
          }
        }
label_26:
        num1 = 5;
      }
label_4:
      return;
label_20:
      return;
label_7:
      try
      {
label_10:
        if (enumerator.MoveNext())
          goto label_12;
        else
          goto label_11;
label_9:
        TablePartMetadata current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_12;
            case 2:
              this.PreSerializingActions(current);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_15;
            default:
              goto label_10;
          }
        }
label_15:
        return;
label_11:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 3 : 1;
        goto label_9;
label_12:
        current = enumerator.Current;
        num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
        {
          num3 = 2;
          goto label_9;
        }
        else
          goto label_9;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_22;
              default:
                enumerator.Dispose();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_22:;
      }
    }

    private void PreSerializingActions(TablePartMetadata tablePartMetadata)
    {
      int num1 = 4;
      IEnumerator<TablePartMetadata> enumerator;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              enumerator = tablePartMetadata.EntityTableParts.GetEnumerator();
              num2 = 6;
              continue;
            case 2:
              tablePartMetadata.TableParts.Clear();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_5;
            case 4:
              tablePartMetadata.Properties.Clear();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 3;
              continue;
            case 5:
              goto label_18;
            case 6:
              goto label_7;
            default:
              tablePartMetadata.TableParts.AddRange((IEnumerable<TablePartMetadata>) tablePartMetadata.EntityTableParts.ToList<TablePartMetadata>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
              continue;
          }
        }
label_5:
        tablePartMetadata.Properties.AddRange((IEnumerable<PropertyMetadata>) tablePartMetadata.EntityProperties.Cast<PropertyMetadata>().ToList<PropertyMetadata>());
        num1 = 2;
      }
label_18:
      return;
label_7:
      try
      {
label_11:
        if (enumerator.MoveNext())
          goto label_9;
        else
          goto label_12;
label_8:
        TablePartMetadata current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_9;
            case 2:
              goto label_13;
            case 3:
              this.PreSerializingActions(current);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            default:
              goto label_11;
          }
        }
label_13:
        return;
label_9:
        current = enumerator.Current;
        num3 = 3;
        goto label_8;
label_12:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 2;
        goto label_8;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                enumerator.Dispose();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
                continue;
              default:
                goto label_20;
            }
          }
        }
label_20:;
      }
    }

    /// <summary>
    /// Действие после десериализации метаданных EntityMetadata. Выполняет удаление старых метаданных с Uid'ом импортируемых метаданных
    /// </summary>
    /// <param name="deserializedObject"></param>
    public void PostDeserializingActions(EntityMetadata deserializedObject)
    {
      int num1 = 20;
      IEnumerator<TablePartMetadata> enumerator1;
      while (true)
      {
        int num2 = num1;
        IEnumerable<IClearBeforeDelEntityMetadata> extensionPoints;
        EntityMetadata entityMetadata;
        List<Guid>.Enumerator enumerator2;
        IEnumerator<IClearBeforeDelEntityMetadata> enumerator3;
        ITransformationProvider serviceNotNull;
        List<PropertyMetadata>.Enumerator enumerator4;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.tablepartsForDelete = new List<TablePartMetadata>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 9 : 24;
              continue;
            case 2:
              try
              {
label_65:
                if (enumerator4.MoveNext())
                  goto label_63;
                else
                  goto label_66;
label_62:
                int num3;
                switch (num3)
                {
                  case 1:
                    goto label_65;
                  case 2:
                    break;
                  default:
                    goto label_41;
                }
label_63:
                enumerator4.Current.Id = 0L;
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
                {
                  num3 = 0;
                  goto label_62;
                }
                else
                  goto label_62;
label_66:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                goto label_62;
              }
              finally
              {
                enumerator4.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 3:
              enumerator3 = extensionPoints.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 10 : 4;
              continue;
            case 5:
              this.GetTablePartsUids(deserializedObject, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 14 : 2;
              continue;
            case 6:
              try
              {
label_46:
                if (enumerator2.MoveNext())
                  goto label_49;
                else
                  goto label_47;
label_45:
                string sql;
                Guid current;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      sql = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867096881), (object) serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345252344)), (object) serviceNotNull.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886625251)), (object) serviceNotNull.ParameterSeparator);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 3;
                      continue;
                    case 2:
                      goto label_49;
                    case 3:
                      serviceNotNull.ExecuteNonQuery(sql, new Dictionary<string, object>()
                      {
                        {
                          z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979609180),
                          (object) Guid.NewGuid()
                        },
                        {
                          z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397369130),
                          (object) current
                        }
                      });
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                      continue;
                    case 4:
                      goto label_42;
                    default:
                      goto label_46;
                  }
                }
label_47:
                num5 = 4;
                goto label_45;
label_49:
                current = enumerator2.Current;
                num5 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
                {
                  num5 = 0;
                  goto label_45;
                }
                else
                  goto label_45;
              }
              finally
              {
                enumerator2.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 7:
              goto label_27;
            case 8:
              extensionPoints = ComponentManager.Current.GetExtensionPoints<IClearBeforeDelEntityMetadata>();
              num2 = 22;
              continue;
            case 9:
              deserializedObject.Id = 0L;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 21 : 0;
              continue;
            case 10:
              try
              {
label_19:
                if (enumerator3.MoveNext())
                  goto label_17;
                else
                  goto label_20;
label_16:
                int num7;
                switch (num7)
                {
                  case 1:
                    goto label_19;
                  case 2:
                    break;
                  default:
                    goto label_75;
                }
label_17:
                enumerator3.Current.Clear((object) entityMetadata);
                num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
                {
                  num7 = 1;
                  goto label_16;
                }
                else
                  goto label_16;
label_20:
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
                goto label_16;
              }
              finally
              {
                if (enumerator3 != null)
                {
                  int num8 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
                    num8 = 0;
                  while (true)
                  {
                    switch (num8)
                    {
                      case 1:
                        goto label_26;
                      default:
                        enumerator3.Dispose();
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
                        continue;
                    }
                  }
                }
label_26:;
              }
            case 11:
              enumerator2 = this.uidsForUpdate.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 2 : 6;
              continue;
            case 12:
              entityMetadata.Delete();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 8 : 9;
              continue;
            case 13:
              enumerator1 = deserializedObject.EntityTableParts.GetEnumerator();
              num2 = 7;
              continue;
            case 14:
              serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 11 : 2;
              continue;
            case 15:
              goto label_71;
            case 16:
              deserializedObject.EntityTableParts.AddRange<TablePartMetadata>((IEnumerable<TablePartMetadata>) deserializedObject.TableParts.ToList<TablePartMetadata>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 13 : 6;
              continue;
            case 17:
              if (entityMetadata != null)
                goto case 8;
              else
                goto label_9;
            case 18:
              this.GetTablePartsUids(entityMetadata, true);
              num2 = 5;
              continue;
            case 19:
              goto label_6;
            case 20:
              if (deserializedObject != null)
              {
                this.uidsForUpdate = new List<Guid>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 0;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 3 : 19;
              continue;
            case 21:
              enumerator4 = deserializedObject.Properties.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 2;
              continue;
            case 22:
              if (extensionPoints != null)
              {
                num2 = 3;
                continue;
              }
              goto default;
            case 23:
label_42:
              if (entityMetadata != null)
              {
                num2 = 12;
                continue;
              }
              goto case 9;
            case 24:
              entityMetadata = ModelHelper.GetEntityManager(deserializedObject.GetType()).LoadOrNull(deserializedObject.Uid) as EntityMetadata;
              num2 = 17;
              continue;
            case 25:
label_41:
              deserializedObject.EntityProperties.AddRange<EntityPropertyMetadata>((IEnumerable<EntityPropertyMetadata>) deserializedObject.Properties.Cast<EntityPropertyMetadata>().ToList<EntityPropertyMetadata>());
              num2 = 16;
              continue;
            default:
label_75:
              if (entityMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 9 : 18;
                continue;
              }
              goto case 5;
          }
        }
label_9:
        num1 = 4;
      }
label_71:
      return;
label_6:
      return;
label_27:
      try
      {
label_30:
        if (enumerator1.MoveNext())
          goto label_29;
        else
          goto label_31;
label_28:
        TablePartMetadata current;
        int num9;
        while (true)
        {
          switch (num9)
          {
            case 1:
              goto label_67;
            case 2:
              this.PostDeserializingActions(current);
              num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_29;
            default:
              goto label_30;
          }
        }
label_67:
        return;
label_29:
        current = enumerator1.Current;
        num9 = 2;
        goto label_28;
label_31:
        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
        goto label_28;
      }
      finally
      {
        int num10;
        if (enumerator1 == null)
          num10 = 2;
        else
          goto label_36;
label_35:
        switch (num10)
        {
          case 1:
          case 2:
        }
label_36:
        enumerator1.Dispose();
        num10 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        {
          num10 = 0;
          goto label_35;
        }
        else
          goto label_35;
      }
    }

    /// <summary>
    /// Проходимся по TablePart'ам заменяемых метаданных и собираем их Uid
    /// </summary>
    /// <param name="metadata"></param>
    private void GetTablePartsUids(EntityMetadata metadata, bool isOld)
    {
      int num1 = 4;
      List<TablePartMetadata>.Enumerator enumerator1;
      while (true)
      {
        int num2 = num1;
        IEnumerator<TablePartMetadata> enumerator2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_8;
            case 1:
              if (!(metadata is TablePartMetadata))
              {
                num2 = 2;
                continue;
              }
              goto case 6;
            case 2:
            case 7:
            case 11:
              if (!isOld)
              {
                num2 = 8;
                continue;
              }
              goto case 18;
            case 3:
              if (this.uidsForUpdate.Contains(metadata.Uid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 11 : 6;
                continue;
              }
              goto case 9;
            case 4:
              if (metadata != null)
              {
                num2 = 3;
                continue;
              }
              goto label_46;
            case 5:
              goto label_35;
            case 6:
              this.tablepartsForDelete.Add(metadata as TablePartMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 2 : 7;
              continue;
            case 8:
            case 10:
            case 16:
label_4:
              if (!isOld)
              {
                num2 = 19;
                continue;
              }
              goto label_40;
            case 9:
              this.uidsForUpdate.Add(metadata.Uid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
              continue;
            case 12:
              try
              {
label_13:
                if (enumerator2.MoveNext())
                  goto label_15;
                else
                  goto label_14;
label_12:
                TablePartMetadata current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_15;
                    case 2:
                      this.GetTablePartsUids((EntityMetadata) current, true);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 3;
                      continue;
                    case 3:
                      goto label_13;
                    default:
                      goto label_4;
                  }
                }
label_14:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
                goto label_12;
label_15:
                current = enumerator2.Current;
                num3 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
                {
                  num3 = 0;
                  goto label_12;
                }
                else
                  goto label_12;
              }
              finally
              {
                int num4;
                if (enumerator2 == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
                else
                  goto label_23;
label_20:
                switch (num4)
                {
                  case 2:
                    break;
                  default:
                }
label_23:
                enumerator2.Dispose();
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
                {
                  num4 = 0;
                  goto label_20;
                }
                else
                  goto label_20;
              }
            case 13:
              goto label_38;
            case 14:
              goto label_3;
            case 15:
              goto label_50;
            case 17:
              enumerator2 = metadata.EntityTableParts.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 12 : 12;
              continue;
            case 18:
              if (metadata.EntityTableParts == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 10 : 10;
                continue;
              }
              goto case 17;
            case 19:
              if (metadata.TableParts == null)
              {
                num2 = 5;
                continue;
              }
              goto label_3;
            default:
              goto label_34;
          }
        }
label_3:
        enumerator1 = metadata.TableParts.GetEnumerator();
        num1 = 13;
      }
label_8:
      return;
label_35:
      return;
label_50:
      return;
label_34:
      return;
label_40:
      return;
label_46:
      return;
label_38:
      try
      {
label_44:
        if (enumerator1.MoveNext())
          goto label_41;
        else
          goto label_45;
label_39:
        TablePartMetadata current;
        int num5;
        while (true)
        {
          switch (num5)
          {
            case 0:
              goto label_22;
            case 1:
              goto label_44;
            case 2:
              goto label_41;
            case 3:
              this.GetTablePartsUids((EntityMetadata) current, false);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
              continue;
            default:
              goto label_21;
          }
        }
label_22:
        return;
label_21:
        return;
label_41:
        current = enumerator1.Current;
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
        {
          num5 = 3;
          goto label_39;
        }
        else
          goto label_39;
label_45:
        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
        goto label_39;
      }
      finally
      {
        enumerator1.Dispose();
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
          num6 = 0;
        switch (num6)
        {
          default:
        }
      }
    }

    private void PostDeserializingActions(TablePartMetadata tablePartMetadata)
    {
      int num1 = 3;
      IEnumerator<TablePartMetadata> enumerator1;
      List<PropertyMetadata>.Enumerator enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            enumerator2 = tablePartMetadata.Properties.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 4;
            continue;
          case 3:
            tablePartMetadata.Id = 0L;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 2 : 0;
            continue;
          case 4:
            try
            {
label_17:
              if (enumerator2.MoveNext())
                goto label_19;
              else
                goto label_18;
label_16:
              int num2;
              switch (num2)
              {
                case 1:
                  goto label_17;
                case 2:
                  goto label_14;
                default:
                  goto label_19;
              }
label_18:
              num2 = 2;
              goto label_16;
label_19:
              enumerator2.Current.Id = 0L;
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
              {
                num2 = 0;
                goto label_16;
              }
              else
                goto label_16;
            }
            finally
            {
              enumerator2.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 5:
            enumerator1 = tablePartMetadata.EntityTableParts.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 1;
            continue;
          case 6:
            goto label_25;
          case 7:
label_14:
            tablePartMetadata.EntityProperties.AddRange<EntityPropertyMetadata>(tablePartMetadata.Properties.Cast<EntityPropertyMetadata>());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          default:
            tablePartMetadata.EntityTableParts.AddRange<TablePartMetadata>((IEnumerable<TablePartMetadata>) tablePartMetadata.TableParts);
            num1 = 5;
            continue;
        }
      }
label_25:
      return;
label_2:
      try
      {
label_6:
        if (enumerator1.MoveNext())
          goto label_4;
        else
          goto label_7;
label_3:
        TablePartMetadata current;
        int num4;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_4;
            case 2:
              goto label_21;
            case 3:
              this.PostDeserializingActions(current);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_21:
        return;
label_4:
        current = enumerator1.Current;
        num4 = 3;
        goto label_3;
label_7:
        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 2 : 1;
        goto label_3;
      }
      finally
      {
        if (enumerator1 != null)
        {
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                goto label_13;
              default:
                enumerator1.Dispose();
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_13:;
      }
    }

    protected EntityMetadataTypeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool i9SU2doyqg9sjFSRoJWy() => EntityMetadataTypeDescriptor<T>.o37rN9oyRukr7uTsPVNP == null;

    internal static object nRFOsxoyKaELZ8HmREAg() => EntityMetadataTypeDescriptor<T>.o37rN9oyRukr7uTsPVNP;
  }
}
