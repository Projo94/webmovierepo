using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using WebApp.Movies.Domain.Entities;

namespace WebApp.Movies.Application.Features.TVPrograms.Queries.GetTopTenTVProgram.DTOs
{
    public class TVProgramVm
    {

        public Guid IDTVProgram { get; set; }

        public string ReleaseDate { get; set; }
        public string Title { get; set; }

        public string PictureDisplay { get; set; }

        public string Description { get; set; }

        public decimal AverageRating { get; set; }



    }
}
