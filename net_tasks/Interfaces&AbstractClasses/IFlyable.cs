using System;

namespace Coordinate
{
interface IFlyable
{
    void FlyTo();
    void GetFlyTime();
    int Speed { get; set; }
    int Distance { get; set; }
    int FlyTime { get; set; }
}
}
