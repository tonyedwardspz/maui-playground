using System.Collections.Generic;
using Syncfusion_Shimmer_View.Models;

namespace Syncfusion_Shimmer_View.Models;

internal static class CottageData
{
    public static List<Cottage> GetDummyCottages()
    {
        return new List<Cottage>
        {
            new Cottage
            {
                Id = 1,
                Name = "Seaside Retreat",
                Description = "A charming cottage overlooking the ocean with stunning sunset views. Perfect for a romantic getaway or peaceful retreat.",
                ImageUrl = "https://webpics.classic.co.uk/5121/list.jpg",
                Location = "Monterey Bay, California",
                Price = 250.00,
                Rating = 4.8
            },
            new Cottage
            {
                Id = 2,
                Name = "Mountain Haven",
                Description = "Cozy log cabin nestled in the mountains with hiking trails nearby. Features a fireplace and hot tub.",
                ImageUrl = "https://webpics.classic.co.uk/4203/list.jpg",
                Location = "Aspen, Colorado",
                Price = 320.00,
                Rating = 4.9
            },
            new Cottage
            {
                Id = 3,
                Name = "Lakeside Cabin",
                Description = "Rustic cottage on a private lake with fishing, kayaking, and swimming opportunities. Includes a dock and fire pit.",
                ImageUrl = "https://webpics.classic.co.uk/3859/list.jpg",
                Location = "Lake Tahoe, Nevada",
                Price = 180.00,
                Rating = 4.6
            },
            new Cottage
            {
                Id = 4,
                Name = "Forest Hideaway",
                Description = "Secluded cottage surrounded by towering pines. Ideal for nature lovers seeking tranquility and wildlife viewing.",
                ImageUrl = "https://webpics.classic.co.uk/5278/list.jpg",
                Location = "Olympic National Park, Washington",
                Price = 195.00,
                Rating = 4.7
            },
            new Cottage
            {
                Id = 5,
                Name = "Countryside Manor",
                Description = "Elegant cottage with beautiful gardens and countryside views. Features modern amenities in a traditional setting.",
                ImageUrl = "https://webpics.classic.co.uk/1430/list.jpg",
                Location = "Napa Valley, California",
                Price = 285.00,
                Rating = 4.5
            },
            new Cottage
            {
                Id = 6,
                Name = "Desert Oasis",
                Description = "Modern cottage with panoramic desert views and a private pool. Perfect for stargazing and desert adventures.",
                ImageUrl = "https://webpics.classic.co.uk/1431/list.jpg",
                Location = "Scottsdale, Arizona",
                Price = 225.00,
                Rating = 4.4
            }
        };
    }
}