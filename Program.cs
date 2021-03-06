using System.Reflection;

Console.WriteLine($"Type.GetType(\"Windows.Storage.ApplicationData, Windows, ContentType=WindowsRuntime\"): {Type.GetType("Windows.Storage.ApplicationData, Windows, ContentType=WindowsRuntime")}");
Console.WriteLine($"Type.GetType(\"Windows.Storage.ApplicationData, Microsoft.Windows.SDK.NET\"): {Type.GetType("Windows.Storage.ApplicationData, Microsoft.Windows.SDK.NET")}");

var propertyName = "TemporaryFolder";
var CurrentApplicationData = ApplicationDataHelper.CurrentApplicationData;
var appDataType = CurrentApplicationData?.GetType();

Console.WriteLine($"appDataType: {appDataType}");
Console.WriteLine($"appDataType?.GetRuntimeProperty(propertyName): {appDataType?.GetRuntimeProperty(propertyName)}");
Console.WriteLine($"appDataType?.GetRuntimeProperty(propertyName)!.GetValue(CurrentApplicationData): {appDataType?.GetRuntimeProperty(propertyName)!.GetValue(CurrentApplicationData)}");

var temporaryFolder = appDataType?.GetRuntimeProperty(propertyName)!.GetValue(CurrentApplicationData);

Console.WriteLine($"temporaryFolder?.GetType(): {temporaryFolder?.GetType()}");
Console.WriteLine($"temporaryFolder?.GetType().GetRuntimeProperty(\"Path\"): {temporaryFolder?.GetType().GetRuntimeProperty("Path")}");
Console.WriteLine($"temporaryFolder?.GetType().GetRuntimeProperty(\"Path\")!.GetValue(temporaryFolder): {temporaryFolder?.GetType().GetRuntimeProperty("Path")!.GetValue(temporaryFolder)}");

// Console.WriteLine(ApplicationDataHelper.CurrentApplicationData);
// Console.WriteLine(ApplicationDataHelper.TemporaryFolderPath);
// Console.WriteLine(ApplicationDataHelper.LocalFolderPath);

