using System.Collections.Generic;

namespace EleWise.ELMA.Runtime.Db.Actions;

public interface IActionsHolder
{
	List<IDbAction> TablesCreatedActions { get; }

	List<IDbAction> TablesDeletedActions { get; }

	List<IDbAction> ForeignKeysCreatedActions { get; }

	List<IDbAction> PrimaryKeysCreatedActions { get; }
}
