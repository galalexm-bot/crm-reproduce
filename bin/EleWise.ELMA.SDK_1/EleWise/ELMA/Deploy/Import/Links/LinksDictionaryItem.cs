// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Links.LinksDictionaryItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.Links
{
  /// <summary>
  /// Класс для описания свойства-ссылки импортируемой сущности, для которой еще нет сущности
  /// </summary>
  public class LinksDictionaryItem : ILinksDictionaryItem
  {
    internal static LinksDictionaryItem S2l8ssEJ9EynArkhOt5B;

    public LinksDictionaryItem(
      Guid entityUid,
      Guid entityTypeUid,
      string entityPropertyName,
      Guid linkUid,
      Guid linkPropertyUid)
    {
      LinksDictionaryItem.IMpemJEJrkRIZEwNgwmU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.LinkUid = linkUid;
            num = 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.LinkPropertyUid = linkPropertyUid;
            num = 2;
            continue;
          case 4:
            this.EntityTypeUid = entityTypeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 5 : 4;
            continue;
          case 5:
            this.EntityPropertyName = entityPropertyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 1;
            continue;
          default:
            this.EntityUid = entityUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 4;
            continue;
        }
      }
label_3:;
    }

    public bool UpdateLinkByUid(Guid oldUid, Guid newUid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!LinksDictionaryItem.gpCVHKEJglRNAFwbd7ju(this.LinkUid, oldUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            this.LinkUid = newUid;
            num = 3;
            continue;
          case 3:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_5:
      return true;
label_6:
      return false;
    }

    public bool ContainLink(Guid propertyUidI) => LinksDictionaryItem.gpCVHKEJglRNAFwbd7ju(this.LinkUid, propertyUidI);

    public bool SetLinkValue(IEntity entity, Guid eUid)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        IEntity entityLink;
        EntityMetadata metadataLink;
        Type typeByUidOrNull;
        IEntityManager entityManager;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              goto label_23;
            case 3:
              if (entityLink != null)
              {
                metadataLink = MetadataLoader.LoadMetadata(typeByUidOrNull) as EntityMetadata;
                num2 = 13;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
              continue;
            case 4:
              this.SetLinkValue(entity, metadataLink, entityLink);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 9 : 5;
              continue;
            case 5:
              goto label_19;
            case 6:
              if (entityManager == null)
              {
                num2 = 2;
                continue;
              }
              entityLink = LinksDictionaryItem.tj979gEJYngdvdiI2nNX((object) entityManager, this.EntityUid) as IEntity;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 3 : 0;
              continue;
            case 7:
              goto label_9;
            case 8:
              if (!LinksDictionaryItem.l1YD8yEJ54wVYfWIKCHA(eUid, this.LinkUid))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 7 : 1;
                continue;
              }
              goto label_8;
            case 9:
              ((ISession) LinksDictionaryItem.Gbwby4EJLbWglt1KvYHn((object) Locator.GetServiceNotNull<ISessionProvider>(), (object) "")).Save((object) entityLink);
              num2 = 14;
              continue;
            case 10:
              if (metadataLink.Properties != null)
              {
                num2 = 4;
                continue;
              }
              goto label_25;
            case 11:
              goto label_8;
            case 12:
              goto label_21;
            case 13:
              if (metadataLink != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 10;
                continue;
              }
              goto label_25;
            case 14:
              goto label_16;
            case 15:
              entityManager = ModelHelper.GetEntityManager(typeByUidOrNull);
              num2 = 6;
              continue;
            default:
              goto label_25;
          }
        }
label_9:
        typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(this.EntityTypeUid);
        num1 = 5;
        continue;
label_19:
        if (!LinksDictionaryItem.OJgq3NEJj7v9vU9cYW9k(typeByUidOrNull, (Type) null))
          num1 = 15;
        else
          goto label_21;
      }
label_8:
      return false;
label_10:
      return false;
label_16:
      return true;
label_21:
      return false;
label_23:
      return false;
