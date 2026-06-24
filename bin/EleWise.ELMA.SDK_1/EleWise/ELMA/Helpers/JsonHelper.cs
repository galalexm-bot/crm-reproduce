// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.JsonHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Newtonsoft.Json;
using System.IO;

namespace EleWise.ELMA.Helpers
{
  /// <summary>Хелпер для работы с json-ответами от web-служб.</summary>
  public static class JsonHelper
  {
    /// <summary>
    /// Десериализовать экземпляр указанного класса из потока.
    /// </summary>
    /// <typeparam name="T">Тип класса на выходе после десериализации.</typeparam>
    /// <param name="stream">Поток, содержащий сериализованное представление класса.</param>
    /// <returns>Экземпляр указанного класса, прочитанный из потока.</returns>
    public static T DeserializeResponse<T>(Stream stream)
    {
      using (StreamReader reader1 = new StreamReader(stream))
      {
        using (JsonTextReader reader2 = new JsonTextReader((TextReader) reader1))
          return new JsonSerializer().Deserialize<T>((JsonReader) reader2);
      }
    }
  }
}
