using System;
using System.Collections.Generic;

// Интерфейс для мультимедийных устройств
public interface IMultimediaDevice
{
    void Play();
    void Stop();
    void Pause();
    void Next();
    void IncreaseVolume();
    void DecreaseVolume();
}

