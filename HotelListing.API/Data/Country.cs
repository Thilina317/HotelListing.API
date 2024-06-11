namespace HotelListing.API.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string ShortName { get; set; }

        //methanadi eka country ekakta hotel kihipayk tyna nisa eka One to Many Relation eka thmai enne eka pahala wdiyta thmai implement krnn wenne
        public virtual IList<Hotel> Hotels { get; set; }
    }
}