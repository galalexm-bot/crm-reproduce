namespace EleWise.ELMA.Events.Audit;

public interface IAuditEventHolder
{
	IAuditObject Object { get; }

	IAuditAction Action { get; }
}
