// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Descriptors.EntityPropertyDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Exceptions;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Descriptors
{
  /// <summary>
  /// Провайдер полнотекстового поиска для свойства с типом "IEntity"
  /// </summary>
  public class EntityPropertyDescriptor : FullTextPropertyDescriptor
  {
    /// <summary>Постфикс названия свойства в БД провайдера</summary>
    protected const string IndexFieldIdPostfix = "_index";
    private static EntityPropertyDescriptor gvpkU5GvyJPlvp9pFBco;

    /// <summary>Ctor</summary>
    /// <param name="typeDescriptor">Дескриптор типа</param>
    public EntityPropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(typeDescriptor);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public override FieldIndexList GetIndexField(
      object obj,
      IPropertyMetadata propMd,
      bool reindex)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (reindex)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return this.GetIndexField(obj, propMd);
label_5:
      return this.GetReIndexField(obj, propMd);
    }

    private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
    {
      int num1 = 7;
      IEnumerable enumerable;
      IEntity entity1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_44;
            case 2:
              if (!EntityPropertyDescriptor.x8Oel6Gvlq4kMHcCaHsg((object) entity1))
              {
                num2 = 8;
                continue;
              }
              goto label_38;
            case 3:
            case 6:
              goto label_49;
            case 4:
              entity1 = obj as IEntity;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 10;
              continue;
            case 5:
              goto label_38;
            case 7:
              if (propMd == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 6 : 2;
                continue;
              }
              goto label_44;
            case 8:
              goto label_37;
            case 9:
              enumerable = obj as IEnumerable;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 11 : 2;
              continue;
            case 10:
              if (entity1 == null)
              {
                num2 = 5;
                continue;
              }
              goto case 2;
            case 11:
              if (enumerable != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            default:
              goto label_3;
          }
        }
label_44:
        if (obj != null)
          num1 = 9;
        else
          goto label_49;
      }
label_3:
      FieldIndexList indexField1;
      try
      {
        List<long> longList = new List<long>();
        int num3 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
          num3 = 0;
        IEnumerator enumerator;
        while (true)
        {
          switch (num3)
          {
            case 1:
label_7:
              FieldIndexList fieldIndexList = new FieldIndexList();
              fieldIndexList.Add(new FieldIndexListItem((string) EntityPropertyDescriptor.E3AC8fGvUxmX09tJS8Jv(EntityPropertyDescriptor.zIWGDHGvYJY5OEb69nhF((object) EntityPropertyDescriptor.UIwJZHGvj6Lhw5mb5cul((object) propMd).ToString()), EntityPropertyDescriptor.L0D824GvLLhC1EYksCmT(2045296739 + 1688595713 ^ -561158538)), (object) longList, FullTextFieldType.Long));
              indexField1 = fieldIndexList;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            case 2:
              try
              {
label_13:
                if (EntityPropertyDescriptor.dhDiHNGv5OFS64bhVJfT((object) enumerator))
                  goto label_21;
                else
                  goto label_14;
label_10:
                object obj1;
                int num4;
                while (true)
                {
                  long result;
                  IEntity entity2;
                  switch (num4)
                  {
                    case 1:
                      if (!long.TryParse(obj1.ToString(), out result))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 4 : 9;
                        continue;
                      }
                      goto case 11;
                    case 2:
                      if (obj1 != null)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
                        continue;
                      }
                      goto label_13;
                    case 3:
                      goto label_7;
                    case 4:
                      if (entity2 == null)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 2;
                        continue;
                      }
                      break;
                    case 5:
                      longList.Add(EntityPropertyDescriptor.OnUYqHGvg6ZOoctmKbHm(EntityPropertyDescriptor.D0X3i9GvrLxu7tmfMaUR((object) entity2)));
                      num4 = 6;
                      continue;
                    case 6:
                    case 8:
                    case 9:
                      goto label_13;
                    case 7:
                      entity2 = obj1 as IEntity;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 3 : 4;
                      continue;
                    case 10:
                      goto label_21;
                    case 11:
                      longList.Add(result);
                      num4 = 8;
                      continue;
                  }
                  if (!EntityPropertyDescriptor.x8Oel6Gvlq4kMHcCaHsg((object) entity2))
                    num4 = 5;
                  else
                    goto label_13;
                }
label_14:
                num4 = 3;
                goto label_10;
label_21:
                obj1 = EntityPropertyDescriptor.mOwB0CGvd6PmqRwWBc85((object) enumerator);
                num4 = 7;
                goto label_10;
              }
              finally
              {
                IDisposable disposable = enumerator as IDisposable;
                int num5 = 3;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      disposable.Dispose();
                      num5 = 2;
                      continue;
                    case 3:
                      if (disposable == null)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                        continue;
                      }
                      goto case 1;
                    default:
                      goto label_30;
                  }
                }
