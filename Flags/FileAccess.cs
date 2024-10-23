
namespace Flags
{
    internal partial class Program
    {
        [Flags]
        public enum FileAccess
        {
            None = 0,    // 0000
            Read = 1,    // 0001
            Write = 2,    // 0010
            Execute = 4,    // 0100
            Delete = 8     // 1000
        }
    }
}
