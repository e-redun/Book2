using System.Runtime.Serialization;

namespace CommonLib.Enums
{
    /// <summary>
    /// Набор гарнитур по ГОСТ 3489
    /// </summary>
    public enum FontFamilies
    {
        [EnumMember(Value = "Новая газетная")]
        NewNewsParper,

        [EnumMember(Value = "Школьная")]
        ScholBook,

        [EnumMember(Value = "Бажановская")]
        Bazhanov,

        [EnumMember(Value = "Журнальная")]
        Journal,

        [EnumMember(Value = "Академическая")]
        Academic
    }
}
