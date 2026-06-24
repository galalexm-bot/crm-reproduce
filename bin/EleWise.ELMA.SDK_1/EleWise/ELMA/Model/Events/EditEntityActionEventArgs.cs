// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Events.EditEntityActionEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Events
{
  /// <summary>Событие редактирования</summary>
  [Uid("0654B7BC-81E6-4BEC-9227-E529104EB144")]
  public class EditEntityActionEventArgs : EntityActionEventArgs
  {
    public const string EventArgsUid_S = "0654B7BC-81E6-4BEC-9227-E529104EB144";
    public static readonly Guid EventArgsUid;
    private IEnumerable<string> dirtyProperties;
    private byte[] additionalData;
    private IList<PropertyMetadata> changedProperties;
    private static EditEntityActionEventArgs fIgSWkoF4PVh2uwanNRN;

    /// <summary>Ctor</summary>
    /// <param name="entity">Сущность связанная с действием</param>
    /// <param name="objectUid">Уникальный идентификатор объекта действия</param>
    /// <param name="actionUid">Уникальный идентификатор действия</param>
    protected EditEntityActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
    {
      EditEntityActionEventArgs.MytiX8oFAHGkUJyvNx6s();
      // ISSUE: explicit constructor call
      base.\u002Ector(entity, objectUid, actionUid);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.dirtyProperties = (IEnumerable<string>) new string[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="entity">Сущность связанная с действием</param>
    /// <param name="newEntity">Новая сущность</param>
    /// <param name="dirtyProperties">Массив названий измененных свойств</param>
    public EditEntityActionEventArgs(
      IEntity entity,
      IEntity newEntity,
      IEnumerable<string> dirtyProperties)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(entity, newEntity, DefaultEntityActions.UpdateGuid);
      this.dirtyProperties = dirtyProperties;
    }

    /// <summary>Ctor</summary>
    /// <param name="entity">Сущность связанная с действием</param>
    /// <param name="newEntity">Новая сущность</param>
    /// <param name="actionUid">Уникальный идентификатор действия</param>
    public EditEntityActionEventArgs(IEntity entity, IEntity newEntity, Guid actionUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(entity, newEntity, actionUid);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.dirtyProperties = (IEnumerable<string>) new string[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Попытаться создать параметры события. Если не удалось найти объект или действие, то возвращается null.
    /// </summary>
    /// <param name="old">Старая сущность (до изменения)</param>
    /// <param name="new">Новая сущность (после изменения)</param>
    /// <param name="dirtyProperties">Массив названий измененных свойств</param>
    /// <returns>Параметры события или null.</returns>
    public static EditEntityActionEventArgs TryCreate(
      IEntity old,
      IEntity @new,
      string[] dirtyProperties)
    {
      EditEntityActionEventArgs entityActionEventArgs1;
      switch (1)
      {
        case 1:
          try
          {
            EditEntityActionEventArgs entityActionEventArgs2 = new EditEntityActionEventArgs(old, @new, (IEnumerable<string>) dirtyProperties);
            int num = 5;
            while (true)
            {
              switch (num)
              {
                case 1:
                case 3:
                  goto label_1;
                case 2:
                  entityActionEventArgs1 = entityActionEventArgs2;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 1;
                  continue;
                case 4:
                  entityActionEventArgs1 = (EditEntityActionEventArgs) null;
                  num = 3;
                  continue;
                case 5:
                  if (entityActionEventArgs2.Action != null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
                    continue;
                  }
                  goto case 4;
                default:
                  if (EditEntityActionEventArgs.fJb2JeoF7Wu4RDZBEvEv((object) entityActionEventArgs2) == null)
                  {
                    num = 4;
                    continue;
                  }
                  goto case 2;
              }
            }
          }
          catch
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                default:
                  entityActionEventArgs1 = (EditEntityActionEventArgs) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
                  continue;
              }
            }
          }
      }
label_1:
      return entityActionEventArgs1;
    }

    public IList<PropertyMetadata> ChangedProperties
    {
      get
      {
        if (this.changedProperties == null)
          this.GetAdditionalData();
        return this.changedProperties;
      }
    }

    public override byte[] GetAdditionalData()
    {
      int num1 = 13;
      byte[] additionalData;
      while (true)
      {
        IMetadataRuntimeService serviceNotNull;
        Collection<PropertyCompareData> collection;
        ClassMetadata metadata;
        List<PropertyMetadata>.Enumerator enumerator;
        switch (num1)
        {
          case 2:
            goto label_7;
          case 3:
            enumerator = metadata.Properties.GetEnumerator();
            num1 = 10;
            continue;
          case 4:
            if (this.Old != null)
            {
              num1 = 8;
              continue;
            }
            break;
          case 5:
            this.changedProperties = (IList<PropertyMetadata>) new List<PropertyMetadata>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 9;
            continue;
          case 6:
            metadata = MetadataLoader.LoadMetadata(EditEntityActionEventArgs.iPTo01oF0oZpZrlkNyQM((object) this).GetType()) as ClassMetadata;
            num1 = 11;
            continue;
          case 7:
            goto label_13;
          case 8:
            if (EditEntityActionEventArgs.FZyQV0oFxTxj6XUdwORK((object) this) == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
              continue;
            }
            goto case 14;
          case 9:
            serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
            num1 = 4;
            continue;
          case 10:
            try
            {
label_20:
              if (enumerator.MoveNext())
                goto label_28;
              else
                goto label_21;
label_16:
              PropertyMetadata current;
              PropertyCompareData compareData;
              TypeDescriptor typeDescriptor;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    typeDescriptor = serviceNotNull.GetTypeDescriptor(EditEntityActionEventArgs.M6IudcoFytMkoFrR2KRM((object) current), current.SubTypeUid) as TypeDescriptor;
                    num2 = 4;
                    continue;
                  case 2:
                  case 6:
                    goto label_20;
                  case 3:
                    goto label_14;
                  case 4:
                    if (typeDescriptor != null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 5;
                      continue;
                    }
                    goto label_20;
                  case 5:
                    compareData = typeDescriptor.GetCompareData(EditEntityActionEventArgs.iPTo01oF0oZpZrlkNyQM((object) this), (object) this.New, metadata, current);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 10 : 8;
                    continue;
                  case 7:
                    if (!this.dirtyProperties.Contains<string>((string) EditEntityActionEventArgs.pn3BZxoFmJ9PN0RP2rpN((object) current)))
                    {
                      num2 = 2;
                      continue;
                    }
                    goto case 1;
                  case 8:
                    collection.Add(compareData);
                    num2 = 6;
                    continue;
                  case 9:
                    goto label_28;
                  case 10:
                    if (!EleWise.ELMA.Extensions.CollectionExtensions.ByteArrayCompare((byte[]) EditEntityActionEventArgs.BnhyH3oFM2Jq6LSM4KR7((object) compareData), (byte[]) EditEntityActionEventArgs.mgEVUAoFJjOgeqJknM7C((object) compareData)))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_20;
                  default:
                    this.changedProperties.Add(current);
                    num2 = 8;
                    continue;
                }
              }
label_21:
              num2 = 3;
              goto label_16;
label_28:
              current = enumerator.Current;
              num2 = 7;
              goto label_16;
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 11:
            if (metadata != null)
            {
              num1 = 3;
              continue;
            }
            break;
          case 12:
            collection = new Collection<PropertyCompareData>();
            num1 = 5;
            continue;
          case 13:
            if (this.additionalData == null)
            {
              num1 = 12;
              continue;
            }
            goto label_7;
          case 14:
            if (EditEntityActionEventArgs.iPTo01oF0oZpZrlkNyQM((object) this) != EditEntityActionEventArgs.FZyQV0oFxTxj6XUdwORK((object) this))
            {
              num1 = 6;
              continue;
            }
            break;
        }
label_14:
        this.additionalData = additionalData = (byte[]) EditEntityActionEventArgs.CHMF54oF957cV7W0kBn8((object) collection);
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 7 : 7;
      }
label_7:
      return this.additionalData;
label_13:
      return additionalData;
    }

    public override void SetAdditionalData(byte[] data)
    {
      int num1 = 26;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IEntity entity1;
          ClassMetadata metadata1;
          IEntity entity2;
          ClassMetadata metadata2;
          List<PropertyMetadata>.Enumerator enumerator1;
          IEntity entity3;
          IMetadataRuntimeService serviceNotNull;
          IEnumerator<PropertyCompareData> enumerator2;
          Collection<PropertyCompareData> collection;
          object obj1;
          switch (num2)
          {
            case 1:
              collection = (Collection<PropertyCompareData>) EditEntityActionEventArgs.pqxT6loFdl2PK3A9s3Nc((object) data);
              num2 = 21;
              continue;
            case 2:
            case 12:
            case 15:
label_22:
              EditEntityActionEventArgs.bhCiyQoFUpm0hZC3RORB((object) this, (object) entity1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 6 : 3;
              continue;
            case 3:
              try
              {
label_10:
                if (enumerator1.MoveNext())
                  goto label_16;
                else
                  goto label_11;
label_9:
                TypeDescriptor typeDescriptor;
                PropertyMetadata current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      typeDescriptor = serviceNotNull.GetTypeDescriptor(EditEntityActionEventArgs.M6IudcoFytMkoFrR2KRM((object) current), EditEntityActionEventArgs.i4uo4joFr0KsuKh85ZJk((object) current)) as TypeDescriptor;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_76;
                    case 3:
                      goto label_16;
                    case 4:
                    case 5:
                      goto label_10;
                    case 6:
                      typeDescriptor.Copy((object) entity3, (object) entity1, metadata1, current);
                      num3 = 4;
                      continue;
                    default:
                      if (typeDescriptor == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 5 : 3;
                        continue;
                      }
                      goto case 6;
                  }
                }
label_11:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 2;
                goto label_9;
label_16:
                current = enumerator1.Current;
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
                {
                  num3 = 1;
                  goto label_9;
                }
                else
                  goto label_9;
              }
              finally
              {
                enumerator1.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 4:
              metadata1 = MetadataLoader.LoadMetadata(entity1.GetType()) as ClassMetadata;
              num2 = 18;
              continue;
            case 5:
              try
              {
label_34:
                if (EditEntityActionEventArgs.S2uvCnoFYwbd6jiXCkRD((object) enumerator2))
                  goto label_29;
                else
                  goto label_35;
label_27:
                PropertyCompareData current;
                int num5;
                while (true)
                {
                  int num6;
                  PropertyMetadata propertyMetadata;
                  TypeDescriptor typeDescriptor;
                  PropertyCompareData cmp;
                  switch (num5)
                  {
                    case 1:
                      if (EditEntityActionEventArgs.zEsMZ5oFjGpN0EPE7u8a(EditEntityActionEventArgs.BnhyH3oFM2Jq6LSM4KR7((object) current), EditEntityActionEventArgs.mgEVUAoFJjOgeqJknM7C((object) current)))
                      {
                        num6 = 5;
                        break;
                      }
                      goto case 15;
                    case 2:
                    case 3:
                    case 7:
                    case 10:
                      goto label_34;
                    case 4:
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 5 : 8;
                      continue;
                    case 5:
                    case 14:
                      typeDescriptor.SetCompareData((object) entity1, (object) entity2, metadata1, propertyMetadata, current);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 6 : 7;
                      continue;
                    case 6:
                      goto label_22;
                    case 8:
                      if (current == null)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 2 : 0;
                        continue;
                      }
                      goto case 12;
                    case 9:
                      typeDescriptor = serviceNotNull.GetTypeDescriptor(EditEntityActionEventArgs.M6IudcoFytMkoFrR2KRM((object) propertyMetadata), EditEntityActionEventArgs.i4uo4joFr0KsuKh85ZJk((object) propertyMetadata)) as TypeDescriptor;
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
                      continue;
                    case 11:
                      if (propertyMetadata == null)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 3 : 1;
                        continue;
                      }
                      goto case 9;
                    case 12:
                      cmp = current;
                      num5 = 13;
                      continue;
                    case 13:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      propertyMetadata = metadata1.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => EditEntityActionEventArgs.\u003C\u003Ec__DisplayClass12_0.aZCdRwCW9CTo6CbWIleN(EditEntityActionEventArgs.\u003C\u003Ec__DisplayClass12_0.FHLnoNCWMPh8kUCNpGuk((object) p), EditEntityActionEventArgs.\u003C\u003Ec__DisplayClass12_0.CiwMSwCWJjVpi7CJHNlG((object) cmp))));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 6 : 11;
                      continue;
                    case 15:
                      this.changedProperties.Add(propertyMetadata);
                      num6 = 14;
                      break;
                    case 16:
                      goto label_29;
                    default:
                      if (typeDescriptor == null)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 7 : 10;
                        continue;
                      }
                      goto case 1;
                  }
                  num5 = num6;
                }
