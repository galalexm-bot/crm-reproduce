// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.FeedSetReadHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Помощник для работы с лентой сообщений.</summary>
  public static class FeedSetReadHelper
  {
    /// <summary>
    /// Отметить все сообщения по указанному объекту, как прочитанные.
    /// </summary>
    /// <param name="entity">Идентификатор типа объекта.</param>
    /// <param name="recipientId">Идентификатор получателя.</param>
    public static void SetAsReadForObject(IEntity entity, long? recipientId = null)
    {
      long int64;
      try
      {
        int64 = Convert.ToInt64(entity.GetId());
      }
      catch (Exception ex)
      {
        return;
      }
      FeedSetReadHelper.SetAsReadForObject(InterfaceActivator.UID(entity.CastAsRealType<IEntity>().GetType()), int64, recipientId);
    }

    /// <summary>
    /// Отметить все сообщения по указанному объекту, как прочитанные.
    /// </summary>
    /// <param name="objectUid">Идентификатор типа объекта.</param>
    /// <param name="objectId">Идентификатор объекта.</param>
    /// <param name="recipientId">Идентификатор получателя.</param>
    public static void SetAsReadForObject(Guid objectUid, long objectId, long? recipientId = null)
    {
      IEnumerable<IFeedSetReadProvider> extensionPoints = ComponentManager.Current.GetExtensionPoints<IFeedSetReadProvider>();
      if (extensionPoints == null)
        return;
      foreach (IFeedSetReadProvider feedSetReadProvider in extensionPoints)
        feedSetReadProvider.SetAsReadForObject(objectUid, objectId, recipientId);
    }
  }
}
