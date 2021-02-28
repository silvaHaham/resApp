using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Restaurants.Models.DAL;

namespace RestCampaign.Models
{
    public class Restaurants
    {
        int id;
        int investedAmount;
        int balance;
        int impressions;
        int clicks;
        bool status;

        public RestCampaign(int id,
                            int investedAmount,
                            int balance,
                            int impressions,
                            int clicks,
                            bool status)
        {
            this.id = id;
            this.investedAmount = investedAmount;
            this.balance = balance;
            this.impressions = impressions;
            this.clicks = clicks;
            this.status = status;
        }
    }
}