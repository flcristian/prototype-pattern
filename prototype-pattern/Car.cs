namespace prototype_pattern
{
    public class Car : Vehicle
    {
        private String _color;
        private Int32 _topSpeed;

        // Constructors

        public Car() : base()
        {
            _color = "Default";
            _topSpeed = 160;
        }

        public Car(Car car) : base(car) 
        {
            _color = car._color;
            _topSpeed = car._topSpeed;
        }

        // Accessors

        public String Color
        {
            get { return _color; }
            set
            {
                _color = value;
            }
        }

        public Int32 TopSpeed
        {
            get { return _topSpeed; }
            set
            {
                _topSpeed = value;
            }
        }

        // Methods

        public override Boolean Equals(object? obj)
        {
            Car car = obj as Car;
            return base.Equals(car) && car._color == _color && car._topSpeed == _topSpeed;
        }

        public override String ToString()
        {
            String desc = base.ToString();
            desc += $"Color : {_color}\n";
            desc += $"Top Speed : {_topSpeed}\n";
            return desc;
        }

        public override Car Clone()
        {
            return new Car(this);
        }
    }
}
