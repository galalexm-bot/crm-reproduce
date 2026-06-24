using System;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.ViewItems;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.Documents.Extensions;

public static class ViewItemBuilderExtension
{
	public static ColumnViewItemBuilder<TM> DocumentType<TM>(this ColumnViewItemBuilder<TM> b) where TM : IDocument
	{
		b.Add(new DocumentTypeViewItem());
		return b;
	}

	public static TB Content<TM, T, TB>(this RootViewItemBuilder<TM, T, TB> b) where TM : IDocument where T : RootViewItem, new()where TB : RootViewItemBuilder<TM, T, TB>
	{
		b.Add(new WebDocumentContentViewItem());
		return b as TB;
	}

	public static TB CurrentVersion<TM, T, TB>(this RootViewItemBuilder<TM, T, TB> b) where TM : IDocument where T : RootViewItem, new()where TB : RootViewItemBuilder<TM, T, TB>
	{
		b.Add(new DocumentCurrentVersionViewItem());
		return b as TB;
	}

	public static ColumnViewItemBuilder<TM> VersionCreate<TM>(this ColumnViewItemBuilder<TM> b) where TM : IDocument
	{
		b.Add(new DocumentVersionCreateViewItem());
		return b;
	}

	public static TB Comments<TM, T, TB>(this RootViewItemBuilder<TM, T, TB> b) where TM : IDocument where T : RootViewItem, new()where TB : RootViewItemBuilder<TM, T, TB>
	{
		b.Add(new DocumentCommentsHistoryPanelViewItem());
		return b as TB;
	}

	public static TabLayoutViewItemBuilder<TM> VersionsTab<TM>(this TabLayoutViewItemBuilder<TM> b, Action<DocumentVersionsTabViewItemBuilder<TM>> builder) where TM : IDocument
	{
		builder?.Invoke(new DocumentVersionsTabViewItemBuilder<TM>(b));
		return b;
	}

	public static TB VersionsGrid<TM, T, TB>(this RootViewItemBuilder<TM, T, TB> b, Action<DocumentVersionsGridViewItemBuilder<TM>> builder = null) where TM : IDocument where T : RootViewItem, new()where TB : RootViewItemBuilder<TM, T, TB>
	{
		DocumentVersionsGridViewItemBuilder<TM> obj = new DocumentVersionsGridViewItemBuilder<TM>(b);
		builder?.Invoke(obj);
		return b as TB;
	}

	public static TabLayoutViewItemBuilder<TM> LinksTab<TM>(this TabLayoutViewItemBuilder<TM> b, Action<DocumentLinksTabViewItemBuilder<TM>> builder) where TM : IDocument
	{
		builder?.Invoke(new DocumentLinksTabViewItemBuilder<TM>(b));
		return b;
	}

	public static TB LinksGrid<TM, T, TB>(this RootViewItemBuilder<TM, T, TB> b, Action<DocumentLinksGridViewItemBuilder<TM>> builder = null) where TM : IDocument where T : RootViewItem, new()where TB : RootViewItemBuilder<TM, T, TB>
	{
		DocumentLinksGridViewItemBuilder<TM> obj = new DocumentLinksGridViewItemBuilder<TM>(b);
		builder?.Invoke(obj);
		return b as TB;
	}

	public static TB PermissionSettings<TM, T, TB>(this RootViewItemBuilder<TM, T, TB> b, Action<DocumentPermissionSettingsViewItemBuilder<TM>> builder = null) where TM : IDocument where T : RootViewItem, new()where TB : RootViewItemBuilder<TM, T, TB>
	{
		DocumentPermissionSettingsViewItemBuilder<TM> obj = new DocumentPermissionSettingsViewItemBuilder<TM>(b);
		builder?.Invoke(obj);
		return b as TB;
	}
}
