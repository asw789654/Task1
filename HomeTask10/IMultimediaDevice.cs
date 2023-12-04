namespace HomeTask10
{
    internal interface IMultimediaDevice
    {
        public string Play()
        {
            return "воспроизведение запущено";
        }

        public string Stop()
        {
            return "воспроизведение прекращено";
        }

        public string Pause()
        {
            return "воспроизведение остановлено";
        }

        public string Next()
        {
            return "следующий";
        }

        public string IncreaseVolume(int value)
        {
            return $"громкость повышена на {value}";
        }

        public string DecreaseVolume(int value)
        {
            return $"громкость понижена на {value}";
        }
    }
}
