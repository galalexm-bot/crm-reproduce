using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

internal sealed class EnumWebGenerator : EnumGenerator
{
	protected override bool IsExtendable => false;

	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		return Enumerable.Empty<GeneratedFileInfo>();
	}

	protected override void WriteTypeAttributes(ISyntaxNode declaration)
	{
	}

	protected override void WriteValueAttributes(ISyntaxNode field, EnumValueMetadata valueMetadata)
	{
	}
}
