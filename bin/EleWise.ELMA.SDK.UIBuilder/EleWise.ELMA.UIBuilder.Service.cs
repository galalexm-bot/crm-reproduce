namespace EleWise.ELMA.Serialization
{
    using Bridge;

    /// <summary>
    /// Контейнер для свойств в Proxy Dto
    /// </summary>
    [ObjectLiteral]
    public sealed class PropertiesContainer
    {
        /// <summary>
        /// Имя типа
        /// </summary>
        [Name("$typeName")]
        public string TypeName { get; set; }

        /// <summary>
        /// Хеш типа
        /// </summary>
        [Name("$t")]
        public string TypeHash { get; set; }
    }
}
