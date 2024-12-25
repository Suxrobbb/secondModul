namespace _2._8_dars
{
    public interface IMyList
    {
        void RemoveItemAt(int index);
        void AddItemsRange(int[] nums);
        void ReplaceAllItems(int oldElement, int newElement);
        List<MyList> GetItemIndex(int item);   
    }
}