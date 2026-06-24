// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityReferences.ReferenceOnEntity
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Entities.EntityReferences
{
  /// <summary>Тип сылка на сущность</summary>
  [XmlRoot("ReferenceOnEntity")]
  [Component]
  [TypeConverter(typeof (ReferenceOnEntityConverter))]
  [Serializable]
  public sealed class ReferenceOnEntity : IXsiType
  {
    /// <summary>Разделитель данных при сериализации</summary>
    public static string Delimiter;
    private long? objectId;
    private Guid objectUid;
    [XmlIgnore]
    [NonSerialized]
    private IEntity _object;
    internal static ReferenceOnEntity bVFAeYhIthv1g5NCiXt0;

    /// <summary>Конструктор</summary>
    public ReferenceOnEntity()
    {
      ReferenceOnEntity.FRuSmPhI6wDtuPFpTgus();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Конструктор</summary>
    /// <param name="object">Объект</param>
    public ReferenceOnEntity(IEntity @object)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Object = @object;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Конструктор</summary>
    /// <param name="objectId">Идентификатор объекта</param>
    /// <param name="objectTypeUId">Уникальный идентификатор типа объекта</param>
    public ReferenceOnEntity(long objectId, Guid objectTypeUId)
    {
      ReferenceOnEntity.FRuSmPhI6wDtuPFpTgus();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ObjectTypeUId = objectTypeUId;
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.ObjectId = objectId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Конструктор</summary>
    /// <param name="objectUid">Уникальный идентификатор объекта</param>
    /// <param name="objectTypeUId">Уникальный идентификатор типа объекта</param>
    public ReferenceOnEntity(Guid objectUid, Guid objectTypeUId)
    {
      ReferenceOnEntity.FRuSmPhI6wDtuPFpTgus();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.objectUid = objectUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          default:
            this.ObjectTypeUId = objectTypeUId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Конструктор</summary>
    /// <param name="stringValue">Сериализованное выражение объекта в виде строки Id;TypeUid</param>
    public ReferenceOnEntity(string stringValue)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
        num = 1;
      Guid result1;
      string[] strArray;
      long result2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ReferenceOnEntity.fyltnahIHipFIkj1EAw3((object) stringValue))
            {
              num = 5;
              continue;
            }
            goto label_8;
          case 2:
          case 6:
          case 14:
            goto label_17;
          case 3:
            this.ObjectTypeUId = result1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 10 : 13;
            continue;
          case 4:
            if (strArray.Length < 2)
            {
              num = 6;
              continue;
            }
            goto case 10;
          case 5:
            strArray = (string[]) ReferenceOnEntity.ST3XyAhI7NRP2m4yWckd((object) stringValue, (object) new string[1]
            {
              ReferenceOnEntity.Delimiter
            }, StringSplitOptions.RemoveEmptyEntries);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 4 : 1;
            continue;
          case 7:
            goto label_13;
          case 8:
            if (!long.TryParse(strArray[1], out result2))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 9:
            if (Guid.TryParse(strArray[0], out result1))
            {
              num = 8;
              continue;
            }
            goto label_10;
          case 10:
            if (ReferenceOnEntity.fyltnahIHipFIkj1EAw3((object) strArray[0]))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 2;
              continue;
            }
            goto case 11;
          case 11:
            if (!ReferenceOnEntity.fyltnahIHipFIkj1EAw3((object) strArray[1]))
            {
              num = 9;
              continue;
            }
            goto label_17;
          case 12:
            goto label_8;
          case 13:
            this.ObjectId = result2;
            num = 7;
            continue;
          default:
            goto label_10;
        }
      }
label_13:
      return;
label_8:
      throw new ArgumentNullException((string) ReferenceOnEntity.KyF2blhIAdgqlMns1h8N(-70007027 ^ -70220551));
label_10:
      throw new ArgumentException((string) ReferenceOnEntity.MyUMbthIxXNEXVKSldob(ReferenceOnEntity.KyF2blhIAdgqlMns1h8N(1917998801 >> 2 ^ 479711674)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859067307));
label_17:
      throw new ArgumentOutOfRangeException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218545574));
    }

    /// <summary>Идентификатор объекта сущности</summary>
    [XmlElement("ObjectId")]
    public long ObjectId
    {
      get
      {
        int num = 8;
        IEntity entity;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 4:
            case 5:
              if (this.objectId.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
                continue;
              }
              goto label_13;
            case 2:
              this.Object = entity;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 3 : 5;
              continue;
            case 3:
              entity = ((IEntityManager) ReferenceOnEntity.fDoKVrhI0uZceZPMVYcf(ModelHelper.GetEntityType(this.ObjectTypeUId))).LoadOrNull(this.objectUid) as IEntity;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 6 : 6;
              continue;
            case 6:
              if (entity == null)
              {
                num = 4;
                continue;
              }
              goto case 2;
            case 7:
              if (!(this.objectUid != Guid.Empty))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 0;
                continue;
              }
              goto case 3;
            case 8:
              if (!this.objectId.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 5 : 7;
                continue;
              }
              goto case 1;
            default:
              goto label_12;
          }
        }
