// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Services.FindLinkedObjectService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.Metadata.Services
{
  /// <summary>Сервис поиска связных объектов</summary>
  [Service]
  internal sealed class FindLinkedObjectService : IFindLinkedObjectService
  {
    /// <summary>Список точек расширения для поиска связных объектов</summary>
    private IEnumerable<ILinkedFinder> linkedObjectsFinders;
    internal static FindLinkedObjectService LBCiFnbL2Z48coVTQnsx;

    /// <summary>Ctor</summary>
    /// <param name="linkedObjectsFinders">Точки расширения</param>
    public FindLinkedObjectService(IEnumerable<ILinkedFinder> linkedObjectsFinders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.linkedObjectsFinders = linkedObjectsFinders;
    }

    /// <inheritdoc />
    public LinkedObjectsSearchResult FindLinkedObjects(RuntimeObjectsSearchParams searchParams)
    {
      int num = 2;
      RuntimeObjectsContext emptyContext;
      while (true)
      {
        switch (num)
        {
          case 1:
            emptyContext.CheckedObjects.AddRange<ILinkedObject>((IEnumerable<ILinkedObject>) searchParams.CheckedObjects);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 2:
            emptyContext = new RuntimeObjectsContext();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return new LinkedObjectsSearchResult(this.GetLinkedObjects(emptyContext, searchParams.ObjectsToSearching));
    }

    /// <inheritdoc />
    public LinkedObjectsSearchResult FindLinkedObjects(LinkedObjectsSearchParams searchParams)
    {
      int num = 2;
      LinkedObjectsContext context;
      while (true)
      {
        switch (num)
        {
          case 1:
            context.AllObjects.AddRange<ILinkedObject>((IEnumerable<ILinkedObject>) searchParams.AllObjects);
            num = 3;
            continue;
          case 2:
            context = new LinkedObjectsContext();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
            continue;
          case 3:
            context.CheckedObjects.AddRange<ILinkedObject>((IEnumerable<ILinkedObject>) searchParams.CheckedObjects);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return new LinkedObjectsSearchResult(this.GetLinkedObjects(context, searchParams.ObjectsToSearching));
    }

    /// <summary>Рекурсивная проверка по всем точкам расширения</summary>
    private ICollection<ILinkedObject> GetLinkedObjects(
      LinkedObjectsContext context,
      ICollection<ILinkedObject> objectsToSearching)
    {
      List<ILinkedObject> linkedObjectList = new List<ILinkedObject>();
      List<ILinkedObject> linkedObjects1 = new List<ILinkedObject>();
      foreach (ILinkedFinder linkedObjectsFinder in this.linkedObjectsFinders)
      {
        FindLinkedObjectsResult linkedObjects2 = linkedObjectsFinder.FindLinkedObjects(objectsToSearching, context);
        if (linkedObjects2 != null)
        {
          linkedObjectList.AddRange((IEnumerable<ILinkedObject>) linkedObjects2.LinkedObjects);
          linkedObjects1.AddRange((IEnumerable<ILinkedObject>) linkedObjects2.AddedObjects);
        }
      }
      if (linkedObjectList.Any<ILinkedObject>())
        linkedObjects1.AddRange((IEnumerable<ILinkedObject>) this.GetLinkedObjects(context, (ICollection<ILinkedObject>) linkedObjectList));
      return (ICollection<ILinkedObject>) linkedObjects1;
    }

    /// <summary>Рекурсивная проверка по всем точкам расширения</summary>
    private ICollection<ILinkedObject> GetLinkedObjects(
      RuntimeObjectsContext emptyContext,
      ICollection<ILinkedObject> objectsToSearching)
    {
      List<ILinkedObject> linkedObjectList = new List<ILinkedObject>();
      List<ILinkedObject> linkedObjects1 = new List<ILinkedObject>();
      foreach (ILinkedFinder linkedObjectsFinder in this.linkedObjectsFinders)
      {
        FindLinkedObjectsResult linkedObjects2 = linkedObjectsFinder.FindLinkedObjects(objectsToSearching, emptyContext);
        if (linkedObjects2 != null)
        {
          linkedObjectList.AddRange((IEnumerable<ILinkedObject>) linkedObjects2.LinkedObjects);
          linkedObjects1.AddRange((IEnumerable<ILinkedObject>) linkedObjects2.AddedObjects);
        }
      }
      if (linkedObjectList.Any<ILinkedObject>())
        linkedObjects1.AddRange((IEnumerable<ILinkedObject>) this.GetLinkedObjects(emptyContext, (ICollection<ILinkedObject>) linkedObjectList));
      return (ICollection<ILinkedObject>) linkedObjects1;
    }

    internal static bool M7FG1hbLe5ie7RQRY4Yg() => FindLinkedObjectService.LBCiFnbL2Z48coVTQnsx == null;

    internal static FindLinkedObjectService zOom0fbLPOgycu58g4A7() => FindLinkedObjectService.LBCiFnbL2Z48coVTQnsx;
  }
}
