using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLSApp
{
    enum City
    {
        All,
        Spokane,
        SpokaneValley,
        Mead,
        LibertyLake,
        AirwayHeights
    }

    internal class House
    {
        //private int GetPriceCat(int price)
        //{
        //    if (price < 375000) { return 1; }
        //    if (price >= 375000 && price < 400000) { return 2; }
        //    if (price >= 400000 && price < 425000) { return 3; }
        //    if (price >= 425000 && price < 450000) { return 4; }
        //    if (price >= 450000 && price < 475000) { return 5; }
        //    if (price >= 475000 && price < 500000) { return 6; }
        //    if (price >= 500000 && price < 525000) { return 7; }
        //    if (price >= 525000) { return 8; }
        //    else return 9;
        //}
        //private int GetSqFeetCat(int sqfeet)
        //{
        //    if (sqfeet < 1500) { return 1; }
        //    if (sqfeet >= 1500 && sqfeet > 1750) { return 2; }
        //    if (sqfeet >= 1750 && sqfeet > 2000) { return 3; }
        //    if (sqfeet >= 2000 && sqfeet > 2250) { return 4; }
        //    if (sqfeet >= 2250 && sqfeet > 2500) { return 5; }
        //    if (sqfeet >= 2500 && sqfeet > 2750) { return 6; }
        //    if (sqfeet >= 2750 && sqfeet > 3000) { return 7; }
        //    if (sqfeet >= 3000 && sqfeet > 3250) { return 8; }
        //    if (sqfeet >= 3250) { return 9; }
        //    else return 10;

        //}
        public int MLS { get; set; }
        public int Price { get; set; }
        public int PriceCat { get; set; }
        public int SqFeet { get; set; }
        public int SqFeetCat { get; set; }
        public int Bed { get; set; }
        public int Bath { get; set; }
        public City City { get; set; }
        public string? Description { get; set; }
        public House(int mlsNum, int price, int pricecat, int sqFeet, int sqfeetcat, int bed, int bath, City city, string description)
        {
            MLS = mlsNum;
            Price = price;
            PriceCat = pricecat;
            SqFeet = sqFeet;
            SqFeetCat = sqfeetcat;
            Bed = bed;
            Bath = bath;
            City = city;
            Description = description;
        }
        //public House(int mlsNum, int price, int sqFeet, int bed, int bath, City city, string description)
        //{
        //    MLS = mlsNum;
        //    Price = price;
        //    PriceCat = GetPriceCat(price);
        //    SqFeet = sqFeet;
        //    SqFeetCat = GetSqFeetCat(sqFeet);
        //    Bed = bed;
        //    Bath = bath;
        //    City = city;
        //    Description = description;
        //}

        public House()
        {
        }
    }
}
