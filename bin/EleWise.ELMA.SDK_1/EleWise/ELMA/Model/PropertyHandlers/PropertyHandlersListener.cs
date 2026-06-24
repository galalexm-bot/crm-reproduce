// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.PropertyHandlers.PropertyHandlersListener
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.PropertyHandlers
{
  /// <summary>
  /// Прослушиватель событий для основных обработчиков свойств
  /// </summary>
  /// <remarks>Используются обработчики: дата создания и изменения</remarks>
  [Component]
  internal class PropertyHandlersListener : EntityEventsListener
  {
    private IContextBoundVariableService contextBoundVariableService;
    private static PropertyHandlersListener p0AKX9WsJ5pWaDlIEHZi;

    /// <summary>Ctor</summary>
    /// <param name="contextBoundVariableService">IContextBoundVariableService</param>
    public PropertyHandlersListener(
      IContextBoundVariableService contextBoundVariableService)
    {
      PropertyHandlersListener.CJbfLdWslRUQ83gtHhds();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.contextBoundVariableService = contextBoundVariableService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    private static void ActivateOnInsertProperties(
      object @event,
      object eventState,
      object entity,
      object metadata)
    {
      int num1 = 9;
      PropertyMetadata propertyMetadata1;
      PropertyMetadata propertyMetadata2;
      while (true)
      {
        int num2 = num1;
        int index1;
        object propertyValue;
        object obj;
        int index2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (index1 >= 0)
              {
                eventState[index1] = propertyValue;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 11 : 3;
                continue;
              }
              num2 = 7;
              continue;
            case 2:
              index2 = Array.IndexOf<string>((string[]) PropertyHandlersListener.SlTi02Wsg3sR0OeaX7CZ(PropertyHandlersListener.VnLW1SWsrhD18fMvHRdZ(@event)), propertyMetadata2.Name);
              num2 = 10;
              continue;
            case 3:
              List<PropertyMetadata> properties = ((ClassMetadata) metadata).Properties;
              // ISSUE: reference to a compiler-generated field
              Func<PropertyMetadata, bool> func1 = PropertyHandlersListener.\u003C\u003Ec.\u003C\u003E9__2_1;
              Func<PropertyMetadata, bool> predicate1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                PropertyHandlersListener.\u003C\u003Ec.\u003C\u003E9__2_1 = predicate1 = (Func<PropertyMetadata, bool>) (p =>
                {
                  List<PropertyHandlerInfo> handlers = p.Handlers;
                  // ISSUE: reference to a compiler-generated field
                  Func<PropertyHandlerInfo, bool> func2 = PropertyHandlersListener.\u003C\u003Ec.\u003C\u003E9__2_2;
                  Func<PropertyHandlerInfo, bool> predicate2;
                  if (func2 == null)
                  {
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    PropertyHandlersListener.\u003C\u003Ec.\u003C\u003E9__2_2 = predicate2 = (Func<PropertyHandlerInfo, bool>) (h => PropertyHandlersListener.\u003C\u003Ec.y7TIuVCWavcYltFsyRZd(PropertyHandlersListener.\u003C\u003Ec.cM9SNgCWp2DdiA6PE3wD((object) h), CreationDatePropertyHandler.UID));
                  }
                  else
                    goto label_1;
label_3:
                  return handlers.FirstOrDefault<PropertyHandlerInfo>(predicate2) != null;
label_1:
                  predicate2 = func2;
                  goto label_3;
                });
              }
              else
                goto label_25;
label_24:
              propertyMetadata1 = properties.FirstOrDefault<PropertyMetadata>(predicate1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 6;
              continue;
label_25:
              predicate1 = func1;
              goto label_24;
            case 4:
              goto label_16;
            case 5:
              index1 = Array.IndexOf<string>((string[]) PropertyHandlersListener.SlTi02Wsg3sR0OeaX7CZ(PropertyHandlersListener.VnLW1SWsrhD18fMvHRdZ(@event)), (string) PropertyHandlersListener.JxaknEWsLPHQLZLvnslZ((object) propertyMetadata1));
              num2 = 12;
              continue;
            case 6:
              if (propertyMetadata1 != null)
              {
                num2 = 5;
                continue;
              }
              goto label_3;
            case 7:
              goto label_5;
            case 8:
              if (propertyMetadata2 != null)
              {
                num2 = 2;
                continue;
              }
              goto case 3;
            case 9:
              goto label_20;
            case 10:
              obj = PropertyHandlersListener.LR3hv9WsjiUG5rLoQqlf(entity, PropertyHandlersListener.XM05CHWs5PmhiworumVZ((object) propertyMetadata2));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
              continue;
            case 11:
              goto label_22;
            case 12:
              propertyValue = ((IEntity) entity).GetPropertyValue(PropertyHandlersListener.XM05CHWs5PmhiworumVZ((object) propertyMetadata1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
              continue;
            default:
              if (index2 >= 0)
              {
                eventState[index2] = obj;
                num2 = 3;
                continue;
              }
              num2 = 4;
              continue;
          }
        }
label_20:
        propertyMetadata2 = ((ClassMetadata) metadata).Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p =>
        {
          int num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                if (!PropertyHandlersListener.\u003C\u003Ec.btai9tCWNqwtG7NgeUbL((object) p.Name, PropertyHandlersListener.\u003C\u003Ec.nnIc8OCW16kOmZTRVoMl(1642859704 ^ 1642881834)))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
                  continue;
                }
                goto label_4;
              case 2:
                goto label_4;
              default:
                goto label_5;
            }
          }
label_4:
          // ISSUE: reference to a compiler-generated method
          return PropertyHandlersListener.\u003C\u003Ec.olArjKCW3R3AdjjEtene((object) p);
label_5:
          return false;
        }));
        num1 = 8;
      }
