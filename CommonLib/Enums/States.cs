using System.Runtime.Serialization;
/// <summary>
/// Состояние книги
/// </summary>
namespace CommonLib.Enums
{
    public enum States
    {
        [EnumMember(Value = "Закрыта")]
        Closed,

        [EnumMember(Value = "Открыта")]
        Open
    }
}
