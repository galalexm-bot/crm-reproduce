// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.PropertyDependencyHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Helpers
{
  /// <summary>
  /// Хэлпер для получения зависимостей по свойствам метаданных класса
  /// </summary>
  internal static class PropertyDependencyHelper
  {
    /// <summary>Поиск зависимостей по свойствам</summary>
    /// <param name="md">Метаданные</param>
    /// <param name="allMetadata">Список краткой информации о метаданных</param>
    /// <returns>Список метаданных, которые нужно отметить</returns>
    internal static ICollection<ILinkedObject> PropertiesProcessing(
      ClassMetadata md,
      ICollection<ILinkedObject> allMetadata)
    {
      List<ILinkedObject> resultList = new List<ILinkedObject>();
      foreach (object property in md.Properties)
        PropertyDependencyHelper.ProcessProperty(property, allMetadata, (ICollection<ILinkedObject>) resultList);
      if (md is EntityMetadata entityMetadata)
      {
        if (entityMetadata.TableParts != null)
        {
          foreach (TablePartMetadata tablePart in entityMetadata.TableParts)
            resultList.AddRange((IEnumerable<ILinkedObject>) PropertyDependencyHelper.PropertiesProcessing((ClassMetadata) tablePart, allMetadata));
        }
        if (entityMetadata.EntityTableParts != null)
        {
          foreach (TablePartMetadata entityTablePart in (IEnumerable<TablePartMetadata>) entityMetadata.EntityTableParts)
            resultList.AddRange((IEnumerable<ILinkedObject>) PropertyDependencyHelper.PropertiesProcessing((ClassMetadata) entityTablePart, allMetadata));
        }
        if (entityMetadata.EntityProperties != null)
        {
          foreach (object entityProperty in (IEnumerable<EntityPropertyMetadata>) entityMetadata.EntityProperties)
            PropertyDependencyHelper.ProcessProperty(entityProperty, allMetadata, (ICollection<ILinkedObject>) resultList);
        }
        if (entityMetadata.ViewModelMetadata != null)
          resultList.AddRange((IEnumerable<ILinkedObject>) PropertyDependencyHelper.PropertiesProcessing((ClassMetadata) entityMetadata.ViewModelMetadata, allMetadata));
      }
      return (ICollection<ILinkedObject>) resultList;
    }

    private static void ProcessProperty(
      object property,
      ICollection<ILinkedObject> allMetadata,
      ICollection<ILinkedObject> resultList)
    {
      PropertyMetadata property1 = (PropertyMetadata) property;
      if (property1.SubTypeUid != Guid.Empty)
      {
        // ISSUE: reference to a compiler-generated method
        ILinkedObject linkedObject = allMetadata.FirstOrDefault<ILinkedObject>((Func<ILinkedObject, bool>) (item => PropertyDependencyHelper.\u003C\u003Ec__DisplayClass1_0.T9VXrKv0zTmC5mbLoErw((object) item) == property1.SubTypeUid));
        if (linkedObject != null)
          resultList.Add(linkedObject);
      }
      if (!(property1.Settings is PropertySettings settings))
        return;
      Guid entityTypeUid = settings.EntityTypeUid;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (!allMetadata.Any<ILinkedObject>((Func<ILinkedObject, bool>) (item => PropertyDependencyHelper.\u003C\u003Ec__DisplayClass1_0.UrvN0kvmBdZfK2jlWFPW(PropertyDependencyHelper.\u003C\u003Ec__DisplayClass1_0.T9VXrKv0zTmC5mbLoErw((object) item), PropertyDependencyHelper.\u003C\u003Ec__DisplayClass1_0.MSDvkhvmFvy0oK62f6or((object) property1)))))
        return;
      // ISSUE: reference to a compiler-generated method
      ILinkedObject linkedObject1 = allMetadata.First<ILinkedObject>((Func<ILinkedObject, bool>) (item => PropertyDependencyHelper.\u003C\u003Ec__DisplayClass1_1.CpQ0LUvmGt4GxhaiQyrn(item.Uid, entityTypeUid)));
      resultList.Add(linkedObject1);
    }
  }
}
