using System;

namespace InventoryLibrary
{
    /// <summary>
    /// User class
    /// </summary>
    public class User : BaseClass
    {
        /// <summary>
        /// name string
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// User constructor 
        /// </summary>
        /// <param name="name">name</param>
        public User(string name)
        {
            this.name = name;
        }

    }
}