label_25:
      return false;
    }

    private void SetLinkValue(IEntity entity, EntityMetadata metadataLink, IEntity entityLink)
    {
      int num1 = 7;
      List<TablePartMetadata>.Enumerator enumerator1;
      while (true)
      {
        int num2 = num1;
        IEnumerator<PropertyMetadata> enumerator2;
        while (true)
        {
          PropertyInfo propertyCached1;
          PropertyInfo propertyCached2;
          switch (num2)
          {
            case 1:
              goto label_79;
            case 2:
              goto label_50;
            case 3:
              goto label_46;
            case 4:
              if (entityLink == null)
              {
                num2 = 3;
                continue;
              }
              propertyCached1 = entityLink.GetType().GetPropertyCached(this.EntityPropertyName);
              num2 = 8;
              continue;
            case 5:
              goto label_58;
            case 6:
              if (metadataLink == null)
              {
                num2 = 5;
                continue;
              }
              goto case 4;
            case 7:
              if (entity != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 6 : 6;
                continue;
              }
              goto label_62;
            case 8:
              propertyCached2 = entityLink.GetType().GetPropertyCached((string) LinksDictionaryItem.C8uanKEJUYtk9cZ3p8fv(-35995181 ^ -36000191));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 6 : 9;
              continue;
            case 9:
              goto label_47;
            case 10:
              try
              {
label_37:
                if (LinksDictionaryItem.wf8chsE9o3PMnYCq04eo((object) enumerator2))
                  goto label_32;
                else
                  goto label_38;
label_8:
                EntitySettings settings;
                int num3;
                while (true)
                {
                  int num4;
                  object obj1;
                  RelationType relationType;
                  IEnumerable enumerable;
                  object obj2;
                  switch (num3)
                  {
                    case 1:
                      LinksDictionaryItem.rg7uu8E9FXqUqPd5gOdd((object) propertyCached1, (object) entityLink, (object) entity, (object) null);
                      num3 = 13;
                      continue;
                    case 2:
                      switch (relationType)
                      {
                        case RelationType.OneToMany:
                        case RelationType.ManyToMany:
                        case RelationType.ManyToManyInverse:
                          goto label_21;
                        default:
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 21 : 1;
                          continue;
                      }
                    case 3:
                    case 26:
                      if (obj1 == null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
                        continue;
                      }
                      goto label_37;
                    case 4:
                    case 10:
                    case 13:
                    case 18:
                    case 21:
                    case 24:
                      goto label_37;
                    case 5:
                      LinksDictionaryItem.PPgUeBE9WTmllsuqAYiC((object) entity, (object) enumerable, obj2);
                      num3 = 18;
                      continue;
                    case 6:
                      obj1 = LinksDictionaryItem.TFnensEJz7SmntGJiiP0((object) propertyCached1, (object) entityLink, (object) null);
                      num3 = 17;
                      continue;
                    case 7:
                    case 23:
                      LinksDictionaryItem.PPgUeBE9WTmllsuqAYiC((object) entity, (object) enumerable, obj2);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 10 : 10;
                      continue;
                    case 8:
                      if (enumerable != null)
                      {
                        num3 = 22;
                        continue;
                      }
                      goto label_37;
                    case 9:
                      if (!(this.TablePartUid != Guid.Empty))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 23 : 10;
                        continue;
                      }
                      goto case 15;
                    case 11:
                      goto label_32;
                    case 12:
                      propertyCached1.SetValue((object) entityLink, (object) entity, (object[]) null);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 4 : 0;
                      continue;
                    case 14:
                      if (!LinksDictionaryItem.gppR31EJsPyBpNbxohF4((object) propertyCached1, (object) null))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
                        continue;
                      }
                      goto label_37;
                    case 15:
                      if (this.IsCurrentTablePart(entityLink, propertyCached2))
                      {
                        num4 = 5;
                        break;
                      }
                      goto label_37;
                    case 16:
                      goto label_3;
                    case 17:
                      if (!LinksDictionaryItem.l1YD8yEJ54wVYfWIKCHA(this.TablePartUid, Guid.Empty))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 26 : 4;
                        continue;
                      }
                      goto case 27;
                    case 19:
label_21:
                      enumerable = (IEnumerable) LinksDictionaryItem.TFnensEJz7SmntGJiiP0((object) propertyCached1, (object) entityLink, (object) null);
                      num4 = 8;
                      break;
                    case 20:
                      if (settings == null)
                      {
                        num3 = 24;
                        continue;
                      }
                      goto case 14;
                    case 22:
                      obj2 = LinksDictionaryItem.n1GG0FE9B9WEhqeMAq33((object) entity);
                      num3 = 9;
                      continue;
                    case 25:
                      if (relationType != RelationType.OneToOne)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 2 : 1;
                        continue;
                      }
                      goto case 6;
                    case 27:
                      if (this.IsCurrentTablePart(entityLink, propertyCached2))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 12 : 8;
                        continue;
                      }
                      goto label_37;
                    default:
                      relationType = LinksDictionaryItem.jl5XDHEJctUPZ61Trq3X((object) settings);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 25 : 5;
                      continue;
                  }
                  num3 = num4;
                }
label_32:
                settings = enumerator2.Current.Settings as EntitySettings;
                num3 = 20;
                goto label_8;
