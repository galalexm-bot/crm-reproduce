using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.Core.Model.Managers;

[ServiceContract]
public interface ICurrentPageService
{
	CurrentPageModel CurrentPageViewModel { get; }

	void SetCurrentPartialViewItemUid(Guid uid);

	System.Threading.Tasks.Task ChangeViewMode(InterfaceBuilderViewMode viewMode);

	System.Threading.Tasks.Task SetCurrentPageUidAsync(Guid moduleUid, Guid uid, Guid typeUid, InterfaceBuilderViewMode viewMode = InterfaceBuilderViewMode.Runtime);

	void SetModuleUid(Guid moduleUid);

	IMetadata GetCurrentMetadata();

	System.Threading.Tasks.Task<UIViewModel> LoadComponentMetadataItem(Guid parentItemUid, ComponentViewItem componentViewItem, InterfaceBuilderViewMode viewMode = InterfaceBuilderViewMode.Runtime, bool cacheClear = false);

	UIViewModel GetComponentMetadata(Guid parentItemUid, ViewItem viewItem);

	UIViewModel GetCurrentItemMetadata();

	System.Threading.Tasks.Task SetScriptVisible(bool value, CodeType codeType = CodeType.Client);

	System.Threading.Tasks.Task Save(Action<System.Threading.Tasks.Task> continuation);

	System.Threading.Tasks.Task Publish(Action<System.Threading.Tasks.Task> continuation, InterfaceBuilderViewMode viewMode = InterfaceBuilderViewMode.Design);

	Guid GetFunctionItemUid(Guid componentUid, Guid functionHeaderUid);

	System.Collections.Generic.IEnumerable<EntityDependency> GetEntityDependencies();

	void ClearRenderComponentCache(Guid parentItemUid, Guid renderUid);

	void UpdateComponentModel(RenderComponentModel model);

	void UpdateEntityDependencies(System.Collections.Generic.IEnumerable<EntityDependency> entityDependencies);

	System.Collections.Generic.IEnumerable<RenderExtensionPointModel> GetExtensionPointImplementations(string pointId, Guid typeUid);
}