label_29:
                current = enumerator2.Current;
                num5 = 4;
                goto label_27;
label_35:
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 3 : 6;
                goto label_27;
              }
              finally
              {
                int num7;
                if (enumerator2 == null)
                  num7 = 2;
                else
                  goto label_48;
label_47:
                switch (num7)
                {
                  case 1:
                    break;
                  default:
                }
label_48:
                EditEntityActionEventArgs.DjoOSeoFLBScJA8qjBPs((object) enumerator2);
                num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
                {
                  num7 = 0;
                  goto label_47;
                }
                else
                  goto label_47;
              }
            case 6:
              this.New = entity2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 6 : 11;
              continue;
            case 7:
              this.additionalData = data;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
              continue;
            case 8:
              try
              {
label_64:
                if (enumerator1.MoveNext())
                  goto label_62;
                else
                  goto label_65;
label_61:
                PropertyMetadata current;
                int num8;
                while (true)
                {
                  TypeDescriptor fgSm9OzrAtmXc;
                  switch (num8)
                  {
                    case 1:
                      goto label_77;
                    case 2:
                      if (fgSm9OzrAtmXc == null)
                      {
                        num8 = 3;
                        continue;
                      }
                      break;
                    case 3:
                    case 5:
                      goto label_64;
                    case 4:
                      fgSm9OzrAtmXc = EditEntityActionEventArgs.o3FRWToFgSm9OZrATmXc((object) serviceNotNull, EditEntityActionEventArgs.M6IudcoFytMkoFrR2KRM((object) current), EditEntityActionEventArgs.i4uo4joFr0KsuKh85ZJk((object) current)) as TypeDescriptor;
                      num8 = 2;
                      continue;
                    case 6:
                      goto label_62;
                  }
                  fgSm9OzrAtmXc.Copy((object) entity3, (object) entity2, metadata2, current);
                  num8 = 5;
                }
label_62:
                current = enumerator1.Current;
                num8 = 4;
                goto label_61;
label_65:
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 1;
                goto label_61;
              }
              finally
              {
                enumerator1.Dispose();
                int num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
                  num9 = 0;
                switch (num9)
                {
                  default:
                }
              }
            case 9:
              obj1 = EditEntityActionEventArgs.iPTo01oF0oZpZrlkNyQM((object) this);
              break;
            case 10:
              object obj2 = EditEntityActionEventArgs.FZyQV0oFxTxj6XUdwORK((object) this);
              if (obj2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 9 : 7;
                continue;
              }
              obj1 = obj2;
              break;
            case 11:
              goto label_73;
            case 13:
              enumerator1 = metadata1.Properties.GetEnumerator();
              num2 = 3;
              continue;
            case 14:
              enumerator2 = collection.GetEnumerator();
              num2 = 5;
              continue;
            case 16:
              enumerator1 = metadata2.Properties.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 8 : 3;
              continue;
            case 17:
              entity1 = (IEntity) EditEntityActionEventArgs.sG9O0hoFlYyhjpR42GC8(entity3.GetType());
              num2 = 22;
              continue;
            case 18:
              metadata2 = MetadataLoader.LoadMetadata(entity2.GetType()) as ClassMetadata;
              num2 = 19;
              continue;
            case 19:
              if (metadata1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 15 : 12;
                continue;
              }
              goto case 23;
            case 20:
