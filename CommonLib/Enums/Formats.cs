using System.Runtime.Serialization;

namespace CommonLib.Enums
{
    /// <summary>
    /// Форматы по ГОСТ 5773-90
    /// </summary>
    public enum Formats
    {
        [EnumMember(Value = "70x90/16")]
        F70_90_16,

        [EnumMember(Value = "60x90/16")]
        F60_90_16,

        [EnumMember(Value = "70x90/32")]
        F70_90_32,
    }
}
