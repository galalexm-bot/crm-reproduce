using System;

namespace EleWise.ELMA.API.Models;

public interface IPublicApplicationToken
{
	IPublicApplication Application { get; }

	string Token { get; }

	DateTime Expire { get; }
}
