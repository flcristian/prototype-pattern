namespace prototype_pattern
{
    public abstract class Vehicle : IPrototype<Vehicle>
    {
        private String _make;
        private String _model;
        private String _engine;
        private Int32 _year;

        // Constructors

        public Vehicle()
        {
            _make = "Default";
            _model = "Default";
            _engine = "Default";
            _year = 2000;
        }

        public Vehicle(Vehicle vehicle)
        {
            _make = vehicle._make;
            _model = vehicle._model;
            _engine = vehicle._engine;
            _year = vehicle._year;
        }

        // Accessors

        public String Make
        {
            get { return _make; }
            set
            {
                _make = value;
            }
        }

        public String Model
        {
            get { return _model; }
            set
            {
                _model = value;
            }
        }

        public String Engine
        {
            get { return _engine; }
            set
            {
                _engine = value;
            }
        }

        public Int32 Year
        {
            get { return _year; }
            set
            {
                _year = value;
            }
        }

        // Methods

        public override Boolean Equals(object? obj)
        {
            Vehicle vehicle = obj as Vehicle;
            return vehicle._make == _make && vehicle._model == _model && vehicle._engine == _engine && vehicle._year == _year;
        }

        public override String ToString()
        {
            String desc = "";
            desc += $"Make : {_make}\n";
            desc += $"Model : {_model}\n";
            desc += $"Engine : {_engine}\n";
            desc += $"Year : {_year}\n";
            return desc;
        }

        public abstract Vehicle Clone();
    }
}
