﻿using OzonEdu.MerchApi.Domain.Models;

namespace OzonEdu.MerchApi.Domain.AggregationModels.MerchOrderAggregate
{
    public class MerchRequestType : Enumeration
    {
        public static MerchRequestType Auto = new(10, nameof(Auto));
        public static MerchRequestType Manual = new(20, nameof(Manual));

        public MerchRequestType(int id, string name) : base(id, name)
        {
        }
    }
}