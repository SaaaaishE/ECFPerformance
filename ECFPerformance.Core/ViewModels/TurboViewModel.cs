﻿using ECFPerformance.Infrastructure.Data.Models.Engine;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECFPerformance.Core.ViewModels
{
    public class TurboViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Make { get; set; } = null!;

        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public string MainImage { get; set; } = null!;

        public TurboScrollType ScrollType { get; set; } = null!;
    }
}