label_30:;
              }
            case 3:
              enumerator = (IEnumerator) EntityPropertyDescriptor.spkAtDGv9ZhmK4ikUa00((object) enumerable);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 2;
              continue;
            default:
              goto label_39;
          }
        }
      }
      catch (Exception ex)
      {
        int num6 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
          num6 = 0;
        while (true)
        {
          switch (num6)
          {
            case 1:
              indexField1 = (FieldIndexList) null;
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
              continue;
            default:
              goto label_39;
          }
        }
      }
label_39:
      return indexField1;
label_37:
      FieldIndexList indexField2 = new FieldIndexList();
      indexField2.Add(new FieldIndexListItem((string) EntityPropertyDescriptor.E3AC8fGvUxmX09tJS8Jv(EntityPropertyDescriptor.zIWGDHGvYJY5OEb69nhF((object) EntityPropertyDescriptor.UIwJZHGvj6Lhw5mb5cul((object) propMd).ToString()), EntityPropertyDescriptor.L0D824GvLLhC1EYksCmT(372753449 ^ 372510523)), (object) Convert.ToInt64(EntityPropertyDescriptor.D0X3i9GvrLxu7tmfMaUR((object) entity1)), FullTextFieldType.Long));
      return indexField2;
label_38:
      return (FieldIndexList) null;
label_49:
      return new FieldIndexList();
    }

    private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
    {
      int num1 = 1;
      IList<object> listOrNull;
      List<long> source;
      long result1;
      Type type;
      IEnumerator<object> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (propMd != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
              continue;
            }
            goto label_37;
          case 2:
            goto label_4;
          case 3:
            goto label_6;
          case 4:
            // ISSUE: type reference
            if (EntityPropertyDescriptor.ikAgumGvcRsW6C6Ufyyb(type.GetGenericTypeDefinition(), EntityPropertyDescriptor.kSqPCgGvsjvfQ5kFXyBh(__typeref (SerializableList<>))))
            {
              num1 = 8;
              continue;
            }
            goto case 7;
          case 5:
            try
            {
label_14:
              if (EntityPropertyDescriptor.dhDiHNGv5OFS64bhVJfT((object) enumerator))
                goto label_21;
              else
                goto label_15;
label_13:
              long? idValueForEntity;
              object current;
              long result2;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                  case 9:
                  case 10:
                  case 11:
                  case 12:
                    goto label_14;
                  case 2:
                    idValueForEntity = EntityPropertyDescriptor.GetIdValueForEntity(current);
                    num2 = 8;
                    continue;
                  case 3:
                    source.Add(result2);
                    num2 = 12;
                    continue;
                  case 4:
                    source.Add(idValueForEntity.Value);
                    num2 = 11;
                    continue;
                  case 5:
                    if (current is IEntity)
                    {
                      num2 = 2;
                      continue;
                    }
                    goto case 7;
                  case 6:
                    if (!long.TryParse(current.ToString(), out result2))
                    {
                      num2 = 9;
                      continue;
                    }
                    goto case 3;
                  case 7:
                    if (current == null)
                    {
                      num2 = 10;
                      continue;
                    }
                    goto case 6;
                  case 8:
                    if (!idValueForEntity.HasValue)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
                      continue;
                    }
                    goto case 4;
                  case 13:
                    goto label_42;
                  default:
                    goto label_21;
                }
              }
label_15:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 13 : 7;
              goto label_13;
