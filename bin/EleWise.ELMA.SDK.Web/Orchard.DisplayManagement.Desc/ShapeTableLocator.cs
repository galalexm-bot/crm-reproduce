using System.Collections.Concurrent;

namespace Orchard.DisplayManagement.Descriptors;

public class ShapeTableLocator : IShapeTableLocator, IUnitOfWorkDependency, IDependency
{
	private readonly IShapeTableManager _shapeTableManager;

	private readonly ConcurrentDictionary<string, ShapeTable> _shapeTables = new ConcurrentDictionary<string, ShapeTable>();

	public ShapeTableLocator(IShapeTableManager shapeTableManager)
	{
		_shapeTableManager = shapeTableManager;
	}

	public ShapeTable Lookup(string themeName)
	{
		return _shapeTables.GetOrAdd(themeName ?? "", (string _) => _shapeTableManager.GetShapeTable(themeName));
	}
}
