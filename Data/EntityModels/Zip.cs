namespace TheBookCave.Data.EntityModels {
    public class Zip {
        public string Id { get; set; }
        // Name of Zip
        public string Name { get; set; }
        // path to Country that Zip represents
        public string CountryId { get; set; }
         // path to region that Zip represents
        public string RegionId { get; set; }

    }
}