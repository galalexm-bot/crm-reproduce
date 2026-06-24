using System.Collections.Generic;
using EleWise.ELMA.Events;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.ContentManagement.MetaData.Models;
using Orchard.ContentManagement.ViewModels;

namespace Orchard.ContentManagement.MetaData;

public interface IContentDefinitionEditorEvents : IEventHandler
{
	IEnumerable<TemplateViewModel> TypeEditor(ContentTypeDefinition definition);

	IEnumerable<TemplateViewModel> TypePartEditor(ContentTypePartDefinition definition);

	IEnumerable<TemplateViewModel> PartEditor(ContentPartDefinition definition);

	IEnumerable<TemplateViewModel> PartFieldEditor(ContentPartFieldDefinition definition);

	void TypeEditorUpdating(ContentTypeDefinitionBuilder builder);

	IEnumerable<TemplateViewModel> TypeEditorUpdate(ContentTypeDefinitionBuilder builder, IUpdateModel updateModel);

	void TypeEditorUpdated(ContentTypeDefinitionBuilder builder);

	void TypePartEditorUpdating(ContentTypePartDefinitionBuilder builder);

	IEnumerable<TemplateViewModel> TypePartEditorUpdate(ContentTypePartDefinitionBuilder builder, IUpdateModel updateModel);

	void TypePartEditorUpdated(ContentTypePartDefinitionBuilder builder);

	void PartEditorUpdating(ContentPartDefinitionBuilder builder);

	IEnumerable<TemplateViewModel> PartEditorUpdate(ContentPartDefinitionBuilder builder, IUpdateModel updateModel);

	void PartEditorUpdated(ContentPartDefinitionBuilder builder);

	void PartFieldEditorUpdating(ContentPartFieldDefinitionBuilder builder);

	IEnumerable<TemplateViewModel> PartFieldEditorUpdate(ContentPartFieldDefinitionBuilder builder, IUpdateModel updateModel);

	void PartFieldEditorUpdated(ContentPartFieldDefinitionBuilder builder);
}
