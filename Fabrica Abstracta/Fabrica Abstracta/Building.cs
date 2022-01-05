using Fabrica_Abstracta.Interfaces;

namespace Fabrica_Abstracta
{
    internal class Building
    {
        private IUnitFactory unitFactory;        

        public Building(IUnitFactory unitFactory)
        {
            this.unitFactory = unitFactory;            
        }

        public Unit GetUnit()
        {
            return unitFactory.CreateUnit();
        }
    }
}