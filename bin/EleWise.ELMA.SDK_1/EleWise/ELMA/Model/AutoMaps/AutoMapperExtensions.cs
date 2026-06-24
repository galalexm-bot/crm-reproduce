// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.AutoMapperExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using System;

namespace EleWise.ELMA.Model.AutoMaps
{
  public static class AutoMapperExtensions
  {
    public static void ConstructAsLoadOrCreateEntity<TSource, TDestination>(
      this IMappingExpression<TSource, TDestination> map)
      where TSource : class, IEntityDTO
      where TDestination : class, IEntity
    {
      map.ConstructUsing((Func<TSource, TDestination>) (source => AutoMapperExtensions.LoadOrCreateEntity<TSource, TDestination>(source)));
    }

    private static TEntity LoadOrCreateEntity<TDTO, TEntity>(TDTO source)
      where TDTO : class, IEntityDTO
      where TEntity : class, IEntity
    {
      if ((object) source == null)
        return default (TEntity);
      TEntity entity = default (TEntity);
      Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies((System.Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              entity = EntityManager<TEntity>.Instance.LoadOrNull(((TDTO) source).Id);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      if ((object) (TEntity) entity == null)
        entity = EntityManager<TEntity>.Instance.Create();
      return entity;
    }
  }
}
