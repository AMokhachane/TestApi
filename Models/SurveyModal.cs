using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;

namespace TestApi.Models
{
    public class SurveyModal
    {

        public string FullName { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }

    // Favorite Food (Checkbox-style)
    public bool LikesPizza { get; set; }
    public bool LikesPasta { get; set; }
    public bool LikesPapAndWors { get; set; }
    public bool LikesOther { get; set; }
    public string? OtherFoodDescription { get; set; }

    // Activity Ratings (1 to 5 scale)
    [Range(1, 5)]
    public int MusicRating { get; set; }

    [Range(1, 5)]
    public int TVRating { get; set; }

    [Range(1, 5)]
    public int RadioRating { get; set; }
    }
}