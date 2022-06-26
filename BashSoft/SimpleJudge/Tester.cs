namespace SimpleJudge
{
    public static class Tester
    {
        public static void CompareContent(string userOutputPath, string expectedOutputPath)
        {
            OutputWriter
        }

        // get the path to the directory of the expected
        // output file by finding the index of the last ‘\’
        public static string GetMissmatchPath(string expectedOutputPath)
        {
            int indexOf = expectedOutputPath.LastIndexOf('\\');
            string directoryPath = expectedOutputPath.Substring(0, indexOf);
            string finalPath = directoryPath + @"\Missmatches.txt";
            return finalPath;
        }

        


    }
}
