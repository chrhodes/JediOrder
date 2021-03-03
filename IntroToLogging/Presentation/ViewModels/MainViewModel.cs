using System;
using System.Windows.Input;

using Prism.Commands;

using VNC.Core.Mvvm;

namespace IntroToLogging.Presentation.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region Constructors, Initialization, and Load

        public MainViewModel()
        {
            Button1Command = new DelegateCommand(Button1Execute);
            Button2Command = new DelegateCommand(Button2Execute);
            Button3Command = new DelegateCommand(Button3Execute);
        }

        #endregion

        #region Fields and Properties

        private string _title = "IntroToLogging - MainWindow";

        public string Title
        {
            get => _title;
            set
            {
                if (_title == value)
                    return;
                _title = value;
                OnPropertyChanged();
            }
        }

        private string _message = "Initial Message";

        public string Message
        {
            get => _message;
            set
            {
                if (_message == value)
                    return;
                _message = value;
                OnPropertyChanged();
            }
        }

        private int _numerator = 10;
        public int Numerator
        {
            get => _numerator;
            set
            {
                if (_numerator == value)
                    return;
                _numerator = value;
                OnPropertyChanged();
            }
        }

        private int _denominator = 2;
        public int Denominator
        {
            get => _denominator;
            set
            {
                if (_denominator == value)
                    return;
                _denominator = value;
                OnPropertyChanged();
            }
        }
        
        private string _answer = "???";

        public string Answer
        {
            get => _answer;
            set
            {
                if (_answer == value)
                    return;
                _answer = value;
                OnPropertyChanged();
            }
        }

        public ICommand Button1Command { get; private set; }
        public ICommand Button2Command { get; private set; }
        public ICommand Button3Command { get; private set; }

        #endregion

        #region Private Methods

        private void Button1Execute()
        {
            Message = "Button1 Clicked";
        }

        private void Button2Execute()
        {
            Message = "Button2 Clicked";
        }

        private void Button3Execute()
        {
            Message = "Button3 Clicked";

            try
            {
                method1();
            }
            catch (Exception ex)
            {
                Message = "EXCEPTION !!!";
            }
        }

        private void method1()
        {
            method2();
        }

        private void method2()
        {
            method3();
        }

        private void method3()
        {
            method4();
        }

        private void method4()
        {
            method5();
        }

        private void method5()
        {
            int answer = Numerator / Denominator;

            Answer = answer.ToString();
        }

        #endregion

    }
}
