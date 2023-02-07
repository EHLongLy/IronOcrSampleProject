// See https://aka.ms/new-console-template for more information

using IronOcr;
License.LicenseKey = "Your License Key";




/*My License Key is above*/



try
{
    IronTesseract ocr = new IronTesseract();
    OcrInput ocrInput = new OcrInput();
    ocrInput.Add(@"TestImage.png");
    Console.WriteLine($"Output = {ocr.Read(ocrInput).Text}");
}
finally
{
    Console.Read();
}