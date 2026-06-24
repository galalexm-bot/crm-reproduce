using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Logging;

namespace EleWise.ELMA.Model.Types;

public abstract class RefTypeDescriptor<T, TSettings> : SimpleTypeDescriptor<T, TSettings> where TSettings : TypeSettings
{
	public RefTypeDescriptor(ILogger logger)
		: base(logger)
	{
	}
}
