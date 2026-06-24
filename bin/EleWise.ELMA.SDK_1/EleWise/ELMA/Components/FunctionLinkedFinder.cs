// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Components.FunctionLinkedFinder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Components
{
  /// <summary>Расширение для поиска связных функций</summary>
  [Component]
  internal sealed class FunctionLinkedFinder : LinkedFinderBase
  {
    private readonly IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager;
    private static FunctionLinkedFinder te5lX3fG2Nf4o0rUV6iF;

    /// <summary>Ctor</summary>
    /// <param name="functionMetadataItemHeaderManager">Менеджер заголовков метаданных функций</param>
    public FunctionLinkedFinder(
      IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager)
    {
      FunctionLinkedFinder.YFKROffG1HRB6YqobqSu();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.functionMetadataItemHeaderManager = functionMetadataItemHeaderManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
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
        IMetadata metadata = this.GetMetadata(linkedObject.Uid, context, resultObj);
        if (metadata != null && metadata is FunctionMetadata functionMetadata)
        {
          this.FillObj(resultObj, context, functionMetadata.Uid);
          if (functionMetadata.ParameterType != null)
            this.FillObj(resultObj, context, functionMetadata.ParameterType.SubTypeUid);
          if (functionMetadata.ReturnType != null)
            this.FillObj(resultObj, context, functionMetadata.ReturnType.SubTypeUid);
        }
      }
      return resultObj;
    }

    /// <inheritdoc />
    protected override IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context)
    {
      int num = 4;
      FunctionMetadataItemHeader metadataItemHeader;
      while (true)
      {
        object obj;
        switch (num)
        {
          case 1:
            obj = (object) null;
            break;
          case 2:
            obj = FunctionLinkedFinder.jlsjsmfGNnX01Fq0ZkxL((object) metadataItemHeader);
            break;
          case 3:
            if (metadataItemHeader != null)
            {
              num = 2;
              continue;
            }
            goto case 1;
          case 4:
            metadataItemHeader = this.functionMetadataItemHeaderManager.LoadOrNull(metadataId);
            num = 3;
            continue;
          default:
            goto label_3;
        }
        if (obj != null)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
        else
          goto label_4;
      }
label_3:
      return (IMetadata) (((FunctionMetadataItem) FunctionLinkedFinder.jlsjsmfGNnX01Fq0ZkxL((object) metadataItemHeader)).Metadata as FunctionMetadata);
label_4:
      return (IMetadata) null;
    }

    internal static void YFKROffG1HRB6YqobqSu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool OD0KX5fGeRNYTj7GpELI() => FunctionLinkedFinder.te5lX3fG2Nf4o0rUV6iF == null;

    internal static FunctionLinkedFinder su24dBfGP9JfQ9tdaULZ() => FunctionLinkedFinder.te5lX3fG2Nf4o0rUV6iF;

    internal static object jlsjsmfGNnX01Fq0ZkxL([In] object obj0) => (object) ((FunctionMetadataItemHeader) obj0).Draft;
  }
}
