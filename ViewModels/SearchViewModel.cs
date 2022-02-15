using System;
namespace IndyBooks.ViewModels
{
    public class SearchViewModel
    {
        public String Title { get; set; }
        public String Author { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        //: Add properties needed for searching, Author's LastName, PriceLow, PriceHigh
    }
}
