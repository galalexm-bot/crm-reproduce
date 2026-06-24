// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.EntityPermissionConfigurationManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Сервис управления привилегиямии дизайнера</summary>
  public class EntityPermissionConfigurationManager : 
    DTOManager,
    IEntityPermissionConfigurationManager,
    IConfigurationService
  {
    internal static EntityPermissionConfigurationManager M0U0tdhGGnY8xyU07V5X;

    /// <inheritdoc />
    public virtual void ActivatePermissionMetadata(
      EntityMetadata metadata,
      TablePartMetadata tablePartMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EntityPermissionConfigurationManager.TMBtyFhGQtWYHXJVcLNv((object) metadata, (object) tablePartMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public virtual void DisablePermissionMetadata(EntityMetadata metadata) => EntityPermissionConfigurationManager.RGp5k0hGCHWExmOEZigw((object) metadata);

    /// <inheritdoc />
    public virtual TablePartMetadata GetActivePermissionMetadata(EntityMetadata metadata) => (TablePartMetadata) EntityPermissionConfigurationManager.pINDdIhGvMvduoP4doQB((object) metadata);

    /// <inheritdoc />
    public virtual TablePartMetadata InitNewPermissionMetadata(
      EntityMetadata metadata,
      string metadataName,
      string propertyName)
    {
      int num = 1;
      TablePartMetadata permissionMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            permissionMetadata = (TablePartMetadata) EntityPermissionConfigurationManager.sxQOuEhG8AFQCWdldjlD((object) metadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            metadata.InitNewPermissionMetadata(permissionMetadata, metadataName, propertyName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 2;
            continue;
        }
      }
label_3:
      return permissionMetadata;
    }

    /// <inheritdoc />
    [Obsolete("Use EntityMetadataExtensions.IsSystem or MetadataRuntimeService.IsSystem instead", true)]
    public virtual bool IsSystem(IMetadata metadata) => EntityPermissionConfigurationManager.mUQJlFhGZCkP9AjhqJtl((object) metadata);

    public EntityPermissionConfigurationManager()
    {
      EntityPermissionConfigurationManager.cw1HgXhGuRSliwjYZERM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void TMBtyFhGQtWYHXJVcLNv([In] object obj0, [In] object obj1) => ((EntityMetadata) obj0).ActivatePermissionMetadata((TablePartMetadata) obj1);

    internal static bool R859WphGEH6QO5VyepLx() => EntityPermissionConfigurationManager.M0U0tdhGGnY8xyU07V5X == null;

    internal static EntityPermissionConfigurationManager nYjunkhGfi4gmR8eW8kZ() => EntityPermissionConfigurationManager.M0U0tdhGGnY8xyU07V5X;

    internal static void RGp5k0hGCHWExmOEZigw([In] object obj0) => ((EntityMetadata) obj0).DisablePermissionMetadata();

    internal static object pINDdIhGvMvduoP4doQB([In] object obj0) => (object) ((EntityMetadata) obj0).GetActivePermissionMetadata();

    internal static object sxQOuEhG8AFQCWdldjlD([In] object obj0) => (object) ((EntityMetadata) obj0).CreateTablePart();

    internal static bool mUQJlFhGZCkP9AjhqJtl([In] object obj0) => ((IMetadata) obj0).IsSystem();

    internal static void cw1HgXhGuRSliwjYZERM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