label_21:
              current = enumerator.Current;
              num2 = 5;
              goto label_13;
            }
            finally
            {
              int num3;
              if (enumerator == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
              else
                goto label_31;
label_30:
              switch (num3)
              {
                case 1:
                  break;
                default:
              }
label_31:
              enumerator.Dispose();
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
              {
                num3 = 2;
                goto label_30;
              }
              else
                goto label_30;
            }
          case 6:
            if (listOrNull != null)
            {
              num1 = 13;
              continue;
            }
            goto label_6;
          case 7:
            // ISSUE: type reference
            if (EntityPropertyDescriptor.ikAgumGvcRsW6C6Ufyyb(type.GetGenericTypeDefinition(), EntityPropertyDescriptor.kSqPCgGvsjvfQ5kFXyBh(__typeref (List<>))))
            {
              num1 = 14;
              continue;
            }
            goto case 11;
          case 8:
          case 14:
            listOrNull = (obj as IEnumerable).CastToListOrNull<object>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 2 : 6;
            continue;
          case 9:
            goto label_50;
          case 10:
            source = new List<long>();
            num1 = 18;
            continue;
          case 11:
            if (long.TryParse(obj.ToString(), out result1))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 15 : 9;
              continue;
            }
            goto label_50;
          case 12:
            type = obj.GetType();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 17 : 14;
            continue;
          case 13:
            if (!listOrNull.Any<object>())
            {
              num1 = 3;
              continue;
            }
            goto case 10;
          case 15:
            goto label_51;
          case 16:
label_42:
            if (source.Any<long>())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 2;
              continue;
            }
            goto label_5;
          case 17:
            if (!type.IsGenericType)
            {
              num1 = 11;
              continue;
            }
            goto case 4;
          case 18:
            enumerator = listOrNull.Distinct<object>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 5 : 0;
            continue;
          case 19:
            goto label_37;
          default:
            if (obj != null)
            {
              num1 = 12;
              continue;
            }
            goto label_52;
        }
      }
label_4:
      FieldIndexList reIndexField1 = new FieldIndexList();
      reIndexField1.Add(new FieldIndexListItem((string) EntityPropertyDescriptor.E3AC8fGvUxmX09tJS8Jv(EntityPropertyDescriptor.zIWGDHGvYJY5OEb69nhF((object) propMd.Uid.ToString()), EntityPropertyDescriptor.L0D824GvLLhC1EYksCmT(-1204263869 ^ -1341583247 ^ 137543456)), (object) source, FullTextFieldType.Long));
      return reIndexField1;
label_5:
      return new FieldIndexList();
label_6:
      FieldIndexList reIndexField2 = new FieldIndexList();
      reIndexField2.Add(new FieldIndexListItem((string) EntityPropertyDescriptor.zIWGDHGvYJY5OEb69nhF((object) EntityPropertyDescriptor.UIwJZHGvj6Lhw5mb5cul((object) propMd).ToString()) + (string) EntityPropertyDescriptor.L0D824GvLLhC1EYksCmT(~541731958 ^ -541714277), (object) null, FullTextFieldType.Long));
      return reIndexField2;
label_37:
      return new FieldIndexList();
label_50:
      return new FieldIndexList();
label_51:
      FieldIndexList reIndexField3 = new FieldIndexList();
      reIndexField3.Add(new FieldIndexListItem((string) EntityPropertyDescriptor.E3AC8fGvUxmX09tJS8Jv(EntityPropertyDescriptor.zIWGDHGvYJY5OEb69nhF((object) EntityPropertyDescriptor.UIwJZHGvj6Lhw5mb5cul((object) propMd).ToString()), EntityPropertyDescriptor.L0D824GvLLhC1EYksCmT(964881585 - -1459193222 ^ -1870677723)), (object) result1, FullTextFieldType.Long));
      return reIndexField3;
