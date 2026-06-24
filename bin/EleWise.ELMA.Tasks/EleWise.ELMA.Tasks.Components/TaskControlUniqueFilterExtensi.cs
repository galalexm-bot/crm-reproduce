using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
internal class TaskControlUniqueFilterExtension : IUniqueFilterExtension
{
	private const string UidS = "{79FA8BB0-F5BD-4B7B-936F-4F73D0882776}";

	public static Guid Guid => new Guid("{79FA8BB0-F5BD-4B7B-936F-4F73D0882776}");

	public Guid Uid => Guid;

	public Type FilterType => InterfaceActivator.TypeOf<ITaskControlFilter>();

	public Type EntityType => InterfaceActivator.TypeOf<ITaskBase>();
}
