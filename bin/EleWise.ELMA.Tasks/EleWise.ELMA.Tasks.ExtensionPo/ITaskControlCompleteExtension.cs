using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ITaskControlCompleteExtension
{
	bool Can(Type type);

	ITaskBase DoControlComplete(Type type, long taskId, ICommentActionModel actionModel = null);
}
