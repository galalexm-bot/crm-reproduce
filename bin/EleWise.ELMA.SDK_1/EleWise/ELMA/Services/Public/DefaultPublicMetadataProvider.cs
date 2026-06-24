// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.Public.DefaultPublicMetadataProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Services.Public
{
  [Component(EnableInterceptiors = false)]
  internal class DefaultPublicMetadataProvider : IPublicMetadataProvider
  {
    private IMetadataRuntimeService _metadataRuntimeService;
    private IEnumerable<IPublicMetadataFilter> _filters;

    public DefaultPublicMetadataProvider(
      IMetadataRuntimeService metadataRuntimeService,
      IEnumerable<IPublicMetadataFilter> filters)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      if (metadataRuntimeService == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858944995));
      if (filters == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751234036));
      this._metadataRuntimeService = metadataRuntimeService;
      this._filters = filters;
    }

    public IEnumerable<IPublicMetadataInfo> GetMetadataInfoList() => (IEnumerable<IPublicMetadataInfo>) ((IEnumerable<IMetadata>) this._metadataRuntimeService.GetMetadataList().Where<IMetadata>(new Func<IMetadata, bool>(this.FilterMetadata<IMetadata>)).Select<IMetadata, IMetadata>((Func<IMetadata, IMetadata>) (m => MetadataLoader.LoadMetadata(DefaultPublicMetadataProvider.\u003C\u003Ec.JwZXYeQnexBExG2kkVLm((object) m), false, false))).ToArray<IMetadata>()).Select<IMetadata, DefaultPublicMetadataProvider.PublicMetadataInfo>((Func<IMetadata, DefaultPublicMetadataProvider.PublicMetadataInfo>) (m => new DefaultPublicMetadataProvider.PublicMetadataInfo(m))).ToArray<DefaultPublicMetadataProvider.PublicMetadataInfo>();

    public IEnumerable<IPublicMetadataGroupInfo> GetGroups() => (IEnumerable<IPublicMetadataGroupInfo>) new IPublicMetadataGroupInfo[0];

    private bool FilterMetadata<T>(T metadata) where T : IMetadata => this._filters.All<IPublicMetadataFilter>((Func<IPublicMetadataFilter, bool>) (f =>
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (f.Filter != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return f.Filter((IMetadata) metadata);
label_5:
      return false;
    }));

    private class PublicMetadataInfo : IPublicMetadataInfo
    {
      private object _metadata;
      internal static object x3mJDsQnRFKIVcV1P2GP;

      public PublicMetadataInfo(IMetadata metadata)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
          num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_7;
            case 2:
              if (metadata != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 3 : 0;
                continue;
              }
              goto label_3;
            case 3:
              this._metadata = (object) metadata;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_7:
        return;
label_3:
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825370680));
      }

      public Guid Uid => DefaultPublicMetadataProvider.PublicMetadataInfo.s7uqfTQnXrtaxnF70Xfp(this._metadata);

      public Guid GroupUid => Guid.Empty;

      public string Name => ((NamedMetadata) this._metadata).Name;

      public string DisplayName => (string) DefaultPublicMetadataProvider.PublicMetadataInfo.gDi9yAQnTLA89JJ92iVj((object) (NamedMetadata) this._metadata);

      public IMetadata GetMetadata() => MetadataLoader.LoadMetadata(((IMetadata) this._metadata).Uid, loadImplementation: false);

      public void ProcessPropertyDescriptor(
        IPropertyMetadata propMetadata,
        TypeSerializationItemDescriptor propDescriptor)
      {
      }

      internal static bool VT7ZjDQnq2diIxVr8K9q() => DefaultPublicMetadataProvider.PublicMetadataInfo.x3mJDsQnRFKIVcV1P2GP == null;

      internal static DefaultPublicMetadataProvider.PublicMetadataInfo oSrY6UQnKgFe23OhcKQx() => (DefaultPublicMetadataProvider.PublicMetadataInfo) DefaultPublicMetadataProvider.PublicMetadataInfo.x3mJDsQnRFKIVcV1P2GP;

      internal static Guid s7uqfTQnXrtaxnF70Xfp([In] object obj0) => ((IMetadata) obj0).Uid;

      internal static object gDi9yAQnTLA89JJ92iVj([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;
    }
  }
}
