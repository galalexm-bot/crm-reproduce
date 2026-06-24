using System;
using EleWise.ELMA.FileProvider.Distributed.Managers;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.FileProvider.Distributed.Models;

[Serializable]
[ClassMap(typeof(ContentOriginMap))]
public class ContentOrigin
{
	public virtual long Id { get; set; }

	public virtual long FileId { get; set; }

	public virtual string SourceGateway { get; set; }
}
