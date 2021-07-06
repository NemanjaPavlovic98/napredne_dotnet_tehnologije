﻿using MoviesAPI.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [StringLength(50)]
        [FirstLetterUppercase]
        public string Name { get; set; }
    }
}
