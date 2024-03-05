namespace DeleteJavaCheckRewritten.CLI.Tests
{
    public class Tests
    {
        private string minecraftLauncherPath;
        private string windowsStoreAppPath;
        private string javaCheckJarPathInMinecraftLauncher;
        private string javaCheckJarPathInWindowsStoreApp;

        [SetUp]
        public void Setup()
        {
            // Setup code to prepare the testing environment
            minecraftLauncherPath = @"C:\Program Files (x86)\Minecraft Launcher\game";
            windowsStoreAppPath = Environment.ExpandEnvironmentVariables(@"%LOCALAPPDATA%\Packages\Microsoft.4297127D64EC6_8wekyb3d8bbwe\LocalCache\Local\game");

            // Create a dummy JavaCheck.jar file in both directories
            javaCheckJarPathInMinecraftLauncher = Path.Combine(minecraftLauncherPath, "JavaCheck.jar");
            javaCheckJarPathInWindowsStoreApp = Path.Combine(windowsStoreAppPath, "JavaCheck.jar");
            File.WriteAllText(javaCheckJarPathInMinecraftLauncher, "");
            File.WriteAllText(javaCheckJarPathInWindowsStoreApp, "");
        }

        [Test]
        public void TestJavaCheckJarDeletion()
        {
            Assert.Multiple(() =>
            {
                // TODO: Access the CLI for testing
                // Verify that JavaCheck.jar files are deleted
                Assert.That(File.Exists(javaCheckJarPathInMinecraftLauncher), Is.False, "JavaCheck.jar still exists in Minecraft Launcher directory");
                Assert.That(File.Exists(javaCheckJarPathInWindowsStoreApp), Is.False, "JavaCheck.jar still exists in Windows Store App directory");
            });
        }
    }
}