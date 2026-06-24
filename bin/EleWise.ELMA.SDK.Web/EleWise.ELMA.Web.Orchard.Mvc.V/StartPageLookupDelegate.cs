using System.Collections.Generic;
using System.Web.WebPages;

namespace EleWise.ELMA.Web.Orchard.Mvc.ViewEngines.Razor;

internal delegate WebPageRenderingBase StartPageLookupDelegate(WebPageRenderingBase page, string fileName, IEnumerable<string> supportedExtensions);
