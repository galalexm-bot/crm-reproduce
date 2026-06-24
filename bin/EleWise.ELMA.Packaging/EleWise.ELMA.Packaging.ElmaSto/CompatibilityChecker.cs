using System.Collections.Generic;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest.Module;

public delegate ICollection<string> CompatibilityChecker(ModuleManifest @new, ModuleManifest old);