label_38:
                num3 = 16;
                goto label_8;
              }
              finally
              {
                if (enumerator2 != null)
                {
                  int num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
                    num5 = 0;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        goto label_45;
                      default:
                        LinksDictionaryItem.Su7KbJE9bXZ2UMGDcsIY((object) enumerator2);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_45:;
              }
          }
label_3:
          enumerator1 = metadataLink.TableParts.GetEnumerator();
          num2 = 2;
        }
label_47:
        enumerator2 = metadataLink.Properties.Where<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => LinksDictionaryItem.gpCVHKEJglRNAFwbd7ju(LinksDictionaryItem.BbEDQLE9CjOyMDHqGxJd((object) p), this.LinkPropertyUid))).GetEnumerator();
        num1 = 10;
      }
label_79:
      return;
label_46:
      return;
label_58:
      return;
label_62:
      return;
label_50:
      try
      {
label_73:
        if (enumerator1.MoveNext())
          goto label_70;
        else
          goto label_74;
label_51:
        IEnumerator enumerator3;
        TablePartMetadata current;
        IEnumerable enumerable;
        int num6;
        while (true)
        {
          switch (num6)
          {
            case 1:
              if (enumerable != null)
              {
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
                continue;
              }
              goto label_73;
            case 2:
              enumerable = LinksDictionaryItem.S9y0X5E9G62WsWQUAcNK((object) entityLink, LinksDictionaryItem.V0ny4OE9h2wHeneLR8yb((object) current)) as IEnumerable;
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_70;
            case 4:
              goto label_75;
            case 5:
              goto label_73;
            case 6:
              goto label_52;
            default:
              enumerator3 = (IEnumerator) LinksDictionaryItem.Lahd98E9EmZNRuylP8TQ((object) enumerable);
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 6 : 1;
              continue;
          }
        }
label_75:
        return;
label_52:
        try
        {
label_56:
          if (LinksDictionaryItem.wf8chsE9o3PMnYCq04eo((object) enumerator3))
            goto label_54;
          else
            goto label_57;
label_53:
          IEntity entityLink1;
          int num7;
          while (true)
          {
            switch (num7)
            {
              case 1:
                goto label_73;
              case 2:
                this.SetLinkValue(entity, (EntityMetadata) current, entityLink1);
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              case 3:
                goto label_54;
              default:
                goto label_56;
            }
          }
label_54:
          entityLink1 = (IEntity) LinksDictionaryItem.ir54IgE9fccrFMDL9fuW((object) enumerator3);
          num7 = 2;
          goto label_53;
label_57:
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 1;
          goto label_53;
        }
        finally
        {
          IDisposable disposable = enumerator3 as IDisposable;
          int num8 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
            num8 = 1;
          while (true)
          {
            switch (num8)
            {
              case 1:
                if (disposable != null)
                {
                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 1;
                  continue;
                }
                goto label_66;
              case 2:
                LinksDictionaryItem.Su7KbJE9bXZ2UMGDcsIY((object) disposable);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                continue;
              default:
                goto label_66;
            }
          }
label_66:;
        }
label_70:
        current = enumerator1.Current;
        num6 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        {
          num6 = 1;
          goto label_51;
        }
        else
          goto label_51;
label_74:
        num6 = 4;
        goto label_51;
      }
      finally
      {
        enumerator1.Dispose();
        int num9 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
          num9 = 0;
        switch (num9)
        {
          default:
        }
      }
    }

    private static void SetTablePartLinkValue(object entity, object propValues, object entityId)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        bool flag;
        IEnumerator enumerator;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_20;
            case 1:
              goto label_3;
            case 2:
              LinksDictionaryItem.AUeDWSE9QcxV2qtv02lc((object) propValues.AsUntypedISet(), entity);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            case 3:
              enumerator = (IEnumerator) LinksDictionaryItem.Lahd98E9EmZNRuylP8TQ(propValues);
              num2 = 5;
              continue;
            case 4:
              flag = false;
              num2 = 3;
              continue;
            case 5:
              goto label_7;
            default:
              goto label_9;
          }
        }
label_3:
        if (!flag)
        {
          num1 = 2;
          continue;
        }
        goto label_16;
label_7:
        try
        {
label_10:
          if (enumerator.MoveNext())
            goto label_12;
          else
            goto label_11;
label_8:
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_12;
              case 2:
                goto label_10;
              case 3:
                flag = true;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 0;
                continue;
              default:
                goto label_3;
            }
          }
label_11:
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
          goto label_8;