label_22:
      return;
label_5:
      throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501325383), PropertyHandlersListener.JxaknEWsLPHQLZLvnslZ((object) propertyMetadata1)));
label_3:
      return;
label_16:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) PropertyHandlersListener.MfewUIWsYUuRhYg9QBTj(-740338220 ^ -740485606), PropertyHandlersListener.JxaknEWsLPHQLZLvnslZ((object) propertyMetadata2)));
    }

    public override bool OnPreInsert(PreInsertEvent @event)
    {
      int num = 5;
      IEntity entity;
      EntityMetadata entityMetadata;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (entityMetadata == null)
            {
              num = 6;
              continue;
            }
            PropertyHandlersListener.krwRV6WszhGM2j7ge18r((object) @event, PropertyHandlersListener.l1UHLBWscGfLMjeDybAO((object) @event), (object) entity, (object) entityMetadata);
            num = 3;
            continue;
          case 2:
            goto label_6;
          case 3:
            goto label_2;
          case 4:
            if (entity != null)
            {
              PropertyHandlersListener.o0RAiwWssEltsYnLgjXY((object) entity);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 2;
            continue;
          case 5:
            entity = PropertyHandlersListener.N5UycLWsUfXwDUdP4yJv((object) @event) as IEntity;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 4 : 2;
            continue;
          case 6:
            goto label_8;
          default:
            entityMetadata = MetadataLoader.LoadMetadata(@event.Entity.GetType()) as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
            continue;
        }
      }
label_2:
      return false;
label_6:
      return false;
