namespace TheCentralBank
{
    public class RequestData
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public bool IsToday { get; set; }
    }
    public class ResponseDataOrg 
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int UnitOf { get; set; }
        public decimal BuyingRate { get; set; }
        public decimal SalesRate { get; set; }
        public decimal EffectiveBuyingRate { get; set; }
        public decimal EffectiveSellingRate { get; set; }
    }
    public class ResponseData 
    {
        public List<ResponseDataOrg> Data { get; set; }
        public string Error { get; set; }
    }
    

}
