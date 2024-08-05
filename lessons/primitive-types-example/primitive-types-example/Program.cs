using System.Runtime.CompilerServices;

class Sample
{
    static void Main()
    {
        // Maximum and minimun values of each type
        sbyte sbyteMax = sbyte.MaxValue;
        sbyte sbyteMin = sbyte.MinValue;

        System.Console.WriteLine($"Sbyte type - maximum value: { sbyteMax }, and minimum value: { sbyteMin }.");


        byte byteMax = byte.MaxValue;
        byte byteMin = byte.MinValue;

        System.Console.WriteLine($"Byte type - maximum value: { byteMax }, and minimum value: { byteMin}." );


        short shortMax = short.MaxValue; 
        short shortMin = short.MinValue;

        System.Console.WriteLine($"Short type - maximum value: {shortMax}, and minimum value: {shortMin}.");


        ushort ushortMax = ushort.MaxValue;
        ushort ushortMin = ushort.MinValue;

        System.Console.WriteLine($"Ushort type - maximum value: {ushortMax}, and minimum value: {ushortMin}.");


        int intMax = int.MaxValue; 
        int intMin = int.MinValue;

        System.Console.WriteLine($"Int type - maximum value: {intMax}, and minimum value: {intMin}.");


        uint uintMax = uint.MaxValue;
        uint uintMin = uint.MinValue;

        System.Console.WriteLine($"Uint type - maximum value: {uintMax}, and minimum value: {uintMin}.");


        long longMax = long.MaxValue; 
        long longMin = long.MinValue;

        System.Console.WriteLine($"Long type - maximum value: {longMax}, and minimum value: {longMin}.");


        ulong ulongMax = ulong.MaxValue; 
        ulong ulongMin = ulong.MinValue;

        System.Console.WriteLine($"Ulong type - maximum value: {ulongMax}, and minimum value: {longMin}.");


        float floatMax = float.MaxValue;
        float floatMin = float.MinValue;

        System.Console.WriteLine($"Float type - maximum value: {floatMax}, and minimum value: {floatMin}.");


        double doubleMax = double.MaxValue; 
        double doubleMin = double.MinValue;

        System.Console.WriteLine($"Double type - maximum value: {doubleMax}, and minimum value: {doubleMin}.");


        decimal decimalMax = decimal.MaxValue;
        decimal decimalMin = decimal.MinValue;

        System.Console.WriteLine($"Decimal type - maximum value: {decimalMax}, and minimum value: {decimalMin}.");


        char charValue = 'A';

        System.Console.WriteLine($"The char type only accepts one character and uses ''.");


        string stringValue = "ABC";

        System.Console.WriteLine("The string type only accepts multiple characters and uses \"\".");


        bool boolTrue = true;
        bool boolFalse = false;

        System.Console.WriteLine($"The bool type accepts { boolTrue } and { boolFalse }.");


        System.Console.ReadKey();
    }
}
