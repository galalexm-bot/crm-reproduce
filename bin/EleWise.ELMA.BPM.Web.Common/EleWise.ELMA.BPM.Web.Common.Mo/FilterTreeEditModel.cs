using System;
using EleWise.ELMA.Web.Mvc.Models.Trees;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class FilterTreeEditModel
{
	public Guid TypeUid { get; set; }

	public Guid? Code { get; set; }

	public TreeModel FilterTreeModel { get; set; }

	public bool AccessSharedFilter { get; set; }

	public bool ShowBackButton { get; set; }
}
