using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

public sealed class AdditionalMethodsGenerationParameters
{
	internal ClassMetadata Metadata { get; }

	internal List<FormViewItem> Views { get; }

	internal bool CustomView { get; }

	public AdditionalMethodsGenerationParameters(ClassMetadata metadata, FormViewItem view, bool customView = false)
	{
		Contract.ArgumentNotNull(metadata, "metadata");
		Metadata = metadata;
		CustomView = customView;
		Views = new List<FormViewItem>(1) { view };
	}

	public AdditionalMethodsGenerationParameters(ClassMetadata metadata, IEnumerable<FormViewItem> views)
	{
		Contract.ArgumentNotNull(metadata, "metadata");
		Metadata = metadata;
		Views = views?.ToList() ?? new List<FormViewItem>();
	}
}
