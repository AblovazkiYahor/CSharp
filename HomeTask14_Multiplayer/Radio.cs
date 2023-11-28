//Класс Radio реализует IMultimediaDevice
public class Radio : IMultimediaDevice
{
    public void Play() { Console.WriteLine("Radio: Playing"); }
    public void Stop() { Console.WriteLine("Radio: Stopped"); }
    public void Pause() { Console.WriteLine("Radio: Paused"); }
    public void Next() { Console.WriteLine("Radio: Next station"); }
    public void IncreaseVolume() { Console.WriteLine("Radio: Volume increased"); }
    public void DecreaseVolume() { Console.WriteLine("Radio: Volume decreased"); }
}

