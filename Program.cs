namespace OptfineInstaller {
    class Program {
        static void Main(string[] args) {
            try {
                System.Diagnostics.Process.Start("CMD.exe", $"/C \"C:\\Program Files (x86)\\Minecraft Launcher\\runtime\\jre-x64\\bin\\java.exe\" -jar {args[0]}");
            }
            catch(System.Exception ex) {
                System.Console.WriteLine(ex);
            }
        }
    }
}
