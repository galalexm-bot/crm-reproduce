// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Entities
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class EntityExtensions
  {
    private static RunWithSoftDeletableService runWithSoftDeletableService;
    internal static EntityExtensions Yc6cvph8CAMfTy2PD3mv;

    /// <summary>Проверить сущность, что она "мягко" удалена</summary>
    /// <param name="entity">Сущность с поддержкой "мягкого" удаления</param>
    /// <returns><paramref name="entity" />, если сущность не удалена, или в контексте разрешено использовать удаленные сущности, иначе <see langword="null" /></returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static T CheckSoftDeletable<T>(T entity) where T : class, ISoftDeletable => (object) entity != null && entity.IsDeleted && !EntityExtensions.RunWithSoftDeletableService.Turned ? default (T) : entity;

    private static RunWithSoftDeletableService RunWithSoftDeletableService
    {
      get
      {
        int num = 1;
        RunWithSoftDeletableService deletableService;
        while (true)
        {
          switch (num)
          {
            case 1:
              deletableService = EntityExtensions.runWithSoftDeletableService;
              if (deletableService == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return deletableService;
label_5:
        return EntityExtensions.runWithSoftDeletableService = Locator.GetServiceNotNull<RunWithSoftDeletableService>();
      }
    }

    internal static bool kMUXWMh8vxSxDxnLjFNY() => EntityExtensions.Yc6cvph8CAMfTy2PD3mv == null;

    internal static EntityExtensions N3km9Rh88D50FwAuFlSW() => EntityExtensions.Yc6cvph8CAMfTy2PD3mv;
  }
}
