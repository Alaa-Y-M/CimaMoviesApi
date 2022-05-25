using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CimaMoviesApi.Data;
    public class MovieLink
    {
        public long Id { get; set; }

        public string Quality { get; set; }=null!;
        
        public int Resolation { get; set; }

        [Required]
        public string MLink { get; set; }=null!;

        [Required]
        public long MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }=null!;
    }
