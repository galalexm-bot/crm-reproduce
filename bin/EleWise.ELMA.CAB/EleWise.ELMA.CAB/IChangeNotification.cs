using System;

namespace EleWise.ELMA.CAB;

public interface IChangeNotification
{
	event EventHandler Changed;
}
