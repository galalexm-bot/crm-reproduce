using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Messages.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IDiscussionAvailableProvider
{
	IEnumerable<Guid> TypeUids { get; }
}
