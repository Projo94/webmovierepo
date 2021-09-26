using System;

namespace WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVProgram.DTOs
{
    public class TVProgramVm
    {

        public Guid IDTVProgram { get; set; }


        public string Caption { get; set; }


        public int Year { get; set; }


        public string Description { get; set; }



        public string TypeOfProgram { get; set; }

        public decimal AverageRating { get; set; }


        public string PictureDisplay { get; set; }

    }
}