label_12:
        return this.objectId.Value;
label_13:
        return 0;
      }
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.objectId = new long?(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Уникальный идентификатор объекта</summary>
    public Guid ObjectUid
    {
      get => this.objectUid;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.objectUid = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Идентификатор типа сущности</summary>
    [XmlElement("ObjectTypeUId")]
    public Guid ObjectTypeUId
    {
      get => this.\u003CObjectTypeUId\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CObjectTypeUId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Тип объекта</summary>
    [XmlIgnore]
    public Type ObjectType
    {
      get
      {
        int num1 = 3;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_13;
            case 2:
              num1 = 4;
              continue;
            case 3:
              if (!ReferenceOnEntity.U8XvsShImeNlCN2SQeOj(this.ObjectTypeUId, Guid.Empty))
              {
                num1 = 2;
                continue;
              }
              goto label_2;
            case 4:
              goto label_6;
            default:
              goto label_2;
          }
        }
label_2:
        return (Type) null;
label_6:
        Type objectType;
        try
        {
          objectType = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(this.ObjectTypeUId);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
            num2 = 0;
          switch (num2)
          {
          }
        }
        catch (Exception ex)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                objectType = (Type) null;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
                continue;
              default:
                goto label_13;
            }
          }
        }
label_13:
        return objectType;
      }
      set
      {
        int num1 = 2;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_17;
            case 1:
              goto label_5;
            case 2:
              if (ReferenceOnEntity.tcAGifhIy1kYcqbGEmHE(value, (Type) null))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
                continue;
              }
              goto label_16;
            default:
              goto label_12;
          }
        }
label_17:
        return;
label_12:
        return;
label_16:
        return;
label_5:
        try
        {
          IMetadata metadata = MetadataLoader.LoadMetadata(value);
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
            num2 = 0;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_8;
              case 2:
                this.ObjectTypeUId = ReferenceOnEntity.qtXOPOhIMjSyBQv6Xmcc((object) metadata);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 1;
                continue;
              default:
                if (metadata != null)
                {
                  num2 = 2;
                  continue;
                }
                goto label_2;
            }
          }
label_8:
          return;
