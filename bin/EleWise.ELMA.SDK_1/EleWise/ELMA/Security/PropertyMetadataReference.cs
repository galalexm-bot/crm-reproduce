// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PropertyMetadataReference
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security
{
  /// <summary>Класс для передачи связанных свойств прав</summary>
  public class PropertyMetadataReference : IEntity, IIdentified
  {
    internal static PropertyMetadataReference uF8pW6B5xckAFytNDNMp;

    public PropertyMetadataReference()
    {
      PropertyMetadataReference.QZSY9nB5yNXVXCEk0KvH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public PropertyMetadataReference(Guid? metadataGuid, Guid? propertyMetadataGuid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      if (metadataGuid.HasValue && propertyMetadataGuid.HasValue)
        this.MetadataGuid = metadataGuid.Value;
      this.PropertyMetadataGuid = propertyMetadataGuid.Value;
    }

    public PropertyMetadataReference(IEntityMetadata metadata, IPropertyMetadata propertyMetadata)
    {
      PropertyMetadataReference.QZSY9nB5yNXVXCEk0KvH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (metadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
              continue;
            }
            goto label_11;
          case 2:
            this.MetadataGuid = metadata.Uid;
            num = 4;
            continue;
          case 3:
            goto label_3;
          case 4:
            this.PropertyMetadataGuid = PropertyMetadataReference.PjBlVbB5Mdh2alnG96a5((object) propertyMetadata);
            num = 3;
            continue;
          default:
            if (propertyMetadata != null)
            {
              num = 2;
              continue;
            }
            goto label_10;
        }
      }
label_3:
      return;
label_10:
      return;
label_11:;
    }

    /// <summary>Uid метаданных к которому пренадлежит свойство</summary>
    public Guid MetadataGuid
    {
      get => this.\u003CMetadataGuid\u003Ek__BackingField;
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
              this.\u003CMetadataGuid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
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

    /// <summary>Uid свойства</summary>
    public Guid PropertyMetadataGuid
    {
      get => this.\u003CPropertyMetadataGuid\u003Ek__BackingField;
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
              this.\u003CPropertyMetadataGuid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
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

    public IPropertyMetadata GetPropertyMetadata()
    {
      IPropertyMetadata propertyMetadata;
      switch (1)
      {
        case 1:
          try
          {
            EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(this.MetadataGuid) as EntityMetadata;
            int num = 4;
            while (true)
            {
              switch (num)
              {
                case 1:
                  propertyMetadata = (IPropertyMetadata) null;
                  num = 2;
                  continue;
                case 3:
                  propertyMetadata = (IPropertyMetadata) entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => PropertyMetadataReference.lVNLyAB59vo593Fr7Zfi(PropertyMetadataReference.pnhtU5B5JkvjX9KEfwxh((object) p), this.PropertyMetadataGuid)));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                  continue;
                case 4:
                  if (entityMetadata == null)
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
                    continue;
                  }
                  goto case 3;
                default:
                  goto label_1;
              }
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                default:
                  propertyMetadata = (IPropertyMetadata) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 1;
                  continue;
              }
            }
          }
      }
label_1:
      return propertyMetadata;
    }

    public object GetId() => throw new NotImplementedException();

    public void SetId(object id) => throw new NotImplementedException();

    public string ToString(string format) => throw new NotImplementedException();

    public object GetPropertyValue(Guid propertyUid) => throw new NotImplementedException();

    public T GetPropertyValue<T>(Guid propertyUid) => throw new NotImplementedException();

    public void SetPropertyValue(Guid propertyUid, object value) => throw new NotImplementedException();

    public TSettings GetPropertySettings<TSettings>(Guid propertyUid) where TSettings : TypeSettings => throw new NotImplementedException();

    public TypeSettings GetPropertySettings(Guid propertyUid) => throw new NotImplementedException();

    public TypeSettings GetPropertySettings(Guid propertyUid, TypeSettings defaultSettings) => throw new NotImplementedException();

    public TypeSettings LoadPropertyInstanceSettings(Guid propertyUid) => throw new NotImplementedException();

    public void SavePropertyInstanceSettings(Guid propertyUid, TypeSettings settings) => throw new NotImplementedException();

    public ITypeSettingsInstanceStore LoadSettingsInstanceStore(
      bool createIfNotExists,
      bool loadIfNotLoaded)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IEntity> GetContainedEntities() => throw new NotImplementedException();

    public IEntity GetRootEntity() => throw new NotImplementedException();

    public void Save() => throw new NotImplementedException();

    public void Delete() => throw new NotImplementedException();

    public void Refresh() => throw new NotImplementedException();

    public bool IsNew() => throw new NotImplementedException();

    public bool IsDirty() => throw new NotImplementedException();

    public Guid[] GetDirtyPropertyUids() => throw new NotImplementedException();

    internal static void QZSY9nB5yNXVXCEk0KvH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JZ09t1B50fU62O08mZgf() => PropertyMetadataReference.uF8pW6B5xckAFytNDNMp == null;

    internal static PropertyMetadataReference qBk6rJB5mkU9mmHnRUf3() => PropertyMetadataReference.uF8pW6B5xckAFytNDNMp;

    internal static Guid PjBlVbB5Mdh2alnG96a5([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static Guid pnhtU5B5JkvjX9KEfwxh([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool lVNLyAB59vo593Fr7Zfi([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;
  }
}
