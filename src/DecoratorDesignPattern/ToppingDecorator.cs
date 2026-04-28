namespace src.DecoratorDesignPattern
{
    public abstract class ToppingDecorator : BasePizza
    {
        protected BasePizza _basePizza;

        public ToppingDecorator(BasePizza basePizza)
        {
            _basePizza = basePizza;
        }
    }
}