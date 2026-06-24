// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.DTO.AutoMaps.BPMAppMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.BPMApps.Models;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace EleWise.ELMA.BPMApps.DTO.AutoMaps
{
  public class BPMAppMap : EntityDTOMap<IBPMApp, BPMAppDTO>
  {
    internal static BPMAppMap KuUvw1fncrqMCrdD0mjH;

    protected override void InitMap(IMappingExpression<IBPMApp, BPMAppDTO> map)
    {
      base.InitMap(map);
      map.ForMember<ElmaStoreComponentManifest>((Expression<Func<BPMAppDTO, ElmaStoreComponentManifest>>) (bpmAppDto => bpmAppDto.ComponentManifest), (Action<IMemberConfigurationExpression<IBPMApp, BPMAppDTO, ElmaStoreComponentManifest>>) (a => a.MapFrom<ElmaStoreComponentManifest>((Expression<Func<IBPMApp, ElmaStoreComponentManifest>>) (bpmApp => (ElmaStoreComponentManifest) bpmApp.ComponentManifest))));
      map.ForMember<BPMAppManifest>((Expression<Func<BPMAppDTO, BPMAppManifest>>) (bpmAppDto => bpmAppDto.AppManifest), (Action<IMemberConfigurationExpression<IBPMApp, BPMAppDTO, BPMAppManifest>>) (a => a.MapFrom<BPMAppManifest>((Expression<Func<IBPMApp, BPMAppManifest>>) (bpmApp => (BPMAppManifest) bpmApp.AppManifest))));
      map.ForMember<string[]>((Expression<Func<BPMAppDTO, string[]>>) (bpmAppDto => bpmAppDto.CertificateThumbprints), (Action<IMemberConfigurationExpression<IBPMApp, BPMAppDTO, string[]>>) (a => a.MapFrom<string[]>((Expression<Func<IBPMApp, string[]>>) (bpmApp => !string.IsNullOrEmpty(bpmApp.CertificateThumbprints) ? bpmApp.CertificateThumbprints.Split(new char[]
      {
        ';'
      }, StringSplitOptions.RemoveEmptyEntries).ToArray<string>() : default (string[])))));
    }

    protected override void InitReverseMap(IMappingExpression<BPMAppDTO, IBPMApp> map)
    {
      base.InitReverseMap(map);
      map.ForMember<object>((Expression<Func<IBPMApp, object>>) (bpmApp => bpmApp.ComponentManifest), (Action<IMemberConfigurationExpression<BPMAppDTO, IBPMApp, object>>) (a => a.MapFrom<ElmaStoreComponentManifest>((Expression<Func<BPMAppDTO, ElmaStoreComponentManifest>>) (bpmAppDto => bpmAppDto.ComponentManifest))));
      map.ForMember<object>((Expression<Func<IBPMApp, object>>) (bpmApp => bpmApp.AppManifest), (Action<IMemberConfigurationExpression<BPMAppDTO, IBPMApp, object>>) (a => a.MapFrom<BPMAppManifest>((Expression<Func<BPMAppDTO, BPMAppManifest>>) (bpmAppDto => bpmAppDto.AppManifest))));
      map.ForMember<string>((Expression<Func<IBPMApp, string>>) (bpmApp => bpmApp.CertificateThumbprints), (Action<IMemberConfigurationExpression<BPMAppDTO, IBPMApp, string>>) (a => a.MapFrom<string>((Expression<Func<BPMAppDTO, string>>) (bpmAppDto => bpmAppDto.CertificateThumbprints != default (object) && bpmAppDto.CertificateThumbprints.Length > 0 ? string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306464888), bpmAppDto.CertificateThumbprints) : default (string)))));
    }

    public BPMAppMap()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool mZb8aEfnzSbPiDCRtPxt() => BPMAppMap.KuUvw1fncrqMCrdD0mjH == null;

    internal static BPMAppMap VhG56TfOFQeHgQ0tFFvM() => BPMAppMap.KuUvw1fncrqMCrdD0mjH;
  }
}
