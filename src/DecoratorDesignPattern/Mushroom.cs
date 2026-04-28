namespace src.DecoratorDesignPattern
{
    public class Mushroom : ToppingDecorator
    {
        public Mushroom(BasePizza basePizza) : base(basePizza)
        {
            
        }

        public override int Cost()
        {
            return _basePizza.Cost() + 10;
        }
    }
}