label_52:
      FieldIndexList reIndexField4 = new FieldIndexList();
      reIndexField4.Add(new FieldIndexListItem((string) EntityPropertyDescriptor.E3AC8fGvUxmX09tJS8Jv(EntityPropertyDescriptor.zIWGDHGvYJY5OEb69nhF((object) propMd.Uid.ToString()), EntityPropertyDescriptor.L0D824GvLLhC1EYksCmT(-488881205 ^ -488666919)), (object) null, FullTextFieldType.Long));
      return reIndexField4;
    }

    /// <inheritdoc />
    public override FilterListItem GetFilterField(
      object value,
      IPropertyMetadata propMd,
      IEntityFilter filter)
    {
      int num1 = 9;
      IEntityFilter entityFilter;
      Guid guid;
      ListInfo listInfo;
      List<object> values;
      PropertyInfo propertyCached;
      List<object>.Enumerator enumerator;
      EntityWrapper entityWrapper;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (filter == null)
            {
              num1 = 17;
              continue;
            }
            goto case 20;
          case 2:
          case 18:
            listInfo = value as ListInfo;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 7 : 1;
            continue;
          case 3:
            enumerator = listInfo.Objects.GetEnumerator();
            num1 = 24;
            continue;
          case 4:
            entityFilter = EntityPropertyDescriptor.c2hMEmG8W5BtCrjV9Kxs((object) propertyCached, (object) filter, (object) null) as IEntityFilter;
            num1 = 23;
            continue;
          case 5:
            values = new List<object>();
            num1 = 3;
            continue;
          case 6:
            if (listInfo.Objects == null)
            {
              num1 = 21;
              continue;
            }
            goto case 14;
          case 7:
            if (listInfo != null)
            {
              num1 = 6;
              continue;
            }
            goto case 21;
          case 8:
            goto label_36;
          case 9:
            if (value == null)
            {
              num1 = 8;
              continue;
            }
            entityWrapper = value as EntityWrapper;
            num1 = 27;
            continue;
          case 10:
            guid = EntityPropertyDescriptor.UIwJZHGvj6Lhw5mb5cul((object) propMd);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 3 : 26;
            continue;
          case 11:
            if (!EntityPropertyDescriptor.YyoBkKG8BtitO2QpVfHW((object) propertyCached, (object) null))
            {
              num1 = 22;
              continue;
            }
            goto case 4;
          case 12:
            goto label_12;
          case 13:
            if (EntityPropertyDescriptor.BrvVHuGvzKkIvNaD3gOE((object) entityWrapper) == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 2 : 1;
              continue;
            }
            goto case 10;
          case 14:
            if (!listInfo.Objects.Any<object>())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 22 : 28;
              continue;
            }
            goto case 5;
          case 16:
            if (!EntityPropertyDescriptor.sANelSG8ogvv3ZsHfHVE((object) entityFilter))
            {
              num1 = 15;
              continue;
            }
            goto label_12;
          case 19:
label_4:
            guid = EntityPropertyDescriptor.UIwJZHGvj6Lhw5mb5cul((object) propMd);
            num1 = 25;
            continue;
          case 20:
            propertyCached = filter.GetType().GetPropertyCached((string) EntityPropertyDescriptor.ECq12rG8FQAvXj1KWpFG((object) propMd));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 9 : 11;
            continue;
          case 21:
          case 28:
            if (value is SerializableFilter)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
              continue;
            }
            goto label_14;
          case 23:
            if (entityFilter == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
              continue;
            }
            goto case 16;
          case 24:
            try
            {
label_43:
              if (enumerator.MoveNext())
                goto label_45;
              else
                goto label_44;
label_39:
              EntityWrapper current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_4;
                  case 2:
                  case 6:
                  case 7:
                    goto label_43;
                  case 3:
                    if (EntityPropertyDescriptor.BrvVHuGvzKkIvNaD3gOE((object) current) == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 6 : 7;
                      continue;
                    }
                    goto case 5;
                  case 4:
                    goto label_45;
                  case 5:
                    values.Add((object) EntityPropertyDescriptor.OnUYqHGvg6ZOoctmKbHm(EntityPropertyDescriptor.BrvVHuGvzKkIvNaD3gOE((object) current)));
                    num2 = 6;
                    continue;
                  default:
                    if (current == null)
                    {
                      num2 = 2;
                      continue;
                    }
                    goto case 3;
                }
              }
label_44:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 1 : 1;
              goto label_39;
label_45:
              current = enumerator.Current as EntityWrapper;
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
              {
                num2 = 0;
                goto label_39;
              }
              else
                goto label_39;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 25:
            goto label_17;
          case 26:
            goto label_20;
          case 27:
            if (entityWrapper == null)
            {
              num1 = 18;
              continue;
            }
            goto case 13;
          default:
            goto label_13;
        }
      }
