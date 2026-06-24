// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Events.Audit.EntityAuditObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Events.Audit
{
  /// <summary>Объект события аудита для сущности</summary>
  [Serializable]
  public class EntityAuditObject : IAuditObject
  {
    private Guid uid;
    private Guid parentClassUid;
    private string fullTypeName;
    private MetadataImage image;
    private EntityMetadata metadata;
    private IAuditObject parent;
    private static EntityAuditObject h6UBiioWVUPjEtHvv613;

    /// <summary>Ctor</summary>
    /// <param name="metadata">Метаданные сущности</param>
    public EntityAuditObject(EntityMetadata metadata)
    {
      EntityAuditObject.TXepxaoWRJZD2pHI3jtf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.metadata = metadata;
            num = 2;
            continue;
          case 2:
            EntityAuditObject.gdv5sAoWKSQq10539pJO((object) metadata, EntityAuditObject.WJ81ScoWqxE677nImao4(654297945 ^ 654279271));
            num = 7;
            continue;
          case 3:
            this.image = (MetadataImage) EntityAuditObject.nFo0QZoWXwKc4FAwxqqA((object) metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 5 : 2;
            continue;
          case 4:
            goto label_11;
          case 5:
            if (this.image != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 4 : 1;
              continue;
            }
            goto case 6;
          case 6:
            this.image = (MetadataImage) EntityAuditObject.t9UISQoWTH4V7fRbAMx3((object) metadata, 16);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 8 : 2;
            continue;
          case 7:
            this.uid = metadata.Uid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 8:
            goto label_3;
          case 9:
            this.fullTypeName = metadata.FullTypeName;
            num = 3;
            continue;
          default:
            this.parentClassUid = metadata.BaseClassUid;
            num = 9;
            continue;
        }
      }
label_11:
      return;
label_3:;
    }

    /// <summary>Uid объекта</summary>
    public Guid Uid => this.uid;

    /// <summary>Тип объекта - сущность</summary>
    public IAuditObjectType Type => (IAuditObjectType) EntityAuditObject.b3C8r5oWka4Zgvmen0H9();

    /// <summary>Родительский объект</summary>
    public IAuditObject Parent
    {
      get
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              if (EntityAuditObject.zlcQYhoWng78yYRqZE9T(this.parentClassUid, Guid.Empty))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 3:
              if (this.parent == null)
              {
                num = 2;
                continue;
              }
              goto label_6;
            default:
              this.parent = (IAuditObject) EntityAuditObject.GSLIWGoWOurEgo9DLQ9H((object) Locator.GetServiceNotNull<IAuditManager>(), this.parentClassUid);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
              continue;
          }
        }
label_6:
        return this.parent;
      }
    }

    /// <summary>Название объекта</summary>
    public string Name => this.fullTypeName;

    /// <summary>
    /// Отображаемое название объекта. Вычисляем динамически, т.к. может вызываться пользователями с разной культурой
    /// </summary>
    public string DisplayName
    {
      get
      {
        int num = 2;
        EntityMetadata metadata;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (metadata == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              metadata = (EntityMetadata) Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadata(this.uid);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return this.fullTypeName;
label_5:
        return (string) EntityAuditObject.o0hYIZoW2C0ILC18Sh9N((object) metadata);
      }
    }

    /// <summary>Изображение объекта (16x16)</summary>
    public Image Image
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (this.image != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return (Image) null;
label_5:
        return (Image) EntityAuditObject.oHl2O3oWeRhlPEuIqocS((object) this.image);
      }
    }

    /// <summary>Метаданные изображение объекта</summary>
    public MetadataImage MetadataImage => this.image;

    public MetadataImage GetImage(int size)
    {
      int num = 1;
      object image;
      while (true)
      {
        switch (num)
        {
          case 1:
            MetadataImage metadataImage = MetadataLoader.ParentImage((ClassMetadata) this.metadata, size);
            if (metadataImage == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            }
            image = (object) metadataImage;
            break;
          case 2:
            goto label_8;
          default:
            image = EntityAuditObject.nFo0QZoWXwKc4FAwxqqA((object) this.metadata);
            break;
        }
        if (image == null)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 2 : 1;
        else
          break;
      }
      return (MetadataImage) image;
label_8:
      return MetadataLoader.ParentImage((ClassMetadata) this.metadata, 16);
    }

    internal static void TXepxaoWRJZD2pHI3jtf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object WJ81ScoWqxE677nImao4(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void gdv5sAoWKSQq10539pJO([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object nFo0QZoWXwKc4FAwxqqA([In] object obj0) => (object) ((NamedMetadata) obj0).DefaultImage;

    internal static object t9UISQoWTH4V7fRbAMx3([In] object obj0, int size) => (object) MetadataLoader.ParentImage((ClassMetadata) obj0, size);

    internal static bool VpKafWoWStUVk2kTLXtk() => EntityAuditObject.h6UBiioWVUPjEtHvv613 == null;

    internal static EntityAuditObject dj5T6poWixr02v4HiauD() => EntityAuditObject.h6UBiioWVUPjEtHvv613;

    internal static object b3C8r5oWka4Zgvmen0H9() => (object) EntityAuditObjectType.Instance;

    internal static bool zlcQYhoWng78yYRqZE9T([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object GSLIWGoWOurEgo9DLQ9H([In] object obj0, Guid uid) => (object) ((IAuditManager) obj0).GetObject(uid);

    internal static object o0hYIZoW2C0ILC18Sh9N([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object oHl2O3oWeRhlPEuIqocS([In] object obj0) => (object) ((MetadataImage) obj0).CreateImage();
  }
}
