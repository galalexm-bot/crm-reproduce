// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.ObjectsLinkedFinder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Components
{
  /// <summary>Расширение для поиска связных объектов</summary>
  [Component]
  internal sealed class ObjectsLinkedFinder : LinkedFinderBase
  {
    private readonly IMetadataService metadataService;
    internal static ObjectsLinkedFinder Yf5hNmfG3BiKpScRfM7n;

    /// <summary>Ctor</summary>
    public ObjectsLinkedFinder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.metadataService = MetadataServiceContext.Service;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override FindLinkedObjectsResult FindLinkedObjects(
      ICollection<ILinkedObject> objectsToSearch,
      LinkedObjectsContext context)
    {
      FindLinkedObjectsResult resultObj = new FindLinkedObjectsResult();
      foreach (ILinkedObject linkedObject in (IEnumerable<ILinkedObject>) objectsToSearch)
      {
        ILinkedObject objectInfo = linkedObject;
        IMetadata metadata = this.GetMetadata(objectInfo.Uid, context, resultObj);
        if (metadata != null && metadata is ClassMetadata md1)
        {
          this.FillObj(resultObj, context, md1.BaseClassUid);
          this.FillProperties(md1, context, resultObj);
          this.FillDependencies(md1.Uid, context, resultObj);
          if (md1 is EntityMetadata)
          {
            foreach (ClassMetadata md in this.metadataService.GetMetadataList().Where<IMetadata>((Func<IMetadata, bool>) (m =>
            {
              int num = 1;
              while (true)
              {
                switch (num)
                {
                  case 1:
                    if (m is EntityMetadata entityMetadata2)
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                      continue;
                    }
                    goto label_3;
                  case 2:
                    goto label_2;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    if (ObjectsLinkedFinder.\u003C\u003Ec__DisplayClass2_0.ym3pt38dAJce8Mg93OoR((object) entityMetadata2) == EntityMetadataType.InterfaceExtension)
                    {
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 2;
                      continue;
                    }
                    goto label_3;
                }
              }
label_2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return ObjectsLinkedFinder.\u003C\u003Ec__DisplayClass2_0.VGkRl08dxlMfAnSZpWPg(ObjectsLinkedFinder.\u003C\u003Ec__DisplayClass2_0.Q153R88d72EdkJ8TnwLF((object) entityMetadata2), objectInfo.Uid);
label_3:
              return false;
            })).OfType<EntityMetadata>())
              this.FillProperties(md, context, resultObj);
          }
        }
      }
      return resultObj;
    }

    /// <inheritdoc />
    protected override IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context)
    {
      IMetadata metadataWithUid;
      switch (1)
      {
        case 1:
          try
          {
            metadataWithUid = (IMetadata) (this.metadataService.GetMetadata(metadataId, false) as NamedMetadata);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
              num = 0;
            switch (num)
            {
            }
          }
          catch (TypeNotFoundException ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  metadataWithUid = (IMetadata) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_1;
              }
            }
          }
          break;
      }
label_1:
      return metadataWithUid;
    }

    internal static bool A5op3vfGph6Wxk1bH792() => ObjectsLinkedFinder.Yf5hNmfG3BiKpScRfM7n == null;

    internal static ObjectsLinkedFinder WXu7iEfGaDFQJfqUlXVR() => ObjectsLinkedFinder.Yf5hNmfG3BiKpScRfM7n;
  }
}
