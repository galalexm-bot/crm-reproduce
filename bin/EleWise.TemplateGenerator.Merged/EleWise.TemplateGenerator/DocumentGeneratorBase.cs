using System;
using System.Collections.Generic;
using EleWise.TemplateGenerator.DataSources;

namespace EleWise.TemplateGenerator;

public abstract class DocumentGeneratorBase : GeneratorBase
{
	public abstract ICollection<Exception> LastExceptions { get; }

	public DocumentGeneratorBase(IGeneratorProvider provider = null)
		: base(provider)
	{
	}

	public void Generate(object dataSourceObject)
	{
		Generate(base.Provider.ConvertObjectToDataSource(dataSourceObject));
	}

	public IEnumerable<ValidateMessage> Validate(object dataSourceObject)
	{
		return Validate(base.Provider.ConvertObjectToDataSource(dataSourceObject));
	}

	public abstract void Generate(IGeneratorDataSource dataSource);

	public abstract IEnumerable<ValidateMessage> Validate(IGeneratorDataSource dataSourceType);
}
