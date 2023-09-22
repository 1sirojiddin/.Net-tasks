namespace OODPrinciples;
    public class CarInventory
    {
        private static CarInventory instance;
        private List<Car> cars;

        private CarInventory()
        {
            cars = new List<Car>();
        }
        public static CarInventory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CarInventory();
                }
                return instance;
            }
        }

        public List<Car> Cars
        {
            get { return cars; }
        }
    }