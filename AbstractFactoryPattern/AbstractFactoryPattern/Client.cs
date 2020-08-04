using AbstractFactoryPattern.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;
        private AbstractCover cover;
        private AbstractLabel lable;

        public Client(AbstractFactory abstractFactory)
        {
            //Абстрагируем процесс инстанцирования
            this.water = abstractFactory.CreateWater();
            this.bottle = abstractFactory.CreateBottle();
            this.cover = abstractFactory.CreateCover();
            this.lable = abstractFactory.CreateLabel();
        }

        public void CreateProduct()
        {
            //Абстрагируем варианты использования
            bottle.Interact(water);
            bottle.Interact(cover);
            bottle.Interact(lable);
        }
    }
}
