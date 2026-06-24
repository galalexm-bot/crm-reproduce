// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Framework.ColumnPropertyExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Runtime.Db.Migrator.Framework
{
  /// <summary>Методы расширения для перечисления ColumnProperty</summary>
  public static class ColumnPropertyExtensions
  {
    private static ColumnPropertyExtensions yZqHfuW2Ft50YOFtQx6G;

    /// <summary>Проверяет, выбрано ли заданное свойство</summary>
    /// <param name="source"></param>
    /// <param name="comparison"></param>
    /// <returns></returns>
    public static bool HasProperty(this ColumnProperty source, ColumnProperty comparison) => (source & comparison) == comparison;

    internal static bool IoNg8PW2BOippeJWJA5M() => ColumnPropertyExtensions.yZqHfuW2Ft50YOFtQx6G == null;

    internal static ColumnPropertyExtensions uNbJuaW2WJJ6KLRB9DXB() => ColumnPropertyExtensions.yZqHfuW2Ft50YOFtQx6G;
  }
}
