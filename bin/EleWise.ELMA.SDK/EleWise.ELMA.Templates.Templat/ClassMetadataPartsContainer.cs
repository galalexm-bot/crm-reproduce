using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Templates.TemplateGenerator;

public sealed class ClassMetadataPartsContainer
{
	private readonly ICollection<ClassMetadata> classMetadataParts;

	public ClassMetadataPartsContainer(IEnumerable<ClassMetadata> classMetadataParts)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.classMetadataParts = new List<ClassMetadata>();
		this.classMetadataParts.AddRange(classMetadataParts.Where((ClassMetadata m) => m != null));
	}

	public IEnumerable<ClassMetadata> GetClassMetadataParts()
	{
		return classMetadataParts;
	}
}