label_12:
      return (FilterListItem) null;
label_13:
      throw new FullTextFilterException(EleWise.ELMA.SR.T((string) EntityPropertyDescriptor.L0D824GvLLhC1EYksCmT(979449278 ^ 979566236), (object) EntityPropertyDescriptor.v6jwVDG8bSnaAAYA1cY6((object) propMd), (object) EntityPropertyDescriptor.oMcwwgG8hKWUNewty3C6((object) propMd), (object) propMd.Uid, EntityPropertyDescriptor.ECq12rG8FQAvXj1KWpFG((object) propMd), EntityPropertyDescriptor.L0D824GvLLhC1EYksCmT(979449278 ^ 979564990)));
label_14:
      return (FilterListItem) null;
label_17:
      return new FilterListItem((string) EntityPropertyDescriptor.E3AC8fGvUxmX09tJS8Jv(EntityPropertyDescriptor.zIWGDHGvYJY5OEb69nhF((object) guid.ToString()), EntityPropertyDescriptor.L0D824GvLLhC1EYksCmT(-1998538950 ^ -1998357464)), values, FilterListItemType.Must, FullTextFieldType.Long);
label_20:
      return new FilterListItem(guid.ToString().ToLower() + (string) EntityPropertyDescriptor.L0D824GvLLhC1EYksCmT(~-122002947 ^ 122049808), new List<object>()
      {
        (object) Convert.ToInt64(EntityPropertyDescriptor.BrvVHuGvzKkIvNaD3gOE((object) entityWrapper))
      }, FilterListItemType.Must, FullTextFieldType.Long);
