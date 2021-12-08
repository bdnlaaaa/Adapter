using Adapter;
LivePhoto photo = new LivePhoto();
photo.ViewLivePhoto();
Console.WriteLine("\n");
IVeiw veiw = new Adapt(photo);
veiw.VeiwPhoto();