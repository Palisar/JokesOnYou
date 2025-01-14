﻿using System;

namespace JokesOnYou.Web.Api.DTOs
{
    public class JokeDto
    {
        public int Id { get; set; }
        public string Premise { get; set; }
        public string Punchline { get; set; }
        public JokeAuthorDto Author { get; set; }
        public DateTime UploadDate { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}
