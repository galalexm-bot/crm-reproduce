// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPMApps.BPMAppManifestSerializationHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace EleWise.ELMA.BPMApps
{
  internal static class BPMAppManifestSerializationHelper
  {
    public static List<TestImportMessages> ValidateChaptersXsiTypes(string manifestXml)
    {
      List<TestImportMessages> testImportMessagesList = new List<TestImportMessages>();
      if (string.IsNullOrWhiteSpace(manifestXml))
        return testImportMessagesList;
      try
      {
        using (XmlReader xmlReader = XmlReader.Create((TextReader) new StringReader(manifestXml)))
        {
          xmlReader.Read();
          xmlReader.MoveToElement();
          xmlReader.Read();
          int content1 = (int) xmlReader.MoveToContent();
          xmlReader.Read();
          int content2 = (int) xmlReader.MoveToContent();
          List<Type> list = ((IEnumerable<Type>) ComponentManager.Current.GetXsiTypes()).ToList<Type>();
          while (xmlReader.NodeType != XmlNodeType.EndElement)
          {
            if (xmlReader.NodeType != XmlNodeType.None)
            {
              if (xmlReader.IsStartElement() && xmlReader.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283203715) && !xmlReader.IsEmptyElement)
              {
                xmlReader.Read();
                int content3 = (int) xmlReader.MoveToContent();
                while (xmlReader.NodeType != XmlNodeType.EndElement)
                {
                  if (xmlReader.IsStartElement() && xmlReader.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236416931) && !xmlReader.IsEmptyElement)
                  {
                    string elementType = xmlReader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710734724));
                    // ISSUE: reference to a compiler-generated method
                    if (list.Where<Type>((Func<Type, bool>) (t => (string) BPMAppManifestSerializationHelper.\u003C\u003Ec__DisplayClass0_0.UaWv8T8zW8KeEkmMhgB8((object) t) == elementType)).ToList<Type>().Count == 0)
                      testImportMessagesList.Add(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978165656), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218150974), (object) elementType)));
                  }
                  xmlReader.Skip();
                  int content4 = (int) xmlReader.MoveToContent();
                }
              }
              xmlReader.Skip();
              int content5 = (int) xmlReader.MoveToContent();
            }
            else
              break;
          }
        }
      }
      catch (Exception ex)
      {
      }
      return testImportMessagesList;
    }
  }
}