label_12:
          if (LinksDictionaryItem.n1GG0FE9B9WEhqeMAq33((object) (IEntity) LinksDictionaryItem.ir54IgE9fccrFMDL9fuW((object) enumerator)) == entityId)
          {
            num3 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
            {
              num3 = 3;
              goto label_8;
            }
            else
              goto label_8;
          }
          else
            goto label_10;
        }
        finally
        {
          IDisposable disposable = enumerator as IDisposable;
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 1:
                if (disposable != null)
                {
                  num4 = 2;
                  continue;
                }
                goto label_24;
              case 2:
                LinksDictionaryItem.Su7KbJE9bXZ2UMGDcsIY((object) disposable);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                continue;
              default:
                goto label_24;
            }
          }
label_24:;
        }
      }
label_20:
      return;
label_9:
      return;
label_16:;
    }

    private bool IsCurrentTablePart(IEntity entityLink, PropertyInfo uidPropInfo)
    {
      int num1 = 5;
      Guid result;
      while (true)
      {
        int num2 = num1;
        object obj;
        while (true)
        {
          switch (num2)
          {
            case 1:
              obj = LinksDictionaryItem.TFnensEJz7SmntGJiiP0((object) uidPropInfo, (object) entityLink, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
              continue;
            case 2:
              if (Guid.TryParse(obj.ToString(), out result))
              {
                num2 = 3;
                continue;
              }
              goto label_5;
            case 3:
              goto label_4;
            case 4:
              goto label_5;
            case 5:
              if (uidPropInfo != (PropertyInfo) null)
                goto case 1;
              else
                goto label_7;
            default:
              if (obj != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 1;
                continue;
              }
              goto label_5;
          }
        }
label_7:
        num1 = 4;
      }
label_4:
      return LinksDictionaryItem.gpCVHKEJglRNAFwbd7ju(this.TablePartUid, result);
label_5:
      return false;
    }

    public Guid EntityUid
    {
      get => this.\u003CEntityUid\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CEntityUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
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

    public Guid EntityTypeUid
    {
      get => this.\u003CEntityTypeUid\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CEntityTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
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

    public string EntityPropertyName
    {
      get => this.\u003CEntityPropertyName\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CEntityPropertyName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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

    /// <summary>
    /// Uid записи в блоке, у которого Parent-ом является эта сущность
    /// </summary>
    internal Guid TablePartUid
    {
      get => this.\u003CTablePartUid\u003Ek__BackingField;
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
              this.\u003CTablePartUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
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

    public Guid LinkUid
    {
      get => this.\u003CLinkUid\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CLinkUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
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

    public Guid LinkPropertyUid
    {
      get => this.\u003CLinkPropertyUid\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CLinkPropertyUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
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

    internal static void IMpemJEJrkRIZEwNgwmU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool vQ5UrFEJdr7UKX292VlK() => LinksDictionaryItem.S2l8ssEJ9EynArkhOt5B == null;

    internal static LinksDictionaryItem xvXHbdEJlPkG0ud2CWSH() => LinksDictionaryItem.S2l8ssEJ9EynArkhOt5B;

    internal static bool gpCVHKEJglRNAFwbd7ju([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool l1YD8yEJ54wVYfWIKCHA([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static bool OJgq3NEJj7v9vU9cYW9k([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object tj979gEJYngdvdiI2nNX([In] object obj0, Guid uid) => ((IEntityManager) obj0).LoadOrNull(uid);

    internal static object Gbwby4EJLbWglt1KvYHn([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static object C8uanKEJUYtk9cZ3p8fv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool gppR31EJsPyBpNbxohF4([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static RelationType jl5XDHEJctUPZ61Trq3X([In] object obj0) => ((EntitySettings) obj0).RelationType;

    internal static object TFnensEJz7SmntGJiiP0([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static void rg7uu8E9FXqUqPd5gOdd([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static object n1GG0FE9B9WEhqeMAq33([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static void PPgUeBE9WTmllsuqAYiC([In] object obj0, [In] object obj1, [In] object obj2) => LinksDictionaryItem.SetTablePartLinkValue(obj0, obj1, obj2);

    internal static bool wf8chsE9o3PMnYCq04eo([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void Su7KbJE9bXZ2UMGDcsIY([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static Guid V0ny4OE9h2wHeneLR8yb([In] object obj0) => ((TablePartMetadata) obj0).TablePartPropertyUid;

    internal static object S9y0X5E9G62WsWQUAcNK([In] object obj0, Guid propertyUid) => ((IEntity) obj0).GetPropertyValue(propertyUid);

    internal static object Lahd98E9EmZNRuylP8TQ([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object ir54IgE9fccrFMDL9fuW([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static void AUeDWSE9QcxV2qtv02lc([In] object obj0, [In] object obj1) => ((IUntypedCollectionProxy) obj0).Add(obj1);

    internal static Guid BbEDQLE9CjOyMDHqGxJd([In] object obj0) => ((AbstractMetadata) obj0).Uid;
  }
}
