namespace DemoAppOpsta.Services
{
    public class FileService
    {
        private string _path = "D:\\Temp";

        public FileService() { }

        public string[] ListFiles(string path)
        {
            var res = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            return res;
        }
        public string ReadFile(string path)
        {
            if (!File.Exists(path))
                //return string.Empty;
                throw new FileNotFoundException($"file not found : {path}");
            return File.ReadAllText(path);
        }
        public void WriteFile(string path, string contents)
        {
            var dir = Path.GetDirectoryName(path);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            File.WriteAllText(path, contents);
        }
    }
}
