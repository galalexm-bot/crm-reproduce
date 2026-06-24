// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.AddressSimpleEventRender
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.History;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace EleWise.ELMA.CRM.Web.Components
{
  [Component(Order = 101)]
  public class AddressSimpleEventRender : BaseAuditEventRender
  {
    private readonly IEnumerable<Guid> actions = (IEnumerable<Guid>) new Guid[1]
    {
      DefaultEntityActions.UpdateGuid
    };
    private readonly Guid addressBaseUid = InterfaceActivator.UID<IAddress>();

    protected override IEnumerable<Guid> Actions => this.actions;

    protected override IEnumerable<Guid> Objects
    {
      get
      {
        EntityMetadata metadata = MetadataLoader.LoadMetadata(this.addressBaseUid) as EntityMetadata;
        List<Guid> list = MetadataLoader.GetChildClasses((ClassMetadata) metadata).SelectMany<ClassMetadata, Guid>((Func<ClassMetadata, IEnumerable<Guid>>) (impl =>
        {
          EntityMetadata entityMetadata = impl as EntityMetadata;
          return (IEnumerable<Guid>) new Guid[2]
          {
            entityMetadata.Uid,
            entityMetadata.ImplementationUid
          };
        })).ToList<Guid>();
        list.AddRange((IEnumerable<Guid>) new Guid[2]
        {
          metadata.Uid,
          metadata.ImplementationUid
        });
        return (IEnumerable<Guid>) list;
      }
    }

    protected override IHistoryBaseModel CreateEventData(
      HtmlHelper html,
      EntityActionEventArgs @event,
      IEntityActionHistoryLoader historyLoader)
    {
      Contract.ArgumentNotNull((object) html, nameof (html));
      Contract.ArgumentNotNull((object) @event, "@event");
      Contract.ArgumentNotNull((object) historyLoader, nameof (historyLoader));
      return !(@event.Action.Uid == DefaultEntityActions.UpdateGuid) ? (IHistoryBaseModel) null : this.RenderUserEdit(@event);
    }

    protected override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
    {
      if (@event == null || @event.Action == null)
        return (HistoryPartViewBlock) null;
      return !(@event.Action.Uid == DefaultEntityActions.UpdateGuid) ? (HistoryPartViewBlock) null : this.EditViewBlock();
    }

    private IHistoryBaseModel RenderUserEdit([NotNull] EntityActionEventArgs @event)
    {
      string actionTheme = EleWise.ELMA.SR.T("Изменено свойство контрагента{0}", (object) string.Format(": {0}", @event.ExtendedProperties["Theme"]));
      EditedAddressHistoryModel addressHistoryModel1 = new EditedAddressHistoryModel(@event, actionTheme);
      addressHistoryModel1.OldEntity = (IEntity) (@event.Old as IEntity<long>);
      addressHistoryModel1.NewEntity = (IEntity) (@event.New as IEntity<long>);
      EditedAddressHistoryModel addressHistoryModel2 = addressHistoryModel1;
      if (@event is EditEntityActionEventArgs entityActionEventArgs)
        addressHistoryModel2.ChangedProperties = (IList<PropertyMetadata>) entityActionEventArgs.ChangedProperties.ToList<PropertyMetadata>();
      object obj;
      if (@event.ExtendedProperties.TryGetValue("RelatedModel", out obj) && obj != null)
      {
        IEntity entity = obj as IEntity;
        IMetadata metadata = MetadataLoader.LoadMetadata(entity.GetType());
        ReferenceOnEntity referenceOnEntity = new ReferenceOnEntity((long) entity.GetId(), metadata.Uid);
        addressHistoryModel2.SlaveObject = referenceOnEntity;
        addressHistoryModel2.ActionTheme = EleWise.ELMA.SR.T("Изменено свойство контрагента: {0}", (object) referenceOnEntity.ObjectDispalyName);
        addressHistoryModel2.SlavePropertyName = string.Format(": {0}", @event.ExtendedProperties["Theme"]);
      }
      return (IHistoryBaseModel) addressHistoryModel2;
    }

    private HistoryPartViewBlock EditViewBlock() => new HistoryPartViewBlock()
    {
      HistoryPartType = "action",
      Index = 1,
      RenderDelegate = (Func<HtmlHelper, IHistoryBaseModel, object>) ((html, model) => (object) html.Partial("AuditView/Address.Edit", (object) model))
    };
  }
}
