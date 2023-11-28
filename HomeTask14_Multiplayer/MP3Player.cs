//Класс MP3Player реализует IMultimediaDevice
public class MP3Player : IMultimediaDevice
{
    public void Play() { Console.WriteLine("MP3Player: Playing"); }
    public void Stop() { Console.WriteLine("MP3Player: Stopped"); }
    public void Pause() { Console.WriteLine("MP3Player: Paused"); }
    public void Next() { Console.WriteLine("MP3Player: Next track"); }
    public void IncreaseVolume() { Console.WriteLine("MP3Player: Volume increased"); }
    public void DecreaseVolume() { Console.WriteLine("MP3Player: Volume decreased"); }
}

