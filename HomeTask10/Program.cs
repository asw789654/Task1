using HomeTask10;

List<string> list = new List<string>() { "record1", "record2", "record3" };
MP3Player mP3Player = new MP3Player(list, 30);
Radio radio = new Radio(list);
DVDPlayer dVDPlayer = new DVDPlayer(list);
List<IMultimediaDevice> deviceList = new List<IMultimediaDevice>() { mP3Player, radio, dVDPlayer };
while (true)
{
    try
    {
        Console.WriteLine("выберите устройство");
        for (int i = 0; i < deviceList.Count; i++)
        {
            Console.WriteLine($"{i + 1}." + deviceList[i].ToString().Remove(0, 11));
        }
        Int32.TryParse(Console.ReadLine(), out int deviceNum);
        Control(deviceList[deviceNum - 1]);
    }
    catch(Exception e) 
    {
        Console.WriteLine(e);
    }

}

void Control(IMultimediaDevice multimediaDevice)
{
    Console.WriteLine($"Выберите операцию:{Environment.NewLine}" +
        $"1.Пуск{Environment.NewLine}" +
        $"2.Стоп{Environment.NewLine}" +
        $"3.Пауза{Environment.NewLine}" +
        $"4.Повысить громкость{Environment.NewLine}" +
        $"5.Понизить громкость{Environment.NewLine}" +
        $"6.Следующая запись{Environment.NewLine}");
    Int32.TryParse(Console.ReadLine(), out int choise);
    switch (choise)
    {
        case 1: Console.WriteLine(multimediaDevice.Play()); break;
        case 2: Console.WriteLine(multimediaDevice.Stop()); break;
        case 3: Console.WriteLine(multimediaDevice.Pause()); break;
        case 4:
            Console.WriteLine("Повыситиь громкость на ");
            Int32.TryParse(Console.ReadLine(), out int increaseValue);
            Console.WriteLine(multimediaDevice.IncreaseVolume(increaseValue)); break;
        case 5:
            Console.WriteLine("Повыситиь громкость на ");
            Int32.TryParse(Console.ReadLine(), out int decreaseValue);
            Console.WriteLine(multimediaDevice.IncreaseVolume(decreaseValue)); break;
        case 6: Console.WriteLine(multimediaDevice.Next()); break;

    }
}
