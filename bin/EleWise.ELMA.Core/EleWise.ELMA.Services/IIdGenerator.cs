using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Services;

[ServiceContract]
public interface IIdGenerator
{
	long GenerateNewId(Guid typeUid);
}
