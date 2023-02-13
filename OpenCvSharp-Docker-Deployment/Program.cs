using OpenCvSharp;
//
// var cascade = new CascadeClassifier(@"./Cascades/haarcascade_frontalface_alt.xml");
// var color = Scalar.FromRgb(0, 255, 0);
//
// using(var srcImage = new Mat("./Images/faces1.jpg"))
// using(var grayImage = new Mat())
// {
//     Cv2.CvtColor(srcImage, grayImage, ColorConversionCodes.BGRA2GRAY);
//     Cv2.EqualizeHist(grayImage, grayImage);
//
//     var faces = cascade.DetectMultiScale(
//         image: grayImage,
//         minSize: new Size(60, 60)
//     );
//
//     Console.WriteLine("Detected faces: {0}", faces.Length);
//
//     foreach (var faceRect in faces)
//     {
//         Cv2.Rectangle(srcImage, faceRect, color, 3);
//     }
//
//     // Cv2.ImShow("Face Detection", srcImage);
//     int key = Cv2.WaitKey(0);
// }

class Program
{
  static void Main()
  {
    Console.WriteLine(Cv2.GetTickCount());
    using var mat = new Mat(1, 1, MatType.CV_8UC1);
    Console.WriteLine(mat.CvPtr);
    Console.WriteLine("the package worked");
    Console.ReadKey();
  }
}