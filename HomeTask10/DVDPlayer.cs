namespace HomeTask10
{
    internal class DVDPlayer : IMultimediaDevice
    {
        private List<string> _listofDVD;
        private int _currentDVDId = 0;
        private bool _isPlayed = false;
        private int _volume;

        public DVDPlayer(List<string> listofDVD, int volume = 50)
        {
            this._listofDVD = listofDVD;
            this.Volume = volume;
        }

        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                if (_volume < 0)
                {
                    _volume = 0;
                }
                else if (_volume > 100)
                {
                    _volume = 100;
                }
                else
                {
                    _volume = value;
                }
            }
        }

        public string Play()
        {
            if (this._isPlayed)
            {
                return "DVD уже работает";
            }
            _isPlayed = true;
            return "пуск DVD";
        }

        public string Stop()
        {
            if (!this._isPlayed)
            {
                return "DVD уже приостоновлен";
            }
            _isPlayed = false;
            return "воспроизведение DVD прервано";
        }

        public string Pause()
        {
            _isPlayed = false;
            _currentDVDId = 0;
            return "воспроизведение DVD остановлено";
        }

        public string Next()
        {
            _currentDVDId++;
            if (_currentDVDId >= _listofDVD.Count)
            {
                _currentDVDId = 0;
            }
            return "следующая запись";
        }

        public string IncreaseVolume(int value)
        {
            Volume += value;
            return $"громкость повышена на {value}";
        }

        public string DecreaseVolume(int value)
        {
            Volume -= value;
            return $"громкость понижена на {value}";
        }
    }
}
