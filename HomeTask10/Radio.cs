namespace HomeTask10
{
    internal class Radio : IMultimediaDevice
    {
        private List<string> _listofRadio;
        private int _currentRadioId = 0;
        private bool _isPlayed = false;
        private int _volume;

        public Radio(List<string> listofRadio, int volume = 50)
        {
            this._listofRadio = listofRadio;
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
                return "Радио уже работает";
            }
            _isPlayed = true;
            return "пуск Радио";
        }

        public string Stop()
        {
            if (!this._isPlayed)
            {
                return "Пригрывание уже приостоновлено";
            }
            _isPlayed = false;
            return "воспроизведение Радио прервано";
        }

        public string Pause()
        {
            _isPlayed = false;
            _currentRadioId = 0;
            return "воспроизведение Радио остановлено";
        }

        public string Next()
        {
            _currentRadioId++;
            if (_currentRadioId >= _listofRadio.Count)
            {
                _currentRadioId = 0;
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
