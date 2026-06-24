using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Services;

[ServiceContract]
public interface INotificationService
{
	void Error(string title, string message, bool autoClosed = true);

	void Success(string title, string message, bool autoClosed = true);

	void Warning(string title, string message, bool autoClosed = true);

	void Info(string title, string message, bool autoClosed = true);
}