label_2:;
        }
        catch (Exception ex)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
            num3 = 0;
          switch (num3)
          {
          }
        }
      }
    }

    /// <summary>Объект</summary>
    [XmlIgnore]
    public IEntity Object
    {
      get
      {
        int num1 = 10;
        Type objectType;
        IEntityManager manager;
        ReferenceOnEntity referenceOnEntity;
        while (true)
        {
          switch (num1)
          {
            case 1:
              referenceOnEntity = this;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 5;
              continue;
            case 2:
              goto label_6;
            case 3:
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
              continue;
            case 4:
            case 9:
              goto label_2;
            case 5:
              objectType = this.ObjectType;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 8;
              continue;
            case 6:
              goto label_24;
            case 7:
              if (this.ObjectId > 0L)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
                continue;
              }
              goto label_24;
            case 8:
              if (!(objectType == (Type) null))
              {
                num1 = 7;
                continue;
              }
              goto label_24;
            case 10:
              if (this._object != null)
              {
                num1 = 9;
                continue;
              }
              goto case 3;
            default:
              manager = ModelHelper.GetEntityManager(objectType);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 2;
              continue;
          }
        }
label_2:
        return this._object;
label_6:
        try
        {
          ISecurityService service = Locator.GetService<ISecurityService>();
          int num2 = 4;
          Filter filter;
          while (true)
          {
            switch (num2)
            {
              case 2:
                ReferenceOnEntity.oRpRVEhI9HqpXV8L0Zxv((object) filter, (object) this.ObjectId);
                num2 = 7;
                continue;
              case 3:
              case 8:
                goto label_2;
              case 4:
                if (service == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
                  continue;
                }
                goto case 5;
              case 5:
                service.RunWithElevatedPrivilegiesAndWithDeleted((System.Action) (() =>
                {
                  int num3 = 1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        referenceOnEntity._object = (IEntity) ReferenceOnEntity.\u003C\u003Ec__DisplayClass23_0.bjCy0vvFoW2k1v0DZiWQ((object) manager, (object) referenceOnEntity.ObjectId);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                }));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 3;
                continue;
              case 6:
                ReferenceOnEntity.MglxP5hIJnu1mQLYqlGa((object) filter, true);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 2;
                continue;
              case 7:
                this._object = ((IEnumerable<IEntity>) ReferenceOnEntity.AkX1TDhIdw5h6Ypq2Pr7((object) manager, (object) filter, (object) new FetchOptions(0, 1))).FirstOrDefault<IEntity>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 8 : 8;
                continue;
              case 9:
                filter.DisableSecurity = true;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 6 : 1;
                continue;
              default:
                filter = new Filter();
                num2 = 9;
                continue;
            }
          }
        }
        catch (SecurityException ex)
        {
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                this._object = (IEntity) null;
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
                continue;
              default:
                goto label_2;
            }
          }
        }
label_24:
        return (IEntity) null;
      }
      set
      {
        int num1 = 8;
        while (true)
        {
          int num2 = num1;
          IEntity entity;
          PropertyInfo property;
          while (true)
          {
            switch (num2)
            {
              case 1:
                if (!ReferenceOnEntity.xC6joPhIl6YvSXZygq3m((object) property, (object) null))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
                  continue;
                }
                goto case 4;
              case 2:
                goto label_6;
              case 3:
                property = entity.GetType().GetProperty((string) ReferenceOnEntity.KyF2blhIAdgqlMns1h8N(322893104 - -1992822529 ^ -1979218577));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
                continue;
              case 4:
                this.ObjectId = ReferenceOnEntity.EZ6BXyhIgBr0rOFFAv8B(ReferenceOnEntity.PXE7tOhIruNrhtn9cspq((object) property, (object) value, (object) null));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 6;
                continue;
              case 5:
                this.ObjectType = entity.GetType();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 3 : 3;
                continue;
              case 7:
                entity = value.CastAsRealType<IEntity>();
                num2 = 5;
                continue;
              case 8:
                goto label_12;
              default:
                this._object = (IEntity) null;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 2;
                continue;
            }
          }
label_12:
          if (value != null)
            num1 = 7;
          else
            goto label_3;
        }
label_6:
        return;
