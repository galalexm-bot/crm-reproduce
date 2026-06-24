// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.EntityCompareHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Класс, позволяющий сравнивать сущности</summary>
  public static class EntityCompareHelper
  {
    private static EntityCompareHelper Tf9CUIhUoyVYXLR1R8Jw;

    /// <summary>
    /// Получить состояние сущности, которое затем будет использоваться для сравнения
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <returns>Состояние сущности</returns>
    public static IDictionary<string, object> GetState([NotNull] IEntity entity) => entity != null ? (IDictionary<string, object>) new EntityJsonSerializer().ConvertToSerializable((object) entity) : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852875104));

    /// <summary>Сравнить сущность с состоянием сущности этого же типа</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="state"></param>
    /// <returns></returns>
    public static string[] Compare([NotNull] IEntity entity, [NotNull] IDictionary<string, object> state)
    {
      if (entity == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281821156));
      if (state == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239439536));
      List<string> result = new List<string>();
      EntityCompareHelper.Compare((object) entity, state, result, (object) "");
      return result.ToArray();
    }

    private static bool Compare(
      object entity,
      IDictionary<string, object> state,
      List<string> result,
      object prefix)
    {
      bool hasChanges = false;
      Action<string> action = (Action<string>) (s =>
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              result.Add(s);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_2;
            case 4:
              if (result.Contains(s))
              {
                num = 3;
                continue;
              }
              goto case 2;
            default:
              hasChanges = true;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
              continue;
          }
        }
label_5:
        return;
label_2:;
      });
      EntityMetadata metadata = (EntityMetadata) MetadataLoader.LoadMetadata(((IEntity) entity).CastAsRealType<IEntity>().GetType());
      IMetadataService service = MetadataServiceContext.Service;
      foreach (PropertyMetadata property in metadata.Properties)
      {
        string str = (string) prefix + property.Name;
        IDictionary<string, object> dictionary = ((service.GetTypeDescriptor(property.TypeUid, property.SubTypeUid) ?? throw new MetadataException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210639533), (object) property.TypeUid))) as ISerializableTypeDescriptor).Serialize(entity, (ClassMetadata) metadata, property);
        if (dictionary != null)
        {
          foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>) dictionary)
          {
            object v1 = keyValuePair.Value;
            object v2;
            if (!state.TryGetValue(keyValuePair.Key, out v2) || !EntityCompareHelper.EqualsSerializedValues(v1, v2))
              action(str);
          }
        }
        else if (state.ContainsKey(property.Name))
          action(str);
      }
      foreach (TablePartMetadata tablePart in metadata.TableParts)
      {
        string str = (string) prefix + tablePart.TablePartPropertyName;
        if (!(((IEntity) entity).GetPropertyValue(tablePart.TablePartPropertyUid) is IEnumerable propertyValue))
        {
          if (state.ContainsKey(tablePart.TablePartPropertyName))
            action(str);
        }
        else
        {
          object obj;
          if (!state.TryGetValue(tablePart.TablePartPropertyName, out obj))
          {
            action(str);
          }
          else
          {
            IEnumerable enumerable = (IEnumerable) obj;
            Dictionary<object, IDictionary<string, object>> source1 = new Dictionary<object, IDictionary<string, object>>();
            foreach (IDictionary<string, object> dictionary in enumerable)
            {
              object key;
              if (dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889492706), out key))
                source1[key] = dictionary;
            }
            Dictionary<object, IEntity> source2 = new Dictionary<object, IEntity>();
            foreach (IEntity entity1 in propertyValue)
              source2[entity1.GetId()] = entity1;
            bool flag = false;
            IEnumerable<object> oldIds = source1.Select<KeyValuePair<object, IDictionary<string, object>>, object>((Func<KeyValuePair<object, IDictionary<string, object>>, object>) (v => v.Key));
            IEnumerable<object> newIds = source2.Select<KeyValuePair<object, IEntity>, object>((Func<KeyValuePair<object, IEntity>, object>) (v => v.Key));
            if (oldIds.Any<object>((Func<object, bool>) (i => !newIds.Contains<object>(i))) || newIds.Any<object>((Func<object, bool>) (i => !oldIds.Contains<object>(i))))
              flag = true;
            foreach (KeyValuePair<object, IEntity> keyValuePair in source2)
            {
              IDictionary<string, object> state1;
              if (source1.TryGetValue(keyValuePair.Key, out state1) && EntityCompareHelper.Compare((object) keyValuePair.Value, state1, result, (object) ((string) prefix + tablePart.TablePartPropertyName + z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813597973))))
                flag = true;
            }
            if (flag)
              action(str);
          }
        }
      }
      return hasChanges;
    }

    private static bool EqualsSerializedValues(object v1, object v2)
    {
      int num1 = 11;
      IDictionary<string, object> source;
      IEnumerator<KeyValuePair<string, object>> enumerator;
      HashSet<object> objectSet1;
      HashSet<object> other;
      IDictionary<string, object> v1dict;
      while (true)
      {
        int num2 = num1;
        List<object> objectList1;
        while (true)
        {
          List<object> objectList2;
          Func<List<object>, HashSet<object>> func1;
          switch (num2)
          {
            case 1:
              goto label_12;
            case 2:
              // ISSUE: reference to a compiler-generated field
              EntityCompareHelper.\u003C\u003Ec.\u003C\u003E9__3_1 = func1 = (Func<List<object>, HashSet<object>>) (e =>
              {
                HashSet<object> objectSet2 = new HashSet<object>();
                foreach (IDictionary<string, object> dictionary in e.OfType<IDictionary<string, object>>())
                {
                  object obj;
                  if (dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289681612), out obj))
                    objectSet2.Add(obj);
                }
                return objectSet2;
              });
              goto label_61;
            case 3:
              goto label_57;
            case 4:
              if (v1 == null)
              {
                num2 = 19;
                continue;
              }
              goto case 25;
            case 5:
              // ISSUE: reference to a compiler-generated field
              Func<List<object>, HashSet<object>> func2 = EntityCompareHelper.\u003C\u003Ec.\u003C\u003E9__3_1;
              if (func2 == null)
              {
                num2 = 2;
                continue;
              }
              func1 = func2;
              goto label_61;
            case 6:
              if (!source.Any<KeyValuePair<string, object>>())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
                continue;
              }
              break;
            case 7:
              if (v2 != null)
              {
                num2 = 24;
                continue;
              }
              goto case 4;
            case 8:
              goto label_43;
            case 9:
              if (objectList1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 15 : 7;
                continue;
              }
              goto case 5;
            case 10:
              if (v1 == v2)
              {
                num2 = 8;
                continue;
              }
              if (v1 == null)
              {
                num2 = 7;
                continue;
              }
              goto case 4;
            case 11:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 10;
              continue;
            case 12:
              v1dict = v1 as IDictionary<string, object>;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 4 : 22;
              continue;
            case 13:
              goto label_17;
            case 14:
              goto label_14;
            case 15:
              goto label_58;
            case 16:
              goto label_37;
            case 17:
            case 24:
              goto label_34;
            case 18:
              if (!v1dict.Any<KeyValuePair<string, object>>())
              {
                num2 = 6;
                continue;
              }
              break;
            case 19:
            case 20:
              if (!v1.Equals(v2))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 12 : 0;
                continue;
              }
              goto label_37;
            case 21:
              objectList2 = v1 as List<object>;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 9 : 14;
              continue;
            case 22:
              goto label_11;
            case 23:
              if (v1dict == null)
              {
                num2 = 21;
                continue;
              }
              goto case 26;
            case 25:
              if (v2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 20 : 19;
                continue;
              }
              goto label_34;
            case 26:
              if (source != null)
              {
                num2 = 18;
                continue;
              }
              goto case 21;
            case 27:
              if (objectList2 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 4 : 9;
                continue;
              }
              goto label_58;
            default:
              goto label_46;
          }
          enumerator = v1dict.GetEnumerator();
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 13 : 0;
          continue;
