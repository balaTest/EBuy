﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ebuy.Website.Models
{
    public class EbuyDataContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }
        
        public EbuyDataContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EbuyDataContext>());
        }
    }

    public class Auction
    {
        public long Id { get; set; }

        [Required]
        [StringLength(50,
          ErrorMessage = "Title cannot be longer than 50 characters")]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(1, 10000,
          ErrorMessage = "The auction's starting price must be at least 1")]
        public decimal StartPrice { get; set; }

        public decimal CurrentPrice { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

}