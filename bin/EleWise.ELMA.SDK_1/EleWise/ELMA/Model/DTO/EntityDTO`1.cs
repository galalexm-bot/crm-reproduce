// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.DTO.EntityDTO`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.DTO
{
  /// <summary>DTO для сущности</summary>
  /// <typeparam name="TId"></typeparam>
  [Serializable]
  public class EntityDTO<TId> : IEntityDTO<TId>, IEntityDTO
  {
    private static object Qe2qsvWjRtxoVWJV2BvE;

    /// <summary>Идентификатор</summary>
    public TId Id { get; set; }

    object IEntityDTO.Id
    {
      get => (object) this.Id;
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
              this.Id = (TId) value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
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

    /// <summary>Скопировать изменения после сохранения объекта</summary>
    /// <param name="saved">Сохраненный объект</param>
    public virtual void CopyChanges(EntityDTO<TId> saved)
    {
      Contract.ArgumentNotNull((object) saved, z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901908163));
      this.Id = saved.Id;
    }

    public EntityDTO()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool z7BIXoWjqb0sgTn2JiBa() => EntityDTO<TId>.Qe2qsvWjRtxoVWJV2BvE == null;

    internal static object ajOFM8WjKdH3bumeMiHY() => EntityDTO<TId>.Qe2qsvWjRtxoVWJV2BvE;
  }
}
