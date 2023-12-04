namespace HomeTask10
{
    internal class MP3Player : IMultimediaDevice
    {
        private List<string> _listofMP3;
        private int _currentMP3Id = 0;
        private bool _isPlayed = false;
        private int _volume;

        public MP3Player(List<string> listofMP3, int volume = 50)
        {
            this._listofMP3 = listofMP3;
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
                return "MP3 запущен";
            }
            _isPlayed = true;
            return "пуск MP3";
        }

        public string Stop()
        {
            if (!this._isPlayed)
            {
                return "MP3 уже приостоновлен";
            }
            _isPlayed = false;
            return "воспроизведение MP3 прервано";
        }

        public string Pause()
        {
            _isPlayed = false;
            _currentMP3Id = 0;
            return "воспроизведение MP3 остановлено";
        }

        public string Next()
        {
            _currentMP3Id++;
            if (_currentMP3Id >= _listofMP3.Count)
            {
                _currentMP3Id = 0;
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
