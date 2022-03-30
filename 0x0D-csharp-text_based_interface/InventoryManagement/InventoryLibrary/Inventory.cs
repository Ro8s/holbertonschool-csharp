using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Inventory class
    /// </summary>
    public class Inventory : BaseClass
    {
        /// <summary>
        /// user_id property
        /// </summary>
        private string user_id;

        /// <summary>
        /// string item_id
        /// </summary>
        private string item_id;

        /// <summary>
        /// int _quantity
        /// </summary>
        private int _quantity = 1;

        /// <summary>
        /// int quantity property
        /// </summary>
        private int quantity { get => _quantity; set => _quantity = value < 0 ? 0 : value; }

        /// <summary>
        /// Constructor Inventory
        /// </summary>
        /// <param name="user">user</param>
        /// <param name="item">item</param>
        public Inventory(User user, Item item)
        {
            this.user_id = user.id;
            this.item_id = item.id;

        }

    }
}