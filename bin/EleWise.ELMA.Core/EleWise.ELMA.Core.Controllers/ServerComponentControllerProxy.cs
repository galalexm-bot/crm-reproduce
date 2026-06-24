using System;
using Bridge;

namespace EleWise.ELMA.Core.Controllers;

internal sealed class ServerComponentControllerProxy : IServerController
{
	public ServerComponentControllerProxy(System.Type serverControllerInterfaceType)
	{
		Script.Write("\r\n                this.$initialize();\r\n                this.ctor.$interfaces.push({0});\r\n                this.ctor.$allInterfaces.push({0})", new object[1] { serverControllerInterfaceType });
	}
}
