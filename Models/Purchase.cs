using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace pda_backend
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string PurchaseName { get; set; }
        public int CategoryId { get; set; }

        public Purchase(int purchaseId, string purchaseName, int categoryId)
        {
            PurchaseId = purchaseId;
            PurchaseName = purchaseName;
            CategoryId = categoryId;
        }

        public string toJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}