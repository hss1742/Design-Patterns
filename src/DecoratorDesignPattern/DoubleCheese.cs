namespace src.DecoratorDesignPattern
{
    public class DoubleCheese : ToppingDecorator
    {

        public DoubleCheese(BasePizza basePizza) : base(basePizza)
        {
            
        }

        public override int Cost()
        {
            return _basePizza.Cost() + 20;
        }
    }
}