class Program
{
    static void Main()
    {
        // Создание экземпляров устройств
        MP3Player mp3Player = new MP3Player();
        DVDPlayer dvdPlayer = new DVDPlayer();
        Radio radio = new Radio();

        // Создание экземпляра контроллера
        MultimediaController controller = new MultimediaController();

        // Подключение устройств к контроллеру
        controller.ConnectDevice(mp3Player);
        controller.ConnectDevice(dvdPlayer);
        controller.ConnectDevice(radio);

        // Управление выбранным устройством
        controller.SelectAndManageDevice();
    }
}

