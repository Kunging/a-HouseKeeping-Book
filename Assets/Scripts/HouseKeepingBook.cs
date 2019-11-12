using System;
using System.Collections.Generic;

public struct HouseKeepingBooks
{
    public List<HouseKeepingBook> houseKeepingList;

    public HouseKeepingBooks(List<HouseKeepingBook>houseKeepings)
    {
        this.houseKeepingList = houseKeepings;
    }
}
[System.Serializable]
public class HouseKeepingBook :IComparable<HouseKeepingBook>
{
    public string spendig;
    public string income;
    public string saving;
    public string outMoney;

    public int CompareTo(HouseKeepingBook other)
    {
        return this.spendig.CompareTo(other.spendig);
    }
}
