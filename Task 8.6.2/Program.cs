namespace Task_8._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\nisso\Desktop\Task 8.6.2";

            if (Directory.Exists(filePath))
            {
                long size = 0;
                DirectoryInfo directoryInfo = new DirectoryInfo(filePath);

                size = CalculateDirectorySize(directoryInfo);
            }
            else
            {
                Console.WriteLine("No directory has been found at this file path. Make sure that the file path is correct.");
            }
        }

        public static long CalculateDirectorySize(DirectoryInfo d)
        {
            long size = 0;

            FileInfo[] fileInfos = d.GetFiles();

            foreach (FileInfo fileInfo in fileInfos) 
            { 
                size += fileInfo.Length;
            }

            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += CalculateDirectorySize(di);
            }
            return size;
        }
    }
}
