//Класс, управляющий мультимедийными устройствами
public class MultimediaController
{
    private List<IMultimediaDevice> connectedDevices = new List<IMultimediaDevice>();

    //Метод для добавления устройства в список
    public void ConnectDevice(IMultimediaDevice device)
    {
        connectedDevices.Add(device);
        Console.WriteLine($"{device.GetType().Name} connected.");
    }

    //Метод для управления устройством
    public void ManageDevice(IMultimediaDevice device)
    {
        Console.WriteLine($"Managing {device.GetType().Name}:");
        device.Play();
        device.Pause();
        device.Stop();
        device.Next();
        device.IncreaseVolume();
        device.DecreaseVolume();
        Console.WriteLine();
    }

    //Метод для выбора устройства из списка и управления им
    public void SelectAndManageDevice()
    {
        Console.WriteLine("Choose a device to manage:");

        for (int i = 0; i < connectedDevices.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {connectedDevices[i].GetType().Name}");
        }

        int choice;
        if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= connectedDevices.Count)
        {
            ManageDevice(connectedDevices[choice - 1]);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}

