using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Common.Models;

public class WatchActions : DefaultEntityActions
{
	[Uid("e7ece447-5a97-445e-b01b-ac8467b985d3")]
	[DisplayName(typeof(__Resources_WatchActions), "P_AddWatch_DisplayName")]
	[View(Visibility.Hidden)]
	public const string AddWatch = "e7ece447-5a97-445e-b01b-ac8467b985d3";

	private static Guid addWatchGuid = new Guid("e7ece447-5a97-445e-b01b-ac8467b985d3");

	[Uid("55d73569-93cc-4955-9f50-0d71b5f0ca66")]
	[DisplayName(typeof(__Resources_WatchActions), "P_DeleteWatch_DisplayName")]
	[View(Visibility.Hidden)]
	public const string DeleteWatch = "55d73569-93cc-4955-9f50-0d71b5f0ca66";

	private static Guid deleteWatchGuid = new Guid("55d73569-93cc-4955-9f50-0d71b5f0ca66");

	public static Guid AddWatchGuid => addWatchGuid;

	public static Guid DeleteWatchGuid => deleteWatchGuid;

	protected WatchActions()
	{
	}
}
