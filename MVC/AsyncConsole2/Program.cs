

namespace na
{
    public class foo
	{
        public static void Main()
		{
           
        }

        public async Task SimpleWriteAsync()
        {
            string filePath = "simple.txt";
            string text = $"Hello World";

            await File.WriteAllTextAsync(filePath, text);
        }
    }

    
}
