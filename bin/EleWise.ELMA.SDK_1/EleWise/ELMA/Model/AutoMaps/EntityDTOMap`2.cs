// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.EntityDTOMap`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.AutoMaps
{
  public class EntityDTOMap<TEntity, TDTO> : BidirectionalMap<TEntity, TDTO>
    where TEntity : class, IEntity
    where TDTO : class, IEntityDTO
  {
    internal static object KTnU00h70ZKmXjgbspVJ;

    protected override void InitReverseMap(IMappingExpression<TDTO, TEntity> map)
    {
      base.InitReverseMap(map);
      map.ConstructAsLoadOrCreateEntity<TDTO, TEntity>();
    }

    public EntityDTOMap()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool PfjDDAh7mE91NEmlhVcq() => EntityDTOMap<TEntity, TDTO>.KTnU00h70ZKmXjgbspVJ == null;

    internal static object okVAZth7yxO2eYc8Ogi6() => EntityDTOMap<TEntity, TDTO>.KTnU00h70ZKmXjgbspVJ;
  }
}
