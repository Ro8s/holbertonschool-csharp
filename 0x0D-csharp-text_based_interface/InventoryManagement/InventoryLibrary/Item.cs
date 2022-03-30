using System;

namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        /// <summary>
        /// name string
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// description optional string
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// price optional float
        /// </summary>
        private float _price;
        /// <summary>
        /// float price property
        /// </summary>
        public float price { get => _price; set => float.Parse(_price.ToString("#.##")); }

        /// <summary>
        /// tags optional list of strings
        /// </summary>
        public List<string> tags { get; set; }

        /// <summary>
        /// Item constructor
        /// </summary>
        /// <param name="name">name</param>
        public Item(string name)
        {
            this.name = name;
        }

    }
}

