using System;
using System.Collections.Generic;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Mvc.Models.ServiceHelp;

public class TypesHelpModel
{
	public class Group
	{
		public Guid GroupUid { get; set; }

		public IPublicMetadataGroupInfo GroupInfo { get; set; }

		public int Order { get; set; }

		public List<IPublicMetadataInfo> MetadataInfoList { get; set; }

		public Group()
		{
			MetadataInfoList = new List<IPublicMetadataInfo>();
		}

		public Group(IPublicMetadataGroupInfo groupInfo)
			: this()
		{
			GroupInfo = groupInfo;
			GroupUid = groupInfo?.GroupUid ?? Guid.Empty;
			Order = groupInfo?.Order ?? 0;
		}
	}

	public List<Group> Groups { get; set; }

	public TypesHelpModel()
	{
		Groups = new List<Group>();
	}
}
