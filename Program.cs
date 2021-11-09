using System.Runtime.CompilerServices;

[assembly: IgnoresAccessChecksTo("SqliteTest")]

Console.WriteLine(Microsoft.Data.Sqlite.Utilities.ApplicationDataHelper.CurrentApplicationData);
Console.WriteLine(Microsoft.Data.Sqlite.Utilities.ApplicationDataHelper.TemporaryFolderPath);
Console.WriteLine(Microsoft.Data.Sqlite.Utilities.ApplicationDataHelper.LocalFolderPath);

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class IgnoresAccessChecksToAttribute : Attribute
{
    public IgnoresAccessChecksToAttribute(string assemblyName)
    {
        AssemblyName = assemblyName;
    }

    public string AssemblyName { get; }
}