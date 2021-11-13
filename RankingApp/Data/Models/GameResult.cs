﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RankingApp.Data.Models
{
    // DB를 위한 데이터
    public class GameResult
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }
}