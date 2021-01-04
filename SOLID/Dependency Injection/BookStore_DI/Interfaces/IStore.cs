namespace BookStore_DI
{
    public interface IStore 
    {
        void MakePurchase(ICustomer customer, IBook book);
    }
}