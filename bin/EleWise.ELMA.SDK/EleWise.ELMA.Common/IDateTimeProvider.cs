using System;

namespace EleWise.ELMA.Common;

public interface IDateTimeProvider
{
	DateTime Now();

	DateTime UtcNow();
}
