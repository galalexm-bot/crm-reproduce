using System;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class DocumentPermissionsReplacementTaskEditModel
{
	private readonly IReplacementTask replacementTask;

	private bool @checked;

	public bool Checked { get; private set; }

	public Guid Uid { get; private set; }

	public long ReplacementTaskId { get; private set; }

	public IEntity Entity { get; private set; }

	public Guid EntityUid => InterfaceActivator.UID(Entity.GetType());

	public DocumentPermissionsReplacementTaskEditModel(Guid uid, IReplacementTask replacementTask, IEntity entity, bool @checked)
	{
		this.replacementTask = replacementTask;
		Uid = uid;
		ReplacementTaskId = replacementTask.Id;
		Entity = entity.CastAsRealType();
		Checked = @checked;
	}
}
