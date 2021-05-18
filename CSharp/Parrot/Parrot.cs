using System;

namespace Parrot
{
    public abstract class Parrot
    {
        public static Parrot Create(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            switch (type)
            {
                case ParrotTypeEnum.EUROPEAN:
                    return new EuropeanParrot();
                case ParrotTypeEnum.AFRICAN:
                    return new AfricanParrot(numberOfCoconuts);
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    return new NorwegianBlueParrot(voltage, isNailed);
            }

            throw new InvalidOperationException("Should never reach here");
        }

        public abstract double GetSpeed();

        protected double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}