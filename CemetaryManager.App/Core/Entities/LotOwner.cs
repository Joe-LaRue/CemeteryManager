﻿namespace CemeteryManager.App.Core.Entities
{
    public class LotOwner
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

    }
}
