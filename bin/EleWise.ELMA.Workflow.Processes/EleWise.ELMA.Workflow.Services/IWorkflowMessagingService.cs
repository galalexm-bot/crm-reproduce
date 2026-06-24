using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

[DeveloperApi(DeveloperApiType.Service)]
[PublicApiMember("WorkflowMessagingServicesApi", "SR.M('Реализация сервиса для работы с сообщениями в процессах Workflow')", "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса можно получить информацию об активынх точках останова экземпляров процессов \r\n    /// //на операции \"Ожидание сообщения\" и отправлять сообщения в процессы\r\n    /// \r\n    /// //запишем сервис в переменную, чтобы с ним легче было работать\r\n    /// var service = PublicAPI.Services.WorkflowMessaging;\r\n    /// \r\n    /// //Чтобы получить информацию об активных точках останова экземпляров процессов на операции \"Ожидание сообщения\" используйте следующие функции:\r\n    /// //1.GetActiveMessageBookmarkInfos(instanceList) - проверяет только по процессам, записанным в переменную\r\n    /// var info = services.GetActiveMessageBookmarkInfos(instanceList);\r\n    /// \r\n    /// //2.GetActiveMessageBookmarkInfos(instanceList, allowSubInstances) - проверяет с учётом подпроцессов\r\n    /// var info = services.GetActiveMessageBookmarkInfos(instanceList, allowSubInstances);\r\n    /// \r\n    /// //Чтобы отправить сообщение, используйте следующие функции:\r\n    /// //1.SendMessage(messageType, data) - отправить сообщение\r\n    /// var sendResult = service.SendMessage(messageType, data);\r\n    /// \r\n    /// //2.SendMessage(instance, messageType, data) - отправить сообщение в указанный экземпляр\r\n    /// var sendResult = service.SendMessage(instance, messageType, data);\r\n    /// </code>')")]
public interface IWorkflowMessagingService
{
	[PublicApiNodeId("WorkflowMessagingServicesApi")]
	IList<WorkflowMessageBookmarkInfo> GetActiveMessageBookmarkInfos(IEnumerable<IWorkflowInstance> instanceList);

	[PublicApiNodeId("WorkflowMessagingServicesApi")]
	IList<WorkflowMessageBookmarkInfo> GetActiveMessageBookmarkInfos(IEnumerable<IWorkflowInstance> instanceList, bool allowSubInstances);

	[PublicApiNodeId("WorkflowMessagingServicesApi")]
	WorkflowMessageSendResult SendMessage(IWorkflowMessageType messageType, WebData data);

	[PublicApiNodeId("WorkflowMessagingServicesApi")]
	WorkflowMessageSendResult SendMessage(IWorkflowInstance instance, IWorkflowMessageType messageType, WebData data);
}
