using IndependienteStaFe.Models;
using IndependienteStaFe.Services;
using IndependienteStaFe.ViewModels.Base;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace IndependienteStaFe.ViewModels
{
    public class CountdownViewModel : BaseViewModel
    {
        private NextGame _nextgame;
        private Countdown _countdown;
        private int _days;
        private int _hours;
        private int _minutes;
        private int _seconds;
        private double _progress;
        private DateTime endTime = new DateTime();

        Repository repository = new Repository();

        public CountdownViewModel()
        {
            _countdown = new Countdown();
        }

        Game _games;
        public Game Games
        {
            get { return Games = repository.getPartidos("1").Result; }
            set
            {
                if (value == _games) return;
                _games = value;
                OnPropertyChanged();
            }
        }

        public ICommand GetGameComand
        {
            get
            {
                return new Command(async () =>
                {
                    Games = await repository.getPartidos("1");
                });
            }
        }

        public NextGame NextGame
        {
            get => _nextgame;
            set => SetProperty(ref _nextgame, value);
        }

        public int Days
        {
            get => _days;
            set => SetProperty(ref _days, value);
        }

        public int Hours
        {
            get => _hours;
            set => SetProperty(ref _hours, value);
        }

        public int Minutes
        {
            get => _minutes;
            set => SetProperty(ref _minutes, value);
        }

        public int Seconds
        {
            get => _seconds;
            set => SetProperty(ref _seconds, value);
        }

        public double Progress
        {
            get => _progress;
            set => SetProperty(ref _progress, value);
        }

        public ICommand RestartCommand => new Command(Restart);

        public override Task LoadAsync()
        {
            LoadTrip();

            _countdown.EndDate = NextGame.GameDate;
            _countdown.Start();

            _countdown.Ticked += OnCountdownTicked;
            _countdown.Completed += OnCountdownCompleted;

            return base.LoadAsync();
        }

        public override Task UnloadAsync()
        {
            _countdown.Ticked -= OnCountdownTicked;
            _countdown.Completed -= OnCountdownCompleted;

            return base.UnloadAsync();
        }

        void OnCountdownTicked()
        {
            Days = _countdown.RemainTime.Days;
            Hours = _countdown.RemainTime.Hours;
            Minutes = _countdown.RemainTime.Minutes;
            Seconds = _countdown.RemainTime.Seconds;

            var totalSeconds = (NextGame.GameDate - NextGame.Now).TotalSeconds;
            var remainSeconds = _countdown.RemainTime.TotalSeconds;
            Progress = remainSeconds / totalSeconds;
        }

        void OnCountdownCompleted()
        {
            Days = 0;
            Hours = 0;
            Minutes = 0;
            Seconds = 0;

            Progress = 0;
        }

        void LoadTrip()
        {
            var daygame = Convert.ToDateTime(Games.data[0].DateGame);
            var daynow = DateTime.Now;
            var nextgame = new NextGame()
            {

                GameDate = DateTime.Now + new TimeSpan(daygame.Day-daynow.Day, daygame.Hour-daynow.Hour, daygame.Minute-daynow.Minute, daygame.Second),
                Now = DateTime.Now.AddHours(-8) //DateTime.Now.AddHours(Convert.ToDateTime(Games.data[0].DateGame).Hour)
            };

            NextGame = nextgame;
        }

        void Restart()
        {
            Debug.WriteLine("Restart");
        }
    }
}
