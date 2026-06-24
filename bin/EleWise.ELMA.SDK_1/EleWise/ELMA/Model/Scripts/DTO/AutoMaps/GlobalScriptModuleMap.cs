// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.DTO.AutoMaps.GlobalScriptModuleMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Scripts.DTO.AutoMaps
{
  public class GlobalScriptModuleMap : EntityDTOMap<IGlobalScriptModule, GlobalScriptModuleDto>
  {
    internal static GlobalScriptModuleMap UL4YFdbXKPtS0wD2irO9;

    protected override void InitMap(
      IMappingExpression<IGlobalScriptModule, GlobalScriptModuleDto> map)
    {
      base.InitMap(map);
      map.ForMember<ProjectInfo>((Expression<Func<GlobalScriptModuleDto, ProjectInfo>>) (globalScriptModuleDto => globalScriptModuleDto.Project), (Action<IMemberConfigurationExpression<IGlobalScriptModule, GlobalScriptModuleDto, ProjectInfo>>) (a => a.MapFrom<object>((Expression<Func<IGlobalScriptModule, object>>) (globalScriptModule => globalScriptModule.Items))));
    }

    protected override void InitReverseMap(
      IMappingExpression<GlobalScriptModuleDto, IGlobalScriptModule> map)
    {
      base.InitReverseMap(map);
      map.ForMember<object>((Expression<Func<IGlobalScriptModule, object>>) (globalScriptModule => globalScriptModule.Items), (Action<IMemberConfigurationExpression<GlobalScriptModuleDto, IGlobalScriptModule, object>>) (a => a.MapFrom<ProjectInfo>((Expression<Func<GlobalScriptModuleDto, ProjectInfo>>) (globalScriptModuleDto => globalScriptModuleDto.Project))));
    }

    public GlobalScriptModuleMap()
    {
      GlobalScriptModuleMap.vEsqWPbXkhWxbcxV3pKZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void vEsqWPbXkhWxbcxV3pKZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool R6D0FrbXXGg7TU1bRJaB() => GlobalScriptModuleMap.UL4YFdbXKPtS0wD2irO9 == null;

    internal static GlobalScriptModuleMap w2VMfqbXTwRQy8VFkngF() => GlobalScriptModuleMap.UL4YFdbXKPtS0wD2irO9;
  }
}