label_36:
      return (FilterListItem) null;
    }

    /// <inheritdoc />
    public override List<string> GetReturnField(IPropertyMetadata propMd) => new List<string>()
    {
      propMd.Uid.ToString().ToLower() + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643607829)
    };

    /// <summary>Восстановление данных полученых из индекса</summary>
    public override void SetIndexField(object obj, object value, IPropertyMetadata propMd)
    {
      int num1 = 13;
      PropertyInfo propertyCached;
      IEntity entity;
      List<IEntity> list;
      while (true)
      {
        int num2 = num1;
        WebDataItem webDataItem;
        EntitySettings entitySettings;
        RelationType relationType;
        int index;
        List<long> source1;
        int result1;
        int result2;
        Type entityType1;
        WebData[] webDataArray;
        int result3;
        Type entityType2;
        IEntityManager entityManager;
        IEntityManager manager;
        while (true)
        {
          switch (num2)
          {
            case 1:
              entityManager = (IEntityManager) EntityPropertyDescriptor.neoyblG88YrniR71Z4ey(entityType1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 36 : 14;
              continue;
            case 2:
              if (manager != null)
              {
                num2 = 38;
                continue;
              }
              goto label_82;
            case 3:
              goto label_21;
            case 4:
            case 28:
              entityType2 = ModelHelper.GetEntityType(EntityPropertyDescriptor.oMcwwgG8hKWUNewty3C6((object) propMd));
              num2 = 29;
              continue;
            case 5:
              entityType1 = ModelHelper.GetEntityType(EntityPropertyDescriptor.oMcwwgG8hKWUNewty3C6((object) propMd));
              num2 = 14;
              continue;
            case 6:
              goto label_57;
            case 7:
              manager = (IEntityManager) EntityPropertyDescriptor.neoyblG88YrniR71Z4ey(entityType2);
              num2 = 2;
              continue;
            case 8:
              source1.Add((long) result1);
              num2 = 45;
              continue;
            case 9:
              goto label_108;
            case 10:
            case 44:
              if (index < webDataArray.Length)
              {
                num2 = 34;
                continue;
              }
              goto case 17;
            case 11:
              goto label_5;
            case 12:
              if (propMd != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 41 : 42;
                continue;
              }
              goto label_88;
            case 13:
              if (obj != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 2 : 12;
                continue;
              }
              goto label_92;
            case 14:
              if (!EntityPropertyDescriptor.DnImPMG8vb4G0A2j6oMZ(entityType1, (Type) null))
              {
                num2 = 6;
                continue;
              }
              goto case 1;
            case 15:
              if (!((string) EntityPropertyDescriptor.fUbZH4G8Ep00vqyEASc9((object) webDataItem) != (string) EntityPropertyDescriptor.zIWGDHGvYJY5OEb69nhF((object) EntityPropertyDescriptor.UIwJZHGvj6Lhw5mb5cul((object) propMd).ToString()) + (string) EntityPropertyDescriptor.L0D824GvLLhC1EYksCmT(-398663332 ^ -398513586)))
              {
                entitySettings = EntityPropertyDescriptor.kNMDx2G8fmZl6R74ryLa((object) propMd) as EntitySettings;
                num2 = 40;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 12 : 33;
              continue;
            case 16:
              index = 0;
              num2 = 10;
              continue;
            case 17:
            case 47:
              IEnumerable<long> source2 = source1.Distinct<long>();
              // ISSUE: reference to a compiler-generated field
              Func<long, long> func = EntityPropertyDescriptor.\u003C\u003Ec.\u003C\u003E9__7_0;
              Func<long, long> keySelector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                EntityPropertyDescriptor.\u003C\u003Ec.\u003C\u003E9__7_0 = keySelector = (Func<long, long>) (i => i);
              }
              else
                goto label_111;
label_110:
              // ISSUE: reference to a compiler-generated method
              list = source2.OrderBy<long, long>(keySelector).Select<long, object>((Func<long, object>) (id => EntityPropertyDescriptor.\u003C\u003Ec__DisplayClass7_0.QfNRNlvj9ZjltNKv2yLi((object) manager, (object) id))).OfType<IEntity>().ToList<IEntity>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
label_111:
              keySelector = func;
              goto label_110;
            case 18:
              if (!int.TryParse((string) EntityPropertyDescriptor.tqE5T1G8CmnfgrLtZWmI((object) webDataItem), out result2))
              {
                num2 = 30;
                continue;
              }
              goto case 5;
            case 19:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 7;
              continue;
            case 20:
            case 34:
              if (!int.TryParse(webDataArray[index].Value, out result3))
              {
                num2 = 39;
                continue;
              }
              goto label_74;
            case 21:
              entity = entityManager.LoadOrNull((object) result2) as IEntity;
              num2 = 32;
              continue;
            case 22:
              if (int.TryParse((string) EntityPropertyDescriptor.tqE5T1G8CmnfgrLtZWmI((object) webDataItem), out result1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 8 : 2;
                continue;
              }
              goto case 45;
            case 23:
              if (relationType == RelationType.OneToOne)
              {
                num2 = 18;
                continue;
              }
              goto case 37;
            case 24:
              goto label_74;
            case 25:
              webDataItem = value as WebDataItem;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 31 : 29;
              continue;
            case 26:
              goto label_73;
            case 27:
              if (webDataItem != null)
              {
                num2 = 15;
                continue;
              }
              goto label_98;
            case 29:
              if (!EntityPropertyDescriptor.DnImPMG8vb4G0A2j6oMZ(entityType2, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 3 : 26;
                continue;
              }
              goto case 19;
            case 30:
              goto label_69;
            case 31:
              if (!EntityPropertyDescriptor.YUHLL5G8Gt0nEmpYJxYb((object) propertyCached, (object) null))
              {
                num2 = 27;
                continue;
              }
              goto label_94;
            case 32:
              goto label_44;
            case 33:
              goto label_12;
            case 35:
            case 39:
              ++index;
              num2 = 44;
              continue;
            case 36:
              if (entityManager != null)
              {
                num2 = 21;
                continue;
              }
              goto label_79;
            case 37:
              if ((uint) (relationType - 1) <= 2U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 28 : 17;
                continue;
              }
              goto label_102;
            case 38:
              source1 = new List<long>();
              num2 = 22;
              continue;
            case 40:
              if (entitySettings != null)
              {
                num2 = 46;
                continue;
              }
              goto label_104;
            case 41:
              goto label_56;
            case 42:
              goto label_58;
            case 43:
              webDataArray = (WebData[]) EntityPropertyDescriptor.vx4NEGG8Iv3x2yAosC1Q((object) webDataItem);
              num2 = 16;
              continue;
            case 45:
              if (EntityPropertyDescriptor.vx4NEGG8Iv3x2yAosC1Q((object) webDataItem) == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 39 : 47;
                continue;
              }
              goto case 43;
            case 46:
              relationType = EntityPropertyDescriptor.hUacvZG8QTqDE43m442H((object) entitySettings);
              num2 = 23;
              continue;
            default:
              goto label_75;
          }
        }
label_58:
        propertyCached = obj.GetType().GetPropertyCached((string) EntityPropertyDescriptor.ECq12rG8FQAvXj1KWpFG((object) propMd));
        num1 = 25;
        continue;
label_74:
        source1.Add((long) result3);
        num1 = 35;
      }
label_12:
      return;
label_21:
      return;
label_57:
      return;
label_108:
      return;
label_5:
      return;
label_73:
      return;
label_69:
      return;
label_56:
      return;
label_98:
      return;
label_102:
      return;
label_94:
      return;
label_104:
      return;
label_44:
      try
      {
        if (entity == null)
          return;
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_50;
            case 1:
              propertyCached.SetValue(obj, (object) entity, (object[]) null);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            default:
              goto label_48;
          }
        }
label_50:
        return;
label_48:
        return;
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_43;
            default:
              EntityPropertyDescriptor.qZsvDaG8uONufyFa6npi(EntityPropertyDescriptor.Jy1cTVG8ZRtTkrTdiGHd(), EntityPropertyDescriptor.L0D824GvLLhC1EYksCmT(825385222 ^ 825338862), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 0;
              continue;
          }
        }
label_43:
        return;
      }
label_82:
      return;
label_79:
      return;
label_92:
      return;
label_75:
      try
      {
        IUntypedCollectionProxy untypedCollectionProxy = (IUntypedCollectionProxy) EntityPropertyDescriptor.bl3i4wG8VADYZBIOiZow(EntityPropertyDescriptor.c2hMEmG8W5BtCrjV9Kxs((object) propertyCached, obj, (object) null));
        int num5 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
          num5 = 3;
        List<IEntity>.Enumerator enumerator;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_33;
            case 2:
              goto label_80;
            case 3:
              if (untypedCollectionProxy == null)
              {
                num5 = 4;
                continue;
              }
              break;
            case 4:
              goto label_23;
          }
          enumerator = list.GetEnumerator();
          num5 = 2;
        }
