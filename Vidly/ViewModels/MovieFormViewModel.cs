﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genres")]
        [Required]
        public byte? GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number In Stock")]
        [Required]
        [Range(1, 20)]
        public byte? NumberInStock { get; set; }

        public string Title
        {
           get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }
    }
}