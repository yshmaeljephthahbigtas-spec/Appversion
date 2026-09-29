namespace lol.Models

{

    public class Product

    {

        public int Id { get; set; }

        public string Name { get; set; } = "";

        public int Price { get; set; }

        //new sh
        public string Description { get; set; } = "";

        public string UnitMeasure { get; set; } = "";

    }

}