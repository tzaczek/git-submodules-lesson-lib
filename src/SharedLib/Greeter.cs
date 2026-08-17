namespace SharedLib;

public static class Greeter
{
    public const string Version = "1.1.0";

    public static string Greet(string name) =>
        $"Hello, {name}! (shared-lib {Version})" + Environment.NewLine + Farewell(name);

    public static string Farewell(string name) => $"Goodbye, {name}!";
}