label_8:
      return false;
    }

    public override bool OnPreUpdate(PreUpdateEvent @event)
    {
      int num1 = 10;
      PropertyMetadata propertyMetadata;
      while (true)
      {
        int num2 = num1;
        IEntity entity;
        DateTime now;
        int index;
        EntityMetadata metadata;
        PreUpdateEvent event1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (index >= 0)
              {
                num2 = 11;
                continue;
              }
              goto label_5;
            case 2:
              goto label_17;
            case 3:
              PropertyHandlersListener.ActivateOnInsertProperties((object) event1, (object) event1.State, (object) entity, (object) metadata);
              num2 = 17;
              continue;
            case 4:
              PropertyHandlersListener.bx6r9tWcBekiSjXLlhje((object) entity, PropertyHandlersListener.XM05CHWs5PmhiworumVZ((object) propertyMetadata), (object) now);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 6 : 1;
              continue;
            case 5:
            case 18:
              goto label_24;
            case 6:
              index = Array.IndexOf<string>((string[]) PropertyHandlersListener.SlTi02Wsg3sR0OeaX7CZ(PropertyHandlersListener.VnLW1SWsrhD18fMvHRdZ((object) event1)), (string) PropertyHandlersListener.JxaknEWsLPHQLZLvnslZ((object) propertyMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
              continue;
            case 7:
              goto label_25;
            case 8:
              if (propertyMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 14 : 18;
                continue;
              }
              goto case 13;
            case 9:
              event1 = @event;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
              continue;
            case 10:
              goto label_4;
            case 11:
              event1.State[index] = (object) now;
              num2 = 5;
              continue;
            case 12:
              goto label_7;
            case 13:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!((ComponentManager) PropertyHandlersListener.He5W8VWcF7loaOYqlR94()).GetExtensionPoints<IChangePropertyHandlerIgnoreProvider>().Where<IChangePropertyHandlerIgnoreProvider>((Func<IChangePropertyHandlerIgnoreProvider, bool>) (p => PropertyHandlersListener.\u003C\u003Ec__DisplayClass4_0.OA2dMCCW6lrm96iQrANB((object) p, PropertyHandlersListener.\u003C\u003Ec__DisplayClass4_0.tE5jh3CW4nZEKL0fmFJ7((object) metadata)))).Select<IChangePropertyHandlerIgnoreProvider, bool>((Func<IChangePropertyHandlerIgnoreProvider, bool>) (p => PropertyHandlersListener.\u003C\u003Ec__DisplayClass4_0.emVUhSCWHNdWvRNIypoQ((object) p, (object) event1))).ToList<bool>().Contains(true))
              {
                num2 = 14;
                continue;
              }
              goto label_25;
            case 14:
              now = DateTime.Now;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 4;
              continue;
            case 15:
              if (entity != null)
              {
                metadata = MetadataLoader.LoadMetadata(PropertyHandlersListener.N5UycLWsUfXwDUdP4yJv((object) event1).GetType()) as EntityMetadata;
                num2 = 19;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 12 : 10;
              continue;
            case 16:
              goto label_5;
            case 17:
              goto label_27;
            case 19:
              if (metadata != null)
              {
                num2 = 3;
                continue;
              }
              goto label_17;
            default:
              entity = PropertyHandlersListener.N5UycLWsUfXwDUdP4yJv((object) event1) as IEntity;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 15 : 6;
              continue;
          }
        }
label_4:
        num1 = 9;
        continue;
label_27:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        propertyMetadata = metadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => p.Handlers.FirstOrDefault<PropertyHandlerInfo>((Func<PropertyHandlerInfo, bool>) (h => PropertyHandlersListener.\u003C\u003Ec.y7TIuVCWavcYltFsyRZd(PropertyHandlersListener.\u003C\u003Ec.cM9SNgCWp2DdiA6PE3wD((object) h), ChangeDatePropertyHandler.UID))) != null));
        num1 = 8;
      }
label_5:
      throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217637641), (object) propertyMetadata.Name));
label_7:
      return false;
label_17:
      return false;
label_24:
      return false;
label_25:
      return false;
    }

    internal static void CJbfLdWslRUQ83gtHhds() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool WEXTrdWs9UQ5K2dOoA2M() => PropertyHandlersListener.p0AKX9WsJ5pWaDlIEHZi == null;

    internal static PropertyHandlersListener xXJ6TFWsdOnZqUGpmgBH() => PropertyHandlersListener.p0AKX9WsJ5pWaDlIEHZi;

    internal static object VnLW1SWsrhD18fMvHRdZ([In] object obj0) => (object) ((AbstractPreDatabaseOperationEvent) obj0).Persister;

    internal static object SlTi02Wsg3sR0OeaX7CZ([In] object obj0) => (object) ((IEntityPersister) obj0).PropertyNames;

    internal static Guid XM05CHWs5PmhiworumVZ([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object LR3hv9WsjiUG5rLoQqlf([In] object obj0, Guid propertyUid) => ((IEntity) obj0).GetPropertyValue(propertyUid);

    internal static object MfewUIWsYUuRhYg9QBTj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object JxaknEWsLPHQLZLvnslZ([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object N5UycLWsUfXwDUdP4yJv([In] object obj0) => ((AbstractPreDatabaseOperationEvent) obj0).Entity;

    internal static void o0RAiwWssEltsYnLgjXY([In] object obj0) => PropertyHandlersActivation.ActivateOnCreate((IEntity) obj0);

    internal static object l1UHLBWscGfLMjeDybAO([In] object obj0) => (object) ((PreInsertEvent) obj0).State;

    internal static void krwRV6WszhGM2j7ge18r([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => PropertyHandlersListener.ActivateOnInsertProperties(obj0, obj1, obj2, obj3);

    internal static object He5W8VWcF7loaOYqlR94() => (object) ComponentManager.Current;

    internal static void bx6r9tWcBekiSjXLlhje([In] object obj0, Guid propertyUid, [In] object obj2) => ((IEntity) obj0).SetPropertyValue(propertyUid, obj2);
  }
}
