using System.Runtime.InteropServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

Console.OutputEncoding = Encoding.UTF8;

var appInfo = new
{
    Application = "CrossApp",
    Student = "Зарічний Степан, група ФЕІ-33с",
    OSDescription = RuntimeInformation.OSDescription,
    OSVersion = Environment.OSVersion.ToString(),
    ProcessArchitecture = RuntimeInformation.ProcessArchitecture.ToString(),
    DotNetVersion = Environment.Version.ToString(),
    Framework = RuntimeInformation.FrameworkDescription,
    AppDirectory = AppContext.BaseDirectory,
    CurrentDirectory = Environment.CurrentDirectory,
    Domain = "Склад (товари, партії, залишки, переміщення)"
};

var jsonRequested = args.Contains("--json", StringComparer.OrdinalIgnoreCase);

if (jsonRequested)
{
    var options = new JsonSerializerOptions
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    Console.WriteLine(JsonSerializer.Serialize(appInfo, options));
    return;
}

Console.WriteLine("CrossApp — практикум з крос-платформного програмування");
Console.WriteLine($"Студент: {appInfo.Student}");
Console.WriteLine(new string('-', 72));
Console.WriteLine($"{"Параметр",-24} | Значення");
Console.WriteLine(new string('-', 72));
Console.WriteLine($"{"ОС (OSDescription)",-24} | {appInfo.OSDescription}");
Console.WriteLine($"{"ОС (Environment)",-24} | {appInfo.OSVersion}");
Console.WriteLine($"{"Архітектура процесу",-24} | {appInfo.ProcessArchitecture}");
Console.WriteLine($"{"Версія .NET (CLR)",-24} | {appInfo.DotNetVersion}");
Console.WriteLine($"{"Runtime",-24} | {appInfo.Framework}");
Console.WriteLine($"{"Каталог застосунку",-24} | {appInfo.AppDirectory}");
Console.WriteLine($"{"Поточний каталог",-24} | {appInfo.CurrentDirectory}");
Console.WriteLine($"{"Предметна область",-24} | {appInfo.Domain}");
