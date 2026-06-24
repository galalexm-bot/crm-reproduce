using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.API.Models;
using EleWise.ELMA.Tasks.ExtensionPoints.API;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Service.v1;

namespace EleWise.ELMA.Tasks.Components;

[Component(Order = int.MaxValue)]
public class UnknownTaskUpdatePackages : ITaskUpdatePackages
{
	[Component(Order = int.MaxValue)]
	internal class PackageService : TaskUpdatePackageServiceBase
	{
		public override string ServiceName => SR.T("Неподдерживаемые типы задач (будут возращаться все типы задач, имеющиеся в системе)");

		public override Guid ServiceUid => serviceUid;

		public override IEnumerable<Type> KnownTypes(ICustomAttributeProvider provider)
		{
			yield return typeof(UnknownTaskPackage);
		}
	}

	private static readonly Guid serviceUid = new Guid("0CA41BA8-44D0-46F3-9886-52E6FE72DEDE");

	private static Guid[] taskUids;

	private static object taskUidsLocker = new object();

	public Guid ServiceUid => serviceUid;

	private static IEnumerable<Guid> TaskUids
	{
		get
		{
			if (taskUids != null)
			{
				return taskUids;
			}
			lock (taskUidsLocker)
			{
				if (taskUids != null)
				{
					return taskUids;
				}
				taskUids = (from m in MetadataLoader.GetChildClasses((ClassMetadata)InterfaceActivator.LoadMetadata<ITaskBase>(), loadImplementation: false)
					select m.Uid).ToArray();
				return taskUids;
			}
		}
	}

	public Guid[] TypeUids
	{
		get
		{
			List<Guid> typeUids = (from service in ComponentManager.Current.GetExtensionPoints<ITaskUpdatePackages>()
				where service.ServiceUid != ServiceUid
				join guid in PackageChangesService.DataSets on service.ServiceUid equals guid
				select service).SelectMany((ITaskUpdatePackages service) => service.TypeUids).ToList();
			return TaskUids.Where((Guid tu) => !typeUids.Contains(tu)).ToArray();
		}
	}

	public IEnumerable<PackageBase> ConvertPackages(IEnumerable<ITaskBase> updateIdPackages)
	{
		return updateIdPackages.Select((Func<ITaskBase, PackageBase>)((ITaskBase task) => new UnknownTaskPackage(task.TypeUid)
		{
			Data = new UnknownTaskWCF(task)
		})).ToArray();
	}

	public IEnumerable<PackageBase> ConvertPackages(Guid serviceUid, IEnumerable<ITaskBase> updateIdPackages)
	{
		return ConvertPackages(updateIdPackages);
	}
}