label_33:
        return;
label_23:
        return;
label_80:
        try
        {
label_86:
          if (enumerator.MoveNext())
            goto label_83;
          else
            goto label_87;
label_81:
          IEntity current;
          int num6;
          while (true)
          {
            switch (num6)
            {
              case 1:
                EntityPropertyDescriptor.nYSoZFG8SG1CdlFmqL8W((object) untypedCollectionProxy, (object) current);
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_30;
              case 3:
                goto label_83;
              default:
                goto label_86;
            }
          }
label_30:
          return;
label_83:
          current = enumerator.Current;
          num6 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
          {
            num6 = 1;
            goto label_81;
          }
          else
            goto label_81;
label_87:
          num6 = 2;
          goto label_81;
        }
        finally
        {
          enumerator.Dispose();
          int num7 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
            num7 = 0;
          switch (num7)
          {
            default:
          }
        }
      }
      catch (Exception ex)
      {
        int num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
          num8 = 0;
        while (true)
        {
          switch (num8)
          {
            case 1:
              goto label_18;
            default:
              EntityPropertyDescriptor.qZsvDaG8uONufyFa6npi(EntityPropertyDescriptor.Jy1cTVG8ZRtTkrTdiGHd(), EntityPropertyDescriptor.L0D824GvLLhC1EYksCmT(-606654180 ^ -606798860), (object) ex);
              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
              continue;
          }
        }
label_18:
        return;
      }
