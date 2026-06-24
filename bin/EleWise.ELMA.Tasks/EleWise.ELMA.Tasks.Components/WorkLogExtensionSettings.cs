using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Tasks.Components;

[Serializable]
public class WorkLogExtensionSettings
{
	[Obsolete("Это свойство будет удалено в ближайших версиях. Для включения/выключения объектов трудозатрат используйте свойство EnabledObjectsUids.")]
	public bool Enabled { get; set; }

	public List<Guid> EnabledObjectsUids { get; set; }
}
