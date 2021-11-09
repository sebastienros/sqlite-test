using System.Runtime.CompilerServices;
using Microsoft.Data.Sqlite.Utilities;

[assembly: IgnoresAccessChecksTo("SqliteTest")]

Console.WriteLine(Microsoft.Data.Sqlite.ApplicationDataHelper.CurrentApplicationData);
Console.WriteLine(Microsoft.Data.Sqlite.ApplicationDataHelper.TemporaryFolderPath);
Console.WriteLine(Microsoft.Data.Sqlite.ApplicationDataHelper.LocalFolderPath);

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class IgnoresAccessChecksToAttribute : Attribute
{
    public IgnoresAccessChecksToAttribute(string assemblyName)
    {
        AssemblyName = assemblyName;
    }

    public string AssemblyName { get; }
}