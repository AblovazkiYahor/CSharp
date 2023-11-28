//Класс DVDPlayer реализует IMultimediaDevice
public class DVDPlayer : IMultimediaDevice
{
    public void Play() { Console.WriteLine("DVDPlayer: Playing"); }
    public void Stop() { Console.WriteLine("DVDPlayer: Stopped"); }
    public void Pause() { Console.WriteLine("DVDPlayer: Paused"); }
    public void Next() { Console.WriteLine("DVDPlayer: Next chapter"); }
    public void IncreaseVolume() { Console.WriteLine("DVDPlayer: Volume increased"); }
    public void DecreaseVolume() { Console.WriteLine("DVDPlayer: Volume decreased"); }
}

