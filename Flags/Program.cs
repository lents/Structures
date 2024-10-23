
namespace Flags
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            And();

            Or();

            Not();

            Xor();
           
            // Set Read and Write permissions
            FileAccess permissions = FileAccess.Read | FileAccess.Write;
            Console.WriteLine($"Permissions: {permissions}");  // Output: Permissions: Read, Write

            // Check if Write permission is set
            if ((permissions & FileAccess.Write) == FileAccess.Write)
            {
                Console.WriteLine("Write permission is set.");
            }

            // Remove the Write permission
            permissions = permissions & ~FileAccess.Write;
            Console.WriteLine($"Permissions after removal: {permissions}");  // Output: Read

            // Check if Execute permission is NOT set
            if ((permissions & FileAccess.Execute) == 0)
            {
                Console.WriteLine("Execute permission is not set.");
            }

        }

        private static void And()
        {
            int a = 6;  // 0110 in binary
            int b = 3;  // 0011 in binary
            int result = a & b;
            Console.WriteLine(result);  // Output: 2 (0010 in binary)
        }
        private static void Or()
        {
            int a = 6;  // 0110 in binary
            int b = 3;  // 0011 in binary
            int result = a | b;
            Console.WriteLine(result);  // Output: 7 (0111 in binary)
        }
        private static void Not()
        {
            int a = 6;  // 0110 in binary
            int result = ~a;
            Console.WriteLine(result);  // Output: -7 (in binary: two's complement of 6)
        }
        private static void Xor()
        {
            int a = 6;  // 0110 in binary
            int b = 3;  // 0011 in binary
            int result = a ^ b;
            Console.WriteLine(result);  // Output: 5 (0101 in binary)
        }
    }
}
