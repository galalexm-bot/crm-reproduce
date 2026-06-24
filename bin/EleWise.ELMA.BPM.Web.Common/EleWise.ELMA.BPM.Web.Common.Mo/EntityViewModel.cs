using System;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class EntityViewModel
{
	public ClassMetadata Metadata { get; set; }

	public IEntity CurrentFolderObject { get; set; }

	public Guid ParentPropertyUid { get; set; }

	public FilterModel Filter { get; set; }
}
