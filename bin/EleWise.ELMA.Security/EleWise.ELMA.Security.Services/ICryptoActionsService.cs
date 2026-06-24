using System;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security.Services;

public interface ICryptoActionsService
{
	Guid[] ActionUids { get; }

	bool IsProvidersEquals(EleWise.ELMA.Security.Models.IUser user);
}
