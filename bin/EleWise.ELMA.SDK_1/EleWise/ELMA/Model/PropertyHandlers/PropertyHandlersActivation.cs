// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.PropertyHandlers.PropertyHandlersActivation
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.PropertyHandlers
{
  /// <summary>
  /// Перехватчик активации сущностей.
  /// Активирует свойство "Дата создания"
  /// </summary>
  [Component]
  internal class PropertyHandlersActivation : IEntityActivationHandler
  {
    internal static PropertyHandlersActivation cHX4xXWstCm1JxECSxVl;

    /// <summary>Заполнить свойства сущности</summary>
    /// <param name="entity">Сущность</param>
    public static void ActivateOnCreate(IEntity entity)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        EntityMetadata entityMetadata;
        PropertyMetadata propertyMetadata1;
        while (true)
        {
          DateTime? nullable1;
          Guid? nullable2;
          Guid? nullable3;
          DateTime? nullable4;
          Guid empty;
          DateTime minValue;
          PropertyMetadata propertyMetadata2;
          int num3;
          int num4;
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
label_45:
              // ISSUE: reference to a compiler-generated method
              propertyMetadata2 = entityMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Handlers.FirstOrDefault<PropertyHandlerInfo>((Func<PropertyHandlerInfo, bool>) (h => PropertyHandlersActivation.\u003C\u003Ec.YkjGhVCWnnQqWX01b13q((object) h) == CreationDatePropertyHandler.UID)) != null));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 13 : 17;
              continue;
            case 3:
              nullable1 = nullable4;
              num2 = 13;
              continue;
            case 4:
              num3 = 0;
              goto label_47;
            case 5:
            case 10:
              goto label_10;
            case 6:
              if (entityMetadata != null)
              {
                num2 = 19;
                continue;
              }
              goto label_9;
            case 7:
              goto label_23;
            case 8:
              if (nullable3.HasValue)
              {
                if (!nullable3.HasValue)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 16 : 8;
                  continue;
                }
                num4 = PropertyHandlersActivation.MCREc7WsAF2urTdHbRTo(nullable3.GetValueOrDefault(), empty) ? 1 : 0;
                break;
              }
              num2 = 12;
              continue;
            case 9:
              nullable3 = nullable2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 21 : 2;
              continue;
            case 11:
              nullable2 = (Guid?) PropertyHandlersActivation.H3YV0tWsHOGbEEVbuHHF((object) entity, PropertyHandlersActivation.VYBfL7Ws6o0OixthlOxl((object) propertyMetadata1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            case 12:
              num4 = 0;
              break;
            case 13:
              minValue = DateTime.MinValue;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 11 : 22;
              continue;
            case 14:
              goto label_39;
            case 15:
              if (!nullable1.HasValue)
              {
                num2 = 18;
                continue;
              }
              num3 = PropertyHandlersActivation.cDwu59WsxL23CAcxxc8W(nullable1.GetValueOrDefault(), minValue) ? 1 : 0;
              goto label_47;
            case 16:
              num4 = 1;
              break;
            case 17:
              if (propertyMetadata2 != null)
              {
                num2 = 26;
                continue;
              }
              goto label_21;
            case 18:
              num3 = 1;
              goto label_47;
            case 19:
              List<PropertyMetadata> properties = entityMetadata.Properties;
              // ISSUE: reference to a compiler-generated field
              Func<PropertyMetadata, bool> func = PropertyHandlersActivation.\u003C\u003Ec.\u003C\u003E9__0_0;
              Func<PropertyMetadata, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                PropertyHandlersActivation.\u003C\u003Ec.\u003C\u003E9__0_0 = predicate = (Func<PropertyMetadata, bool>) (p =>
                {
                  int num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (!PropertyHandlersActivation.\u003C\u003Ec.VJIoFjCWTKJLfbpjNqek(PropertyHandlersActivation.\u003C\u003Ec.cchH9ACWKSQKo196kOHe((object) p), PropertyHandlersActivation.\u003C\u003Ec.TdtLKVCWXDPr2T3qQaIM(322893104 - -1992822529 ^ -1979225181)))
                        {
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
                          continue;
                        }
                        goto label_2;
                      case 2:
                        goto label_2;
                      default:
                        goto label_3;
                    }
                  }
label_2:
                  // ISSUE: reference to a compiler-generated method
                  return PropertyHandlersActivation.\u003C\u003Ec.bHUl2hCWkjJIwLq6pEq5((object) p);
label_3:
                  return false;
                });
              }
              else
                goto label_49;
