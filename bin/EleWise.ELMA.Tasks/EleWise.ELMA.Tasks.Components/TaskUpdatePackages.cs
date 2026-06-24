using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.API.Models;
using EleWise.ELMA.Tasks.API.Service.v1;
using EleWise.ELMA.Tasks.ExtensionPoints.API;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
public class TaskUpdatePackages : ITaskUpdatePackages
{
	[Component(Order = 110)]
	internal class PackageService : TaskUpdatePackageServiceBase
	{
		public override string ServiceName => SR.T("Задачи и вопросы");

		public override Guid ServiceUid => serviceUid;

		public override IEnumerable<Type> KnownTypes(ICustomAttributeProvider provider)
		{
			yield return typeof(TaskPackage);
			yield return typeof(ApprovalTaskPackage);
			yield return typeof(QuestionPackage);
		}
	}

	private static readonly Guid serviceUid = new Guid("278C0083-9F22-4289-B0D3-D8DF48ECEB88");

	private static Guid[] typeUids;

	public Guid ServiceUid => serviceUid;

	public Guid[] TypeUids
	{
		get
		{
			object obj = typeUids;
			if (obj == null)
			{
				obj = new Guid[3]
				{
					InterfaceActivator.UID<ITask>(),
					InterfaceActivator.UID<IApprovalTask>(),
					InterfaceActivator.UID<IQuestion>()
				};
				typeUids = (Guid[])obj;
			}
			return (Guid[])obj;
		}
	}

	public IEnumerable<PackageBase> ConvertPackages(IEnumerable<ITaskBase> updateIdPackages)
	{
		return ConvertPackages(TaskBaseUpdatePackageService.Uid, updateIdPackages);
	}

	public IEnumerable<PackageBase> ConvertPackages(Guid serviceUid, IEnumerable<ITaskBase> updateIdPackages)
	{
		return updateIdPackages.OfType<ITask>().Select((Func<ITask, PackageBase>)((ITask task) => new TaskPackage(serviceUid, TypeUids[0])
		{
			Data = TaskWCF.Create(task, needApprovalSubTask: true)
		})).Union(from task in updateIdPackages.OfType<IApprovalTask>()
			select new ApprovalTaskPackage(TypeUids[1])
			{
				Data = new ApprovalTaskWCF(task)
			})
			.Union(from task in updateIdPackages.OfType<IQuestion>()
				select new QuestionPackage(TypeUids[2])
				{
					Data = new QuestionWCF(task)
				})
			.ToArray();
	}
}
