using System;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Models.Actions;

[DisplayName("SR.M('Стандартные действия с блоком')")]
public class DefaultTablePartActions : DefaultEntityActions
{
	[Uid("8F125C95-05B7-4D05-89CF-803BD5CBB090")]
	[DisplayName("SR.M('Изменение блока')")]
	[Image(typeof(DefaultEntityActions), "edit", 16, ImageFormatType.IconPack, false)]
	public new const string EditCollection = "8F125C95-05B7-4D05-89CF-803BD5CBB090";

	public static readonly Guid UpdateCollectionGuid = new Guid("8F125C95-05B7-4D05-89CF-803BD5CBB090");
}