label_41:
              propertyMetadata1 = properties.FirstOrDefault<PropertyMetadata>(predicate);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 23 : 3;
              continue;
label_49:
              predicate = func;
              goto label_41;
            case 20:
label_26:
              PropertyHandlersActivation.lh5e3bWsmQM0HyMyrYk6((object) entity, PropertyHandlersActivation.VYBfL7Ws6o0OixthlOxl((object) propertyMetadata2), (object) PropertyHandlersActivation.qd3N5UWs08HThvM1TX9r());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 10 : 14;
              continue;
            case 21:
              empty = Guid.Empty;
              num2 = 8;
              continue;
            case 22:
              if (nullable1.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 14 : 15;
                continue;
              }
              goto case 4;
            case 23:
              if (propertyMetadata1 != null)
              {
                num2 = 11;
                continue;
              }
              goto case 2;
            case 24:
              goto label_12;
            case 25:
              if (nullable4.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 3 : 3;
                continue;
              }
              goto case 20;
            case 26:
              nullable4 = (DateTime?) PropertyHandlersActivation.H3YV0tWsHOGbEEVbuHHF((object) entity, PropertyHandlersActivation.VYBfL7Ws6o0OixthlOxl((object) propertyMetadata2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 15 : 25;
              continue;
            default:
              if (!nullable2.HasValue)
              {
                num2 = 10;
                continue;
              }
              goto case 9;
          }
          if (num4 != 0)
          {
            num2 = 5;
            continue;
          }
          goto label_45;
label_47:
          if (num3 == 0)
            num2 = 24;
          else
            goto label_26;
        }
label_10:
        entity.SetPropertyValue(PropertyHandlersActivation.VYBfL7Ws6o0OixthlOxl((object) propertyMetadata1), (object) PropertyHandlersActivation.wQJf8YWs748TAItewD8r());
        num1 = 2;
        continue;
label_23:
        entityMetadata = MetadataLoader.LoadMetadata(entity.GetType()) as EntityMetadata;
        num1 = 6;
      }
label_7:
      return;
label_39:
      return;
label_12:
      return;
label_9:
      return;
label_21:;
    }

    public void OnActivating(IEntity entity) => PropertyHandlersActivation.dCPkdYWsyk0E6VC3DyP7((object) entity);

    public void OnActivated(IEntity entity)
    {
    }

    public PropertyHandlersActivation()
    {
      PropertyHandlersActivation.c6h96bWsMSjE6QOfNEDQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Guid VYBfL7Ws6o0OixthlOxl([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object H3YV0tWsHOGbEEVbuHHF([In] object obj0, Guid propertyUid) => ((IEntity) obj0).GetPropertyValue(propertyUid);

    internal static bool MCREc7WsAF2urTdHbRTo([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid wQJf8YWs748TAItewD8r() => Guid.NewGuid();

    internal static bool cDwu59WsxL23CAcxxc8W([In] DateTime obj0, [In] DateTime obj1) => obj0 == obj1;

    internal static DateTime qd3N5UWs08HThvM1TX9r() => DateTime.Now;

    internal static void lh5e3bWsmQM0HyMyrYk6([In] object obj0, Guid propertyUid, [In] object obj2) => ((IEntity) obj0).SetPropertyValue(propertyUid, obj2);

    internal static bool aL4rCbWswUMDO6LP57Li() => PropertyHandlersActivation.cHX4xXWstCm1JxECSxVl == null;

    internal static PropertyHandlersActivation yxecLwWs4LvPSFNY3nWW() => PropertyHandlersActivation.cHX4xXWstCm1JxECSxVl;

    internal static void dCPkdYWsyk0E6VC3DyP7([In] object obj0) => PropertyHandlersActivation.ActivateOnCreate((IEntity) obj0);

    internal static void c6h96bWsMSjE6QOfNEDQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
