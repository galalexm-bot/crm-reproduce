namespace Orchard.ContentManagement.Handlers;

internal interface IContentTemplateFilter : IContentFilter
{
	void GetContentItemMetadata(GetContentItemMetadataContext context);

	void BuildDisplayShape(BuildDisplayContext context);

	void BuildEditorShape(BuildEditorContext context);

	void UpdateEditorShape(UpdateEditorContext context);
}