label_88:;
    }

    /// <summary>Получить идентификатор объекта</summary>
    /// <param name="obj">Объект</param>
    internal static long? GetIdValueForEntity(object obj)
    {
      try
      {
        if (obj is IEntity entity)
        {
          object id = entity.GetId();
          if (id != null)
          {
            long result;
            return long.TryParse(id.ToString(), out result) ? new long?(result) : new long?();
          }
        }
        else
        {
          PropertyInfo property = obj.GetType().GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740305782));
          if (property != (PropertyInfo) null)
          {
            object obj1 = property.GetValue(obj, (object[]) null);
            long result;
            return obj1 == null ? new long?() : (long.TryParse(obj1.ToString(), out result) ? new long?(result) : new long?());
          }
        }
      }
      catch (Exception ex)
      {
        return new long?();
      }
      return new long?();
    }

    internal static bool pTGWgDGvMh3EVBsYUFL9() => EntityPropertyDescriptor.gvpkU5GvyJPlvp9pFBco == null;

    internal static EntityPropertyDescriptor QY6WJUGvJaAbfmKWdZLJ() => EntityPropertyDescriptor.gvpkU5GvyJPlvp9pFBco;

    internal static object spkAtDGv9ZhmK4ikUa00([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object mOwB0CGvd6PmqRwWBc85([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static bool x8Oel6Gvlq4kMHcCaHsg([In] object obj0) => ((IEntity) obj0).IsNew();

    internal static object D0X3i9GvrLxu7tmfMaUR([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static long OnUYqHGvg6ZOoctmKbHm([In] object obj0) => Convert.ToInt64(obj0);

    internal static bool dhDiHNGv5OFS64bhVJfT([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static Guid UIwJZHGvj6Lhw5mb5cul([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static object zIWGDHGvYJY5OEb69nhF([In] object obj0) => (object) ((string) obj0).ToLower();

    internal static object L0D824GvLLhC1EYksCmT(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object E3AC8fGvUxmX09tJS8Jv([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static Type kSqPCgGvsjvfQ5kFXyBh([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool ikAgumGvcRsW6C6Ufyyb([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object BrvVHuGvzKkIvNaD3gOE([In] object obj0) => ((EntityWrapper) obj0).Id;

    internal static object ECq12rG8FQAvXj1KWpFG([In] object obj0) => (object) ((IPropertyMetadata) obj0).Name;

    internal static bool YyoBkKG8BtitO2QpVfHW([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static object c2hMEmG8W5BtCrjV9Kxs([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static bool sANelSG8ogvv3ZsHfHVE([In] object obj0) => ((IEntityFilter) obj0).IsEmpty();

    internal static Guid v6jwVDG8bSnaAAYA1cY6([In] object obj0) => ((IPropertyMetadata) obj0).TypeUid;

    internal static Guid oMcwwgG8hKWUNewty3C6([In] object obj0) => ((IPropertyMetadata) obj0).SubTypeUid;

    internal static bool YUHLL5G8Gt0nEmpYJxYb([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static object fUbZH4G8Ep00vqyEASc9([In] object obj0) => (object) ((WebDataItem) obj0).Name;

    internal static object kNMDx2G8fmZl6R74ryLa([In] object obj0) => (object) ((IPropertyMetadata) obj0).Settings;

    internal static RelationType hUacvZG8QTqDE43m442H([In] object obj0) => ((EntitySettings) obj0).RelationType;

    internal static object tqE5T1G8CmnfgrLtZWmI([In] object obj0) => (object) ((WebDataItem) obj0).Value;

    internal static bool DnImPMG8vb4G0A2j6oMZ([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object neoyblG88YrniR71Z4ey(Type entityType) => (object) ModelHelper.GetEntityManagerOrNull(entityType);

    internal static object Jy1cTVG8ZRtTkrTdiGHd() => (object) Logger.Log;

    internal static void qZsvDaG8uONufyFa6npi([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Warn(obj1, (Exception) obj2);

    internal static object vx4NEGG8Iv3x2yAosC1Q([In] object obj0) => (object) ((WebDataItem) obj0).DataArray;

    internal static object bl3i4wG8VADYZBIOiZow([In] object obj0) => (object) obj0.AsUntypedISet();

    internal static void nYSoZFG8SG1CdlFmqL8W([In] object obj0, [In] object obj1) => ((IUntypedCollectionProxy) obj0).Add(obj1);
  }
}
