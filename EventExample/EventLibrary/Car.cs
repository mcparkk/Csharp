using System;

namespace EventLibrary
{   
    // Local, argument => camel(thisIsCamel)
    // field => camel(thisIsCamel) /_camel
    // etc => pascal(ThisIsPascal)

    public class Car
    {
        public Car(string name, int Speed, string color)
        {
            _name = name;
            _speed = Speed;
            _color = color;
        }
        public string _name { get; set; }
        public int _speed { get; set; }
        public string _color { get; set; }

        //public string _userColor
        //{ get { return _color; } set { _color = value; } }

        public void Upgrade()
        {
            

            SpeedChangingEventArgs speedArgs = new SpeedChangingEventArgs();
            int beforeSpeed = _speed;
            speedArgs.BeforeSpeed = _speed;
            speedArgs.AfterSpeed = _speed + 50;
            OnSpeedChanging(speedArgs);

            if (speedArgs.Cancel)
                return;

            ColorChangingEventArgs colorArgs = new ColorChangingEventArgs();
            string defaultColor = "white";
            colorArgs.CurrentColor = _color;

            colorArgs.NewColor = colorArgs.UserColor;
            OnColorChanging(colorArgs);

            if (colorArgs.No)
                return;


            _color = colorArgs.UserColor;
            _speed += 50;

            OnSpeedChanged(beforeSpeed, _speed);
            OnColorChanged(defaultColor, _color);



        }

        #region SpeedChanged event things for C# 3.0
        public event EventHandler<SpeedChangedEventArgs> SpeedChanged;

        protected virtual void OnSpeedChanged(SpeedChangedEventArgs e)
        {
            if (SpeedChanged != null)
                SpeedChanged(this, e);
        }

        private SpeedChangedEventArgs OnSpeedChanged(int beforeSpeed, int afterSpeed)
        {
            SpeedChangedEventArgs args = new SpeedChangedEventArgs(beforeSpeed, afterSpeed);
            OnSpeedChanged(args);

            return args;
        }

        private SpeedChangedEventArgs OnSpeedChangedForOut()
        {
            SpeedChangedEventArgs args = new SpeedChangedEventArgs();
            OnSpeedChanged(args);

            return args;
        }

        public class SpeedChangedEventArgs : EventArgs
        {
            public int BeforeSpeed { get; set; }
            public int AfterSpeed { get; set; }

            public SpeedChangedEventArgs()
            {
            }

            public SpeedChangedEventArgs(int beforeSpeed, int afterSpeed)
            {
                BeforeSpeed = beforeSpeed;
                AfterSpeed = afterSpeed;
            }
        }
        #endregion

        #region SpeedChanging event things for C# 3.0
        public event EventHandler<SpeedChangingEventArgs> SpeedChanging;

        protected virtual void OnSpeedChanging(SpeedChangingEventArgs e)
        {
            if (SpeedChanging != null)
                SpeedChanging(this, e);
        }

        private SpeedChangingEventArgs OnSpeedChanging(int beforeSpeed, int afterSpeed, bool cancel)
        {
            SpeedChangingEventArgs args = new SpeedChangingEventArgs(beforeSpeed, afterSpeed, cancel);
            OnSpeedChanging(args);

            return args;
        }

        private SpeedChangingEventArgs OnSpeedChangingForOut()
        {
            SpeedChangingEventArgs args = new SpeedChangingEventArgs();
            OnSpeedChanging(args);

            return args;
        }

        public class SpeedChangingEventArgs : EventArgs
        {
            public int BeforeSpeed { get; set; }
            public int AfterSpeed { get; set; }
            public bool Cancel { get; set; }

            public SpeedChangingEventArgs()
            {
            }

            public SpeedChangingEventArgs(int beforeSpeed, int afterSpeed, bool cancel)
            {
                BeforeSpeed = beforeSpeed;
                AfterSpeed = afterSpeed;
                Cancel = cancel;
            }
        }
        #endregion

        #region ColorChanging event things for C# 3.0
        public event EventHandler<ColorChangingEventArgs> ColorChanging;

        protected virtual void OnColorChanging(ColorChangingEventArgs e)
        {
            if (ColorChanging != null)
                ColorChanging(this, e);
        }

        private ColorChangingEventArgs OnColorChanging(string currentColor, string newColor, bool no, string userColor)
        {
            ColorChangingEventArgs args = new ColorChangingEventArgs(currentColor, newColor, no, userColor);
            OnColorChanging(args);

            return args;
        }

        private ColorChangingEventArgs OnColorChangingForOut()
        {
            ColorChangingEventArgs args = new ColorChangingEventArgs();
            OnColorChanging(args);

            return args;
        }

        public class ColorChangingEventArgs : EventArgs
        {
            public string CurrentColor { get; set; }
            public string NewColor { get; set; }
            public bool No { get; set; }
            public string UserColor { get; set; }

            public ColorChangingEventArgs()
            {
            }

            public ColorChangingEventArgs(string currentColor, string newColor, bool no, string userColor)
            {
                CurrentColor = currentColor;
                NewColor = newColor;
                No = no;
                UserColor = userColor;
            }
        }
        #endregion

        #region ColorChanged event things for C# 3.0
        public event EventHandler<ColorChangedEventArgs> ColorChanged;

        protected virtual void OnColorChanged(ColorChangedEventArgs e)
        {
            if (ColorChanged != null)
                ColorChanged(this, e);
        }

        private ColorChangedEventArgs OnColorChanged(string defultColor, string newColor)
        {
            ColorChangedEventArgs args = new ColorChangedEventArgs(defultColor, newColor);
            OnColorChanged(args);

            return args;
        }

        private ColorChangedEventArgs OnColorChangedForOut()
        {
            ColorChangedEventArgs args = new ColorChangedEventArgs();
            OnColorChanged(args);

            return args;
        }

        public class ColorChangedEventArgs : EventArgs
        {
            public string DefultColor { get; set; }
            public string NewColor { get; set; }

            public ColorChangedEventArgs()
            {
            }

            public ColorChangedEventArgs(string defultColor, string newColor)
            {
                DefultColor = defultColor;
                NewColor = newColor;
            }
        }
        #endregion
    }
}
