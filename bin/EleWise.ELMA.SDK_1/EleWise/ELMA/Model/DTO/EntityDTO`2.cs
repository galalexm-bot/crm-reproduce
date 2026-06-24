// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.DTO.EntityDTO`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.DTO
{
  /// <summary>DTO для сущности указанного типа</summary>
  /// <typeparam name="TId"></typeparam>
  [Component]
  [Serializable]
  public class EntityDTO<TId, TEntity> : 
    EntityDTO<TId>,
    IEntityDTO<TId, TEntity>,
    IEntityDTO<TId>,
    IEntityDTO
    where TEntity : class, IEntity
  {
    private static object oY73YjWjVqxtfDl9FcbB;

    public EntityDTO()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool tEjYk9WjSYmOSs05aaeR() => EntityDTO<TId, TEntity>.oY73YjWjVqxtfDl9FcbB == null;

    internal static object a61WqYWjiVYw1p5KMoKS() => EntityDTO<TId, TEntity>.oY73YjWjVqxtfDl9FcbB;
  }
}
