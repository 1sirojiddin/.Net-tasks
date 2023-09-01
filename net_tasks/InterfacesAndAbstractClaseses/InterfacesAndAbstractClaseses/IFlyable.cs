using System;

namespace InterfacesAndAbstractClaseses;
    public interface IFlyable
    {
        void FlyTo(Coordinate newPoint);
        double GetFlyTime();
    }
