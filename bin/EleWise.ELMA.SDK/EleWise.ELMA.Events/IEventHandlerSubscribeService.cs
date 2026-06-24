using System;

namespace EleWise.ELMA.Events;

public interface IEventHandlerSubscribeService
{
	IDisposable Subscribe(IEventHandler observer);
}
