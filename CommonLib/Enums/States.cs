using System.Runtime.Serialization;
/// <summary>
/// Состояние книги
/// </summary>
namespace CommonLib.Enums
{
    /// <summary>
    /// Состояния книги: Открыта/Закрыта
    /// </summary>
    public enum States
    {
        [EnumMember(Value = "Закрыта")]
        Closed,

        [EnumMember(Value = "Открыта")]
        Open
    }
}