label_61:
          objectSet1 = func1(objectList2);
          other = func1(objectList1);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 3 : 1;
        }
label_11:
        source = v2 as IDictionary<string, object>;
        num1 = 23;
        continue;
label_14:
        objectList1 = v2 as List<object>;
        num1 = 27;
      }
label_12:
      return true;
label_17:
      bool flag;
      try
      {
label_21:
        if (EntityCompareHelper.gOEwFehUEiKwX9rb0nSm((object) enumerator))
          goto label_27;
        else
          goto label_22;
label_18:
        KeyValuePair<string, object> current;
        object obj;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_59;
            case 2:
              goto label_27;
            case 3:
              if (!EntityCompareHelper.TtJoUshUGmUjaYwXpTtN(current.Value, obj))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 3 : 6;
                continue;
              }
              goto label_21;
            case 4:
              goto label_21;
            case 5:
              if (source.TryGetValue(current.Key, out obj))
              {
                num3 = 3;
                continue;
              }
              goto label_21;
            case 6:
              flag = false;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 1 : 1;
              continue;
            default:
              goto label_46;
          }
        }
label_22:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
        goto label_18;
label_27:
        current = enumerator.Current;
        num3 = 5;
        goto label_18;
      }
      finally
      {
        if (enumerator != null)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                EntityCompareHelper.DK6ecwhUfqKbN0IGXSC3((object) enumerator);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                continue;
              default:
                goto label_33;
            }
          }
        }
label_33:;
      }
label_59:
      return flag;
label_34:
      return false;
label_37:
      return true;
label_43:
      return true;
label_46:
      return source.Keys.All<string>((Func<string, bool>) (a => v1dict.ContainsKey(a)));
label_57:
      return objectSet1.SetEquals((IEnumerable<object>) other);
label_58:
      return false;
    }

    internal static bool TtJoUshUGmUjaYwXpTtN([In] object obj0, [In] object obj1) => EntityCompareHelper.EqualsSerializedValues(obj0, obj1);

    internal static bool gOEwFehUEiKwX9rb0nSm([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void DK6ecwhUfqKbN0IGXSC3([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool x0B04VhUb2Ynb7piwLNq() => EntityCompareHelper.Tf9CUIhUoyVYXLR1R8Jw == null;

    internal static EntityCompareHelper XCgb8ohUhkKGoLPT5BSH() => EntityCompareHelper.Tf9CUIhUoyVYXLR1R8Jw;
  }
}