label_77:
              EditEntityActionEventArgs.Jsond6oF5g982iE0nyyu((object) entity2, entity3.GetId());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 14;
              continue;
            case 21:
              this.changedProperties = (IList<PropertyMetadata>) new List<PropertyMetadata>();
              num2 = 24;
              continue;
            case 22:
              entity2 = (IEntity) InterfaceActivator.Create(entity3.GetType());
              num2 = 4;
              continue;
            case 23:
              if (metadata2 != null)
                goto case 13;
              else
                goto label_53;
            case 24:
              serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
              num2 = 10;
              continue;
            case 25:
              goto label_69;
            case 26:
              if (data == null)
              {
                num2 = 25;
                continue;
              }
              goto case 7;
            default:
label_76:
              entity1.SetId(entity3.GetId());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 4 : 16;
              continue;
          }
          entity3 = (IEntity) obj1;
          num2 = 17;
        }
label_53:
        num1 = 12;
      }
label_73:
      return;
label_69:;
    }

    /// <summary>Отметить свойства как изменённые</summary>
    /// <param name="propertyNames">Названия свойств</param>
    public void SetPropertyDirty(string[] propertyNames)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.dirtyProperties = this.dirtyProperties.Union<string>((IEnumerable<string>) propertyNames).Distinct<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    static EditEntityActionEventArgs()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EditEntityActionEventArgs.EventArgsUid = new Guid((string) EditEntityActionEventArgs.PZoRX0oFsa8Z3VK3aTTc(1021410165 ^ 1021525367));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          case 2:
            EditEntityActionEventArgs.MytiX8oFAHGkUJyvNx6s();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void MytiX8oFAHGkUJyvNx6s() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool u8Y3g8oF6HJq6C4SdRLl() => EditEntityActionEventArgs.fIgSWkoF4PVh2uwanNRN == null;

    internal static EditEntityActionEventArgs xeQ6YroFHihRD715JTtp() => EditEntityActionEventArgs.fIgSWkoF4PVh2uwanNRN;

    internal static object fJb2JeoF7Wu4RDZBEvEv([In] object obj0) => (object) ((AuditEventArgs) obj0).Object;

    internal static object FZyQV0oFxTxj6XUdwORK([In] object obj0) => (object) ((EntityActionEventArgs) obj0).New;

    internal static object iPTo01oF0oZpZrlkNyQM([In] object obj0) => (object) ((EntityActionEventArgs) obj0).Old;

    internal static object pn3BZxoFmJ9PN0RP2rpN([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static Guid M6IudcoFytMkoFrR2KRM([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static object BnhyH3oFM2Jq6LSM4KR7([In] object obj0) => (object) ((PropertyCompareData) obj0).OldPropertyData;

    internal static object mgEVUAoFJjOgeqJknM7C([In] object obj0) => (object) ((PropertyCompareData) obj0).NewPropertyData;

    internal static object CHMF54oF957cV7W0kBn8([In] object obj0) => (object) ClassSerializationHelper.SerializeObject(obj0);

    internal static object pqxT6loFdl2PK3A9s3Nc([In] object obj0) => ClassSerializationHelper.DeserializeObject((byte[]) obj0);

    internal static object sG9O0hoFlYyhjpR42GC8(Type t) => InterfaceActivator.Create(t);

    internal static Guid i4uo4joFr0KsuKh85ZJk([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static object o3FRWToFgSm9OZrATmXc([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static void Jsond6oF5g982iE0nyyu([In] object obj0, [In] object obj1) => ((IIdentified) obj0).SetId(obj1);

    internal static bool zEsMZ5oFjGpN0EPE7u8a([In] object obj0, [In] object obj1) => EleWise.ELMA.Extensions.CollectionExtensions.ByteArrayCompare((byte[]) obj0, (byte[]) obj1);

    internal static bool S2uvCnoFYwbd6jiXCkRD([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void DjoOSeoFLBScJA8qjBPs([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void bhCiyQoFUpm0hZC3RORB([In] object obj0, [In] object obj1) => ((EntityActionEventArgs) obj0).Old = (IEntity) obj1;

    internal static object PZoRX0oFsa8Z3VK3aTTc(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