label_3:;
      }
    }

    /// <summary>Отображаемое имя типа объекта</summary>
    [XmlIgnore]
    public string ObjectDispalyName
    {
      get
      {
        int num1 = 2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_6;
            case 2:
              if (ReferenceOnEntity.tcAGifhIy1kYcqbGEmHE(this.ObjectType, (Type) null))
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return "";
label_6:
        string objectDispalyName;
        try
        {
          ClassMetadata classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(this.ObjectType);
          int num2 = 3;
          while (true)
          {
            switch (num2)
            {
              case 1:
                objectDispalyName = (string) ReferenceOnEntity.DXk8VmhI5dpZ2MTnkRCR((object) classMetadata);
                num2 = 2;
                continue;
              case 2:
                goto label_3;
              case 3:
                if (classMetadata == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 4;
                  continue;
                }
                goto case 1;
              default:
                goto label_2;
            }
          }
        }
        catch (Exception ex)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
            num3 = 0;
          switch (num3)
          {
            default:
              goto label_2;
          }
        }
label_3:
        return objectDispalyName;
      }
    }

    public static ReferenceOnEntity Create(Type type, long id)
    {
      ReferenceOnEntity referenceOnEntity = new ReferenceOnEntity();
      ReferenceOnEntity.BqvLYlhIjOhKQ7hSFBmU((object) referenceOnEntity, type);
      ReferenceOnEntity.xTo8SchIYF6DmaLG3gQ2((object) referenceOnEntity, id);
      return referenceOnEntity;
    }

    public static ReferenceOnEntity Create(Guid typeUid, long id)
    {
      ReferenceOnEntity referenceOnEntity = new ReferenceOnEntity();
      ReferenceOnEntity.kFJCg1hILj4jqlInPfFa((object) referenceOnEntity, typeUid);
      ReferenceOnEntity.xTo8SchIYF6DmaLG3gQ2((object) referenceOnEntity, id);
      return referenceOnEntity;
    }

    public static ReferenceOnEntity Create(IEntity obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (ReferenceOnEntity) null;
label_3:
      ReferenceOnEntity referenceOnEntity = new ReferenceOnEntity();
      ReferenceOnEntity.oePrlJhIUT0RCxhxJT6I((object) referenceOnEntity, (object) obj);
      return referenceOnEntity;
    }

    public bool Equals(ReferenceOnEntity other)
    {
      int num1 = 2;
      Guid objectTypeUid;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this == other)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 3 : 3;
                continue;
              }
              goto label_4;
            case 2:
              if (other != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
                continue;
              }
              goto label_6;
            case 3:
              goto label_3;
            case 4:
              goto label_6;
            case 5:
              objectTypeUid = other.ObjectTypeUId;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
              continue;
            default:
              goto label_9;
          }
        }
label_4:
        if (ReferenceOnEntity.f1JcJihIsN76kHSuVXEx((object) other) == this.ObjectId)
          num1 = 5;
        else
          goto label_10;
      }
label_3:
      return true;
label_6:
      return false;
label_9:
      return objectTypeUid.Equals(this.ObjectTypeUId);
label_10:
      return false;
    }

    public override bool Equals(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            goto label_8;
          case 3:
            goto label_5;
          case 4:
            goto label_2;
          default:
            if (this != obj)
            {
              // ISSUE: type reference
              if (ReferenceOnEntity.tcAGifhIy1kYcqbGEmHE(obj.GetType(), ReferenceOnEntity.r3J6VVhIc8IsYQLw44Qc(__typeref (ReferenceOnEntity))))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 2 : 1;
                continue;
              }
              goto label_9;
            }
            else
            {
              num = 4;
              continue;
            }
        }
      }
label_2:
      return true;
label_5:
      return false;
label_8:
      return false;
label_9:
      return this.Equals((ReferenceOnEntity) obj);
    }

    /// <summary>Преобразует в строку</summary>
    /// <returns></returns>
    public override string ToString() => (string) ReferenceOnEntity.KT7edmhIzsKxIDir1Rc8((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909275351), (object) this.ObjectTypeUId, (object) ReferenceOnEntity.Delimiter, (object) this.ObjectId);

    /// <summary>Извлекает из строки объект ReferenceOnEntity</summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static ReferenceOnEntity Parse(string value)
    {
      int num = 1;
      ReferenceOnEntity entity;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ReferenceOnEntity.TryParse(value, out entity))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      throw new Exception((string) ReferenceOnEntity.KyF2blhIAdgqlMns1h8N(1232639661 >> 3 ^ 153900729));
