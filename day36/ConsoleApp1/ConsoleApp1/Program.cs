namespace ConsoleApp1
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            string inputFilePath = "C:\\Users\\kanna\\OneDrive\\Pictures\\Images\\burger.jpg";
            string outputFilePath = "C:\\Users\\kanna\\OneDrive\\Pictures\\Images\\burger_crop.jpg";
            try
            {
                // Read the image file as binary data
                byte[] imageData = File.ReadAllBytes(inputFilePath);

                // Calculate the midpoint of the byte array
                int halfLength = imageData.Length / 2;

                // Write the first half of the binary data to a new file using BinaryWriter
                using (FileStream fs = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    writer.Write(imageData, 0, halfLength);
                }

                Console.WriteLine("Half of the image file has been written to the new file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
