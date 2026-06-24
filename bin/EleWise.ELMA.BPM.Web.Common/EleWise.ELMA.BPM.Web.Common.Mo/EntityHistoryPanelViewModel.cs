using System;
using System.Collections.Generic;
using System.ComponentModel;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class EntityHistoryPanelViewModel
{
	private const int LoadHistoryMaxResultDefault = 10;

	private bool? orderDesc;

	public string HistoryClass { get; set; }

	public bool NeedHistory { get; set; }

	public Guid ObjectUid { get; set; }

	public string DivId { get; set; }

	public bool InTab { get; set; }

	public IEntity<long> Entity { get; set; }

	public List<string> DisableButtons { get; set; }

	public List<string> HideButtons { get; set; }

	public bool AsyncLoading { get; set; }

	[Obsolete("Больше не используется")]
	public bool OrderDesc
	{
		get
		{
			orderDesc = orderDesc ?? (Locator.GetServiceNotNull<IHistoryOrder>().GetOrderType(new HistoryIdParams()) == ListSortDirection.Descending);
			return orderDesc.Value;
		}
	}

	public int LoadHistoryMaxResult => SR.GetSetting("EntityHistoryPanel.LoadHistoryMaxResult", 10);

	public EntityHistoryPanelViewModel()
	{
		AsyncLoading = true;
		NeedHistory = true;
	}
}
