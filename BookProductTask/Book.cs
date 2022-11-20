internal class Book : Product
{
    public string authorName;
    public int pageCount;
    public double discountPercent;
    double discountedPrice;
    public void GetInfo()
    {
        Console.WriteLine($"Author name:{authorName} \nPage count:{pageCount} \nDiscount:{discountPercent}%");
    }

    public void GetDiscountedPrice()
    {
        if (discountPercent>=100|| discountPercent <= 0)
        {
            throw new Exception("Wrong discount persentage!");
        }
        discountedPrice = saledPrice - (saledPrice*discountPercent)/100;
        Console.WriteLine($"Discounted price:{discountedPrice}");
    }
}