label_3:
      return entity;
    }

    /// <summary>Извлекает из строки объект ReferenceOnEntity</summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static bool TryParse(string value, out ReferenceOnEntity entity)
    {
      int num = 6;
      Guid result1;
      string[] strArray;
      long result2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            if (long.TryParse(strArray[1], out result2))
            {
              num = 3;
              continue;
            }
            goto label_7;
          case 3:
            entity = new ReferenceOnEntity(result2, result1);
            num = 10;
            continue;
          case 4:
            goto label_2;
          case 5:
            strArray = (string[]) ReferenceOnEntity.Ro26HWhVFeTKIaD2dTen((object) value, (object) new char[1]
            {
              ';'
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 4 : 9;
            continue;
          case 6:
            entity = (ReferenceOnEntity) null;
            num = 5;
            continue;
          case 7:
            goto label_7;
          case 8:
            result1 = Guid.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
            continue;
          case 9:
            if (strArray.Length >= 2)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 8 : 2;
              continue;
            }
            goto label_2;
          case 10:
            goto label_15;
          default:
            if (Guid.TryParse(strArray[0], out result1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 2 : 2;
              continue;
            }
            goto label_11;
        }
      }
label_2:
      return false;
label_7:
      return false;
label_11:
      return false;
label_15:
      return true;
    }

    public override int GetHashCode()
    {
      int num = 1;
      long objectId;
      while (true)
      {
        switch (num)
        {
          case 1:
            objectId = this.ObjectId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return objectId.GetHashCode() * 397 ^ this.ObjectTypeUId.GetHashCode();
    }

    static ReferenceOnEntity()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ReferenceOnEntity.Delimiter = (string) ReferenceOnEntity.KyF2blhIAdgqlMns1h8N(-1978478350 ^ -1978498002);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
            continue;
          case 2:
            ReferenceOnEntity.FRuSmPhI6wDtuPFpTgus();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void FRuSmPhI6wDtuPFpTgus() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool zoZsZthIwKPAUtxyXgRd() => ReferenceOnEntity.bVFAeYhIthv1g5NCiXt0 == null;

    internal static ReferenceOnEntity FGF0phhI4fpOFAeunx9N() => ReferenceOnEntity.bVFAeYhIthv1g5NCiXt0;

    internal static bool fyltnahIHipFIkj1EAw3([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object KyF2blhIAdgqlMns1h8N(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object ST3XyAhI7NRP2m4yWckd([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static object MyUMbthIxXNEXVKSldob([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object fDoKVrhI0uZceZPMVYcf(Type entityType) => (object) ModelHelper.GetEntityManager(entityType);

    internal static bool U8XvsShImeNlCN2SQeOj([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool tcAGifhIy1kYcqbGEmHE([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static Guid qtXOPOhIMjSyBQv6Xmcc([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static void MglxP5hIJnu1mQLYqlGa([In] object obj0, bool value) => ((Filter) obj0).DisableSoftDeletable = value;

    internal static void oRpRVEhI9HqpXV8L0Zxv([In] object obj0, [In] object obj1) => ((Filter) obj0).Id = obj1;

    internal static object AkX1TDhIdw5h6Ypq2Pr7([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((IEntityManager) obj0).Find((IEntityFilter) obj1, (FetchOptions) obj2);

    internal static bool xC6joPhIl6YvSXZygq3m([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static object PXE7tOhIruNrhtn9cspq([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static long EZ6BXyhIgBr0rOFFAv8B([In] object obj0) => Convert.ToInt64(obj0);

    internal static object DXk8VmhI5dpZ2MTnkRCR([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void BqvLYlhIjOhKQ7hSFBmU([In] object obj0, Type value) => ((ReferenceOnEntity) obj0).ObjectType = value;

    internal static void xTo8SchIYF6DmaLG3gQ2([In] object obj0, long value) => ((ReferenceOnEntity) obj0).ObjectId = value;

    internal static void kFJCg1hILj4jqlInPfFa([In] object obj0, Guid value) => ((ReferenceOnEntity) obj0).ObjectTypeUId = value;

    internal static void oePrlJhIUT0RCxhxJT6I([In] object obj0, [In] object obj1) => ((ReferenceOnEntity) obj0).Object = (IEntity) obj1;

    internal static long f1JcJihIsN76kHSuVXEx([In] object obj0) => ((ReferenceOnEntity) obj0).ObjectId;

    internal static Type r3J6VVhIc8IsYQLw44Qc([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object KT7edmhIzsKxIDir1Rc8(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static object Ro26HWhVFeTKIaD2dTen([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);
  }
}
