﻿using System;
using System.Runtime.Serialization;

namespace IceCreamRatingsApi.Models
{
    [DataContract]
    public class Rating : IRating
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "userId")]
        public string UserId { get; set; }
        [DataMember(Name = "productId")]
        public string ProductId { get; set; }
        [DataMember(Name = "locationName")]
        public string LocationName { get; set; }
        [DataMember(Name = "rating")]
        public int RatingValue { get; set; }
        [DataMember(Name = "userNotes")]
        public string UserNotes { get; set; }
        [DataMember(Name = "timestamp")]
        public DateTime TimeStamp { get; set; }

        public Rating()
        {
            Id = Guid.NewGuid().ToString();
            TimeStamp = DateTime.UtcNow;
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(UserId))
            {
                return false;
            }

            if (string.IsNullOrEmpty(ProductId))
            {
                return false;
            }

            return true;
        }
    }
}
