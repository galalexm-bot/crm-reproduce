using System;
using Bridge.React;

namespace EleWise.ELMA.Core.React.Models;

public interface IRootComponent
{
	ReactElement GetSlotContent(Guid uid = default(Guid));
}
