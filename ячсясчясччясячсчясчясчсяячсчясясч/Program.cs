
using System;
using System.IO;
class Program
{
    static void Main()
    {
        string image = "image/typoikot.jpg";
        string myString = image.ToString();
        byte[] imageByt = File.ReadAllBytes(image);
        string outputImage = "image/typoikot.jpg";
        File.WriteAllBytes(outputImage, imageByt);
        Console.WriteLine("Изображение успешно сохранено по пути: " + outputImage);
    }
} 