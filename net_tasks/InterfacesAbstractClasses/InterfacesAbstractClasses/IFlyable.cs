using System;

namespace InterfacesAbstractClasses
{
public interface IFlyable
{
    void FlyTo(Coordinate newPoint);
    double GetFlyTime();
}
}
