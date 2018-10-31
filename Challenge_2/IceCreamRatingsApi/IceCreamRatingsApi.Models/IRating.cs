﻿using System;

namespace IceCreamRatingsApi.Models
{
    public interface IRating
    {
        string Id { get; set; }
        string ProductId { get; set; }

        DateTime TimeStamp { get; set; }

        string LocationName { get; set; }

        int RatingValue { get; set; }

        string UserNotes { get; set; }
    }
}
