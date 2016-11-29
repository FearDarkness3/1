namespace Supermarket
{
    interface ICustomList
    {
        void AddToList(Product prod);
        void RemoveFromList(Product prod);
        bool ListContains(Product prod);
    }
}
