using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[Component(Order = int.MaxValue)]
public class WorkLogItemUniqueFilterExtension : IUniqueFilterExtension
{
	public const string uid_s = "{BB33273E-8224-4D28-82E6-E1C37F659828}";

	public Guid Uid => new Guid("{BB33273E-8224-4D28-82E6-E1C37F659828}");

	public Type FilterType => InterfaceActivator.TypeOf<IWorkLogObjectSearchFilter>();

	public Type EntityType => InterfaceActivator.TypeOf<IWorkLogItem>();
}
